using ProjectFitness.Dominios;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFitness.Interfaces_e_Respositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private const string Conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sarab\\source\\repos\\FitnessProjectGP\\ProjectFitness\\BaseDeDados\\BaseDeDadosFit.mdf;Integrated Security=True";
  
        public bool AdicionarUsuario(Usuario usuario)
        {
            var novoUsuarioAdicionado = false;

            using (SqlConnection conn = new SqlConnection((Conexao)))
            {
                //Instrução SQL de inserção
                string sql = "INSERT INTO Usuario (Nome, Login, Senha, Email, DataCriacao)" +
                            "VALEUS (@Nome, @Login, @Senha, @Email, @DataCriacao)";
    
                SqlCommand comandos = new  SqlCommand(sql, conn);
                comandos.Parameters.AddWithValue("@Nome", usuario.Nome);
                comandos.Parameters.AddWithValue("@Login", usuario.Login);
                comandos.Parameters.AddWithValue("@Senha", usuario.Senha);
                comandos.Parameters.AddWithValue("@Email", usuario.Email);
                comandos.Parameters.AddWithValue("@DataCiacao", usuario.DataCriacao);

                //abre a conexão com o banco de dados
                conn.Open();

                /* os comanados referidos acima são para execução da Query e a mesma ira
                ira a a executar as instruções para o SQL como atualizar, inserir, excluir
                Ao executar a mesma ira a retornar o numero de linhas que foram efetuadas
                */

                var result = comandos.ExecuteNonQuery();
                if (result > 0)
                {
                    novoUsuarioAdicionado = true;
                }
                // feha a conexãoso com o banco de dados
                conn.Close();
            }

            return novoUsuarioAdicionado;
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public bool AutenticarUsuario(string login, string senha)
        {
            var registo = 0;

            using (SqlConnection conn = new SqlConnection(Conexao))
            {
                string sql = "SELECT Id FROM Usuario WHERE Login = @Login And Senha = @Senha ";

                SqlCommand comandos = new SqlCommand(sql, conn);
                comandos.Parameters.AddWithValue("@Login", login);
                comandos.Parameters.AddWithValue("@Senha", senha);

                conn.Open();

                var result = comandos.ExecuteNonQuery();
                if (result != null)
                {
                    registo = (int)result;
                }
                conn.Close();

            }
            return registo > 0;
        }

        public void ExcluirUsuario(int usuarioId)
        {
            using (SqlConnection conn = new SqlConnection(Conexao))
            {
                string sql = "DELETE FROM Usuario WHERE Id = @Id";

                SqlCommand comandos = new SqlCommand(sql, conn);
                comandos.Parameters.AddWithValue("@Id", usuarioId);

                conn.Open();

                var result = comandos.ExecuteNonQuery();

                conn.Close();
            }
        }

        public Usuario ObterPorLogin(string login)
        {
            Usuario usuario = null;
            using (SqlConnection conn = new SqlConnection(Conexao))
            {
                string sql = "SELECT Id, Nome, Login, Senha, Email, DataCriacao FROM Usuario WHERE Login = @Login";

                SqlCommand comandos = new SqlCommand(sql, conn);
                comandos.Parameters.AddWithValue("@Login", login);

                conn.Open();

                SqlDataReader reader = comandos.ExecuteReader();

                reader.Read();

                if (reader.HasRows)
                {
                    usuario = Usuario.CreateNew
                        (
                            reader["Nome"].ToString(),
                            reader["Login"].ToString(),
                            reader["Senha"].ToString(),
                            reader["Email"].ToString(),
                            Convert.ToDateTime(reader["DataCriacao"]),
                            Convert.ToInt16(reader["Id"])
                         );

                }
                conn.Close();
               return usuario;
            }
        }

        public Usuario[] ObterTodosUsuario()
        {
            Usuario[] usuarios = null;

            var numRegistos = ObterTotalDeUsuarios();

            if (numRegistos > 0)
            {
                usuarios = new Usuario[numRegistos];

                using (OleDbConnection conn = new OleDbConnection(Conexao))
                {
                    string sql = "SELECT Nome, Login, Senha, Email, DataCriacao FROM Usuario";

                    OleDbCommand comandos = new OleDbCommand(sql, conn);

                    conn.Open();

                    OleDbDataReader reader = comandos.ExecuteReader();

                    int count = 0;

                    while (reader.Read())
                    {
                        usuarios[count] = Usuario.CreateNew
                            (
                                reader["Nome"].ToString(),
                                reader["Login"].ToString(),
                                reader["Senha"].ToString(),
                                reader["Email"].ToString(),
                                Convert.ToDateTime(reader["DataCriacao"]),
                                Convert.ToInt16(reader["Id"])

                            );

                        count++;
                    }

                    conn.Close();
                }
        }
            return usuarios;
        }

        public int ObterTotalDeUsuarios()
        {
            var numRegistos = 0;

            using (SqlConnection conn = new SqlConnection(Conexao))
            {
                string sql = "SELECT COUNT(Id) FROM Usuario";

                OleDbCommand comandos = new OleDbCommand(sql);

                conn.Open();

                var result = comandos.ExecuteScalar();
                if (result != null)
                {
                    numRegistos = (int)result;
                }

                conn.Close();
            }
            return numRegistos;
        }
    }
}
