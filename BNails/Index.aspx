<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BNails.Index" %>

<%@ Register Assembly="DevExpress.Web.v18.1" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <section class="d-flex justify-content-center">
        <div class="card w-25">
            <img src="App_Themes/Tema1/assets/img/Image-1.jpeg" />
            <img src="App_Themes/Tema1/assets/img/Image-2.jpeg" />
            <img src="App_Themes/Tema1/assets/img/Image-3.jpeg" />
            <div class="card-body">
                <h5 class="card-title">Card title</h5>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <a href="#" class="btn btn-primary">Go somewhere</a>
            </div>
        </div>
    </section>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
