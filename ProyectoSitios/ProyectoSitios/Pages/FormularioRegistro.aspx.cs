using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;
using Newtonsoft.Json.Linq;

namespace ProyectoSitios.Pages
{
    public partial class FormularioRegistro : System.Web.UI.Page
    {
        Nusuarios user = new Nusuarios();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblerror.Visible = false;
        }
        public bool IsReCaptchValid()
        {
            var result = false;
            var captchaResponse = Request.Form["g-recaptcha-response"];
            var secretKey = ConfigurationManager.AppSettings["SecretKey"];
            var apiUrl = "https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}";
            var requestUri = string.Format(apiUrl, secretKey, captchaResponse);
            var request = (HttpWebRequest)WebRequest.Create(requestUri);

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    JObject jResponse = JObject.Parse(stream.ReadToEnd());
                    var isSuccess = jResponse.Value<bool>("success");
                    result = (isSuccess) ? true : false;
                }
            }
            return result;
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsReCaptchValid())
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
                                    int tiporol = 2;
                                    resp = user.crearUsuario2(txtUser.Text, txtNom.Text, txtNacionalidad.Text, txtTel.Text, txtCorreo.Text, txtDirec.Text, txtpass1.Text, tiporol);
                                    if (resp.Equals("1"))
                                    {

                                        lblerror.Visible = true;
                                        Response.Redirect("../Pages/login.aspx");

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
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "Error: Debe de indicar que no es un Robot.";
            }

        }
    }
}
