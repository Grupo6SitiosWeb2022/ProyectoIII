using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;
namespace ProyectoSitios.Pages
{
    public partial class VistasInformacionT : System.Web.UI.Page
    {
        Nvistas vistas = new Nvistas();
        protected void Page_Load(object sender, EventArgs e)
        {

            lblerror.Visible = false;
            vistas.ConteoVistas();
            if (!IsPostBack)
            {
                cargarvistas();
            }
        }
        public void cargarvistas()
        {
            List<VistaCompleta> vistas1 = vistas.ConteoVistas();

            foreach (VistaCompleta vistas in vistas1)
            {
                string nombre = vistas.nombrePrestamo;
                string numeroSsolicitudes = vistas.numeroSsolicitudes.ToString();
                string solicitudesPendientes = vistas.solicitudesPendientes.ToString();
                string solicitudesAprobadas = vistas.solicitudesAprobadas.ToString();
                string solicitudesDenegadas = vistas.solicitudesDenegadas.ToString();
                string solicitudestramitando = vistas.solicitudestramitando.ToString();
                TableRow row = new TableRow();
                TableCell[] cell = new TableCell[] { new TableCell { Text = nombre }, new TableCell { Text = numeroSsolicitudes }, new TableCell { Text = solicitudesPendientes }
                , new TableCell { Text = solicitudesAprobadas }, new TableCell { Text = solicitudesDenegadas }, new TableCell { Text = solicitudestramitando }};
                //cell.Text = word.ToString();
                row.Cells.AddRange(cell);
                TalaVistas.Rows.Add(row);

            }
        }

        public bool validarfechas(DateTime fechaI, DateTime fechaf)
        {
            bool validacion = false;

            if (fechaI > fechaf)
            {
                return true;
            }
            else if (fechaf < fechaI)
            {
                return true;
            }

            return validacion;
        }

        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            string fechaI = Request.Form["fechainicio"];

            string fechaF = Request.Form["fechafin"];
            if (fechaI.Equals("") && fechaF.Equals(""))
            {
                cargarvistas();
            }
            else
            {
                if (validarfechas(Convert.ToDateTime(fechaI), Convert.ToDateTime(fechaF)) == false)
                {
                    List<VistaCompleta> vistas1 = vistas.ConteoVistasFiltro(Convert.ToDateTime(fechaI), Convert.ToDateTime(fechaF));

                    foreach (VistaCompleta vistas in vistas1)
                    {
                        string nombre = vistas.nombrePrestamo;
                        string numeroSsolicitudes = vistas.numeroSsolicitudes.ToString();
                        string solicitudesPendientes = vistas.solicitudesPendientes.ToString();
                        string solicitudesAprobadas = vistas.solicitudesAprobadas.ToString();
                        string solicitudesDenegadas = vistas.solicitudesDenegadas.ToString();
                        string solicitudestramitando = vistas.solicitudestramitando.ToString();
                        TableRow row = new TableRow();
                        TableCell[] cell = new TableCell[] { new TableCell { Text = nombre }, new TableCell { Text = numeroSsolicitudes }, new TableCell { Text = solicitudesPendientes }
                , new TableCell { Text = solicitudesAprobadas }, new TableCell { Text = solicitudesDenegadas }, new TableCell { Text = solicitudestramitando }};
                        //cell.Text = word.ToString();
                        row.Cells.AddRange(cell);
                        TalaVistas.Rows.Add(row);

                    }
                }
                else
                {
                    cargarvistas();
                    lblerror.Visible = true;
                    lblerror.Text = "Rango de fechas incorrecto";
                }
            }
        }
    }
}