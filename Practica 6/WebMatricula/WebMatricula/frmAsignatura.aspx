<%@ Page Title="" Language="C#" MasterPageFile="~/frmPrincipal.Master" AutoEventWireup="true" CodeBehind="frmAsignatura.aspx.cs" Inherits="WebMatricula.Formulario_web13" %>

<asp:Content ID="Content4" ContentPlaceHolderID="Cuerpo" runat="server">

    <table align="center" class="auto-style7">
        <tr>
            <td colspan="2" style="font-family: 'Times New Roman', Times, serif; color: #FFFFFF; font-size: x-large; background-color: #000099;">Maestro de Asignatura</td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right">Facultad:</td>
            <td style="text-align: left">
                <asp:DropDownList ID="ddlFacultad" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="text-align: right">Programa:</td>
            <td style="text-align: left">
                <asp:DropDownList ID="ddlPrograma" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="text-align: right">Codigo:</td>
            <td style="text-align: left">
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                <asp:ImageButton ID="ibtnBuscar" runat="server" ImageUrl="~/imagenes/Buscar.jpg" Visible="False" />
            </td>
        </tr>
        <tr>
            <td style="text-align: right">Nombre:</td>
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
                <asp:Menu ID="mnnOpciones" runat="server" BackColor="#3366FF" BorderStyle="Solid" BorderWidth="2px" DynamicHorizontalOffset="2" Font-Bold="True" Font-Size="Small" ForeColor="#CCFFFF" Orientation="Horizontal" Width="100%">
                    <Items>
                        <asp:MenuItem Text="Buscar" Value="opcBuscar"></asp:MenuItem>
                        <asp:MenuItem Text="Agregar" Value="opcAgregar"></asp:MenuItem>
                        <asp:MenuItem Text="Modificar" Value="opcModificar"></asp:MenuItem>
                        <asp:MenuItem Text="Grabar" Value="opcGrabar"></asp:MenuItem>
                        <asp:MenuItem Text="Cancelar" Value="opcCancelar"></asp:MenuItem>
                    </Items>
                    <StaticHoverStyle BorderWidth="2px" />
                    <StaticMenuItemStyle HorizontalPadding="22px" />
                </asp:Menu>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="grvDatos" runat="server">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMsj" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
<asp:Content ID="Content5" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style7 {
            width: 80%;
        }
    </style>
</asp:Content>

