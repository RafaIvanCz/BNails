<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BNails.Index" %>

<%@ Register Assembly="DevExpress.Web.v18.1" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">

    <link href="App_Themes/Tema1/css/index/index.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />


</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <section id="sectionHeader" class="bg-danger-subtle text-danger-emphasis mb-5 vh-100 hero-bg" >
        <div class="pb-5">
            <h1 class="text-hero1 caveat-hero">Transformando tus manos <br /> <spam>en una obra de arte</spam></h1>
            <%--<h1 class="text-hero2 caveat-hero">en una obra de arte</h1>--%>
        </div>
        <div class="">
            <h5 class="text-below-hero mb-0">Soy Betsabé, una apasionada por el cuidado de manos. Con dedicación y habilidad,</h5>
            <h5 class="text-below-hero">te invito a descubrir el encanto de una manicura verdaderamente única</h5>
            <h5 class="text-below-hero">Bienvenida a mi espacio de belleza y confianza!</h5>
        </div>
    </section>

    <section class="mt-3" id="section1">
        <div class="row gx-0 d-flex justify-content-around">
            <div class="card col-3">
                <img src="App_Themes/Tema1/assets/img/Image-1.jpeg" class="rounded-1" />
                <div class="card-body">
                    <h5 class="card-title">Card title</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <%--<a href="#" class="btn btn-primary">Go somewhere</a>--%>
                </div>
            </div>

            <div class="card col-3">
                <img src="App_Themes/Tema1/assets/img/Image-2.jpeg" class="rounded-1" />
                <div class="card-body">
                    <h5 class="card-title">Card title</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <%--<a href="#" class="btn btn-primary">Go somewhere</a>--%>
                </div>
            </div>

            <div class="card col-3">
                <img src="App_Themes/Tema1/assets/img/Image-3.jpeg" class="rounded-1" />
                <div class="card-body">
                    <h5 class="card-title">Card title</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <%--<a href="#" class="btn btn-primary">Go somewhere</a>--%>
                </div>
            </div>
            <div class="row d-flex justify-content-center">
                <div class="card col-11 px-0">
                    <dx:ASPxButton ID="btnSeccion1" runat="server" Text="Ir a la Sección 1" CssClass="border border-danger border-width-3 p-3 fs-1 text-danger fw-semibold rounded-2 btn-seccion"></dx:ASPxButton>
                </div>
            </div>

        </div>
    </section>
    <fieldset><legend class="col-lg-12 border-danger border-bottom border-width-3"></legend></fieldset>

    <section class="d-flex justify-content-center mt-5" id="section2">
        <div class="row gx-0">
            <div class="card col-4 w-25 border border-0">
                <img src="App_Themes/Tema1/assets/img/Image-4.jpeg" class="rounded-1" />
                <div class="card-body">
                    <h5 class="card-title">Card title</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <%--<a href="#" class="btn btn-primary">Go somewhere</a>--%>
                </div>
            </div>

            <div class="card col-4">
                <img src="App_Themes/Tema1/assets/img/Image-5.jpeg" class="rounded-1" />
                <div class="card-body">
                    <h5 class="card-title">Card title</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <%--<a href="#" class="btn btn-primary">Go somewhere</a>--%>
                </div>
            </div>

            <div class="card col-4">
                <img src="App_Themes/Tema1/assets/img/Image-6.jpeg" class="rounded-1" />
                <div class="card-body">
                    <h5 class="card-title">Card title</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <%--<a href="#" class="btn btn-primary">Go somewhere</a>--%>
                </div>
            </div>
            <div class="row d-flex justify-content-center">
                <div class="card col-11 px-0">
                    <dx:ASPxButton ID="btnSeccion2" runat="server" Text="Ir a la Sección 2" CssClass="border border-danger border-width-3 p-3 fs-1 text-danger fw-semibold rounded-2 btn-seccion"></dx:ASPxButton>
                </div>
            </div>

        </div>
    </section>
    <fieldset><legend class="col-lg-12 border-danger border-bottom border-width-3"></legend></fieldset>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
