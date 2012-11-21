using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient; //Conecta ao SQL Server

namespace DAL.Persistence
{
    public class DAL
    {

        #region Atributos

        protected SqlConnection Con;    //Conecta ao Banco
        protected SqlCommand Com;    //Executa um comando no Banco de Dados
        protected SqlDataReader Dr;    //Percorre um resultado de SELECT

        #endregion

        #region Métodos
        /// <summary>
        /// Metodo para abrir uma conexão ao Banco de Dados
        /// </summary>
        public void AbrirConexao()
        {
            //Usa o método para conectar ao Banco de Dados
            Con = new SqlConnection("Data Source=GABRIEL-LAPTOP\\SQLEXPRESS;Integrated Security=True");
            Con.Open(); //Conecta ao Banco de Dados
        }

        public void FechaConexao(){
            Con.Close();    //Fecha a conexão com o Banco
        }

        #endregion





    }
}
