<%@ Page Title="" Language="C#" MasterPageFile="~/frmPrincipal.Master" AutoEventWireup="true" CodeBehind="frmInformeEstudiante.aspx.cs" Inherits="WebMatricula.Formulario_web17" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content4" ContentPlaceHolderID="Cuerpo" runat="server">
    <CR:CrystalReportViewer ID="crvVerInforme" runat="server" AutoDataBind="true" />
</asp:Content>
