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
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        Nusuarios user = new Nusuarios();
        NRoles rol = new NRoles();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblerror.Visible = false;
            cargarroles();
        }
        public void cargarroles()
        {
            List<Roles> roles = rol.ListarRoles();
            ListItem i;
            foreach (Roles r in roles)
            {

                i = new ListItem(r.NombreRol, r.IdTipoRol.ToString());
                ddltipo.Items.Add(i);
            }
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtpass1.Text.Equals(txtpass2.Text))
                {
                    string resp1 = "Los campos de la contraseña no coinciden.";
                    lblerror.Visible = true;
                    lblerror.Text = "Error:  " + resp1;
                }
                else
                {

                    string resp = user.ValidarNulosRegistro(txtUser.Text, txtNom.Text, txtNacionalidad.Text, txtTel.Text, txtCorreo.Text, txtDirec.Text, txtpass1.Text);
                    if (resp.Equals("1"))
                    {
                        resp = user.validarTexto(txtNom.Text, txtNacionalidad.Text);
                        if (resp.Equals("1"))
                        {
                            resp = user.ValidarNumero(txtUser.Text);
                            if (resp.Equals("1"))
                            {
                                int idrol = Convert.ToInt32(ddltipo.SelectedValue);
                                resp = user.crearUsuario2(txtUser.Text, txtNom.Text, txtNacionalidad.Text, txtTel.Text, txtCorreo.Text, txtDirec.Text, txtpass1.Text, idrol);
                                if (resp.Equals("1"))
                                {

                                    lblerror.Visible = true;
                                    Response.Redirect("../Pages/GestionUsuarios.aspx");

                                }
                                else
                                {
                                    lblerror.Visible = true;
                                    lblerror.Text = "Error: " + resp;
                                }
                            }
                            else
                            {
                                lblerror.Visible = true;
                                lblerror.Text = "Error: " + resp;
                            }
                        }
                        else
                        {
                            lblerror.Visible = true;
                            lblerror.Text = "Error: " + resp;
                        }
                    }

                    else
                    {
                        lblerror.Visible = true;
                        lblerror.Text = "Error:  " + resp;
                    }
                }
            }
            catch (Exception ex)
            {
                lblerror.Visible = true;
                lblerror.Text = "Error:  " + ex.Message;
            }
        }

        protected void ddltipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}