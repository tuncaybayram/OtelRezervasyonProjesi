USE [master]
GO

/****** Object:  Database [OtelRezarvasyon]    Script Date: 6/2/2022 2:44:58 PM ******/
CREATE DATABASE [OtelRezarvasyon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OtelRezarvasyon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\OtelRezarvasyon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OtelRezarvasyon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\OtelRezarvasyon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OtelRezarvasyon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OtelRezarvasyon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET ARITHABORT OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OtelRezarvasyon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OtelRezarvasyon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OtelRezarvasyon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OtelRezarvasyon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET RECOVERY FULL 
GO
ALTER DATABASE [OtelRezarvasyon] SET  MULTI_USER 
GO
ALTER DATABASE [OtelRezarvasyon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OtelRezarvasyon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OtelRezarvasyon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OtelRezarvasyon] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OtelRezarvasyon] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'OtelRezarvasyon', N'ON'
GO
ALTER DATABASE [OtelRezarvasyon] SET QUERY_STORE = OFF
GO
USE [OtelRezarvasyon]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [OtelRezarvasyon]
GO
/****** Object:  Database [OtelRezarvasyon]    Script Date: 6/2/2022 2:44:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[MusteriID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAd] [nvarchar](50) NOT NULL,
	[MusteriSoyad] [nvarchar](50) NOT NULL,
	[MusteriDTarih] [datetime] NOT NULL,
	[Cinsiyet] [int] NOT NULL,
	[Adres] [nvarchar](70) NOT NULL,
	[Tel] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Musteri] PRIMARY KEY CLUSTERED 
(
	[MusteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Database [OtelRezarvasyon]    Script Date: 6/2/2022 2:44:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda](
	[OdaID] [int] IDENTITY(1,1) NOT NULL,
	[OtelID] [int] NOT NULL,
	[OdaBoyut] [int] NOT NULL,
	[OdaFiyat] [int] NOT NULL,
	[OdaDurum] [bit] NOT NULL,
 CONSTRAINT [PK_Oda] PRIMARY KEY CLUSTERED 
(
	[OdaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Database [OtelRezarvasyon]    Script Date: 6/2/2022 2:44:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OdaOzellik](
	[OdaOzellikID] [int] IDENTITY(1,1) NOT NULL,
	[OdaID] [int] NOT NULL,
	[OzellikID] [int] NOT NULL,
	[OzellikDurum] [bit] NOT NULL,
 CONSTRAINT [PK_OdaOzellik] PRIMARY KEY CLUSTERED 
(
	[OdaOzellikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Database [OtelRezarvasyon]    Script Date: 6/2/2022 2:44:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Otel](
	[OtelID] [int] IDENTITY(1,1) NOT NULL,
	[OtelAdi] [nvarchar](50) NOT NULL,
	[OtelSehir] [int] NOT NULL,
	[OtelIlce] [nvarchar](50) NOT NULL,
	[OtelDurum] [bit] NOT NULL,
 CONSTRAINT [PK_Otel] PRIMARY KEY CLUSTERED 
(
	[OtelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Database [OtelRezarvasyon]    Script Date: 6/2/2022 2:44:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OtelOzellik](
	[OtelOzellikID] [int] IDENTITY(1,1) NOT NULL,
	[OtelID] [int] NOT NULL,
	[OzellikID] [int] NOT NULL,
	[OzellikDurum] [bit] NOT NULL,
 CONSTRAINT [PK_OtelOzellik] PRIMARY KEY CLUSTERED 
(
	[OtelOzellikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Database [OtelRezarvasyon]    Script Date: 6/2/2022 2:44:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ozellik](
	[OzellikID] [int] IDENTITY(1,1) NOT NULL,
	[OzellikAd] [nvarchar](50) NOT NULL,
	[OzellikTip] [int] NOT NULL,
 CONSTRAINT [PK_Ozellik] PRIMARY KEY CLUSTERED 
(
	[OzellikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Database [OtelRezarvasyon]    Script Date: 6/2/2022 2:44:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervasyon](
	[RezervasyonID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriID] [int] NOT NULL,
	[GirisTarihi] [datetime] NOT NULL,
	[CikisTarihi] [datetime] NOT NULL,
	[OtelID] [int] NOT NULL,
	[OdaID] [int] NOT NULL,
	[islemTarihi] [datetime] NULL,
 CONSTRAINT [PK_Rezervasyon] PRIMARY KEY CLUSTERED 
(
	[RezervasyonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Musteri] ON 

INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriDTarih], [Cinsiyet], [Adres], [Tel], [Email]) VALUES (1, N'tuncay', N'bayran', CAST(N'1994-12-16T00:00:00.000' AS DateTime), 1, N'istan', N'1563432', N'asdfasdf@gamil.com')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriDTarih], [Cinsiyet], [Adres], [Tel], [Email]) VALUES (2, N'kutluhan', N'tarlacı', CAST(N'2019-12-19T00:00:00.000' AS DateTime), 0, N'sdads', N'(111) 111-1111', N'asdasda')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriDTarih], [Cinsiyet], [Adres], [Tel], [Email]) VALUES (3, N'evet', N'evet', CAST(N'2019-12-19T00:00:00.000' AS DateTime), 0, N'asdfasdf', N'(111) 111-1111', N'asdasd')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriDTarih], [Cinsiyet], [Adres], [Tel], [Email]) VALUES (4, N'butkana', N'asdfasdfa', CAST(N'2019-12-19T00:00:00.000' AS DateTime), 0, N'asdfasdf', N'(123) 123-1231', N'asdfasdf')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriDTarih], [Cinsiyet], [Adres], [Tel], [Email]) VALUES (5, N'nuru', N'kara', CAST(N'2019-12-19T00:00:00.000' AS DateTime), 1, N'gfdfg', N'(543) 878-6456', N'fasdfas')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriDTarih], [Cinsiyet], [Adres], [Tel], [Email]) VALUES (6, N'burak', N'türker', CAST(N'2014-06-11T00:00:00.000' AS DateTime), 1, N'asdfasdaf', N'(123) 333-3333', N'nurtuertu@gmail.com')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriDTarih], [Cinsiyet], [Adres], [Tel], [Email]) VALUES (7, N'fasdfasdf', N'asdfasdf', CAST(N'2019-12-19T00:00:00.000' AS DateTime), 1, N'asdfasdf', N'(123) 213-2131', N'qweqwe@gasdf')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriDTarih], [Cinsiyet], [Adres], [Tel], [Email]) VALUES (8, N'fgsdfg', N'sdfgsdfg', CAST(N'2019-12-19T00:00:00.000' AS DateTime), 1, N'asfdf', N'(123) 123-1231', N'asdfas')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriDTarih], [Cinsiyet], [Adres], [Tel], [Email]) VALUES (9, N'nuru', N'asdf', CAST(N'1955-07-15T00:00:00.000' AS DateTime), 1, N'nueatas/asdfa', N'(123) 123-1231', N'nurrtudfg')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriDTarih], [Cinsiyet], [Adres], [Tel], [Email]) VALUES (10, N'asdf', N'asdfasd', CAST(N'2019-12-20T00:00:00.000' AS DateTime), 0, N'asdfasdf', N'(123) 123-1231', N'sdafsd')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriDTarih], [Cinsiyet], [Adres], [Tel], [Email]) VALUES (11, N'asdfa', N'asdfas', CAST(N'2019-12-20T00:00:00.000' AS DateTime), 0, N'sdfasdf', N'(112) 312-3123', N'dasda')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriDTarih], [Cinsiyet], [Adres], [Tel], [Email]) VALUES (12, N'ASDFA', N'ASDF', CAST(N'2019-12-20T00:00:00.000' AS DateTime), 0, N'NRURU', N'(123) 123-1231', N'ADFVASDF')
SET IDENTITY_INSERT [dbo].[Musteri] OFF
SET IDENTITY_INSERT [dbo].[Oda] ON 

INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (1, 5, 0, 220, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (2, 6, 0, 102, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (3, 5, 0, 220, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (4, 5, 0, 220, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (5, 5, 0, 220, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (6, 5, 0, 220, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (7, 5, 0, 250, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (8, 5, 0, 250, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (9, 1, 0, 220, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (10, 1, 0, 220, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (11, 1, 0, 250, 0)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (12, 1, 0, 220, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (13, 1, 0, 220, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (14, 1, 0, 250, 0)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (15, 1, 0, 220, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (16, 1, 0, 220, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (17, 5, 0, 250, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (18, 5, 0, 250, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (19, 1, 0, 220, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (20, 7, 3, 99, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (21, 8, 0, 100, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (22, 8, 1, 50, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (23, 8, 2, 75, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (24, 8, 3, 150, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (25, 7, 3, 150, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (26, 7, 3, 150, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (27, 7, 3, 150, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (28, 7, 3, 150, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (29, 7, 0, 150, 1)
INSERT [dbo].[Oda] ([OdaID], [OtelID], [OdaBoyut], [OdaFiyat], [OdaDurum]) VALUES (30, 7, 0, 150, 1)
SET IDENTITY_INSERT [dbo].[Oda] OFF
SET IDENTITY_INSERT [dbo].[OdaOzellik] ON 

INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (53, 2, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (54, 2, 6, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (57, 19, 10, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (58, 19, 9, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (59, 19, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (60, 20, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (61, 20, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (62, 20, 10, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (63, 20, 9, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (64, 21, 6, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (65, 21, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (66, 21, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (67, 21, 9, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (68, 21, 10, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (69, 22, 6, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (70, 22, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (71, 22, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (72, 22, 9, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (73, 22, 10, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (74, 23, 6, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (75, 23, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (76, 23, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (77, 23, 9, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (78, 23, 10, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (79, 24, 6, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (80, 24, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (81, 24, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (82, 24, 9, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (83, 24, 10, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (84, 9, 6, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (85, 9, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (86, 9, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (87, 9, 9, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (88, 9, 10, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (89, 10, 6, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (90, 10, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (91, 10, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (92, 10, 9, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (93, 10, 10, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (94, 12, 9, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (95, 13, 9, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (96, 15, 9, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (97, 16, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (98, 1, 6, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (99, 3, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (100, 4, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (101, 5, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (102, 6, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (103, 8, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (104, 8, 9, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (105, 18, 10, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (106, 18, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (107, 7, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (108, 17, 10, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (109, 17, 9, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (110, 17, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (111, 25, 6, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (112, 25, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (113, 25, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (114, 26, 6, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (115, 26, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (116, 26, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (117, 27, 6, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (118, 27, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (119, 27, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (120, 28, 6, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (121, 28, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (122, 28, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (123, 29, 6, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (124, 29, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (125, 29, 8, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (126, 30, 6, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (127, 30, 7, 1)
INSERT [dbo].[OdaOzellik] ([OdaOzellikID], [OdaID], [OzellikID], [OzellikDurum]) VALUES (128, 30, 8, 1)
SET IDENTITY_INSERT [dbo].[OdaOzellik] OFF
SET IDENTITY_INSERT [dbo].[Otel] ON 

INSERT [dbo].[Otel] ([OtelID], [OtelAdi], [OtelSehir], [OtelIlce], [OtelDurum]) VALUES (1, N'ArtıkHisar', 7, N'Artço', 1)
INSERT [dbo].[Otel] ([OtelID], [OtelAdi], [OtelSehir], [OtelIlce], [OtelDurum]) VALUES (2, N'Ceyhan Yıldız Oteli', 0, N'Ceyhan', 0)
INSERT [dbo].[Otel] ([OtelID], [OtelAdi], [OtelSehir], [OtelIlce], [OtelDurum]) VALUES (3, N'Çiğköfte Oteli', 1, N'Falan', 0)
INSERT [dbo].[Otel] ([OtelID], [OtelAdi], [OtelSehir], [OtelIlce], [OtelDurum]) VALUES (4, N'Şef Otel', 13, N'Mengen', 0)
INSERT [dbo].[Otel] ([OtelID], [OtelAdi], [OtelSehir], [OtelIlce], [OtelDurum]) VALUES (5, N'Kebab 0101', 0, N'Ceyhan', 1)
INSERT [dbo].[Otel] ([OtelID], [OtelAdi], [OtelSehir], [OtelIlce], [OtelDurum]) VALUES (6, N'Ceyhan 01', 0, N'Ceyhan', 1)
INSERT [dbo].[Otel] ([OtelID], [OtelAdi], [OtelSehir], [OtelIlce], [OtelDurum]) VALUES (7, N'Balıklı Otel', 9, N'Zeytinli', 1)
INSERT [dbo].[Otel] ([OtelID], [OtelAdi], [OtelSehir], [OtelIlce], [OtelDurum]) VALUES (8, N'Kiğı Özel Oteli', 11, N'Kiğı', 1)
SET IDENTITY_INSERT [dbo].[Otel] OFF
SET IDENTITY_INSERT [dbo].[OtelOzellik] ON 

INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (1, 1, 5, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (2, 1, 3, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (3, 1, 4, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (5, 1, 1, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (6, 5, 5, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (7, 5, 3, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (8, 5, 1, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (9, 6, 5, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (10, 6, 3, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (11, 6, 2, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (12, 6, 4, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (13, 7, 4, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (14, 7, 3, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (15, 8, 11, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (16, 8, 5, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (17, 8, 4, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (18, 8, 3, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (19, 8, 2, 1)
INSERT [dbo].[OtelOzellik] ([OtelOzellikID], [OtelID], [OzellikID], [OzellikDurum]) VALUES (20, 8, 1, 1)
SET IDENTITY_INSERT [dbo].[OtelOzellik] OFF
SET IDENTITY_INSERT [dbo].[Ozellik] ON 

INSERT [dbo].[Ozellik] ([OzellikID], [OzellikAd], [OzellikTip]) VALUES (1, N'Havuz', 0)
INSERT [dbo].[Ozellik] ([OzellikID], [OzellikAd], [OzellikTip]) VALUES (2, N'Kapalı Havuz', 0)
INSERT [dbo].[Ozellik] ([OzellikID], [OzellikAd], [OzellikTip]) VALUES (3, N'Otopark', 0)
INSERT [dbo].[Ozellik] ([OzellikID], [OzellikAd], [OzellikTip]) VALUES (4, N'Bar', 0)
INSERT [dbo].[Ozellik] ([OzellikID], [OzellikAd], [OzellikTip]) VALUES (5, N'Hamam', 0)
INSERT [dbo].[Ozellik] ([OzellikID], [OzellikAd], [OzellikTip]) VALUES (6, N'WİFİ', 1)
INSERT [dbo].[Ozellik] ([OzellikID], [OzellikAd], [OzellikTip]) VALUES (7, N'24 Saat Sıcak Su', 1)
INSERT [dbo].[Ozellik] ([OzellikID], [OzellikAd], [OzellikTip]) VALUES (8, N'TV', 1)
INSERT [dbo].[Ozellik] ([OzellikID], [OzellikAd], [OzellikTip]) VALUES (9, N'Mini Bar', 1)
INSERT [dbo].[Ozellik] ([OzellikID], [OzellikAd], [OzellikTip]) VALUES (10, N'Klima', 1)
INSERT [dbo].[Ozellik] ([OzellikID], [OzellikAd], [OzellikTip]) VALUES (11, N'Helikopter Sahası', 0)
SET IDENTITY_INSERT [dbo].[Ozellik] OFF
SET IDENTITY_INSERT [dbo].[Rezervasyon] ON 

INSERT [dbo].[Rezervasyon] ([RezervasyonID], [MusteriID], [GirisTarihi], [CikisTarihi], [OtelID], [OdaID], [islemTarihi]) VALUES (5, 6, CAST(N'2019-12-19T17:57:19.783' AS DateTime), CAST(N'2019-12-19T17:57:19.783' AS DateTime), 6, 2, CAST(N'2019-12-19T17:58:19.720' AS DateTime))
INSERT [dbo].[Rezervasyon] ([RezervasyonID], [MusteriID], [GirisTarihi], [CikisTarihi], [OtelID], [OdaID], [islemTarihi]) VALUES (6, 7, CAST(N'2019-12-19T18:02:47.000' AS DateTime), CAST(N'2019-12-21T18:02:47.000' AS DateTime), 5, 3, CAST(N'2019-12-19T18:03:48.820' AS DateTime))
INSERT [dbo].[Rezervasyon] ([RezervasyonID], [MusteriID], [GirisTarihi], [CikisTarihi], [OtelID], [OdaID], [islemTarihi]) VALUES (7, 8, CAST(N'2019-12-19T18:06:55.877' AS DateTime), CAST(N'2019-12-19T18:06:55.877' AS DateTime), 8, 24, CAST(N'2019-12-19T18:09:00.500' AS DateTime))
INSERT [dbo].[Rezervasyon] ([RezervasyonID], [MusteriID], [GirisTarihi], [CikisTarihi], [OtelID], [OdaID], [islemTarihi]) VALUES (8, 9, CAST(N'2019-12-19T18:25:32.793' AS DateTime), CAST(N'2019-12-19T18:25:32.793' AS DateTime), 1, 9, CAST(N'2019-12-19T18:26:09.340' AS DateTime))
INSERT [dbo].[Rezervasyon] ([RezervasyonID], [MusteriID], [GirisTarihi], [CikisTarihi], [OtelID], [OdaID], [islemTarihi]) VALUES (9, 10, CAST(N'2019-12-20T00:19:04.093' AS DateTime), CAST(N'2019-12-20T00:19:04.093' AS DateTime), 5, 6, CAST(N'2019-12-20T00:19:42.217' AS DateTime))
INSERT [dbo].[Rezervasyon] ([RezervasyonID], [MusteriID], [GirisTarihi], [CikisTarihi], [OtelID], [OdaID], [islemTarihi]) VALUES (10, 11, CAST(N'2019-12-20T00:20:57.063' AS DateTime), CAST(N'2019-12-20T00:20:57.063' AS DateTime), 8, 23, CAST(N'2019-12-20T00:21:58.310' AS DateTime))
INSERT [dbo].[Rezervasyon] ([RezervasyonID], [MusteriID], [GirisTarihi], [CikisTarihi], [OtelID], [OdaID], [islemTarihi]) VALUES (11, 12, CAST(N'2019-12-20T09:33:15.667' AS DateTime), CAST(N'2019-12-20T09:33:15.667' AS DateTime), 8, 21, CAST(N'2019-12-20T09:34:21.573' AS DateTime))
SET IDENTITY_INSERT [dbo].[Rezervasyon] OFF
ALTER TABLE [dbo].[Oda]  WITH CHECK ADD  CONSTRAINT [FK_Oda_Otel] FOREIGN KEY([OtelID])
REFERENCES [dbo].[Otel] ([OtelID])
GO
ALTER TABLE [dbo].[Oda] CHECK CONSTRAINT [FK_Oda_Otel]
GO
ALTER TABLE [dbo].[OdaOzellik]  WITH CHECK ADD  CONSTRAINT [FK_OdaOzellik_Oda] FOREIGN KEY([OdaID])
REFERENCES [dbo].[Oda] ([OdaID])
GO
ALTER TABLE [dbo].[OdaOzellik] CHECK CONSTRAINT [FK_OdaOzellik_Oda]
GO
ALTER TABLE [dbo].[OdaOzellik]  WITH CHECK ADD  CONSTRAINT [FK_OdaOzellik_Ozellik] FOREIGN KEY([OzellikID])
REFERENCES [dbo].[Ozellik] ([OzellikID])
GO
ALTER TABLE [dbo].[OdaOzellik] CHECK CONSTRAINT [FK_OdaOzellik_Ozellik]
GO
ALTER TABLE [dbo].[OtelOzellik]  WITH CHECK ADD  CONSTRAINT [FK_OtelOzellik_Otel] FOREIGN KEY([OtelID])
REFERENCES [dbo].[Otel] ([OtelID])
GO
ALTER TABLE [dbo].[OtelOzellik] CHECK CONSTRAINT [FK_OtelOzellik_Otel]
GO
ALTER TABLE [dbo].[OtelOzellik]  WITH CHECK ADD  CONSTRAINT [FK_OtelOzellik_Ozellik] FOREIGN KEY([OzellikID])
REFERENCES [dbo].[Ozellik] ([OzellikID])
GO
ALTER TABLE [dbo].[OtelOzellik] CHECK CONSTRAINT [FK_OtelOzellik_Ozellik]
GO
ALTER TABLE [dbo].[Rezervasyon]  WITH CHECK ADD  CONSTRAINT [FK_Rezervasyon_Musteri] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[Musteri] ([MusteriID])
GO
ALTER TABLE [dbo].[Rezervasyon] CHECK CONSTRAINT [FK_Rezervasyon_Musteri]
GO
ALTER TABLE [dbo].[Rezervasyon]  WITH CHECK ADD  CONSTRAINT [FK_Rezervasyon_Oda] FOREIGN KEY([OdaID])
REFERENCES [dbo].[Oda] ([OdaID])
GO
ALTER TABLE [dbo].[Rezervasyon] CHECK CONSTRAINT [FK_Rezervasyon_Oda]
GO
ALTER TABLE [dbo].[Rezervasyon]  WITH CHECK ADD  CONSTRAINT [FK_Rezervasyon_Otel] FOREIGN KEY([OtelID])
REFERENCES [dbo].[Otel] ([OtelID])
GO
ALTER TABLE [dbo].[Rezervasyon] CHECK CONSTRAINT [FK_Rezervasyon_Otel]
GO
USE [master]
GO
ALTER DATABASE [OtelRezarvasyon] SET  READ_WRITE 
GO
