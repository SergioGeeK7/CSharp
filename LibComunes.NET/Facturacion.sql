USE [master]
GO
/****** Object:  Database [Facturacion]    Script Date: 25/09/2013 9:51:59 a. m. ******/
CREATE DATABASE [Facturacion] ON  PRIMARY 
( NAME = N'Facturacion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Facturacion.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Facturacion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Facturacion_log.ldf' , SIZE = 5184KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Facturacion] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Facturacion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Facturacion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Facturacion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Facturacion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Facturacion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Facturacion] SET ARITHABORT OFF 
GO
ALTER DATABASE [Facturacion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Facturacion] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Facturacion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Facturacion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Facturacion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Facturacion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Facturacion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Facturacion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Facturacion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Facturacion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Facturacion] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Facturacion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Facturacion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Facturacion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Facturacion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Facturacion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Facturacion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Facturacion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Facturacion] SET RECOVERY FULL 
GO
ALTER DATABASE [Facturacion] SET  MULTI_USER 
GO
ALTER DATABASE [Facturacion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Facturacion] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Facturacion', N'ON'
GO
USE [Facturacion]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 25/09/2013 9:51:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IDCliente] [nvarchar](20) NOT NULL,
	[Nombres] [nvarchar](30) NOT NULL,
	[Apellidos] [nvarchar](30) NOT NULL,
	[Direccion] [nvarchar](50) NULL,
	[Telefono] [nvarchar](20) NULL,
	[Correo] [nvarchar](50) NULL,
	[FechaNacimiento] [date] NULL,
	[Cupo] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IDCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 25/09/2013 9:52:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamento](
	[IDDepartamento] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Departamento] PRIMARY KEY CLUSTERED 
(
	[IDDepartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 25/09/2013 9:52:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[IDFactura] [int] NOT NULL,
	[IDLinea] [int] IDENTITY(1,1) NOT NULL,
	[IDProducto] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Precio] [money] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_DetalleFactura2] PRIMARY KEY CLUSTERED 
(
	[IDFactura] ASC,
	[IDLinea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleFacturaTmp]    Script Date: 25/09/2013 9:52:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFacturaTmp](
	[IDLinea] [int] IDENTITY(1,1) NOT NULL,
	[IDProducto] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Precio] [money] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_DetalleFacturaTmp] PRIMARY KEY CLUSTERED 
(
	[IDLinea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Factura]    Script Date: 25/09/2013 9:52:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[IDFactura] [int] IDENTITY(1,1) NOT NULL,
	[IDCliente] [nvarchar](20) NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Factura_1] PRIMARY KEY CLUSTERED 
(
	[IDFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IVA]    Script Date: 25/09/2013 9:52:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IVA](
	[IDIVA] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](255) NOT NULL,
	[Tarifa] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_IVA] PRIMARY KEY CLUSTERED 
(
	[IDIVA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto]    Script Date: 25/09/2013 9:52:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[IDProducto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Precio] [money] NOT NULL,
	[Stock] [int] NOT NULL,
	[Notas] [text] NULL,
	[IDIVA] [int] NOT NULL,
	[IDDepartamento] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[IDProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 25/09/2013 9:52:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Usuario] [nvarchar](10) NOT NULL,
	[Clave] [nvarchar](10) NOT NULL,
	[Nombres] [nvarchar](255) NOT NULL,
	[Apellidos] [nvarchar](255) NOT NULL,
	[IDPerfil] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[ReporteFacturas]    Script Date: 25/09/2013 9:52:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ReporteFacturas]
AS
SELECT        dbo.Factura.Fecha, dbo.Factura.IDCliente, dbo.Cliente.Nombres + ' ' + dbo.Cliente.Apellidos AS NombreCompleto, dbo.Factura.IDFactura, 
                         dbo.DetalleFactura.IDLinea, dbo.DetalleFactura.IDProducto, dbo.DetalleFactura.Descripcion, dbo.DetalleFactura.Precio, dbo.DetalleFactura.Cantidad, 
                         dbo.DetalleFactura.Precio * dbo.DetalleFactura.Cantidad AS Valor
FROM            dbo.Cliente INNER JOIN
                         dbo.Factura ON dbo.Cliente.IDCliente = dbo.Factura.IDCliente INNER JOIN
                         dbo.DetalleFactura ON dbo.Factura.IDFactura = dbo.DetalleFactura.IDFactura

