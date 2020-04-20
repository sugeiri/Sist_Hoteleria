
CREATE TABLE HOTEL(
	id_hotel				char(5) not null primary key,
	descr_hotel				varchar(300) not null,
	Direccion_hotel			varchar(max) not null,
	tel_hotel				varchar(12) not null,
	a_cancelacion_hotel		char(1) not null,
)
Create table Tipo_Identificacion(
	Id_Tipo_Ident		char(5) NOT NULL PRIMARY KEY,
	Descr_Tipo_Ident	varchar(30) NOT NULL,
	Estado_Tipo_Ident	char(1) NOT NULL
)

CREATE TABLE Tercero(
	id_Tercero				char(10) NOT NULL PRIMARY KEY,
	Nombre_Tercero			varchar(100) NOT NULL,
	ID_T_Identif_Tercero	char(5) Not null Constraint FK_Tercero_T_Identif FOREIGN KEY REFERENCES Tipo_Identificacion(Id_Tipo_Ident),
	Cedula_Tercero			varchar(20) NOT NULL,
	Fecha_Nac_Tercero		date NOT NULL,
	Sexo_Tercero			char(1) NOT NULL,
	Estado_Tercero			char(1) NOT NULL
)
CREATE TABLE PAIS(
	id_pais		char(5) NOT NULL PRIMARY KEY,
	descr_pais	VARCHAR(50) NOT NULL,
	estado_pais CHAR(1) NOT NULL
)
CREATE TABLE PROVINCIA(
	id_provincia		char(5) NOT NULL PRIMARY KEY,
	descr_provincia		VARCHAR(50) NOT NULL,
	id_pais_provincia	char(5) NOT NULL Constraint FK_PROVINCIA_PAIS FOREIGN KEY REFERENCES PAIS(id_pais),
	estado_provincia	CHAR(1) NOT NULL
)
CREATE TABLE MUNICIPIO(
	id_municipio		char(5) NOT NULL PRIMARY KEY,
	descr_municipio		VARCHAR(50) NOT NULL,
	id_prov_municipio	char(5) NOT NULL Constraint FK_MUNICIPIO_PROV FOREIGN KEY REFERENCES PROVINCIA(ID_PROVINCIA),
	estado_municipio	CHAR(1) NOT NULL
)

CREATE TABLE DIRECCION(
	id_Tercero_Direccion	char(10) NOT NULL Constraint FK_Tercero_Direccion FOREIGN KEY REFERENCES Tercero(id_Tercero),
	id_mun_Direccion		char(5) NOT NULL Constraint FK_MUNICIPIO_Direccion FOREIGN KEY REFERENCES MUNICIPIO(id_municipio),
	Direccion				varchar(MAX) NOT NULL,
	TIPO_DIRECCION			VARCHAR(2) NOT NULL,
	N_LINEA_DIRECCION		INT NOT NULL,
	ESTADO_DIRECCION		CHAR(1) NOT NULL
	PRIMARY KEY(id_Tercero_Direccion,TIPO_DIRECCION,N_LINEA_DIRECCION)	
)

