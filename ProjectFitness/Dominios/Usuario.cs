using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFitness.Dominios
{
    public class Usuario
    {
        public int Id { get; private set; }

        public string Nome { get; private set; }

        public string Login { get; private set; }

        public string Email { get; private set; }

        public string Senha { get; private set; }

        public DateTime DataCriacao { get; private set; }


        private Usuario(string nome, string login, string senha, string email, DateTime? datacriacao, int id)
        {
            Id = id;
            Nome = nome;
            Login = login;
            Senha = senha;
            Email = email;
            DataCriacao = datacriacao ?? DateTime.Now;
        }

        public static Usuario CreateNew(string nome, string login, string senha, string email, DateTime? datacriacao = null, int id = 0)
        {
            return new Usuario(nome, login, senha, email, datacriacao, id);
        }

        public static bool Validarnome(string nome)
        {
            var isValid = true;

            if (string.IsNullOrEmpty(nome) || nome.Trim().Length < 3)
            {
                isValid = false;
            }

            return isValid;
        }

        public static bool ValidarLogin(string login)
        {
            var isValid = true;

            if (string.IsNullOrEmpty(login) || login.Trim().Length < 3)
            {
                isValid = false;
            }

            return isValid;
        }


        public static bool ValidarEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email); ;
        }

        public static bool ValidarSenha(string senha)
        {
            var isValid = true;

            if (string.IsNullOrEmpty(senha) || senha.Trim().Length < 5)
            {
                isValid = false;
            }

            return isValid;
        }

        public static bool ValidarConfirmarSenha(string senha, string confirmacao)
        {
            var isValid = true;

            if (!senha.Equals(confirmacao))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
 