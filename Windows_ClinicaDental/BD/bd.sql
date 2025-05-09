USE [master]
GO
/****** Object:  Database [ClinicaDental_DB]    Script Date: 13/04/2025 16:39:43 ******/
CREATE DATABASE [ClinicaDental_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ClinicaDental_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ClinicaDental_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ClinicaDental_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ClinicaDental_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ClinicaDental_DB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ClinicaDental_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ClinicaDental_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ClinicaDental_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ClinicaDental_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ClinicaDental_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ClinicaDental_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [ClinicaDental_DB] SET  MULTI_USER 
GO
ALTER DATABASE [ClinicaDental_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ClinicaDental_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ClinicaDental_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ClinicaDental_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ClinicaDental_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ClinicaDental_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ClinicaDental_DB', N'ON'
GO
ALTER DATABASE [ClinicaDental_DB] SET QUERY_STORE = ON
GO
ALTER DATABASE [ClinicaDental_DB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ClinicaDental_DB]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cita](
	[idCita] [int] IDENTITY(1,1) NOT NULL,
	[idPaciente] [int] NULL,
	[idDentista] [int] NULL,
	[fechaCita] [date] NULL,
	[horaCita] [time](7) NULL,
	[motivoCita] [varchar](250) NULL,
	[estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dentista]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dentista](
	[idDentista] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NULL,
	[especialidad] [int] NULL,
	[estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDentista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Disponibilidad]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disponibilidad](
	[idDisponibilidad] [int] IDENTITY(1,1) NOT NULL,
	[idDentista] [int] NULL,
	[fecha] [date] NULL,
	[hora] [time](7) NULL,
	[estado] [int] NULL,
	[MotivoEliminacion] [nvarchar](255) NULL,
	[Eliminado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDisponibilidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidad](
	[idEspecialidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[descripcion] [varchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEspecialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[idFactura] [int] IDENTITY(1,1) NOT NULL,
	[idPaciente] [int] NULL,
	[fecha] [date] NULL,
	[montoTotal] [decimal](10, 2) NULL,
	[estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Historia]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historia](
	[idHistoria] [int] IDENTITY(1,1) NOT NULL,
	[idPaciente] [int] NULL,
	[idCita] [int] NULL,
	[fecha] [date] NULL,
	[descripcion] [text] NULL,
	[idDentista] [int] NULL,
	[idTratamiento] [int] NULL,
	[observaciones] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[idHistoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HorarioDentista]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HorarioDentista](
	[idHorario] [int] IDENTITY(1,1) NOT NULL,
	[idDentista] [int] NULL,
	[diaSemana] [varchar](20) NULL,
	[horaInicio] [time](7) NULL,
	[horaFin] [time](7) NULL,
	[mesObjetivo] [int] NULL,
	[anioObjetivo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idHorario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[idPaciente] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pago]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pago](
	[idPago] [int] IDENTITY(1,1) NOT NULL,
	[idPaciente] [int] NULL,
	[fecha] [date] NULL,
	[monto] [decimal](10, 2) NULL,
	[metodoPago] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tratamiento]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tratamiento](
	[idTratamiento] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[descripcion] [varchar](250) NULL,
	[precio] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTratamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[dni] [varchar](8) NOT NULL,
	[correo] [varchar](100) NULL,
	[contraseña] [varchar](100) NULL,
	[nombres] [varchar](100) NULL,
	[apellidos] [varchar](100) NULL,
	[telefono] [varchar](15) NULL,
	[fechaNacimiento] [date] NULL,
	[direccion] [varchar](200) NULL,
	[sexo] [int] NULL,
	[rol] [varchar](50) NULL,
	[estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Dentista] ON 

INSERT [dbo].[Dentista] ([idDentista], [idUsuario], [especialidad], [estado]) VALUES (1, 23, 1, 1)
INSERT [dbo].[Dentista] ([idDentista], [idUsuario], [especialidad], [estado]) VALUES (2, 24, 1, 1)
INSERT [dbo].[Dentista] ([idDentista], [idUsuario], [especialidad], [estado]) VALUES (3, 25, 1, 1)
INSERT [dbo].[Dentista] ([idDentista], [idUsuario], [especialidad], [estado]) VALUES (4, 26, 2, 1)
INSERT [dbo].[Dentista] ([idDentista], [idUsuario], [especialidad], [estado]) VALUES (5, 27, 2, 1)
INSERT [dbo].[Dentista] ([idDentista], [idUsuario], [especialidad], [estado]) VALUES (6, 28, 2, 1)
INSERT [dbo].[Dentista] ([idDentista], [idUsuario], [especialidad], [estado]) VALUES (7, 29, 2, 1)
INSERT [dbo].[Dentista] ([idDentista], [idUsuario], [especialidad], [estado]) VALUES (8, 30, 3, 1)
INSERT [dbo].[Dentista] ([idDentista], [idUsuario], [especialidad], [estado]) VALUES (9, 31, 3, 1)
INSERT [dbo].[Dentista] ([idDentista], [idUsuario], [especialidad], [estado]) VALUES (10, 32, 4, 1)
SET IDENTITY_INSERT [dbo].[Dentista] OFF
GO
SET IDENTITY_INSERT [dbo].[Especialidad] ON 

INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (1, N'Consulta Dental', N'Atención preventiva y diagnóstico general de la salud bucal.')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (2, N'Ortodoncia', N'Corrección de dientes y mandíbulas mal posicionados.')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (3, N'Endodoncia', N'Tratamiento de conductos radiculares para salvar dientes dañados.')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (4, N'Periodoncia', N'Diagnóstico y tratamiento de enfermedades de las encías y los tejidos que soportan los dientes.')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (5, N'Implantología', N'Colocación de implantes dentales para sustituir dientes perdidos.')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (6, N'Odontopediatría', N'Atención dental integral para niños.')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (7, N'Cirugía Oral', N'Procedimientos quirúrgicos dentro de la cavidad oral, como extracciones complejas de dientes.')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (8, N'Odontología Estética', N'Mejora de la apariencia de los dientes mediante técnicas de blanqueamiento, carillas y más.')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (9, N'Prostodoncia', N'Rehabilitación de dientes ausentes o dañados mediante prótesis dentales.')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (10, N'Radiología Dental', N'Uso de rayos X para el diagnóstico dental y maxilofacial.')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (11, N'Odontología Restauradora', N'Reparación de dientes dañados o cariados mediante empastes y coronas.')
SET IDENTITY_INSERT [dbo].[Especialidad] OFF
GO
SET IDENTITY_INSERT [dbo].[Paciente] ON 

INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (1, 1)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (2, 3)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (3, 4)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (4, 5)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (5, 6)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (6, 7)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (7, 8)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (8, 9)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (9, 10)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (10, 11)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (11, 12)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (12, 13)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (13, 14)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (14, 15)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (15, 16)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (16, 17)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (17, 18)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (18, 19)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (19, 20)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (20, 21)
INSERT [dbo].[Paciente] ([idPaciente], [idUsuario]) VALUES (21, 22)
SET IDENTITY_INSERT [dbo].[Paciente] OFF
GO
SET IDENTITY_INSERT [dbo].[Tratamiento] ON 

INSERT [dbo].[Tratamiento] ([idTratamiento], [nombre], [descripcion], [precio]) VALUES (1, N'Brackets', N'Colocación de brackets para corregir la alineación de los dientes.', CAST(2500.00 AS Decimal(10, 2)))
INSERT [dbo].[Tratamiento] ([idTratamiento], [nombre], [descripcion], [precio]) VALUES (2, N'Tratamiento de conducto', N'Procedimiento para tratar la infección dentro del diente.', CAST(1200.00 AS Decimal(10, 2)))
INSERT [dbo].[Tratamiento] ([idTratamiento], [nombre], [descripcion], [precio]) VALUES (3, N'Sellantes dentales', N'Aplicación de sellantes para proteger los dientes de los niños contra caries.', CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Tratamiento] ([idTratamiento], [nombre], [descripcion], [precio]) VALUES (4, N'Limpieza profunda', N'Limpieza profunda de encías y eliminación de sarro.', CAST(450.00 AS Decimal(10, 2)))
INSERT [dbo].[Tratamiento] ([idTratamiento], [nombre], [descripcion], [precio]) VALUES (5, N'Implante dental', N'Colocación de implantes dentales para reemplazar dientes perdidos.', CAST(3500.00 AS Decimal(10, 2)))
INSERT [dbo].[Tratamiento] ([idTratamiento], [nombre], [descripcion], [precio]) VALUES (6, N'Extracción de muelas del juicio', N'Extracción quirúrgica de muelas del juicio.', CAST(900.00 AS Decimal(10, 2)))
INSERT [dbo].[Tratamiento] ([idTratamiento], [nombre], [descripcion], [precio]) VALUES (7, N'Prótesis fija', N'Colocación de prótesis dentales fijas para reemplazar dientes ausentes.', CAST(2800.00 AS Decimal(10, 2)))
INSERT [dbo].[Tratamiento] ([idTratamiento], [nombre], [descripcion], [precio]) VALUES (8, N'Blanqueamiento dental', N'Tratamiento de blanqueamiento para mejorar la estética dental.', CAST(600.00 AS Decimal(10, 2)))
INSERT [dbo].[Tratamiento] ([idTratamiento], [nombre], [descripcion], [precio]) VALUES (9, N'Restauración con resina', N'Relleno de caries utilizando resina estética.', CAST(400.00 AS Decimal(10, 2)))
INSERT [dbo].[Tratamiento] ([idTratamiento], [nombre], [descripcion], [precio]) VALUES (10, N'Radiografía panorámica', N'Radiografía completa de la boca para diagnóstico.', CAST(150.00 AS Decimal(10, 2)))
INSERT [dbo].[Tratamiento] ([idTratamiento], [nombre], [descripcion], [precio]) VALUES (11, N'Profilaxis dental', N'Limpieza dental regular para prevenir enfermedades.', CAST(200.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Tratamiento] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (1, N'73335280', N'andy@gmail.com', N'123', N'Andy Rodrigo', N'Gonzales Castillo', N'960936934', CAST(N'2005-05-11' AS Date), N'Calle 123', 1, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (3, N'12345678', N'maria.perez@example.com', N'password123', N'Maria', N'Perez Lopez', N'987654321', CAST(N'1990-05-10' AS Date), N'Calle 123, Lima', 0, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (4, N'87654321', N'juan.lopez@example.com', N'securepass', N'Juan', N'Lopez García', N'912345678', CAST(N'1985-03-15' AS Date), N'Av. Siempre Viva 742, Lima', 1, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (5, N'10293847', N'ana.rodriguez@example.com', N'anaPass2023', N'Ana', N'Rodriguez Fernandez', N'922334455', CAST(N'1992-11-23' AS Date), N'Calle Falsa 123, Lima', 0, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (6, N'56473829', N'carlos.gomez@example.com', N'gomezSecure', N'Carlos', N'Gomez Perez', N'911223344', CAST(N'1988-07-12' AS Date), N'Jr. Libertad 456, Lima', 1, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (7, N'19283746', N'sofia.martinez@example.com', N'sofi1234', N'Sofia', N'Martinez Soto', N'933221144', CAST(N'1995-12-05' AS Date), N'Av. Central 789, Lima', 0, N'Paciente', 0)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (8, N'28374659', N'pedro.lopez@example.com', N'pedroPass', N'Pedro', N'Lopez Rodriguez', N'955667788', CAST(N'1993-01-01' AS Date), N'Jr. Los Pinos 321, Lima', 1, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (9, N'91827364', N'laura.garcia@example.com', N'laura123', N'Laura', N'Garcia Gomez', N'977665544', CAST(N'1999-09-09' AS Date), N'Calle Norte 87, Lima', 0, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (10, N'56473819', N'luis.mendez@example.com', N'luisPassword', N'Luis', N'Mendez Juarez', N'923456789', CAST(N'1978-04-30' AS Date), N'Av. Sur 654, Lima', 1, N'Paciente', 0)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (11, N'65748392', N'isabel.moreno@example.com', N'isaMoreno2023', N'Isabel', N'Moreno Flores', N'944556677', CAST(N'1997-06-25' AS Date), N'Calle Primavera 12, Lima', 0, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (12, N'37482910', N'david.fernandez@example.com', N'davidSafe', N'David', N'Fernandez Mendez', N'912345123', CAST(N'1983-08-08' AS Date), N'Jr. Luna 99, Lima', 1, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (13, N'49382746', N'paula.torres@example.com', N'paulaTorres123', N'Paula', N'Torres Diaz', N'911234567', CAST(N'1994-02-18' AS Date), N'Av. Oeste 101, Lima', 0, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (14, N'83746592', N'andres.ruiz@example.com', N'andresPass!', N'Andres', N'Ruiz Gonzales', N'922113355', CAST(N'1987-10-10' AS Date), N'Calle Colina 45, Lima', 1, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (15, N'91827365', N'lucia.fuentes@example.com', N'luciaSafe2023', N'Lucia', N'Fuentes Paredes', N'933112233', CAST(N'2000-05-20' AS Date), N'Jr. Verde 123, Lima', 0, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (16, N'28374651', N'felipe.santos@example.com', N'felipe123', N'Felipe', N'Santos Lopez', N'955441122', CAST(N'1991-12-12' AS Date), N'Av. Libertad 999, Lima', 1, N'Paciente', 0)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (17, N'39284756', N'adriana.ramos@example.com', N'adriSafe', N'Adriana', N'Ramos Ortiz', N'977441144', CAST(N'1996-11-11' AS Date), N'Jr. Sol 45, Lima', 0, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (18, N'91837465', N'bruno.vasquez@example.com', N'brunoVasquez2023', N'Bruno', N'Vasquez Herrera', N'911223344', CAST(N'1984-06-06' AS Date), N'Calle Rio 67, Lima', 1, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (19, N'39274658', N'monica.reyes@example.com', N'monicaReyesSafe', N'Monica', N'Reyes Campos', N'922334455', CAST(N'1999-03-22' AS Date), N'Av. Arboles 75, Lima', 0, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (20, N'83749201', N'roberto.flores@example.com', N'robertoPass2023', N'Roberto', N'Flores Garcia', N'933445566', CAST(N'1982-12-31' AS Date), N'Calle Oro 98, Lima', 1, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (21, N'91827366', N'elena.rios@example.com', N'elenaSafe2024', N'Elena', N'Rios Mendoza', N'911223344', CAST(N'1990-10-10' AS Date), N'Av. Rio 45, Lima', 0, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (22, N'28374652', N'marco.garcia@example.com', N'marco2023!', N'Marco', N'Garcia Ortiz', N'977441145', CAST(N'1985-12-05' AS Date), N'Jr. Paz 123, Lima', 1, N'Paciente', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (23, N'01929495', N'dentista1@clinica.com', N'contraseña1', N'Carlos', N'Ramírez', N'999888777', CAST(N'1985-05-20' AS Date), N'Av. Los Olivos 123', 1, N'Dentista', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (24, N'01239494', N'dentista2@clinica.com', N'contraseña2', N'Ana', N'Fernández', N'987654321', CAST(N'1990-10-15' AS Date), N'Calle Las Flores 456', 0, N'Dentista', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (25, N'11223344', N'dentista3@clinica.com', N'contraseña3', N'Mario', N'Pérez', N'912345678', CAST(N'1978-08-30' AS Date), N'Jr. San José 789', 1, N'Dentista', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (26, N'91828483', N'dentista4@clinica.com', N'contraseña4', N'Lucía', N'Gómez', N'923456789', CAST(N'1995-03-10' AS Date), N'Av. Primavera 321', 0, N'Dentista', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (27, N'91827377', N'dentista5@clinica.com', N'contraseña5', N'Javier', N'Mendoza', N'934567890', CAST(N'1982-01-25' AS Date), N'Calle Luna 654', 1, N'Dentista', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (28, N'12395679', N'dentista6@clinica.com', N'contraseña6', N'Sofía', N'Torres', N'945678901', CAST(N'1993-09-05' AS Date), N'Jr. Sol 987', 0, N'Dentista', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (29, N'92827777', N'dentista7@clinica.com', N'contraseña7', N'Andrés', N'Ríos', N'956789012', CAST(N'1987-07-22' AS Date), N'Av. Central 852', 1, N'Dentista', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (30, N'09988888', N'dentista8@clinica.com', N'contraseña8', N'María', N'Vega', N'967890123', CAST(N'1991-12-12' AS Date), N'Calle Pino 159', 0, N'Dentista', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (31, N'18264513', N'dentista9@clinica.com', N'contraseña9', N'Julio', N'Castro', N'978901234', CAST(N'1983-11-18' AS Date), N'Jr. Robles 753', 1, N'Dentista', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (32, N'19264524', N'dentista10@clinica.com', N'contraseña10', N'Carmen', N'López', N'989012345', CAST(N'1986-06-06' AS Date), N'Av. Del Sol 456', 0, N'Dentista', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (33, N'123', N'admin12@clinicadental.com', N'123', N'Juan', N'Perez', N'987654321', CAST(N'1985-05-15' AS Date), N'Av. Los Robles 123', 1, N'Admin', 1)
INSERT [dbo].[Usuario] ([idUsuario], [dni], [correo], [contraseña], [nombres], [apellidos], [telefono], [fechaNacimiento], [direccion], [sexo], [rol], [estado]) VALUES (34, N'56781234', N'recep1@clinicadental.com', N'123', N'Carlos', N'Ramirez', N'923456789', CAST(N'1992-03-10' AS Date), N'Jr. Lima 789', 1, N'Recepcionista', 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Usuario__2A586E0B0CB023C8]    Script Date: 13/04/2025 16:39:43 ******/
ALTER TABLE [dbo].[Usuario] ADD UNIQUE NONCLUSTERED 
(
	[correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Usuario__D87608A7B98C66B7]    Script Date: 13/04/2025 16:39:43 ******/
ALTER TABLE [dbo].[Usuario] ADD UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cita] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Dentista] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Disponibilidad] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Disponibilidad] ADD  DEFAULT ((0)) FOR [Eliminado]
GO
ALTER TABLE [dbo].[Factura] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT ((1)) FOR [sexo]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD FOREIGN KEY([idDentista])
REFERENCES [dbo].[Dentista] ([idDentista])
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([idPaciente])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Dentista]  WITH CHECK ADD FOREIGN KEY([especialidad])
REFERENCES [dbo].[Especialidad] ([idEspecialidad])
GO
ALTER TABLE [dbo].[Dentista]  WITH CHECK ADD FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Disponibilidad]  WITH CHECK ADD FOREIGN KEY([idDentista])
REFERENCES [dbo].[Dentista] ([idDentista])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([idPaciente])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Historia]  WITH CHECK ADD FOREIGN KEY([idCita])
REFERENCES [dbo].[Cita] ([idCita])
GO
ALTER TABLE [dbo].[Historia]  WITH CHECK ADD FOREIGN KEY([idDentista])
REFERENCES [dbo].[Dentista] ([idDentista])
GO
ALTER TABLE [dbo].[Historia]  WITH CHECK ADD FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([idPaciente])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Historia]  WITH CHECK ADD FOREIGN KEY([idTratamiento])
REFERENCES [dbo].[Tratamiento] ([idTratamiento])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HorarioDentista]  WITH CHECK ADD FOREIGN KEY([idDentista])
REFERENCES [dbo].[Dentista] ([idDentista])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pago]  WITH CHECK ADD FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([idPaciente])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD CHECK  (([rol]='Admin' OR [rol]='Recepcionista' OR [rol]='Dentista' OR [rol]='Paciente'))
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD CHECK  (([sexo]=(1) OR [sexo]=(0)))
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarDentista]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_ActualizarDentista]
    @idDentista INT,
    @dni VARCHAR(8),
    @correo VARCHAR(100),
    @contraseña VARCHAR(100),
    @nombres VARCHAR(100),
    @apellidos VARCHAR(100),
    @telefono VARCHAR(15),
    @fechaNacimiento DATE,
    @direccion VARCHAR(200),
    @sexo INT,              -- 0: Femenino, 1: Masculino
    @estado INT,            -- 1: Activo, 0: Inactivo
    @especialidad INT       -- ID de la especialidad
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Obtener idUsuario relacionado al dentista
        DECLARE @idUsuario INT;
        SELECT @idUsuario = D.idUsuario
        FROM Dentista D
        WHERE D.idDentista = @idDentista;

        -- Actualizar los datos del Usuario
        UPDATE Usuario
        SET 
            dni = @dni,
            correo = @correo,
            contraseña = @contraseña,
            nombres = @nombres,
            apellidos = @apellidos,
            telefono = @telefono,
            fechaNacimiento = @fechaNacimiento,
            direccion = @direccion,
            sexo = @sexo,
            estado = @estado
        WHERE idUsuario = @idUsuario;

        -- Actualizar los datos del Dentista
        UPDATE Dentista
        SET 
            especialidad = @especialidad,
            estado = @estado
        WHERE idDentista = @idDentista;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarEstadoCita]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ActualizarEstadoCita]
    @idCita INT,
    @nuevoEstado INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Cita WHERE idCita = @idCita)
    BEGIN
        UPDATE Cita
        SET estado = @nuevoEstado
        WHERE idCita = @idCita;
        
        PRINT 'Estado de la cita actualizado correctamente.';
    END
    ELSE
    BEGIN
        PRINT 'Cita no encontrada.';
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarHistoriaClinica]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ActualizarHistoriaClinica]
    @idHistoria INT,
    @descripcion TEXT,
    @observaciones TEXT,
    @idTratamiento INT 
AS
BEGIN
    -- Verificar si el historial clínico existe antes de actualizar
    IF EXISTS (SELECT 1 FROM Historia WHERE idHistoria = @idHistoria)
    BEGIN
        UPDATE Historia
        SET 
            descripcion = @descripcion,
            observaciones = @observaciones,
            idTratamiento = COALESCE(@idTratamiento, idTratamiento)
        WHERE 
            idHistoria = @idHistoria;

        PRINT 'Historial clínico actualizado exitosamente.';
    END
    ELSE
    BEGIN
        PRINT 'No se encontró el historial clínico especificado.';
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarPaciente]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ActualizarPaciente]
   @idPaciente INT,
    @dni VARCHAR(8),
    @correo VARCHAR(100),
    @contraseña VARCHAR(100),
    @nombres VARCHAR(100),
    @apellidos VARCHAR(100),
    @telefono VARCHAR(15),
    @fechaNacimiento DATE,
    @direccion VARCHAR(200),
    @sexo INT,              -- 0: Femenino, 1: Masculino
    @estado INT             -- 1: Activo, 0: Inactivo
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Obtener idUsuario relacionado al paciente
        DECLARE @idUsuario INT;
        SELECT @idUsuario = P.idUsuario
        FROM Paciente P
        WHERE P.idPaciente = @idPaciente;

        -- Actualizar los datos del Usuario
        UPDATE Usuario
        SET 
            dni = @dni,
            correo = @correo,
            contraseña = @contraseña,
            nombres = @nombres,
            apellidos = @apellidos,
            telefono = @telefono,
            fechaNacimiento = @fechaNacimiento,
            direccion = @direccion,
            sexo = @sexo,
            estado = @estado
        WHERE idUsuario = @idUsuario;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarAdmin]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AgregarAdmin]
    @dni VARCHAR(8),
    @correo VARCHAR(100),
    @contraseña VARCHAR(100),
    @nombres VARCHAR(100),
    @apellidos VARCHAR(100),
    @telefono VARCHAR(15),
    @fechaNacimiento DATE,
    @direccion VARCHAR(200),
    @sexo INT,              -- 0: Femenino, 1: Masculino
    @estado INT             -- 1: Activo, 0: Inactivo
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Insertar en la tabla Usuario
        INSERT INTO Usuario (dni, correo, contraseña, nombres, apellidos, telefono, fechaNacimiento, direccion, sexo, rol, estado)
        VALUES (@dni, @correo, @contraseña, @nombres, @apellidos, @telefono, @fechaNacimiento, @direccion, @sexo, 'Admin', @estado);

        -- Obtener el idUsuario recién creado
        DECLARE @idUsuario INT = SCOPE_IDENTITY();
        
        -- Aquí se pueden agregar inserciones adicionales en otras tablas si es necesario para el rol de Admin
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarCita]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  PROCEDURE [dbo].[sp_AgregarCita]
    @idPaciente INT,
    @idDentista INT,
    @fechaCita DATE,
    @horaCita TIME,
    @motivoCita VARCHAR(250)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
            -- Verificar si el horario está disponible
            IF EXISTS (
                SELECT 1 
                FROM Disponibilidad d
                WHERE d.idDentista = @idDentista 
                    AND d.fecha = @fechaCita 
                    AND d.hora = @horaCita 
                    AND d.estado = 1  -- Debe estar disponible
                    AND NOT EXISTS (
                        SELECT 1 
                        FROM Cita c 
                        WHERE c.idDentista = @idDentista
                            AND c.fechaCita = @fechaCita
                            AND c.horaCita = @horaCita
                            AND c.estado = 1
                    )
            )
            BEGIN
                -- Insertar la nueva cita
                INSERT INTO Cita (idPaciente, idDentista, fechaCita, horaCita, motivoCita, estado)
                VALUES (@idPaciente, @idDentista, @fechaCita, @horaCita, @motivoCita, 1);
                
                -- Actualizar la disponibilidad
                UPDATE Disponibilidad
                SET estado = 0  -- Marcar como no disponible
                WHERE idDentista = @idDentista 
                    AND fecha = @fechaCita 
                    AND hora = @horaCita;

                SELECT 'Cita agregada exitosamente' AS Mensaje;
            END
            ELSE
            BEGIN
                SELECT 'El horario seleccionado no está disponible.' AS Mensaje;
            END
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SELECT 'Error al agregar la cita: ' + ERROR_MESSAGE() AS Mensaje;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarDentista]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_AgregarDentista]
    @dni VARCHAR(8),
    @correo VARCHAR(100),
    @contraseña VARCHAR(100),
    @nombres VARCHAR(100),
    @apellidos VARCHAR(100),
    @telefono VARCHAR(15),
    @fechaNacimiento DATE,
    @direccion VARCHAR(200),
    @sexo INT,
    @especialidad INT,
	@estado int
AS
BEGIN
    -- Insertar en la tabla Usuario
    INSERT INTO Usuario (dni, correo, contraseña, nombres, apellidos, telefono, fechaNacimiento, direccion, sexo, rol, estado)
    VALUES (@dni, @correo, @contraseña, @nombres, @apellidos, @telefono, @fechaNacimiento, @direccion, @sexo, 'Dentista', @estado);
    
    -- Obtener el ID del Usuario recién insertado
    DECLARE @idUsuario INT;
    SET @idUsuario = SCOPE_IDENTITY();
    
    -- Insertar en la tabla Dentista
    INSERT INTO Dentista (idUsuario, especialidad, estado)
    VALUES (@idUsuario, @especialidad, @estado);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarEspecialidad]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AgregarEspecialidad]
    @nombre VARCHAR(100),
    @descripcion VARCHAR(250)
AS
BEGIN
    -- Insertar en la tabla Especialidad
    INSERT INTO Especialidad (nombre, descripcion)
    VALUES (@nombre, @descripcion);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarHistoriaClinica]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AgregarHistoriaClinica] 
    @idPaciente INT,
    @idDentista INT,
    @idTratamiento INT,
    @idCita INT,
    @descripcion TEXT,
    @observaciones TEXT
AS
BEGIN
    -- Verificar si ya existe un historial clínico para la cita especificada
    IF EXISTS (SELECT 1 FROM Historia WHERE idCita = @idCita)
    BEGIN
        PRINT 'El historial clínico ya ha sido registrado para esta cita.';
    END
    ELSE
    BEGIN
        -- Insertar el historial clínico solo si no existe para la cita
        INSERT INTO Historia (idPaciente, fecha, descripcion, idDentista, idTratamiento, idCita, observaciones)
        VALUES (@idPaciente, GETDATE(), @descripcion, @idDentista, @idTratamiento, @idCita, @observaciones);

        PRINT 'Historial clínico registrado exitosamente.';
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarHorarioDentista]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Modificar el procedimiento almacenado para incluir validación de fechas
CREATE   PROCEDURE [dbo].[sp_AgregarHorarioDentista] 
    @idDentista INT, 
    @diaSemana VARCHAR(20), 
    @horaInicio TIME, 
    @horaFin TIME,
    @mesObjetivo INT = NULL,  
    @anioObjetivo INT = NULL  
AS 
BEGIN
    -- Explicitly truncate time to whole seconds (remove milliseconds)
    SET @horaInicio = CONVERT(TIME(0), @horaInicio);
    SET @horaFin = CONVERT(TIME(0), @horaFin);

    -- Si no se especifica el mes/año, usar el actual
    IF @mesObjetivo IS NULL
        SET @mesObjetivo = MONTH(GETDATE())
    IF @anioObjetivo IS NULL
        SET @anioObjetivo = YEAR(GETDATE())
        
    -- Validar que la fecha no sea anterior a la actual
    DECLARE @fechaObjetivo DATE = DATEFROMPARTS(@anioObjetivo, @mesObjetivo, 1)
    DECLARE @fechaActual DATE = DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)
    
    -- Verificar si la fecha es anterior a la actual
    IF @fechaObjetivo < @fechaActual
    BEGIN
        DECLARE @mensajeError VARCHAR(200) = 
            'Error: No se pueden agregar horarios para fechas pasadas. ' +
            'Mes/Año objetivo: ' + CAST(@mesObjetivo AS VARCHAR) + '/' + CAST(@anioObjetivo AS VARCHAR) + 
            '. Fecha actual: ' + FORMAT(GETDATE(), 'MM/yyyy')
        RAISERROR(@mensajeError, 16, 1)
        RETURN
    END

    -- Verificar si el idDentista existe
    IF EXISTS (SELECT 1 FROM Dentista WHERE idDentista = @idDentista)
    BEGIN
        -- Verificar el rango de horas permitido
        IF @horaInicio >= '08:00:00' AND @horaFin <= '22:00:00'
        BEGIN
            INSERT INTO HorarioDentista (
                idDentista, 
                diaSemana, 
                horaInicio, 
                horaFin,
                mesObjetivo,
                anioObjetivo
            )
            VALUES (
                @idDentista, 
                @diaSemana, 
                @horaInicio, 
                @horaFin,
                @mesObjetivo,
                @anioObjetivo
            );
            
            PRINT 'Horario agregado exitosamente para ' + 
                  FORMAT(DATEFROMPARTS(@anioObjetivo, @mesObjetivo, 1), 'MMMM yyyy')
        END
        ELSE
        BEGIN
            RAISERROR('Error: El horario debe estar entre las 8:00 y las 22:00.', 16, 1)
            RETURN
        END
    END
    ELSE
    BEGIN
        RAISERROR('Error: idDentista no existe.', 16, 1)
        RETURN
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarPaciente]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_AgregarPaciente]
    @dni VARCHAR(8),
    @correo VARCHAR(100),
    @contraseña VARCHAR(100),
    @nombres VARCHAR(100),
    @apellidos VARCHAR(100),
    @telefono VARCHAR(15),
    @fechaNacimiento DATE,
    @direccion VARCHAR(200),
    @sexo INT,              -- 0: Femenino, 1: Masculino
    @estado INT             -- 1: Activo, 0: Inactivo
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Insertar en la tabla Usuario
        INSERT INTO Usuario (dni, correo, contraseña, nombres, apellidos, telefono, fechaNacimiento, direccion, sexo, rol, estado)
        VALUES (@dni, @correo, @contraseña, @nombres, @apellidos, @telefono, @fechaNacimiento, @direccion, @sexo, 'Paciente', @estado);
        
        -- Obtener el idUsuario recién creado
        DECLARE @idUsuario INT = SCOPE_IDENTITY();
        
        -- Insertar en la tabla Paciente
        INSERT INTO Paciente (idUsuario)
        VALUES (@idUsuario);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarRecepcionista]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AgregarRecepcionista]
    @dni VARCHAR(8),
    @correo VARCHAR(100),
    @contraseña VARCHAR(100),
    @nombres VARCHAR(100),
    @apellidos VARCHAR(100),
    @telefono VARCHAR(15),
    @fechaNacimiento DATE,
    @direccion VARCHAR(200),
    @sexo INT,              -- 0: Femenino, 1: Masculino
    @estado INT             -- 1: Activo, 0: Inactivo
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Insertar en la tabla Usuario
        INSERT INTO Usuario (dni, correo, contraseña, nombres, apellidos, telefono, fechaNacimiento, direccion, sexo, rol, estado)
        VALUES (@dni, @correo, @contraseña, @nombres, @apellidos, @telefono, @fechaNacimiento, @direccion, @sexo, 'Recepcionista', @estado);

        -- Obtener el idUsuario recién creado
        DECLARE @idUsuario INT = SCOPE_IDENTITY();
        
        -- Aquí se pueden agregar inserciones adicionales en otras tablas si es necesario para el rol de Recepcionista
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarTratamiento]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AgregarTratamiento]
    @nombre VARCHAR(100),
    @descripcion VARCHAR(250),
    @precio DECIMAL(10, 2)
