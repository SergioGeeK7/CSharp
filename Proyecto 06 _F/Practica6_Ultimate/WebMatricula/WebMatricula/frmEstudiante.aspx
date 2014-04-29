<%@ Page Title="" Language="C#" MasterPageFile="~/frmPrincipal.Master" AutoEventWireup="true" CodeBehind="frmEstudiante.aspx.cs" Inherits="WebMatricula.Formulario_web14" %>
<asp:Content ID="Content4" ContentPlaceHolderID="Cuerpo" runat="server">
    <table align="center" class="auto-style8">
        <tr>
            <td colspan="2" style="background-color: #000080; font-family: 'Comic Sans MS'; font-size: x-large; color: #FFFF00">Maestro de Estudiante</td>
        </tr>
        <tr>
            <td style="width: 35%">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">Facultad:</td>
            <td class="auto-style10">
                <asp:DropDownList ID="ddlFacultad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlFacultad_SelectedIndexChanged" Width="176px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Programa:</td>
            <td class="auto-style10">
                <asp:DropDownList ID="ddlPrograma" runat="server" Width="181px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Carné:</td>
            <td class="auto-style10">
                <asp:TextBox ID="txtCarne" runat="server" ReadOnly="True" Width="168px"></asp:TextBox>
&nbsp;
                <asp:ImageButton ID="ibtnBuscar" runat="server" ImageUrl="~/Imagenes/Buscar.jpg" OnClick="ibtnBuscar_Click" Visible="False" />
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Nro.Doc:</td>
            <td class="auto-style10">&nbsp;
                <asp:TextBox ID="txtNroDoc" runat="server" Width="158px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Nombre:</td>
            <td class="auto-style10">
                <asp:TextBox ID="txtNombre" runat="server" Width="170px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:CheckBox ID="chkActivo" runat="server" EnableTheming="True" Text="Activo" TextAlign="Left" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:RadioButtonList ID="rblJornada" runat="server" AutoPostBack="True" RepeatDirection="Horizontal">
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Observaciones:</td>
            <td style="text-align: left">
                <asp:TextBox ID="txtObservac" runat="server" style="text-align: left" Rows="3" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style11"></td>
        </tr>
        <tr>
            <td class="auto-style12" colspan="2">
                <asp:Menu ID="mnnOpciones" runat="server" Orientation="Horizontal" RenderingMode="Table" OnMenuItemClick="mnnOpciones_MenuItemClick">
                    <Items>
                        <asp:MenuItem Text="Buscar" Value="opcBuscar"></asp:MenuItem>
                        <asp:MenuItem Text="Agregar" Value="opcAgregar"></asp:MenuItem>
                        <asp:MenuItem Text="Modificar" Value="opcModificar"></asp:MenuItem>
                        <asp:MenuItem Text="Grabar" Value="opcGrabar"></asp:MenuItem>
                        <asp:MenuItem Text="Cancelar" Value="opcCancelar"></asp:MenuItem>
                        <asp:MenuItem Text="Imprimir" Value="opcImprimir"></asp:MenuItem>
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
                <asp:Label ID="lblMsj" runat="server" Width="98px"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content5" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style8 {
            width: 98%;
            border: 3px solid #0099CC;
        }
        .auto-style9 {
            text-align: right;
        }
        .auto-style10 {
            text-align: left;
        }
        .auto-style11 {
            height: 23px;
        }
        .auto-style12 {
            height: 25px;
        }
    </style>
</asp:Content>

