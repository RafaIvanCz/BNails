using Business.Services.Usuarios;
using DevExpress.XtraRichEdit.Model;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common.Encrypt;
using Business.Services.Config;

namespace BNails
{
    public partial class ResetPwd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRestorePwd_Click(object sender, EventArgs e)
        {
            //Verifico la existencia del mail ingresado
            String correo = txtEmailRestorePwd.Text;

            try
            {
                Usuario user = UsuarioServices.ExisteEmail(correo);

                if (user != null)
                {
                    String persona = user.Nombre;
                    String urlRestablecer = Request.Url.GetLeftPart(UriPartial.Authority) + Global.ApplicationPath + "/ChangePwd.aspx?id=";
                    String encrypt = persona + user.Email + DateTime.Now;
                    SimpleAES sp = new SimpleAES();
                    String encryptData = sp.EncryptToString(encrypt);

                    //Guardo la encriptación para recuperación de contraseña
                    user.Confirmacion = encryptData;
                    UsuarioServices.SaveOrUpdate(user);
                    Configuraciones cfg = ConfiguracionServices.getFirst();
                    if (cfg != null)
                    {
                        String mailUser = cfg.SMPTUser;
                        String mailPassword = cfg.SMTPPwd;
                        String from = cfg.SMTPFrom;
                        String smtpServer = cfg.SMTPServer;
                        String smtpPort = cfg.SMTPPort.ToString();
                        String body = "Hola " + persona +
                                      "<br><br>Hiciste una solicitud de cambio de contraseña recientemente en tu cuenta de B-Nails.<br>" +
                                      "Si fuiste vos, por favor, ingresa una contraseña nueva usando el enlace a continuación:<br><br>" +
                                      "<a href='" + urlRestablecer + encryptData + "'>Cambiar Contraseña</a>" +
                                      "<br><br>Si no deseas cambiar tu contraseña, ignora este mensaje.<br><br>" +
                                      "Gracias.<br>" + Settings.Settings.NombreApp;

                        MailMessage mail = new MailMessage()
                        {
                            From = new MailAddress(from, Settings.Settings.NombreApp),
                            Body = body,
                            Subject = "Recuperación de contraseña de " + Settings.Settings.NombreApp,
                            IsBodyHtml = true,
                        };

                        mail.To.Add(new MailAddress(correo, persona));
                        SmtpClient smtp = new SmtpClient(smtpServer, Convert.ToInt32(smtpPort))
                        {
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(mailUser, mailPassword),
                            EnableSsl = true,
                        };
                        smtp.Host = smtpServer;
                        smtp.Port = Convert.ToInt32(smtpPort);
                        smtp.Credentials = new NetworkCredential(mailUser, mailPassword);
                        smtp.Send(mail);

                        ScriptManager.RegisterStartupScript(this,this.GetType(),"key1", "showMessage('Email enviado correctamente. Revisá tu correo.')",true);
                        txtEmailRestorePwd.Text = "";
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "key1", "showMessage('No se encontro una cuenta asociada a ese email.')", true);
                    txtEmailRestorePwd.Text = "";
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "key1", "showMessage('Error enviando email, consulte al administrador del sistema.')", true);

            }
        }
    }
}