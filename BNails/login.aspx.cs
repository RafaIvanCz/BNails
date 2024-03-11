using Business.Services.Config;
using Business.Services.Usuarios;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Org.BouncyCastle.Crypto.Utilities;

namespace BNails
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string emailUser = txtUserEmail.Text.Trim().ToLower();

                if (UsuarioServices.ExisteEmailUser(emailUser) == false)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "key1", "showMessage('E-mail no registrado. Tenés que registrarte antes de ingresar.')", true);
                }
                else
                {
                    Domain.Usuario user = UsuarioServices.GetByEmail(emailUser);

                    if (user.Password.Equals(txtPassword.Text.Trim()))
                    {
                        if (user.Activo == true && user.Eliminado == false)
                        {
                            if (Session["usuario"] != null)
                            {
                                Session.Remove("usuario");
                                Session.Add("usuario", user.Id);
                            }
                            else
                            {
                                Session.Add("usuario", user.Id);
                            }

                            if (user.PrimerIngreso == true)
                            {
                                user.PrimerIngreso = false;
                                user.IngresoActual = DateTime.Now;
                            }

                            user.UltimoIngreso = user.IngresoActual;

                            user.IngresoActual = DateTime.Now;

                            UsuarioServices.SaveOrUpdate(user);

                            //GUARDO UNA COOKIE
                            //HttpCookie myCookie = new HttpCookie("usuario_" + user.Id.ToString());
                            //myCookie.Value = user.Id.ToString();
                            //myCookie.Expires = DateTime.Now.AddDays(1d);
                            //Response.Cookies.Add(myCookie);

                            Response.Redirect(Global.ApplicationPath + "/Index.aspx", true);
                            //Response.Redirect(Global.ApplicationPath + "/ImportarPatrones.aspx", true);
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "key1", "showMessage('No existe el usuario ingresado')", true);
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "key1", "showMessage('La contraseña es incorrecta!')", true);
                    }
                }

            }catch (Exception ex)
            {

            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombreRegister.Text.Trim()) || string.IsNullOrEmpty(txtApellidoRegister.Text.Trim()) || string.IsNullOrEmpty(txtEmailRegister.Text.Trim()) || string.IsNullOrEmpty(txtPasswordRegister.Text.Trim()))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "key1", "showMessage('Tenés que completar todos los campos.')", true);
                }
                else
                {
                    if (txtPasswordRegister.Text.Trim().Length < 6)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "key1", "showMessage('La contraseña debe tener como mínimo 6 caracteres.')", true);
                    }
                    else
                    {
                        string emailRegister = txtEmailRegister.Text.Trim().ToLower();

                        if (UsuarioServices.ExisteEmailUser(emailRegister) == true)
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "key1", "showMessage('Ya existe un Usuario con ese E-mail.')", true);
                        }
                        else
                        {
                            Domain.Usuario user = new Domain.Usuario();

                            user.Nombre = txtNombreRegister.Text.Trim();
                            user.Apellido = txtApellidoRegister.Text.Trim();
                            user.Email = txtEmailRegister.Text.Trim().ToLower();
                            user.Password = txtPasswordRegister.Text.Trim();
                            user.Eliminado = false;
                            user.Activo = true;

                            UsuarioServices.SaveOrUpdate(user);

                            Configuraciones cfg = ConfiguracionServices.getFirst();

                            if (cfg != null)
                            {
                                String mailUser = cfg.SMPTUser;
                                String mailPassword = cfg.SMTPPwd;
                                String from = cfg.SMTPFrom;
                                String smtpServer = cfg.SMTPServer;
                                String smtpPort = cfg.SMTPPort.ToString();
                                String body = "Hola " + txtNombreRegister.Text + "!" + " Te doy la bienvenida a " + cfg.NombreApp +
                                    "<br><br>" +
                                    "Recorda que una vez que te loguees, vas a poder ver todos mis trabajos e incluso reservar una sesión de uñas para cualquier día y horario disponible, con la opción de agregar detalles del modelo que quieras realizarte en el campo de 'Observaciones'." +
                                    "<br><br>Espero que tengas una excelente experiencia!" +
                                    "<br><br>Saludos!<br><br>" + Settings.Settings.NombreApp;

                                MailMessage mail = new MailMessage()
                                {
                                    From = new MailAddress(from, Settings.Settings.NombreApp),
                                    Body = body,
                                    Subject = "Mensaje de bienvenida de " + Settings.Settings.NombreApp,
                                    IsBodyHtml = true,
                                };

                                mail.To.Add(new MailAddress(txtEmailRegister.Text, txtNombreRegister.Text));
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
                            }

                            ScriptManager.RegisterStartupScript(this, this.GetType(), "key1", "showMessage('Usuario creado con éxito! Ya podés ingresar al sistema.')", true);

                            txtNombreRegister.Text = "";
                            txtApellidoRegister.Text = "";
                            txtEmailRegister.Text = "";
                            txtPasswordRegister.Text = "";

                        }
                    }                    
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}