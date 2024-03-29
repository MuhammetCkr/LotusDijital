USE [master]
GO
/****** Object:  Database [LotusDijital]    Script Date: 10.03.2024 09:41:31 ******/
CREATE DATABASE [LotusDijital]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LotusDijital', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\LotusDijital_fa316295521747ffa885d538a23664dd.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LotusDijital_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\LotusDijital_b9ba632c08404da1aaace54a2c18394a.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [LotusDijital] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LotusDijital].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LotusDijital] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LotusDijital] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LotusDijital] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LotusDijital] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LotusDijital] SET ARITHABORT OFF 
GO
ALTER DATABASE [LotusDijital] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LotusDijital] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LotusDijital] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LotusDijital] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LotusDijital] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LotusDijital] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LotusDijital] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LotusDijital] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LotusDijital] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LotusDijital] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LotusDijital] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LotusDijital] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LotusDijital] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LotusDijital] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LotusDijital] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LotusDijital] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [LotusDijital] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LotusDijital] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LotusDijital] SET  MULTI_USER 
GO
ALTER DATABASE [LotusDijital] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LotusDijital] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LotusDijital] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LotusDijital] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LotusDijital] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LotusDijital] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'LotusDijital', N'ON'
GO
ALTER DATABASE [LotusDijital] SET QUERY_STORE = OFF
GO
USE [LotusDijital]
GO
/****** Object:  User [Lotus]    Script Date: 10.03.2024 09:41:31 ******/
CREATE USER [Lotus] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[Lotus]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [Lotus]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Lotus]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Lotus]
GO
/****** Object:  Schema [Lotus]    Script Date: 10.03.2024 09:41:31 ******/
CREATE SCHEMA [Lotus]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Image] [nvarchar](max) NULL,
	[Details] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Parameter] [nvarchar](max) NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentGalleries]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentGalleries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[InnerPageId] [int] NULL,
	[Name] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_DocumentGalleries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImageGalleries]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImageGalleries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[InnerPageId] [int] NULL,
	[Name] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_ImageGalleries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Images]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImageGalleryId] [int] NULL,
	[Name] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InnerPages]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InnerPages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Contents] [nvarchar](max) NULL,
	[ShortContent] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[SmallImage] [nvarchar](max) NULL,
	[Banner] [nvarchar](max) NULL,
	[IsHome] [bit] NOT NULL,
	[Phone] [nvarchar](max) NULL,
	[Location] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[SequenceNumber] [int] NOT NULL,
	[Icon] [nvarchar](max) NULL,
	[PageTitle] [nvarchar](max) NULL,
	[PageDescription] [nvarchar](max) NULL,
	[PageKeyword] [nvarchar](max) NULL,
	[PageId] [int] NULL,
	[Name] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_InnerPages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pages]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Pages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategories]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_ProductCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Contents] [nvarchar](max) NULL,
	[ShortContent] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[SmallImage] [nvarchar](max) NULL,
	[Banner] [nvarchar](max) NULL,
	[IsHome] [bit] NOT NULL,
	[Link] [nvarchar](max) NULL,
	[TrendyolLink] [nvarchar](max) NULL,
	[HepsiBuradaLink] [nvarchar](max) NULL,
	[CicekSepetiLink] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Settings]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Settings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Favicon] [nvarchar](max) NULL,
	[Logo] [nvarchar](max) NULL,
	[Adress] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Twitter] [nvarchar](max) NULL,
	[Facebook] [nvarchar](max) NULL,
	[Youtube] [nvarchar](max) NULL,
	[Instagram] [nvarchar](max) NULL,
	[Trendyol] [nvarchar](max) NULL,
	[Hepsiburada] [nvarchar](max) NULL,
	[Ciceksepeti] [nvarchar](max) NULL,
	[FooterContent] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Settings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VideoGalleries]    Script Date: 10.03.2024 09:41:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VideoGalleries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VideoImage] [nvarchar](max) NULL,
	[VideoEmbed] [nvarchar](max) NULL,
	[ProductId] [int] NULL,
	[InnerPageId] [int] NULL,
	[Name] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_VideoGalleries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240221121934_SqlServer', N'7.0.13')
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Image], [Details], [Name], [Url], [IsActive]) VALUES (18, N'ff9f092c-c916-4231-99d0-428d50e858d1.jpg', NULL, N'Çeyiz Defteri', NULL, 1)
INSERT [dbo].[Categories] ([Id], [Image], [Details], [Name], [Url], [IsActive]) VALUES (19, N'cdcf8c83-ee7b-4f17-a6ef-b75d3477f3fa.jpg', NULL, N'Bloknot', NULL, 1)
INSERT [dbo].[Categories] ([Id], [Image], [Details], [Name], [Url], [IsActive]) VALUES (20, N'4dd95022-4818-4aa5-94ec-65a294534129.jpg', NULL, N'Aktivite Kartları', NULL, 1)
INSERT [dbo].[Categories] ([Id], [Image], [Details], [Name], [Url], [IsActive]) VALUES (21, NULL, NULL, N'Tasarım Hizmetleri', NULL, 1)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[ImageGalleries] ON 

