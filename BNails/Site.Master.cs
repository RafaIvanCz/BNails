using Business.Services.Usuarios;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace BNails
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Línea para que funcione -ResolveClientUrl-
            // Page.Header.DataBind();
            try
            {
                if (Session["usuario"] != null)
                {
                    int idUsuario = (int)Session["usuario"];
                    Usuario u = UsuarioServices.getByIdNoInitialize(idUsuario);
                    if (u != null)
                    {
                        //GenerarMenu(u);

                        // lnk_editProfile.HRef = Global.ApplicationPath + "/Admin/Usuarios/EditProfile.aspx?from=menu&id=" + Encrypt(u.IdUsuario.ToString());
                        // lnk_changePassowrd.HRef = Global.ApplicationPath + "/Admin/Usuarios/ChangePassword.aspx?from=menu&id=" + Encrypt(u.IdUsuario.ToString());
                    }
                }
                else
                {
                    //No hay usuario, vuelve al Login
                    Response.Redirect(Global.ApplicationPath + "/login.aspx", false);
                }
                //Obtengo los permisos de la página
                if (!IsPostBack)
                {
                    if (Session["usuario"] != null)
                    {
                        string pageName = this.MainContent.Page.GetType().FullName.Replace("ASP.", "/").Replace("_aspx", ".aspx").Replace("_", "/");
                        int idUsuario = (int)Session["usuario"];
                        Usuario u = UsuarioServices.getByIdNoInitialize(idUsuario);
                        //List<TipoPermiso> lst = ModuloService.getPermisoIndividualPagina(pageName, u.Rols.ToList<Rol>());

                    }
                    /*ASPxButton btnGuardarPrincipal=null;
                    if (this.Master.FindControl("btnGuardarPrincipal") != null)
                    {
                        btnGuardarPrincipal = this.Master.FindControl("btnGuardarPrincipal") as ASPxButton;
                        if (btnGuardarPrincipal != null)
                        {
                            btnGuardarPrincipal.ClientEnabled = false;
                        }
                    }
                         


                    foreach (TipoPermiso tp in lst)
                    {
                        switch (tp.Codigo)
                        {
                            case "VL":

                                break;
                            case "IMP":
                                break;
                            case "G":
                                if (btnGuardarPrincipal != null)
                                {
                                    btnGuardarPrincipal.ClientEnabled = true;
                                }
                            break;
                          
                        }
                    }*/
                }


                if (!IsPostBack)
                {

                }
            }
            catch (Exception ex)
            {
                Response.Redirect(Global.ApplicationPath + "/Index.aspx", false);
            }
        }





        #region GENERO EL MENU DEL USUARIO
        /// <summary>
        /// Función recursiva que genera el menú 
        /// </summary>
        /// <param name="Acc"></param>
        /// <param name="u"></param>
        /// <returns></returns>
        //protected HtmlGenericControl generar_MenuItem(ModuloDTO Acc, Usuario u)
        //{
        //    HtmlGenericControl menuItem = null;
        //    // HtmlGenericControl menuItem_aux = null;
        //    HtmlGenericControl hijoItem = null;

        //    List<ModuloDTO> listaSubHijos = new List<ModuloDTO>();

        //    if (Session["menuSH_" + Acc.Id + "_" + u.Username] != null)
        //    {
        //        listaSubHijos = (List<ModuloDTO>)Session["menuSH_" + Acc.Id + "_" + u.Username];
        //    }
        //    else
        //    {
        //        listaSubHijos = (List<ModuloDTO>)GenerarListaNodos(u.Rols.ToList<Rol>(), Acc.Nodo);
        //        Session.Add("menuSH_" + Acc.Id + "_" + u.Username, listaSubHijos);
        //    }

        //    if (listaSubHijos.Count > 0)
        //    {
        //        menuItem = new HtmlGenericControl("li");

        //        HtmlGenericControl item = new HtmlGenericControl("a");
        //        item.Attributes.Add("class", "dropdown-item dropdown-toggle");
        //        item.Attributes.Add("href", "#");
        //        item.InnerText = Acc.Descripcion;
        //        menuItem.Controls.Add(item);

        //        HtmlGenericControl menuItem_Sub = new HtmlGenericControl("ul");
        //        menuItem_Sub.Attributes.Add("class", "dropdown-menu");
        //        menuItem.Controls.Add(menuItem_Sub);


        //        foreach (ModuloDTO hijo_B in listaSubHijos)
        //        {
        //            menuItem_Sub.Controls.Add(generar_MenuItem(hijo_B, u));
        //        }
        //    }
        //    else
        //    {
        //        menuItem = new HtmlGenericControl("li");

        //        HtmlGenericControl item = new HtmlGenericControl("a");
        //        item.Attributes.Add("class", "dropdown-item");
        //        item.Attributes.Add("href", Global.ApplicationPath + Acc.Url);

        //        item.InnerText = Acc.Descripcion;
        //        item.Attributes.Add("onclick", "LoadingPanel.Show();");
        //        menuItem.Controls.Add(item);
        //    }


        //    return menuItem;
        //}

        //private void GenerarMenu(Usuario u)
        //{
        //    List<ModuloDTO> listaPadres;
        //    if (Session["menuP_" + u.Username] != null)
        //    {
        //        listaPadres = (List<ModuloDTO>)Session["menuP_" + u.Username];
        //    }
        //    else
        //    {
        //        listaPadres = (List<ModuloDTO>)GenerarListaNodos(u.Rols.ToList<Rol>(), 0);
        //        Session.Add("menuP_" + u.Username, listaPadres);
        //    }

        //    foreach (ModuloDTO Acc in listaPadres)
        //    {

        //        HtmlGenericControl menuItem = null;
        //        HtmlGenericControl hijoItem = null;
        //        HtmlGenericControl menuItem_Divider = null;


        //        List<ModuloDTO> Hijos;
        //        if (Session["menuH_" + Acc.Id + "_" + u.Username] != null)
        //        {
        //            Hijos = (List<ModuloDTO>)Session["menuH_" + Acc.Id + "_" + u.Username];
        //        }
        //        else
        //        {
        //            Hijos = (List<ModuloDTO>)GenerarListaNodos(u.Rols.ToList<Rol>(), Acc.Nodo);
        //            Session.Add("menuH_" + Acc.Id + "_" + u.Username, Hijos);
        //        }

        //        if (Hijos.Count > 0)
        //        {
        //            menuItem = new HtmlGenericControl("li");
        //            menuItem.Attributes.Add("class", "nav-item dropdown");


        //            //LINK
        //            HtmlGenericControl link = new HtmlGenericControl("a");
        //            link.Attributes.Add("class", "navbar-nav-link rounded dropdown-toggle");
        //            link.Attributes.Add("data-bs-toggle", "dropdown");
        //            // link.Attributes.Add("aria-haspopup", "true");
        //            link.Attributes.Add("aria-expanded", "false");
        //            link.Attributes.Add("id", "id_" + Acc.Id);
        //            link.Attributes.Add("href", "#");

        //            //ICONO SI TIENE HIJOS
        //            if (Acc.NodoPadre == 0)
        //            {
        //                HtmlGenericControl icon = new HtmlGenericControl("i");
        //                icon.Attributes.Add("class", Acc.Icon);

        //                link.Controls.Add(icon);
        //            }
        //            //TEXTO
        //            HtmlGenericControl text = new HtmlGenericControl("span");
        //            text.InnerText = Acc.Descripcion;
        //            text.Attributes.Add("class", "d-md-inline-block ms-2");
        //            link.Controls.Add(text);


        //            menuItem.Controls.Add(link);



        //            //LISTADO HIJOS
        //            hijoItem = new HtmlGenericControl("ul");
        //            hijoItem.Attributes.Add("class", "dropdown-menu");
        //            hijoItem.Attributes.Add("aria-labelledby", "id_" + Acc.Id);

        //            menuItem.Controls.Add(hijoItem);
        //            foreach (ModuloDTO hijo in Hijos)
        //            {
        //                hijoItem.Controls.Add(generar_MenuItem(hijo, u));
        //            }
        //            menuDinamico.Controls.Add(menuItem);


        //        }
        //        else
        //        {
        //            menuItem = new HtmlGenericControl("li");
        //            menuItem.Attributes.Add("class", "nav-item");

        //            //LINK
        //            HtmlGenericControl item = new HtmlGenericControl("a");
        //            item.Attributes.Add("class", "navbar-nav-link rounded");
        //            item.Attributes.Add("onclick", "LoadingPanel.Show();");
        //            item.Attributes.Add("href", Global.ApplicationPath + Acc.Url);


        //            //ICONO SI NO TIENE HIJOS
        //            if (Acc.NodoPadre == 0)
        //            {
        //                HtmlGenericControl icon = new HtmlGenericControl("i");
        //                icon.Attributes.Add("class", Acc.Icon);

        //                item.Controls.Add(icon);
        //            }
        //            //TEXTO
        //            HtmlGenericControl text = new HtmlGenericControl("span");
        //            text.InnerText = Acc.Descripcion;
        //            text.Attributes.Add("class", "d-md-inline-block ms-2");
        //            item.Controls.Add(text);

        //            menuItem.Controls.Add(item);
        //            menuDinamico.Controls.Add(menuItem);

        //        }



        //    }
        //}

        //public static IList<ModuloDTO> GenerarListaNodos(List<Rol> lstRol, int Padre)
        //{

        //    IList<ModuloDTO> lista = ModuloService.getByRol_DTO(lstRol, Padre, 1);
        //    return lista;

        //}

        #endregion
    }
}