AS
BEGIN
    -- Insertar en la tabla Tratamiento
    INSERT INTO Tratamiento (nombre, descripcion, precio)
    VALUES (@nombre, @descripcion, @precio);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_CancelarCita]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_CancelarCita]
    @idCita INT
AS
BEGIN
    DECLARE @idDentista INT, @fechaCita DATE, @horaCita TIME;

    -- Obtener detalles de la cita
    SELECT @idDentista = idDentista, @fechaCita = fechaCita, @horaCita = horaCita
    FROM Cita
    WHERE idCita = @idCita;

    -- Actualizar el estado de la cita a cancelada
    UPDATE Cita
    SET estado = 0
    WHERE idCita = @idCita;

    -- Revisar si existe otra cita activa en el mismo horario
    IF NOT EXISTS (
        SELECT 1 
        FROM Cita 
        WHERE idDentista = @idDentista AND fechaCita = @fechaCita AND horaCita = @horaCita AND estado = 1
    )
    BEGIN
        -- Actualizar disponibilidad a "Disponible" si no hay otras citas activas
        UPDATE Disponibilidad
        SET estado = 1
        WHERE idDentista = @idDentista AND fecha = @fechaCita AND hora = @horaCita;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarCitas]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ConsultarCitas]
    @idPaciente INT
