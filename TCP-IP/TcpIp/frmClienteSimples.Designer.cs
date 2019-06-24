namespace TcpIp
{
    partial class frmClienteSimples
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblPorta = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblEnviaString = new System.Windows.Forms.Label();
            this.txtEnviaString = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimparLog
            // 
            this.btnLimparLog.Location = new System.Drawing.Point(342, 394);
            this.btnLimparLog.Name = "btnLimparLog";
            this.btnLimparLog.Size = new System.Drawing.Size(114, 23);
            this.btnLimparLog.TabIndex = 73;
            this.btnLimparLog.Text = "Limpar Log";
            this.btnLimparLog.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(10, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(96, 24);
            this.lblTitulo.TabIndex = 71;
            this.lblTitulo.Text = "CLIENTE";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 192);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(444, 196);
            this.txtLog.TabIndex = 70;
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(107, 79);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(97, 20);
            this.txtPorta.TabIndex = 69;
            this.txtPorta.Text = "5000";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(107, 53);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(97, 20);
            this.txtServidor.TabIndex = 68;
            this.txtServidor.Text = "192.168.1.54";
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Location = new System.Drawing.Point(11, 82);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(90, 13);
            this.lblPorta.TabIndex = 67;
            this.lblPorta.Text = "Porta do servidor:";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(26, 56);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(75, 13);
            this.lblServidor.TabIndex = 66;
            this.lblServidor.Text = "IP do servidor:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(352, 119);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(104, 23);
            this.btnEnviar.TabIndex = 77;
            this.btnEnviar.Text = "Enviar Comando";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // lblEnviaString
            // 
            this.lblEnviaString.AutoSize = true;
            this.lblEnviaString.Location = new System.Drawing.Point(11, 105);
            this.lblEnviaString.Name = "lblEnviaString";
            this.lblEnviaString.Size = new System.Drawing.Size(55, 13);
            this.lblEnviaString.TabIndex = 76;
            this.lblEnviaString.Text = "Comando:";
            // 
            // txtEnviaString
            // 
            this.txtEnviaString.Location = new System.Drawing.Point(14, 121);
            this.txtEnviaString.Multiline = true;
            this.txtEnviaString.Name = "txtEnviaString";
            this.txtEnviaString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEnviaString.Size = new System.Drawing.Size(332, 51);
            this.txtEnviaString.TabIndex = 75;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(11, 176);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(28, 13);
            this.lblLog.TabIndex = 74;
            this.lblLog.Text = "Log:";
            // 
            // frmClienteSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 436);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblEnviaString);
            this.Controls.Add(this.txtEnviaString);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.btnLimparLog);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblPorta);
            this.Controls.Add(this.lblServidor);
            this.Name = "frmClienteSimples";
            this.Text = "frmClienteSimples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimparLog;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblEnviaString;
        private System.Windows.Forms.TextBox txtEnviaString;
        private System.Windows.Forms.Label lblLog;
    }
}