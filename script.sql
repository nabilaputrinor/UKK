USE [master]
GO
/****** Object:  Database [db_UKK_NABILA]    Script Date: 11/04/2021 20:31:38 ******/
CREATE DATABASE [db_UKK_NABILA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_UKK_NABILA', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\db_UKK_NABILA.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_UKK_NABILA_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\db_UKK_NABILA_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_UKK_NABILA] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_UKK_NABILA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_UKK_NABILA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_UKK_NABILA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_UKK_NABILA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_UKK_NABILA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_UKK_NABILA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_UKK_NABILA] SET  MULTI_USER 
GO
ALTER DATABASE [db_UKK_NABILA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_UKK_NABILA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_UKK_NABILA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_UKK_NABILA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [db_UKK_NABILA] SET DELAYED_DURABILITY = DISABLED 
GO
USE [db_UKK_NABILA]
GO
/****** Object:  User [nabilaputri]    Script Date: 11/04/2021 20:31:39 ******/
CREATE USER [nabilaputri] FOR LOGIN [nabilaputri] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[barang]    Script Date: 11/04/2021 20:31:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[barang](
	[id_barang] [varchar](8) NOT NULL,
	[nama_barang] [varchar](100) NULL,
	[tgl] [date] NULL,
	[harga_awal] [int] NULL,
	[desk_barang] [varchar](50) NULL,
 CONSTRAINT [PK_barang] PRIMARY KEY CLUSTERED 
(
	[id_barang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[history]    Script Date: 11/04/2021 20:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[history](
	[id_history] [varchar](8) NOT NULL,
	[id_lelang] [varchar](8) NULL,
	[id_barang] [varchar](8) NULL,
	[id_user] [varchar](8) NULL,
	[penawaran_harga] [int] NULL,
 CONSTRAINT [PK_history] PRIMARY KEY CLUSTERED 
(
	[id_history] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[lelang]    Script Date: 11/04/2021 20:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[lelang](
	[id_lelang] [varchar](8) NOT NULL,
	[id_barang] [varchar](8) NULL,
	[tgl_lelang] [date] NULL,
	[harga_akhir] [int] NULL,
	[id_user] [varchar](8) NULL,
	[id_petugas] [varchar](8) NULL,
	[status] [varchar](8) NULL,
 CONSTRAINT [PK_lelang] PRIMARY KEY CLUSTERED 
(
	[id_lelang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[level]    Script Date: 11/04/2021 20:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[level](
	[id_level] [varchar](8) NOT NULL,
	[hak] [varchar](10) NULL,
 CONSTRAINT [PK_level] PRIMARY KEY CLUSTERED 
(
	[id_level] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[masyarakat]    Script Date: 11/04/2021 20:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[masyarakat](
	[id_user] [varchar](8) NOT NULL,
	[nama_lengkap] [varchar](35) NULL,
	[username] [varchar](12) NULL,
	[password] [varchar](12) NULL,
	[telp] [varchar](15) NULL,
 CONSTRAINT [PK_masyarakat] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[petugas]    Script Date: 11/04/2021 20:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[petugas](
	[id_petugas] [varchar](8) NOT NULL,
	[nama_petugas] [varchar](25) NULL,
	[username] [varchar](12) NULL,
	[password] [varchar](12) NULL,
	[id_level] [varchar](8) NULL,
 CONSTRAINT [PK_petugas] PRIMARY KEY CLUSTERED 
(
	[id_petugas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[barang] ([id_barang], [nama_barang], [tgl], [harga_awal], [desk_barang]) VALUES (N'IB-01', N'Daihatsu Ayla', CAST(N'2020-02-22' AS Date), 100000000, N'Warna merah, Varian 1.0L X-Deluxe')
INSERT [dbo].[barang] ([id_barang], [nama_barang], [tgl], [harga_awal], [desk_barang]) VALUES (N'IB-02', N'Daihatsu Ayla', CAST(N'2020-02-25' AS Date), 125000000, N'Warna silver, Varian 1.2L R-Deluxe')
INSERT [dbo].[barang] ([id_barang], [nama_barang], [tgl], [harga_awal], [desk_barang]) VALUES (N'IB-03', N'Toyota Agya', CAST(N'2020-03-01' AS Date), 220000000, N'Warna putih, type citycar')
INSERT [dbo].[barang] ([id_barang], [nama_barang], [tgl], [harga_awal], [desk_barang]) VALUES (N'IB-04', N'Ford Focus', CAST(N'2020-04-06' AS Date), 200000000, N'Warna hitam, type sedan')
INSERT [dbo].[barang] ([id_barang], [nama_barang], [tgl], [harga_awal], [desk_barang]) VALUES (N'IB-05', N'Honda jazz', CAST(N'2021-04-08' AS Date), 100000000, N'warna putih')
INSERT [dbo].[history] ([id_history], [id_lelang], [id_barang], [id_user], [penawaran_harga]) VALUES (N'IH-01', N'IL-01', N'IB-01', N'IM-01', 105000000)
INSERT [dbo].[history] ([id_history], [id_lelang], [id_barang], [id_user], [penawaran_harga]) VALUES (N'IH-02', N'IL-02', N'IB-03', N'IM-04', 200000000)
INSERT [dbo].[history] ([id_history], [id_lelang], [id_barang], [id_user], [penawaran_harga]) VALUES (N'IH-03', N'IL-03', N'IB-02', N'IM-03', 150000000)
INSERT [dbo].[history] ([id_history], [id_lelang], [id_barang], [id_user], [penawaran_harga]) VALUES (N'IH-04', N'iL-01', N'iB-01', N'IM-05', 1500000000)
INSERT [dbo].[history] ([id_history], [id_lelang], [id_barang], [id_user], [penawaran_harga]) VALUES (N'IH-05', N'IL-04', N'IB-05', N'IM-07', 120000000)
INSERT [dbo].[history] ([id_history], [id_lelang], [id_barang], [id_user], [penawaran_harga]) VALUES (N'IH-06', N'IL-05', N'IB-02', N'IM-03', 160000000)
INSERT [dbo].[lelang] ([id_lelang], [id_barang], [tgl_lelang], [harga_akhir], [id_user], [id_petugas], [status]) VALUES (N'IL-01', N'IB-01', CAST(N'2020-02-22' AS Date), 110000000, N'IM-01', N'IP-01', N'ditutup')
INSERT [dbo].[lelang] ([id_lelang], [id_barang], [tgl_lelang], [harga_akhir], [id_user], [id_petugas], [status]) VALUES (N'IL-02', N'IB-03', CAST(N'2020-03-03' AS Date), 220000000, N'IM-04', N'IP-01', N'ditutup')
INSERT [dbo].[lelang] ([id_lelang], [id_barang], [tgl_lelang], [harga_akhir], [id_user], [id_petugas], [status]) VALUES (N'IL-03', N'IB-02', CAST(N'2021-04-06' AS Date), 0, N'IM-03', N'IP-01', N'dibuka')
INSERT [dbo].[lelang] ([id_lelang], [id_barang], [tgl_lelang], [harga_akhir], [id_user], [id_petugas], [status]) VALUES (N'IL-04', N'iB-01', CAST(N'2021-04-07' AS Date), 0, N'IM-03', N'IP-01', N'dibuka')
INSERT [dbo].[lelang] ([id_lelang], [id_barang], [tgl_lelang], [harga_akhir], [id_user], [id_petugas], [status]) VALUES (N'IL-05', N'IB-03', CAST(N'2021-04-11' AS Date), 0, N'IM-04', N'IP-02', N'dibuka')
INSERT [dbo].[level] ([id_level], [hak]) VALUES (N'LV-01', N'petugas')
INSERT [dbo].[level] ([id_level], [hak]) VALUES (N'LV-02', N'admin')
INSERT [dbo].[masyarakat] ([id_user], [nama_lengkap], [username], [password], [telp]) VALUES (N'IM-01', N'Nabila putri normalita', N'bibil', N'0604', N'0821-5015-0651')
INSERT [dbo].[masyarakat] ([id_user], [nama_lengkap], [username], [password], [telp]) VALUES (N'IM-02', N'Risma wati putri', N'risma', N'0110', N'0822-5564-5023')
INSERT [dbo].[masyarakat] ([id_user], [nama_lengkap], [username], [password], [telp]) VALUES (N'IM-03', N'Lintang cahyaningtyas', N'alin', N'2220', N'0812-5041-2020')
INSERT [dbo].[masyarakat] ([id_user], [nama_lengkap], [username], [password], [telp]) VALUES (N'IM-04', N'Novalitza', N'novaa', N'1212', N'0852-4550-0687')
INSERT [dbo].[masyarakat] ([id_user], [nama_lengkap], [username], [password], [telp]) VALUES (N'IM-05', N'Muhammad rafi', N'rafii', N'2207', N'0812-5014-2556')
INSERT [dbo].[masyarakat] ([id_user], [nama_lengkap], [username], [password], [telp]) VALUES (N'IM-06', N'nurul fatimah', N'nurul', N'nurul123', N'0812-5041-6989')
INSERT [dbo].[masyarakat] ([id_user], [nama_lengkap], [username], [password], [telp]) VALUES (N'IM-07', N'nabila putri', N'nabila01', N'123456', N'0821-5746-2044')
INSERT [dbo].[masyarakat] ([id_user], [nama_lengkap], [username], [password], [telp]) VALUES (N'IM-08', N'nurul fatimah', N'nurul', N'nurul01', N'0821-5445-8962')
INSERT [dbo].[masyarakat] ([id_user], [nama_lengkap], [username], [password], [telp]) VALUES (N'IM-09', N'nur fitria', N'tia', N'2020', N'0812-5695-8974')
INSERT [dbo].[petugas] ([id_petugas], [nama_petugas], [username], [password], [id_level]) VALUES (N'IP-01', N'Muhammad Irawan', N'iwan', N'1201', N'LV-01')
INSERT [dbo].[petugas] ([id_petugas], [nama_petugas], [username], [password], [id_level]) VALUES (N'IP-02', N'Fikri Ramadhan', N'fikri', N'1010', N'LV-02')
INSERT [dbo].[petugas] ([id_petugas], [nama_petugas], [username], [password], [id_level]) VALUES (N'IP-03', N'Nur Fitria', N'Tia', N'1001', N'LV-01')
ALTER TABLE [dbo].[history]  WITH CHECK ADD  CONSTRAINT [FK_history_barang] FOREIGN KEY([id_barang])
REFERENCES [dbo].[barang] ([id_barang])
GO
ALTER TABLE [dbo].[history] CHECK CONSTRAINT [FK_history_barang]
GO
ALTER TABLE [dbo].[history]  WITH CHECK ADD  CONSTRAINT [FK_history_lelang] FOREIGN KEY([id_lelang])
REFERENCES [dbo].[lelang] ([id_lelang])
GO
ALTER TABLE [dbo].[history] CHECK CONSTRAINT [FK_history_lelang]
GO
ALTER TABLE [dbo].[history]  WITH CHECK ADD  CONSTRAINT [FK_history_masyarakat] FOREIGN KEY([id_user])
REFERENCES [dbo].[masyarakat] ([id_user])
GO
ALTER TABLE [dbo].[history] CHECK CONSTRAINT [FK_history_masyarakat]
GO
ALTER TABLE [dbo].[lelang]  WITH CHECK ADD  CONSTRAINT [FK_lelang_barang] FOREIGN KEY([id_barang])
REFERENCES [dbo].[barang] ([id_barang])
GO
ALTER TABLE [dbo].[lelang] CHECK CONSTRAINT [FK_lelang_barang]
GO
ALTER TABLE [dbo].[lelang]  WITH CHECK ADD  CONSTRAINT [FK_lelang_masyarakat] FOREIGN KEY([id_user])
REFERENCES [dbo].[masyarakat] ([id_user])
GO
ALTER TABLE [dbo].[lelang] CHECK CONSTRAINT [FK_lelang_masyarakat]
GO
ALTER TABLE [dbo].[lelang]  WITH CHECK ADD  CONSTRAINT [FK_lelang_petugas] FOREIGN KEY([id_petugas])
REFERENCES [dbo].[petugas] ([id_petugas])
GO
ALTER TABLE [dbo].[lelang] CHECK CONSTRAINT [FK_lelang_petugas]
GO
ALTER TABLE [dbo].[petugas]  WITH CHECK ADD  CONSTRAINT [FK_petugas_level] FOREIGN KEY([id_level])
REFERENCES [dbo].[level] ([id_level])
GO
ALTER TABLE [dbo].[petugas] CHECK CONSTRAINT [FK_petugas_level]
GO
USE [master]
GO
ALTER DATABASE [db_UKK_NABILA] SET  READ_WRITE 
GO
