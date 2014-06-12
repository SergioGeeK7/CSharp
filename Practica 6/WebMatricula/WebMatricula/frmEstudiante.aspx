<%@ Page Title="" Language="C#" MasterPageFile="~/frmPrincipal.Master" AutoEventWireup="true" CodeBehind="frmEstudiante.aspx.cs" Inherits="WebMatricula.Formulario_web14" %>

<asp:Content ID="Content4" ContentPlaceHolderID="Cuerpo" runat="server">

    <table align="center" class="auto-style7">
        <tr>
            <td class="auto-style8" colspan="2" style="background-color: #000099; font-family: 'Times New Roman', Times, serif; color: #FFFFFF; font-size: x-large;">Maestro de Estudiante</td>
        </tr>
        <tr>
            <td style="width: 35%">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">Facultad:</td>
            <td style="text-align: left">
                <asp:DropDownList ID="ddlFacultad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlFacultad_SelectedIndexChanged" Width="170px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Programa:</td>
            <td style="text-align: left">
                <asp:DropDownList ID="ddlPrograma" runat="server" Width="176px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Carne:</td>
            <td style="text-align: left">
                <asp:TextBox ID="txtCarnet" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;
                <asp:ImageButton ID="ibtnBuscar" runat="server" ImageUrl="~/imagenes/Buscar.jpg" Visible="False" OnClick="ibtnBuscar_Click" style="width: 23px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Nro. Doc:</td>
            <td style="text-align: left">
                <asp:TextBox ID="txtNroDoc" runat="server"></asp:TextBox>
&nbsp; </td>
        </tr>
        <tr>
            <td class="auto-style9">Nombre: </td>
            <td style="text-align: left">
                <asp:TextBox ID="txtNombre" runat="server" style="text-align: left"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8" colspan="2" style="text-align: center">
                <asp:CheckBox ID="chkActivo" runat="server" Text="Activo" TextAlign="Left" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center; line-height: normal;">
                <asp:RadioButtonList ID="rblJornada" runat="server" AutoPostBack="True" RepeatDirection="Horizontal">
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Observaciones: </td>
            <td class="auto-style8" style="text-align: left">
                <asp:TextBox ID="txtObservac" runat="server" Height="61px" Rows="3" TextMode="MultiLine" Width="279px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8" colspan="2">
                <asp:Menu ID="mnuOpciones" runat="server" BackColor="#3366FF" BorderStyle="Solid" BorderWidth="2px" DynamicHorizontalOffset="2" Font-Bold="True" Font-Size="Small" ForeColor="#CCFFFF"  Orientation="Horizontal" Width="100%" OnMenuItemClick="mnuOpciones_MenuItemClick">
                    <Items>
                        <asp:MenuItem Text="Buscar" Value="opcBuscar"></asp:MenuItem>
                        <asp:MenuItem Text="Agregar" Value="opcAgregar"></asp:MenuItem>
                        <asp:MenuItem Text="Modificar" Value="opcModificar"></asp:MenuItem>
                        <asp:MenuItem Text="Grabar" Value="opcGrabar"></asp:MenuItem>
                        <asp:MenuItem Text="Cancelar" Value="opcCancelar"></asp:MenuItem>
                        <asp:MenuItem Text="Imprimir" Value="opcImprimir"></asp:MenuItem>
                    </Items>
                    <StaticHoverStyle BackColor="#99CCFF" BorderWidth="2px" BorderColor="#6699FF" />
                    <StaticMenuItemStyle HorizontalPadding="20px" />
                </asp:Menu>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style8">
                <asp:Label ID="lblMsj" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
<asp:Content ID="Content5" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style7 {
            width: 98%;
            border: 3px solid #000099;
        }
        .auto-style8 {
            height: 23px;
        }
        .auto-style9 {
            text-align: right;
        }
        .auto-style10 {
            height: 23px;
            text-align: right;
        }
    </style>
</asp:Content>



