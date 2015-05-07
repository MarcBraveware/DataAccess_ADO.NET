using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibMTD;

namespace WebApp_GUIProjetoII
{
    public partial class Pesquisa_Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            foreach (var item in metodo.Clientes())
            {
                if (item != null)
                {
                    ddlClientes.Items.Add(item);        
                }
            }
            
        }

        protected void ddlClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblListaEncomendaCli.Text = "";
            lblTxtIDdaEncom.Visible = true;

            NWMTD metodo = new NWMTD();
            foreach (var item in metodo.Encomendas(ddlClientes.SelectedValue))
            {
                lblListaEncomendaCli.Text += "- " + item + ";<br />";    
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HOME.aspx");
        }
    }
}
