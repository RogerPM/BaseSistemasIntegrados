create view Menu_X_Usuario 
as 
select e.IdEmpresa,a.NombreUsuario,a.Contrasena,d.* ,c.*
from Seguridad.Usuario a inner join Seguridad.Perfil b on a.IdPerfil = b.IdPerfil inner join Seguridad.Permiso c on a.IdPerfil = c.IdPerfil and b.IdPerfil = b.IdPerfil inner join Seguridad.Menu d on c.IdMenu = d.IdMenu inner join Seguridad.MenuPorEmpresa e on e.IdMenu = c.IdMenu and e.IdMenu = d.IdMenu
go



insert into Seguridad.Permiso values(1,1,1,1,1,0,0) 
go 
insert into Seguridad.Permiso values(1,2,2,1,1,0,0) 
go 
insert into Seguridad.Permiso values(1,3,3,1,1,0,0) 
go 
insert into Seguridad.Permiso values(1,4,4,1,1,0,0) 
go 
insert into Seguridad.Permiso values(1,5,5,1,1,0,0) 
go 
insert into Seguridad.Permiso values(1,7,6,1,1,0,0) 
go 
insert into Seguridad.Permiso values(1,8,7,1,1,0,0) 
go 
insert into Seguridad.Permiso values(1,9,8,1,1,0,0) 
go 
insert into Seguridad.Permiso values(1,10,9,1,1,0,0) 
go 
insert into Seguridad.Permiso values(1,11,11,1,1,0,0) 
go 
insert into Seguridad.Permiso values(1,12,12,1,1,0,0) 
go 
insert into Seguridad.Permiso values(1,13,13,1,1,0,0) 
go 
insert into Seguridad.Permiso values(1,14,14,1,1,0,0) 
go 
insert into Seguridad.Permiso values(1,15,15,1,1,0,0) 
go
