INSERT INTO `modulo` (`pk_id_modulo`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(3, 'Modulo SCM', 'Encargado de la Logistica e Inventarios', 1);



INSERT INTO `login` (`pk_id_login`, `usuario_login`, `contraseña_login`, `nombreCompleto_login`, `estado_login`) VALUES
(1, 'Karen', 'karen123', 'Karen Roldan', 1);
 


INSERT INTO `permiso` (`pk_id_permiso`, `insertar_permiso`, `modificar_permiso`, `eliminar_permiso`, `consultar_permiso`, `imprimir_permiso`) VALUES
(1, 1, 1, 1, 1, 1);



INSERT INTO `aplicacion` (`pk_id_aplicacion`, `fk_id_modulo`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(2301, 3, 'Linea Producto', 'lINEA', 1),
(2302, 3, 'Categoria Producto', 'Categoria', 1),
(2303, 3, 'Producto', 'Producto', 1),
(2304, 3, 'Departamento', 'Deptos', 1),
(2305, 3, 'Municipio', 'Muni depto', 1),
(2306, 3, 'Ruta', 'Rutas', 1),
(2307, 3, 'Proveedores', 'Nada', 1),
(2308, 3, 'Telefono Proveedor', 'Telefonos ', 1),
(2309, 3, 'Correo Proveedor', 'Correos', 1),
(2310, 3, 'Pais', 'Pais de Proveedor', 1),
(2311, 3, 'Marca', 'Contiene la Marca de Vehiculos', 1),
(2312, 3, 'Vehiculo', 'Vehiculos usados para traslados', 1),
(2313, 3, 'Bodega', 'Localizacion de bodegas', 1),
(2314, 3, 'Encargado Bodega', 'Empleado dentro del area de bodegas', 1),
(2315, 3, 'Tipo de Movimiento', 'Movimientos de Inventarios', 1),
(2316, 3, 'Compras y Pedidos', 'Gestión de Órdenes de Compra y Pedido', 1),
(2318, 3, 'Fabrica', 'Fabrica', 1);



INSERT INTO `aplicacion_usuario` (`pk_id_aplicacion_usuario`, `fk_idlogin_aplicacion_usuario`, `fk_idaplicacion_aplicacion_usuario`, `fk_idpermiso_aplicacion_usuario`) VALUES
(15, 1, 2301, 1),
(12, 1, 2302, 1),
(17, 1, 2303, 1),
(13, 1, 2304, 1),
(16, 1, 2305, 1),
(7, 1, 2306, 1),
(8, 1, 2307, 1),
(9, 1, 2308, 1),
(10, 1, 2309, 1),
(11, 1, 2310, 1),
(4, 1, 2311, 1),
(6, 1, 2312, 1),
(1, 1, 2313, 1),
(3, 1, 2314, 1),
(5, 1, 2315, 1),
(2, 1, 2316, 1),
(14, 1, 2318, 1);