CREATE TABLE EMAIL(
	id_Tercero_Email	char(10) NOT NULL Constraint FK_Tercero_Email FOREIGN KEY REFERENCES Tercero(id_Tercero),
	Email				varchar(MAX) NOT NULL,
	TIPO_Email			VARCHAR(2) NOT NULL,
	N_LINEA_Email		INT NOT NULL,
	ESTADO_Email		CHAR(1) NOT NULL
	PRIMARY KEY(id_Tercero_Email,N_LINEA_Email)	
)
CREATE TABLE TELEFONO(
	id_Tercero_Tel	char(10) NOT NULL Constraint FK_Tercero_Tel FOREIGN KEY REFERENCES Tercero(id_Tercero),
	Numero_Tel		varchar(20) NOT NULL,
	TIPO_Tel		VARCHAR(2) NOT NULL,
	N_LINEA_Tel	    INT NOT NULL,
	ESTADO_Tel	    CHAR(1) NOT NULL
	PRIMARY KEY(id_Tercero_Tel,Numero_Tel,N_LINEA_Tel)	
)
CREATE TABLE Tipo_Usuario(
	id_T_Usuario			char(5) NOT NULL PRIMARY KEY,
	Descripcion_T_Usuario	varchar(30)  NOT NULL,
	Nivel_Acceso_T_Usuario	varchar(3) NOT NULL,
	Estado_T_Usuario		char(1) NOT NULL
)
CREATE TABLE Usuario(
	id_Usuario			char(10) NOT NULL PRIMARY KEY,
	id_Tercero_Usuario	char(10) NOT NULL Constraint FK_Usuario_Tercero FOREIGN KEY REFERENCES Tercero(id_Tercero),
	Tipo_Usuario		char(5) NOT NULL Constraint FK_Usuario_Tipo_Usuario FOREIGN KEY REFERENCES Tipo_Usuario(id_T_Usuario),
	password_Usuario	varchar(MAX) NOT NULL,
	Estado_Usuario		char(1) NOT NULL
)

CREATE TABLE Permisos_Adi(
	id_opcion		char(5) NOT NULL PRIMARY KEY,
	Descr_opcion	varchar(30)  NOT NULL,
	Estado_Opcion	char(1) NOT NULL
)
CREATE TABLE Usuario_Permisos_Adi
(
	id_Usuario_UP char(10) NOT NULL Constraint FK_Usuario_UP_Usuario FOREIGN KEY REFERENCES Usuario(id_Usuario),
	id_Permiso_UP char(5) NOT NULL Constraint FK_Permiso_UP_Permiso FOREIGN KEY REFERENCES Permisos_Adi(id_opcion),
	PRIMARY KEY(id_Usuario_UP,id_Permiso_UP)
)
CREATE TABLE TIPO_CLIENTE(
	ID_T_CLIENTE_TC char(5) NOT NULL PRIMARY KEY,
	DESCR_TC VARCHAR(50) NOT NULL,
	ESTADO_TC CHAR(1) NOT NULL
)
CREATE TABLE CLIENTE(
	ID_CLIENTE char(5) NOT NULL PRIMARY KEY,
	ID_TERCERO_CLIENTE char(10) NOT NULL Constraint FK_Tercero_CLIENTE FOREIGN KEY REFERENCES Tercero(id_Tercero),
	ID_T_CLIENTE       char(5) NOT NULL Constraint FK_T_CLIENTE_TC FOREIGN KEY REFERENCES TIPO_CLIENTE(ID_T_CLIENTE_TC),
	LIM_CRED_CLIENTE DECIMAL(12,2) NOT NULL,
	--SALDO_CLIENTE DECIMAL(12,2) NOT NULL,
	ESTADO_CLIENTE CHAR(1) NOT NULL
)
CREATE TABLE TIPO_EMPLEADO(
	ID_T_EMPLEADO_TE char(5) NOT NULL PRIMARY KEY,
	DESCR_TE VARCHAR(50) NOT NULL,
	ESTADO_TE CHAR(1) NOT NULL
)
CREATE TABLE EMPLEADO(
	ID_EMPLEADO char(5) NOT NULL PRIMARY KEY,
	ID_TERCERO_EMPLEADO char(10) NOT NULL Constraint FK_Tercero_EMPLEADO FOREIGN KEY REFERENCES Tercero(id_Tercero),
	ID_T_EMPLEADO       char(5) NOT NULL Constraint FK_T_EMPLEADO_TE FOREIGN KEY REFERENCES TIPO_EMPLEADO(ID_T_EMPLEADO_TE),
	FECHA_I_EMPLEADO    DATE NOT NULL,
	ESTADO_EMPLEADO     CHAR(1) NOT NULL
)