GO
INSERT [dbo].[Cliente] ([IDCliente], [Nombres], [Apellidos], [Direccion], [Telefono], [Correo], [FechaNacimiento], [Cupo]) VALUES (N'1', N'JUAN CARLOS', N'ZULUAGA CARDONA', N'CALLE LUNA CALLE SOL', N'2334455', N'jzuluaga55@gmail.com', CAST(0xF8FF0A00 AS Date), 3000000)
INSERT [dbo].[Cliente] ([IDCliente], [Nombres], [Apellidos], [Direccion], [Telefono], [Correo], [FechaNacimiento], [Cupo]) VALUES (N'10', N'Rafael', N'Nadal', N'Carrera 80 #56 78', N'3557790', N'rafanadal@hotmail.es', CAST(0x00000000 AS Date), 8000000)
INSERT [dbo].[Cliente] ([IDCliente], [Nombres], [Apellidos], [Direccion], [Telefono], [Correo], [FechaNacimiento], [Cupo]) VALUES (N'11', N'Carla', N'Bruni', N'Avenila Las Hermosas', N'4557788', N'carlabruni@gmail.com', CAST(0x00000000 AS Date), 7000000)
INSERT [dbo].[Cliente] ([IDCliente], [Nombres], [Apellidos], [Direccion], [Telefono], [Correo], [FechaNacimiento], [Cupo]) VALUES (N'2', N'LEDYS', N'BEDOYA', N'AVENIDA LOS GUERREROS', N'4556688', N'ledysbedoya@hotmail.com', CAST(0xF6080B00 AS Date), 5000000)
INSERT [dbo].[Cliente] ([IDCliente], [Nombres], [Apellidos], [Direccion], [Telefono], [Correo], [FechaNacimiento], [Cupo]) VALUES (N'3', N'Barak', N'Obama', N'Casa Blanca', N'3446677', N'obama666@yahoo.com', CAST(0x00000000 AS Date), 2000000)
INSERT [dbo].[Cliente] ([IDCliente], [Nombres], [Apellidos], [Direccion], [Telefono], [Correo], [FechaNacimiento], [Cupo]) VALUES (N'4', N'Marlon', N'Brandon', N'Los Angeles', N'3446677', N'marlito', CAST(0x00000000 AS Date), 5000000)
INSERT [dbo].[Cliente] ([IDCliente], [Nombres], [Apellidos], [Direccion], [Telefono], [Correo], [FechaNacimiento], [Cupo]) VALUES (N'5', N'Angelina', N'Jolie', N'Calle La Gloria', N'4935678', N'labios@gmail.com', CAST(0x00000000 AS Date), 1000000)
INSERT [dbo].[Cliente] ([IDCliente], [Nombres], [Apellidos], [Direccion], [Telefono], [Correo], [FechaNacimiento], [Cupo]) VALUES (N'6', N'Juan Manuel', N'Santos', N'Calle 45 544', N'2443366', N'', CAST(0x00000000 AS Date), 5000000)
INSERT [dbo].[Cliente] ([IDCliente], [Nombres], [Apellidos], [Direccion], [Telefono], [Correo], [FechaNacimiento], [Cupo]) VALUES (N'9', N'Leonel', N'Messi', N'', N'', N'', CAST(0x00000000 AS Date), 9000000)
SET IDENTITY_INSERT [dbo].[Departamento] ON 

INSERT [dbo].[Departamento] ([IDDepartamento], [Descripcion]) VALUES (1, N'Lacteos')
INSERT [dbo].[Departamento] ([IDDepartamento], [Descripcion]) VALUES (2, N'Licores')
INSERT [dbo].[Departamento] ([IDDepartamento], [Descripcion]) VALUES (3, N'Rancho')
INSERT [dbo].[Departamento] ([IDDepartamento], [Descripcion]) VALUES (4, N'Aseo Hogar')
INSERT [dbo].[Departamento] ([IDDepartamento], [Descripcion]) VALUES (5, N'Aseo Personal')
INSERT [dbo].[Departamento] ([IDDepartamento], [Descripcion]) VALUES (6, N'Bedidas')
INSERT [dbo].[Departamento] ([IDDepartamento], [Descripcion]) VALUES (7, N'Granos')
INSERT [dbo].[Departamento] ([IDDepartamento], [Descripcion]) VALUES (8, N'Frutas y Verduras')
SET IDENTITY_INSERT [dbo].[Departamento] OFF
SET IDENTITY_INSERT [dbo].[DetalleFactura] ON 

