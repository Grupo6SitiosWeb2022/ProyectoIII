using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaDatos;
namespace ProyectoSitios.Pages
{
    public partial class AgregarPrestamo : System.Web.UI.Page
    {
        Nprestamos pres = new Nprestamos();
        NPlazosCatego pc = new NPlazosCatego();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblerror.Visible = false;
            cargarCatego();
            cargarPlazo();

        }
        public void cargarCatego()
        {
            List<PurpleCategoriasPrestamos> cate = pc.ListarCategoria();
            ListItem i;
            foreach (PurpleCategoriasPrestamos r in cate)
            {

                i = new ListItem(r.NombreCategoria, r.CodigoCategoria.ToString());
                ddlcatego.Items.Add(i);
            }
        }

        public void cargarPlazo()
        {
            List<PrestamoPlazosClass> plazo = pc.ListarPlazos();
            ListItem i;
            foreach (PrestamoPlazosClass r in plazo)
            {
                string aux = "Monto mínimo: " + r.PlazoMin + " meses, monto máximo: " + r.PlazoMax + " meses";
                i = new ListItem(aux, r.CodigoPlazo.ToString());
                ddlplazo.Items.Add(i);
            }
        }
        protected void btnagregar_Click(object sender, EventArgs e)
        {
            string codiplazo = ddlplazo.SelectedValue;
            string cate = ddlcatego.SelectedValue;
            string resp = pres.ValidarNulosNewPrestamo(txtNom.Text, txtDescri.Text, txtTasa.Text, codiplazo, txtMontoMin.Text, txtMontoMax.Text, cate);
            if (resp == "1")
            {
                string aux = pres.CrearPrestamo(txtNom.Text, txtDescri.Text, txtTasa.Text, codiplazo, txtMontoMin.Text, txtMontoMax.Text, cate);
                if (aux == "1")
                {
                    Response.Redirect("../Pages/GestionPrestamos.aspx");
                }
                else
                {
                    lblerror.Visible = true;
                    lblerror.Text = aux;
                }
            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = resp;
            }
        }

        protected void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtDescri_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtTasa_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtMontoMin_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtMontoMax_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlplazo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlcatego_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}