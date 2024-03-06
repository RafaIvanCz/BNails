<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BNails.login" %>

<%@ Register Assembly="DevExpress.Web.v18.1" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Betsa Log-In</title>

    <%--Style links--%>
    <link href="App_Themes/Tema1/css/login/login.css" rel="stylesheet" />
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

    <script type="text/javascript">

        function showMessage(Mensaje) {

            Swal.fire({
                title: '',
                text: Mensaje,
                confirmButtonText: 'Continuar'
            });
        }

    </script>


</head>
<body>
    <form id="form1" runat="server">
        <section class="user">
            <div class="user_options-container">
                <div class="user_options-text">
                    <div class="user_options-unregistered">
                        <h2 class="user_unregistered-title">No tenés una cuenta?</h2>
                        <h6 class="user_unregistered-text">Registrarte es muy sencillo!</h6>
                        <dx:ASPxButton ID="btnRegistrarse" Text="Registrarme" AutoPostBack="false" runat="server" CssClass="text-danger fw-semibold user_unregistered-signup"></dx:ASPxButton>
                    </div>

                    <div class="user_options-registered">
                        <h2 class="user_registered-title">Ya tenés cuenta?</h2>
                        <h6 class="user_registered-text">Ingresá al sistema</h6>
                        <dx:ASPxButton ID="btnLogin" runat="server" Text="Loguearme" AutoPostBack="false" CssClass="text-danger fw-semibold user_registered-login"></dx:ASPxButton>
                    </div>
                </div>

                <div class="user_options-forms" id="user_options-forms">
                    <div class="user_forms-login">
                        <h2 class="forms_title mb-4">Login</h2>
                        <section class="forms_form">
                            <fieldset class="forms_fieldset">
                                <div class="forms_field">
                                    <dx:ASPxTextBox ID="txtUserEmail" NullText="E-mail" Width="100%" CssClass="forms_field-input" runat="server" ClientInstanceName="txtUserEmail">
                                        <ValidationSettings ValidationGroup="ingreso" Display="Dynamic" ErrorTextPosition="Bottom">
                                            <RequiredField IsRequired="True" ErrorText="Campo Obligatorio." />
                                            <RegularExpression ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                                ErrorText="Formato inválido. 'ejemplo@ejemplo.com'" />
                                        </ValidationSettings>
                                    </dx:ASPxTextBox>
                                </div>
                                <%--<div class="form-group d-flex align-items-center">
                                    <dx:ASPxLabel ID="lblError" Visible="false" runat="server" Text="" CssClass="alert alert-danger"></dx:ASPxLabel>
                                </div>--%>
                                <div class="forms_field">
                                    <dx:ASPxTextBox ID="txtPassword" Password="true" NullText="Contraseña" CssClass="forms_field-input" runat="server" ClientInstanceName="txtPassword">
                                        <ValidationSettings ValidationGroup="ingreso" SetFocusOnError="true" Display="Dynamic" ErrorTextPosition="Bottom">
                                            <RequiredField IsRequired="True" ErrorText="Campo Obligatorio." />
                                        </ValidationSettings>
                                    </dx:ASPxTextBox>
                                </div>
                            </fieldset>
                            <div class="forms_buttons">

                                <dx:ASPxHyperLink ID="ASPxHyperLink1" runat="server" CssClass="fw-medium text-pink text-decoration-none" Cursor="pointer" Text="Olvidaste la contraseña?" Font-Size="Small" NavigateUrl="~/ResetPwd.aspx">
                                </dx:ASPxHyperLink>

                                <%--<dx:ASPxButton ID="btnForgotPassword" runat="server" Text="Olvidaste la contraseña?" RenderMode="Link" CssClass="text-danger fw-semibold forms_buttons-forgot"></dx:ASPxButton>--%>

                                <dx:ASPxButton ID="btnIngresar" CssClass="text-decoration-none forms_buttons-action" RenderMode="Link" OnClick="btnIngresar_Click" runat="server" Text="Ingresar">
                                    <ClientSideEvents Click="function(s,e){}" />
                                </dx:ASPxButton>

                                <%--<input type="submit" value="Log In" class="forms_buttons-action" />--%>
                            </div>
                        </section>
                    </div>
                    <div class="user_forms-signup">
                        <h2 class="forms_title mb-4">Registro</h2>
                        <section class="forms_form">
                            <fieldset class="forms_fieldset">
                                <div class="forms_field">
                                    <dx:ASPxTextBox ID="txtNombreRegister" NullText="Nombre" Width="100%" CssClass="forms_field-input" runat="server" ClientInstanceName="txtNombreRegister">
                                        <ValidationSettings ValidationGroup="registro" Display="Dynamic" ErrorTextPosition="Bottom">
                                            <RequiredField IsRequired="True" ErrorText="Campo Obligatorio." />
                                        </ValidationSettings>
                                    </dx:ASPxTextBox>
                                </div>
                                <div class="forms_field">
                                    <dx:ASPxTextBox ID="txtApellidoRegister" NullText="Apellido" Width="100%" CssClass="forms_field-input" runat="server" ClientInstanceName="txtApellidoRegister">
                                        <ValidationSettings ValidationGroup="registro" Display="Dynamic" ErrorTextPosition="Bottom">
                                            <RequiredField IsRequired="True" ErrorText="Campo Obligatorio." />
                                        </ValidationSettings>
                                    </dx:ASPxTextBox>
                                </div>
                                <div class="forms_field">
                                    <dx:ASPxTextBox ID="txtEmailRegister" NullText="Correo electrónico" Width="100%" CssClass="forms_field-input" runat="server" ClientInstanceName="txtEmailRegister">
                                        <ValidationSettings ValidationGroup="registro" Display="Dynamic" ErrorTextPosition="Bottom">
                                            <RequiredField IsRequired="True" ErrorText="Campo Obligatorio." />
                                            <RegularExpression ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                                ErrorText="E-mail inválido. <br/> Formato correcto 'ejemplo@ejemplo.com'" />
                                        </ValidationSettings>
                                    </dx:ASPxTextBox>
                                </div>
                                <div class="forms_field">
                                    <dx:ASPxTextBox ID="txtPasswordRegister" Password="true" NullText="Contraseña" Width="100%" CssClass="forms_field-input" runat="server" ClientInstanceName="txtPasswordRegister">
                                        <ValidationSettings ValidationGroup="registro" Display="Dynamic" ErrorTextPosition="Bottom">
                                            <RequiredField IsRequired="True" ErrorText="Campo Obligatorio." />
                                        </ValidationSettings>
                                    </dx:ASPxTextBox>
                                </div>
                            </fieldset>
                            <div class="forms_buttons">
                                <dx:ASPxButton ID="btnRegistro" runat="server" Text="Registrarme" RenderMode="Link" CssClass="text-decoration-none forms_buttons-action" OnClick="btnRegistro_Click"></dx:ASPxButton>
                            </div>
                        </section>
                    </div>
                </div>
            </div>
        </section>
    </form>

    <dx:ASPxLoadingPanel Theme="Moderno" ID="ASPxLoadingPanel2" Modal="true" ForeColor="#106488" ClientInstanceName="LoadingPanel"
        runat="server" Text="Por favor espere...">
    </dx:ASPxLoadingPanel>

    

</body>

    <script type="text/javascript">

        var signupButton = document.getElementById('btnRegistrarse'),
            loginButton = document.getElementById('btnLogin'),
            userForms = document.getElementById('user_options-forms')

        /**
         * Add event listener to the "Sign Up" button
         */
        signupButton.addEventListener('click', () => {
            userForms.classList.remove('bounceRight')
            userForms.classList.add('bounceLeft')
        }, false)

        /**
         * Add event listener to the "Login" button
         */
        loginButton.addEventListener('click', () => {
            userForms.classList.remove('bounceLeft')
            userForms.classList.add('bounceRight')
        }, false)       

    </script>

</html>
