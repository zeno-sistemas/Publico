using System;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace TcpIp
{
    public class ClienteTcpIp
    {
        public string resultado;
        private TcpClient tcpCliente;
        public event EventHandler Cliente_Change;
        public bool executar = true;
        private string endereco;
        private int porta;

        public void AtualizaStatus(int x)
        {
            OnThresholdReached(EventArgs.Empty);
        }

        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = Cliente_Change;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void Conectar()
        {
            string resultadoAnterior = "";
            try
            {
                while (executar)
                {
                    if (ConexaoAtiva())
                    {
                        StreamReader reader = new StreamReader(tcpCliente.GetStream());
                        resultado = (reader.ReadLine());
                        AtualizaStatus(0);
                    }
                    else
                    {
                        if (!resultadoAnterior.Equals(resultado))
                        {
                            resultado = "ERRO:Off-Line";
                            AtualizaStatus(0);
                            resultadoAnterior = resultado;
                        }
                        Thread.Sleep(10);
                        //Iniciar(endereco, porta);
                        Application.DoEvents();
                        return;
                    }
                    Application.DoEvents();
                }
            }
            catch (Exception)
            {
                resultado = "ERRO:Off-Line";
                AtualizaStatus(0);
            }
            
        }

        private bool ConexaoAtiva()
        {
            bool retorno = true;
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnections = ipProperties.GetActiveTcpConnections().Where(x => x.LocalEndPoint.Equals(tcpCliente.Client.LocalEndPoint) && x.RemoteEndPoint.Equals(tcpCliente.Client.RemoteEndPoint)).ToArray();

            if (tcpConnections != null && tcpConnections.Length > 0)
            {
                TcpState stateOfConnection = tcpConnections.First().State;
                if (stateOfConnection != TcpState.Established)
                {
                    retorno = false;
                }
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }

        public void EnviarMensagem(string msg)
        {
            try
            {
                if (ConexaoAtiva())
                {
                    StreamWriter writer = new StreamWriter(tcpCliente.GetStream());
                    writer.WriteLine(msg);
                    writer.Flush();
                }
                else
                {
                    Conectar();
                }
            }
            catch (Exception)
            {
                resultado = "ERRO:Off-Line";
                AtualizaStatus(0);
            }
        }

        public void Iniciar(string _endereco, int _porta)
        {
            endereco = _endereco;
            porta = _porta;
            try
            {
                tcpCliente = new TcpClient();
                tcpCliente.Connect(endereco, porta);

                Thread chatThread = new Thread(() => Conectar());
                chatThread.IsBackground = true;
                chatThread.Start();
            }
            catch (SocketException)
            {
                resultado = "ERRO:Off-Line";
                AtualizaStatus(0);
            }
        }

        public void FecharConeccao()
        {
            try
            {
                if (tcpCliente == null) return;
                tcpCliente.Client.Disconnect(false);
            }
            catch (Exception)
            {

            }   
        }

        //public bool IsConnected(this Socket client)
        //{
        //    // This is how you can determine whether a socket is still connected.
        //    bool blockingState = client.Blocking;
        //    try
        //    {
        //        byte[] tmp = new byte[1];

        //        client.Blocking = false;
        //        client.Send(tmp, 0, 0);
        //        return true;
        //    }
        //    catch (SocketException e)
        //    {
        //        // 10035 == WSAEWOULDBLOCK
        //        if (e.NativeErrorCode.Equals(10035))
        //            return true;
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    finally
        //    {
        //        client.Blocking = blockingState;
        //    }
        //}
    }
}
