delimiter $$

CREATE DEFINER=`pydcom_michael`@`%.%.%.%` PROCEDURE `operar_Tabla`(in tabla varchar(20),in parm varchar(20),in t_accion varchar(1),in att varchar(20), in cod int)
BEGIN
    case 
		when tabla = "Categorias" then
			case
				when t_accion = "C" then
					case
						when att = "Codigo" then 
							select c1.idCategoriaM, c1.nombre, c1.descripcion, c2.nombre as Padre, c1.eliminado
							from categoriam c1 inner join categoriam c2 on c1.idCategoriaDepende = c2.idCategoria
							where c1.idcategoriaM = parm and c1.eliminado = 0;
						when att = "Nombre" then
							select c1.idCategoriaM, c1.nombre, c1.descripcion, c2.nombre as Padre, c1.eliminado
							from categoriam c1 inner join categoriam c2 on c1.idCategoriaDepende = c2.idCategoria
							where c1.nombre = parm and c1.eliminado = 0;
						when att = "Descripcion" then
							select c1.idCategoriaM, c1.nombre, c1.descripcion, c2.nombre as Padre, c1.eliminado
							from categoriam c1 inner join categoriam c2 on c1.idCategoriaDepende = c2.idCategoria
							where c1.descripcion = parm and c1.eliminado = 0;
						when att = "Padre" then
							select c1.idCategoriaM, c1.nombre, c1.descripcion, c2.nombre as Padre, c1.eliminado
							from categoriam c1 inner join categoriam c2 on c1.idCategoriaDepende = c2.idCategoria
							where c2.nombre = parm and c1.eliminado = 0;
					end case;		
				when t_accion = "M" then
					case
						when att = "Nombre" then update categoriam set nombre = parm where idcategoriaM = cod;
						when att = "Descripcion" then update categoriam set descripcion = parm where idcategoriaM = cod;
						when att = "Padre" then update categoriam set idCategoriaDepende = parm where idcategoriaM = cod;							
					end case;
				when t_accion = "E" then
					update categoriam set eliminado = parm where idcategoriaM = cod;
			end case;
		when tabla = "Existencias" then
			case
				when t_accion = "C" then
					case
						when att = "Codigo" then select * from existencias where eliminado = 0;
						when att = "CodigoBar" then select * from codInternoMercaderia where eliminado = 0;
						when att = "PrecioCompra" then select * from precioAdquisicion where eliminado = 0;
						when att = "PrecioVenta" then select * from precioUnitario where eliminado = 0;
						when att = "FechaCompra" then select * from fechaAdquisicion where eliminado = 0;
						when att = "FechaVencimiento" then select * from fechaVencimiento where eliminado = 0;
						when att = "Estado" then select * from estadoMercaderia where eliminado = 0;
						when att = "Ubicacion" then select * from Ubicacion where eliminado = 0;
						when att = "NroMovimiento" then select * from idMovimiento where eliminado = 0;
					end case;
				when t_accion = "M" then
					case
						when att = "PrecioCompra" then update existencias set precioAdquisicion = parm where idMercaderia = cod;
						when att = "PrecioVenta" then update existencias set precioUnitario = parm where idMercaderia = cod;
						when att = "FechaCompra" then update existencias set fechaAdquisicion = parm where idMercaderia = cod;
						when att = "FechaVencimiento" then update existencias set fechaVencimiento = parm where idMercaderia = cod;
						when att = "Estado" then update existencias set estadoMercaderia = parm where idMercaderia = cod;
						when att = "Ubicacion" then update existencias set Ubicacion = parm where idMercaderia = cod;
						when att = "NroMovimiento" then update existencias set idMovimiento = parm where idMercaderia = cod;
					end case;
				when t_accion = "E" then
					update existencias set eliminado = parm where idMercaderia = cod;
			end case;
		when tabla = "factores" then
			case
				when t_accion = "C" then
					case
						when att = "Codigo" then select * from factores where idfactores = parm  and eliminado=0;
                        
						when att = "Tabla"     then select * from factores where tabla = parm  and eliminado=0;
						when att = "Concepto" then select * from factores where concepto = parm  and eliminado=0;
						when att = "Monto" then select * from factores where monto = parm  and eliminado=0;
						when att="ctabla" then select * from factores where t=parm  and eliminado=0;
						when att = "Todos" then select * from factores where eliminado=0; 
					end case;
				when t_accion = "M" then
					case
						when att = "Tabla" then update factores set tabla = parm where idFactores = cod;
						when att = "Concepto" then update factores set concepto = parm where idFactores = cod;
						when att = "Monto" then update factores set monto = parm where idFactores = cod;
					end case;
				when t_accion = "E" then update factores set eliminado = parm where idFactores = cod;
			end case;            
		when tabla = "mercaderia" then
			case
				when t_accion = "C" then
					case
						when att = "Codigo" then
							select m.idMercaderia, m.StockDisponible, m.StockMinimo, m.PrecioCompra, m.PrecioVenta, m.Nombre, um.valor, c.nombre
							from mercaderia m inner join unidadmedida um on m.idUndMedida = um.idUnidadMedida
							inner join categoriam c on m.idCategoria = c.idcategoriaM 
							where m.idMercaderia = parm and m.eliminado = 0;
						when att = "StockDisponible" then
							select m.idMercaderia, m.StockDisponible, m.StockMinimo, m.PrecioCompra, m.PrecioVenta, m.Nombre, um.valor, c.nombre
							from mercaderia m inner join unidadmedida um on m.idUndMedida = um.idUnidadMedida
							inner join categoriam c on m.idCategoria = c.idcategoriaM
							where m.StockDisponible = parm and m.eliminado = 0;
						when att = "StockMinimo" then
							select m.idMercaderia, m.StockDisponible, m.StockMinimo, m.PrecioCompra, m.PrecioVenta, m.Nombre, um.valor, c.nombre
							from mercaderia m inner join unidadmedida um on m.idUndMedida = um.idUnidadMedida
							inner join categoriam c on m.idCategoria = c.idcategoriaM
							where m.StockMinimo = parm and m.eliminado = 0;
						when att = "PrecioCompra" then
							select m.idMercaderia, m.StockDisponible, m.StockMinimo, m.PrecioCompra, m.PrecioVenta, m.Nombre, um.valor, c.nombre
							from mercaderia m inner join unidadmedida um on m.idUndMedida = um.idUnidadMedida
							inner join categoriam c on m.idCategoria = c.idcategoriaM
							where m.PrecioCompra = parm and m.eliminado = 0;
						when att = "PrecioVenta" then
							select m.idMercaderia, m.StockDisponible, m.StockMinimo, m.PrecioCompra, m.PrecioVenta, m.Nombre, um.valor, c.nombre
							from mercaderia m inner join unidadmedida um on m.idUndMedida = um.idUnidadMedida
							inner join categoriam c on m.idCategoria = c.idcategoriaM
							where m.PrecioVenta = parm and m.eliminado = 0;
						when att = "Nombre" then
							select m.idMercaderia, m.StockDisponible, m.StockMinimo, m.PrecioCompra, m.PrecioVenta, m.Nombre, um.valor, c.nombre
							from mercaderia m inner join unidadmedida um on m.idUndMedida = um.idUnidadMedida
							inner join categoriam c on m.idCategoria = c.idcategoriaM
							where m.Nombre = parm and m.eliminado = 0;
						when att = "UnidadMedida" then
							select m.idMercaderia, m.StockDisponible, m.StockMinimo, m.PrecioCompra, m.PrecioVenta, m.Nombre, um.valor, c.nombre
							from mercaderia m inner join unidadmedida um on m.idUndMedida = um.idUnidadMedida
							inner join categoriam c on m.idCategoria = c.idcategoriaM
							where um.valor = parm and m.eliminado = 0;
						when att = "Categoria" then
							select m.idMercaderia, m.StockDisponible, m.StockMinimo, m.PrecioCompra, m.PrecioVenta, m.Nombre, um.valor, c.nombre
							from mercaderia m inner join unidadmedida um on m.idUndMedida = um.idUnidadMedida
							inner join categoriam c on m.idCategoria = c.idcategoriaM
							where c.nombre = parm and m.eliminado = 0;
					end case;
				when t_accion = "M" then
					case
						when att = "StockDisponible" then update mercaderia set StockDisponible = parm where idMercaderia = cod;
						when att = "StockMinimo" then update mercaderia set StockMinimo = parm where idMercaderia = cod;
						when att = "PrecioCompra" then update mercaderia set PrecioCompra = parm where idMercaderia = cod;
						when att = "PrecioVenta" then update mercaderia set PrecioVenta = parm where idMercaderia = cod;
						when att = "Nombre" then update mercaderia set Nombre = parm where idMercaderia = cod;
						when att = "UnidadMedida" then update mercaderia set idUndMedida = parm where idMercaderia = cod;
						when att = "Categoria" then update mercaderia set idCategoria = parm where idMercaderia = cod;
					end case;
			end case;
		when tabla = "movimiento" then
			case 
        when t_accion = "C" then
            case
                when  att = "Codigo" then
                    select 
                        m.idMovimiento,
                        m.tipoMovimiento,
                        m.cantidadItemsMovimiento,
                        m.codInterno,
                        m.tipoComprobante,
                        m.montoPago,
                        v.primerNombre,
                        v.segundoNombre,
                        v.nroIdentificacion,
                        c.primerNombre,
                        c.segundoNombre,
                        c.nroItentificacion,
                        o.factorOfertas
                    from movimiento m inner join persona v on m.persona_idPersona = p.idPersona inner join persona c on m.persona_idPersona1 = c.idPersona inner join ofertas o on m.ofertas_idOfertas = o.idOfertas
                    where m.idMovimiento = parm  and eliminado=0;
                when att = "TipoMov" then
                    select 
                        m.idMovimiento,
                        m.tipoMovimiento,
                        m.cantidadItemsMovimiento,
                        m.codInterno,
                        m.tipoComprobante,
                        m.montoPago,
                        v.primerNombre,
                        v.segundoNombre,
                        v.nroIdentificacion,
                        c.primerNombre,
                        c.segundoNombre,
                        c.nroItentificacion,
                        o.factorOfertas
                    from movimiento m inner join persona v on m.persona_idPersona = p.idPersona inner join persona c on m.persona_idPersona1 = c.idPersona inner join ofertas o on m.ofertas_idOfertas = o.idOfertas
                    where m.tipoMovimiento = parm  and eliminado=0;
                when att = "CantidadItems" then
                    select 
                        m.idMovimiento,
                        m.tipoMovimiento,
                        m.cantidadItemsMovimiento,
                        m.codInterno,
                        m.tipoComprobante,
                        m.montoPago,
                        v.primerNombre,
                        v.segundoNombre,
                        v.nroIdentificacion,
                        c.primerNombre,
                        c.segundoNombre,
                        c.nroItentificacion,
                        o.factorOfertas
                    from movimiento m inner join persona v on m.persona_idPersona = p.idPersona inner join persona c on m.persona_idPersona1 = c.idPersona inner join ofertas o on m.ofertas_idOfertas = o.idOfertas
                    where m.cantidadItemsMovimiento = parm  and eliminado=0;
                when att = "CodInterno" then
                    select 
                        m.idMovimiento,
                        m.tipoMovimiento,
                        m.cantidadItemsMovimiento,
                        m.codInterno,
                        m.tipoComprobante,
                        m.montoPago,
                        v.primerNombre,
                        v.segundoNombre,
                        v.nroIdentificacion,
                        c.primerNombre,
                        c.segundoNombre,
                        c.nroItentificacion,
                        o.factorOfertas
                    from movimiento m inner join persona v on m.persona_idPersona = p.idPersona inner join persona c on m.persona_idPersona1 = c.idPersona inner join ofertas o on m.ofertas_idOfertas = o.idOfertas
                    where m.codInterno = parm  and eliminado=0;
                when att = "TipoComprobante" then
                    select 
                        m.idMovimiento,
                        m.tipoMovimiento,
                        m.cantidadItemsMovimiento,
                        m.codInterno,
                        m.tipoComprobante,
                        m.montoPago,
                        v.primerNombre,
                        v.segundoNombre,
                        v.nroIdentificacion,
                        c.primerNombre,
                        c.segundoNombre,
                        c.nroItentificacion,
                        o.factorOfertas
                    from movimiento m inner join persona v on m.persona_idPersona = p.idPersona inner join persona c on m.persona_idPersona1 = c.idPersona inner join ofertas o on m.ofertas_idOfertas = o.idOfertas
                    where m.tipoComprobante = parm  and eliminado=0;
                when att = "Monto" then
                    select 
                        m.idMovimiento,
                        m.tipoMovimiento,
                        m.cantidadItemsMovimiento,
                        m.codInterno,
                        m.tipoComprobante,
                        m.montoPago,
                        v.primerNombre,
                        v.segundoNombre,
                        v.nroIdentificacion,
                        c.primerNombre,
                        c.segundoNombre,
                        c.nroItentificacion,
                        o.factorOfertas
                    from movimiento m inner join persona v on m.persona_idPersona = p.idPersona inner join persona c on m.persona_idPersona1 = c.idPersona inner join ofertas o on m.ofertas_idOfertas = o.idOfertas
                    where m.montoPago = parm  and eliminado=0;
                when att = "Vendedor" then
                    select 
                        m.idMovimiento,
                        m.tipoMovimiento,
                        m.cantidadItemsMovimiento,
                        m.codInterno,
                        m.tipoComprobante,
                        m.montoPago,
                        v.primerNombre,
                        v.segundoNombre,
                        v.nroIdentificacion,
                        c.primerNombre,
                        c.segundoNombre,
                        c.nroIdentificacion,
                        o.factorOfertas
                    from movimiento m inner join persona v on m.persona_idPersona = p.idPersona inner join persona c on m.persona_idPersona1 = c.idPersona inner join ofertas o on m.ofertas_idOfertas = o.idOfertas
                    where v.nroIdentificacion = parm and eliminado=0;
                when att = "Cliente" then
                    select 
                        m.idMovimiento,
                        m.tipoMovimiento,
                        m.cantidadItemsMovimiento,
                        m.codInterno,
                        m.tipoComprobante,
                        m.montoPago,
                        v.primerNombre,
                        v.segundoNombre,
                        v.nroIdentificacion,
                        c.primerNombre,
                        c.segundoNombre,
                        c.nroIdentificacion,
                        o.factorOfertas
                    from movimiento m inner join persona v on m.persona_idPersona = p.idPersona inner join persona c on m.persona_idPersona1 = c.idPersona inner join ofertas o on m.ofertas_idOfertas = o.idOfertas
                    where c.nroIdentificacion = parm and eliminado=0;
                when att = "Ofertas" then
                    select 
                        m.idMovimiento,
                        m.tipoMovimiento,
                        m.cantidadItemsMovimiento,
                        m.codInterno,
                        m.tipoComprobante,
                        m.montoPago,
                        v.primerNombre,
                        v.segundoNombre,
                        v.nroIdentificacion,
                        c.primerNombre,
                        c.segundoNombre,
                        c.nroIdentificacion,
                        o.factorOfertas
                    from movimiento m inner join persona v on m.persona_idPersona = p.idPersona inner join persona c on m.persona_idPersona1 = c.idPersona inner join ofertas o on m.ofertas_idOfertas = o.idOfertas
                    where o.factorOfertas = parm and eliminado=0;
                when att = "Todos" then
                    select
                        m.idMovimiento,
                        m.tipoMovimiento,
                        m.cantidadItemsMovimiento,
                        m.codInterno,
                        m.tipoComprobante,
                        m.montoPago,
                        v.primerNombre,
                        v.segundoNombre,
                        v.nroIdentificacion,
                        c.primerNombre,
                        c.segundoNombre,
                        c.nroIdentificacion,
                        o.factorOfertas
                    from movimiento m inner join persona v on m.persona_idPersona = p.idPersona inner join persona c on m.persona_idPersona1 = c.idPersona inner join ofertas o on m.ofertas_idOfertas = o.idOfertas where m.eliminado=0;
            end case;
        when t_accion = "M" then
            case
                when att = "TipoMov" then update movimiento set tipoMovimiento = parm where idMovimiento = cod;
                when att = "CantidadItems" then update movimiento set cantidaItemsMovimiento = parm where idMovimiento = cod;
                when att = "TipoComprobante" then update movimiento set tipoComprobante = parm where idMovimiento = cod;
                when att = "MontoPago" then update movimiento set montoPago = parm where idMovimiento = cod;
                when att = "Vendedor" then update movimiento set persona_idPersona = parm where idMovimiento = cod;
                when att = "Cliente" then update movimiento set persona_idPersona1 = parm where idMovimiento = cod;
                when att = "Ofertas" then update movimiento set ofertas_idOfertas = parm where idMovimiento = cod;                     
            end case;
        when t_accion = "E" then update movimiento set eliminado = parm where idMovimiento = cod;
      end case;          
		when tabla = "Ofertas" then
			case
        when t_accion = "C" then
            case
                when att = "Codigo" then select * from ofertas where idOfertas = parm and eliminado=0;
                when att = "FechaInicio" then select * from ofertas where idOfertas = parm and eliminado=0; /*Revisar si se mueve a otro script*/
                when att = "FechaFin" then select * from ofertas where idOfertas = parm and eliminado=0; /*Revisar si se mueve a otro script*/
                when att = "TipoOferta" then select * from ofertas where idOfertas = parm and eliminado=0;
                when att = "Todos" then select * from ofertas where eliminado=0;
            end case;            
        when t_accion = "M" then
            case                    
                when att = "TipoOferta" then update ofertas set tipoOferta = parm where idOferta = cod;
                when att = "Factores" then update ofertas set factores_idFactores = parm where idOferta = cod;                    
            end case;
        when t_accion = "E" then update ofertas set eliminado = parm where idOfertas = cod;
      end case;
		when tabla = "Persona" then
			case
        when t_accion = "C" then 
            case
                when att = "Codigo" then select * from persona where idPersona = parm and eliminado = 0;
                when att = "PrimerNombre" then select * from persona where primerNombre = parm and eliminado = 0;
                when att = "Apellido_NE" then select * from persona where segundoNombre = parm and eliminado = 0;
                when att = "FechaNacimiento" then select * from persona where fechaNacimiento = parm and eliminado = 0;
                when att = "Direccion" then select * from persona where direccionRasonSocial = parm and eliminado = 0;
                when att = "Telefono" then select * from persona where telefono = parm and eliminado = 0;
                when att = "NroId" then select * from persona where nroIdentificacion = parm and eliminado = 0;
                when att = "TipoId" then select * from persona where tipoIdentificacion = parm and eliminado = 0;
                when att = "FechaReg" then select * from persona where fechaRegistro = parm and eliminado = 0;
                when att = "Todos" then select * from persona where eliminado = 0;
            end case;
        when t_accion = "M" then
            case 
                when att = "PrimerNombre" then update persona set primerNombre = parm where idPersona = cod;
                when att = "Apellido_Ne" then update persona set segundoNombre = parm where idPersona = cod;
                when att = "FechaNacimiento" then update persona set fechaNacimiento = parm where idPersona = cod;
                when att = "Direccion" then update persona set direccionRasonSocial = parm where idPersona = cod;
                when att = "Telefono" then update persona set telefono = parm where idPersona = cod;
                when att = "NroId" then update persona set nroIdentificacion = parm where idPersona = cod;
                when att = "TipoId" then update persona set tipoIdentificacion = parm where idPersona = cod;
                when att = "FechaReg" then update persona set fechaRegistro = parm where idPersona = cod;
            end case;
        when t_accion = "E" then update persona set eliminado = parm where idPersona = cod;
		  end case;
		when tabla = "UnidadMedida" then
			case    
        when t_accion = "C" then
            case
                    when att = "Codigo" then
                        select 
                            um1.idUnidadMedida,
                            um1.descripcion,
                            um1.valor,
                            um2.descripcion
                        from unidadMedida um1 inner join unidadMedida um2 on um1.unidadMedida_idUnidadMedida = um2.idUnidadMediada 
                        where um1.idUnidadMedida = parm and eliminado=0;
                    when att = "Descripcion" then
                        select 
                            um1.idUnidadMedida,
                            um1.descripcion,
                            um1.valor,
                            um2.descripcion
                        from unidadMedida um1 inner join unidadMedida um2 on um1.unidadMedida_idUnidadMedida = um2.idUnidadMediada 
                        where um1.descripcion = parm and eliminado=0;
                    when att = "Valor" then
                        select 
                            um1.idUnidadMedida,
                            um1.descripcion,
                            um1.valor,
                            um2.descripcion
                        from unidadMedida um1 inner join unidadMedida um2 on um1.unidadMedida_idUnidadMedida = um2.idUnidadMediada 
                        where um1.valor = parm and eliminado=0;
                    when att = "Padre" then
                        select 
                            um1.idUnidadMedida,
                            um1.descripcion,
                            um1.valor,
                            um2.descripcion
                        from unidadMedida um1 inner join unidadMedida um2 on um1.unidadMedida_idUnidadMedida = um2.idUnidadMediada 
                        where um2.descripcion = parm and eliminado=0;
                    when att = "Todos" then
                        select 
                            um1.idUnidadMedida,
                            um1.descripcion
                        from unidadMedida um1 where um1.eliminado=0;
                end case;
        when t_accion = "M" then
            case
          when att = "Descripcion" then update unidadmedida set descripcion = parm where idUnidadMedida = cod;
          when att = "Valor" then update unidadmedida set valor = parm where idUnidadMedida = cod;
          when att = "Padre" then update unidadmedida set unidadMedida_idUnidadMedida = parm where idUnidadMedida = cod;
      end case;
        when t_accion = "E" then update unidadmedida set eliminado = parm where idUnidadMedida = cod;        
		end case;
		when tabla = "Usuario" then
		  case
			when t_accion = "C" then
				case
					when att = "Codigo" then select * from usuario where idUsuario = parm and eliminado=0;
					when att = "Nombre" then select * from usuario where Nombre = parm and eliminado=0;
					when att = "Login" then select * from usuario where Login = parm and eliminado=0;
					when att = "Clave" then select * from usuario where Clave = parm and eliminado=0;
					when att = "Cargo" then select * from usuario where Cargo = parm and eliminado=0;
					when att = "Modo" then select * from usuario where Modo = parm and eliminado=0;
					when att = "Estado" then select * from usuario where Estado = parm and eliminado=0;
				end case;
			when t_accion = "M" then
				case
					when att = "Nombre" then update usuario set Nombre = parm where idUsuario = cod;
					when att = "Login" then update usuario set Login = parm where idUsuario = cod;
					when att = "Clave" then update usuario set Clave = parm where idUsuario = cod;
					when att = "Cargo" then update usuario set Cargo = parm where idUsuario = cod;
					when att = "Modo" then update usuario set Modo = parm where idUsuario = cod;
					when att = "Estado" then update usuario set Estado = parm where idUsuario = cod;
				end case;
			when t_accion = "E" then update usuario set Eliminado = parm where idUsuario = cod;
		  end case;
		when tabla = "Registro" then        
		  select u.Nombre, ua.NomTabla, ua.idTabla, ua.tipoAccion from UsuarioAccion ua inner join usuario u on ua.idUsuario=u.idUsuario where u.Nombre=parm;
		when tabla = "Traspasos" then
      select * from DatosTraspasos;
    end case;
END$$


