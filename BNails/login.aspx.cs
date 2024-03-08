using Business.Services.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "key1", "showMessage('Email no registrado. Debe registrarse antes de ingresar.')", true);
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
                            HttpCookie myCookie = new HttpCookie("usuario_" + user.Id.ToString());
                            myCookie.Value = user.Id.ToString();
                            myCookie.Expires = DateTime.Now.AddDays(1d);
                            Response.Cookies.Add(myCookie);

                            Response.Redirect(Global.ApplicationPath + "/ResetPwd.aspx", true);
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

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                string emailRegister = txtEmailRegister.Text.Trim().ToLower();

                if (UsuarioServices.ExisteEmailUser(emailRegister) == true)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "key1", "showMessage('Ya existe un usuario con ese Email.')", true);
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

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "key1", "showMessage('Usuario creado con éxito! Ya podés ingresar al sistema ☺')", true);

                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}