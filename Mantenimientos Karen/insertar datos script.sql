select * from pais;
INSERT INTO `pais` (`nombre_pais`, `capital_pais`, `estado_pais`) VALUES ('Guatemala', 'Guatemala', 1);
INSERT INTO `pais` (`nombre_pais`, `capital_pais`, `estado_pais`) VALUES ('Salvador', 'San Salvador', 1);
INSERT INTO `pais` (`nombre_pais`, `capital_pais`, `estado_pais`) VALUES ('Honduras', 'Tegucigalpa', 1);
INSERT INTO `pais` (`nombre_pais`, `capital_pais`, `estado_pais`) VALUES ('Costa Rica', 'San José', 1);

select * from proveedor;
INSERT INTO `proveedor` (`fk_id_pais`, `razon_social_proveedor`, `representante_legal_proveedor`, `nit_proveedor`, `estado_proveedor`) 
VALUES (1, 'COLCHO.S.A.','Maria Lopez','123654-K', 1);
INSERT INTO `proveedor` (`fk_id_pais`, `razon_social_proveedor`, `representante_legal_proveedor`, `nit_proveedor`, `estado_proveedor`) 
VALUES (2, 'COLCOL.S.A.','Juan Gal','587469-H', 1);
INSERT INTO `proveedor` (`fk_id_pais`, `razon_social_proveedor`, `representante_legal_proveedor`, `nit_proveedor`, `estado_proveedor`) 
VALUES (1, 'CAMA.S.A.','Laura Molina','987456-F', 1);

select * from correo_proveedor;
INSERT INTO `correo_proveedor` (`fk_id_proveedor`, `correo_correo_proveedor`, `estado_correo_proveedor`) VALUES (1, 'colcho@gmail.com', 1);
INSERT INTO `correo_proveedor` (`fk_id_proveedor`, `correo_correo_proveedor`, `estado_correo_proveedor`) VALUES (1, 'colcho2@gmail.com', 1);
INSERT INTO `correo_proveedor` (`fk_id_proveedor`, `correo_correo_proveedor`, `estado_correo_proveedor`) VALUES (2, 'colcol@gmail.com', 1);
INSERT INTO `correo_proveedor` (`fk_id_proveedor`, `correo_correo_proveedor`, `estado_correo_proveedor`) VALUES (3, 'cama@gmail.com', 1);

select * from telefono_proveedor;
INSERT INTO `telefono_proveedor` (`fk_id_proveedor`, `telefono_telefono_proveedor`, `estado_telefono_proveedor`) VALUES (1, '22547896', 1);
INSERT INTO `telefono_proveedor` (`fk_id_proveedor`, `telefono_telefono_proveedor`, `estado_telefono_proveedor`) VALUES (2, '23687453', 1);
INSERT INTO `telefono_proveedor` (`fk_id_proveedor`, `telefono_telefono_proveedor`, `estado_telefono_proveedor`) VALUES (3, '29230107', 1);

select * from ruta;
INSERT INTO `ruta` (`origen_ruta`, `destino_ruta`, `descripcion_ruta`, `estado_ruta`) VALUES ('6ta avenida 8-03 zona 5','5ta avenida 20-12 zona 21','Ninguna', 1);
INSERT INTO `ruta` (`origen_ruta`, `destino_ruta`, `descripcion_ruta`, `estado_ruta`) VALUES ('2da avenida 5-15 zona 6','9na avenida 30-22 zona 15','Ninguna', 1);
INSERT INTO `ruta` (`origen_ruta`, `destino_ruta`, `descripcion_ruta`, `estado_ruta`) VALUES ('3ra avenida 70-29 zona 8','6ta avenida 10-11 zona 16','Ninguna', 1);
