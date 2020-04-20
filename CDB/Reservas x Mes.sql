
select MONTH(fecha_lleg_reservacion) As MES,
	   count(*) as Cant 
from reservacion 
where not exists (select * from cancelacion where id_reserv_cancelacion=id_reservacion)
and fecha_lleg_reservacion between '2020-01-01' and '2020-12-31'
group by MONTH(fecha_lleg_reservacion)
