<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SistemaFacturacionWeb._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Sistema facturacion</h1>
                <h2>Ejemplo sencillo de un sistema de facturacion</h2>
            </hgroup>
            <p>
                realizado con mucha perseverancia
                <a href="http://forums.asp.net/18.aspx" title="ASP.NET Forum">our forums</a>.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <table class="auto-style1">
        <tr>
            <td>



                <ol class="round">
                    <li class="one">
                        <h5>Clientes</h5>
                        <p>Mantenimiento de clientes</p>

                    </li>
                    <li class="two">
                        <h5>Productos</h5>
                        <p>Mantenimiento de Productos</p>
                    </li>
                    <li class="three">
                        <h5>Facturas</h5>
                        <p>Permite crear nuevas facturas</p>
                    </li>
                    <li class="four">
                        <h5>Administracion de permisos</h5>
                        <p>Establecer permisos de los usuarios</p>
                    </li>

                </ol>
            </td>
            <td>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/fotoitm.jpg" Height="170px" Width="534px" />

            </td>
        </tr>
    </table>




</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>