INSERT [dbo].[DetalleFactura] ([IDFactura], [IDLinea], [IDProducto], [Descripcion], [Precio], [Cantidad]) VALUES (1, 1, 1, N'COCA COLA X 350 ML', 1500.0000, 1)
INSERT [dbo].[DetalleFactura] ([IDFactura], [IDLinea], [IDProducto], [Descripcion], [Precio], [Cantidad]) VALUES (1, 2, 10, N'FABULOSO X 500 ML', 3800.0000, 2)
INSERT [dbo].[DetalleFactura] ([IDFactura], [IDLinea], [IDProducto], [Descripcion], [Precio], [Cantidad]) VALUES (1, 3, 2, N'HAMBURGUEZA CON QUESO', 50000.0000, 3)
INSERT [dbo].[DetalleFactura] ([IDFactura], [IDLinea], [IDProducto], [Descripcion], [Precio], [Cantidad]) VALUES (1, 4, 3, N'MANTEQUILLA RAMA', 5200.0000, 4)
INSERT [dbo].[DetalleFactura] ([IDFactura], [IDLinea], [IDProducto], [Descripcion], [Precio], [Cantidad]) VALUES (2, 5, 1, N'COCA COLA X 350 ML', 1500.0000, 10)
INSERT [dbo].[DetalleFactura] ([IDFactura], [IDLinea], [IDProducto], [Descripcion], [Precio], [Cantidad]) VALUES (2, 6, 7, N'AGUARDIENTE ANTIOQUEÑO X 750 ML', 32000.0000, 10)
INSERT [dbo].[DetalleFactura] ([IDFactura], [IDLinea], [IDProducto], [Descripcion], [Precio], [Cantidad]) VALUES (2, 7, 8, N'RON MEDELLIN X 750 ML', 35000.0000, 10)
INSERT [dbo].[DetalleFactura] ([IDFactura], [IDLinea], [IDProducto], [Descripcion], [Precio], [Cantidad]) VALUES (3, 8, 1, N'COCA COLA X 350 ML', 1500.0000, 20)
INSERT [dbo].[DetalleFactura] ([IDFactura], [IDLinea], [IDProducto], [Descripcion], [Precio], [Cantidad]) VALUES (3, 9, 2, N'HAMBURGUEZA CON QUESO', 5000.0000, 20)
INSERT [dbo].[DetalleFactura] ([IDFactura], [IDLinea], [IDProducto], [Descripcion], [Precio], [Cantidad]) VALUES (4, 10, 4, N'SALCHICHON ZENU X 500 GR', 5200.0000, 100)
SET IDENTITY_INSERT [dbo].[DetalleFactura] OFF
SET IDENTITY_INSERT [dbo].[Factura] ON 

INSERT [dbo].[Factura] ([IDFactura], [IDCliente], [Fecha]) VALUES (1, N'1', CAST(0x0000A14E0107E39E AS DateTime))
INSERT [dbo].[Factura] ([IDFactura], [IDCliente], [Fecha]) VALUES (2, N'1', CAST(0x0000A14E0108561E AS DateTime))
INSERT [dbo].[Factura] ([IDFactura], [IDCliente], [Fecha]) VALUES (3, N'11', CAST(0x0000A14F0115E990 AS DateTime))
INSERT [dbo].[Factura] ([IDFactura], [IDCliente], [Fecha]) VALUES (4, N'3', CAST(0x0000A14F011622CA AS DateTime))
SET IDENTITY_INSERT [dbo].[Factura] OFF
SET IDENTITY_INSERT [dbo].[IVA] ON 

