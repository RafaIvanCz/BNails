using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BNails
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            HttpContext.Current.Session.Clear();
            Session.Abandon();
            System.GC.Collect();
            Response.Redirect(Global.ApplicationPath + "/Login.aspx", false);
        }
    }
}