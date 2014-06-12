<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="Q.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <div style="margin: 0 auto; text-align: center;">
    
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
        
        </div>    
    <br />


    <br />
   Codigo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtcodigo" runat="server"></asp:TextBox>
    <asp:ImageButton ID="btnbuscar" runat="server" Height="21px" ImageUrl="~/imagenes/Buscar.jpg" OnClick="ImageButton2_Click" Visible="False" Width="30px" />
    &nbsp;<br />
   Titulo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txttitulo" runat="server" ReadOnly="True"></asp:TextBox>
    
        
        <div style="float: right;position: relative;right: 400px;bottom: 40px">
        
    </div>

    <br />
   Numero de Horas <asp:TextBox ID="txtNumeroHoras" runat="server" ReadOnly="True"></asp:TextBox>
    <br />

   Temas<asp:CheckBoxList ID="cbltemas" runat="server" RepeatDirection="Horizontal">
    </asp:CheckBoxList>
&nbsp;<br />
   Costo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; $ <asp:TextBox ID="txtcosto" runat="server" ReadOnly="True" Width="128px"></asp:TextBox>
    <br />
    <hr style="border: 1px solid black"/>   
    <asp:GridView ID="GridView1" runat="server" Width="999px">
    </asp:GridView>

    <br />
    <asp:Label ID="lblmensaje" runat="server"></asp:Label>
    <br />


</asp:Content>
