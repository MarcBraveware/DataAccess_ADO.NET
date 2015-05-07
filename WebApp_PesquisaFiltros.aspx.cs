using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibMTD;

namespace WebApp_GUIProjetoII
{
    public partial class Totais_LM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            foreach (var item in metodo.ListaIDEncomendas())
            {
                ddlListOrderID.Items.Add(item.ToString());
            }
            foreach (var item in metodo.Clientes())
            {
                ddlNomeClientes.Items.Add(item);
            }
            foreach (var item in metodo.Produtos())
            {
                ddlProd.Items.Add(item);
            }
            foreach (var item in metodo.Categorias())
            {
                ddlCategorias.Items.Add(item);
            }

        }

        protected void ddlListOrderID_SelectedIndexChanged(object sender, EventArgs e)
        { }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            lblTotalVendasEncomenda.Text = metodo.TotalDeVendasOrders(int.Parse(ddlListOrderID.SelectedValue));
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HOME.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            lblIDCliente.Text = metodo.ClientesID(ddlNomeClientes.SelectedValue);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            lblTotVendasCliente.Text = metodo.TotalDeVendasCust(ddlNomeClientes.SelectedValue, lblIDCliente.Text);
        }

        protected void ddlProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            lblIDProd.Text = metodo.IDProduto(ddlProd.SelectedValue).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            lblTotVendasProd.Text = metodo.TotalDeVendasProd(int.Parse(lblIDProd.Text));
        }

        protected void ddlCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            lblIDCat.Text = metodo.CategoriasID(ddlCategorias.SelectedValue).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            lblTotVendasCat.Text = metodo.TotalDeVendasCat(int.Parse(lblIDCat.Text));
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            metodo.TotalDeVendasAnoMes();
        }
    }
}
