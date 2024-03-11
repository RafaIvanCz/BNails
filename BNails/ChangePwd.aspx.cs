using Business.Services.Usuarios;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BNails
{
    public partial class ChangePwd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnConfirmChangePwd_Click(object sender, EventArgs e)
        {
            try
            {
                String pwdEncrypt = Request.QueryString["id"];

                if (pwdEncrypt != null)
                {
                    Usuario user = UsuarioServices.ConfirmarPwd(pwdEncrypt);

                    if (user == null)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "key1", "showMessage('Link caducado, volvé a iniciar el proceso.')", true);
                    }
                    else
                    {
                        if (txtNewPwd.Text.Equals(txtRepeatNewPwd.Text) && txtNewPwd.Text.Trim() != "")
                        {
                            user.Password = txtNewPwd.Text;
                            user.Confirmacion = "";
                            UsuarioServices.SaveOrUpdate(user);

                            ScriptManager.RegisterStartupScript(this, this.GetType(), "key1", "showMessage('Se actualizó tu contraseña. Ya podés loguearte!')", true);

                            txtNewPwd.Enabled = false;
                            txtRepeatNewPwd.Enabled = false;
                            btnBackLogin.Visible = true;
                            btnConfirmChangePwd.Visible = false;
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "key1", "showMessage('Escribí una contraseña válida. Debe ser igual en ambos campos.')", true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "key1", "showMessage('" + ex.Message + "')", true);
            }
        }

        protected void btnBackLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect(Global.ApplicationPath + "/Login.aspx");
        }
    }
}