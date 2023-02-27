using ProjectFitness.Dominios;
using ProjectFitness.Interfaces_e_Respositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessProjectGP
{
    public partial class Login : Form
    {
        private bool LoginValidated = false;
        private bool SenhaValidated = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_Usuario_Validating(object sender, CancelEventArgs e)
        {
            if (!Usuario.ValidarLogin(txt_Login.Text))
            {
                ep_login.SetError(txt_Login, "login invalido");
            }
            else
            {
                if (!string.IsNullOrEmpty(ep_login.GetError(txt_Login)))
                {
                    ep_login.Clear();
                }
                LoginValidated = true;  
            }
        }

        private void txt_Senha_Validating(object sender, CancelEventArgs e)
        {
            if (!Usuario.ValidarLogin(txt_Senha.Text))
            {
                ep_senha.SetError(txt_Senha, "login invalido");
            }
            else
            {
                if (!string.IsNullOrEmpty(ep_senha.GetError(txt_Senha)))
                {
                    ep_senha.Clear();
                }
                SenhaValidated = true;  
            }
        }


        private void txt_Usuario_Validated(object sender, EventArgs e)
        {
            if(EnableButtonLogin())
            {
                btn_login.Enabled = true;
            }

        }

        private void txt_Senha_Validated(object sender, EventArgs e)
        {
            if(EnableButtonLogin())
            { 
                btn_login.Enabled = false; 
            }
        }

        private bool EnableButtonLogin()
        {
            return LoginValidated && SenhaValidated;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            RepositorioUsuario repositorioUsuario = new RepositorioUsuario();
            if (repositorioUsuario.AutenticarUsuario(txt_Login.Text, txt_Senha.Text))
            {
                this.Hide();

                Home frmhome = new Home();
                frmhome.Show();
            }
            else 
            {
                MessageBox.Show("Dados de login não existem, crie um novo utilizador!", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnk_NovoRegisto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ep_login.Clear();

            CadastroUsuario frmCadastroUsuario = new CadastroUsuario();

            frmCadastroUsuario.ShowDialog();

        }
    }
}
