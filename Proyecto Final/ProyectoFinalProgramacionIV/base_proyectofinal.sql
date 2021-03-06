USE [master]
GO
/****** Object:  Database [final]    Script Date: 23/4/2019 10:32:38 p. m. ******/
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
USE [final]
GO
/****** Object:  Table [dbo].[excel]    Script Date: 23/4/2019 10:32:39 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[FiltrarNuevos]    Script Date: 23/4/2019 10:32:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FiltrarNuevos] @fecha_inicio datetime, @fecha_final datetime, @modulo nvarchar(50) As 
SELECT * FROM excel 
WHERE  Fecha_Creacion >= @fecha_inicio and Fecha_Creacion <= @fecha_final and modulo = @modulo
GO
/****** Object:  StoredProcedure [dbo].[FiltrarPendientes]    Script Date: 23/4/2019 10:32:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FiltrarPendientes] @fecha_inicio datetime, @fecha_final datetime, @modulo nvarchar(50)  As 
SELECT * FROM excel 
WHERE  Fecha_Creacion >= @fecha_inicio and Fecha_Creacion <= @fecha_final and Estado = 'Pendiente' and modulo = @modulo
GO
/****** Object:  StoredProcedure [dbo].[FiltroIncidentesResueltos]    Script Date: 23/4/2019 10:32:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FiltroIncidentesResueltos] @fecha_inicio datetime, @fecha_final datetime, @modulo nvarchar(50) As 
select DISTINCT  Estado,
        sum(case when Prioridad_Real = 'Emergencia' then 1 else 0 end) Emergencia,
        sum(case when Prioridad_Real = 'Alta' then 1 else 0 end) Alta,
        sum(case when Prioridad_Real = 'Media' then 1 else 0 end) Media,
        sum(case when Prioridad_Real = 'Baja' then 1 else 0 end) Baja
        from excel
		WHERE  Fecha_Resul >= @fecha_inicio and Fecha_Resul <= @fecha_final and modulo like @modulo
		group by Estado

GO
/****** Object:  StoredProcedure [dbo].[FiltroRetrasados]    Script Date: 23/4/2019 10:32:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FiltroRetrasados] @fecha_inicio datetime2, @fecha_final datetime2, @modulo nvarchar(50)  As 
SELECT * FROM excel 
WHERE  Fecha_Creacion >= @fecha_inicio and Fecha_Creacion <= @fecha_final and Estado = 'Retrasado' and modulo = @modulo
GO
/****** Object:  StoredProcedure [dbo].[FiltrosResumenModuloAfectados]    Script Date: 23/4/2019 10:32:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FiltrosResumenModuloAfectados] @fecha_inicio datetime2, @fecha_final datetime2, @modulo nvarchar(50)  As
SELECT @modulo as modulo, 
	   SUM(CASE WHEN Prioridad_Real = 'Emergencia' THEN 1 ELSE 0 END) as EMERGENCIA,
       SUM(CASE WHEN Prioridad_Real = 'Alta' THEN 1 ELSE 0 END) as ALTA,
       SUM(CASE WHEN Prioridad_Real = 'Media' THEN 1 ELSE 0 END) as MEDIA,
       SUM(CASE WHEN Prioridad_Real = 'Baja' THEN 1 ELSE 0 END) as BAJA
FROM   excel WHERE  Fecha_Resul >= @fecha_inicio and Fecha_Resul <= @fecha_final and modulo like @modulo
group by modulo
GO
/****** Object:  StoredProcedure [dbo].[LastRow]    Script Date: 23/4/2019 10:32:40 p. m. ******/
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