AS
BEGIN
    SELECT 
        C.idCita,
        C.fechaCita,
        CONVERT(VARCHAR(5), C.horaCita, 108)AS 'hora' ,
        U.nombres + ' ' + U.apellidos AS 'nombreDentista',  -- Nombres y apellidos desde la tabla Usuario
        E.nombre AS 'especialidadDentista',
        C.motivoCita AS 'motivoCita',
        C.estado 
    FROM 
        Cita C
    INNER JOIN 
        Dentista D ON C.idDentista = D.idDentista
    INNER JOIN 
        Usuario U ON D.idUsuario = U.idUsuario  -- Se une con la tabla Usuario para obtener los nombres y apellidos
    INNER JOIN 
        Especialidad E ON D.especialidad = E.idEspecialidad
    WHERE 
        C.idPaciente = @idPaciente
    ORDER BY 
        C.fechaCita DESC, C.horaCita;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarDentista]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ConsultarDentista] 
    @idDentista INT
AS
BEGIN
    SELECT 
        D.idDentista, 
        U.idUsuario, 
        U.dni, 
        U.nombres, 
        U.apellidos, 
        U.telefono, 
        U.correo, 
        U.direccion, 
        U.fechaNacimiento, 
        U.sexo, 
        U.estado AS estadoUsuario, 
        U.contraseña,
		D.especialidad,
		D.estado AS estadoDentista
    FROM Dentista D
    INNER JOIN Usuario U ON D.idUsuario = U.idUsuario
    WHERE D.idDentista = @idDentista AND U.rol = 'Dentista';
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarDisponibilidad]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ConsultarDisponibilidad]
    @idDentista INT,
    @fecha DATE
