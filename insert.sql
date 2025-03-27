DELIMITER $$
create function insertar(disponible varchar(2), 
    no_de_ucarto int(2), tamanio varchar(2), categoria varchar(10), 
    direccion varchar(20), precio int(4),propietario_idpropietario int (2),
    banio varchar(2), internet varchar(2), cablevicion varchar (2), 
    amueblado varchar(2), agua_caliente varchar(2), nombre_imagen varchar(25))

    returns int (2)
    begin 
    declare idcuarto int (1);
    declare idservicio int (1);
    declare idimagen int (1);

    set idcuarto = 0;
    set idservicio = 0;
    set idimagen = 0;

    insert into Cuarto values(idcuarto,disponible,no_de_ucarto, tamanio,categoria, direccion, precio, propietario_idpropietario);

    insert into Sevicios values (idservicio, banio,internet,cablevicion,amueblado,agua_caliente,last_insert_id() );

    insert into imagenes values (idimagen,nombre_imagen,last_insert_id());

    return true;
    end$$
DELIMITER;
