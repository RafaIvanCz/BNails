using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace BNails
{
    public class Global : HttpApplication
    {
        public static string ApplicationPath = "";

        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

            CultureInfo myCIintl = Thread.CurrentThread.CurrentCulture;
            Application.Add("culture", myCIintl);

            CultureInfo nueva = new CultureInfo("es-AR");
            nueva.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";

            nueva.NumberFormat.CurrencyDecimalSeparator = ",";

            nueva.NumberFormat.CurrencyGroupSeparator = ".";

            nueva.NumberFormat.NumberDecimalSeparator = ",";

            nueva.NumberFormat.NumberGroupSeparator = ".";

            Thread.CurrentThread.CurrentUICulture = nueva;
            Thread.CurrentThread.CurrentCulture = nueva;


        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

            if (HttpContext.Current.Request.ApplicationPath != "/")
            {
                ApplicationPath = HttpContext.Current.Request.ApplicationPath;
            }
        }
    }
}