AS
BEGIN
    SELECT hora, estado
    FROM Disponibilidad
    WHERE idDentista = @idDentista AND fecha = @fecha AND estado = 1;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarDisponibilidadDetallada]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ConsultarDisponibilidadDetallada]
    @idDentista INT
AS
BEGIN
    -- Establecer el idioma en español para la sesión actual
    SET LANGUAGE Spanish;

    SELECT 
        DATENAME(WEEKDAY, D.fecha) AS 'diaSemana',
        D.fecha AS 'fecha',
        D.hora AS 'hora',
        D.estado AS 'estado'
    FROM 
        Disponibilidad D
    WHERE 
        D.idDentista = @idDentista
        AND D.estado = 1  -- Filtrar solo las horas disponibles
    ORDER BY 
        D.fecha ASC,   -- Ordenamos por la fecha para seguir el orden del calendario
        D.hora ASC;    -- Dentro de cada fecha, ordenamos por la hora
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarHistoriaClinica]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ConsultarHistoriaClinica]
    @idPaciente INT
AS
BEGIN
    SELECT 
        H.fecha ,
        H.descripcion ,
        H.observaciones ,
        T.nombre AS 'NombreTratamiento',
        U.nombres + ' ' + U.apellidos AS 'NombreDentista',
        C.fechaCita ,
        CONVERT(VARCHAR(5), C.horaCita, 108) AS 'horaCita',
        C.motivoCita ,
        C.estado
    FROM 
        Historia H
    INNER JOIN 
        Tratamiento T ON H.idTratamiento = T.idTratamiento
    INNER JOIN 
        Dentista D ON H.idDentista = D.idDentista
    INNER JOIN 
        Usuario U ON D.idUsuario = U.idUsuario  -- Aseguramos obtener los nombres desde Usuario
    INNER JOIN 
        Cita C ON H.idCita = C.idCita
    WHERE 
        H.idPaciente = @idPaciente
    ORDER BY 
        H.fecha DESC; -- Ordena por fecha para mostrar primero las entradas más recientes
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarHistoriaClinicaPorCita]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ConsultarHistoriaClinicaPorCita]
    @idCita INT