create table servicio( 
	id_servicio char(5) not null primary key,
	descr_servicio varchar(50) not null, --Desayuno, restaurante, wifi
	costo_servicio decimal(12,2) not null,
	estado_servicio char(1) not null
)
create table tipo_alojamiento 
(
	id_t_alojamiento char(5) not null primary key,
	descr_t_alojamiento varchar(100) not null,
	costo_t_alojamiento decimal(12,2) not null,
	estado_t_alojamiento char(1) not null	
)
create table talojamiento_servicio
(
	id_t_alojamiento_tas char(5) not null Constraint FK_talojamiento_tas FOREIGN KEY REFERENCES tipo_alojamiento(id_t_alojamiento),
	id_servicio_tas char(5) not null Constraint FK_thabitacion_tas FOREIGN KEY REFERENCES servicio(id_servicio),
	primary key(id_t_alojamiento_tas,id_servicio_tas)
)
create table cama(
	id_cama char(5) not null primary key,
	descr_cama varchar(50) not null,
	capacidad_cama int not null,
	estado_cama char(1) not null
)
create table tipo_habitacion(
	id_t_hab char(5) not null primary key,
	descr_t_hab varchar(50) not null,
	capacidad_hab int not null,
	costo_hab	 decimal(12,2) not null,
	estado_t_hab char(1) not null
)

create table thabitacion_cama(
	id_t_hab_thc char(5) not null Constraint FK_thabitacion_thc FOREIGN KEY REFERENCES tipo_habitacion(id_t_hab),
	id_cama_thc char(5) not null Constraint FK_cama_thc FOREIGN KEY REFERENCES cama(id_cama),
	Cantidad_camas int not null,--DA
	primary key(id_t_hab_thc,id_cama_thc)
)
create table caracteristica(
	id_caracteristica char(5) not null primary key,
	descr_caracteristica varchar(100) not null, --vistal al mar, etc
	estado_caracteristica char(1) not null,
)

create table thab_caracteristica
(
	id_t_hab_thcar char(5) not null Constraint FK_thabitacion_thcar FOREIGN KEY REFERENCES tipo_habitacion(id_t_hab),
	id_caracteristica_thcar char(5) not null Constraint FK_talojamiento_thcar FOREIGN KEY REFERENCES caracteristica(id_caracteristica),
	primary key(id_t_hab_thcar,id_caracteristica_thcar)
)

create table edificio(
	id_edificio char(5) not null primary key,
	descr_edificio varchar(100) not null,
	cant_nivel_edificio int not null,
	estado_edificio char(1) not null
)
create table habitacion(
	id_habitacion char(5) not null primary key,
	descr_habitacion varchar(100) not null,
	t_habitacion		  char(5) not null Constraint FK_thabitacion_hab FOREIGN KEY REFERENCES tipo_habitacion(id_t_hab),
	edificio_habitacion  char(5) not null Constraint FK_edificio_hab FOREIGN KEY REFERENCES edificio(id_edificio),
	piso_habitacion		int not null,
	estado_habitacion char(1) not null
)

create table tipo_mantenimiento(
	id_t_mantenimiento char(5) not null primary key,
	descr_t_mantenimiento varchar(100) not null, --(limpieza, revisar aire etc)
	estado_t_mantenimiento char(1) not null
) 
create table mantenimiento(
	id_mantenimiento int not null primary key,
	id_hab_mantenimiento  char(5) not null Constraint FK_habitacion_mant FOREIGN KEY REFERENCES habitacion(id_habitacion),
	fecha_cre_mantenimiento datetime not null,
	fecha_mod_mantenimiento datetime not null,
	estado_mantenimiento char(1) not null
)
create table mantenimiento_det(
	id_mantenimiento_det int not null Constraint FK_mant_det FOREIGN KEY REFERENCES mantenimiento(id_mantenimiento),
	id_t_mant_det char(5) not null Constraint FK_tipo_mant_det FOREIGN KEY REFERENCES tipo_mantenimiento(id_t_mantenimiento),
	id_empleado_det	char(5) not null Constraint FK_EMPLEADO_mant_det FOREIGN KEY REFERENCES EMPLEADO(ID_EMPLEADO),
	estado_mantenimiento char(1) not null,
	primary key(id_mantenimiento_det,id_t_mant_det)
)

