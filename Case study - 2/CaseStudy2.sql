/****** Object:  Database [EcommerceDb]    Script Date: 09-03-2022 18:01:51 ******/

CREATE TABLE [dbo].[tblCategory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
	[ParentID] [int] NULL,
	[IsDeleted] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
 CONSTRAINT [PK_tblCategory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblColor]    Script Date: 09-03-2022 18:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblColor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ColorName] [nvarchar](50) NULL,
	[IsDeleted] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
 CONSTRAINT [PK_tblColor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProduct]    Script Date: 09-03-2022 18:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProduct](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[Description] [nvarchar](2000) NULL,
	[VendorName] [nchar](10) NULL,
	[Mrp] [decimal](5, 2) NULL,
	[Discount] [int] NULL,
	[FinalPrice] [decimal](5, 2) NULL,
	[IsDeleted] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
 CONSTRAINT [PK_tblProduct] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProductSizeColor]    Script Date: 09-03-2022 18:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProductSizeColor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[SizeId] [int] NULL,
	[ColorId] [int] NULL,
	[CatId] [int] NULL,
	[IsDeleted] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
 CONSTRAINT [PK_tblProductSizeColor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSize]    Script Date: 09-03-2022 18:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSize](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SizeName] [nvarchar](50) NULL,
	[IsDeleted] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [date] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedOn] [date] NULL,
 CONSTRAINT [PK_tblSize] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblCategory] ON 

INSERT [dbo].[tblCategory] ([ID], [CategoryName], [ParentID], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (1, N'Mobiles', 0, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblCategory] ([ID], [CategoryName], [ParentID], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (2, N'Fashion', 0, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblCategory] ([ID], [CategoryName], [ParentID], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (3, N'Electronics', 0, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblCategory] ([ID], [CategoryName], [ParentID], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (4, N'Toys', 0, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblCategory] ([ID], [CategoryName], [ParentID], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (5, N'Mens Tshirt', 2, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblCategory] ([ID], [CategoryName], [ParentID], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (6, N'Womens T Shirt', 2, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblCategory] ([ID], [CategoryName], [ParentID], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (7, N'Laptops', 3, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblCategory] ([ID], [CategoryName], [ParentID], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (8, N'Power Bank', 3, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblCategory] ([ID], [CategoryName], [ParentID], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (9, N'School Toys', 4, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[tblColor] ON 

INSERT [dbo].[tblColor] ([ID], [ColorName], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (1, N'Green', 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblColor] ([ID], [ColorName], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (2, N'Blue', NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblColor] OFF
GO
SET IDENTITY_INSERT [dbo].[tblProduct] ON 

INSERT [dbo].[tblProduct] ([ID], [ProductName], [Description], [VendorName], [Mrp], [Discount], [FinalPrice], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (2, N'Solid Men Polo Neck Maroon T-Shirt', N'Solid Men Polo Neck Maroon T-Shirt', N'3BROS     ', CAST(999.00 AS Decimal(5, 2)), 60, CAST(399.00 AS Decimal(5, 2)), 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([ID], [ProductName], [Description], [VendorName], [Mrp], [Discount], [FinalPrice], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (5, N'Printed Women Round Neck Purple T-Shirt', N'Printed Women Round Neck Purple T-Shirt', N'JUNEBERRY ', CAST(199.00 AS Decimal(5, 2)), 0, CAST(199.00 AS Decimal(5, 2)), 0, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[tblProductSizeColor] ON 

INSERT [dbo].[tblProductSizeColor] ([ID], [ProductId], [SizeId], [ColorId], [CatId], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (1, 2, 1, 1, 5, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblProductSizeColor] ([ID], [ProductId], [SizeId], [ColorId], [CatId], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (2, 5, 1, 2, 6, 0, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblProductSizeColor] OFF
GO
SET IDENTITY_INSERT [dbo].[tblSize] ON 

INSERT [dbo].[tblSize] ([ID], [SizeName], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (1, N'Xl', 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblSize] ([ID], [SizeName], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (2, N'L', 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblSize] ([ID], [SizeName], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (3, N'S', 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblSize] ([ID], [SizeName], [IsDeleted], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (4, N'M', 0, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblSize] OFF
GO
/****** Object:  StoredProcedure [dbo].[GetAllProducts]    Script Date: 09-03-2022 18:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllProducts] as
Begin
select P.ID,P.ProductName,P.VendorName,P.Mrp,P.Discount,P.FinalPrice,P.Description,S.SizeName,C.ColorName,Cat.CategoryName 
from tblProduct P 
inner join [tblProductSizeColor] PSC on PSC.ProductId=P.ID
inner join [tblSize] S on PSC.SizeId=S.ID
inner join [tblColor] C on PSC.ColorId=C.ID
inner join [tblCategory] Cat on PSC.CatId=Cat.ID
End
GO
USE [master]
GO
ALTER DATABASE [EcommerceDb] SET  READ_WRITE 
GO