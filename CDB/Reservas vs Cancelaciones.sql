select 'Res',count(*)
from reservacion 
where not exists (select * from cancelacion where id_reserv_cancelacion=id_reservacion) and
      fecha_lleg_reservacion between '2020-01-01' and '2020-12-31'
Union All
select 'Can',count(*)
from reservacion 
where exists (select * from cancelacion where id_reserv_cancelacion=id_reservacion) and
      fecha_lleg_reservacion between '2020-01-01' and '2020-12-31'




