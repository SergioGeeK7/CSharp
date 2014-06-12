<%@ Page Title="" Language="C#" MasterPageFile="~/frmPrincipal.Master" AutoEventWireup="true" CodeBehind="frmMatricula.aspx.cs" Inherits="WebMatricula.Formulario_web15" %>
<asp:Content ID="Content4" ContentPlaceHolderID="Cuerpo" runat="server">
    <table align="center" class="auto-style8">
        <tr>
            <td colspan="2" style="background-color: #0000FF; font-family: 'Comic Sans MS'; color: #FFFFFF; font-size: x-large">Asesoría/Matrícula</td>
        </tr>
        <tr>
            <td class="auto-style9" style="width: 25%">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9" style="width: 25%">Periodo:</td>
            <td style="text-align: left">
                <asp:DropDownList ID="ddlPeriodo" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style9" style="width: 25%">Carné:</td>
            <td style="text-align: left">
                <asp:TextBox ID="txtCarne" runat="server" ReadOnly="True"></asp:TextBox>
                <asp:ImageButton ID="ibtnBuscar" runat="server" ImageUrl="~/Imagenes/Buscar.jpg" OnClick="ibtnBuscar_Click" Visible="False" />
            </td>
        </tr>
        <tr>
            <td class="auto-style9" style="width: 25%">Nombre:</td>
            <td style="text-align: left">
                <asp:Label ID="lblNombre" runat="server" style="text-align: left"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style9" style="width: 25%">Programa:</td>
            <td style="text-align: left">
                <asp:Label ID="lblPrograma" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style9" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">Asignatura:</td>
            <td class="auto-style10">
                <asp:DropDownList ID="ddlAsignatura" runat="server" Height="17px" Width="258px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style10" colspan="2"></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Menu ID="mnnOpciones" runat="server" Orientation="Horizontal" OnMenuItemClick="mnnOpciones_MenuItemClick">
                    <Items>
                        <asp:MenuItem Text="Nuevo" Value="opcNuevo"></asp:MenuItem>
                        <asp:MenuItem Text="Matricular" Value="opcMatricular"></asp:MenuItem>
                        <asp:MenuItem Text="Imprimir" Value="opcImprimir"></asp:MenuItem>
                    </Items>
                    <StaticMenuItemStyle HorizontalPadding="30px" />
                </asp:Menu>
            </td>
        </tr>
        <tr>
            <td class="auto-style9" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9" colspan="2">
                <asp:GridView ID="grvDatos" runat="server" Width="347px">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style9" colspan="2">
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
        .auto-style9 {}
        .auto-style10 {
            height: 23px;
            text-align: left;
        }
        .auto-style12 {
            width: 25%;
            height: 23px;
        }
    </style>
</asp:Content>


