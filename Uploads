using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibBD;

namespace WebApp_GUIProjetoII
{
    public partial class INSERTBD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnInserirProduto_Click(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            Label1.Text = metodo.AdicionarProduto(txbInserirProduto.Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            lblCategID.Text = metodo.AdicionarCategoria(txbNomeCat.Text);
        }

        protected void btnInserirCli_Click(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            lblInserirCli.Text = metodo.AdicionarCliente(txbInserirCli.Text, txbNomeEmpresa.Text);
        }

        protected void btnInserirEnc_Click(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            lblInserirEnc.Text = metodo.AdicionarEncomenda(txbShName.Text, txbSAdr.Text, txbSCty.Text).ToString();
        }

        protected void txbCliID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HOME.aspx");
        }
    }
}
