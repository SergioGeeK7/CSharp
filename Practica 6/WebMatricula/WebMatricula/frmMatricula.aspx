<%@ Page Title="" Language="C#" MasterPageFile="~/frmPrincipal.Master" AutoEventWireup="true" CodeBehind="frmMatricula.aspx.cs" Inherits="WebMatricula.Formulario_web15" %>

<asp:Content ID="Content4" ContentPlaceHolderID="Cuerpo" runat="server">

    <table align="center" class="auto-style7">
        <tr>
            <td colspan="2" style="font-family: 'Times New Roman', Times, serif; font-size: x-large; color: #FFFFFF; background-color: #000099">Maestro de Matricula</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8" style="text-align: right">Periodo:</td>
            <td class="auto-style8" style="text-align: left">
                <asp:DropDownList ID="ddlPeriodo" runat="server" OnSelectedIndexChanged="ddlPeriodo_SelectedIndexChanged" Width="170px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="text-align: right">Carnet: </td>
            <td style="text-align: left">
                <asp:TextBox ID="txtCarnet" runat="server"></asp:TextBox>
                <asp:ImageButton ID="ibtnBuscar" runat="server" ImageUrl="~/imagenes/Buscar.jpg" Visible="False" OnClick="ibtnBuscar_Click" />
            </td>
        </tr>
        <tr>
            <td style="text-align: right">Nombre:</td>
            <td style="text-align: left">
                <asp:Label ID="lblNombre" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: right">Programa:&nbsp; </td>
            <td style="text-align: left">
                <asp:Label ID="lblPrograma" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: right">&nbsp;</td>
            <td style="text-align: left">&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right">Asignatura:</td>
            <td style="text-align: left">
                <asp:DropDownList ID="ddlAsignatura" runat="server" Width="170px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Menu ID="mnuOpciones" runat="server" BackColor="#3366FF" BorderStyle="Solid" BorderWidth="2px" DynamicHorizontalOffset="2" Font-Bold="True" Font-Size="Small" ForeColor="#CCFFFF"  Orientation="Horizontal" Width="100%" OnMenuItemClick="mnuOpciones_MenuItemClick">
                    <Items>
                        <asp:MenuItem Text="Nuevo" Value="opcNuevo"></asp:MenuItem>
                        <asp:MenuItem Text="Matricular" Value="opcMatricular"></asp:MenuItem>
                        <asp:MenuItem Text="Imprimir" Value="opcImprimir"></asp:MenuItem>
                    </Items>
                    <StaticHoverStyle BackColor="#99CCFF" BorderWidth="2px" BorderColor="#6699FF" />
                    <StaticMenuItemStyle HorizontalPadding="50px" />
                </asp:Menu>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
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
        .auto-style8 {
            height: 23px;
        }
    </style>
</asp:Content>

