USE [master]
GO
/****** Object:  Database [DashPet]    Script Date: 15-Jul-22 11:32:23 PM ******/
CREATE DATABASE [DashPet]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DashPet', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DashPet.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DashPet_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DashPet_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DashPet] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DashPet].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DashPet] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DashPet] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DashPet] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DashPet] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DashPet] SET ARITHABORT OFF 
GO
ALTER DATABASE [DashPet] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DashPet] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DashPet] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DashPet] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DashPet] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DashPet] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DashPet] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DashPet] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DashPet] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DashPet] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DashPet] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DashPet] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DashPet] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DashPet] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DashPet] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DashPet] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DashPet] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DashPet] SET RECOVERY FULL 
GO
ALTER DATABASE [DashPet] SET  MULTI_USER 
GO
ALTER DATABASE [DashPet] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DashPet] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DashPet] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DashPet] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DashPet] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DashPet] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DashPet', N'ON'
GO
ALTER DATABASE [DashPet] SET QUERY_STORE = OFF
GO
USE [DashPet]
GO
/****** Object:  Table [dbo].[AnimalClass]    Script Date: 15-Jul-22 11:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnimalClass](
	[animalclass_id] [int] IDENTITY(1,1) NOT NULL,
	[animalclass_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_AnimalClass] PRIMARY KEY CLUSTERED 
(
	[animalclass_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnimalSpecies]    Script Date: 15-Jul-22 11:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnimalSpecies](
	[animalspecies_id] [int] IDENTITY(1,1) NOT NULL,
	[animalspecies_name] [varchar](50) NOT NULL,
	[animalspecies_animalclass_id] [int] NOT NULL,
 CONSTRAINT [PK_Species] PRIMARY KEY CLUSTERED 
(
	[animalspecies_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 15-Jul-22 11:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[appt_id] [int] IDENTITY(1,1) NOT NULL,
	[appt_pet_id] [int] NOT NULL,
	[appt_vet_id] [int] NOT NULL,
	[appt_date] [date] NOT NULL,
	[appt_timeslot_id] [int] NOT NULL,
	[appt_service_id] [int] NOT NULL,
	[appt_notes] [varchar](1000) NOT NULL,
	[appt_status] [bit] NOT NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[appt_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Owner]    Script Date: 15-Jul-22 11:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Owner](
	[owner_id] [int] IDENTITY(1,1) NOT NULL,
	[owner_name] [varchar](300) NOT NULL,
	[owner_doc] [varchar](20) NOT NULL,
	[owner_phone] [varchar](50) NOT NULL,
	[owner_address] [varchar](500) NOT NULL,
	[owner_email] [varchar](320) NOT NULL,
	[owner_status] [bit] NOT NULL,
	[owner_timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK_Owner] PRIMARY KEY CLUSTERED 
(
	[owner_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pet]    Script Date: 15-Jul-22 11:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pet](
	[pet_id] [int] IDENTITY(1,1) NOT NULL,
	[pet_owner_id] [int] NOT NULL,
	[pet_name] [varchar](100) NOT NULL,
	[pet_animalspecies_id] [int] NOT NULL,
	[pet_dob] [date] NOT NULL,
	[pet_weight] [varchar](10) NOT NULL,
	[pet_sex] [varchar](3) NOT NULL,
	[pet_notes] [varchar](1000) NOT NULL,
	[pet_status] [bit] NOT NULL,
	[pet_timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK_Pet] PRIMARY KEY CLUSTERED 
(
	[pet_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 15-Jul-22 11:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[room_id] [int] IDENTITY(1,1) NOT NULL,
	[room_name] [varchar](100) NOT NULL,
	[room_status] [bit] NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[room_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 15-Jul-22 11:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[service_id] [int] IDENTITY(1,1) NOT NULL,
	[service_name] [varchar](100) NOT NULL,
	[service_price] [varchar](10) NOT NULL,
	[service_status] [bit] NOT NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimeSlot]    Script Date: 15-Jul-22 11:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeSlot](
	[timeslot_id] [int] IDENTITY(1,1) NOT NULL,
	[timeslot_time] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TimeSlot] PRIMARY KEY CLUSTERED 
(
	[timeslot_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vet]    Script Date: 15-Jul-22 11:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vet](
	[vet_id] [int] IDENTITY(1,1) NOT NULL,
	[vet_name] [varchar](300) NOT NULL,
	[vet_doc] [varchar](20) NOT NULL,
	[vet_phone] [varchar](50) NOT NULL,
	[vet_email] [varchar](320) NOT NULL,
	[vet_room_id] [int] NULL,
	[vet_status] [bit] NOT NULL,
 CONSTRAINT [PK_Vet] PRIMARY KEY CLUSTERED 
(
	[vet_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AnimalClass] ON 

INSERT [dbo].[AnimalClass] ([animalclass_id], [animalclass_name]) VALUES (1, N'Mammals')
INSERT [dbo].[AnimalClass] ([animalclass_id], [animalclass_name]) VALUES (2, N'Birds')
INSERT [dbo].[AnimalClass] ([animalclass_id], [animalclass_name]) VALUES (3, N'Fish')
INSERT [dbo].[AnimalClass] ([animalclass_id], [animalclass_name]) VALUES (4, N'Reptiles')
INSERT [dbo].[AnimalClass] ([animalclass_id], [animalclass_name]) VALUES (5, N'Amphibians')
INSERT [dbo].[AnimalClass] ([animalclass_id], [animalclass_name]) VALUES (6, N'Invertbrates')
SET IDENTITY_INSERT [dbo].[AnimalClass] OFF
GO
SET IDENTITY_INSERT [dbo].[AnimalSpecies] ON 

INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (1, N'Dog', 1)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (2, N'Cat', 1)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (3, N'Goat', 1)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (4, N'Wolf', 1)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (5, N'Pig', 1)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (6, N'Horse', 1)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (7, N'Parrot', 2)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (8, N'Owl', 2)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (9, N'Blue Jay', 2)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (10, N'Chicken', 2)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (11, N'Humming Bird', 2)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (12, N'Goldfish', 3)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (13, N'Carp', 3)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (14, N'Swordfish', 3)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (15, N'Zebrafish', 3)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (16, N'Lizard', 4)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (17, N'Turtle', 4)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (18, N'Snake', 4)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (19, N'Chameleion', 4)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (20, N'Frog', 5)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (21, N'Salamander', 5)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (22, N'Axolotl', 5)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (23, N'Spider', 6)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (24, N'Worm', 6)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (25, N'Snail', 6)
INSERT [dbo].[AnimalSpecies] ([animalspecies_id], [animalspecies_name], [animalspecies_animalclass_id]) VALUES (26, N'Lobster', 6)
SET IDENTITY_INSERT [dbo].[AnimalSpecies] OFF
GO
SET IDENTITY_INSERT [dbo].[TimeSlot] ON 

INSERT [dbo].[TimeSlot] ([timeslot_id], [timeslot_time]) VALUES (0, N'09:00 - 09:30')
INSERT [dbo].[TimeSlot] ([timeslot_id], [timeslot_time]) VALUES (1, N'09:30 - 10:00')
INSERT [dbo].[TimeSlot] ([timeslot_id], [timeslot_time]) VALUES (2, N'10:00 - 10:30')
INSERT [dbo].[TimeSlot] ([timeslot_id], [timeslot_time]) VALUES (3, N'10:30 - 11:00')
INSERT [dbo].[TimeSlot] ([timeslot_id], [timeslot_time]) VALUES (4, N'11:00 - 11:30')
INSERT [dbo].[TimeSlot] ([timeslot_id], [timeslot_time]) VALUES (5, N'11:30 - 12:00')
INSERT [dbo].[TimeSlot] ([timeslot_id], [timeslot_time]) VALUES (6, N'12:30 - 13:00')
SET IDENTITY_INSERT [dbo].[TimeSlot] OFF
GO
ALTER TABLE [dbo].[Appointment] ADD  CONSTRAINT [DF_Appointment_appt_status]  DEFAULT ((1)) FOR [appt_status]
GO
ALTER TABLE [dbo].[Owner] ADD  CONSTRAINT [DF_Owner_owner_status]  DEFAULT ((1)) FOR [owner_status]
GO
ALTER TABLE [dbo].[Pet] ADD  CONSTRAINT [DF_Pet_pet_status]  DEFAULT ((1)) FOR [pet_status]
GO
ALTER TABLE [dbo].[Room] ADD  CONSTRAINT [DF_Room_room_status]  DEFAULT ((1)) FOR [room_status]
GO
ALTER TABLE [dbo].[Service] ADD  CONSTRAINT [DF_Service_service_status]  DEFAULT ((1)) FOR [service_status]
GO
ALTER TABLE [dbo].[Vet] ADD  CONSTRAINT [DF_Vet_vet_status]  DEFAULT ((1)) FOR [vet_status]
GO
ALTER TABLE [dbo].[AnimalSpecies]  WITH CHECK ADD  CONSTRAINT [FK_AnimalSpecies_AnimalClass] FOREIGN KEY([animalspecies_animalclass_id])
REFERENCES [dbo].[AnimalClass] ([animalclass_id])
GO
ALTER TABLE [dbo].[AnimalSpecies] CHECK CONSTRAINT [FK_AnimalSpecies_AnimalClass]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Pet] FOREIGN KEY([appt_pet_id])
REFERENCES [dbo].[Pet] ([pet_id])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Pet]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Service] FOREIGN KEY([appt_service_id])
REFERENCES [dbo].[Service] ([service_id])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Service]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_TimeSlot] FOREIGN KEY([appt_timeslot_id])
REFERENCES [dbo].[TimeSlot] ([timeslot_id])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_TimeSlot]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Vet] FOREIGN KEY([appt_vet_id])
REFERENCES [dbo].[Vet] ([vet_id])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Vet]
GO
ALTER TABLE [dbo].[Pet]  WITH CHECK ADD  CONSTRAINT [FK_Pet_AnimalSpecies] FOREIGN KEY([pet_animalspecies_id])
REFERENCES [dbo].[AnimalSpecies] ([animalspecies_id])
GO
ALTER TABLE [dbo].[Pet] CHECK CONSTRAINT [FK_Pet_AnimalSpecies]
GO
ALTER TABLE [dbo].[Pet]  WITH CHECK ADD  CONSTRAINT [FK_Pet_Owner] FOREIGN KEY([pet_owner_id])
REFERENCES [dbo].[Owner] ([owner_id])
GO
ALTER TABLE [dbo].[Pet] CHECK CONSTRAINT [FK_Pet_Owner]
GO
ALTER TABLE [dbo].[Vet]  WITH CHECK ADD  CONSTRAINT [FK_Vet_Room] FOREIGN KEY([vet_room_id])
REFERENCES [dbo].[Room] ([room_id])
GO
ALTER TABLE [dbo].[Vet] CHECK CONSTRAINT [FK_Vet_Room]
GO
USE [master]
GO
ALTER DATABASE [DashPet] SET  READ_WRITE 
GO
