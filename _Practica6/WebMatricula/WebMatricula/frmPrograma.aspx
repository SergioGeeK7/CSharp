<%@ Page Title="" Language="C#" MasterPageFile="~/frmPrincipal.Master" AutoEventWireup="true" CodeBehind="frmPrograma.aspx.cs" Inherits="WebMatricula.Formulario_web12" %>
<asp:Content ID="Content4" ContentPlaceHolderID="Cuerpo" runat="server">
    <table align="center" class="auto-style8">
        <tr>
            <td colspan="2" style="font-family: 'Comic Sans MS'; background-color: #0000FF; color: #FFFFFF; font-size: x-large">Maestro de Programa</td>
        </tr>
        <tr>
            <td class="auto-style10"></td>
            <td class="auto-style11" style="text-align: left"></td>
        </tr>
        <tr>
            <td class="auto-style9" style="width: 25%">Facultad:</td>
            <td style="text-align: left">
                <asp:DropDownList ID="ddlFacultad" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 25%">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nombre:</td>
            <td style="text-align: left">
                <asp:TextBox ID="txtNombre" runat="server" Width="100px"></asp:TextBox>
                <asp:TextBox ID="txtCodigo" runat="server" Width="16px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 25%">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Menu ID="mnnOpciones" runat="server" Orientation="Horizontal">
                    <Items>
                        <asp:MenuItem Text="Agregar" Value="opcAgregar"></asp:MenuItem>
                        <asp:MenuItem Text="Modificar" Value="opcModificar"></asp:MenuItem>
                        <asp:MenuItem Text="Grabar" Value="opcGrabar"></asp:MenuItem>
                        <asp:MenuItem Text="Cancelar" Value="opcCancelar"></asp:MenuItem>
                    </Items>
                    <StaticMenuItemStyle HorizontalPadding="20px" />
                </asp:Menu>
            </td>
        </tr>
        <tr>
            <td class="auto-style11" colspan="2"></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="grvDatos" runat="server" Width="346px">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMsj" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content5" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style8 {
            width: 80%;
        }
        .auto-style9 {
            text-align: right;
        }
        .auto-style10 {
            text-align: right;
            width: 25%;
            height: 23px;
        }
        .auto-style11 {
            height: 23px;
        }
    </style>
</asp:Content>

