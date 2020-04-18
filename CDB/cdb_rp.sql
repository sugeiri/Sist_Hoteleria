CREATE TABLE rp_cliente(
	ID_CLIENTE char(5) NOT NULL PRIMARY KEY,
	Nombre_Tercero			varchar(100) NOT NULL,
	ESTADO_CLIENTE CHAR(1) NOT NULL,
	ID_T_CLIENTE       char(5) NOT NULL,
	LIM_CRED_CLIENTE DECIMAL(12,2) NOT NULL
)

CREATE TABLE rp_empleado(
	ID_empleado char(5) NOT NULL PRIMARY KEY,
	Nombre_Tercero			varchar(100) NOT NULL,
	ESTADO_empleado CHAR(1) NOT NULL,
	ID_T_empleado       char(5) NOT NULL,
	FECHA_I_EMPLEADO date NOT NULL
)


CREATE TABLE rp_usuario(
	id_Usuario char(10) NOT NULL PRIMARY KEY,
	Nombre_Tercero			varchar(100) NOT NULL,
	Estado_Usuario CHAR(1) NOT NULL,
	Tipo_Usuario       char(5) NOT NULL
)
