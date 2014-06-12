<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Q.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:Timer ID="Timer1" runat="server" Interval="1500" OnTick="Timer1_Tick">
    </asp:Timer>

    
    <h1>Proyecto Final</h1>
    <h2>Sergio Andres Arboleda Cardona</h2>
    <h3>Fecha entegra 29/05/2014</h3>



</asp:Content>
