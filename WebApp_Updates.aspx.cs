using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibMTD;

namespace WebApp_GUIProjetoII
{
    public partial class UPDATEBD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();

            foreach (var item in metodo.Produtos())
            {
                ddlListaProdutos.Items.Add(item);
            }

            foreach (var item in metodo.Categorias())
            {
                ddlCat.Items.Add(item);
            }

            foreach (var item in metodo.Clientes())
            {
                if (item != null)
                {
                    ddlListaClientes.Items.Add(item);    
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            lblAlterarProd.Text = metodo.AlterarProduto(txbProdOld.Text, ddlListaProdutos.SelectedValue, int.Parse(lblIDProduto.Text));

        }

        protected void ddlListaProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            txbProdOld.Text = ddlListaProdutos.SelectedValue;
            lblIDProduto.Text = metodo.IDProduto(ddlListaProdutos.SelectedValue).ToString();
        }

        protected void ddlCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            NWMTD metodos = new NWMTD();
            txbIdNomCat.Text = ddlCat.SelectedValue;
            lblCategoriaOldName.Text = metodos.CategoriasID(ddlCat.SelectedValue).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            NWMTD metodos = new NWMTD();
            lblResultadoCatID.Text = metodos.AlterarCategoria(txbIdNomCat.Text, ddlCat.SelectedValue, int.Parse(lblCategoriaOldName.Text));
        }

        protected void ddlCatID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //NWMTD metodos = new NWMTD();
            //txbIdNomCat.Text = metodos.Categorias(int.Parse(ddlCatID.SelectedValue));
        }

        protected void ddlListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            txbListaCli.Text = ddlListaClientes.SelectedValue;
            lblIDCli.Text = metodo.ClientesID(txbListaCli.Text);
            lblCompanyName.Text = metodo.ClientesCompanyName(txbListaCli.Text);
        }

        protected void btnListCli_Click(object sender, EventArgs e)
        {
            NWMTD metodos = new NWMTD();
            lblResultListCli.Text = metodos.AlterarCliente(txbListaCli.Text, ddlListaClientes.SelectedValue, lblCompanyName.Text, lblIDCli.Text);
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HOME.aspx");
        }
    }
}