create table reservacion(
	id_reservacion int not null primary key,
	id_cliente		char(5) not null Constraint FK_cliente_res FOREIGN KEY REFERENCES cliente(id_cliente),
	id_t_aloj_reservacion char(5) not null Constraint FK_talojamiento_res FOREIGN KEY REFERENCES tipo_alojamiento(id_t_alojamiento),
	fecha_lleg_reservacion datetime not null,
	fecha_sal_reservacion datetime not null,
	Monto_apagar		decimal(12,2) not null,
	estado_reservacion	char(1) not null,
	creado_por_reservacion char(10) not null,
	fecha_cre_reservacion datetime not null,
	mod_por_reservacion char(10) not null,
	fecha_mod_reservacion datetime not null,
)
create table reservacion_det(
	id_reservacion_det int not null Constraint FK_reserv_det FOREIGN KEY REFERENCES reservacion(id_reservacion),
	id_thab_reserv_det char(5) not null Constraint FK_thab_reserv_det FOREIGN KEY REFERENCES tipo_habitacion(id_t_hab),
	cant_reserv_det    int not null,
	primary key(id_reservacion_det,id_thab_reserv_det)
)

create table cancelacion(
	id_cancelacion int not null primary key,
	id_reserv_cancelacion int not null  Constraint FK_reserv_canc FOREIGN KEY REFERENCES reservacion(id_reservacion),
	fecha_cancelacion		datetime not null,
	motivo_cancelacion		varchar(MAX) not null,
	id_archivo_cancelacion	char(10) not null Constraint FK_archivo_canc FOREIGN KEY REFERENCES archivo(id_archivo),
	creado_por_cancelacion char(10) not null,
	estado_cancelacion		char(1) not null,
	mod_por_cancelacion	char(10) not null,
	fecha_mod_cancelacion   datetime not null
)
create table alojamiento(
	id_alojamiento int not null primary key,
	id_reserv_alojamiento int not null Constraint FK_reserv_aloj FOREIGN KEY REFERENCES reservacion(id_reservacion),
	ing_por_alojamiento char(10) not null,
	fecha_i_alojamiento datetime not null,
	sal_por_alojamiento char(10) not null,
	fecha_s_alojamiento datetime not null,
	estado_alojamiento char(1) not null
)

create table alojamiento_det(
	id_alojamiento_det int not null Constraint FK_aloj_det FOREIGN KEY REFERENCES alojamiento(id_alojamiento),
	id_hab_det		   char(5) not null Constraint FK_hab_aloj_det FOREIGN KEY REFERENCES habitacion(id_habitacion),
	id_clie_det		   char(5) not null Constraint FK_clie_aloj_det FOREIGN KEY REFERENCES cliente(ID_CLIENTE),
	primary key(id_alojamiento_det,id_hab_det,id_clie_det)
)

--CXC CLIENTE
CREATE TABLE NOTA_CREDITO_CLIENTE(
	ID_NCC INT  NOT NULL PRIMARY KEY,
	ID_CLIENTE_NCC char(5)  NOT NULL CONSTRAINT FK_CLIENTE_NCC FOREIGN KEY REFERENCES CLIENTE(ID_CLIENTE),
	MONTO_NCC DECIMAL(12,2) NOT NULL,
	FECHA_NCC DATE NOT NULL,
	ESTADO_NCC CHAR(1) NOT NULL,
	CREADO_P_NCC CHAR(10) NOT NULL,
	FECHA_C_NCC DATETIME NOT NULL,
	MOD_P_NCC CHAR(10) NOT NULL,
	FECHA_M_NCC DATETIME NOT NULL
	
)
CREATE TABLE NOTA_CREDITO_DETALLE(
	ID_NCC_DET     INT  NOT NULL,
	ID_RESERV_NCC_DET INT  NOT NULL,
	VALOR_NCC_DET DECIMAL(12,2) NOT NULL,
	BALANCE_NCC_DET DECIMAL(12,2) NOT NULL,
	FECHA_NCC_DET DATETIME NOT NULL,
	PRIMARY KEY(ID_NCC_DET,ID_RESERV_NCC_DET),
	CONSTRAINT FK_RESERV_NCC_DET FOREIGN KEY(ID_RESERV_NCC_DET) REFERENCES RESERVACION(ID_RESERVACION)
)
CREATE TABLE NOTA_CREDITO_ABONO
(
	ID_NCC_AB INT  NOT NULL,
	ID_RESERV_NCC_AB INT  NOT NULL,
	N_ABONO_NCC_AB INT  NOT NULL,
	FECHA_ABONO_NCC_AB DATETIME NOT NULL,
	BALANCE_ANT_NCC_AB DECIMAL(12,2) NOT NULL,
	ABONO_NCC_AB DECIMAL(12,2) NOT NULL,
	BALANCE_ACT_NCC_AB DECIMAL(12,2) NOT NULL,
	PRIMARY KEY(ID_NCC_AB,ID_RESERV_NCC_AB,N_ABONO_NCC_AB),
	CONSTRAINT FK_RESERV_NCC_AB FOREIGN KEY(ID_RESERV_NCC_AB) REFERENCES RESERVACION(ID_RESERVACION)
)

