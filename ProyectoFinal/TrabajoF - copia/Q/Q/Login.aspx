﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Q.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        
    <link href="http://fonts.googleapis.com/css?family=Source+Sans+Pro:200,300,400,600,700,900" rel="stylesheet" />
    <link href="default.css" rel="stylesheet" type="text/css" media="all" />
    <link href="fonts.css" rel="stylesheet" type="text/css" media="all" />
    
</head>
<body>
  
    
    
<div id="wrapper">
	<div id="header-wrapper">
		<div id="header" class="container">
			<div id="logo">
			 <img src="images/Logo.png" alt="Alternate Text" id="logoo"/>
			</div>
			<div id="social">
				<ul class="contact">
					<li><a href="#" class="icon icon-twitter"><span>Twitter</span></a></li>
					<li><a href="#" class="icon icon-facebook"><span></span></a></li>
					<li><a href="#" class="icon icon-dribbble"><span>Pinterest</span></a></li>
					<li><a href="#" class="icon icon-tumblr"><span>Google+</span></a></li>
					<li><a href="#" class="icon icon-rss"><span>Pinterest</span></a></li>
				</ul>
			</div>
		</div>
	
	</div>
    

    <!--id page class container-->
      
    <!--here begin-->
      
    <form id="form1" runat="server">
    <div class="container" id="page">
     

    Bienvenido
    <br />
   Usuario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtusuario" runat="server"></asp:TextBox>
    <br />
   Contrasena <asp:TextBox ID="txtpassword" TextMode="Password" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Entrar" OnClick="Button1_Click" />
    

        <br />
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    

    </div>
    </form>

    <!--here done-->
    

    
    


  
</div>
<div id="footer">
	<p>&copy; Sergio Andres Arboleda <a href="http://sergio.tk" rel="nofollow">WebSite</a></p>
</div>
</body>
</html>
