namespace TcpIp
{
    partial class frmServidor
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
            this.lblServidor = new System.Windows.Forms.Label();
            this.lblPorta = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtRecebeBytes = new System.Windows.Forms.TextBox();
            this.lblRecebeBytes = new System.Windows.Forms.Label();
            this.lblEnviaBytes = new System.Windows.Forms.Label();
            this.txtEnviaBytes = new System.Windows.Forms.TextBox();
            this.btnResponderBytes = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblTituloStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnResponderString = new System.Windows.Forms.Button();
            this.lblEnviaString = new System.Windows.Forms.Label();
            this.txtEnviaString = new System.Windows.Forms.TextBox();
            this.lblRecebeString = new System.Windows.Forms.Label();
            this.txtRecebeString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(40, 64);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(75, 13);
            this.lblServidor.TabIndex = 0;
            this.lblServidor.Text = "IP do servidor:";
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Location = new System.Drawing.Point(25, 90);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(90, 13);
            this.lblPorta.TabIndex = 1;
            this.lblPorta.Text = "Porta do servidor:";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(121, 61);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(195, 20);
            this.txtServidor.TabIndex = 2;
            this.txtServidor.Text = "127.0.0.1";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(121, 87);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(53, 20);
            this.txtPorta.TabIndex = 3;
            this.txtPorta.Text = "5000";
            // 
            // txtRecebeBytes
            // 
            this.txtRecebeBytes.Location = new System.Drawing.Point(28, 202);
            this.txtRecebeBytes.Multiline = true;
            this.txtRecebeBytes.Name = "txtRecebeBytes";
            this.txtRecebeBytes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRecebeBytes.Size = new System.Drawing.Size(377, 105);
            this.txtRecebeBytes.TabIndex = 4;
            // 
            // lblRecebeBytes
            // 
            this.lblRecebeBytes.AutoSize = true;
            this.lblRecebeBytes.Location = new System.Drawing.Point(25, 186);
            this.lblRecebeBytes.Name = "lblRecebeBytes";
            this.lblRecebeBytes.Size = new System.Drawing.Size(85, 13);
            this.lblRecebeBytes.TabIndex = 5;
            this.lblRecebeBytes.Text = "Bytes recebidos:";
            // 
            // lblEnviaBytes
            // 
            this.lblEnviaBytes.AutoSize = true;
            this.lblEnviaBytes.Location = new System.Drawing.Point(25, 318);
            this.lblEnviaBytes.Name = "lblEnviaBytes";
            this.lblEnviaBytes.Size = new System.Drawing.Size(79, 13);
            this.lblEnviaBytes.TabIndex = 7;
            this.lblEnviaBytes.Text = "Bytes resposta:";
            // 
            // txtEnviaBytes
            // 
            this.txtEnviaBytes.Location = new System.Drawing.Point(28, 334);
            this.txtEnviaBytes.Multiline = true;
            this.txtEnviaBytes.Name = "txtEnviaBytes";
            this.txtEnviaBytes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEnviaBytes.Size = new System.Drawing.Size(377, 104);
            this.txtEnviaBytes.TabIndex = 6;
            // 
            // btnResponderBytes
            // 
            this.btnResponderBytes.Location = new System.Drawing.Point(291, 446);
            this.btnResponderBytes.Name = "btnResponderBytes";
            this.btnResponderBytes.Size = new System.Drawing.Size(114, 23);
            this.btnResponderBytes.TabIndex = 8;
            this.btnResponderBytes.Text = "Enviar Bytes";
            this.btnResponderBytes.UseVisualStyleBackColor = true;
            this.btnResponderBytes.Click += new System.EventHandler(this.btnResponderBytes_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(322, 60);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(83, 23);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblTituloStatus
            // 
            this.lblTituloStatus.AutoSize = true;
            this.lblTituloStatus.Location = new System.Drawing.Point(75, 121);
            this.lblTituloStatus.Name = "lblTituloStatus";
            this.lblTituloStatus.Size = new System.Drawing.Size(40, 13);
            this.lblTituloStatus.TabIndex = 10;
            this.lblTituloStatus.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(118, 121);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(83, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Inicie o Servidor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(24, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(114, 24);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "SERVIDOR";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnResponderString
            // 
            this.btnResponderString.Location = new System.Drawing.Point(678, 446);
            this.btnResponderString.Name = "btnResponderString";
            this.btnResponderString.Size = new System.Drawing.Size(114, 23);
            this.btnResponderString.TabIndex = 17;
            this.btnResponderString.Text = "Enviar String";
            this.btnResponderString.UseVisualStyleBackColor = true;
            this.btnResponderString.Click += new System.EventHandler(this.btnResponderString_Click);
            // 
            // lblEnviaString
            // 
            this.lblEnviaString.AutoSize = true;
            this.lblEnviaString.Location = new System.Drawing.Point(412, 318);
            this.lblEnviaString.Name = "lblEnviaString";
            this.lblEnviaString.Size = new System.Drawing.Size(80, 13);
            this.lblEnviaString.TabIndex = 16;
            this.lblEnviaString.Text = "String resposta:";
            // 
            // txtEnviaString
            // 
            this.txtEnviaString.Location = new System.Drawing.Point(415, 334);
            this.txtEnviaString.Multiline = true;
            this.txtEnviaString.Name = "txtEnviaString";
            this.txtEnviaString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEnviaString.Size = new System.Drawing.Size(377, 104);
            this.txtEnviaString.TabIndex = 15;
            // 
            // lblRecebeString
            // 
            this.lblRecebeString.AutoSize = true;
            this.lblRecebeString.Location = new System.Drawing.Point(412, 186);
            this.lblRecebeString.Name = "lblRecebeString";
            this.lblRecebeString.Size = new System.Drawing.Size(81, 13);
            this.lblRecebeString.TabIndex = 14;
            this.lblRecebeString.Text = "String recebida:";
            // 
            // txtRecebeString
            // 
            this.txtRecebeString.Location = new System.Drawing.Point(415, 202);
            this.txtRecebeString.Multiline = true;
            this.txtRecebeString.Name = "txtRecebeString";
            this.txtRecebeString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRecebeString.Size = new System.Drawing.Size(377, 105);
            this.txtRecebeString.TabIndex = 13;
            // 
            // frmServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 482);
            this.Controls.Add(this.btnResponderString);
            this.Controls.Add(this.lblEnviaString);
            this.Controls.Add(this.txtEnviaString);
            this.Controls.Add(this.lblRecebeString);
            this.Controls.Add(this.txtRecebeString);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTituloStatus);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnResponderBytes);
            this.Controls.Add(this.lblEnviaBytes);
            this.Controls.Add(this.txtEnviaBytes);
            this.Controls.Add(this.lblRecebeBytes);
            this.Controls.Add(this.txtRecebeBytes);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblPorta);
            this.Controls.Add(this.lblServidor);
            this.Name = "frmServidor";
            this.Text = "Servidor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServidor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtRecebeBytes;
        private System.Windows.Forms.Label lblRecebeBytes;
        private System.Windows.Forms.Label lblEnviaBytes;
        private System.Windows.Forms.TextBox txtEnviaBytes;
        private System.Windows.Forms.Button btnResponderBytes;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblTituloStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnResponderString;
        private System.Windows.Forms.Label lblEnviaString;
        private System.Windows.Forms.TextBox txtEnviaString;
        private System.Windows.Forms.Label lblRecebeString;
        private System.Windows.Forms.TextBox txtRecebeString;
    }
}

