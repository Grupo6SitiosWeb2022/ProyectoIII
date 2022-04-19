using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using CapaDatos;

using System.Net.Mime;
using System.Net.Http;

namespace CapaNegocio
{
    public class NCorreo
    {

        public string sendMail(string destinatario, string asunto, string body)
        {
            string msge = "Error al enviar este correo. Por favor verifique los datos o intente más tarde.";
            string from = "banconav20@gmail.com";
            string displayName = "Banco Nav";
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(destinatario);

                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;


                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Host y puerto
                client.Credentials = new NetworkCredential(from, "proyectoGrupo6");
                client.EnableSsl = true;


                client.Send(mail);
                msge = "Correo enviado";

            }
            catch (Exception ex)
            {
                msge = ex.Message + "Error: al enviar el correo.";
            }

            return msge;
        }

        private const String SERVICE_URL2 = "https://tiusr3pl.cuc-carrera-ti.ac.cr/ProyectoPPII/api/SolicitudesAnalistas";

        SolicitudesAnalista analista = new SolicitudesAnalista();

        public List<SolicitudesAnalista> Listarsolianalistas()
        {
            try
            {
                using (var prestamo = new HttpClient())
                {
                    var task = Task.Run(
                    async () =>
                    {
                        using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, SERVICE_URL2))
                        {
                            var respuesta = await prestamo.SendAsync(requestMessage);
                            return respuesta;
                        }
                    }
                    );
                    HttpResponseMessage message = task.Result;
                    if (message.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var task2 = Task<string>.Run(async () =>
                        {
                            return await message.Content.ReadAsStringAsync();
                        }
                        );
                        string resultStr = task2.Result;
                        List<SolicitudesAnalista> soli = SolicitudesAnalista.FromJson(resultStr);
                        return soli;
                    }
                    else if (message.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                    {
                        throw new Exception("Error");
                    }
                    else
                    {
                        throw new Exception("Error");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

