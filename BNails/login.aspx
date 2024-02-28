<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BNails.login" %>

<%@ Register Assembly="DevExpress.Web.v18.1" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Betsa Log-In</title>

    <link href="App_Themes/Tema1/css/login/login.css" rel="stylesheet" />

    <script type="text/javascript">

        const signupButton = document.getElementById('<%= btnRegistrarse.ClientID %>'),
            loginButton = document.getElementById('login-button'),
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


</head>
<body>
    <form id="form1" runat="server">
        <section class="user">
            <div class="user_options-container">
                <div class="user_options-text">
                    <div class="user_options-unregistered">
                        <h2 class="user_unregistered-title">No tenés una cuenta?</h2>
                        <p class="user_unregistered-text">Registrarte ahora es muy sencillo!</p>
                        <dx:ASPxButton ID="btnRegistrarse" Text="Registrarme" runat="server" CssClass="user_unregistered-signup"></dx:ASPxButton>
                    </div>

                    <div class="user_options-registered">
                        <h2 class="user_registered-title">Ya tenés cuenta?</h2>
                        <p class="user_registered-text">Ingresá al sistema</p>
                        <dx:ASPxButton ID="btnLogin" runat="server" Text="Loguearme" CssClass="user_registered-login"></dx:ASPxButton>
                    </div>
                </div>

                <div class="user_options-forms" id="user_options-forms">
                    <div class="user_forms-login">
                        <h2 class="forms_title">Login</h2>
                        <form class="forms_form">
                            <fieldset class="forms_fieldset">
                                <div class="forms_field">
                                    <input type="email" placeholder="Email" class="forms_field-input" required autofocus />
                                </div>
                                <div class="forms_field">
                                    <input type="password" placeholder="Password" class="forms_field-input" required />
                                </div>
                            </fieldset>
                            <div class="forms_buttons">
                                <button type="button" class="forms_buttons-forgot">Forgot password?</button>
                                <input type="submit" value="Log In" class="forms_buttons-action" />
                            </div>
                        </form>
                    </div>
                    <div class="user_forms-signup">
                        <h2 class="forms_title">Sign Up</h2>
                        <form class="forms_form">
                            <fieldset class="forms_fieldset">
                                <div class="forms_field">
                                    <input type="text" placeholder="Full Name" class="forms_field-input" required />
                                </div>
                                <div class="forms_field">
                                    <input type="email" placeholder="Email" class="forms_field-input" required />
                                </div>
                                <div class="forms_field">
                                    <input type="password" placeholder="Password" class="forms_field-input" required />
                                </div>
                            </fieldset>
                            <div class="forms_buttons">
                                <input type="submit" value="Sign up" class="forms_buttons-action" />
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </section>
    </form>
</body>
</html>
