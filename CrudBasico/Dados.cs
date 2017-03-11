using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace CrudBasico
{
    public class Dados
    {
        #region String de Conexão  
        public string strConexao = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        #endregion

        #region Instruções SQL para o CRUD  

        // Tabela Clientes      
        public const string strDelete = "delete from Clientes where IdCliente = @IdCliente";
        public const string strInsert = "Insert into Clientes values (@Nome, @Endereco, @Telefone, @Sexo, @Ativo, @DataCadastro)";
        public const string strSelect = "select IdCliente, Nome, Endereco, Telefone, Sexo, Ativo, DataCadastro from Clientes";
        public const string strUpdate = "update Clientes set Nome = @Nome, Endereco = @Endereco, Telefone = @Telefone, Sexo = @Sexo, Ativo = @Ativo, DataCadastro = @DataCadastro where IdCliente = @IdCliente";
        //Tabela Login
        public const string strSelectLogin = "select IdLogin, Login, Senha from Login where Login = @Login and Senha = @Senha";
        private object lstAcesso;

        #endregion

        #region Getters and Setters
        public class Clientes
        {
            public int IdCLiente { get; set; }
            public string Nome { get; set; }
            public string Endereco { get; set; }
            public string Telefone { get; set; }
            public string Sexo { get; set; }
            public bool Ativo { get; set; }
            public DateTime DataCadastro { get; set; }
        }

        public class Acesso
        {
            public int IdLogin { get; set; }
            public string Login { get; set; }
            public string Senha { get; set; }

        }

        #endregion


        //Declaração dos Métodos

        public void Atualizar(int IdCliente, string Nome, string Endereco, string Telefone, string Sexo, bool Ativo, DateTime DataCadastro)
        {

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strUpdate, objConexao))
                {
                    objCommand.Parameters.AddWithValue("@IdCliente", IdCliente);
                    objCommand.Parameters.AddWithValue("@Nome", Nome);
                    objCommand.Parameters.AddWithValue("@Endereco", Endereco);
                    objCommand.Parameters.AddWithValue("@Telefone", Telefone);
                    objCommand.Parameters.AddWithValue("@Sexo", Sexo);
                    objCommand.Parameters.AddWithValue("@Ativo", Ativo);
                    objCommand.Parameters.AddWithValue("@DataCadastro", DataCadastro);

                    objConexao.Open();

                    objCommand.ExecuteNonQuery();

                    objConexao.Close();

                }
            }

        }
        public void Excluir(int IdCliente)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strDelete, objConexao))
                {
                    objCommand.Parameters.AddWithValue("@IdCliente", IdCliente);

                    objConexao.Open();

                    objCommand.ExecuteNonQuery();

                    objConexao.Close();
                }
            }

        }
        public void Gravar(string Nome, string Endereco, string Telefone, string Sexo, bool Ativo, DateTime DataCadastro)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strInsert, objConexao))
                {
                    objCommand.Parameters.AddWithValue("@Nome", Nome);
                    objCommand.Parameters.AddWithValue("@Endereco", Endereco);
                    objCommand.Parameters.AddWithValue("@Telefone", Telefone);
                    objCommand.Parameters.AddWithValue("@Sexo", Sexo);
                    objCommand.Parameters.AddWithValue("@Ativo", Ativo);
                    objCommand.Parameters.AddWithValue("@DataCadastro", DataCadastro);

                    objConexao.Open();

                    objCommand.ExecuteNonQuery();

                    objConexao.Close();

                }
            }

        }

        public List<Clientes> Consultar()
        {
            List<Clientes> lstClientes = new List<Clientes>();

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strSelect, objConexao))
                {
                    objConexao.Open();
                    SqlDataReader objDataReader = objCommand.ExecuteReader();

                    //A propriedade HasRows verifica se existe uma ou mais linhas
                    if (objDataReader.HasRows)
                    {
                        //se retornar true significa dados no data reader
                        // O while atribui os valores para os respectivos as propriedades
                        while (objDataReader.Read())
                        {
                            Clientes objClientes = new Clientes();
                            objClientes.IdCLiente = Convert.ToInt32(objDataReader["IdCliente"].ToString());
                            objClientes.Nome = objDataReader["Nome"].ToString();
                            objClientes.Endereco = objDataReader["Endereco"].ToString();
                            objClientes.Telefone = objDataReader["Telefone"].ToString();
                            objClientes.Sexo = objDataReader["Sexo"].ToString();

                            if (objDataReader["Ativo"].ToString().Equals("0"))
                            {
                                objClientes.Ativo = false;
                            }

                            else
                            {
                                objClientes.Ativo = true;
                            }

                            objClientes.DataCadastro = Convert.ToDateTime(objDataReader["DataCadastro"].ToString());

                            lstClientes.Add(objClientes);
                        }
                        objDataReader.Close();
                    }
                    objConexao.Close();
                }
            }
            return lstClientes;
        }

        public List<Acesso> ConsultarAcesso(string Login, string Senha)
        {
            List<Acesso> lstLogin = new List<Acesso>();
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strSelectLogin, objConexao))
                {
                    objConexao.Open();
                    SqlDataReader objDataReader = objCommand.ExecuteReader();

                    //A propriedade HasRows verifica se existe uma ou mais linhas
                    if (objDataReader.HasRows)
                    {
                        //se retornar true significa dados no data reader
                        // O while atribui os valores para os respectivos as propriedades
                        while (objDataReader.Read())
                        {
                            Acesso objAcesso = new Acesso();
                            objAcesso.IdLogin = Convert.ToInt32(objDataReader["IdLogin"].ToString());
                            objAcesso.Login = objDataReader["Login"].ToString();
                            objAcesso.Senha = objDataReader["Senha"].ToString();


                        }
                        objDataReader.Close();
                    }
                    objConexao.Close();

                    return lstLogin;
                }

               

            }
        }


    }
}
