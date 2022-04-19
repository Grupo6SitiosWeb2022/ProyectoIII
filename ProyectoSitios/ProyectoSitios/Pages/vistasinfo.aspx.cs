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

    public partial class vistasinfo : System.Web.UI.Page
    {

        Nvistas vistas = new Nvistas();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarvistas();
            }
        }

        public void cargarvistas()
        {
            List<InfoVistas> vistas1 = vistas.ListarVistas();

            foreach (InfoVistas vistas in vistas1)
            {
                string nombre = vistas.nombrePrestamo;
                string numeroSsolicitudes = vistas.numeroSsolicitudes.ToString();
                string solicitudesPendientes = vistas.solicitudesPendientes.ToString();
                string solicitudesAprobadas = vistas.solicitudesAprobadas.ToString();
                string solicitudesDenegadas = vistas.solicitudesDenegadas.ToString();
                TableRow row = new TableRow();
                TableCell[] cell = new TableCell[] { new TableCell { Text = nombre }, new TableCell { Text = numeroSsolicitudes }, new TableCell { Text = solicitudesPendientes }
                , new TableCell { Text = solicitudesAprobadas }, new TableCell { Text = solicitudesDenegadas }};
                //cell.Text = word.ToString();
                row.Cells.AddRange(cell);
                tablevistas.Rows.Add(row);

            }
        }

        protected void btnBuscar_Click1(object sender, EventArgs e)
        {

        }
    }


}