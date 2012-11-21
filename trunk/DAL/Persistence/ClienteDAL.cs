using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Entity;
using System.Data.SqlClient;



namespace DAL.Persistence
{
    public class ClienteDAL : DAL
    {
        #region Metodos

        /// <summary>
        /// Cadastra Cliente
        /// </summary>
        /// <param name="cliente"></param>
        public void Salvar(Cliente cliente)
        {
            try
            {
                AbrirConexao();

                Com = new SqlCommand("INSERT INTO CLIENTE(NOME, EMAIL) VALUES (@p1,@p2)",Con);
                Com.Parameters.AddWithValue("@p1",cliente.Nome);
                Com.Parameters.AddWithValue("@p2", cliente.Email);

                //Executar a query sem retornar valores
                Com.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                FechaConexao();
            }
        }

        public List<Cliente> ListarTodos()
        {
            try
            {
                AbrirConexao();

                Com = new SqlCommand("SELECT * FROM cliente",Con );
                Dr = Com.ExecuteReader();

                List<Cliente> dados = new List<Cliente>(); //Lista vazia

                //Varre o DataReader
                while(Dr.Read()){
                    Cliente cliente2 = new Cliente();

                    cliente2.IdCliente = Convert.ToInt32(Dr["IdCliente"]);
                    cliente2.Nome = Convert.ToString(Dr["Nome"]);
                    cliente2.Email = Convert.ToString(Dr["Email"]);

                    dados.Add(cliente2);
                }

                return dados;
            }
            catch
            {
                throw;
            }
            finally
            {
                FechaConexao();
            }
        }

        #endregion
    }
}
