namespace TcpIp
{
    partial class frmCatraca
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
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblPorta = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtComando = new System.Windows.Forms.TextBox();
            this.btnSolicita = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnGira = new System.Windows.Forms.Button();
            this.btnNaoGira = new System.Windows.Forms.Button();
            this.btnFinaliza = new System.Windows.Forms.Button();
            this.btnLimparLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(24, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(265, 24);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "SIMULADOR DA CATRACA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(118, 121);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(81, 13);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Inicie a Catraca";
            // 
            // lblTituloStatus
            // 
            this.lblTituloStatus.AutoSize = true;
            this.lblTituloStatus.Location = new System.Drawing.Point(75, 121);
            this.lblTituloStatus.Name = "lblTituloStatus";
            this.lblTituloStatus.Size = new System.Drawing.Size(40, 13);
            this.lblTituloStatus.TabIndex = 18;
            this.lblTituloStatus.Text = "Status:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(234, 60);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(80, 21);
            this.btnIniciar.TabIndex = 17;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(121, 87);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(107, 20);
            this.txtPorta.TabIndex = 16;
            this.txtPorta.Text = "5000";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(121, 61);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(107, 20);
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
            this.lblPorta.Text = "Porta da Catraca:";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(40, 64);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(75, 13);
            this.lblServidor.TabIndex = 13;
            this.lblServidor.Text = "IP da Catraca:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(25, 157);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(89, 13);
            this.lblMatricula.TabIndex = 22;
            this.lblMatricula.Text = "Matricula/Cartão:";
            // 
            // txtComando
            // 
            this.txtComando.Location = new System.Drawing.Point(28, 199);
            this.txtComando.Name = "txtComando";
            this.txtComando.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComando.Size = new System.Drawing.Size(377, 20);
            this.txtComando.TabIndex = 21;
            // 
            // btnSolicita
            // 
            this.btnSolicita.Location = new System.Drawing.Point(28, 225);
            this.btnSolicita.Name = "btnSolicita";
            this.btnSolicita.Size = new System.Drawing.Size(125, 28);
            this.btnSolicita.TabIndex = 23;
            this.btnSolicita.Text = "Passar cartão";
            this.btnSolicita.UseVisualStyleBackColor = true;
            this.btnSolicita.Click += new System.EventHandler(this.btnSolicita_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(28, 277);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultado.Size = new System.Drawing.Size(377, 141);
            this.txtResultado.TabIndex = 24;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(25, 261);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(28, 13);
            this.lblResultado.TabIndex = 32;
            this.lblResultado.Text = "Log:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(28, 173);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMatricula.Size = new System.Drawing.Size(114, 20);
            this.txtMatricula.TabIndex = 34;
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtMatricula_TextChanged);
            // 
            // btnGira
            // 
            this.btnGira.Location = new System.Drawing.Point(159, 225);
            this.btnGira.Name = "btnGira";
            this.btnGira.Size = new System.Drawing.Size(125, 28);
            this.btnGira.TabIndex = 35;
            this.btnGira.Text = "Girar catraca";
            this.btnGira.UseVisualStyleBackColor = true;
            this.btnGira.Click += new System.EventHandler(this.btnGira_Click);
            // 
            // btnNaoGira
            // 
            this.btnNaoGira.Location = new System.Drawing.Point(290, 225);
            this.btnNaoGira.Name = "btnNaoGira";
            this.btnNaoGira.Size = new System.Drawing.Size(125, 28);
            this.btnNaoGira.TabIndex = 36;
            this.btnNaoGira.Text = "Não girar catraca";
            this.btnNaoGira.UseVisualStyleBackColor = true;
            this.btnNaoGira.Click += new System.EventHandler(this.btnNaoGira_Click);
            // 
            // btnFinaliza
            // 
            this.btnFinaliza.Location = new System.Drawing.Point(234, 86);
            this.btnFinaliza.Name = "btnFinaliza";
            this.btnFinaliza.Size = new System.Drawing.Size(80, 21);
            this.btnFinaliza.TabIndex = 37;
            this.btnFinaliza.Text = "Finalizar";
            this.btnFinaliza.UseVisualStyleBackColor = true;
            this.btnFinaliza.Click += new System.EventHandler(this.btnFinaliza_Click);
            // 
            // btnLimparLog
            // 
            this.btnLimparLog.Location = new System.Drawing.Point(280, 424);
            this.btnLimparLog.Name = "btnLimparLog";
            this.btnLimparLog.Size = new System.Drawing.Size(125, 28);
            this.btnLimparLog.TabIndex = 38;
            this.btnLimparLog.Text = "Limpar Log";
            this.btnLimparLog.UseVisualStyleBackColor = true;
            this.btnLimparLog.Click += new System.EventHandler(this.btnLimparLog_Click);
            // 
            // frmCatraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 460);
            this.Controls.Add(this.btnLimparLog);
            this.Controls.Add(this.btnFinaliza);
            this.Controls.Add(this.btnNaoGira);
            this.Controls.Add(this.btnGira);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
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
            this.Name = "frmCatraca";
            this.Text = "Simulador da Catraca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCatraca_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTituloStatus;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtComando;
        private System.Windows.Forms.Button btnSolicita;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnGira;
        private System.Windows.Forms.Button btnNaoGira;
        private System.Windows.Forms.Button btnFinaliza;
        private System.Windows.Forms.Button btnLimparLog;
    }
}