INSERT [dbo].[ImageGalleries] ([Id], [ProductId], [InnerPageId], [Name], [Url], [IsActive]) VALUES (2, NULL, NULL, N'Iphone 13', NULL, 0)
INSERT [dbo].[ImageGalleries] ([Id], [ProductId], [InnerPageId], [Name], [Url], [IsActive]) VALUES (3, 1, NULL, N'Çeyiz Defteri (Tel Dikiş)', NULL, 1)
INSERT [dbo].[ImageGalleries] ([Id], [ProductId], [InnerPageId], [Name], [Url], [IsActive]) VALUES (4, 2, NULL, N'Çeyiz Defteri (Spiralli)', NULL, 1)
INSERT [dbo].[ImageGalleries] ([Id], [ProductId], [InnerPageId], [Name], [Url], [IsActive]) VALUES (5, NULL, NULL, N'Bloknotlar (haftalık-günlük-notes)', NULL, 1)
INSERT [dbo].[ImageGalleries] ([Id], [ProductId], [InnerPageId], [Name], [Url], [IsActive]) VALUES (6, 6, NULL, N'Sevgiliyle Yapılacak 50 Aktivite', NULL, 1)
INSERT [dbo].[ImageGalleries] ([Id], [ProductId], [InnerPageId], [Name], [Url], [IsActive]) VALUES (7, 7, NULL, N'Imdb Izlenecek 50 Film', NULL, 1)
SET IDENTITY_INSERT [dbo].[ImageGalleries] OFF
GO
SET IDENTITY_INSERT [dbo].[Images] ON 

INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (1, 2, N'Ekran görüntüsü 2023-06-11 135206.png', N'b52784bd-47ea-4346-95f1-438bfb9c09f0.png', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (2, 2, N'Ekran görüntüsü 2023-06-11 143736.png', N'5d509eff-62dc-4a56-b404-1a0beedf6505.png', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (3, 2, N'Ekran görüntüsü 2023-06-13 212910.png', N'3883ba59-4856-4b76-b00a-f53e6fb01867.png', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (4, 2, N'Ekran görüntüsü 2023-06-13 213318.png', N'3253943a-f4af-4ef8-b8f8-54b3a40d19c0.png', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (5, 2, N'Ekran görüntüsü 2023-06-15 205717.png', N'92ec255d-85a4-48f4-add0-54de20bf0fdf.png', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (6, 3, N'banyo-antre.jpg', N'e5757fb3-8d49-4d49-936f-d4dcef25d312.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (7, 3, N'bohça-not.jpg', N'8c55dca5-4382-4ae5-8f2a-ba9bbdc0159c.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (8, 3, N'davetli-kuaför.jpg', N'0bf7db46-c979-4431-8a78-3ca1e2d46f06.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (9, 3, N'düğün-balayı.jpg', N'99f5c31d-4e2a-4308-92f0-d7dad8ed07cf.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (10, 3, N'kapak2.jpg', N'425a3601-73da-4035-b666-50ef0ffeee64.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (11, 3, N'mutfak.jpg', N'd079ff36-69da-4df6-b3cc-d66143aa5610.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (12, 3, N'nişan-söz-kına.jpg', N'9217fcbf-be71-4498-8536-8833262726fb.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (13, 4, N'banyo-salon.jpg', N'22d9599e-10cf-46ed-a39f-760277401f20.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (14, 4, N'bohça-antre.jpg', N'eaf25dbc-e72b-4361-8738-287591bf55a3.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (15, 4, N'davetli-düğün.jpg', N'6a08cecf-0ce7-431e-be3e-d010dafb44e8.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (16, 4, N'mutfak1.jpg', N'904a64ec-21c6-4e8f-8cfd-92fe2541b420.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (17, 4, N'mutfak2.jpg', N'7f23bb0d-02ba-4672-b7d6-8782d994506b.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (18, 4, N'ÖnKapak.jpg', N'216ca97d-7231-42f9-ae95-6294dabd0637.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (19, 4, N'söz-nişan.jpg', N'860e417b-98ca-4ecc-9297-6942a2cc039e.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (20, 4, N'takvim-notlar.jpg', N'53ff9826-b05e-4144-b595-00b520f3bb28.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (21, 5, N'çeyizplanlayıcı.jpg', N'8f14254f-2f20-4f16-b1c9-e68eeadb687e.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (22, 5, N'haftalıktext.jpg', N'4007b8d7-f9be-49ea-a31f-a2477f372468.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (23, 5, N'noteskopya.jpg', N'6c4eb866-c56b-4f0d-8064-dc03390d1f6b.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (24, 6, N'SEVGİLİ2.jpg', N'f07b0c79-f474-426d-9a99-3e7fbd8cf28c.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (25, 6, N'SEVGİLİ3.jpg', N'9064ee58-407e-4102-a1bf-ce78197814c3.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (26, 6, N'SEVGİLİ4.jpg', N'65e18724-0e2b-47d1-befe-f436e5dda6b3.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (27, 6, N'SEVGİLİ5.jpg', N'4c26ce66-f51b-4ec6-bd24-57c3edd410bc.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (28, 6, N'SEVGİLİKAPAK1.jpg', N'f6198e97-7f53-40ea-a310-87e5cd90fede.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (29, 7, N'FİLM2.jpg', N'c54a6dcb-df23-496b-b249-211fb6595f35.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (30, 7, N'FİLM3.jpg', N'66c9a060-7609-4757-a947-bda44bfdc6df.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (31, 7, N'FİLM4.jpg', N'f896b091-6057-42fc-a770-b1e823f0c245.jpg', 0)
INSERT [dbo].[Images] ([Id], [ImageGalleryId], [Name], [Url], [IsActive]) VALUES (32, 7, N'FİLMKAPAK1.jpg', N'33f9d3f6-f775-4769-b3b7-eb7cee18048f.jpg', 0)
SET IDENTITY_INSERT [dbo].[Images] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductCategories] ON 

INSERT [dbo].[ProductCategories] ([Id], [ProductId], [CategoryId]) VALUES (18, 1, 18)
INSERT [dbo].[ProductCategories] ([Id], [ProductId], [CategoryId]) VALUES (26, 6, 20)
INSERT [dbo].[ProductCategories] ([Id], [ProductId], [CategoryId]) VALUES (27, 7, 20)
INSERT [dbo].[ProductCategories] ([Id], [ProductId], [CategoryId]) VALUES (29, 8, 21)
INSERT [dbo].[ProductCategories] ([Id], [ProductId], [CategoryId]) VALUES (31, 2, 18)
INSERT [dbo].[ProductCategories] ([Id], [ProductId], [CategoryId]) VALUES (33, 3, 19)
INSERT [dbo].[ProductCategories] ([Id], [ProductId], [CategoryId]) VALUES (35, 5, 19)
INSERT [dbo].[ProductCategories] ([Id], [ProductId], [CategoryId]) VALUES (36, 4, 19)
SET IDENTITY_INSERT [dbo].[ProductCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Title], [Contents], [ShortContent], [Image], [SmallImage], [Banner], [IsHome], [Link], [TrendyolLink], [HepsiBuradaLink], [CicekSepetiLink], [Name], [Url], [IsActive]) VALUES (1, N'Çeyiz Defteri', N'<p>Evlilik yolculuğunu eğlenceli bir hale getirmek ister misiniz? &Ccedil;eyiz, s&ouml;z, kına, nişan ,d&uuml;ğ&uuml;n, randevu, balayı, masa d&uuml;zeni, hediyeler, kuaf&ouml;r, organizasyonlar ve eğlence k&ouml;şesi gibi b&ouml;l&uuml;mleri i&ccedil;erisinde barındıran ''''Evlilik Yolculuğum'''' &uuml;r&uuml;n&uuml; ile b&uuml;t&uuml;n evlilik s&uuml;recinizi detaylıca planlayıp, sistematik bir şekilde mutlu sona ulaşabilirsiniz. &Uuml;r&uuml;n &Ouml;zellikleri: 1.Kalite Dijital Baskı ile muadillerini geride bırakan kaliteye sahiptir. &Ouml;l&ccedil;&uuml;ler: A5 boyut 14,8cm-21cm Tel Dikiş</p>', NULL, N'b11132ce-3799-4e81-a15b-66317b99b11a.png', N'73eb0119-228a-4533-ada6-6cba16264433.png', NULL, 1, NULL, N'Çeyiz Defteri, Düğün Planlayıcı, Çeyiz Listesi, Çeyiz, Söz, Nişan, Kına, Balayı Planlayıcı, A5', N'https://www.hepsiburada.com/midilli-ceyiz-defteri-dugun-planlayici-ceyiz-listesi-ceyiz-soz-nisan-kina-balayi-planlayici-a5-p-HBCV00005R80BR', NULL, N'Çeyiz Defteri, Düğün Planlayıcı, Çeyiz Listesi, Çeyiz, Söz, Nişan, Kına, Balayı Planlayıcı, A5', N'ceyiz-defteri-dugun-planlayici-ceyiz-listesi-ceyiz-soz-nisan-kina-balayi-planlayici-a5', 1)
INSERT [dbo].[Products] ([Id], [Title], [Contents], [ShortContent], [Image], [SmallImage], [Banner], [IsHome], [Link], [TrendyolLink], [HepsiBuradaLink], [CicekSepetiLink], [Name], [Url], [IsActive]) VALUES (2, N'Spiralli Çeyiz Defteri', N'<div class="detail-name-container">
<h3 class="detail-name">Spiralli &Ccedil;eyiz Defteri, D&uuml;ğ&uuml;n Planlayıcı, &Ccedil;eyiz Listesi, &Ccedil;eyiz, S&ouml;z, Nişan, Kına, Balayı Planlayıcı,</h3>
</div>
<ul class="detail-desc-list">
<li>Evlilik Yolculuğunu eğlenceli bir hale getirmek ister misiniz?</li>
<li>Ayrıntılı &Ccedil;eyiz Listesi, Gelin ve Damat Boh&ccedil;aları, S&ouml;z, Nişan, Kına, D&uuml;ğ&uuml;n ve Balayı Listeleri ve Organizasyonları... gibi b&ouml;l&uuml;mleri i&ccedil;erisinde barındıran ''''Evlilik Yolculuğum'''' &uuml;r&uuml;n&uuml; ile b&uuml;t&uuml;n evlilik s&uuml;recinizi detaylıca planlayıp, sistematik bir şekilde mutlu sona ulaşabilirsiniz.</li>
<li>A5 Boyutunda ve 44 Sayfadan oluşmaktadır.</li>
<li>Spiralli Yapıya Sahiptir.</li>
<li>1. Kalite Dijital Baskı &Uuml;r&uuml;n&uuml;d&uuml;r.</li>
</ul>', N'<ul class="detail-desc-list">
<li>A5 Boyutunda ve 44 Sayfadan oluşmaktadır.</li>
<li>Spiralli Yapıya Sahiptir.</li>
<li>1. Kalite Dijital Baskı &Uuml;r&uuml;n&uuml;d&uuml;r.</li>
</ul>', N'10bbc955-0730-4113-ae1d-e224586b5c00.png', N'4ec7bae1-5778-44db-bf80-c161ceac2871.png', NULL, 1, NULL, N'https://www.trendyol.com/lotus/ceyiz-defteri-dugun-planlayici-ceyiz-listesi-ceyiz-soz-nisan-kina-balayi-planlayici-spiralli-p-786664410?merchantId=761639&filterOverPriceListings=false', N'https://www.trendyol.com/lotus/ceyiz-defteri-dugun-planlayici-ceyiz-listesi-ceyiz-soz-nisan-kina-balayi-planlayici-spiralli-p-786664410?merchantId=761639&filterOverPriceListings=false', NULL, N'Çeyiz Defteri, Düğün Planlayıcı, Çeyiz Listesi, Çeyiz, Söz, Nişan, Kına, Balayı Planlayıcı, Spiralli', N'ceyiz-defteri-dugun-planlayici-ceyiz-listesi-ceyiz-soz-nisan-kina-balayi-planlayici-spiralli', 1)
INSERT [dbo].[Products] ([Id], [Title], [Contents], [ShortContent], [Image], [SmallImage], [Banner], [IsHome], [Link], [TrendyolLink], [HepsiBuradaLink], [CicekSepetiLink], [Name], [Url], [IsActive]) VALUES (3, N'Haftalık To Do List ', N'<p>50 yaprak 100 sayfadan oluşmaktadır. Arkasında sert karton bulunmaktadır. Tutkallı yapıdadır. &Ccedil;ekip koparılabilir. 1. kalite dijital baskı &uuml;r&uuml;n&uuml;d&uuml;r.</p>', NULL, N'4e0d72b7-873f-4c63-8f49-0dc7fc5ae159.png', N'f8121b82-ca06-4b5c-9b92-33f342f02e36.png', NULL, 1, NULL, N'https://www.trendyol.com/lotus/haftalik-yapilacaklar-to-do-list-gunluk-yapilacaklar-defter-planlayici-bloknot-hatirlatici-a5-p-713081337?merchantId=761639&filterOverPriceListings=false', NULL, NULL, N'Haftalık Yapılacaklar, To Do List, Günlük Yapılacaklar, Defter, Planlayıcı, Bloknot, Hatırlatıcı, A5', N'haftalik-yapilacaklar-to-do-list-gunluk-yapilacaklar-defter-planlayici-bloknot-hatirlatici-a5', 1)
INSERT [dbo].[Products] ([Id], [Title], [Contents], [ShortContent], [Image], [SmallImage], [Banner], [IsHome], [Link], [TrendyolLink], [HepsiBuradaLink], [CicekSepetiLink], [Name], [Url], [IsActive]) VALUES (4, N'Çeyiz To Do List', N'<p>50 yaprak 100 sayfadan oluşmaktadır. Arkasında sert karton bulunmaktadır. Tutkallı yapıdadır. &Ccedil;ekip koparılabilir. 1. kalite dijital baskı &uuml;r&uuml;n&uuml;d&uuml;r.</p>', NULL, N'b92a20ee-0bfe-46bd-9459-4357be358447.png', N'5dbc1286-e172-474b-9b01-0c925738358b.png', NULL, 1, NULL, N'https://www.trendyol.com/lotus/gunluk-yapilacaklar-to-do-list-not-defteri-defter-planlayici-bloknot-hatirlatici-a5-p-713124972?boutiqueId=61&merchantId=761639&filterOverPriceListings=false&sav=true', NULL, NULL, N'Çeyiz Bloknot, To Do List, Not Defteri, Defter, Planlayıcı, Bloknot, Hatırlatıcı, A5', N'ceyiz-bloknot-to-do-list-not-defteri-defter-planlayici-bloknot-hatirlatici-a5', 1)
INSERT [dbo].[Products] ([Id], [Title], [Contents], [ShortContent], [Image], [SmallImage], [Banner], [IsHome], [Link], [TrendyolLink], [HepsiBuradaLink], [CicekSepetiLink], [Name], [Url], [IsActive]) VALUES (5, N'Günlük To Do List', N'<p>50 yaprak 100 sayfadan oluşmaktadır. Arkasında sert karton bulunmaktadır. Tutkallı yapıdadır. &Ccedil;ekip koparılabilir. 1. kalite dijital baskı &uuml;r&uuml;n&uuml;d&uuml;r.</p>', NULL, N'2f9e483e-c44c-4e30-962b-426bec72fe7e.png', N'e01b705d-0438-49ba-9aed-43d5cee6963c.png', NULL, 1, NULL, N'https://www.trendyol.com/lotus/gunluk-yapilacaklar-to-do-list-not-defteri-defter-planlayici-bloknot-hatirlatici-a5-p-713055030?merchantId=761639&filterOverPriceListings=false', NULL, NULL, N'Günlük Yapılacaklar, To Do List, Not Defteri, Defter, Planlayıcı, Bloknot, Hatırlatıcı', N'gunluk-yapilacaklar-to-do-list-not-defteri-defter-planlayici-bloknot-hatirlatici', 1)
INSERT [dbo].[Products] ([Id], [Title], [Contents], [ShortContent], [Image], [SmallImage], [Banner], [IsHome], [Link], [TrendyolLink], [HepsiBuradaLink], [CicekSepetiLink], [Name], [Url], [IsActive]) VALUES (6, N'Sevgiliyle Yapılacaklar', N'<p>Aşk hayatınızı eğlenceli hale getirmek ister misiniz? Bu &uuml;r&uuml;n&uuml;m&uuml;z ile sizi buna davet ediyoruz. İ&ccedil;erisinde birbirinden g&uuml;zel 50 Aktivite bulunan &uuml;r&uuml;n&uuml;m&uuml;z sizlere &ouml;zel kutusu ile birlikte teslim edilmektedir. ; Sevgiliniz ile yapacak bir şey bulamıyorsanız ya da birlikte ge&ccedil;irdiğiniz vakitleri eğlenceli bir hale getirmek istiyorsanız doğru yerdesiniz. Her kartın &uuml;zerinde &ouml;zel boya bulunmakta ve bu boyayı kazıyarak i&ccedil;erisinde bulunan s&uuml;rpriz Aktiviteyi ortaya &ccedil;ıkarabilmektesiniz.</p>', NULL, N'7909f22a-403b-4c16-94b2-5d8c2015e05e.png', N'0a5916fe-3f0e-4ea5-b378-df6faa03f31c.png', NULL, 1, NULL, N'Aşk hayatınızı eğlenceli hale getirmek ister misiniz? Bu ürünümüz ile sizi buna davet ediyoruz... ; İçerisinde birbirinden güzel 50 Aktivite bulunan ürünümüz sizlere özel kutusu ile birlikte teslim edilmektedir. ; Sevgiliniz ile yapacak bir şey bulamıyorsanız ya da birlikte geçirdiğiniz vakitleri eğlenceli bir hale getirmek istiyorsanız doğru yerdesiniz. ; Her kartın üzerinde özel boya bulunmakta ve bu boyayı kazıyarak içerisinde bulunan sürpriz Aktiviteyi ortaya çıkarabilmektesiniz. ;', NULL, NULL, N'Sevgiliyle Yapılacak 50 Aktivite, Eğlence Kartı, Anı Kartı, Aşk Kartı, Hediyelik, Oyun Kartı', N'sevgiliyle-yapilacak-50-aktivite-eglence-karti-ani-karti-ask-karti-hediyelik-oyun-karti', 1)
INSERT [dbo].[Products] ([Id], [Title], [Contents], [ShortContent], [Image], [SmallImage], [Banner], [IsHome], [Link], [TrendyolLink], [HepsiBuradaLink], [CicekSepetiLink], [Name], [Url], [IsActive]) VALUES (7, N'İzlenecek Filmler', N'<p>Film ser&uuml;veninizi eğlenceli hale getirmek ister misiniz? Bu &uuml;r&uuml;n&uuml;m&uuml;z ile sizi buna davet ediyoruz. İ&ccedil;erisinde birbirinden g&uuml;zel 50 film bulunan &uuml;r&uuml;n&uuml;m&uuml;z sizlere &ouml;zel kutusu ile birlikte teslim edilmektedir. ; İzleyeceğiniz filmi se&ccedil;emiyorsanız ya da film izlemeyi eğlenceli bir hale getirmek istiyorsanız doğru yerdesiniz. Her kartın &uuml;zerinde &ouml;zel boya bulunmakta ve bu boyayı kazıyarak i&ccedil;erisinde bulunan s&uuml;rpriz filmi ortaya &ccedil;ıkarabilmektesiniz.</p>', NULL, N'b38ca2e5-9a6b-4cd6-934d-3af7d70299eb.png', N'17f5a50d-653f-48ac-bfed-502a974e9d40.png', NULL, 1, N'https://www.trendyol.com/lotus/imdb-izlenecek-50-film-film-karti-ani-karti-kazi-kazan-film-karti-eglence-karti-oyun-karti-p-773996111?merchantId=761639&filterOverPriceListings=false', N'https://www.trendyol.com/lotus/imdb-izlenecek-50-film-film-karti-ani-karti-kazi-kazan-film-karti-eglence-karti-oyun-karti-p-773996111?merchantId=761639&filterOverPriceListings=false', NULL, NULL, N'Imdb Izlenecek 50 Film, Film Kartı, Anı Kartı, Kazı Kazan Film Kartı, Eğlence Kartı, Oyun Kartı', N'imdb-izlenecek-50-film-film-karti-ani-karti-kazi-kazan-film-karti-eglence-karti-oyun-karti', 1)
INSERT [dbo].[Products] ([Id], [Title], [Contents], [ShortContent], [Image], [SmallImage], [Banner], [IsHome], [Link], [TrendyolLink], [HepsiBuradaLink], [CicekSepetiLink], [Name], [Url], [IsActive]) VALUES (8, N'Kartvizit', NULL, NULL, N'0e463ca8-361d-4fb5-baaf-1ae7c9c6e022.png', N'd5f02f36-38cb-4a37-b5f6-e7177f1a95d3.png', NULL, 1, NULL, NULL, NULL, NULL, N'Kartvizit', N'kartvizit', 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [Favicon], [Logo], [Adress], [Email], [Title], [Twitter], [Facebook], [Youtube], [Instagram], [Trendyol], [Hepsiburada], [Ciceksepeti], [FooterContent], [Phone], [Name], [Url], [IsActive]) VALUES (1, N'', N'', N'Sarıyer/İstanbul', N'midillidesign@gmail.com', N'ceyizdefteri.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 10.03.2024 09:41:31 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 10.03.2024 09:41:31 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 10.03.2024 09:41:31 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 10.03.2024 09:41:31 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 10.03.2024 09:41:31 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 10.03.2024 09:41:31 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 10.03.2024 09:41:31 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DocumentGalleries_InnerPageId]    Script Date: 10.03.2024 09:41:31 ******/
CREATE NONCLUSTERED INDEX [IX_DocumentGalleries_InnerPageId] ON [dbo].[DocumentGalleries]
(
	[InnerPageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DocumentGalleries_ProductId]    Script Date: 10.03.2024 09:41:31 ******/
CREATE NONCLUSTERED INDEX [IX_DocumentGalleries_ProductId] ON [dbo].[DocumentGalleries]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ImageGalleries_InnerPageId]    Script Date: 10.03.2024 09:41:31 ******/
CREATE NONCLUSTERED INDEX [IX_ImageGalleries_InnerPageId] ON [dbo].[ImageGalleries]
(
	[InnerPageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ImageGalleries_ProductId]    Script Date: 10.03.2024 09:41:31 ******/
CREATE NONCLUSTERED INDEX [IX_ImageGalleries_ProductId] ON [dbo].[ImageGalleries]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Images_ImageGalleryId]    Script Date: 10.03.2024 09:41:31 ******/
CREATE NONCLUSTERED INDEX [IX_Images_ImageGalleryId] ON [dbo].[Images]
(
	[ImageGalleryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_InnerPages_PageId]    Script Date: 10.03.2024 09:41:31 ******/
CREATE NONCLUSTERED INDEX [IX_InnerPages_PageId] ON [dbo].[InnerPages]
(
	[PageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductCategories_CategoryId]    Script Date: 10.03.2024 09:41:31 ******/
CREATE NONCLUSTERED INDEX [IX_ProductCategories_CategoryId] ON [dbo].[ProductCategories]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductCategories_ProductId]    Script Date: 10.03.2024 09:41:31 ******/
CREATE NONCLUSTERED INDEX [IX_ProductCategories_ProductId] ON [dbo].[ProductCategories]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_VideoGalleries_InnerPageId]    Script Date: 10.03.2024 09:41:31 ******/
CREATE NONCLUSTERED INDEX [IX_VideoGalleries_InnerPageId] ON [dbo].[VideoGalleries]
(
	[InnerPageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_VideoGalleries_ProductId]    Script Date: 10.03.2024 09:41:31 ******/
CREATE NONCLUSTERED INDEX [IX_VideoGalleries_ProductId] ON [dbo].[VideoGalleries]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[DocumentGalleries]  WITH CHECK ADD  CONSTRAINT [FK_DocumentGalleries_InnerPages_InnerPageId] FOREIGN KEY([InnerPageId])
REFERENCES [dbo].[InnerPages] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[DocumentGalleries] CHECK CONSTRAINT [FK_DocumentGalleries_InnerPages_InnerPageId]
GO
ALTER TABLE [dbo].[DocumentGalleries]  WITH CHECK ADD  CONSTRAINT [FK_DocumentGalleries_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[DocumentGalleries] CHECK CONSTRAINT [FK_DocumentGalleries_Products_ProductId]
GO
ALTER TABLE [dbo].[ImageGalleries]  WITH CHECK ADD  CONSTRAINT [FK_ImageGalleries_InnerPages_InnerPageId] FOREIGN KEY([InnerPageId])
REFERENCES [dbo].[InnerPages] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[ImageGalleries] CHECK CONSTRAINT [FK_ImageGalleries_InnerPages_InnerPageId]
GO
ALTER TABLE [dbo].[ImageGalleries]  WITH CHECK ADD  CONSTRAINT [FK_ImageGalleries_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[ImageGalleries] CHECK CONSTRAINT [FK_ImageGalleries_Products_ProductId]
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_ImageGalleries_ImageGalleryId] FOREIGN KEY([ImageGalleryId])
REFERENCES [dbo].[ImageGalleries] ([Id])
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_ImageGalleries_ImageGalleryId]
GO
ALTER TABLE [dbo].[InnerPages]  WITH CHECK ADD  CONSTRAINT [FK_InnerPages_Pages_PageId] FOREIGN KEY([PageId])
REFERENCES [dbo].[Pages] ([Id])
GO
ALTER TABLE [dbo].[InnerPages] CHECK CONSTRAINT [FK_InnerPages_Pages_PageId]
GO
ALTER TABLE [dbo].[ProductCategories]  WITH CHECK ADD  CONSTRAINT [FK_ProductCategories_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductCategories] CHECK CONSTRAINT [FK_ProductCategories_Categories_CategoryId]
GO
ALTER TABLE [dbo].[ProductCategories]  WITH CHECK ADD  CONSTRAINT [FK_ProductCategories_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductCategories] CHECK CONSTRAINT [FK_ProductCategories_Products_ProductId]
GO
ALTER TABLE [dbo].[VideoGalleries]  WITH CHECK ADD  CONSTRAINT [FK_VideoGalleries_InnerPages_InnerPageId] FOREIGN KEY([InnerPageId])
REFERENCES [dbo].[InnerPages] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[VideoGalleries] CHECK CONSTRAINT [FK_VideoGalleries_InnerPages_InnerPageId]
GO
ALTER TABLE [dbo].[VideoGalleries]  WITH CHECK ADD  CONSTRAINT [FK_VideoGalleries_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[VideoGalleries] CHECK CONSTRAINT [FK_VideoGalleries_Products_ProductId]
GO
USE [master]
GO
ALTER DATABASE [LotusDijital] SET  READ_WRITE 
GO
