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
    public partial class CadastroUsuario : Form
    {

        private bool NomeValidated = false;
        private bool LoginValidated = false;
        private bool EmailValidated = false;
        private bool SenhaValidated = false;
        private bool ConfirmacaoValidated = false;




        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {
            if(!Usuario.Validarnome(txt_Nome.Text))
            {
                ep_NovoUsuario.SetError(txt_Nome, "Nome Invalido");
            }
            else
            {
                if(!string.IsNullOrEmpty(ep_NovoUsuario.GetError(txt_Nome)))
                {
                    ep_NovoUsuario.Clear();
                }
                LoginValidated = true;
            }

            btn_Adicionar.Enabled = EnableButtonAdicionar();
        }

        private void txt(object sender, EventArgs e)
        {

        }

        private void txt_Login_TxtChanged(object sender, EventArgs e)
        {
            if (!Usuario.Validarnome(txt_Login.Text))
            {
                ep_NovoUsuario.SetError(txt_Login, "Login Invalido");
            }
            else
            {
                if (!string.IsNullOrEmpty(ep_NovoUsuario.GetError(txt_Login)))
                {
                    ep_NovoUsuario.Clear();
                }
                LoginValidated = true;
            }
            btn_Adicionar.Enabled = EnableButtonAdicionar();
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            if (!Usuario.Validarnome(txt_Email.Text))
            {
                ep_NovoUsuario.SetError(txt_Email, "Email Invalido");
            }
            else
            {
                if (!string.IsNullOrEmpty(ep_NovoUsuario.GetError(txt_Email)))
                {
                    ep_NovoUsuario.Clear();
                }
                EmailValidated = true;
            }

            btn_Adicionar.Enabled = EnableButtonAdicionar();
        }

        private void txt_Senha_TextChanged(object sender, EventArgs e)
        {
            if (!Usuario.Validarnome(txt_Senha.Text))
            {
                ep_NovoUsuario.SetError(txt_Senha, "Senha Invalido");
            }
            else
            {
                if (!string.IsNullOrEmpty(ep_NovoUsuario.GetError(txt_Email)))
                {
                    ep_NovoUsuario.Clear();
                }
                SenhaValidated = true;
            }

            btn_Adicionar.Enabled = EnableButtonAdicionar();
        }

        private void txt_ConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            if (!Usuario.Validarnome(txt_Confirmacaosenha.Text))
            {
                ep_NovoUsuario.SetError(txt_Confirmacaosenha, "Senha Invalido");
            }
            else
            {
                if (!string.IsNullOrEmpty(ep_NovoUsuario.GetError(txt_Confirmacaosenha)))
                {
                    ep_NovoUsuario.Clear();
                }
               ConfirmacaoValidated = true;
            }

            btn_Adicionar.Enabled = EnableButtonAdicionar();
        }


        private bool EnableButtonAdicionar()
        {
            return NomeValidated && LoginValidated && EmailValidated && SenhaValidated && ConfirmacaoValidated;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            RepositorioUsuario repositorio = new RepositorioUsuario();
            var usuario = repositorio.ObterPorLogin(txt_Login.Text);
            if (usuario != null) 
            {
                MessageBox.Show("Login já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var novoUsuario = Usuario.CreateNew(txt_Nome.Text, txt_Login.Text, txt_Senha.Text, txt_Email.Text);

                if (repositorio.AdicionarUsuario(novoUsuario))
                {
                    MessageBox.Show("Usuario cadastrado com sucesso", "Cadastro de novo utilizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
