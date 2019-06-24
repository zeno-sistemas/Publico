namespace TcpIp
{
    partial class frmCatraca2
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
            this.btnLimparLog = new System.Windows.Forms.Button();
            this.btnFinaliza = new System.Windows.Forms.Button();
            this.btnNaoGira = new System.Windows.Forms.Button();
            this.btnGira = new System.Windows.Forms.Button();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnSolicita = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtComando = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTituloStatus = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblPorta = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimparLog
            // 
            this.btnLimparLog.Location = new System.Drawing.Point(278, 414);
            this.btnLimparLog.Name = "btnLimparLog";
            this.btnLimparLog.Size = new System.Drawing.Size(125, 28);
            this.btnLimparLog.TabIndex = 56;
            this.btnLimparLog.Text = "Limpar Log";
            this.btnLimparLog.UseVisualStyleBackColor = true;
            // 
            // btnFinaliza
            // 
            this.btnFinaliza.Location = new System.Drawing.Point(222, 76);
            this.btnFinaliza.Name = "btnFinaliza";
            this.btnFinaliza.Size = new System.Drawing.Size(80, 21);
            this.btnFinaliza.TabIndex = 55;
            this.btnFinaliza.Text = "Finalizar";
            this.btnFinaliza.UseVisualStyleBackColor = true;
            this.btnFinaliza.Click += new System.EventHandler(this.BtnFinaliza_Click);
            // 
            // btnNaoGira
            // 
            this.btnNaoGira.Location = new System.Drawing.Point(278, 215);
            this.btnNaoGira.Name = "btnNaoGira";
            this.btnNaoGira.Size = new System.Drawing.Size(125, 28);
            this.btnNaoGira.TabIndex = 54;
            this.btnNaoGira.Text = "Não girar catraca";
            this.btnNaoGira.UseVisualStyleBackColor = true;
            // 
            // btnGira
            // 
            this.btnGira.Location = new System.Drawing.Point(147, 215);
            this.btnGira.Name = "btnGira";
            this.btnGira.Size = new System.Drawing.Size(125, 28);
            this.btnGira.TabIndex = 53;
            this.btnGira.Text = "Girar catraca";
            this.btnGira.UseVisualStyleBackColor = true;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(16, 163);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMatricula.Size = new System.Drawing.Size(114, 20);
            this.txtMatricula.TabIndex = 52;
            this.txtMatricula.TextChanged += new System.EventHandler(this.TxtMatricula_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(13, 251);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(28, 13);
            this.lblResultado.TabIndex = 51;
            this.lblResultado.Text = "Log:";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(16, 267);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(387, 141);
            this.txtLog.TabIndex = 50;
            // 
            // btnSolicita
            // 
            this.btnSolicita.Location = new System.Drawing.Point(16, 215);
            this.btnSolicita.Name = "btnSolicita";
            this.btnSolicita.Size = new System.Drawing.Size(125, 28);
            this.btnSolicita.TabIndex = 49;
            this.btnSolicita.Text = "Passar cartão";
            this.btnSolicita.UseVisualStyleBackColor = true;
            this.btnSolicita.Click += new System.EventHandler(this.BtnSolicita_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(13, 147);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(89, 13);
            this.lblMatricula.TabIndex = 48;
            this.lblMatricula.Text = "Matricula/Cartão:";
            // 
            // txtComando
            // 
            this.txtComando.Location = new System.Drawing.Point(16, 189);
            this.txtComando.Name = "txtComando";
            this.txtComando.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComando.Size = new System.Drawing.Size(387, 20);
            this.txtComando.TabIndex = 47;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(265, 24);
            this.lblTitulo.TabIndex = 46;
            this.lblTitulo.Text = "SIMULADOR DA CATRACA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(106, 111);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(81, 13);
            this.lblStatus.TabIndex = 45;
            this.lblStatus.Text = "Inicie a Catraca";
            // 
            // lblTituloStatus
            // 
            this.lblTituloStatus.AutoSize = true;
            this.lblTituloStatus.Location = new System.Drawing.Point(63, 111);
            this.lblTituloStatus.Name = "lblTituloStatus";
            this.lblTituloStatus.Size = new System.Drawing.Size(40, 13);
            this.lblTituloStatus.TabIndex = 44;
            this.lblTituloStatus.Text = "Status:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(222, 50);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(80, 21);
            this.btnIniciar.TabIndex = 43;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(109, 77);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(107, 20);
            this.txtPorta.TabIndex = 42;
            this.txtPorta.Text = "5000";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(109, 51);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(107, 20);
            this.txtServidor.TabIndex = 41;
            this.txtServidor.Text = "192.168.1.54";
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Location = new System.Drawing.Point(13, 80);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(90, 13);
            this.lblPorta.TabIndex = 40;
            this.lblPorta.Text = "Porta da Catraca:";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(28, 54);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(75, 13);
            this.lblServidor.TabIndex = 39;
            this.lblServidor.Text = "IP da Catraca:";
            // 
            // frmCatraca2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 456);
            this.Controls.Add(this.btnLimparLog);
            this.Controls.Add(this.btnFinaliza);
            this.Controls.Add(this.btnNaoGira);
            this.Controls.Add(this.btnGira);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnSolicita);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtComando);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTituloStatus);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblPorta);
            this.Controls.Add(this.lblServidor);
            this.Name = "frmCatraca2";
            this.Text = "frmCatraca2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimparLog;
        private System.Windows.Forms.Button btnFinaliza;
        private System.Windows.Forms.Button btnNaoGira;
        private System.Windows.Forms.Button btnGira;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnSolicita;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtComando;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTituloStatus;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.Label lblServidor;
    }
}