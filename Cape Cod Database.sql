USE [master]
GO
/****** Object:  Database [Cape Cod]    Script Date: 5/7/2019 7:54:43 PM ******/
CREATE DATABASE [Cape Cod]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cape Cod', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Cape Cod.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Cape Cod_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Cape Cod_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Cape Cod] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cape Cod].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cape Cod] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Cape Cod] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Cape Cod] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Cape Cod] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Cape Cod] SET ARITHABORT OFF 
GO
ALTER DATABASE [Cape Cod] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Cape Cod] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Cape Cod] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Cape Cod] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Cape Cod] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Cape Cod] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Cape Cod] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Cape Cod] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Cape Cod] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Cape Cod] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Cape Cod] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Cape Cod] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Cape Cod] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Cape Cod] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Cape Cod] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Cape Cod] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Cape Cod] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Cape Cod] SET RECOVERY FULL 
GO
ALTER DATABASE [Cape Cod] SET  MULTI_USER 
GO
ALTER DATABASE [Cape Cod] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Cape Cod] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Cape Cod] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Cape Cod] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Cape Cod] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Cape Cod', N'ON'
GO
ALTER DATABASE [Cape Cod] SET QUERY_STORE = OFF
GO
USE [Cape Cod]
GO
/****** Object:  Table [dbo].[Beaches]    Script Date: 5/7/2019 7:54:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Beaches](
	[BeachName] [nvarchar](15) NOT NULL,
	[Location] [nvarchar](50) NULL,
 CONSTRAINT [PK_Beaches_1] PRIMARY KEY CLUSTERED 
(
	[BeachName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BoatInfo]    Script Date: 5/7/2019 7:54:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoatInfo](
	[BoatID] [int] NOT NULL,
	[Make] [nvarchar](50) NULL,
	[Model] [nvarchar](50) NULL,
	[Year] [nvarchar](50) NULL,
	[Color] [nvarchar](50) NULL,
 CONSTRAINT [PK_BoatInfo] PRIMARY KEY CLUSTERED 
(
	[BoatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BoatLicenses]    Script Date: 5/7/2019 7:54:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoatLicenses](
	[UserID] [int] NOT NULL,
	[BeachName] [nvarchar](15) NOT NULL,
	[BoatID] [int] NOT NULL,
	[BoatLicenseID] [int] NOT NULL,
 CONSTRAINT [PK_BoatLicenses] PRIMARY KEY CLUSTERED 
(
	[BoatLicenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BoatRegistrations]    Script Date: 5/7/2019 7:54:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoatRegistrations](
	[RegistrationNumber] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[BoatID] [int] NULL,
 CONSTRAINT [PK_BoatRegistrations] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[RegistrationNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FishingLicenses]    Script Date: 5/7/2019 7:54:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FishingLicenses](
	[FishingLicenseID] [int] NOT NULL,
	[UserID] [int] NULL,
	[BeachName] [nvarchar](15) NULL,
 CONSTRAINT [PK_FishingLicenses] PRIMARY KEY CLUSTERED 
(
	[FishingLicenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParkingPermits]    Script Date: 5/7/2019 7:54:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParkingPermits](
	[ParkingPermitID] [int] NOT NULL,
	[UserID] [int] NULL,
	[plateInfo] [nchar](10) NULL,
	[BeachName] [nvarchar](15) NULL,
 CONSTRAINT [PK_ParkingPermits] PRIMARY KEY CLUSTERED 
(
	[ParkingPermitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/7/2019 7:54:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] NOT NULL,
	[FName] [nvarchar](50) NULL,
	[LName] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Beaches] ([BeachName], [Location]) VALUES (N'Craigville', N'Centerville')
INSERT [dbo].[Beaches] ([BeachName], [Location]) VALUES (N'Keyes', N'Hyannis')
INSERT [dbo].[Beaches] ([BeachName], [Location]) VALUES (N'Sandy Neck', N'Barnstable')
INSERT [dbo].[Beaches] ([BeachName], [Location]) VALUES (N'Seagull', N'Hyannis')
INSERT [dbo].[Beaches] ([BeachName], [Location]) VALUES (N'Veterans', N'Hyannis')
INSERT [dbo].[BoatInfo] ([BoatID], [Make], [Model], [Year], [Color]) VALUES (1, N'Yahmaha', N'2.5hp', N'2010', N'Grey')
INSERT [dbo].[BoatInfo] ([BoatID], [Make], [Model], [Year], [Color]) VALUES (2, N'SeaCraft', N'10hp', N'2012', N'Red')
INSERT [dbo].[BoatInfo] ([BoatID], [Make], [Model], [Year], [Color]) VALUES (3, N'Boston Whaler', N'5hp', N'1999', N'Tan')
INSERT [dbo].[BoatInfo] ([BoatID], [Make], [Model], [Year], [Color]) VALUES (4, N'Suzuki', N'12hp', N'2006', N'Blue')
INSERT [dbo].[BoatInfo] ([BoatID], [Make], [Model], [Year], [Color]) VALUES (5, N'Lund', N'5hp', N'2010', N'White')
INSERT [dbo].[BoatInfo] ([BoatID], [Make], [Model], [Year], [Color]) VALUES (6, N'Yahmaha', N'3hp', N'2012', N'Black')
INSERT [dbo].[BoatInfo] ([BoatID], [Make], [Model], [Year], [Color]) VALUES (7, N'Boston Whaler', N'2.5hp', N'2008', N'Grey')
INSERT [dbo].[BoatInfo] ([BoatID], [Make], [Model], [Year], [Color]) VALUES (8, N'SeaCraft', N'5hp', N'2002', N'Tan')
INSERT [dbo].[BoatInfo] ([BoatID], [Make], [Model], [Year], [Color]) VALUES (9, N'Suzuki', N'10hp', N'2010', N'White')
INSERT [dbo].[BoatInfo] ([BoatID], [Make], [Model], [Year], [Color]) VALUES (10, N'Lund', N'10hp', N'2006', N'White')
INSERT [dbo].[BoatInfo] ([BoatID], [Make], [Model], [Year], [Color]) VALUES (11, N'Test', N'Test', N'2006', N'Test')
INSERT [dbo].[BoatLicenses] ([UserID], [BeachName], [BoatID], [BoatLicenseID]) VALUES (1, N'Veterans', 1, 1)
INSERT [dbo].[BoatLicenses] ([UserID], [BeachName], [BoatID], [BoatLicenseID]) VALUES (2, N'Keyes', 10, 2)
INSERT [dbo].[BoatLicenses] ([UserID], [BeachName], [BoatID], [BoatLicenseID]) VALUES (3, N'Veterans', 6, 3)
INSERT [dbo].[BoatLicenses] ([UserID], [BeachName], [BoatID], [BoatLicenseID]) VALUES (4, N'Sandy Neck', 4, 4)
INSERT [dbo].[BoatLicenses] ([UserID], [BeachName], [BoatID], [BoatLicenseID]) VALUES (6, N'Seagull', 9, 5)
INSERT [dbo].[BoatLicenses] ([UserID], [BeachName], [BoatID], [BoatLicenseID]) VALUES (7, N'Seagull', 3, 6)
INSERT [dbo].[BoatLicenses] ([UserID], [BeachName], [BoatID], [BoatLicenseID]) VALUES (8, N'Keyes', 2, 7)
INSERT [dbo].[BoatLicenses] ([UserID], [BeachName], [BoatID], [BoatLicenseID]) VALUES (9, N'Veterans', 5, 8)
INSERT [dbo].[BoatLicenses] ([UserID], [BeachName], [BoatID], [BoatLicenseID]) VALUES (10, N'Keyes', 8, 9)
INSERT [dbo].[BoatLicenses] ([UserID], [BeachName], [BoatID], [BoatLicenseID]) VALUES (4, N'Veterans', 7, 10)
INSERT [dbo].[BoatLicenses] ([UserID], [BeachName], [BoatID], [BoatLicenseID]) VALUES (1, N'Craigville', 4, 11)
INSERT [dbo].[BoatRegistrations] ([RegistrationNumber], [UserID], [BoatID]) VALUES (1, 1, 4)
INSERT [dbo].[BoatRegistrations] ([RegistrationNumber], [UserID], [BoatID]) VALUES (9, 2, 2)
INSERT [dbo].[BoatRegistrations] ([RegistrationNumber], [UserID], [BoatID]) VALUES (2, 3, 5)
INSERT [dbo].[BoatRegistrations] ([RegistrationNumber], [UserID], [BoatID]) VALUES (3, 4, 6)
INSERT [dbo].[BoatRegistrations] ([RegistrationNumber], [UserID], [BoatID]) VALUES (11, 4, 7)
INSERT [dbo].[BoatRegistrations] ([RegistrationNumber], [UserID], [BoatID]) VALUES (6, 5, 10)
INSERT [dbo].[BoatRegistrations] ([RegistrationNumber], [UserID], [BoatID]) VALUES (7, 6, 9)
INSERT [dbo].[BoatRegistrations] ([RegistrationNumber], [UserID], [BoatID]) VALUES (10, 7, 3)
INSERT [dbo].[BoatRegistrations] ([RegistrationNumber], [UserID], [BoatID]) VALUES (4, 8, 7)
INSERT [dbo].[BoatRegistrations] ([RegistrationNumber], [UserID], [BoatID]) VALUES (8, 9, 1)
INSERT [dbo].[BoatRegistrations] ([RegistrationNumber], [UserID], [BoatID]) VALUES (5, 10, 8)
INSERT [dbo].[FishingLicenses] ([FishingLicenseID], [UserID], [BeachName]) VALUES (1, 10, N'Keyes')
INSERT [dbo].[FishingLicenses] ([FishingLicenseID], [UserID], [BeachName]) VALUES (2, 9, N'Veterans')
INSERT [dbo].[FishingLicenses] ([FishingLicenseID], [UserID], [BeachName]) VALUES (3, 8, N'Keyes')
INSERT [dbo].[FishingLicenses] ([FishingLicenseID], [UserID], [BeachName]) VALUES (4, 7, N'Seagull')
INSERT [dbo].[FishingLicenses] ([FishingLicenseID], [UserID], [BeachName]) VALUES (5, 6, N'Seagull')
INSERT [dbo].[FishingLicenses] ([FishingLicenseID], [UserID], [BeachName]) VALUES (6, 5, N'Sandy Neck')
INSERT [dbo].[FishingLicenses] ([FishingLicenseID], [UserID], [BeachName]) VALUES (7, 4, N'Veterans')
INSERT [dbo].[FishingLicenses] ([FishingLicenseID], [UserID], [BeachName]) VALUES (8, 3, N'Keyes')
INSERT [dbo].[FishingLicenses] ([FishingLicenseID], [UserID], [BeachName]) VALUES (9, 2, N'Veterans')
INSERT [dbo].[ParkingPermits] ([ParkingPermitID], [UserID], [plateInfo], [BeachName]) VALUES (1, 8, N'FG5DRA    ', N'Seagull')
INSERT [dbo].[ParkingPermits] ([ParkingPermitID], [UserID], [plateInfo], [BeachName]) VALUES (2, 4, N'6S12CB    ', N'Veterans')
INSERT [dbo].[ParkingPermits] ([ParkingPermitID], [UserID], [plateInfo], [BeachName]) VALUES (3, 7, N'5XQ67B    ', N'Craigville')
INSERT [dbo].[ParkingPermits] ([ParkingPermitID], [UserID], [plateInfo], [BeachName]) VALUES (4, 8, N'QW8SC6    ', N'Sandy Neck')
INSERT [dbo].[ParkingPermits] ([ParkingPermitID], [UserID], [plateInfo], [BeachName]) VALUES (5, 9, N'6U5X4S    ', N'Keyes')
INSERT [dbo].[ParkingPermits] ([ParkingPermitID], [UserID], [plateInfo], [BeachName]) VALUES (6, 10, N'6A9L8E    ', N'Veterans')
INSERT [dbo].[ParkingPermits] ([ParkingPermitID], [UserID], [plateInfo], [BeachName]) VALUES (7, 1, N'4G8C7H    ', N'Sandy Neck')
INSERT [dbo].[ParkingPermits] ([ParkingPermitID], [UserID], [plateInfo], [BeachName]) VALUES (8, 2, N'65C8D4    ', N'Craigville')
INSERT [dbo].[ParkingPermits] ([ParkingPermitID], [UserID], [plateInfo], [BeachName]) VALUES (9, 3, N'SO94BR    ', N'Seagull')
INSERT [dbo].[ParkingPermits] ([ParkingPermitID], [UserID], [plateInfo], [BeachName]) VALUES (10, 2, N'HJ994G    ', N'Sandy Neck')
INSERT [dbo].[ParkingPermits] ([ParkingPermitID], [UserID], [plateInfo], [BeachName]) VALUES (11, 8, N'FG5DRA    ', N'Seagull')
INSERT [dbo].[ParkingPermits] ([ParkingPermitID], [UserID], [plateInfo], [BeachName]) VALUES (12, 4, N'asdfg     ', N'Veterans')
INSERT [dbo].[ParkingPermits] ([ParkingPermitID], [UserID], [plateInfo], [BeachName]) VALUES (13, 5, N'QWERT     ', N'Veterans')
INSERT [dbo].[ParkingPermits] ([ParkingPermitID], [UserID], [plateInfo], [BeachName]) VALUES (14, 4, N'BNMKL     ', N'Veterans')
INSERT [dbo].[ParkingPermits] ([ParkingPermitID], [UserID], [plateInfo], [BeachName]) VALUES (15, 7, N'GYUJMK    ', N'Sandy Neck')
INSERT [dbo].[ParkingPermits] ([ParkingPermitID], [UserID], [plateInfo], [BeachName]) VALUES (16, 11, N'88Y5A     ', N'Craigville')
INSERT [dbo].[Users] ([UserID], [FName], [LName], [Address], [Phone]) VALUES (1, N'Dave', N'Marks', N'123 First St', N'555-546-1234')
INSERT [dbo].[Users] ([UserID], [FName], [LName], [Address], [Phone]) VALUES (2, N'Fred', N'Lang', N'452 Brent Ave', N'555-645-4132')
INSERT [dbo].[Users] ([UserID], [FName], [LName], [Address], [Phone]) VALUES (3, N'Matt', N'Wheeler', N'745 Moore Rd', N'555-432-7645')
INSERT [dbo].[Users] ([UserID], [FName], [LName], [Address], [Phone]) VALUES (4, N'Kelly', N'Jones', N'946 Blueberry Cir', N'555-342-6452')
INSERT [dbo].[Users] ([UserID], [FName], [LName], [Address], [Phone]) VALUES (5, N'Billy', N'Karr', N'87 Meetinghouse St', N'555-932-7831')
INSERT [dbo].[Users] ([UserID], [FName], [LName], [Address], [Phone]) VALUES (6, N'Sean', N'Nauk', N'55 Straight Way', N'555-675-8862')
INSERT [dbo].[Users] ([UserID], [FName], [LName], [Address], [Phone]) VALUES (7, N'Marge', N'Loy', N'32 Pleasent Rd', N'555-764-4463')
INSERT [dbo].[Users] ([UserID], [FName], [LName], [Address], [Phone]) VALUES (8, N'Willy', N'Stevens', N'99 Technical St', N'454-356-2246')
INSERT [dbo].[Users] ([UserID], [FName], [LName], [Address], [Phone]) VALUES (9, N'Karen', N'Loydes', N'45 Green Ave', N'555-456-6412')
INSERT [dbo].[Users] ([UserID], [FName], [LName], [Address], [Phone]) VALUES (10, N'Jeff', N'Hyde', N'64 Simmons St', N'555-789-4865')
INSERT [dbo].[Users] ([UserID], [FName], [LName], [Address], [Phone]) VALUES (11, N'Peter', N'Cahill', N'83 Knotty Pine Ln', N'555-867-5309')
ALTER TABLE [dbo].[BoatLicenses]  WITH CHECK ADD  CONSTRAINT [FK_BoatLicenses_Beaches] FOREIGN KEY([BeachName])
REFERENCES [dbo].[Beaches] ([BeachName])
GO
ALTER TABLE [dbo].[BoatLicenses] CHECK CONSTRAINT [FK_BoatLicenses_Beaches]
GO
ALTER TABLE [dbo].[BoatLicenses]  WITH CHECK ADD  CONSTRAINT [FK_BoatLicenses_BoatInfo] FOREIGN KEY([BoatID])
REFERENCES [dbo].[BoatInfo] ([BoatID])
GO
ALTER TABLE [dbo].[BoatLicenses] CHECK CONSTRAINT [FK_BoatLicenses_BoatInfo]
GO
ALTER TABLE [dbo].[BoatRegistrations]  WITH CHECK ADD  CONSTRAINT [FK_BoatRegistrations_BoatInfo] FOREIGN KEY([BoatID])
REFERENCES [dbo].[BoatInfo] ([BoatID])
GO
ALTER TABLE [dbo].[BoatRegistrations] CHECK CONSTRAINT [FK_BoatRegistrations_BoatInfo]
GO
ALTER TABLE [dbo].[BoatRegistrations]  WITH CHECK ADD  CONSTRAINT [FK_BoatRegistrations_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[BoatRegistrations] CHECK CONSTRAINT [FK_BoatRegistrations_Users]
GO
ALTER TABLE [dbo].[FishingLicenses]  WITH CHECK ADD  CONSTRAINT [FK_FishingLicenses_Beaches] FOREIGN KEY([BeachName])
REFERENCES [dbo].[Beaches] ([BeachName])
GO
ALTER TABLE [dbo].[FishingLicenses] CHECK CONSTRAINT [FK_FishingLicenses_Beaches]
GO
ALTER TABLE [dbo].[FishingLicenses]  WITH CHECK ADD  CONSTRAINT [FK_FishingLicenses_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[FishingLicenses] CHECK CONSTRAINT [FK_FishingLicenses_Users]
GO
ALTER TABLE [dbo].[ParkingPermits]  WITH CHECK ADD  CONSTRAINT [FK_ParkingPermits_Beaches] FOREIGN KEY([BeachName])
REFERENCES [dbo].[Beaches] ([BeachName])
GO
ALTER TABLE [dbo].[ParkingPermits] CHECK CONSTRAINT [FK_ParkingPermits_Beaches]
GO
ALTER TABLE [dbo].[ParkingPermits]  WITH NOCHECK ADD  CONSTRAINT [FK_ParkingPermits_ParkingPermits] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[ParkingPermits] NOCHECK CONSTRAINT [FK_ParkingPermits_ParkingPermits]
GO
USE [master]
GO
ALTER DATABASE [Cape Cod] SET  READ_WRITE 
GO
