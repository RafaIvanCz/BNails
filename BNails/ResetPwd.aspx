﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPwd.aspx.cs" Inherits="BNails.ResetPwd" %>

<%@ Register Assembly="DevExpress.Web.v18.1" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Recuperación de Contraseña</title>

    <%--Style links--%>
    <link href="App_Themes/Tema1/css/resetPwd/resetPwd.css" rel="stylesheet" />
    <link href="App_Themes/Tema1/css/layout.css" rel="stylesheet" />
    <link href="App_Themes/Tema1/css/layout.min.css" rel="stylesheet" />
    <link href="App_Themes/Tema1/css/components.css" rel="stylesheet" />
    <link href="App_Themes/Tema1/css/components.min.css" rel="stylesheet" />

    <%--bs styles--%>
    <link href="App_Themes/Tema1/css/bootstrap/all.min.css" rel="stylesheet" />
    <link href="App_Themes/Tema1/css/bootstrap/bootstrap.css" rel="stylesheet" />
    <link href="App_Themes/Tema1/css/bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="App_Themes/Tema1/css/bootstrap/bootstrap_limitless.css" rel="stylesheet" />
    <link href="App_Themes/Tema1/css/bootstrap/bootstrap_limitless.min.css" rel="stylesheet" />

    <%-- bs JS --%>
    <script src="App_Themes/Tema1/js/app.js"></script>
    <script src="App_Themes/Tema1/js/bootstrap.bundle.min.js"></script>
    <script src="App_Themes/Tema1/js/custom.js"></script>
    <script src="App_Themes/Tema1/js/jquery.min.js"></script>
    <script src="App_Themes/Tema1/js/prism.min.js"></script>

    <%-- Swal JS & css --%>
    <script src="App_Themes/Tema1/sweetAlerts/extra_sweetalert.js"></script>
    <script src="App_Themes/Tema1/sweetAlerts/sweet_alert.min.js"></script>
    <link href="App_Themes/Tema1/sweetAlerts/sweetalert2.min.css" rel="stylesheet" />

</head>
<body>
    <form id="resetPwd" runat="server">
        <section class="user">
            <div class="user_options-container">
                <div class="user_options-forms w-50 h-50" id="user_options-forms">
                    <div class="user_forms-login">
                        <h2 class="forms_title">Recuperar contraseña</h2>
                        <section class="forms_form">
                            <fieldset class="forms_fieldset">
                                <div class="forms_field">
                                    <dx:ASPxTextBox ID="txtEmailRestorePwd" ClientInstanceName="txtEmailRestorePwd" CssClass="forms_field-input" AutoCompleteType="Disabled" NullText="ejemplo@ejemplo.com" Width="100%" runat="server">
                                        <ValidationSettings SetFocusOnError="True" Display="Dynamic" ErrorTextPosition="Bottom">
                                            <RequiredField IsRequired="True" ErrorText="Campo Obligatorio." />
                                            <RegularExpression ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                                ErrorText="E-mail inválido." />
                                        </ValidationSettings>
                                    </dx:ASPxTextBox>
                                </div>
                            </fieldset>
                            <div class="mt-5 d-flex justify-content-end me-5">
                                <dx:ASPxButton ID="btnRestablecer" CssClass="text-decoration-none forms_buttons-action" RenderMode="Link" runat="server" Text="Restablecer">
                                    <ClientSideEvents Click="function(s,e){}" />
                                </dx:ASPxButton>
                            </div>
                        </section>
                    </div>
                </div>
            </div>
        </section>
    </form>
</body>
</html>
