USE [master]
GO
/****** Object:  Database [final]    Script Date: 20.4.2019 3:34:03 a. m. ******/
CREATE DATABASE [final]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'final', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\final.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'final_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\final_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [final] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [final].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [final] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [final] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [final] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [final] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [final] SET ARITHABORT OFF 
GO
ALTER DATABASE [final] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [final] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [final] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [final] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [final] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [final] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [final] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [final] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [final] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [final] SET  DISABLE_BROKER 
GO
ALTER DATABASE [final] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [final] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [final] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [final] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [final] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [final] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [final] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [final] SET RECOVERY FULL 
GO
ALTER DATABASE [final] SET  MULTI_USER 
GO
ALTER DATABASE [final] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [final] SET DB_CHAINING OFF 
GO
ALTER DATABASE [final] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [final] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [final] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'final', N'ON'
GO
ALTER DATABASE [final] SET QUERY_STORE = OFF
GO
USE [final]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [final]
GO
/****** Object:  Table [dbo].[excel]    Script Date: 20.4.2019 3:34:03 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[excel](
	[No_Incidente] [nvarchar](50) NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[Fecha_Creacion] [datetime2](7) NOT NULL,
	[Prioridad] [nvarchar](50) NOT NULL,
	[Prioridad_Real] [nvarchar](50) NULL,
	[Horas] [int] NULL,
	[Fecha_Est] [datetime2](7) NULL,
	[Fecha_Asigna] [datetime2](7) NULL,
	[Fecha_Resul] [datetime2](7) NULL,
	[Estado] [nvarchar](50) NULL,
	[modulo] [nvarchar](50) NULL,
 CONSTRAINT [PK_excel] PRIMARY KEY CLUSTERED 
(
	[No_Incidente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[LastRow]    Script Date: 20.4.2019 3:34:03 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Carlos
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[LastRow] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select top 1 No_Incidente from excel excel order by No_Incidente desc
END
GO
USE [master]
GO
ALTER DATABASE [final] SET  READ_WRITE 
GO
