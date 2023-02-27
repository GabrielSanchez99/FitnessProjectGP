namespace FitnessProjectGP
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnk_NovoRegisto = new System.Windows.Forms.LinkLabel();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.ep_login = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_senha = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ep_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_senha)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // lnk_NovoRegisto
            // 
            this.lnk_NovoRegisto.AutoSize = true;
            this.lnk_NovoRegisto.Location = new System.Drawing.Point(161, 135);
            this.lnk_NovoRegisto.Name = "lnk_NovoRegisto";
            this.lnk_NovoRegisto.Size = new System.Drawing.Size(97, 13);
            this.lnk_NovoRegisto.TabIndex = 2;
            this.lnk_NovoRegisto.TabStop = true;
            this.lnk_NovoRegisto.Text = "Criar novo Registro";
            this.lnk_NovoRegisto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_NovoRegisto_LinkClicked);
            // 
            // txt_Login
            // 
            this.txt_Login.Location = new System.Drawing.Point(120, 63);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(177, 20);
            this.txt_Login.TabIndex = 3;
            this.txt_Login.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Usuario_Validating);
            this.txt_Login.Validated += new System.EventHandler(this.txt_Usuario_Validated);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(120, 102);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(177, 20);
            this.txt_Senha.TabIndex = 4;
            this.txt_Senha.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Senha_Validating);
            this.txt_Senha.Validated += new System.EventHandler(this.txt_Senha_Validated);
            // 
            // btn_login
            // 
            this.btn_login.Enabled = false;
            this.btn_login.Location = new System.Drawing.Point(164, 175);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // ep_login
            // 
            this.ep_login.ContainerControl = this;
            // 
            // ep_senha
            // 
            this.ep_senha.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FitnessProjectGP.Properties.Resources.FITNESS_WEB_SITE_VS1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(385, 303);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.lnk_NovoRegisto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_senha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnk_NovoRegisto;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ErrorProvider ep_login;
        private System.Windows.Forms.ErrorProvider ep_senha;
    }
}