AS
BEGIN
    SELECT 
        h.idHistoria,
        h.idPaciente,
        h.idDentista,
        h.idTratamiento,
        h.idCita,
        h.descripcion,
        h.observaciones,
        h.fecha
    FROM 
        Historia h
    WHERE 
        h.idCita = @idCita;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarPaciente]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ConsultarPaciente]
    @idPaciente INT
AS
BEGIN
    SELECT 
        P.idPaciente, 
        U.idUsuario, 
        U.dni, 
        U.nombres, 
        U.apellidos, 
        U.telefono, 
        U.correo, 
        U.direccion, 
        U.fechaNacimiento, 
        U.sexo, 
        U.estado,
		u.contraseña	
    FROM Paciente P
    INNER JOIN Usuario U ON P.idUsuario = U.idUsuario
    WHERE P.idPaciente = @idPaciente AND U.rol = 'Paciente';
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarDentista]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EliminarDentista]
    @idDentista INT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Obtener el idUsuario relacionado al dentista
        DECLARE @idUsuario INT;
        SELECT @idUsuario = idUsuario FROM Dentista WHERE idDentista = @idDentista;

        -- Actualizar el estado del Usuario a inactivo (estado = 0)
        UPDATE Usuario
        SET estado = 0
        WHERE idUsuario = @idUsuario;

        -- Actualizar el estado del Dentista a inactivo (estado = 0)
        UPDATE Dentista
        SET estado = 0
        WHERE idDentista = @idDentista;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarDisponibilidadDentista]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE   PROCEDURE [dbo].[sp_EliminarDisponibilidadDentista]
    @idDentista INT,
    @Fecha DATE,
    @Hora TIME,
    @Motivo NVARCHAR(255) = NULL  -- Motivo opcional
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar si la hora ya está reservada
    IF EXISTS (
        SELECT 1 
        FROM Disponibilidad d
        JOIN Cita c ON c.fechaCita = d.fecha 
            AND c.horaCita = d.hora 
            AND c.idDentista = d.idDentista
        WHERE d.idDentista = @idDentista 
          AND d.Fecha = @Fecha 
          AND d.Hora = @Hora
    )
    BEGIN
        RAISERROR('No se puede eliminar un horario que ya está reservado.', 16, 1);
        RETURN;
    END;

    -- Si no está reservado, proceder con la eliminación
    UPDATE Disponibilidad
    SET Eliminado = 1,
        MotivoEliminacion = @Motivo
    WHERE idDentista = @idDentista 
      AND Fecha = @Fecha 
      AND Hora = @Hora;

    PRINT 'Horario marcado como eliminado con éxito.';
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarDisponibilidadDia]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE   PROCEDURE [dbo].[sp_EliminarDisponibilidadDia] 
    @idDentista INT,
    @Fecha DATE,
    @Motivo NVARCHAR(255) = NULL -- Motivo opcional
