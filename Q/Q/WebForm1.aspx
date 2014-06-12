<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Q.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 299px;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style2 {
            height: 47px;
        }
        .auto-style3 {
            height: 36px;
        }
        .auto-style4 {
            width: 175px;
        }
        .auto-style5 {
            height: 36px;
            width: 175px;
        }
        .auto-style7 {
            height: 140px;
            width: 268435488px;
        }
        .auto-style8 {
            width: 130px;
        }
        .auto-style9 {
            height: 36px;
            width: 130px;
        }
        .auto-style11 {
            height: 140px;
        }
        .auto-style12 {
            height: 47px;
            width: 17px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style4">
                    <asp:Label ID="Label3" runat="server" Text="Cedula"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtcedula" runat="server"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/imagenes/Buscar.jpg" OnClick="ImageButton1_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="Nombres" runat="server" Text="Nombres"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="auto-style8">
                    <asp:Label ID="Label2" runat="server" Text="Apellidos"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtapellidos" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </td>
                <td class="auto-style12">
                </td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style11" rowspan="1"></td>
                <td class="auto-style7" colspan="2">
                    <asp:GridView ID="GridView1" runat="server" Visible="False">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style7" colspan="2">
                    <asp:Label ID="lblmensaje" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
