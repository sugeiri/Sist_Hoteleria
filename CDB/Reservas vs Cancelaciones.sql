select 'Res',count(*)
from reservacion 
where not exists (select * from cancelacion where id_reserv_cancelacion=id_reservacion) and
      fecha_lleg_reservacion between '2020-01-01' and '2020-12-31'
Union All
select 'Can',count(*)
from reservacion 
where exists (select * from cancelacion where id_reserv_cancelacion=id_reservacion) and
      fecha_lleg_reservacion between '2020-01-01' and '2020-12-31'


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

