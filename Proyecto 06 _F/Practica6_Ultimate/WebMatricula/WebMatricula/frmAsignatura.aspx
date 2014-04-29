<%@ Page Title="" Language="C#" MasterPageFile="~/frmPrincipal.Master" AutoEventWireup="true" CodeBehind="frmAsignatura.aspx.cs" Inherits="WebMatricula.Formulario_web13" %>
<asp:Content ID="Content4" ContentPlaceHolderID="Cuerpo" runat="server">
    <table align="center" class="auto-style8">
        <tr>
            <td colspan="2" style="font-family: 'Comic Sans MS'; font-size: x-large; background-color: #000080; color: #FFFF00">Maestro de Asignatura</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9" style="width: 25%">Facultad:</td>
            <td style="text-align: left">
                <asp:DropDownList ID="ddlFacultad" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Programa:</td>
            <td style="text-align: left">
                <asp:DropDownList ID="ddlPrograma" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Codigo:</td>
            <td style="text-align: left">
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                <asp:ImageButton ID="ibtnBuscar" runat="server" Visible="False" />
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Nombre:</td>
            <td style="text-align: left">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Menu ID="mnnOpciones" runat="server" Orientation="Horizontal">
                    <Items>
                        <asp:MenuItem Text="Buscar" Value="opcBuscar"></asp:MenuItem>
                        <asp:MenuItem Text="Agregar" Value="opcAgregar"></asp:MenuItem>
                        <asp:MenuItem Text="Modificar" Value="opcModificar"></asp:MenuItem>
                        <asp:MenuItem Text="Grabar" Value="opcGrabar"></asp:MenuItem>
                        <asp:MenuItem Text="Cancelar" Value="opcCancelar"></asp:MenuItem>
                    </Items>
                    <StaticMenuItemStyle HorizontalPadding="15px" />
                </asp:Menu>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="grvDatos" runat="server" Width="316px">
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
    </style>
</asp:Content>