INSERT [dbo].[IVA] ([IDIVA], [Descripcion], [Tarifa]) VALUES (1, N'Excluido', CAST(0.00 AS Decimal(8, 2)))
INSERT [dbo].[IVA] ([IDIVA], [Descripcion], [Tarifa]) VALUES (2, N'Excento', CAST(0.00 AS Decimal(8, 2)))
INSERT [dbo].[IVA] ([IDIVA], [Descripcion], [Tarifa]) VALUES (3, N'IVA 10%', CAST(10.00 AS Decimal(8, 2)))
INSERT [dbo].[IVA] ([IDIVA], [Descripcion], [Tarifa]) VALUES (4, N'IVA 16%', CAST(16.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[IVA] OFF
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([IDProducto], [Descripcion], [Precio], [Stock], [Notas], [IDIVA], [IDDepartamento]) VALUES (1, N'COCA COLA X 350 ML', 1500.0000, 500, N'Sabe mejor bien helada', 4, 6)
INSERT [dbo].[Producto] ([IDProducto], [Descripcion], [Precio], [Stock], [Notas], [IDIVA], [IDDepartamento]) VALUES (2, N'HAMBURGUEZA CON QUESO', 5000.0000, 100, N'', 1, 3)
INSERT [dbo].[Producto] ([IDProducto], [Descripcion], [Precio], [Stock], [Notas], [IDIVA], [IDDepartamento]) VALUES (3, N'MANTEQUILLA RAMA', 5200.0000, 300, N'', 1, 4)
INSERT [dbo].[Producto] ([IDProducto], [Descripcion], [Precio], [Stock], [Notas], [IDIVA], [IDDepartamento]) VALUES (4, N'SALCHICHON ZENU X 500 GR', 5200.0000, 250, N'Recomendado comer con limon', 2, 5)
INSERT [dbo].[Producto] ([IDProducto], [Descripcion], [Precio], [Stock], [Notas], [IDIVA], [IDDepartamento]) VALUES (5, N'PAN BIMBO', 3500.0000, 140, N'', 2, 6)
INSERT [dbo].[Producto] ([IDProducto], [Descripcion], [Precio], [Stock], [Notas], [IDIVA], [IDDepartamento]) VALUES (6, N'TOSTADAS MAMA INES', 1300.0000, 760, N'Crujientes y deliciosas', 3, 1)
INSERT [dbo].[Producto] ([IDProducto], [Descripcion], [Precio], [Stock], [Notas], [IDIVA], [IDDepartamento]) VALUES (7, N'AGUARDIENTE ANTIOQUEÑO X 750 ML', 32000.0000, 80, N'', 3, 2)
INSERT [dbo].[Producto] ([IDProducto], [Descripcion], [Precio], [Stock], [Notas], [IDIVA], [IDDepartamento]) VALUES (8, N'RON MEDELLIN X 750 ML', 35000.0000, 60, N'', 4, 3)
INSERT [dbo].[Producto] ([IDProducto], [Descripcion], [Precio], [Stock], [Notas], [IDIVA], [IDDepartamento]) VALUES (9, N'JABON REY', 500.0000, 120, N'', 4, 4)
INSERT [dbo].[Producto] ([IDProducto], [Descripcion], [Precio], [Stock], [Notas], [IDIVA], [IDDepartamento]) VALUES (10, N'FABULOSO X 500 ML', 3800.0000, 300, N'', 1, 2)
SET IDENTITY_INSERT [dbo].[Producto] OFF
INSERT [dbo].[Usuario] ([Usuario], [Clave], [Nombres], [Apellidos], [IDPerfil]) VALUES (N'vale', N'123', N'Valery', N'Zuluag', 2)
INSERT [dbo].[Usuario] ([Usuario], [Clave], [Nombres], [Apellidos], [IDPerfil]) VALUES (N'zulu', N'123', N'Juan', N'Zuluaga', 1)
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Factura] FOREIGN KEY([IDFactura])
REFERENCES [dbo].[Factura] ([IDFactura])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Factura]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Producto] FOREIGN KEY([IDProducto])
REFERENCES [dbo].[Producto] ([IDProducto])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Producto]
GO
ALTER TABLE [dbo].[DetalleFacturaTmp]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFacturaTmp_Producto] FOREIGN KEY([IDProducto])
REFERENCES [dbo].[Producto] ([IDProducto])
GO
ALTER TABLE [dbo].[DetalleFacturaTmp] CHECK CONSTRAINT [FK_DetalleFacturaTmp_Producto]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Cliente] FOREIGN KEY([IDCliente])
REFERENCES [dbo].[Cliente] ([IDCliente])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Cliente]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Departamento] FOREIGN KEY([IDDepartamento])
REFERENCES [dbo].[Departamento] ([IDDepartamento])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Departamento]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_IVA] FOREIGN KEY([IDIVA])
REFERENCES [dbo].[IVA] ([IDIVA])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_IVA]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Cliente"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Factura"
            Begin Extent = 
               Top = 6
               Left = 285
               Bottom = 119
               Right = 494
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DetalleFactura"
            Begin Extent = 
               Top = 6
               Left = 532
               Bottom = 172
               Right = 741
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 2505
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ReporteFacturas'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ReporteFacturas'
GO
USE [master]
GO
ALTER DATABASE [Facturacion] SET  READ_WRITE 
GO
