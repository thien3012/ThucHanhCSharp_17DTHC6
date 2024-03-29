USE [master]
GO
/****** Object:  Database [ProductOrder]    Script Date: 10/19/2019 15:57:08 ******/
CREATE DATABASE [ProductOrder] ON  PRIMARY 
( NAME = N'ProductOrder', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\ProductOrder.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProductOrder_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\ProductOrder_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProductOrder] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProductOrder].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProductOrder] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [ProductOrder] SET ANSI_NULLS OFF
GO
ALTER DATABASE [ProductOrder] SET ANSI_PADDING OFF
GO
ALTER DATABASE [ProductOrder] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [ProductOrder] SET ARITHABORT OFF
GO
ALTER DATABASE [ProductOrder] SET AUTO_CLOSE ON
GO
ALTER DATABASE [ProductOrder] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [ProductOrder] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [ProductOrder] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [ProductOrder] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [ProductOrder] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [ProductOrder] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [ProductOrder] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [ProductOrder] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [ProductOrder] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [ProductOrder] SET  ENABLE_BROKER
GO
ALTER DATABASE [ProductOrder] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [ProductOrder] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [ProductOrder] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [ProductOrder] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [ProductOrder] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [ProductOrder] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [ProductOrder] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [ProductOrder] SET  READ_WRITE
GO
ALTER DATABASE [ProductOrder] SET RECOVERY SIMPLE
GO
ALTER DATABASE [ProductOrder] SET  MULTI_USER
GO
ALTER DATABASE [ProductOrder] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [ProductOrder] SET DB_CHAINING OFF
GO
USE [ProductOrder]
GO
/****** Object:  User [TienNguyen]    Script Date: 10/19/2019 15:57:09 ******/
CREATE USER [TienNguyen] FOR LOGIN [TienNguyen] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 10/19/2019 15:57:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceNo] [nvarchar](20) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[DeliveryDate] [datetime] NOT NULL,
	[Note] [nvarchar](255) NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Invoice] ([InvoiceNo], [OrderDate], [DeliveryDate], [Note]) VALUES (N'HDX001', CAST(0x0000AAD900000000 AS DateTime), CAST(0x0000AADA00000000 AS DateTime), N'Giao hàng trước 9h')
INSERT [dbo].[Invoice] ([InvoiceNo], [OrderDate], [DeliveryDate], [Note]) VALUES (N'HDX002', CAST(0x0000AADA00000000 AS DateTime), CAST(0x0000AADA00000000 AS DateTime), N'Gọi điện trước khi giao')
INSERT [dbo].[Invoice] ([InvoiceNo], [OrderDate], [DeliveryDate], [Note]) VALUES (N'HDX003', CAST(0x0000AABB00000000 AS DateTime), CAST(0x0000AABD00000000 AS DateTime), NULL)
INSERT [dbo].[Invoice] ([InvoiceNo], [OrderDate], [DeliveryDate], [Note]) VALUES (N'HDX004', CAST(0x0000AA9D00000000 AS DateTime), CAST(0x0000AA9F00000000 AS DateTime), N'Coi chừng bùm hàng')
/****** Object:  Table [dbo].[Product]    Script Date: 10/19/2019 15:57:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [nvarchar](20) NOT NULL,
	[ProductName] [nvarchar](100) NOT NULL,
	[Unit] [nvarchar](20) NOT NULL,
	[BuyPrice] [decimal](18, 0) NULL,
	[SellPrice] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Product] ([ProductID], [ProductName], [Unit], [BuyPrice], [SellPrice]) VALUES (N'Product1', N'Sản phẩm 1', N'Cái', CAST(100000 AS Decimal(18, 0)), CAST(120000 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([ProductID], [ProductName], [Unit], [BuyPrice], [SellPrice]) VALUES (N'Product2', N'Sản phẩm 2', N'Cái', CAST(90000 AS Decimal(18, 0)), CAST(120000 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([ProductID], [ProductName], [Unit], [BuyPrice], [SellPrice]) VALUES (N'Product3', N'Sản phẩm 3', N'Cái', CAST(40000 AS Decimal(18, 0)), CAST(70000 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([ProductID], [ProductName], [Unit], [BuyPrice], [SellPrice]) VALUES (N'Product4', N'Sản phẩm 4', N'Hộp', CAST(200000 AS Decimal(18, 0)), CAST(300000 AS Decimal(18, 0)))
/****** Object:  Table [dbo].[Order]    Script Date: 10/19/2019 15:57:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[InvoiceNo] [nvarchar](20) NOT NULL,
	[No] [int] NOT NULL,
	[ProductID] [nvarchar](20) NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[Unit] [nvarchar](20) NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[InvoiceNo] ASC,
	[No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Order] ([InvoiceNo], [No], [ProductID], [ProductName], [Unit], [Price], [Quantity]) VALUES (N'HDX001', 1, N'Product1', N'Sản phẩm 1', N'Cái', CAST(120000 AS Decimal(18, 0)), 20)
INSERT [dbo].[Order] ([InvoiceNo], [No], [ProductID], [ProductName], [Unit], [Price], [Quantity]) VALUES (N'HDX001', 2, N'Product2', N'Sản phẩm 2', N'Cái', CAST(120000 AS Decimal(18, 0)), 4)
INSERT [dbo].[Order] ([InvoiceNo], [No], [ProductID], [ProductName], [Unit], [Price], [Quantity]) VALUES (N'HDX001', 3, N'Product4', N'Sản phẩm 4', N'Hộp', CAST(300000 AS Decimal(18, 0)), 10)
INSERT [dbo].[Order] ([InvoiceNo], [No], [ProductID], [ProductName], [Unit], [Price], [Quantity]) VALUES (N'HDX002', 1, N'Product4', N'Sản phẩm 1', N'Hộp', CAST(300000 AS Decimal(18, 0)), 10)
INSERT [dbo].[Order] ([InvoiceNo], [No], [ProductID], [ProductName], [Unit], [Price], [Quantity]) VALUES (N'HDX002', 2, N'Product2', N'Sản phẩm 3', N'Cái', CAST(300000 AS Decimal(18, 0)), 12)
INSERT [dbo].[Order] ([InvoiceNo], [No], [ProductID], [ProductName], [Unit], [Price], [Quantity]) VALUES (N'HDX003', 1, N'Product2', N'Sản phẩm 2', N'cái', CAST(120000 AS Decimal(18, 0)), 5)
INSERT [dbo].[Order] ([InvoiceNo], [No], [ProductID], [ProductName], [Unit], [Price], [Quantity]) VALUES (N'HDX004', 3, N'Product1', N'Sản phẩm 1', N'Cái', CAST(120000 AS Decimal(18, 0)), 2)
/****** Object:  ForeignKey [FK_Order_Invoice]    Script Date: 10/19/2019 15:57:10 ******/
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Invoice] FOREIGN KEY([InvoiceNo])
REFERENCES [dbo].[Invoice] ([InvoiceNo])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Invoice]
GO
/****** Object:  ForeignKey [FK_Order_Product]    Script Date: 10/19/2019 15:57:10 ******/
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Product]
GO
