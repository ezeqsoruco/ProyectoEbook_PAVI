namespace Ebook
{
    partial class LoginEbook
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
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.txtContraseniaLogin = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblContraseniaUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(173, 67);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(157, 20);
            this.txtUsuarioLogin.TabIndex = 0;
            // 
            // txtContraseniaLogin
            // 
            this.txtContraseniaLogin.Location = new System.Drawing.Point(173, 109);
            this.txtContraseniaLogin.Name = "txtContraseniaLogin";
            this.txtContraseniaLogin.Size = new System.Drawing.Size(157, 20);
            this.txtContraseniaLogin.TabIndex = 1;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(85, 70);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(82, 13);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "Ingrese usuario:";
            // 
            // lblContraseniaUsuario
            // 
            this.lblContraseniaUsuario.AutoSize = true;
            this.lblContraseniaUsuario.Location = new System.Drawing.Point(69, 112);
            this.lblContraseniaUsuario.Name = "lblContraseniaUsuario";
            this.lblContraseniaUsuario.Size = new System.Drawing.Size(101, 13);
            this.lblContraseniaUsuario.TabIndex = 3;
            this.lblContraseniaUsuario.Text = "Ingrese contraseña:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 261);
            this.Controls.Add(this.lblContraseniaUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.txtContraseniaLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtContraseniaLogin;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblContraseniaUsuario;
    }
}

