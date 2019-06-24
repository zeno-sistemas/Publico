using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace TcpIp
{
    public class ServidorTcpIp
    {
        private static TcpListener tcpServidor;
        public static Hashtable nomeIdentificador;
        public static Hashtable nomeIdentificadorDaConexao;
        public static bool executar = true;

        public ServidorTcpIp()
        {
            nomeIdentificador = new Hashtable(100);
            nomeIdentificadorDaConexao = new Hashtable(100);
        }

        public void IniciarServidorTcpIp(string ip, int porta)
        {
            Thread tcpThread = new Thread(() => ExecutarMonitoramento(ip, porta));
            tcpThread.IsBackground = true;
            tcpThread.Start();
        }

        private void ExecutarMonitoramento(string ip, int porta)
        {
            tcpServidor = new TcpListener(IPAddress.Parse(ip), porta);
            while (executar)
            {
                tcpServidor.Start();
                if (tcpServidor.Pending())
                {
                    TcpClient chatConnection = tcpServidor.AcceptTcpClient();
                    Console.WriteLine("CONEXAO:Conectado");
                    IniciaComunicacao comm = new IniciaComunicacao(chatConnection);
                }
            }
            EncerraClientes();
            tcpServidor.Stop();
        }

        public void EncerraClientes()
        {
            RemoveClientesInativos();
            TcpClient[] tcpCliente = new TcpClient[nomeIdentificador.Count];
            try
            {
                for (int cnt = 0; cnt < tcpCliente.Length; cnt++)
                {
                    tcpCliente[cnt].Close();
                }
            }
            catch (Exception)
            {

            }
        }

        private static void RemoveClientesInativos()
        {
            TcpClient[] tcpCliente = new TcpClient[nomeIdentificador.Count];
            nomeIdentificador.Values.CopyTo(tcpCliente, 0);
            try
            {
                for (int cnt = 0; cnt < tcpCliente.Length; cnt++)
                {
                    if (!tcpCliente[cnt].Client.Connected)
                    {
                        var port = ((IPEndPoint)tcpCliente[cnt].Client.RemoteEndPoint).Port;
                        var ip = ((IPEndPoint)tcpCliente[cnt].Client.RemoteEndPoint).Address.ToString();
                        nomeIdentificador.Remove(ip + ":" + port);
                    }
                }
                tcpCliente = new TcpClient[nomeIdentificador.Count];
                nomeIdentificador.Values.CopyTo(tcpCliente, 0);
            }
            catch (Exception)
            {
            }
        }

        public static void EnviaMensagemParaTodos(string msg)
        {
            if (tcpServidor == null) return;

            StreamWriter writer;
            ArrayList ToRemove = new ArrayList(0);
            RemoveClientesInativos();
            TcpClient[] tcpCliente = new TcpClient[nomeIdentificador.Count];
            nomeIdentificador.Values.CopyTo(tcpCliente, 0);

            for (int cnt = 0; cnt < tcpCliente.Length; cnt++)
            {
                if (tcpCliente[cnt].Client.Connected)
                {
                    try
                    {
                        if (msg.Trim() == "" || tcpCliente[cnt] == null) continue;
                        writer = new StreamWriter(tcpCliente[cnt].GetStream());
                        writer.WriteLine(msg);
                        writer.Flush();
                        writer = null;
                    }
                    catch (SocketException)
                    {
                        nomeIdentificador.Remove(nomeIdentificadorDaConexao[tcpCliente[cnt]]);
                        nomeIdentificadorDaConexao.Remove(tcpCliente[cnt]);
                    }
                    catch (Exception)
                    {
                        nomeIdentificador.Remove(nomeIdentificadorDaConexao[tcpCliente[cnt]]);
                        nomeIdentificadorDaConexao.Remove(tcpCliente[cnt]);
                    }
                }
            }
        }

        public static bool VerificarEncerramento()
        {
            return executar;
        }

        public void EnviarEncerramento(bool encerramento)
        {
            executar = encerramento;
        }
        public static int QuantidadeConexoesAtivas()
        {
            RemoveClientesInativos();
            return nomeIdentificador.Count;
        }

    }


    class IniciaComunicacao
    {
        TcpClient cliente;
        StreamReader reader;
        StreamWriter writer;
        string nomeIdentificador;
        public bool executar = true;

        public IniciaComunicacao(TcpClient tcpClient)
        {
            cliente = tcpClient;
            Thread tcpIpThread = new Thread(new ThreadStart(IniciaComunicacaoTcpip));
            tcpIpThread.Start();
        }


        private void IniciaComunicacaoTcpip()
        {
            var port = ((IPEndPoint)cliente.Client.RemoteEndPoint).Port;
            var ip = ((IPEndPoint)cliente.Client.RemoteEndPoint).Address;
            nomeIdentificador = ip.ToString() + ":" + port;
            reader = new StreamReader(cliente.GetStream());
            writer = new StreamWriter(cliente.GetStream());
            writer.WriteLine("MSG:Conectado");
            ServidorTcpIp.nomeIdentificador.Add(nomeIdentificador, cliente);
            ServidorTcpIp.nomeIdentificadorDaConexao.Add(cliente, nomeIdentificador);
            writer.Flush();
            Thread tcpIpThread = new Thread(new ThreadStart(MonitoraMensagens));
            tcpIpThread.Start();
        }

        private void MonitoraMensagens()
        {
            try
            {
                string texto = "";
                while (executar)
                {
                    texto = reader.ReadLine();
                    ServidorTcpIp.EnviaMensagemParaTodos(texto);
                    executar = ServidorTcpIp.VerificarEncerramento();
                    if (ServidorTcpIp.QuantidadeConexoesAtivas() <= 0) return;
                }
            }
            catch (Exception e44)
            {
                Console.WriteLine(e44);
            }
        }
    }
}