AS
BEGIN
    SET NOCOUNT ON;
    -- Eliminar solo la disponibilidad del día que está disponible
    UPDATE Disponibilidad
    SET Eliminado = 1,
        MotivoEliminacion = @Motivo
    WHERE idDentista = @idDentista
      AND Fecha = @Fecha
      AND Eliminado = 0  -- Solo afecta a los no eliminados previamente
      AND NOT EXISTS (
          SELECT 1 
          FROM Cita c 
          WHERE c.fechaCita = Disponibilidad.Fecha 
            AND c.horaCita = Disponibilidad.hora 
            AND c.idDentista = Disponibilidad.idDentista 
            AND (c.estado = 1 OR c.estado = 2)  -- No eliminar si está reservada O completada
      )
      AND CAST(Disponibilidad.fecha AS DATETIME) + CAST(Disponibilidad.hora AS DATETIME) >= GETDATE();
    
    PRINT 'Solo la disponibilidad disponible del día ha sido marcada como eliminada con éxito.';
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarHorarioDentistaDia]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_EliminarHorarioDentistaDia]
    @idDentista INT,
    @Fecha DATE
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        -- Verificar si existen citas para ese día
        IF EXISTS (
            SELECT 1 
            FROM Cita 
            WHERE idDentista = @idDentista 
              AND fechaCita = @Fecha
        )
        BEGIN
            RAISERROR('No se puede eliminar el horario del día porque hay citas programadas.', 16, 1);
            RETURN;
        END
        -- Eliminar todos los registros del día
        DELETE FROM Disponibilidad
        WHERE idDentista = @idDentista 
          AND Fecha = @Fecha;
        PRINT 'Horarios del día eliminados con éxito.';
    END TRY
    BEGIN CATCH
        PRINT 'Error al eliminar los horarios del día.';
        THROW;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarHorarioDentistaHora]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE   PROCEDURE [dbo].[sp_EliminarHorarioDentistaHora]
    @idDentista INT,
    @Fecha DATE,
    @Hora TIME
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        -- Verificar si existe una cita para esa hora
        IF EXISTS (
            SELECT 1 
            FROM Cita 
            WHERE idDentista = @idDentista 
              AND fechaCita = @Fecha 
              AND horaCita = @Hora
        )
        BEGIN
            RAISERROR('No se puede eliminar un horario que tiene una cita programada.', 16, 1);
            RETURN;
        END

        -- Eliminar el registro directamente
        DELETE FROM Disponibilidad
        WHERE idDentista = @idDentista 
          AND Fecha = @Fecha 
          AND Hora = @Hora;

        PRINT 'Horario eliminado con éxito.';
    END TRY
    BEGIN CATCH
        PRINT 'Error al eliminar el horario.';
        THROW;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarPaciente]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EliminarPaciente]
    @idPaciente INT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Obtener el idUsuario relacionado al paciente
        DECLARE @idUsuario INT;
        SELECT @idUsuario = idUsuario FROM Paciente WHERE idPaciente = @idPaciente;

        -- Actualizar el estado del Usuario a inactivo (estado = 0)
        UPDATE Usuario
        SET estado = 0
        WHERE idUsuario = @idUsuario;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarCitasPorDentistaYFecha]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_ListarCitasPorDentistaYFecha]
    @idDentista INT,
    @fechaInicio DATETIME = NULL,
    @fechaFin DATETIME = NULL
AS
BEGIN
    -- Si no se especifican fechas, se usa el día actual completo
    SET @fechaInicio = ISNULL(@fechaInicio, CAST(GETDATE() AS DATE)); -- Día actual a las 00:00
    SET @fechaFin = ISNULL(@fechaFin, DATEADD(DAY, 1, @fechaInicio) - 1 / 86400); -- Día actual a las 23:59:59
    
    SELECT 
        C.idCita, 
        C.fechaCita, 
        C.horaCita, 
        C.motivoCita, 
        C.estado,
		P.idPaciente,
        U.nombres AS PacienteNombres, 
        U.apellidos AS PacienteApellidos,
        U.dni AS PacienteDNI,
        U.correo AS PacienteCorreo,
        U.telefono AS PacienteTelefono,
        U.fechaNacimiento AS PacienteFechaNacimiento,
        -- Cálculo de la edad del paciente
        DATEDIFF(YEAR, U.fechaNacimiento, GETDATE()) - 
        CASE 
            WHEN MONTH(U.fechaNacimiento) > MONTH(GETDATE()) 
                 OR (MONTH(U.fechaNacimiento) = MONTH(GETDATE()) AND DAY(U.fechaNacimiento) > DAY(GETDATE())) 
            THEN 1 ELSE 0 
        END AS PacienteEdad,  
        U.direccion AS PacienteDireccion,
        U.sexo AS PacienteSexo
    FROM 
        Cita C
    INNER JOIN 
        Paciente P ON C.idPaciente = P.idPaciente
    INNER JOIN 
        Usuario U ON P.idUsuario = U.idUsuario
    WHERE 
        C.idDentista = @idDentista
        AND C.fechaCita BETWEEN @fechaInicio AND @fechaFin
        AND C.estado IN (1, 2)  -- Solo muestra citas Reservadas (1) o Completadas (2)
    ORDER BY 
        C.fechaCita, 
        C.horaCita;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarDentistas]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ListarDentistas]
AS
BEGIN
    SELECT 
        D.idDentista, 
        U.idUsuario, 
        U.dni, 
        U.nombres, 
        U.apellidos, 
        U.telefono, 
        U.correo, 
        U.direccion, 
        U.fechaNacimiento, 
		DATEDIFF(YEAR, U.fechaNacimiento, GETDATE()) - 
        CASE 
            WHEN MONTH(U.fechaNacimiento) > MONTH(GETDATE()) 
                 OR (MONTH(U.fechaNacimiento) = MONTH(GETDATE()) AND DAY(U.fechaNacimiento) > DAY(GETDATE())) 
            THEN 1 ELSE 0 END AS edad,   -- Cálculo de la edad
        U.sexo, 
        U.estado AS estadoUsuario, 
        E.nombre AS especialidad,
        D.estado AS estadoDentista
    FROM 
        Dentista D
    INNER JOIN 
        Usuario U ON D.idUsuario = U.idUsuario
    INNER JOIN 
        Especialidad E ON D.especialidad = E.idEspecialidad
    ORDER BY 
        U.apellidos, U.nombres;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarDentistasPorEspecialidadDetallado]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ListarDentistasPorEspecialidadDetallado]
    @idEspecialidad INT
AS
BEGIN
    SELECT 
        U.idUsuario,
        U.dni,
        U.nombres,
        U.apellidos,
        U.telefono,
        U.correo,
        U.direccion,
        U.fechaNacimiento,
        DATEDIFF(YEAR, U.fechaNacimiento, GETDATE()) 
            - CASE 
                WHEN MONTH(U.fechaNacimiento) > MONTH(GETDATE()) 
                    OR (MONTH(U.fechaNacimiento) = MONTH(GETDATE()) AND DAY(U.fechaNacimiento) > DAY(GETDATE())) 
                THEN 1 
                ELSE 0 
              END AS edad,
        U.sexo,
        U.rol,
        U.estado AS estadoUsuario,
        D.idDentista,
        D.estado AS estadoDentista,
        E.nombre AS especialidadNombre,
        E.descripcion AS especialidadDescripcion
    FROM 
        Dentista D
    INNER JOIN 
        Usuario U ON D.idUsuario = U.idUsuario
    INNER JOIN 
        Especialidad E ON D.especialidad = E.idEspecialidad
    WHERE 
        E.idEspecialidad = @idEspecialidad
    ORDER BY 
        U.apellidos, U.nombres;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarEspecialidades]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ListarEspecialidades]
AS
BEGIN
    SELECT * 
    FROM Especialidad
    ORDER BY idEspecialidad ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarPacientes]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_ListarPacientes]
