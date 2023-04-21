USE [master]
GO
/****** Object:  Database [TouristAgency]    Script Date: 20.04.2023 15:06:26 ******/
CREATE DATABASE [TouristAgency]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TouristAgency', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\TouristAgency.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TouristAgency_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\TouristAgency_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TouristAgency] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TouristAgency].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TouristAgency] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TouristAgency] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TouristAgency] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TouristAgency] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TouristAgency] SET ARITHABORT OFF 
GO
ALTER DATABASE [TouristAgency] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TouristAgency] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TouristAgency] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TouristAgency] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TouristAgency] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TouristAgency] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TouristAgency] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TouristAgency] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TouristAgency] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TouristAgency] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TouristAgency] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TouristAgency] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TouristAgency] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TouristAgency] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TouristAgency] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TouristAgency] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TouristAgency] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TouristAgency] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TouristAgency] SET  MULTI_USER 
GO
ALTER DATABASE [TouristAgency] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TouristAgency] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TouristAgency] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TouristAgency] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TouristAgency] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TouristAgency] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TouristAgency] SET QUERY_STORE = ON
GO
ALTER DATABASE [TouristAgency] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TouristAgency]
GO
/****** Object:  Default [def]    Script Date: 20.04.2023 15:06:26 ******/
CREATE DEFAULT [dbo].[def] 
AS
0
GO
/****** Object:  Table [dbo].[Клиенты]    Script Date: 20.04.2023 15:06:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Клиенты](
	[КодКлиента] [int] NOT NULL,
	[Фамилия] [varchar](25) NULL,
	[Имя] [varchar](25) NULL,
	[Отчество] [varchar](25) NULL,
	[Адрес] [varchar](255) NULL,
	[Телефон] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[КодКлиента] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Маршруты]    Script Date: 20.04.2023 15:06:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Маршруты](
	[КодМаршрута] [int] NOT NULL,
	[Страна] [varchar](25) NULL,
	[Климат] [varchar](25) NULL,
	[Длительность] [int] NULL,
	[Отель] [varchar](25) NULL,
	[Стоимость] [int] NULL,
	[Количество_по_Умолчанию] [int] NOT NULL,
	[default1] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[КодМаршрута] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Путевки]    Script Date: 20.04.2023 15:06:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Путевки](
	[КодПутевки] [int] NOT NULL,
	[КодМаршрута] [int] NULL,
	[КодКлиента] [int] NULL,
	[ДатаОтправления] [date] NULL,
	[Количество] [int] NULL,
	[Скидка] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[КодПутевки] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [uni] UNIQUE NONCLUSTERED 
(
	[КодМаршрута] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [uni1] UNIQUE NONCLUSTERED 
(
	[КодМаршрута] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Маршруты] ADD  DEFAULT ((0)) FOR [Количество_по_Умолчанию]
GO
ALTER TABLE [dbo].[Маршруты] ADD  DEFAULT ((0)) FOR [default1]
GO
ALTER TABLE [dbo].[Маршруты]  WITH CHECK ADD  CONSTRAINT [check1] CHECK  (([Стоимость]>(10000)))
GO
ALTER TABLE [dbo].[Маршруты] CHECK CONSTRAINT [check1]
GO
ALTER TABLE [dbo].[Маршруты]  WITH CHECK ADD  CONSTRAINT [name_1] CHECK  (([Стоимость]>(10000)))
GO
ALTER TABLE [dbo].[Маршруты] CHECK CONSTRAINT [name_1]
GO
ALTER TABLE [dbo].[Маршруты]  WITH CHECK ADD  CONSTRAINT [name_2] CHECK  (([Стоимость]>(10000)))
GO
ALTER TABLE [dbo].[Маршруты] CHECK CONSTRAINT [name_2]
GO
/****** Object:  StoredProcedure [dbo].[Клиент_Указанный_Маршрут]    Script Date: 20.04.2023 15:06:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Клиент_Указанный_Маршрут]
	-- Add the parameters for the stored procedure here
	@Marchrute int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Фамилия, Имя, Отчество, ДатаОтправления, Страна, Климат, Отель
	FROM Путевки JOIN Клиенты  ON Клиенты.КодКлиента = Путевки.КодКлиента  
	JOIN Маршруты ON Маршруты.КодМаршрута = Путевки.КодМаршрута
	WHERE Путевки.КодМаршрута = @Marchrute;
END
GO
/****** Object:  StoredProcedure [dbo].[Кол_во_Маршрута]    Script Date: 20.04.2023 15:06:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Кол_во_Маршрута]
	-- Add the parameters for the stored procedure here
	@Marchrute int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT КодМаршрута, Количество
	FROM Путевки 
	WHERE КодМаршрута = @Marchrute;
END
GO
/****** Object:  StoredProcedure [dbo].[Маршрут_Указанная_Страна]    Script Date: 20.04.2023 15:06:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Маршрут_Указанная_Страна]
	-- Add the parameters for the stored procedure here
	@COUNTRY varchar(100) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM Маршруты
	WHERE Страна = @COUNTRY;
END
GO
/****** Object:  StoredProcedure [dbo].[Путевка_Указанная_Дата]    Script Date: 20.04.2023 15:06:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Путевка_Указанная_Дата]
	-- Add the parameters for the stored procedure here
	@DATA date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM Путевки
	WHERE ДатаОтправления = @DATA;
END
GO
/****** Object:  StoredProcedure [dbo].[Самый_Длинный_Маршрут]    Script Date: 20.04.2023 15:06:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Самый_Длинный_Маршрут]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM Маршруты 
	WHERE Длительность = (SELECT MAX(Длительность)
							FROM Маршруты)
END
GO
USE [master]
GO
ALTER DATABASE [TouristAgency] SET  READ_WRITE 
GO
