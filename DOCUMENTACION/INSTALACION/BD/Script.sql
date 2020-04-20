USE [master]
GO
/****** Object:  Database [db_hotel]    Script Date: 20/04/2020 16:22:20 ******/
CREATE DATABASE [db_hotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_hotel', FILENAME = N'C:\DB\db_hotel\db_hotel.mdf' , SIZE = 3072000KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'db_hotel_log', FILENAME = N'C:\DB\db_hotel\db_hotel_log.ldf' , SIZE = 3072000KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_hotel] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_hotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_hotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_hotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_hotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_hotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_hotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_hotel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_hotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_hotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_hotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_hotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_hotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_hotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_hotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_hotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_hotel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_hotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_hotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_hotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_hotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_hotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_hotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_hotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_hotel] SET RECOVERY FULL 
GO
ALTER DATABASE [db_hotel] SET  MULTI_USER 
GO
ALTER DATABASE [db_hotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_hotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_hotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_hotel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_hotel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_hotel] SET QUERY_STORE = OFF
GO
USE [db_hotel]
GO
/****** Object:  User [SistHot]    Script Date: 20/04/2020 16:22:20 ******/
CREATE USER [SistHot] FOR LOGIN [SistHot] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[alojamiento]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alojamiento](
	[id_alojamiento] [int] NOT NULL,
	[id_reserv_alojamiento] [int] NOT NULL,
	[ing_por_alojamiento] [char](10) NOT NULL,
	[fecha_i_alojamiento] [datetime] NOT NULL,
	[sal_por_alojamiento] [char](10) NOT NULL,
	[fecha_s_alojamiento] [datetime] NOT NULL,
	[estado_alojamiento] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_alojamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[alojamiento_det]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alojamiento_det](
	[id_alojamiento_det] [int] NOT NULL,
	[id_hab_det] [char](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_alojamiento_det] ASC,
	[id_hab_det] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[archivo]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[archivo](
	[id_archivo] [int] NOT NULL,
	[id_tarchivo] [int] NOT NULL,
	[ruta_archivo] [varchar](500) NOT NULL,
	[comentario_01_archivo] [varchar](2000) NOT NULL,
	[comentario_02_archivo] [varchar](2000) NOT NULL,
	[estado_archivo] [char](1) NOT NULL,
	[CREADO_P_archivo] [char](10) NOT NULL,
	[FECHA_C_archivo] [datetime] NOT NULL,
	[MOD_P_archivo] [char](10) NOT NULL,
	[FECHA_M_archivo] [datetime] NOT NULL,
 CONSTRAINT [PK__archivo__9B696443C6693C15] PRIMARY KEY CLUSTERED 
(
	[id_archivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cama]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cama](
	[id_cama] [char](5) NOT NULL,
	[descr_cama] [varchar](50) NOT NULL,
	[capacidad_cama] [int] NOT NULL,
	[estado_cama] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cama] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cancelacion]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cancelacion](
	[id_cancelacion] [int] NOT NULL,
	[id_reserv_cancelacion] [int] NOT NULL,
	[fecha_cancelacion] [datetime] NOT NULL,
	[motivo_cancelacion] [varchar](max) NOT NULL,
	[id_archivo_cancelacion] [varchar](10) NOT NULL,
	[creado_por_cancelacion] [char](10) NOT NULL,
	[estado_cancelacion] [char](1) NOT NULL,
	[mod_por_cancelacion] [char](10) NOT NULL,
	[fecha_mod_cancelacion] [datetime] NOT NULL,
 CONSTRAINT [PK__cancelac__D14FA595A606A21E] PRIMARY KEY CLUSTERED 
(
	[id_cancelacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[caracteristica]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[caracteristica](
	[id_caracteristica] [char](5) NOT NULL,
	[descr_caracteristica] [varchar](100) NOT NULL,
	[estado_caracteristica] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_caracteristica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[ID_CLIENTE] [char](5) NOT NULL,
	[ID_TERCERO_CLIENTE] [char](10) NOT NULL,
	[ID_T_CLIENTE] [char](5) NOT NULL,
	[LIM_CRED_CLIENTE] [decimal](12, 2) NOT NULL,
	[ESTADO_CLIENTE] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_CLIENTE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIRECCION]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIRECCION](
	[id_Tercero_Direccion] [char](10) NOT NULL,
	[id_mun_Direccion] [char](5) NOT NULL,
	[Direccion] [varchar](max) NOT NULL,
	[TIPO_DIRECCION] [varchar](2) NOT NULL,
	[N_LINEA_DIRECCION] [int] NOT NULL,
	[ESTADO_DIRECCION] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Tercero_Direccion] ASC,
	[TIPO_DIRECCION] ASC,
	[N_LINEA_DIRECCION] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[edificio]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[edificio](
	[id_edificio] [char](5) NOT NULL,
	[descr_edificio] [varchar](100) NOT NULL,
	[cant_nivel_edificio] [int] NOT NULL,
	[estado_edificio] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_edificio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMAIL]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMAIL](
	[id_Tercero_Email] [char](10) NOT NULL,
	[Email] [varchar](max) NOT NULL,
	[TIPO_Email] [varchar](2) NOT NULL,
	[N_LINEA_Email] [int] NOT NULL,
	[ESTADO_Email] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Tercero_Email] ASC,
	[N_LINEA_Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLEADO]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLEADO](
	[ID_EMPLEADO] [char](5) NOT NULL,
	[ID_TERCERO_EMPLEADO] [char](10) NOT NULL,
	[ID_T_EMPLEADO] [char](5) NOT NULL,
	[FECHA_I_EMPLEADO] [date] NOT NULL,
	[ESTADO_EMPLEADO] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_EMPLEADO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[habitacion]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[habitacion](
	[id_habitacion] [char](5) NOT NULL,
	[descr_habitacion] [varchar](100) NOT NULL,
	[t_habitacion] [char](5) NOT NULL,
	[edificio_habitacion] [char](5) NOT NULL,
	[piso_habitacion] [int] NOT NULL,
	[estado_habitacion] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_habitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOTEL]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOTEL](
	[id_hotel] [char](5) NOT NULL,
	[descr_hotel] [varchar](300) NOT NULL,
	[Direccion_hotel] [varchar](max) NOT NULL,
	[tel_hotel] [varchar](12) NOT NULL,
	[a_cancelacion_hotel] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_hotel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mantenimiento]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mantenimiento](
	[id_mantenimiento] [int] NOT NULL,
	[id_hab_mantenimiento] [char](5) NOT NULL,
	[fecha_cre_mantenimiento] [datetime] NOT NULL,
	[fecha_mod_mantenimiento] [datetime] NOT NULL,
	[estado_mantenimiento] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_mantenimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mantenimiento_det]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mantenimiento_det](
	[id_mantenimiento_det] [int] NOT NULL,
	[id_t_mant_det] [char](5) NOT NULL,
	[id_empleado_det] [char](5) NOT NULL,
	[estado_mantenimiento] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_mantenimiento_det] ASC,
	[id_t_mant_det] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MUNICIPIO]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MUNICIPIO](
	[id_municipio] [char](5) NOT NULL,
	[descr_municipio] [varchar](50) NOT NULL,
	[id_prov_municipio] [char](5) NOT NULL,
	[estado_municipio] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_municipio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NOTA_CREDITO_ABONO]    Script Date: 20/04/2020 16:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NOTA_CREDITO_ABONO](
	[ID_NCC_AB] [int] NOT NULL,
	[ID_RESERV_NCC_AB] [int] NOT NULL,
	[N_ABONO_NCC_AB] [int] NOT NULL,
	[FECHA_ABONO_NCC_AB] [datetime] NOT NULL,
	[BALANCE_ANT_NCC_AB] [decimal](12, 2) NOT NULL,
	[ABONO_NCC_AB] [decimal](12, 2) NOT NULL,
	[BALANCE_ACT_NCC_AB] [decimal](12, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_NCC_AB] ASC,
	[ID_RESERV_NCC_AB] ASC,
	[N_ABONO_NCC_AB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NOTA_CREDITO_CLIENTE]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NOTA_CREDITO_CLIENTE](
	[ID_NCC] [int] NOT NULL,
	[ID_CLIENTE_NCC] [char](5) NOT NULL,
	[MONTO_NCC] [decimal](12, 2) NOT NULL,
	[FECHA_NCC] [date] NOT NULL,
	[ESTADO_NCC] [char](1) NOT NULL,
	[CREADO_P_NCC] [char](10) NOT NULL,
	[FECHA_C_NCC] [datetime] NOT NULL,
	[MOD_P_NCC] [char](10) NOT NULL,
	[FECHA_M_NCC] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_NCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NOTA_CREDITO_DETALLE]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NOTA_CREDITO_DETALLE](
	[ID_NCC_DET] [int] NOT NULL,
	[ID_RESERV_NCC_DET] [int] NOT NULL,
	[VALOR_NCC_DET] [decimal](12, 2) NOT NULL,
	[BALANCE_NCC_DET] [decimal](12, 2) NOT NULL,
	[FECHA_NCC_DET] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_NCC_DET] ASC,
	[ID_RESERV_NCC_DET] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oferta]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oferta](
	[id_oferta] [char](5) NOT NULL,
	[descr_oferta] [varchar](200) NOT NULL,
	[id_temp_oferta] [char](5) NOT NULL,
	[estado_oferta] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_oferta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oferta_det_01]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oferta_det_01](
	[id_oferta_det01] [char](5) NOT NULL,
	[id_t_aloj_det01] [char](5) NOT NULL,
	[descuento_det01] [decimal](12, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_oferta_det01] ASC,
	[id_t_aloj_det01] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oferta_det_02]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oferta_det_02](
	[id_oferta_det02] [char](5) NOT NULL,
	[id_t_cliente_det02] [char](5) NOT NULL,
	[descuento_det02] [decimal](12, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_oferta_det02] ASC,
	[id_t_cliente_det02] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oferta_det_03]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oferta_det_03](
	[id_oferta_det03] [char](5) NOT NULL,
	[c_ini_aloj_det03] [int] NOT NULL,
	[c_fin_aloj_det03] [int] NOT NULL,
	[descuento_det03] [decimal](12, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_oferta_det03] ASC,
	[c_ini_aloj_det03] ASC,
	[c_fin_aloj_det03] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PAIS]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAIS](
	[id_pais] [char](5) NOT NULL,
	[descr_pais] [varchar](50) NOT NULL,
	[estado_pais] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos_Adi]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos_Adi](
	[id_opcion] [char](5) NOT NULL,
	[Descr_opcion] [varchar](30) NOT NULL,
	[Estado_Opcion] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_opcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVINCIA]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVINCIA](
	[id_provincia] [char](5) NOT NULL,
	[descr_provincia] [varchar](50) NOT NULL,
	[id_pais_provincia] [char](5) NOT NULL,
	[estado_provincia] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reservacion]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservacion](
	[id_reservacion] [int] NOT NULL,
	[id_cliente] [char](5) NOT NULL,
	[id_t_aloj_reservacion] [char](5) NOT NULL,
	[fecha_lleg_reservacion] [datetime] NOT NULL,
	[fecha_sal_reservacion] [datetime] NOT NULL,
	[Monto_apagar] [decimal](12, 2) NOT NULL,
	[estado_reservacion] [char](1) NOT NULL,
	[creado_por_reservacion] [char](10) NOT NULL,
	[fecha_cre_reservacion] [datetime] NOT NULL,
	[mod_por_reservacion] [char](10) NOT NULL,
	[fecha_mod_reservacion] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_reservacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reservacion_det]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservacion_det](
	[id_reservacion_det] [int] NOT NULL,
	[id_thab_reserv_det] [char](5) NOT NULL,
	[cant_reserv_det] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_reservacion_det] ASC,
	[id_thab_reserv_det] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rp_cliente]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rp_cliente](
	[ID_CLIENTE] [char](5) NOT NULL,
	[Nombre_Tercero] [varchar](100) NOT NULL,
	[ESTADO_CLIENTE] [char](1) NOT NULL,
	[ID_T_CLIENTE] [char](5) NOT NULL,
	[LIM_CRED_CLIENTE] [decimal](12, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_CLIENTE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rp_empleado]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rp_empleado](
	[ID_empleado] [char](5) NOT NULL,
	[Nombre_Tercero] [varchar](100) NOT NULL,
	[ESTADO_empleado] [char](1) NOT NULL,
	[ID_T_empleado] [char](5) NOT NULL,
	[FECHA_I_EMPLEADO] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rp_Mantenimiento]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rp_Mantenimiento](
	[id_mantenimiento] [int] NOT NULL,
	[id_hab_mantenimiento] [char](5) NOT NULL,
	[descr_habitacion] [varchar](100) NOT NULL,
	[fecha_cre_mantenimiento] [datetime] NOT NULL,
	[estado_mantenimiento] [char](1) NOT NULL,
	[id_mantenimiento_det] [int] NOT NULL,
	[id_t_mant_det] [char](5) NOT NULL,
	[descr_t_mantenimiento] [varchar](100) NOT NULL,
	[id_empleado_det] [char](5) NOT NULL,
	[Nombre_Tercero] [varchar](100) NOT NULL,
	[estado_mantenimiento_det] [char](1) NOT NULL,
	[usuario_crea] [char](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rp_usuario]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rp_usuario](
	[id_Usuario] [char](10) NOT NULL,
	[Nombre_Tercero] [varchar](100) NOT NULL,
	[Estado_Usuario] [char](1) NOT NULL,
	[Tipo_Usuario] [char](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[servicio]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicio](
	[id_servicio] [char](5) NOT NULL,
	[descr_servicio] [varchar](50) NOT NULL,
	[costo_servicio] [decimal](12, 2) NOT NULL,
	[estado_servicio] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[talojamiento_servicio]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[talojamiento_servicio](
	[id_t_alojamiento_tas] [char](5) NOT NULL,
	[id_servicio_tas] [char](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_t_alojamiento_tas] ASC,
	[id_servicio_tas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TELEFONO]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TELEFONO](
	[id_Tercero_Tel] [char](10) NOT NULL,
	[Numero_Tel] [varchar](20) NOT NULL,
	[TIPO_Tel] [varchar](2) NOT NULL,
	[N_LINEA_Tel] [int] NOT NULL,
	[ESTADO_Tel] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Tercero_Tel] ASC,
	[Numero_Tel] ASC,
	[N_LINEA_Tel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TEMPORADA]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TEMPORADA](
	[id_temporada] [char](5) NOT NULL,
	[descr_temporada] [varchar](100) NOT NULL,
	[fecha_i_temporada] [date] NOT NULL,
	[fecha_f_temporada] [date] NOT NULL,
	[estado_temporada] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_temporada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tercero]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tercero](
	[id_Tercero] [char](10) NOT NULL,
	[Nombre_Tercero] [varchar](100) NOT NULL,
	[ID_T_Identif_Tercero] [char](5) NOT NULL,
	[Cedula_Tercero] [varchar](20) NOT NULL,
	[Fecha_Nac_Tercero] [date] NOT NULL,
	[Sexo_Tercero] [char](1) NOT NULL,
	[Estado_Tercero] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Tercero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thab_caracteristica]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thab_caracteristica](
	[id_t_hab_thcar] [char](5) NOT NULL,
	[id_caracteristica_thcar] [char](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_t_hab_thcar] ASC,
	[id_caracteristica_thcar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thabitacion_cama]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thabitacion_cama](
	[id_t_hab_thc] [char](5) NOT NULL,
	[id_cama_thc] [char](5) NOT NULL,
	[Cantidad_camas] [int] NOT NULL,
 CONSTRAINT [PK__thabitac__9306A31580BF1AD8] PRIMARY KEY CLUSTERED 
(
	[id_t_hab_thc] ASC,
	[id_cama_thc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_alojamiento]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_alojamiento](
	[id_t_alojamiento] [char](5) NOT NULL,
	[descr_t_alojamiento] [varchar](100) NOT NULL,
	[costo_t_alojamiento] [decimal](12, 2) NOT NULL,
	[estado_t_alojamiento] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_t_alojamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_archivo]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_archivo](
	[id_t_archivo] [int] NOT NULL,
	[descr_t_archivo] [varchar](100) NOT NULL,
	[estado_t_archivo] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_t_archivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_CLIENTE]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_CLIENTE](
	[ID_T_CLIENTE_TC] [char](5) NOT NULL,
	[DESCR_TC] [varchar](50) NOT NULL,
	[ESTADO_TC] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_T_CLIENTE_TC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_EMPLEADO]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_EMPLEADO](
	[ID_T_EMPLEADO_TE] [char](5) NOT NULL,
	[DESCR_TE] [varchar](50) NOT NULL,
	[ESTADO_TE] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_T_EMPLEADO_TE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_habitacion]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_habitacion](
	[id_t_hab] [char](5) NOT NULL,
	[descr_t_hab] [varchar](50) NOT NULL,
	[capacidad_hab] [int] NOT NULL,
	[costo_hab] [decimal](12, 2) NOT NULL,
	[estado_t_hab] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_t_hab] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Identificacion]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Identificacion](
	[Id_Tipo_Ident] [char](5) NOT NULL,
	[Descr_Tipo_Ident] [varchar](30) NOT NULL,
	[Estado_Tipo_Ident] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Tipo_Ident] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_mantenimiento]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_mantenimiento](
	[id_t_mantenimiento] [char](5) NOT NULL,
	[descr_t_mantenimiento] [varchar](100) NOT NULL,
	[estado_t_mantenimiento] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_t_mantenimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Usuario]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Usuario](
	[id_T_Usuario] [char](5) NOT NULL,
	[Descripcion_T_Usuario] [varchar](30) NOT NULL,
	[Nivel_Acceso_T_Usuario] [varchar](3) NOT NULL,
	[Estado_T_Usuario] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_T_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_Usuario] [char](10) NOT NULL,
	[id_Tercero_Usuario] [char](10) NOT NULL,
	[Tipo_Usuario] [char](5) NOT NULL,
	[password_Usuario] [varchar](max) NOT NULL,
	[Estado_Usuario] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario_Permisos_Adi]    Script Date: 20/04/2020 16:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Permisos_Adi](
	[id_Usuario_UP] [char](10) NOT NULL,
	[id_Permiso_UP] [char](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Usuario_UP] ASC,
	[id_Permiso_UP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cancelacion] ADD  CONSTRAINT [DF_cancelacion_id_archivo_cancelacion]  DEFAULT ('') FOR [id_archivo_cancelacion]
GO
ALTER TABLE [dbo].[alojamiento]  WITH CHECK ADD  CONSTRAINT [FK_reserv_aloj] FOREIGN KEY([id_reserv_alojamiento])
REFERENCES [dbo].[reservacion] ([id_reservacion])
GO
ALTER TABLE [dbo].[alojamiento] CHECK CONSTRAINT [FK_reserv_aloj]
GO
ALTER TABLE [dbo].[alojamiento_det]  WITH CHECK ADD  CONSTRAINT [FK_aloj_det] FOREIGN KEY([id_alojamiento_det])
REFERENCES [dbo].[alojamiento] ([id_alojamiento])
GO
ALTER TABLE [dbo].[alojamiento_det] CHECK CONSTRAINT [FK_aloj_det]
GO
ALTER TABLE [dbo].[alojamiento_det]  WITH CHECK ADD  CONSTRAINT [FK_hab_aloj_det] FOREIGN KEY([id_hab_det])
REFERENCES [dbo].[habitacion] ([id_habitacion])
GO
ALTER TABLE [dbo].[alojamiento_det] CHECK CONSTRAINT [FK_hab_aloj_det]
GO
ALTER TABLE [dbo].[archivo]  WITH CHECK ADD  CONSTRAINT [FK_tipo_archivo] FOREIGN KEY([id_tarchivo])
REFERENCES [dbo].[tipo_archivo] ([id_t_archivo])
GO
ALTER TABLE [dbo].[archivo] CHECK CONSTRAINT [FK_tipo_archivo]
GO
ALTER TABLE [dbo].[cancelacion]  WITH CHECK ADD  CONSTRAINT [FK_reserv_canc] FOREIGN KEY([id_reserv_cancelacion])
REFERENCES [dbo].[reservacion] ([id_reservacion])
GO
ALTER TABLE [dbo].[cancelacion] CHECK CONSTRAINT [FK_reserv_canc]
GO
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [FK_T_CLIENTE_TC] FOREIGN KEY([ID_T_CLIENTE])
REFERENCES [dbo].[TIPO_CLIENTE] ([ID_T_CLIENTE_TC])
GO
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [FK_T_CLIENTE_TC]
GO
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [FK_Tercero_CLIENTE] FOREIGN KEY([ID_TERCERO_CLIENTE])
REFERENCES [dbo].[Tercero] ([id_Tercero])
GO
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [FK_Tercero_CLIENTE]
GO
ALTER TABLE [dbo].[DIRECCION]  WITH CHECK ADD  CONSTRAINT [FK_MUNICIPIO_Direccion] FOREIGN KEY([id_mun_Direccion])
REFERENCES [dbo].[MUNICIPIO] ([id_municipio])
GO
ALTER TABLE [dbo].[DIRECCION] CHECK CONSTRAINT [FK_MUNICIPIO_Direccion]
GO
ALTER TABLE [dbo].[DIRECCION]  WITH CHECK ADD  CONSTRAINT [FK_Tercero_Direccion] FOREIGN KEY([id_Tercero_Direccion])
REFERENCES [dbo].[Tercero] ([id_Tercero])
GO
ALTER TABLE [dbo].[DIRECCION] CHECK CONSTRAINT [FK_Tercero_Direccion]
GO
ALTER TABLE [dbo].[EMAIL]  WITH CHECK ADD  CONSTRAINT [FK_Tercero_Email] FOREIGN KEY([id_Tercero_Email])
REFERENCES [dbo].[Tercero] ([id_Tercero])
GO
ALTER TABLE [dbo].[EMAIL] CHECK CONSTRAINT [FK_Tercero_Email]
GO
ALTER TABLE [dbo].[EMPLEADO]  WITH CHECK ADD  CONSTRAINT [FK_T_EMPLEADO_TE] FOREIGN KEY([ID_T_EMPLEADO])
REFERENCES [dbo].[TIPO_EMPLEADO] ([ID_T_EMPLEADO_TE])
GO
ALTER TABLE [dbo].[EMPLEADO] CHECK CONSTRAINT [FK_T_EMPLEADO_TE]
GO
ALTER TABLE [dbo].[EMPLEADO]  WITH CHECK ADD  CONSTRAINT [FK_Tercero_EMPLEADO] FOREIGN KEY([ID_TERCERO_EMPLEADO])
REFERENCES [dbo].[Tercero] ([id_Tercero])
GO
ALTER TABLE [dbo].[EMPLEADO] CHECK CONSTRAINT [FK_Tercero_EMPLEADO]
GO
ALTER TABLE [dbo].[habitacion]  WITH CHECK ADD  CONSTRAINT [FK_edificio_hab] FOREIGN KEY([edificio_habitacion])
REFERENCES [dbo].[edificio] ([id_edificio])
GO
ALTER TABLE [dbo].[habitacion] CHECK CONSTRAINT [FK_edificio_hab]
GO
ALTER TABLE [dbo].[habitacion]  WITH CHECK ADD  CONSTRAINT [FK_thabitacion_hab] FOREIGN KEY([t_habitacion])
REFERENCES [dbo].[tipo_habitacion] ([id_t_hab])
GO
ALTER TABLE [dbo].[habitacion] CHECK CONSTRAINT [FK_thabitacion_hab]
GO
ALTER TABLE [dbo].[mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_habitacion_mant] FOREIGN KEY([id_hab_mantenimiento])
REFERENCES [dbo].[habitacion] ([id_habitacion])
GO
ALTER TABLE [dbo].[mantenimiento] CHECK CONSTRAINT [FK_habitacion_mant]
GO
ALTER TABLE [dbo].[mantenimiento_det]  WITH CHECK ADD  CONSTRAINT [FK_EMPLEADO_mant_det] FOREIGN KEY([id_empleado_det])
REFERENCES [dbo].[EMPLEADO] ([ID_EMPLEADO])
GO
ALTER TABLE [dbo].[mantenimiento_det] CHECK CONSTRAINT [FK_EMPLEADO_mant_det]
GO
ALTER TABLE [dbo].[mantenimiento_det]  WITH CHECK ADD  CONSTRAINT [FK_mant_det] FOREIGN KEY([id_mantenimiento_det])
REFERENCES [dbo].[mantenimiento] ([id_mantenimiento])
GO
ALTER TABLE [dbo].[mantenimiento_det] CHECK CONSTRAINT [FK_mant_det]
GO
ALTER TABLE [dbo].[mantenimiento_det]  WITH CHECK ADD  CONSTRAINT [FK_tipo_mant_det] FOREIGN KEY([id_t_mant_det])
REFERENCES [dbo].[tipo_mantenimiento] ([id_t_mantenimiento])
GO
ALTER TABLE [dbo].[mantenimiento_det] CHECK CONSTRAINT [FK_tipo_mant_det]
GO
ALTER TABLE [dbo].[MUNICIPIO]  WITH CHECK ADD  CONSTRAINT [FK_MUNICIPIO_PROV] FOREIGN KEY([id_prov_municipio])
REFERENCES [dbo].[PROVINCIA] ([id_provincia])
GO
ALTER TABLE [dbo].[MUNICIPIO] CHECK CONSTRAINT [FK_MUNICIPIO_PROV]
GO
ALTER TABLE [dbo].[NOTA_CREDITO_ABONO]  WITH CHECK ADD  CONSTRAINT [FK_RESERV_NCC_AB] FOREIGN KEY([ID_RESERV_NCC_AB])
REFERENCES [dbo].[reservacion] ([id_reservacion])
GO
ALTER TABLE [dbo].[NOTA_CREDITO_ABONO] CHECK CONSTRAINT [FK_RESERV_NCC_AB]
GO
ALTER TABLE [dbo].[NOTA_CREDITO_CLIENTE]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTE_NCC] FOREIGN KEY([ID_CLIENTE_NCC])
REFERENCES [dbo].[CLIENTE] ([ID_CLIENTE])
GO
ALTER TABLE [dbo].[NOTA_CREDITO_CLIENTE] CHECK CONSTRAINT [FK_CLIENTE_NCC]
GO
ALTER TABLE [dbo].[NOTA_CREDITO_DETALLE]  WITH CHECK ADD  CONSTRAINT [FK_RESERV_NCC_DET] FOREIGN KEY([ID_RESERV_NCC_DET])
REFERENCES [dbo].[reservacion] ([id_reservacion])
GO
ALTER TABLE [dbo].[NOTA_CREDITO_DETALLE] CHECK CONSTRAINT [FK_RESERV_NCC_DET]
GO
ALTER TABLE [dbo].[Oferta]  WITH CHECK ADD  CONSTRAINT [FK_temporada_oferta] FOREIGN KEY([id_temp_oferta])
REFERENCES [dbo].[TEMPORADA] ([id_temporada])
GO
ALTER TABLE [dbo].[Oferta] CHECK CONSTRAINT [FK_temporada_oferta]
GO
ALTER TABLE [dbo].[oferta_det_01]  WITH CHECK ADD  CONSTRAINT [FK_oferta_d01] FOREIGN KEY([id_oferta_det01])
REFERENCES [dbo].[Oferta] ([id_oferta])
GO
ALTER TABLE [dbo].[oferta_det_01] CHECK CONSTRAINT [FK_oferta_d01]
GO
ALTER TABLE [dbo].[oferta_det_01]  WITH CHECK ADD  CONSTRAINT [FK_talojamiento_of_det01] FOREIGN KEY([id_t_aloj_det01])
REFERENCES [dbo].[tipo_alojamiento] ([id_t_alojamiento])
GO
ALTER TABLE [dbo].[oferta_det_01] CHECK CONSTRAINT [FK_talojamiento_of_det01]
GO
ALTER TABLE [dbo].[oferta_det_02]  WITH CHECK ADD  CONSTRAINT [FK_oferta_d02] FOREIGN KEY([id_oferta_det02])
REFERENCES [dbo].[Oferta] ([id_oferta])
GO
ALTER TABLE [dbo].[oferta_det_02] CHECK CONSTRAINT [FK_oferta_d02]
GO
ALTER TABLE [dbo].[oferta_det_02]  WITH CHECK ADD  CONSTRAINT [FK_t_cliente_det02] FOREIGN KEY([id_t_cliente_det02])
REFERENCES [dbo].[TIPO_CLIENTE] ([ID_T_CLIENTE_TC])
GO
ALTER TABLE [dbo].[oferta_det_02] CHECK CONSTRAINT [FK_t_cliente_det02]
GO
ALTER TABLE [dbo].[oferta_det_03]  WITH CHECK ADD  CONSTRAINT [FK_oferta_d03] FOREIGN KEY([id_oferta_det03])
REFERENCES [dbo].[Oferta] ([id_oferta])
GO
ALTER TABLE [dbo].[oferta_det_03] CHECK CONSTRAINT [FK_oferta_d03]
GO
ALTER TABLE [dbo].[PROVINCIA]  WITH CHECK ADD  CONSTRAINT [FK_PROVINCIA_PAIS] FOREIGN KEY([id_pais_provincia])
REFERENCES [dbo].[PAIS] ([id_pais])
GO
ALTER TABLE [dbo].[PROVINCIA] CHECK CONSTRAINT [FK_PROVINCIA_PAIS]
GO
ALTER TABLE [dbo].[reservacion]  WITH CHECK ADD  CONSTRAINT [FK_cliente_res] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[CLIENTE] ([ID_CLIENTE])
GO
ALTER TABLE [dbo].[reservacion] CHECK CONSTRAINT [FK_cliente_res]
GO
ALTER TABLE [dbo].[reservacion]  WITH CHECK ADD  CONSTRAINT [FK_talojamiento_res] FOREIGN KEY([id_t_aloj_reservacion])
REFERENCES [dbo].[tipo_alojamiento] ([id_t_alojamiento])
GO
ALTER TABLE [dbo].[reservacion] CHECK CONSTRAINT [FK_talojamiento_res]
GO
ALTER TABLE [dbo].[reservacion_det]  WITH CHECK ADD  CONSTRAINT [FK_reserv_det] FOREIGN KEY([id_reservacion_det])
REFERENCES [dbo].[reservacion] ([id_reservacion])
GO
ALTER TABLE [dbo].[reservacion_det] CHECK CONSTRAINT [FK_reserv_det]
GO
ALTER TABLE [dbo].[reservacion_det]  WITH CHECK ADD  CONSTRAINT [FK_thab_reserv_det] FOREIGN KEY([id_thab_reserv_det])
REFERENCES [dbo].[tipo_habitacion] ([id_t_hab])
GO
ALTER TABLE [dbo].[reservacion_det] CHECK CONSTRAINT [FK_thab_reserv_det]
GO
ALTER TABLE [dbo].[talojamiento_servicio]  WITH CHECK ADD  CONSTRAINT [FK_talojamiento_tas] FOREIGN KEY([id_t_alojamiento_tas])
REFERENCES [dbo].[tipo_alojamiento] ([id_t_alojamiento])
GO
ALTER TABLE [dbo].[talojamiento_servicio] CHECK CONSTRAINT [FK_talojamiento_tas]
GO
ALTER TABLE [dbo].[talojamiento_servicio]  WITH CHECK ADD  CONSTRAINT [FK_thabitacion_tas] FOREIGN KEY([id_servicio_tas])
REFERENCES [dbo].[servicio] ([id_servicio])
GO
ALTER TABLE [dbo].[talojamiento_servicio] CHECK CONSTRAINT [FK_thabitacion_tas]
GO
ALTER TABLE [dbo].[TELEFONO]  WITH CHECK ADD  CONSTRAINT [FK_Tercero_Tel] FOREIGN KEY([id_Tercero_Tel])
REFERENCES [dbo].[Tercero] ([id_Tercero])
GO
ALTER TABLE [dbo].[TELEFONO] CHECK CONSTRAINT [FK_Tercero_Tel]
GO
ALTER TABLE [dbo].[Tercero]  WITH CHECK ADD  CONSTRAINT [FK_Tercero_T_Identif] FOREIGN KEY([ID_T_Identif_Tercero])
REFERENCES [dbo].[Tipo_Identificacion] ([Id_Tipo_Ident])
GO
ALTER TABLE [dbo].[Tercero] CHECK CONSTRAINT [FK_Tercero_T_Identif]
GO
ALTER TABLE [dbo].[thab_caracteristica]  WITH CHECK ADD  CONSTRAINT [FK_talojamiento_thcar] FOREIGN KEY([id_caracteristica_thcar])
REFERENCES [dbo].[caracteristica] ([id_caracteristica])
GO
ALTER TABLE [dbo].[thab_caracteristica] CHECK CONSTRAINT [FK_talojamiento_thcar]
GO
ALTER TABLE [dbo].[thab_caracteristica]  WITH CHECK ADD  CONSTRAINT [FK_thabitacion_thcar] FOREIGN KEY([id_t_hab_thcar])
REFERENCES [dbo].[tipo_habitacion] ([id_t_hab])
GO
ALTER TABLE [dbo].[thab_caracteristica] CHECK CONSTRAINT [FK_thabitacion_thcar]
GO
ALTER TABLE [dbo].[thabitacion_cama]  WITH CHECK ADD  CONSTRAINT [FK_cama_thc] FOREIGN KEY([id_cama_thc])
REFERENCES [dbo].[cama] ([id_cama])
GO
ALTER TABLE [dbo].[thabitacion_cama] CHECK CONSTRAINT [FK_cama_thc]
GO
ALTER TABLE [dbo].[thabitacion_cama]  WITH CHECK ADD  CONSTRAINT [FK_thabitacion_thc] FOREIGN KEY([id_t_hab_thc])
REFERENCES [dbo].[tipo_habitacion] ([id_t_hab])
GO
ALTER TABLE [dbo].[thabitacion_cama] CHECK CONSTRAINT [FK_thabitacion_thc]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Tercero] FOREIGN KEY([id_Tercero_Usuario])
REFERENCES [dbo].[Tercero] ([id_Tercero])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Tercero]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Tipo_Usuario] FOREIGN KEY([Tipo_Usuario])
REFERENCES [dbo].[Tipo_Usuario] ([id_T_Usuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Tipo_Usuario]
GO
ALTER TABLE [dbo].[Usuario_Permisos_Adi]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_UP_Permiso] FOREIGN KEY([id_Permiso_UP])
REFERENCES [dbo].[Permisos_Adi] ([id_opcion])
GO
ALTER TABLE [dbo].[Usuario_Permisos_Adi] CHECK CONSTRAINT [FK_Permiso_UP_Permiso]
GO
ALTER TABLE [dbo].[Usuario_Permisos_Adi]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_UP_Usuario] FOREIGN KEY([id_Usuario_UP])
REFERENCES [dbo].[Usuario] ([id_Usuario])
GO
ALTER TABLE [dbo].[Usuario_Permisos_Adi] CHECK CONSTRAINT [FK_Usuario_UP_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[ACTALOJAMIENTO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTALOJAMIENTO]
       @II_ID_ALOJAMIENTO  INT,
       @II_ID_RESERV_ALOJAMIENTO  INT,
       @II_ING_POR_ALOJAMIENTO  CHAR(10),
       @II_FECHA_I_ALOJAMIENTO  DATETIME,
       @II_SAL_POR_ALOJAMIENTO  CHAR(10),
       @II_FECHA_S_ALOJAMIENTO  DATETIME,
       @II_ESTADO_ALOJAMIENTO  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into alojamiento values(	     @II_ID_ALOJAMIENTO,
	     @II_ID_RESERV_ALOJAMIENTO,
	     @II_ING_POR_ALOJAMIENTO,
	     GETDATE(),
	     @II_SAL_POR_ALOJAMIENTO,
	     GETDATE(),
	     @II_ESTADO_ALOJAMIENTO);
else
	update alojamiento set 	     ID_RESERV_ALOJAMIENTO=@II_ID_RESERV_ALOJAMIENTO,
	     ING_POR_ALOJAMIENTO=@II_ING_POR_ALOJAMIENTO,
	     FECHA_I_ALOJAMIENTO=GETDATE(),
	     SAL_POR_ALOJAMIENTO=@II_SAL_POR_ALOJAMIENTO,
	     FECHA_S_ALOJAMIENTO=GETDATE(),
	     ESTADO_ALOJAMIENTO=@II_ESTADO_ALOJAMIENTO
  where ID_ALOJAMIENTO=@II_ID_ALOJAMIENTO;
GO
/****** Object:  StoredProcedure [dbo].[ACTALOJAMIENTO_DET]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTALOJAMIENTO_DET]
       @II_ID_ALOJAMIENTO_DET  INT,
       @II_ID_HAB_DET  CHAR(5),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into alojamiento_det values(	     @II_ID_ALOJAMIENTO_DET,
	     @II_ID_HAB_DET);
else
	update alojamiento_det set 	     ID_HAB_DET=@II_ID_HAB_DET
  where ID_ALOJAMIENTO_DET=@II_ID_ALOJAMIENTO_DET;
GO
/****** Object:  StoredProcedure [dbo].[ACTARCHIVO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTARCHIVO]
       @II_ID_ARCHIVO  int,
       @II_ID_TARCHIVO  INT,
       @II_RUTA_ARCHIVO  VARCHAR(500),
       @II_COMENTARIO_01_ARCHIVO  VARCHAR(2000),
       @II_COMENTARIO_02_ARCHIVO  VARCHAR(2000),
       @II_ESTADO_ARCHIVO  CHAR(1),
       @II_CREADO_P_ARCHIVO  CHAR(10),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into archivo values(	     @II_ID_ARCHIVO,
	     @II_ID_TARCHIVO,
	     @II_RUTA_ARCHIVO,
	     @II_COMENTARIO_01_ARCHIVO,
	     @II_COMENTARIO_02_ARCHIVO,
	     @II_ESTADO_ARCHIVO,
	     @II_CREADO_P_ARCHIVO,
	     GETDATE(),
	     @II_CREADO_P_ARCHIVO,
	     GETDATE());
else
	update archivo set 	     ID_TARCHIVO=@II_ID_TARCHIVO,
	     RUTA_ARCHIVO=@II_RUTA_ARCHIVO,
	     COMENTARIO_01_ARCHIVO=@II_COMENTARIO_01_ARCHIVO,
	     COMENTARIO_02_ARCHIVO=@II_COMENTARIO_02_ARCHIVO,
	     ESTADO_ARCHIVO=@II_ESTADO_ARCHIVO,
	     MOD_P_ARCHIVO=@II_CREADO_P_ARCHIVO,
	     FECHA_M_ARCHIVO=GETDATE()
  where ID_ARCHIVO=@II_ID_ARCHIVO;
GO
/****** Object:  StoredProcedure [dbo].[ACTCAMA]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTCAMA]
       @II_ID_CAMA  CHAR(5),
       @II_DESCR_CAMA  VARCHAR(50),
       @II_CAPACIDAD_CAMA  INT,
       @II_ESTADO_CAMA  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into cama values(	     @II_ID_CAMA,
	     @II_DESCR_CAMA,
	     @II_CAPACIDAD_CAMA,
	     @II_ESTADO_CAMA);
else
	update cama set 	     DESCR_CAMA=@II_DESCR_CAMA,
	     CAPACIDAD_CAMA=@II_CAPACIDAD_CAMA,
	     ESTADO_CAMA=@II_ESTADO_CAMA
  where ID_CAMA=@II_ID_CAMA;
GO
/****** Object:  StoredProcedure [dbo].[ACTCANCELACION]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTCANCELACION]
       @II_ID_CANCELACION  INT,
       @II_ID_RESERV_CANCELACION  INT,
       @II_MOTIVO_CANCELACION  VARCHAR(MAX),
	   @II_archivo_Cancelacion  INT,
       @II_CREADO_POR_CANCELACION  CHAR(10),
       @II_ESTADO_CANCELACION  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
begin
	insert into cancelacion values(	     @II_ID_CANCELACION,
	     @II_ID_RESERV_CANCELACION,
	     GETDATE(),
	     @II_MOTIVO_CANCELACION,
		 @II_archivo_Cancelacion,
	     @II_CREADO_POR_CANCELACION,
	     @II_ESTADO_CANCELACION,
	     @II_CREADO_POR_CANCELACION,
	     GETDATE());
	update reservacion set estado_reservacion = 'C' where id_reservacion = @II_ID_RESERV_CANCELACION;
end
else
	update cancelacion set 	     ID_RESERV_CANCELACION=@II_ID_RESERV_CANCELACION,
	     FECHA_CANCELACION=GETDATE(),
	     MOTIVO_CANCELACION=@II_MOTIVO_CANCELACION,
		 id_archivo_cancelacion=@II_archivo_Cancelacion,
	     ESTADO_CANCELACION=@II_ESTADO_CANCELACION,
	     MOD_POR_CANCELACION=@II_CREADO_POR_CANCELACION,
	     FECHA_MOD_CANCELACION=GETDATE()
  where ID_CANCELACION=@II_ID_CANCELACION;
GO
/****** Object:  StoredProcedure [dbo].[ACTCARACTERISTICA]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTCARACTERISTICA]
       @II_ID_CARACTERISTICA  CHAR(5),
       @II_DESCR_CARACTERISTICA  VARCHAR(100),
       @II_ESTADO_CARACTERISTICA  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into caracteristica values(	     @II_ID_CARACTERISTICA,
	     @II_DESCR_CARACTERISTICA,
	     @II_ESTADO_CARACTERISTICA);
else
	update caracteristica set 	     DESCR_CARACTERISTICA=@II_DESCR_CARACTERISTICA,
	     ESTADO_CARACTERISTICA=@II_ESTADO_CARACTERISTICA
  where ID_CARACTERISTICA=@II_ID_CARACTERISTICA;
GO
/****** Object:  StoredProcedure [dbo].[ACTCLIENTE]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTCLIENTE]
       @II_ID_CLIENTE  CHAR(5),
       @II_ID_TERCERO_CLIENTE  CHAR(10),
       @II_ID_T_CLIENTE  CHAR(5),
       @II_LIM_CRED_CLIENTE  DECIMAL,
       @II_ESTADO_CLIENTE  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into CLIENTE values(	     @II_ID_CLIENTE,
	     @II_ID_TERCERO_CLIENTE,
	     @II_ID_T_CLIENTE,
	     @II_LIM_CRED_CLIENTE,
	     @II_ESTADO_CLIENTE);
else
	update CLIENTE set 	     ID_TERCERO_CLIENTE=@II_ID_TERCERO_CLIENTE,
	     ID_T_CLIENTE=@II_ID_T_CLIENTE,
	     LIM_CRED_CLIENTE=@II_LIM_CRED_CLIENTE,
	     ESTADO_CLIENTE=@II_ESTADO_CLIENTE
  where ID_CLIENTE=@II_ID_CLIENTE;
GO
/****** Object:  StoredProcedure [dbo].[ACTDIRECCION]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTDIRECCION]
       @II_ID_TERCERO_DIRECCION  CHAR(10),
       @II_ID_MUN_DIRECCION  CHAR(5),
       @II_DIRECCION  VARCHAR(max),
       @II_TIPO_DIRECCION  VARCHAR(2),
       @II_N_LINEA_DIRECCION  INT,
       @II_ESTADO_DIRECCION  CHAR(1)
AS
	insert into DIRECCION values(	     @II_ID_TERCERO_DIRECCION,
	     @II_ID_MUN_DIRECCION,
	     @II_DIRECCION,
	     @II_TIPO_DIRECCION,
	     @II_N_LINEA_DIRECCION,
	     @II_ESTADO_DIRECCION);

GO
/****** Object:  StoredProcedure [dbo].[ACTEDIFICIO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTEDIFICIO]
       @II_ID_EDIFICIO  CHAR(5),
       @II_DESCR_EDIFICIO  VARCHAR(100),
       @II_CANT_NIVEL_EDIFICIO  INT,
       @II_ESTADO_EDIFICIO  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into edificio values(	     @II_ID_EDIFICIO,
	     @II_DESCR_EDIFICIO,
	     @II_CANT_NIVEL_EDIFICIO,
	     @II_ESTADO_EDIFICIO);
else
	update edificio set 	     DESCR_EDIFICIO=@II_DESCR_EDIFICIO,
	     CANT_NIVEL_EDIFICIO=@II_CANT_NIVEL_EDIFICIO,
	     ESTADO_EDIFICIO=@II_ESTADO_EDIFICIO
  where ID_EDIFICIO=@II_ID_EDIFICIO;
GO
/****** Object:  StoredProcedure [dbo].[ACTEMAIL]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTEMAIL]
       @II_ID_TERCERO_EMAIL  CHAR(10),
       @II_EMAIL  VARCHAR(max),
       @II_TIPO_EMAIL  VARCHAR(2),
       @II_N_LINEA_EMAIL  INT,
       @II_ESTADO_EMAIL  CHAR(1)
AS
	insert into EMAIL values(	     @II_ID_TERCERO_EMAIL,
	     @II_EMAIL,
	     @II_TIPO_EMAIL,
	     @II_N_LINEA_EMAIL,
	     @II_ESTADO_EMAIL);

GO
/****** Object:  StoredProcedure [dbo].[ACTEMPLEADO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTEMPLEADO]
       @II_ID_EMPLEADO  CHAR(5),
       @II_ID_TERCERO_EMPLEADO  CHAR(10),
       @II_ID_T_EMPLEADO  CHAR(5),
       @II_FECHA_I_EMPLEADO  DATE,
       @II_ESTADO_EMPLEADO  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into EMPLEADO values(	     @II_ID_EMPLEADO,
	     @II_ID_TERCERO_EMPLEADO,
	     @II_ID_T_EMPLEADO,
	     @II_FECHA_I_EMPLEADO,
	     @II_ESTADO_EMPLEADO);
else
	update EMPLEADO set 	     ID_TERCERO_EMPLEADO=@II_ID_TERCERO_EMPLEADO,
	     ID_T_EMPLEADO=@II_ID_T_EMPLEADO,
	     FECHA_I_EMPLEADO=@II_FECHA_I_EMPLEADO,
	     ESTADO_EMPLEADO=@II_ESTADO_EMPLEADO
  where ID_EMPLEADO=@II_ID_EMPLEADO;
GO
/****** Object:  StoredProcedure [dbo].[ACTHABITACION]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTHABITACION]
       @II_ID_HABITACION  CHAR(5),
       @II_DESCR_HABITACION  VARCHAR(100),
       @II_T_HABITACION  CHAR(5),
       @II_EDIFICIO_HABITACION  CHAR(5),
       @II_PISO_HABITACION  INT,
       @II_ESTADO_HABITACION  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into habitacion values(	     @II_ID_HABITACION,
	     @II_DESCR_HABITACION,
	     @II_T_HABITACION,
	     @II_EDIFICIO_HABITACION,
	     @II_PISO_HABITACION,
	     @II_ESTADO_HABITACION);
else
	update habitacion set 	     DESCR_HABITACION=@II_DESCR_HABITACION,
	     T_HABITACION=@II_T_HABITACION,
	     EDIFICIO_HABITACION=@II_EDIFICIO_HABITACION,
	     PISO_HABITACION=@II_PISO_HABITACION,
	     ESTADO_HABITACION=@II_ESTADO_HABITACION
  where ID_HABITACION=@II_ID_HABITACION;
GO
/****** Object:  StoredProcedure [dbo].[ACTHOTEL]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTHOTEL]
       @II_ID_HOTEL  CHAR(5),
       @II_DESCR_HOTEL  VARCHAR(300),
       @II_DIRECCION_HOTEL  VARCHAR(max),
       @II_TEL_HOTEL  VARCHAR(12),
       @II_A_CANCELACION_HOTEL  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into HOTEL values(	     @II_ID_HOTEL,
	     @II_DESCR_HOTEL,
	     @II_DIRECCION_HOTEL,
	     @II_TEL_HOTEL,
	     @II_A_CANCELACION_HOTEL);
else
	update HOTEL set 	     DESCR_HOTEL=@II_DESCR_HOTEL,
	     DIRECCION_HOTEL=@II_DIRECCION_HOTEL,
	     TEL_HOTEL=@II_TEL_HOTEL,
	     A_CANCELACION_HOTEL=@II_A_CANCELACION_HOTEL
  where ID_HOTEL=@II_ID_HOTEL;
GO
/****** Object:  StoredProcedure [dbo].[ACTMANTENIMIENTO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTMANTENIMIENTO]
       @II_ID_MANTENIMIENTO  INT,
       @II_ID_HAB_MANTENIMIENTO  CHAR(5),
       @II_FECHA_CRE_MANTENIMIENTO  DATETIME,
       @II_FECHA_MOD_MANTENIMIENTO  DATETIME,
       @II_ESTADO_MANTENIMIENTO  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into mantenimiento values(	     @II_ID_MANTENIMIENTO,
	     @II_ID_HAB_MANTENIMIENTO,
	     GETDATE(),
	     GETDATE(),
	     @II_ESTADO_MANTENIMIENTO);
else
	update mantenimiento set 	     ID_HAB_MANTENIMIENTO=@II_ID_HAB_MANTENIMIENTO,
	     FECHA_CRE_MANTENIMIENTO=GETDATE(),
	     FECHA_MOD_MANTENIMIENTO=GETDATE(),
	     ESTADO_MANTENIMIENTO=@II_ESTADO_MANTENIMIENTO
  where ID_MANTENIMIENTO=@II_ID_MANTENIMIENTO;
GO
/****** Object:  StoredProcedure [dbo].[ACTMANTENIMIENTO_DET]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTMANTENIMIENTO_DET]
       @II_ID_MANTENIMIENTO_DET  INT,
       @II_ID_T_MANT_DET  CHAR(5),
       @II_ID_EMPLEADO_DET  CHAR(5),
       @II_ESTADO_MANTENIMIENTO  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into mantenimiento_det values(	     @II_ID_MANTENIMIENTO_DET,
	     @II_ID_T_MANT_DET,
	     @II_ID_EMPLEADO_DET,
	     @II_ESTADO_MANTENIMIENTO);
else
	update mantenimiento_det set 	     ID_T_MANT_DET=@II_ID_T_MANT_DET,
	     ID_EMPLEADO_DET=@II_ID_EMPLEADO_DET,
	     ESTADO_MANTENIMIENTO=@II_ESTADO_MANTENIMIENTO
  where ID_MANTENIMIENTO_DET=@II_ID_MANTENIMIENTO_DET;
GO
/****** Object:  StoredProcedure [dbo].[ACTMUNICIPIO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTMUNICIPIO]
       @II_ID_MUNICIPIO  CHAR(5),
       @II_DESCR_MUNICIPIO  VARCHAR(50),
       @II_ID_PROV_MUNICIPIO  CHAR(5),
       @II_ESTADO_MUNICIPIO  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into MUNICIPIO values(	     @II_ID_MUNICIPIO,
	     @II_DESCR_MUNICIPIO,
	     @II_ID_PROV_MUNICIPIO,
	     @II_ESTADO_MUNICIPIO);
else
	update MUNICIPIO set 	     DESCR_MUNICIPIO=@II_DESCR_MUNICIPIO,
	     ID_PROV_MUNICIPIO=@II_ID_PROV_MUNICIPIO,
	     ESTADO_MUNICIPIO=@II_ESTADO_MUNICIPIO
  where ID_MUNICIPIO=@II_ID_MUNICIPIO;
GO
/****** Object:  StoredProcedure [dbo].[ACTNOTA_CREDITO_ABONO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTNOTA_CREDITO_ABONO]
       @II_ID_NCC_AB  INT,
       @II_ID_RESERV_NCC_AB  INT,
       @II_N_ABONO_NCC_AB  INT,
       @II_FECHA_ABONO_NCC_AB  DATETIME,
       @II_BALANCE_ANT_NCC_AB  DECIMAL,
       @II_ABONO_NCC_AB  DECIMAL,
       @II_BALANCE_ACT_NCC_AB  DECIMAL,
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into NOTA_CREDITO_ABONO values(	     @II_ID_NCC_AB,
	     @II_ID_RESERV_NCC_AB,
	     @II_N_ABONO_NCC_AB,
	     GETDATE(),
	     @II_BALANCE_ANT_NCC_AB,
	     @II_ABONO_NCC_AB,
	     @II_BALANCE_ACT_NCC_AB);
else
	update NOTA_CREDITO_ABONO set 	     ID_RESERV_NCC_AB=@II_ID_RESERV_NCC_AB,
	     N_ABONO_NCC_AB=@II_N_ABONO_NCC_AB,
	     FECHA_ABONO_NCC_AB=GETDATE(),
	     BALANCE_ANT_NCC_AB=@II_BALANCE_ANT_NCC_AB,
	     ABONO_NCC_AB=@II_ABONO_NCC_AB,
	     BALANCE_ACT_NCC_AB=@II_BALANCE_ACT_NCC_AB
  where ID_NCC_AB=@II_ID_NCC_AB;
GO
/****** Object:  StoredProcedure [dbo].[ACTNOTA_CREDITO_CLIENTE]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTNOTA_CREDITO_CLIENTE]
       @II_ID_NCC  INT,
       @II_ID_CLIENTE_NCC  CHAR(5),
       @II_MONTO_NCC  DECIMAL,
       @II_FECHA_NCC  DATE,
       @II_ESTADO_NCC  CHAR(1),
       @II_CREADO_P_NCC  CHAR(10),
       @II_FECHA_C_NCC  DATETIME,
       @II_MOD_P_NCC  CHAR(10),
       @II_FECHA_M_NCC  DATETIME,
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into NOTA_CREDITO_CLIENTE values(	     @II_ID_NCC,
	     @II_ID_CLIENTE_NCC,
	     @II_MONTO_NCC,
	     @II_FECHA_NCC,
	     @II_ESTADO_NCC,
	     @II_CREADO_P_NCC,
	     GETDATE(),
	     @II_MOD_P_NCC,
	     GETDATE());
else
	update NOTA_CREDITO_CLIENTE set 	     ID_CLIENTE_NCC=@II_ID_CLIENTE_NCC,
	     MONTO_NCC=@II_MONTO_NCC,
	     FECHA_NCC=@II_FECHA_NCC,
	     ESTADO_NCC=@II_ESTADO_NCC,
	     CREADO_P_NCC=@II_CREADO_P_NCC,
	     FECHA_C_NCC=GETDATE(),
	     MOD_P_NCC=@II_MOD_P_NCC,
	     FECHA_M_NCC=GETDATE()
  where ID_NCC=@II_ID_NCC;
GO
/****** Object:  StoredProcedure [dbo].[ACTNOTA_CREDITO_DETALLE]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTNOTA_CREDITO_DETALLE]
       @II_ID_NCC_DET  INT,
       @II_ID_RESERV_NCC_DET  INT,
       @II_VALOR_NCC_DET  DECIMAL,
       @II_BALANCE_NCC_DET  DECIMAL,
       @II_FECHA_NCC_DET  DATETIME,
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into NOTA_CREDITO_DETALLE values(	     @II_ID_NCC_DET,
	     @II_ID_RESERV_NCC_DET,
	     @II_VALOR_NCC_DET,
	     @II_BALANCE_NCC_DET,
	     GETDATE());
else
	update NOTA_CREDITO_DETALLE set 	     ID_RESERV_NCC_DET=@II_ID_RESERV_NCC_DET,
	     VALOR_NCC_DET=@II_VALOR_NCC_DET,
	     BALANCE_NCC_DET=@II_BALANCE_NCC_DET,
	     FECHA_NCC_DET=GETDATE()
  where ID_NCC_DET=@II_ID_NCC_DET;
GO
/****** Object:  StoredProcedure [dbo].[ACTOFERTA]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTOFERTA]
       @II_ID_OFERTA  CHAR(5),
       @II_DESCR_OFERTA  VARCHAR(200),
       @II_ID_TEMP_OFERTA  CHAR(5),
       @II_ESTADO_OFERTA  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into Oferta values(	     @II_ID_OFERTA,
	     @II_DESCR_OFERTA,
	     @II_ID_TEMP_OFERTA,
	     @II_ESTADO_OFERTA);
else
	update Oferta set 	     DESCR_OFERTA=@II_DESCR_OFERTA,
	     ID_TEMP_OFERTA=@II_ID_TEMP_OFERTA,
	     ESTADO_OFERTA=@II_ESTADO_OFERTA
  where ID_OFERTA=@II_ID_OFERTA;
GO
/****** Object:  StoredProcedure [dbo].[ACTOFERTA_DET_01]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTOFERTA_DET_01]
       @II_ID_OFERTA_DET01  CHAR(5),
       @II_ID_T_ALOJ_DET01  CHAR(5),
       @II_DESCUENTO_DET01  DECIMAL
AS
	insert into oferta_det_01 values(	     @II_ID_OFERTA_DET01,
	     @II_ID_T_ALOJ_DET01,
	     @II_DESCUENTO_DET01);
GO
/****** Object:  StoredProcedure [dbo].[ACTOFERTA_DET_02]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTOFERTA_DET_02]
       @II_ID_OFERTA_DET02  CHAR(5),
       @II_ID_T_CLIENTE_DET02  CHAR(5),
       @II_DESCUENTO_DET02  DECIMAL
AS
	insert into oferta_det_02 values(	     @II_ID_OFERTA_DET02,
	     @II_ID_T_CLIENTE_DET02,
	     @II_DESCUENTO_DET02);
GO
/****** Object:  StoredProcedure [dbo].[ACTOFERTA_DET_03]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTOFERTA_DET_03]
       @II_ID_OFERTA_DET03  CHAR(5),
       @II_C_INI_ALOJ_DET03  INT,
       @II_C_FIN_ALOJ_DET03  INT,
       @II_DESCUENTO_DET03  DECIMAL
AS

	insert into oferta_det_03 values(	     @II_ID_OFERTA_DET03,
	     @II_C_INI_ALOJ_DET03,
	     @II_C_FIN_ALOJ_DET03,
	     @II_DESCUENTO_DET03);
GO
/****** Object:  StoredProcedure [dbo].[ACTPAIS]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTPAIS]
       @II_ID_PAIS  CHAR(5),
       @II_DESCR_PAIS  VARCHAR(50),
       @II_ESTADO_PAIS  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into PAIS values(	     @II_ID_PAIS,
	     @II_DESCR_PAIS,
	     @II_ESTADO_PAIS);
else
	update PAIS set 	     DESCR_PAIS=@II_DESCR_PAIS,
	     ESTADO_PAIS=@II_ESTADO_PAIS
  where ID_PAIS=@II_ID_PAIS;
GO
/****** Object:  StoredProcedure [dbo].[ACTPERMISOS_ADI]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTPERMISOS_ADI]
       @II_ID_OPCION  CHAR(5),
       @II_DESCR_OPCION  VARCHAR(30),
       @II_ESTADO_OPCION  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into Permisos_Adi values(	     @II_ID_OPCION,
	     @II_DESCR_OPCION,
	     @II_ESTADO_OPCION);
else
	update Permisos_Adi set 	     DESCR_OPCION=@II_DESCR_OPCION,
	     ESTADO_OPCION=@II_ESTADO_OPCION
  where ID_OPCION=@II_ID_OPCION;
GO
/****** Object:  StoredProcedure [dbo].[ACTPROVINCIA]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTPROVINCIA]
       @II_ID_PROVINCIA  CHAR(5),
       @II_DESCR_PROVINCIA  VARCHAR(50),
       @II_ID_PAIS_PROVINCIA  CHAR(5),
       @II_ESTADO_PROVINCIA  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into PROVINCIA values(	     @II_ID_PROVINCIA,
	     @II_DESCR_PROVINCIA,
	     @II_ID_PAIS_PROVINCIA,
	     @II_ESTADO_PROVINCIA);
else
	update PROVINCIA set 	     DESCR_PROVINCIA=@II_DESCR_PROVINCIA,
	     ID_PAIS_PROVINCIA=@II_ID_PAIS_PROVINCIA,
	     ESTADO_PROVINCIA=@II_ESTADO_PROVINCIA
  where ID_PROVINCIA=@II_ID_PROVINCIA;
GO
/****** Object:  StoredProcedure [dbo].[ACTRESERVACION]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTRESERVACION]
        @II_ID_RESERVACION  INT,
       @II_ID_CLIENTE  CHAR(5),
       @II_ID_T_ALOJ_RESERVACION  CHAR(5),
      @II_FECHA_LLEG_RESERVACION  DATETIME,
       @II_FECHA_SAL_RESERVACION  DATETIME,
       @II_MONTO_APAGAR  DECIMAL,
       @II_ESTADO_RESERVACION  CHAR(1),
       @II_CREADO_POR_RESERVACION  CHAR(10),
    --   @II_FECHA_CRE_RESERVACION  DATETIME,
       @II_MOD_POR_RESERVACION  CHAR(10),
     ---  @II_FECHA_MOD_RESERVACION  DATETIME,
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into reservacion values(	     @II_ID_RESERVACION,
	     @II_ID_CLIENTE,
	     @II_ID_T_ALOJ_RESERVACION,
	     @II_FECHA_LLEG_RESERVACION ,
	     @II_FECHA_SAL_RESERVACION  ,
	     @II_MONTO_APAGAR,
	     @II_ESTADO_RESERVACION,
	     @II_CREADO_POR_RESERVACION,
	     GETDATE(),
	     @II_MOD_POR_RESERVACION,
	     GETDATE());
else
	update reservacion set 	     ID_CLIENTE=@II_ID_CLIENTE,
	     ID_T_ALOJ_RESERVACION=@II_ID_T_ALOJ_RESERVACION,
	     FECHA_LLEG_RESERVACION=@II_FECHA_LLEG_RESERVACION  ,
	     FECHA_SAL_RESERVACION=@II_FECHA_SAL_RESERVACION  ,
	     MONTO_APAGAR=@II_MONTO_APAGAR,
	     ESTADO_RESERVACION=@II_ESTADO_RESERVACION,
	     MOD_POR_RESERVACION=@II_MOD_POR_RESERVACION,
	     FECHA_MOD_RESERVACION=GETDATE()
  where ID_RESERVACION=@II_ID_RESERVACION;
GO
/****** Object:  StoredProcedure [dbo].[ACTRESERVACION_DET]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTRESERVACION_DET]
       @II_ID_RESERVACION_DET  INT,
       @II_ID_THAB_RESERV_DET  CHAR(5),
       @II_CANT_RESERV_DET  INT
AS

	insert into reservacion_det values(	     @II_ID_RESERVACION_DET,
	     @II_ID_THAB_RESERV_DET,
	     @II_CANT_RESERV_DET);
GO
/****** Object:  StoredProcedure [dbo].[ACTSERVICIO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTSERVICIO]
       @II_ID_SERVICIO  CHAR(5),
       @II_DESCR_SERVICIO  VARCHAR(50),
       @II_COSTO_SERVICIO  DECIMAL,
       @II_ESTADO_SERVICIO  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into servicio values(	     @II_ID_SERVICIO,
	     @II_DESCR_SERVICIO,
	     @II_COSTO_SERVICIO,
	     @II_ESTADO_SERVICIO);
else
	update servicio set 	     DESCR_SERVICIO=@II_DESCR_SERVICIO,
	     COSTO_SERVICIO=@II_COSTO_SERVICIO,
	     ESTADO_SERVICIO=@II_ESTADO_SERVICIO
  where ID_SERVICIO=@II_ID_SERVICIO;
GO
/****** Object:  StoredProcedure [dbo].[ACTTALOJAMIENTO_SERVICIO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTTALOJAMIENTO_SERVICIO]
       @II_ID_T_ALOJAMIENTO_TAS  CHAR(5),
       @II_ID_SERVICIO_TAS  CHAR(5),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into talojamiento_servicio values(	     @II_ID_T_ALOJAMIENTO_TAS,
	     @II_ID_SERVICIO_TAS);
else
	update talojamiento_servicio set 	     ID_SERVICIO_TAS=@II_ID_SERVICIO_TAS
  where ID_T_ALOJAMIENTO_TAS=@II_ID_T_ALOJAMIENTO_TAS;
GO
/****** Object:  StoredProcedure [dbo].[ACTTELEFONO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTTELEFONO]
       @II_ID_TERCERO_TEL  CHAR(10),
       @II_NUMERO_TEL  VARCHAR(20),
       @II_TIPO_TEL  VARCHAR(2),
       @II_N_LINEA_TEL  INT,
       @II_ESTADO_TEL  CHAR(1)
AS
	insert into TELEFONO values(	     @II_ID_TERCERO_TEL,
	     @II_NUMERO_TEL,
	     @II_TIPO_TEL,
	     @II_N_LINEA_TEL,
	     @II_ESTADO_TEL);

GO
/****** Object:  StoredProcedure [dbo].[ACTTEMPORADA]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTTEMPORADA]
       @II_ID_TEMPORADA  CHAR(5),
       @II_DESCR_TEMPORADA  VARCHAR(100),
       @II_FECHA_I_TEMPORADA  DATE,
       @II_FECHA_F_TEMPORADA  DATE,
       @II_ESTADO_TEMPORADA  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into TEMPORADA values(	     @II_ID_TEMPORADA,
	     @II_DESCR_TEMPORADA,
	     @II_FECHA_I_TEMPORADA,
	     @II_FECHA_F_TEMPORADA,
	     @II_ESTADO_TEMPORADA);
else
	update TEMPORADA set 	     DESCR_TEMPORADA=@II_DESCR_TEMPORADA,
	     FECHA_I_TEMPORADA=@II_FECHA_I_TEMPORADA,
	     FECHA_F_TEMPORADA=@II_FECHA_F_TEMPORADA,
	     ESTADO_TEMPORADA=@II_ESTADO_TEMPORADA
  where ID_TEMPORADA=@II_ID_TEMPORADA;
GO
/****** Object:  StoredProcedure [dbo].[ACTTERCERO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTTERCERO]
       @II_ID_TERCERO  CHAR(10),
       @II_NOMBRE_TERCERO  VARCHAR(100),
       @II_ID_T_IDENTIF_TERCERO  CHAR(5),
       @II_CEDULA_TERCERO  VARCHAR(20),
       @II_FECHA_NAC_TERCERO  DATE,
       @II_SEXO_TERCERO  CHAR(1),
       @II_ESTADO_TERCERO  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into Tercero values(	     @II_ID_TERCERO,
	     @II_NOMBRE_TERCERO,
	     @II_ID_T_IDENTIF_TERCERO,
	     @II_CEDULA_TERCERO,
	     @II_FECHA_NAC_TERCERO,
	     @II_SEXO_TERCERO,
	     @II_ESTADO_TERCERO);
else
	update Tercero set 	     NOMBRE_TERCERO=@II_NOMBRE_TERCERO,
	     ID_T_IDENTIF_TERCERO=@II_ID_T_IDENTIF_TERCERO,
	     CEDULA_TERCERO=@II_CEDULA_TERCERO,
	     FECHA_NAC_TERCERO=@II_FECHA_NAC_TERCERO,
	     SEXO_TERCERO=@II_SEXO_TERCERO,
	     ESTADO_TERCERO=@II_ESTADO_TERCERO
  where ID_TERCERO=@II_ID_TERCERO;
GO
/****** Object:  StoredProcedure [dbo].[ACTTHAB_CARACTERISTICA]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTTHAB_CARACTERISTICA]
       @II_ID_T_HAB_THCAR  CHAR(5),
       @II_ID_CARACTERISTICA_THCAR  CHAR(5),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into thab_caracteristica values(	     @II_ID_T_HAB_THCAR,
	     @II_ID_CARACTERISTICA_THCAR);
else
	update thab_caracteristica set 	     ID_CARACTERISTICA_THCAR=@II_ID_CARACTERISTICA_THCAR
  where ID_T_HAB_THCAR=@II_ID_T_HAB_THCAR;
GO
/****** Object:  StoredProcedure [dbo].[ACTTHABITACION_CAMA]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTTHABITACION_CAMA]
       @II_ID_T_HAB_THC  CHAR(5),
       @II_ID_CAMA_THC  CHAR(5),
       @II_CANTIDAD_CAMAS  INT,
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into thabitacion_cama values(	     @II_ID_T_HAB_THC,
	     @II_ID_CAMA_THC,
	     @II_CANTIDAD_CAMAS);
else
	update thabitacion_cama set 	     ID_CAMA_THC=@II_ID_CAMA_THC,
	     CANTIDAD_CAMAS=@II_CANTIDAD_CAMAS
  where ID_T_HAB_THC=@II_ID_T_HAB_THC;
GO
/****** Object:  StoredProcedure [dbo].[ACTTIPO_ALOJAMIENTO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTTIPO_ALOJAMIENTO]
       @II_ID_T_ALOJAMIENTO  CHAR(5),
       @II_DESCR_T_ALOJAMIENTO  VARCHAR(100),
       @II_COSTO_T_ALOJAMIENTO  DECIMAL,
       @II_ESTADO_T_ALOJAMIENTO  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into tipo_alojamiento values(	     @II_ID_T_ALOJAMIENTO,
	     @II_DESCR_T_ALOJAMIENTO,
	     @II_COSTO_T_ALOJAMIENTO,
	     @II_ESTADO_T_ALOJAMIENTO);
else
	update tipo_alojamiento set 	     DESCR_T_ALOJAMIENTO=@II_DESCR_T_ALOJAMIENTO,
	     COSTO_T_ALOJAMIENTO=@II_COSTO_T_ALOJAMIENTO,
	     ESTADO_T_ALOJAMIENTO=@II_ESTADO_T_ALOJAMIENTO
  where ID_T_ALOJAMIENTO=@II_ID_T_ALOJAMIENTO;
GO
/****** Object:  StoredProcedure [dbo].[ACTTIPO_ARCHIVO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTTIPO_ARCHIVO]
       @II_ID_T_ARCHIVO  INT,
       @II_DESCR_T_ARCHIVO  VARCHAR(100),
       @II_ESTADO_T_ARCHIVO  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into tipo_archivo values(	     @II_ID_T_ARCHIVO,
	     @II_DESCR_T_ARCHIVO,
	     @II_ESTADO_T_ARCHIVO);
else
	update tipo_archivo set 	     DESCR_T_ARCHIVO=@II_DESCR_T_ARCHIVO,
	     ESTADO_T_ARCHIVO=@II_ESTADO_T_ARCHIVO
  where ID_T_ARCHIVO=@II_ID_T_ARCHIVO;
GO
/****** Object:  StoredProcedure [dbo].[ACTTIPO_CLIENTE]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTTIPO_CLIENTE]
       @II_ID_T_CLIENTE_TC  CHAR(5),
       @II_DESCR_TC  VARCHAR(50),
       @II_ESTADO_TC  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into TIPO_CLIENTE values(	     @II_ID_T_CLIENTE_TC,
	     @II_DESCR_TC,
	     @II_ESTADO_TC);
else
	update TIPO_CLIENTE set 	     DESCR_TC=@II_DESCR_TC,
	     ESTADO_TC=@II_ESTADO_TC
  where ID_T_CLIENTE_TC=@II_ID_T_CLIENTE_TC;
GO
/****** Object:  StoredProcedure [dbo].[ACTTIPO_EMPLEADO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTTIPO_EMPLEADO]
       @II_ID_T_EMPLEADO_TE  CHAR(5),
       @II_DESCR_TE  VARCHAR(50),
       @II_ESTADO_TE  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into TIPO_EMPLEADO values(	     @II_ID_T_EMPLEADO_TE,
	     @II_DESCR_TE,
	     @II_ESTADO_TE);
else
	update TIPO_EMPLEADO set 	     DESCR_TE=@II_DESCR_TE,
	     ESTADO_TE=@II_ESTADO_TE
  where ID_T_EMPLEADO_TE=@II_ID_T_EMPLEADO_TE;
GO
/****** Object:  StoredProcedure [dbo].[ACTTIPO_HABITACION]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTTIPO_HABITACION]
       @II_ID_T_HAB  CHAR(5),
       @II_DESCR_T_HAB  VARCHAR(50),
       @II_CAPACIDAD_HAB  INT,
       @II_COSTO_HAB  DECIMAL,
       @II_ESTADO_T_HAB  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into tipo_habitacion values(	     @II_ID_T_HAB,
	     @II_DESCR_T_HAB,
	     @II_CAPACIDAD_HAB,
	     @II_COSTO_HAB,
	     @II_ESTADO_T_HAB);
else
	update tipo_habitacion set 	     DESCR_T_HAB=@II_DESCR_T_HAB,
	     CAPACIDAD_HAB=@II_CAPACIDAD_HAB,
	     COSTO_HAB=@II_COSTO_HAB,
	     ESTADO_T_HAB=@II_ESTADO_T_HAB
  where ID_T_HAB=@II_ID_T_HAB;
GO
/****** Object:  StoredProcedure [dbo].[ACTTIPO_IDENTIFICACION]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTTIPO_IDENTIFICACION]
       @II_ID_TIPO_IDENT  CHAR(5),
       @II_DESCR_TIPO_IDENT  VARCHAR(30),
       @II_ESTADO_TIPO_IDENT  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into Tipo_Identificacion values(	     @II_ID_TIPO_IDENT,
	     @II_DESCR_TIPO_IDENT,
	     @II_ESTADO_TIPO_IDENT);
else
	update Tipo_Identificacion set 	     DESCR_TIPO_IDENT=@II_DESCR_TIPO_IDENT,
	     ESTADO_TIPO_IDENT=@II_ESTADO_TIPO_IDENT
  where ID_TIPO_IDENT=@II_ID_TIPO_IDENT;
GO
/****** Object:  StoredProcedure [dbo].[ACTTIPO_MANTENIMIENTO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTTIPO_MANTENIMIENTO]
       @II_ID_T_MANTENIMIENTO  CHAR(5),
       @II_DESCR_T_MANTENIMIENTO  VARCHAR(100),
       @II_ESTADO_T_MANTENIMIENTO  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into tipo_mantenimiento values(	     @II_ID_T_MANTENIMIENTO,
	     @II_DESCR_T_MANTENIMIENTO,
	     @II_ESTADO_T_MANTENIMIENTO);
else
	update tipo_mantenimiento set 	     DESCR_T_MANTENIMIENTO=@II_DESCR_T_MANTENIMIENTO,
	     ESTADO_T_MANTENIMIENTO=@II_ESTADO_T_MANTENIMIENTO
  where ID_T_MANTENIMIENTO=@II_ID_T_MANTENIMIENTO;
GO
/****** Object:  StoredProcedure [dbo].[ACTTIPO_USUARIO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTTIPO_USUARIO]
       @II_ID_T_USUARIO  CHAR(5),
       @II_DESCRIPCION_T_USUARIO  VARCHAR(30),
       @II_NIVEL_ACCESO_T_USUARIO  VARCHAR(3),
       @II_ESTADO_T_USUARIO  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into Tipo_Usuario values(	     @II_ID_T_USUARIO,
	     @II_DESCRIPCION_T_USUARIO,
	     @II_NIVEL_ACCESO_T_USUARIO,
	     @II_ESTADO_T_USUARIO);
else
	update Tipo_Usuario set 	     DESCRIPCION_T_USUARIO=@II_DESCRIPCION_T_USUARIO,
	     NIVEL_ACCESO_T_USUARIO=@II_NIVEL_ACCESO_T_USUARIO,
	     ESTADO_T_USUARIO=@II_ESTADO_T_USUARIO
  where ID_T_USUARIO=@II_ID_T_USUARIO;
GO
/****** Object:  StoredProcedure [dbo].[ACTUSUARIO]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTUSUARIO]
       @II_ID_USUARIO  CHAR(10),
       @II_ID_TERCERO_USUARIO  CHAR(10),
       @II_TIPO_USUARIO  CHAR(5),
       @II_PASSWORD_USUARIO  VARCHAR(max),
       @II_ESTADO_USUARIO  CHAR(1),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into Usuario values(	     @II_ID_USUARIO,
	     @II_ID_TERCERO_USUARIO,
	     @II_TIPO_USUARIO,
	     @II_PASSWORD_USUARIO,
	     @II_ESTADO_USUARIO);
else
	update Usuario set 	     ID_TERCERO_USUARIO=@II_ID_TERCERO_USUARIO,
	     TIPO_USUARIO=@II_TIPO_USUARIO,
	     PASSWORD_USUARIO=@II_PASSWORD_USUARIO,
	     ESTADO_USUARIO=@II_ESTADO_USUARIO
  where ID_USUARIO=@II_ID_USUARIO;
GO
/****** Object:  StoredProcedure [dbo].[ACTUSUARIO_PERMISOS_ADI]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACTUSUARIO_PERMISOS_ADI]
       @II_ID_USUARIO_UP  CHAR(10),
       @II_ID_PERMISO_UP  CHAR(5),
       @aa_Modo  char(1)
AS
if @aa_Modo='A' 
	insert into Usuario_Permisos_Adi values(	     @II_ID_USUARIO_UP,
	     @II_ID_PERMISO_UP);
else
	update Usuario_Permisos_Adi set 	     ID_PERMISO_UP=@II_ID_PERMISO_UP
  where ID_USUARIO_UP=@II_ID_USUARIO_UP;
GO
/****** Object:  StoredProcedure [dbo].[CDetMant]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CDetMant]
       @II_id  int
AS
	select * from mantenimiento_det 
	where id_mantenimiento_det=@II_id
GO
/****** Object:  StoredProcedure [dbo].[CMantActivos]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CMantActivos]
       @II_id  char(5)
AS
	select * from 
			mantenimiento 
	where id_hab_mantenimiento=@II_id and 
	estado_mantenimiento='P'
GO
/****** Object:  StoredProcedure [dbo].[CReservasVsCancelaciones]    Script Date: 20/04/2020 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CReservasVsCancelaciones]
       @II_FechaI  date,
       @II_FechaF  date
AS
	select 'Res',count(*)
	from reservacion 
	where not exists (select * from cancelacion where id_reserv_cancelacion=id_reservacion) and
		  fecha_lleg_reservacion between @II_FechaI and @II_FechaF
	Union All
	select 'Can',count(*)
	from reservacion 
	where exists (select * from cancelacion where id_reserv_cancelacion=id_reservacion) and
		  fecha_lleg_reservacion between @II_FechaI and @II_FechaF
GO
USE [master]
GO
ALTER DATABASE [db_hotel] SET  READ_WRITE 
GO