AS
BEGIN
    SELECT 
        P.idPaciente, 
        U.idUsuario, 
        U.dni, 
        U.nombres, 
        U.apellidos, 
        U.telefono, 
        U.correo, 
        U.direccion, 
        U.fechaNacimiento, 
        DATEDIFF(YEAR, U.fechaNacimiento, GETDATE()) - 
        CASE 
            WHEN MONTH(U.fechaNacimiento) > MONTH(GETDATE()) 
                 OR (MONTH(U.fechaNacimiento) = MONTH(GETDATE()) AND DAY(U.fechaNacimiento) > DAY(GETDATE())) 
            THEN 1 ELSE 0 END AS edad,   -- Cálculo de la edad
        U.sexo, 
        U.estado
    FROM Paciente P
    INNER JOIN Usuario U ON P.idUsuario = U.idUsuario
    WHERE U.rol = 'Paciente'
    ORDER BY U.apellidos, U.nombres;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarTratamientos]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_ListarTratamientos]
AS
BEGIN
    SELECT 
        idTratamiento,
        nombre,
        descripcion,
        precio
    FROM 
        Tratamiento;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_LoginPaciente]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_LoginPaciente]
    @dni VARCHAR(8),
    @contraseña VARCHAR(100)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Usuario WHERE dni = @dni AND contraseña = @contraseña AND rol = 'Paciente')
    BEGIN
        SELECT 'Login exitoso' AS Mensaje;
    END
    ELSE
    BEGIN
        SELECT 'DNI o contraseña incorrecta' AS Mensaje;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerCalendarioDisponible]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- Procedimiento para mostrar solo horarios disponibles
