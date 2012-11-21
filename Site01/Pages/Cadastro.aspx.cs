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
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = string.Empty;
        }

        protected void CadastrarCliente(object sender, EventArgs e)
        {
            //lblMensagem.Text = "Seja bem vindo ao ASP.NET";
            try
            {
                Cliente     cliente = new Cliente();
                ClienteDAL  dal = new ClienteDAL();

                cliente.Nome = txtNome.Text;
                cliente.Email = txtEmail.Text;

                dal.Salvar(cliente);

                lblMensagem.Text = "Cliente " + cliente.Nome + " cadastrado coms sucesso!";

            }
            catch (Exception ex)
            {

                lblMensagem.Text = "Erro: " + ex.Message;
            }
        }

    }
}