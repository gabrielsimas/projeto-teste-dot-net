using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site02.Pages
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (! IsPostBack){
                ddlFornecedor.Items.Insert(0, new ListItem("Escolha uma Opção"));
            }
        }

        protected void CadastrarProduto(object sender, EventArgs e)
        {
            //Teste
            lblMensagem.Text = "Testando...";
        }

    }
}