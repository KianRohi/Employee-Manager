USE [master]
GO
/****** Object:  Database [Remax]    Script Date: 2021-12-17 3:57:20 PM ******/
CREATE DATABASE [Remax]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Remax', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Remax.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Remax_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Remax_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Remax] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Remax].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Remax] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [Remax] SET ANSI_NULLS ON 
GO
ALTER DATABASE [Remax] SET ANSI_PADDING ON 
GO
ALTER DATABASE [Remax] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [Remax] SET ARITHABORT ON 
GO
ALTER DATABASE [Remax] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Remax] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Remax] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Remax] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Remax] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [Remax] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [Remax] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Remax] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [Remax] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Remax] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Remax] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Remax] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Remax] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Remax] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Remax] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Remax] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Remax] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Remax] SET RECOVERY FULL 
GO
ALTER DATABASE [Remax] SET  MULTI_USER 
GO
ALTER DATABASE [Remax] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Remax] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Remax] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Remax] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Remax] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Remax] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Remax] SET QUERY_STORE = OFF
GO
USE [Remax]
GO
/****** Object:  Table [dbo].[Branches]    Script Date: 2021-12-17 3:57:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branches](
	[BranchID] [int] IDENTITY(1,1) NOT NULL,
	[Location] [nvarchar](50) NOT NULL,
	[Status] [nvarchar](20) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[BranchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 2021-12-17 3:57:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[ClientName] [nvarchar](50) NOT NULL,
	[ClientStatus] [nvarchar](25) NOT NULL,
	[Phone] [nvarchar](25) NOT NULL,
	[E-mail] [nchar](50) NULL,
	[BranchID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2021-12-17 3:57:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Position] [nvarchar](20) NOT NULL,
	[Phone] [nvarchar](25) NULL,
	[Birthday] [datetime] NULL,
	[Gender] [nvarchar](25) NULL,
	[Email] [nvarchar](80) NULL,
	[City] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Pin] [nvarchar](50) NOT NULL,
	[BranchID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HouseFeatures]    Script Date: 2021-12-17 3:57:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HouseFeatures](
	[EstateID] [int] NOT NULL,
	[Building Type] [nvarchar](50) NULL,
	[BedRooms] [int] NULL,
	[Built in] [nvarchar](10) NULL,
	[Neighbourhood] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
	[Price] [money] NULL,
	[Description] [nchar](255) NULL,
	[Pool] [nvarchar](10) NULL,
	[Elevator] [nvarchar](10) NULL,
 CONSTRAINT [PK_HouseFeatures] PRIMARY KEY CLUSTERED 
(
	[EstateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Houses]    Script Date: 2021-12-17 3:57:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Houses](
	[EstateID] [int] NOT NULL,
	[Status] [nvarchar](25) NULL,
	[ClientID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[BranchID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EstateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Branches] ON 

INSERT [dbo].[Branches] ([BranchID], [Location], [Status], [Phone], [Email]) VALUES (1, N'Montreal', N'Active', N'(514)235-5458', N'RemaxMont@yahoo.com')
INSERT [dbo].[Branches] ([BranchID], [Location], [Status], [Phone], [Email]) VALUES (2, N'toronto', N'Active', N'(589) 877-2871
', N'RemaxTornt@yahoo.com')
INSERT [dbo].[Branches] ([BranchID], [Location], [Status], [Phone], [Email]) VALUES (3, N'Ottawa', N'Active', N'(540) 563-2162
', N'RemaxOttawa@yahoo.com')
INSERT [dbo].[Branches] ([BranchID], [Location], [Status], [Phone], [Email]) VALUES (4, N'Angola', N'Active', N'(514)235-5658', N'RexAngola.com')
INSERT [dbo].[Branches] ([BranchID], [Location], [Status], [Phone], [Email]) VALUES (5, N'Montreal(LaSalle)', N'Active', N'(514)686-9823', N'RexMtl@yahoo.com')
SET IDENTITY_INSERT [dbo].[Branches] OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ClientID], [ClientName], [ClientStatus], [Phone], [E-mail], [BranchID]) VALUES (1, N'Rania Veschambes
', N'Buyer', N'(848) 1367728
', N'rveschambes24@miibeian.gov.cn
                   ', 1)
INSERT [dbo].[Clients] ([ClientID], [ClientName], [ClientStatus], [Phone], [E-mail], [BranchID]) VALUES (2, N'Kele Tomowicz
', N'Seller', N'(757) 1877243
', N'Kele18@gmail.com                                  ', 2)
INSERT [dbo].[Clients] ([ClientID], [ClientName], [ClientStatus], [Phone], [E-mail], [BranchID]) VALUES (4, N'Garrard Carlon
', N'Buyer', N'(449) 8796943
', N'ygrimmett2g@twitter.com
                         ', 3)
INSERT [dbo].[Clients] ([ClientID], [ClientName], [ClientStatus], [Phone], [E-mail], [BranchID]) VALUES (10, N'Dimitry Chopra', N'Buyer', N'(589) 8772871
', N'Dimitry@yahoo.com                                 ', 1)
INSERT [dbo].[Clients] ([ClientID], [ClientName], [ClientStatus], [Phone], [E-mail], [BranchID]) VALUES (11, N'Chad Cleere
', N'Seller', N'(778) 7452090
', N'Cleereee@hotmail.com                              ', 2)
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
INSERT [dbo].[Employees] ([EmployeeID], [Name], [Position], [Phone], [Birthday], [Gender], [Email], [City], [Username], [Pin], [BranchID]) VALUES (2, N'kian rohi', N'Admin', N'5142355458', CAST(N'1998-12-31T00:00:00.000' AS DateTime), N'Male', N'Kasragholami92@yahoo.com', N'Montreal', N'ali', N'1998', 1)
INSERT [dbo].[Employees] ([EmployeeID], [Name], [Position], [Phone], [Birthday], [Gender], [Email], [City], [Username], [Pin], [BranchID]) VALUES (6, N'Chloe Towle
', N'Agent', N'(449) 8796943
', CAST(N'1974-01-12T00:00:00.000' AS DateTime), N'Male
', N'bvase2l@1688.com
', NULL, N'hurling', N'Towle', 1)
INSERT [dbo].[Employees] ([EmployeeID], [Name], [Position], [Phone], [Birthday], [Gender], [Email], [City], [Username], [Pin], [BranchID]) VALUES (7, N'Cody Bufton
', N'Agent', N'(732) 1094979
', CAST(N'1985-09-08T00:00:00.000' AS DateTime), N'Female
', N'cbufton4@uol.com.br
', NULL, N'Cody', N'Bufton', 2)
INSERT [dbo].[Employees] ([EmployeeID], [Name], [Position], [Phone], [Birthday], [Gender], [Email], [City], [Username], [Pin], [BranchID]) VALUES (8, N'Kelly', N'Admin', N'(802) 2915405
', CAST(N'1991-04-12T00:00:00.000' AS DateTime), N'Female', N'Kelly91@gamil.com', N'Montreal', N'Kelly91', N'Kelkel', 2)
INSERT [dbo].[Employees] ([EmployeeID], [Name], [Position], [Phone], [Birthday], [Gender], [Email], [City], [Username], [Pin], [BranchID]) VALUES (9, N'Stavro Quarrington
', N'Agent', N'(532) 7600276', CAST(N'1975-01-16T00:00:00.000' AS DateTime), N'Male', N'zkleyna@rakuten.co.jp
', N'Toronto', N'starvo', N'st75', 3)
INSERT [dbo].[Employees] ([EmployeeID], [Name], [Position], [Phone], [Birthday], [Gender], [Email], [City], [Username], [Pin], [BranchID]) VALUES (11, N'kasra', N'Agent', N'5142355458', CAST(N'1998-01-23T00:00:00.000' AS DateTime), N'Male', N'K@yahoo.com', N'Montreal', N'6600', N'6600', 2)
INSERT [dbo].[Employees] ([EmployeeID], [Name], [Position], [Phone], [Birthday], [Gender], [Email], [City], [Username], [Pin], [BranchID]) VALUES (12, N'kian rohi', N'Agent', N'5142355458', CAST(N'2001-07-19T00:00:00.000' AS DateTime), N'Male', N'K@gmail.com', N'Montreal', N'HajAli', N'HajAli', 3)
INSERT [dbo].[Employees] ([EmployeeID], [Name], [Position], [Phone], [Birthday], [Gender], [Email], [City], [Username], [Pin], [BranchID]) VALUES (13, N'KImia', N'Agent', N'5142365874', CAST(N'1998-12-31T00:00:00.000' AS DateTime), N'Female', N'kimi@yahoo.com', N'Montreal', N'kim', N'12', 1)
GO
INSERT [dbo].[HouseFeatures] ([EstateID], [Building Type], [BedRooms], [Built in], [Neighbourhood], [Address], [Price], [Description], [Pool], [Elevator]) VALUES (3, N'Apartment', 2, N'2011', N'Rue des Émeraudes', N'#1704 
Repentigny (Repentigny)', 1950000.0000, N'Far from Downtown                                                                                                                                                                                                                                              ', N'Yes', N'Yes')
INSERT [dbo].[HouseFeatures] ([EstateID], [Building Type], [BedRooms], [Built in], [Neighbourhood], [Address], [Price], [Description], [Pool], [Elevator]) VALUES (5, N'House', 1, N'unknown', N'North York', N'#114 -9 BOARDWALK DR', 1180000.0000, N'A grate Family House                                                                                                                                                                                                                                           ', N'No', N'No')
INSERT [dbo].[HouseFeatures] ([EstateID], [Building Type], [BedRooms], [Built in], [Neighbourhood], [Address], [Price], [Description], [Pool], [Elevator]) VALUES (7, N'Apartment', 2, N'2020', N'Westboro', N'1451 WELLINGTON STREET', 1481900.0000, N'Central air conditioning                                                                                                                                                                                                                                       ', N'Yes', N'Yes')
INSERT [dbo].[HouseFeatures] ([EstateID], [Building Type], [BedRooms], [Built in], [Neighbourhood], [Address], [Price], [Description], [Pool], [Elevator]) VALUES (8, N'Apartment', 2, N'2012', N'Roxbro', N'14399 Boul. Gouin O.', 1080000.0000, N'QST must be added to the asking price                                                                                                                                                                                                                          ', N'Yes', N'Yes')
INSERT [dbo].[HouseFeatures] ([EstateID], [Building Type], [BedRooms], [Built in], [Neighbourhood], [Address], [Price], [Description], [Pool], [Elevator]) VALUES (9, N'', 2, N'2020', N'Yorkville', N'#PH 2 -7 DALE AVE', 11950000.0000, N'A Private Roof Top Garden Over 2000 Sq.                                                                                                                                                                                                                        ', N'Yes', N'Yes')
INSERT [dbo].[HouseFeatures] ([EstateID], [Building Type], [BedRooms], [Built in], [Neighbourhood], [Address], [Price], [Description], [Pool], [Elevator]) VALUES (19, N'Apartment', 15, N' 89', N' dgsdg', N' sdgs', 1500000.0000, N' sdg                                                                                                                                                                                                                                                           ', N'Yes', N'Yes')
INSERT [dbo].[HouseFeatures] ([EstateID], [Building Type], [BedRooms], [Built in], [Neighbourhood], [Address], [Price], [Description], [Pool], [Elevator]) VALUES (20, N'Apartment', 7, N' 78', N' fdh', N' dfhdh', 12300.0000, N' dfhd                                                                                                                                                                                                                                                          ', N'Yes', N'Yes')
GO
INSERT [dbo].[Houses] ([EstateID], [Status], [ClientID], [EmployeeID], [BranchID]) VALUES (3, N'To Buy', 1, 2, 1)
INSERT [dbo].[Houses] ([EstateID], [Status], [ClientID], [EmployeeID], [BranchID]) VALUES (5, N'For Sale', 2, 6, 2)
INSERT [dbo].[Houses] ([EstateID], [Status], [ClientID], [EmployeeID], [BranchID]) VALUES (7, N'To Buy', 4, 7, 3)
INSERT [dbo].[Houses] ([EstateID], [Status], [ClientID], [EmployeeID], [BranchID]) VALUES (8, N'To Buy', 10, 8, 1)
INSERT [dbo].[Houses] ([EstateID], [Status], [ClientID], [EmployeeID], [BranchID]) VALUES (9, N'For Sale', 11, 9, 2)
INSERT [dbo].[Houses] ([EstateID], [Status], [ClientID], [EmployeeID], [BranchID]) VALUES (19, N'To Buy', 4, 13, 1)
INSERT [dbo].[Houses] ([EstateID], [Status], [ClientID], [EmployeeID], [BranchID]) VALUES (20, N'For Sale', 10, 13, 1)
GO
ALTER TABLE [dbo].[Branches] ADD  DEFAULT ('Active') FOR [Status]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [FK_Clients_ToTable] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Branches] ([BranchID])
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [FK_Clients_ToTable]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_ToTable] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Branches] ([BranchID])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_ToTable]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_ToTable_1] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Branches] ([BranchID])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_ToTable_1]
GO
ALTER TABLE [dbo].[Houses]  WITH CHECK ADD  CONSTRAINT [FK_Houses_ToTable] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ClientID])
GO
ALTER TABLE [dbo].[Houses] CHECK CONSTRAINT [FK_Houses_ToTable]
GO
ALTER TABLE [dbo].[Houses]  WITH CHECK ADD  CONSTRAINT [FK_Houses_ToTable_1] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Houses] CHECK CONSTRAINT [FK_Houses_ToTable_1]
GO
ALTER TABLE [dbo].[Houses]  WITH CHECK ADD  CONSTRAINT [FK_Houses_ToTable_2] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Branches] ([BranchID])
GO
ALTER TABLE [dbo].[Houses] CHECK CONSTRAINT [FK_Houses_ToTable_2]
GO
USE [master]
GO
ALTER DATABASE [Remax] SET  READ_WRITE 
GO