CREATE TABLE TEMPORADA(
	id_temporada char(5) not null primary key,
	descr_temporada varchar(100) not  null,
	fecha_i_temporada date not null,
	fecha_f_temporada date not null,
	estado_temporada char(1) not null
)
CREATE TABLE Oferta
(	id_oferta char(5) not null primary key,
	descr_oferta varchar(200) not null,
	id_temp_oferta char(5) not null,
	estado_oferta	char(1) not null
	CONSTRAINT FK_temporada_oferta FOREIGN KEY(id_temp_oferta) REFERENCES TEMPORADA(id_temporada)
)
--POR TIPO ALOJAMIENTO
create table oferta_det_01
(
	id_oferta_det01 char(5) not null CONSTRAINT FK_oferta_d01 FOREIGN KEY REFERENCES Oferta(id_oferta),
	id_t_aloj_det01 char(5) not null Constraint FK_talojamiento_of_det01 FOREIGN KEY REFERENCES tipo_alojamiento(id_t_alojamiento),
	descuento_det01 decimal(12,2) not null,
	primary key(id_oferta_det01,id_t_aloj_det01)
)
-- POR TIPO CLIENTE
create table oferta_det_02
(
	id_oferta_det02			 char(5) not null  CONSTRAINT FK_oferta_d02 FOREIGN KEY REFERENCES Oferta(id_oferta),
	id_t_cliente_det02       char(5) NOT NULL Constraint FK_t_cliente_det02 FOREIGN KEY REFERENCES TIPO_CLIENTE(ID_T_CLIENTE_TC),
	descuento_det02			 decimal(12,2) not null,
	primary key(id_oferta_det02,id_t_cliente_det02)
)
-- POR CANTIDAD DE ALOJAMIENTOS DE CLIENTE
create table oferta_det_03
(
	id_oferta_det03   char(5) not null  CONSTRAINT FK_oferta_d03 FOREIGN KEY REFERENCES Oferta(id_oferta),
	c_ini_aloj_det03  int not null,
	c_fin_aloj_det03  int not null,
	descuento_det03   decimal(12,2) not null,
	primary key(id_oferta_det03,c_ini_aloj_det03,c_fin_aloj_det03)
)
create table tipo_archivo
(
	id_t_archivo int not null primary key,
	descr_t_archivo varchar(100) not null,
	estado_t_archivo char(1) not null
)

create table archivo(
	id_archivo				int not null primary key,
	id_tarchivo				int not null  CONSTRAINT FK_tipo_archivo FOREIGN KEY REFERENCES tipo_archivo(id_t_archivo),
	ruta_archivo			varchar(500) not null,
	comentario_01_archivo	varchar(2000) not null,
	comentario_02_archivo	varchar(2000) not null,
	estado_archivo			char(1) not null,
	CREADO_P_archivo		CHAR(10) NOT NULL,
	FECHA_C_archivo			DATETIME NOT NULL,
	MOD_P_archivo			CHAR(10) NOT NULL,
	FECHA_M_archivo			DATETIME NOT NULL
)







