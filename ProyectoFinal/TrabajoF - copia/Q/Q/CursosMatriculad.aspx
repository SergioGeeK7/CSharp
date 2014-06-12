<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="CursosMatriculad.aspx.cs" Inherits="Q.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Menu ID="mnnOpciones" runat="server" OnMenuItemClick="mnnOpciones_MenuItemClick" Orientation="Horizontal" BackColor="#4982C4" BorderStyle="Ridge">
        <Items>
            <asp:MenuItem Text="Buscar" Value="Buscar"></asp:MenuItem>
            <asp:MenuItem Text="Modificar" Value="Modificar"></asp:MenuItem>
            <asp:MenuItem Text="Nuevo" Value="Agregar"></asp:MenuItem>
            <asp:MenuItem Text="Grabar" Value="Grabar"></asp:MenuItem>
            <asp:MenuItem Text="Cancelar" Value="Cancelar"></asp:MenuItem>
            <asp:MenuItem Text="Mostrar Todo" Value="MostrarTodo"></asp:MenuItem>
        </Items>
        <StaticMenuItemStyle HorizontalPadding="20px" />
    </asp:Menu>
        
        <br />
Cedula&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:TextBox ID="txtcedula" runat="server" Height="20px" Width="170px"></asp:TextBox>
    <asp:ImageButton ID="btnbuscar" runat="server" Height="21px" ImageUrl="~/imagenes/Buscar.jpg" OnClick="ImageButton2_Click" Visible="False" Width="30px" />
    <br />
    Curso&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="comboocurso" runat="server" OnSelectedIndexChanged="comboocurso_SelectedIndexChanged" AutoPostBack="True" Height="25px" Width="173px" Enabled="False">
    </asp:DropDownList>
    <br />
    Periodo&nbsp;&nbsp; <asp:DropDownList ID="comboperiodo" runat="server" Height="25px" Width="172px" OnSelectedIndexChanged="combofecha_SelectedIndexChanged" Enabled="False">
    </asp:DropDownList>
    <div style="float: right;position: relative;right: 40px;bottom: 50px">
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
     </div>    
    <br />
    Jornada&nbsp;  
    <asp:DropDownList ID="combojornada" runat="server" Height="25px" Width="172px" Enabled="False">
    </asp:DropDownList>
    <br />
    Pago&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
    <asp:DropDownList ID="combopago" runat="server" Height="26px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="172px" Enabled="False">
    </asp:DropDownList>
    <br />
    Estado&nbsp;&nbsp;$  <asp:TextBox ID="txtestado" runat="server" Height="20px" Width="162px"></asp:TextBox>
    &nbsp;
    <br />
    <asp:Label ID="lblmensaje" runat="server"></asp:Label>
</asp:Content>
