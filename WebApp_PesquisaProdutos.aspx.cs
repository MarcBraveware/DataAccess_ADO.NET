using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibBD;
using ClassLibMTD;

namespace WebApp_GUIProjetoII
{
    public partial class Pesquisa_Produtos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NWMTD metodos = new NWMTD();
            foreach (var item in metodos.Categorias())
            {
                ddlCat.Items.Add(item);
                ddlCatMaisVend.Items.Add(item);
            }
        }

        protected void btnListaTPC_Click(object sender, EventArgs e)
        { }

        protected void ddlProd_SelectedIndexChanged(object sender, EventArgs e)
        { }

        protected void ddlCat_SelectedIndexChanged(object sender, EventArgs e)
        {//A condição aqui presente deve estar referida no metodo e não na aplicação do método.
            //Esta aqui encontrasse por incompatibilidade da condição no metodo associada à compatibilidade de tipos de dados
            //Para mais informação vid metodo "public string[] Produto(string categoria){ ... }"

            ddlProd.Items.Clear();
            NWMTD metodo = new NWMTD();
            if (metodo.Produto(ddlCat.SelectedValue).Count() != 0)
            {
                foreach (var item in metodo.Produto(ddlCat.SelectedValue))
                {
                    ddlProd.Items.Add(item);
                }
            }
            else
            {
                ddlProd.Items.Add("A categoria não possui produtos associados!");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblResPesqProdNome.Text = "";

            NWMTD metodo = new NWMTD();
            lblResPesqProdNome.Text = metodo.Produtos(tbxNomeProd.Text);
        }

        protected void ddlCatMaisVend_SelectedIndexChanged(object sender, EventArgs e)
        {
            NWMTD metodo = new NWMTD();
            Label1.Text = metodo.CategoriasID(ddlCat.SelectedValue).ToString();
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HOME.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lbxResultProdMaisVendido.Items.Clear();

            NWMTD metodo = new NWMTD();
            foreach (var item in metodo.ProdutoMaisVendidos(int.Parse(Label1.Text), int.Parse(txbQuantidProdVis.Text)))
            {
                lbxResultProdMaisVendido.Items.Add(item);
            }
        }
    }
}
