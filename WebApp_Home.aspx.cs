using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_GUIProjetoII
{
    public partial class HOME : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPesqCli_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pesquisa_Clientes.aspx");
        }

        protected void btnPesqProd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pesquisa_Produtos.aspx");
        }

        protected void btnAddElemBD_Click(object sender, EventArgs e)
        {
            Response.Redirect("INSERTBD.aspx");
        }

        protected void btnEditElemBD_Click(object sender, EventArgs e)
        {
            Response.Redirect("UPDATEBD.aspx");
        }

        protected void btnTotVendas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Totais_LM.aspx");
        }
    }
}
