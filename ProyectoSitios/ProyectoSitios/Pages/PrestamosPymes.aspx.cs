using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoSitios.Pages
{
    public partial class PrestamosPymes : System.Web.UI.Page
    {


        protected void btncalcu_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Pages/CalcularPrestamos.aspx");
        }

        protected void btnformu_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Pages/FormularioP.aspx");
        }
    }
}