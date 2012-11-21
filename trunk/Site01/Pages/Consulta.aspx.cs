using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DAL.Entity;
using DAL.Persistence;

namespace Site01.Pages
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            MontaGrid();

        }

        private void MontaGrid()
        {
            try
            {
                ClienteDAL dal = new ClienteDAL();
                List<Cliente> dados = dal.ListarTodos();

                lblMensagem.Text = "Quantidade de Clientes cadastrados: " + dados.Count;

                //Carregar o GridView
                gridClientes.DataSource = dados;
                gridClientes.DataBind();    //Desenhar o GridView

            }
            catch (Exception ex)
            {

                lblMensagem.Text = "Erro: " + ex.Message;
            }
        }
    }
}