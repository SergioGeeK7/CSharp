<%@ Page Title="" Language="C#" MasterPageFile="~/frmPrincipal.Master" AutoEventWireup="true" CodeBehind="frmFacultad.aspx.cs" Inherits="WebMatricula.Formulario_web11" %>

<asp:Content ID="Content4" ContentPlaceHolderID="Cuerpo" runat="server">

    <table align="center" class="auto-style8">
        <tr>
            <td colspan="2" style="background-color: #000099; font-family: 'Times New Roman', Times, serif; font-size: x-large; color: #FFFFFF;">Maestro de Facultad</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right">Codigo:</td>
            <td style="text-align: left">
                <asp:TextBox ID="txtCodigo" runat="server" Width="128px"></asp:TextBox>
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
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Menu ID="mnuOpciones" runat="server" BackColor="#3366FF" BorderStyle="Solid" BorderWidth="2px" DynamicHorizontalOffset="2" Font-Bold="True" Font-Size="Small" ForeColor="#CCFFFF"  Orientation="Horizontal" Width="100%">
                    <Items>
                        <asp:MenuItem Text="Buscar" Value="opcBuscar"></asp:MenuItem>
                        <asp:MenuItem Text="Agregar" Value="opcAgregar"></asp:MenuItem>
                        <asp:MenuItem Text="Grabar" Value="opcGrabar"></asp:MenuItem>
                        <asp:MenuItem Text="Cancelar" Value="opcCancelar"></asp:MenuItem>
                    </Items>
                    <StaticHoverStyle BackColor="#99CCFF" BorderWidth="2px" BorderColor="#6699FF" />
                    <StaticMenuItemStyle HorizontalPadding="40px" />
                </asp:Menu>
            </td>
        </tr>
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style9"></td>
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
        .auto-style8 {
            width: 90%;
             border: 3px solid #000099;
        }
        .auto-style9 {
            height: 23px;
        }
    </style>
</asp:Content>

