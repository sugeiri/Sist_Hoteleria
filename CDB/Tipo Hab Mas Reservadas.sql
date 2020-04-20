select Top 10 id_thab_reserv_det,count(*)
from reservacion, reservacion_det 
where not exists (select * from cancelacion where id_reserv_cancelacion=id_reservacion) and
      fecha_lleg_reservacion between '2020-01-01' and '2020-12-31'
	  and id_reservacion=id_reservacion_det
group by id_thab_reserv_det


insert into reservacion_det values((select Max(id_reservacion_det)+1from reservacion_det),1,2)
insert into reservacion_det values((select Max(id_reservacion_det)+1from reservacion_det),2,4)
insert into reservacion_det values((select Max(id_reservacion_det)+1from reservacion_det),2,1)
insert into reservacion_det values((select Max(id_reservacion_det)+1from reservacion_det),1,1)
insert into reservacion_det values((select Max(id_reservacion_det)+1from reservacion_det),2,10)
insert into reservacion_det values((select Max(id_reservacion_det)+1from reservacion_det),1,1)
insert into reservacion_det values((select Max(id_reservacion_det)+1from reservacion_det),1,2)
insert into reservacion_det values((select Max(id_reservacion_det)+1from reservacion_det),2,4)
insert into reservacion_det values((select Max(id_reservacion_det)+1from reservacion_det),1,2)
insert into reservacion_det values((select Max(id_reservacion_det)+1from reservacion_det),2,4)
insert into reservacion_det values((select Max(id_reservacion_det)+1from reservacion_det),1,2)

