namespace TcpIp
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTituloStatus = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblPorta = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.lblEnviaString = new System.Windows.Forms.Label();
            this.txtEnviaString = new System.Windows.Forms.TextBox();
            this.btnResponderString = new System.Windows.Forms.Button();
            this.btnLimparLog = new System.Windows.Forms.Button();
            this.radEventos1 = new System.Windows.Forms.RadioButton();
            this.radEventos2 = new System.Windows.Forms.RadioButton();
            this.radEventos3 = new System.Windows.Forms.RadioButton();
            this.radEventos4 = new System.Windows.Forms.RadioButton();
            this.txtMensagem1 = new System.Windows.Forms.TextBox();
            this.txtMensagem2 = new System.Windows.Forms.TextBox();
            this.lblMsg1 = new System.Windows.Forms.Label();
            this.lblMsg2 = new System.Windows.Forms.Label();
            this.btnLimpaResposta = new System.Windows.Forms.Button();
            this.btnPreparaEnvio = new System.Windows.Forms.Button();
            this.numTempo = new System.Windows.Forms.NumericUpDown();
            this.lblTempo = new System.Windows.Forms.Label();
            this.chkRele1 = new System.Windows.Forms.CheckBox();
            this.chkRele2 = new System.Windows.Forms.CheckBox();
            this.chkRele3 = new System.Windows.Forms.CheckBox();
            this.btnFinaliza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(24, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(96, 24);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "CLIENTE";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(118, 121);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(83, 13);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Inicie o Servidor";
            // 
            // lblTituloStatus
            // 
            this.lblTituloStatus.AutoSize = true;
            this.lblTituloStatus.Location = new System.Drawing.Point(75, 121);
            this.lblTituloStatus.Name = "lblTituloStatus";
            this.lblTituloStatus.Size = new System.Drawing.Size(40, 13);
            this.lblTituloStatus.TabIndex = 23;
            this.lblTituloStatus.Text = "Status:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(224, 60);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(83, 21);
            this.btnIniciar.TabIndex = 22;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(25, 287);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(28, 13);
            this.lblLog.TabIndex = 18;
            this.lblLog.Text = "Log:";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(28, 303);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(667, 242);
            this.txtLog.TabIndex = 17;
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(121, 87);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(97, 20);
            this.txtPorta.TabIndex = 16;
            this.txtPorta.Text = "5000";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(121, 61);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(97, 20);
            this.txtServidor.TabIndex = 15;
            this.txtServidor.Text = "192.168.1.54";
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Location = new System.Drawing.Point(25, 90);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(90, 13);
            this.lblPorta.TabIndex = 14;
            this.lblPorta.Text = "Porta do servidor:";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(40, 64);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(75, 13);
            this.lblServidor.TabIndex = 13;
            this.lblServidor.Text = "IP do servidor:";
            // 
            // lblEnviaString
            // 
            this.lblEnviaString.AutoSize = true;
            this.lblEnviaString.Location = new System.Drawing.Point(25, 181);
            this.lblEnviaString.Name = "lblEnviaString";
            this.lblEnviaString.Size = new System.Drawing.Size(85, 13);
            this.lblEnviaString.TabIndex = 29;
            this.lblEnviaString.Text = "String Resposta:";
            // 
            // txtEnviaString
            // 
            this.txtEnviaString.Location = new System.Drawing.Point(28, 197);
            this.txtEnviaString.Multiline = true;
            this.txtEnviaString.Name = "txtEnviaString";
            this.txtEnviaString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEnviaString.Size = new System.Drawing.Size(547, 81);
            this.txtEnviaString.TabIndex = 28;
            // 
            // btnResponderString
            // 
            this.btnResponderString.Location = new System.Drawing.Point(581, 255);
            this.btnResponderString.Name = "btnResponderString";
            this.btnResponderString.Size = new System.Drawing.Size(114, 23);
            this.btnResponderString.TabIndex = 30;
            this.btnResponderString.Text = "Enviar Resposta";
            this.btnResponderString.UseVisualStyleBackColor = true;
            this.btnResponderString.Click += new System.EventHandler(this.btnResponderString_Click);
            // 
            // btnLimparLog
            // 
            this.btnLimparLog.Location = new System.Drawing.Point(581, 551);
            this.btnLimparLog.Name = "btnLimparLog";
            this.btnLimparLog.Size = new System.Drawing.Size(114, 23);
            this.btnLimparLog.TabIndex = 31;
            this.btnLimparLog.Text = "Limpar Log";
            this.btnLimparLog.UseVisualStyleBackColor = true;
            this.btnLimparLog.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // radEventos1
            // 
            this.radEventos1.AutoSize = true;
            this.radEventos1.Location = new System.Drawing.Point(460, 20);
            this.radEventos1.Name = "radEventos1";
            this.radEventos1.Size = new System.Drawing.Size(94, 17);
            this.radEventos1.TabIndex = 32;
            this.radEventos1.TabStop = true;
            this.radEventos1.Text = "Libera Entrada";
            this.radEventos1.UseVisualStyleBackColor = true;
            // 
            // radEventos2
            // 
            this.radEventos2.AutoSize = true;
            this.radEventos2.Location = new System.Drawing.Point(460, 43);
            this.radEventos2.Name = "radEventos2";
            this.radEventos2.Size = new System.Drawing.Size(86, 17);
            this.radEventos2.TabIndex = 33;
            this.radEventos2.TabStop = true;
            this.radEventos2.Text = "Libera Saída";
            this.radEventos2.UseVisualStyleBackColor = true;
            // 
            // radEventos3
            // 
            this.radEventos3.AutoSize = true;
            this.radEventos3.Location = new System.Drawing.Point(594, 19);
            this.radEventos3.Name = "radEventos3";
            this.radEventos3.Size = new System.Drawing.Size(89, 17);
            this.radEventos3.TabIndex = 34;
            this.radEventos3.TabStop = true;
            this.radEventos3.Text = "Libera Ambos";
            this.radEventos3.UseVisualStyleBackColor = true;
            // 
            // radEventos4
            // 
            this.radEventos4.AutoSize = true;
            this.radEventos4.Location = new System.Drawing.Point(594, 43);
            this.radEventos4.Name = "radEventos4";
            this.radEventos4.Size = new System.Drawing.Size(101, 17);
            this.radEventos4.TabIndex = 35;
            this.radEventos4.TabStop = true;
            this.radEventos4.Text = "Acesso Negado";
            this.radEventos4.UseVisualStyleBackColor = true;
            // 
            // txtMensagem1
            // 
            this.txtMensagem1.Location = new System.Drawing.Point(461, 84);
            this.txtMensagem1.Name = "txtMensagem1";
            this.txtMensagem1.Size = new System.Drawing.Size(234, 20);
            this.txtMensagem1.TabIndex = 37;
            this.txtMensagem1.Text = "Liberado";
            // 
            // txtMensagem2
            // 
            this.txtMensagem2.Location = new System.Drawing.Point(461, 107);
            this.txtMensagem2.Name = "txtMensagem2";
            this.txtMensagem2.Size = new System.Drawing.Size(234, 20);
            this.txtMensagem2.TabIndex = 38;
            // 
            // lblMsg1
            // 
            this.lblMsg1.AutoSize = true;
            this.lblMsg1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMsg1.Location = new System.Drawing.Point(390, 87);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(71, 13);
            this.lblMsg1.TabIndex = 39;
            this.lblMsg1.Text = "Mensagem 1:";
            this.lblMsg1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMsg2
            // 
            this.lblMsg2.AutoSize = true;
            this.lblMsg2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMsg2.Location = new System.Drawing.Point(390, 110);
            this.lblMsg2.Name = "lblMsg2";
            this.lblMsg2.Size = new System.Drawing.Size(71, 13);
            this.lblMsg2.TabIndex = 40;
            this.lblMsg2.Text = "Mensagem 2:";
            this.lblMsg2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLimpaResposta
            // 
            this.btnLimpaResposta.Location = new System.Drawing.Point(581, 226);
            this.btnLimpaResposta.Name = "btnLimpaResposta";
            this.btnLimpaResposta.Size = new System.Drawing.Size(114, 23);
            this.btnLimpaResposta.TabIndex = 41;
            this.btnLimpaResposta.Text = "Limpar Resposta";
            this.btnLimpaResposta.UseVisualStyleBackColor = true;
            this.btnLimpaResposta.Click += new System.EventHandler(this.btnLimpaResposta_Click);
            // 
            // btnPreparaEnvio
            // 
            this.btnPreparaEnvio.Location = new System.Drawing.Point(581, 197);
            this.btnPreparaEnvio.Name = "btnPreparaEnvio";
            this.btnPreparaEnvio.Size = new System.Drawing.Size(114, 23);
            this.btnPreparaEnvio.TabIndex = 42;
            this.btnPreparaEnvio.Text = "Montar Resposta";
            this.btnPreparaEnvio.UseVisualStyleBackColor = true;
            this.btnPreparaEnvio.Click += new System.EventHandler(this.btnPreparaEnvio_Click);
            // 
            // numTempo
            // 
            this.numTempo.Location = new System.Drawing.Point(461, 130);
            this.numTempo.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numTempo.Name = "numTempo";
            this.numTempo.Size = new System.Drawing.Size(56, 20);
            this.numTempo.TabIndex = 43;
            this.numTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTempo.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTempo.Location = new System.Drawing.Point(338, 133);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(123, 13);
            this.lblTempo.TabIndex = 44;
            this.lblTempo.Text = "Tempo de Acionamento:";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkRele1
            // 
            this.chkRele1.AutoSize = true;
            this.chkRele1.Location = new System.Drawing.Point(460, 159);
            this.chkRele1.Name = "chkRele1";
            this.chkRele1.Size = new System.Drawing.Size(57, 17);
            this.chkRele1.TabIndex = 45;
            this.chkRele1.Text = "Relê 1";
            this.chkRele1.UseVisualStyleBackColor = true;
            // 
            // chkRele2
            // 
            this.chkRele2.AutoSize = true;
            this.chkRele2.Location = new System.Drawing.Point(550, 159);
            this.chkRele2.Name = "chkRele2";
            this.chkRele2.Size = new System.Drawing.Size(57, 17);
            this.chkRele2.TabIndex = 46;
            this.chkRele2.Text = "Relê 2";
            this.chkRele2.UseVisualStyleBackColor = true;
            // 
            // chkRele3
            // 
            this.chkRele3.AutoSize = true;
            this.chkRele3.Location = new System.Drawing.Point(638, 159);
            this.chkRele3.Name = "chkRele3";
            this.chkRele3.Size = new System.Drawing.Size(57, 17);
            this.chkRele3.TabIndex = 47;
            this.chkRele3.Text = "Relê 3";
            this.chkRele3.UseVisualStyleBackColor = true;
            // 
            // btnFinaliza
            // 
            this.btnFinaliza.Location = new System.Drawing.Point(224, 86);
            this.btnFinaliza.Name = "btnFinaliza";
            this.btnFinaliza.Size = new System.Drawing.Size(83, 21);
            this.btnFinaliza.TabIndex = 48;
            this.btnFinaliza.Text = "Finalizar";
            this.btnFinaliza.UseVisualStyleBackColor = true;
            this.btnFinaliza.Click += new System.EventHandler(this.btnFinaliza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(458, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Caracteres 16x2 ou 24x2 (gráfico)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 22);
            this.button1.TabIndex = 50;
            this.button1.Text = "testar conectividade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 22);
            this.button2.TabIndex = 51;
            this.button2.Text = "Captura de string";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 592);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinaliza);
            this.Controls.Add(this.chkRele3);
            this.Controls.Add(this.chkRele2);
            this.Controls.Add(this.chkRele1);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.numTempo);
            this.Controls.Add(this.btnPreparaEnvio);
            this.Controls.Add(this.btnLimpaResposta);
            this.Controls.Add(this.lblMsg2);
            this.Controls.Add(this.lblMsg1);
            this.Controls.Add(this.txtMensagem2);
            this.Controls.Add(this.txtMensagem1);
            this.Controls.Add(this.radEventos4);
            this.Controls.Add(this.radEventos3);
            this.Controls.Add(this.radEventos2);
            this.Controls.Add(this.radEventos1);
            this.Controls.Add(this.btnLimparLog);
            this.Controls.Add(this.btnResponderString);
            this.Controls.Add(this.lblEnviaString);
            this.Controls.Add(this.txtEnviaString);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTituloStatus);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblPorta);
            this.Controls.Add(this.lblServidor);
            this.Name = "frmCliente";
            this.Text = "Cliente Controlador";
            ((System.ComponentModel.ISupportInitialize)(this.numTempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTituloStatus;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Label lblEnviaString;
        private System.Windows.Forms.TextBox txtEnviaString;
        private System.Windows.Forms.Button btnResponderString;
        private System.Windows.Forms.Button btnLimparLog;
        private System.Windows.Forms.RadioButton radEventos1;
        private System.Windows.Forms.RadioButton radEventos2;
        private System.Windows.Forms.RadioButton radEventos3;
        private System.Windows.Forms.RadioButton radEventos4;
        private System.Windows.Forms.TextBox txtMensagem1;
        private System.Windows.Forms.TextBox txtMensagem2;
        private System.Windows.Forms.Label lblMsg1;
        private System.Windows.Forms.Label lblMsg2;
        private System.Windows.Forms.Button btnLimpaResposta;
        private System.Windows.Forms.Button btnPreparaEnvio;
        private System.Windows.Forms.NumericUpDown numTempo;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.CheckBox chkRele1;
        private System.Windows.Forms.CheckBox chkRele2;
        private System.Windows.Forms.CheckBox chkRele3;
        private System.Windows.Forms.Button btnFinaliza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}