CREATE  PROCEDURE [dbo].[sp_ObtenerCalendarioDisponible] 
    @idDentista INT = NULL,
    @FechaInicio DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Si no se proporciona fecha, usar la fecha actual
    IF @FechaInicio IS NULL
        SET @FechaInicio = GETDATE();
        
    -- Obtener el inicio de la semana (Lunes)
    DECLARE @InicioSemana DATE = DATEADD(DAY, -(DATEPART(WEEKDAY, @FechaInicio) + 5) % 7, @FechaInicio);
    
    -- Obtener fin de semana (Domingo)
    DECLARE @FinSemana DATE = DATEADD(DAY, 6, @InicioSemana);
    
    -- Obtener la fecha y hora actual
    DECLARE @FechaActual DATE = CAST(GETDATE() AS DATE);
    DECLARE @HoraActual TIME = CAST(GETDATE() AS TIME);
    
    -- Consulta directa a la tabla de Disponibilidad
    WITH DisponibilidadActual AS (
        SELECT 
            d.fecha AS Fecha,
            DATENAME(WEEKDAY, d.fecha) AS DiaSemana,
            FORMAT(d.fecha, 'dd/MM/yyyy') AS FechaFormateada,
            d.hora AS Hora,
            d.idDentista
        FROM Disponibilidad d
        LEFT JOIN Cita c ON c.fechaCita = d.fecha 
                       AND c.horaCita = d.hora 
                       AND c.idDentista = d.idDentista
        WHERE d.estado = 1  -- Solo disponibilidades activas
          AND d.Eliminado = 0  -- Excluir horarios eliminados
          AND (c.estado IS NULL OR c.estado != 1)   -- Excluir citas activas
          AND d.fecha BETWEEN @InicioSemana AND @FinSemana  -- Solo fechas de la semana seleccionada
          AND (@idDentista IS NULL OR d.idDentista = @idDentista)  -- Filtro por dentista si se especifica
          AND (
            -- Para fechas futuras, mostrar todas las horas
            d.fecha > @FechaActual 
            OR 
            -- Para el día actual, mostrar horas que aún no han pasado
            (d.fecha = @FechaActual AND d.hora > @HoraActual)
          )
    )
    -- Formato final del calendario
    SELECT 
        Hora,
        MAX(CASE WHEN DiaSemana = 'Monday' THEN FechaFormateada END) AS Lunes,
        MAX(CASE WHEN DiaSemana = 'Tuesday' THEN FechaFormateada END) AS Martes,
        MAX(CASE WHEN DiaSemana = 'Wednesday' THEN FechaFormateada END) AS Miércoles,
        MAX(CASE WHEN DiaSemana = 'Thursday' THEN FechaFormateada END) AS Jueves,
        MAX(CASE WHEN DiaSemana = 'Friday' THEN FechaFormateada END) AS Viernes,
        MAX(CASE WHEN DiaSemana = 'Saturday' THEN FechaFormateada END) AS Sábado,
        MAX(CASE WHEN DiaSemana = 'Sunday' THEN FechaFormateada END) AS Domingo
    FROM DisponibilidadActual
    GROUP BY Hora
    ORDER BY Hora;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerCalendarioSemanal]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ObtenerCalendarioSemanal]
    @FechaInicio DATE = NULL,
    @idDentista INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Si no se proporciona fecha, usar la fecha actual
    IF @FechaInicio IS NULL
        SET @FechaInicio = GETDATE();

    -- Obtener el inicio de la semana (Lunes)
    DECLARE @InicioSemana DATE = DATEADD(DAY, -(DATEPART(WEEKDAY, @FechaInicio) + 5) % 7, @FechaInicio);
    
    -- Obtener fin de semana (Domingo)
    DECLARE @FinSemana DATE = DATEADD(DAY, 6, @InicioSemana);

    -- Crear tabla temporal para las horas del día
    CREATE TABLE #Horas (
        Hora TIME
    );

    -- Insertar horas de trabajo típicas (8 AM a 8 PM)
    INSERT INTO #Horas (Hora)
    SELECT DATEADD(HOUR, number, '08:00')
    FROM master.dbo.spt_values
    WHERE type = 'P' 
    AND number BETWEEN 0 AND 12;

    -- Consulta principal que genera la vista de calendario
    WITH CalendarioBase AS (
        SELECT 
            d.fecha AS Fecha,
            DATENAME(WEEKDAY, d.fecha) AS DiaSemana,
            FORMAT(d.fecha, 'dd/MM/yyyy') AS FechaFormateada,
            h.Hora,
            d.idDentista,
            CASE 
                WHEN d.estado = 1 THEN 'Disponible'
                WHEN d.estado = 0 THEN 'Reservado'
                ELSE 'No disponible'
            END AS Estado,
            u.nombres + ' ' + u.apellidos AS NombreDentista,
            CASE 
                WHEN c.idCita IS NOT NULL THEN 
                    'Cita: ' + COALESCE(up.nombres + ' ' + up.apellidos, 'Sin asignar')
                ELSE NULL 
            END AS DetalleCita
        FROM #Horas h
        CROSS JOIN (
            SELECT DATEADD(DAY, number, @InicioSemana) AS fecha
            FROM master.dbo.spt_values
            WHERE type = 'P' 
            AND number BETWEEN 0 AND DATEDIFF(DAY, @InicioSemana, @FinSemana)
        ) AS fechas
        LEFT JOIN Disponibilidad d ON d.fecha = fechas.fecha 
            AND d.hora = h.Hora 
            AND (@idDentista IS NULL OR d.idDentista = @idDentista)
        LEFT JOIN Dentista den ON d.idDentista = den.idDentista
        LEFT JOIN Usuario u ON den.idUsuario = u.idUsuario
        LEFT JOIN Cita c ON d.fecha = c.fechaCita 
            AND d.hora = c.horaCita 
            AND d.idDentista = c.idDentista
        LEFT JOIN Paciente p ON c.idPaciente = p.idPaciente
        LEFT JOIN Usuario up ON p.idUsuario = up.idUsuario
    )
    -- Formato final del calendario
    SELECT 
        Hora,
        MAX(CASE WHEN DiaSemana = 'Monday' 
            THEN CONCAT(FechaFormateada, CHAR(13), NombreDentista, ' - ', Estado, CHAR(13), DetalleCita) 
        END) AS Lunes,
        MAX(CASE WHEN DiaSemana = 'Tuesday' 
            THEN CONCAT(FechaFormateada, CHAR(13), NombreDentista, ' - ', Estado, CHAR(13), DetalleCita) 
        END) AS Martes,
        MAX(CASE WHEN DiaSemana = 'Wednesday' 
            THEN CONCAT(FechaFormateada, CHAR(13), NombreDentista, ' - ', Estado, CHAR(13), DetalleCita) 
        END) AS Miércoles,
        MAX(CASE WHEN DiaSemana = 'Thursday' 
            THEN CONCAT(FechaFormateada, CHAR(13), NombreDentista, ' - ', Estado, CHAR(13), DetalleCita) 
        END) AS Jueves,
        MAX(CASE WHEN DiaSemana = 'Friday' 
            THEN CONCAT(FechaFormateada, CHAR(13), NombreDentista, ' - ', Estado, CHAR(13), DetalleCita) 
        END) AS Viernes,
        MAX(CASE WHEN DiaSemana = 'Saturday' 
            THEN CONCAT(FechaFormateada, CHAR(13), NombreDentista, ' - ', Estado, CHAR(13), DetalleCita) 
        END) AS Sábado,
        MAX(CASE WHEN DiaSemana = 'Sunday' 
            THEN CONCAT(FechaFormateada, CHAR(13), NombreDentista, ' - ', Estado, CHAR(13), DetalleCita) 
        END) AS Domingo
    FROM CalendarioBase
    GROUP BY Hora
    ORDER BY Hora;

    -- Limpiar tabla temporal
    DROP TABLE #Horas;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerHorarioDentista]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[sp_ObtenerHorarioDentista]
    @idDentista INT = NULL,
    @FechaInicio DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Si no se proporciona fecha, usar la fecha actual
    IF @FechaInicio IS NULL
        SET @FechaInicio = GETDATE();

    -- Obtener el inicio de la semana (Lunes)
    DECLARE @InicioSemana DATE = DATEADD(DAY, -(DATEPART(WEEKDAY, @FechaInicio) + 5) % 7, @FechaInicio);
    
    -- Obtener fin de semana (Domingo)
    DECLARE @FinSemana DATE = DATEADD(DAY, 6, @InicioSemana);

    WITH HorarioDentista AS (
        SELECT 
            d.fecha AS Fecha,
            DATENAME(WEEKDAY, d.fecha) AS DiaSemana,
            FORMAT(d.fecha, 'dd/MM/yyyy') AS FechaFormateada,
            d.hora AS Hora,
            d.idDentista
        FROM Disponibilidad d
        WHERE d.fecha BETWEEN @InicioSemana AND @FinSemana
          AND d.Eliminado = 0  -- Excluir horarios eliminados
          AND (@idDentista IS NULL OR d.idDentista = @idDentista)
    )

    -- Formato final del calendario
    SELECT 
        Hora,
        MAX(CASE WHEN DiaSemana = 'Monday' THEN FechaFormateada END) AS Lunes,
        MAX(CASE WHEN DiaSemana = 'Tuesday' THEN FechaFormateada END) AS Martes,
        MAX(CASE WHEN DiaSemana = 'Wednesday' THEN FechaFormateada END) AS Miércoles,
        MAX(CASE WHEN DiaSemana = 'Thursday' THEN FechaFormateada END) AS Jueves,
        MAX(CASE WHEN DiaSemana = 'Friday' THEN FechaFormateada END) AS Viernes,
        MAX(CASE WHEN DiaSemana = 'Saturday' THEN FechaFormateada END) AS Sábado,
        MAX(CASE WHEN DiaSemana = 'Sunday' THEN FechaFormateada END) AS Domingo
    FROM HorarioDentista
    GROUP BY Hora
    ORDER BY Hora;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerHorarioDetallado]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_ObtenerHorarioDetallado] 
    @idDentista INT = NULL,
    @FechaInicio DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Si no se proporciona fecha, usar la fecha actual
    IF @FechaInicio IS NULL
        SET @FechaInicio = GETDATE();

    -- Declarar variable para la fecha y hora actual
    DECLARE @FechaHoraActual DATETIME = GETDATE();

    -- Obtener el inicio de la semana (Lunes)
    DECLARE @InicioSemana DATE = DATEADD(DAY, -(DATEPART(WEEKDAY, @FechaInicio) + 5) % 7, @FechaInicio);

    -- Obtener fin de semana (Domingo)
    DECLARE @FinSemana DATE = DATEADD(DAY, 6, @InicioSemana);

    WITH HorarioCompleto AS (
        SELECT 
            d.fecha AS Fecha,
            DATENAME(WEEKDAY, d.fecha) AS DiaSemana,
            d.hora AS Hora,
            d.idDentista,
            CASE 
                WHEN d.Eliminado = 1 THEN CONCAT('Eliminado - Motivo: ', d.MotivoEliminacion)
                WHEN c.estado = 2 THEN CONCAT('Completado - ', CONCAT(u.nombres, ' ', u.apellidos))
                WHEN c.estado = 1 AND CAST(d.fecha AS DATETIME) + CAST(d.hora AS DATETIME) < @FechaHoraActual 
                    THEN 'Expirado'
                WHEN c.estado = 1 THEN 'Reservado'
                WHEN CAST(d.fecha AS DATETIME) + CAST(d.hora AS DATETIME) < @FechaHoraActual 
                    THEN 'Hora Vencida'
                ELSE 'Disponible'
            END AS EstadoCita,
            CONCAT(u.nombres, ' ', u.apellidos) AS NombrePaciente,
            FORMAT(d.fecha, 'dd/MM/yyyy') + 
            CASE 
                WHEN d.Eliminado = 1 THEN CONCAT(' - Eliminado - Motivo: ', d.MotivoEliminacion)
                WHEN c.estado = 2 THEN CONCAT(' - Completado - ', CONCAT(u.nombres, ' ', u.apellidos))
                WHEN c.estado = 1 AND CAST(d.fecha AS DATETIME) + CAST(d.hora AS DATETIME) < @FechaHoraActual 
                    THEN CONCAT(' - Expirado - ', CONCAT(u.nombres, ' ', u.apellidos))
                WHEN c.estado = 1 THEN CONCAT(' - Reservado - ', CONCAT(u.nombres, ' ', u.apellidos))
                WHEN CAST(d.fecha AS DATETIME) + CAST(d.hora AS DATETIME) < @FechaHoraActual 
                    THEN ' - Expirado'
                ELSE ' - Disponible'
            END AS InfoCompleta
        FROM Disponibilidad d
        LEFT JOIN Cita c ON c.fechaCita = d.fecha 
            AND c.horaCita = d.hora 
            AND c.idDentista = d.idDentista
        LEFT JOIN Paciente p ON c.idPaciente = p.idPaciente
        LEFT JOIN Usuario u ON p.idUsuario = u.idUsuario
        WHERE d.fecha BETWEEN @InicioSemana AND @FinSemana
          AND (@idDentista IS NULL OR d.idDentista = @idDentista)
    )
    -- Formato final del calendario
    SELECT 
        Hora,
        MAX(CASE WHEN DiaSemana = 'Monday' THEN InfoCompleta END) AS Lunes,
        MAX(CASE WHEN DiaSemana = 'Tuesday' THEN InfoCompleta END) AS Martes,
        MAX(CASE WHEN DiaSemana = 'Wednesday' THEN InfoCompleta END) AS Miércoles,
        MAX(CASE WHEN DiaSemana = 'Thursday' THEN InfoCompleta END) AS Jueves,
        MAX(CASE WHEN DiaSemana = 'Friday' THEN InfoCompleta END) AS Viernes,
        MAX(CASE WHEN DiaSemana = 'Saturday' THEN InfoCompleta END) AS Sábado,
        MAX(CASE WHEN DiaSemana = 'Sunday' THEN InfoCompleta END) AS Domingo
    FROM HorarioCompleto
    GROUP BY Hora
    ORDER BY Hora;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_RegistrarPago]    Script Date: 13/04/2025 16:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_RegistrarPago]
    @idPaciente INT,
    @monto DECIMAL(10, 2),
    @metodoPago VARCHAR(50)
AS
BEGIN
    INSERT INTO Pago (idPaciente, fecha, monto, metodoPago)
    VALUES (@idPaciente, GETDATE(), @monto, @metodoPago);
END;
GO
USE [master]
GO
ALTER DATABASE [ClinicaDental_DB] SET  READ_WRITE 
GO
