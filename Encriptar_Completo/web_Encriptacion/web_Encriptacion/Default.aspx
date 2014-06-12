<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="web_Encriptacion._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>

    <style type="text/css">
        .style1
        {
            width: 153px;
        }
        .style2
        {
            width: 153px;
            font-weight: bold;
        }
        .style4
        {
            text-decoration: underline;
            font-style: italic;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table width= "100%">
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    Cadena:&nbsp; </td>
                <td>
                    <asp:TextBox ID="TxtTexto" runat="server" TextMode="Password" Width="50%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    <asp:RadioButtonList ID="rdbL_Opciones" runat="server" 
                        RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True" Value="1">Encriptar</asp:ListItem>
                        <asp:ListItem Value="2">Desencriptar</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnProcesar" runat="server" onclick="btnProcesar_Click" 
                        Text="Procesar" />
                </td>
            </tr>
            <tr>
                <td align="right" class="style1" valign="top">
                    <br />
                    <b>Resultado:</b></td>
                <td>
                    <asp:TextBox ID="TxtRpta" runat="server" TextMode="MultiLine" 
                        Width="50%" Rows="5"></asp:TextBox>
                    <br />
                    Para ver el proceso de <i>Encriptar</i>:<br />
                    * Escriba un texto en el TextBox:&nbsp;<b><i>Cadena</i></b> , seleccione la opción:
                    <span class="style4">Encriptar</span> y presione el botón: <i><b>Procesar</b></i>, 
                    se mostrará en el textbox: <i><b>Resultado</b></i> la cadena encriptada.<br />
                    Para ver el proceso de <i>Desencriptar</i>:<br />
                    * Copie el texto encriptado en el TextBox: <b><i>Cadena,</i></b> Seleccione la opción: <span class="style4">Desencriptar,</span>&nbsp; 
                    presione el botón: <i><b>Procesar</b></i>, se mostrará en el textbox: <i><b>
                    Resultado</b></i> la cadena Desencriptada.</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
