select id_temporada,count(*)
from reservacion,TEMPORADA 
where not exists (select * from cancelacion where id_reserv_cancelacion=id_reservacion) and
	  fecha_lleg_reservacion >= fecha_i_temporada and
	  fecha_lleg_reservacion <=fecha_f_temporada and 
      fecha_lleg_reservacion between '2020-01-01' and '2020-12-31'
group by id_temporada


