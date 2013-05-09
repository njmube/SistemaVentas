CREATE DATABASE  IF NOT EXISTS `pydcom_bd_ventas` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci */;
USE `pydcom_bd_ventas`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: pydcom_bd_ventas
-- ------------------------------------------------------
-- Server version	5.0.51b-community-nt-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Not dumping tablespaces as no INFORMATION_SCHEMA.FILES table on this server
--

--
-- Table structure for table `categoriam`
--

DROP TABLE IF EXISTS `categoriam`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoriam` (
  `idcategoriaM` int(11) NOT NULL auto_increment,
  `nombre` varchar(200) collate utf8_unicode_ci NOT NULL,
  `descripcion` longtext collate utf8_unicode_ci NOT NULL,
  `idCategoriaDepende` int(11) NOT NULL,
  `eliminado` int(11) NOT NULL default '0',
  `idUsuario` int(11) NOT NULL,
  PRIMARY KEY  (`idcategoriaM`),
  KEY `fk_CategoriaUsuario` (`idUsuario`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `detallefactoresmercaderia`
--

DROP TABLE IF EXISTS `detallefactoresmercaderia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detallefactoresmercaderia` (
  `mercaderia_idMercaderia` int(11) NOT NULL,
  `factores_idFactores` int(11) NOT NULL,
  PRIMARY KEY  (`mercaderia_idMercaderia`,`factores_idFactores`),
  KEY `fk_detallefactoresmercaderia_mercaderia1` (`mercaderia_idMercaderia`),
  KEY `fk_detallefactoresmercaderia_factores1` (`factores_idFactores`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `existencias`
--

DROP TABLE IF EXISTS `existencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `existencias` (
  `idMercaderia` int(11) NOT NULL auto_increment,
  `codInternoMercaderia` varchar(45) default NULL,
  `precioUnitario` decimal(11,2) default '0.00',
  `precioAdquisicion` decimal(11,2) default NULL,
  `fechaAdquisicion` date default NULL,
  `fechaVencimiento` date default NULL,
  `estadoMercaderia` varchar(45) default NULL,
  `eliminado` int(11) default NULL,
  `Ubicacion` int(11) default NULL,
  `idMovimiento` int(11) NOT NULL,
  PRIMARY KEY  (`idMercaderia`),
  UNIQUE KEY `codInternoMercaderia_UNIQUE` (`codInternoMercaderia`),
  KEY `fk_existencias_movimiento1` (`idMovimiento`)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `factores`
--

DROP TABLE IF EXISTS `factores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factores` (
  `idFactores` int(11) NOT NULL auto_increment,
  `concepto` varchar(45) NOT NULL,
  `monto` varchar(45) NOT NULL,
  `eliminado` int(11) NOT NULL,
  `t` varchar(45) NOT NULL,
  PRIMARY KEY  (`idFactores`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `mercaderia`
--

DROP TABLE IF EXISTS `mercaderia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mercaderia` (
  `idMercaderia` int(11) NOT NULL auto_increment,
  `StockDisponible` int(11) NOT NULL,
  `StockMinimo` int(11) NOT NULL,
  `PrecioCompra` decimal(11,2) NOT NULL,
  `PrecioVenta` decimal(11,2) NOT NULL,
  `Nombre` varchar(20) collate utf8_unicode_ci NOT NULL,
  `idUndMedida` int(10) unsigned NOT NULL,
  `idCategoria` int(11) NOT NULL,
  PRIMARY KEY  (`idMercaderia`),
  KEY `fk_mercaderia_unidadmedida1` (`idUndMedida`),
  KEY `fk_mercaderia_categoriam1` (`idCategoria`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `movimiento`
--

DROP TABLE IF EXISTS `movimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movimiento` (
  `idMovimiento` int(11) NOT NULL auto_increment,
  `tipoMovimiento` varchar(20) NOT NULL,
  `fecha` date default NULL,
  `hora` time default NULL,
  `idCliente` int(11) NOT NULL COMMENT 'Cliente',
  `idVendedor` int(11) NOT NULL COMMENT 'Empleado',
  `idOferta` int(11) default NULL,
  `eliminado` int(11) default NULL,
  `UbicacionInicial` varchar(20) default NULL,
  `UbicacionFinal` varchar(20) default NULL,
  `idMercaderia` int(11) NOT NULL,
  `montoPago` decimal(11,2) NOT NULL,
  PRIMARY KEY  (`idMovimiento`),
  KEY `fk_movimiento_persona1` (`idCliente`),
  KEY `fk_movimiento_persona2` (`idVendedor`),
  KEY `fk_movimiento_ofertas1` (`idOferta`),
  KEY `fk_movimiento_mercaderia1` (`idMercaderia`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `ofertas`
--

DROP TABLE IF EXISTS `ofertas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ofertas` (
  `idOfertas` int(11) NOT NULL auto_increment,
  `factores_idFactores` int(11) NOT NULL,
  `fechaInicioAplicacion` date NOT NULL,
  `fechaFinAplicacion` date NOT NULL,
  `eliminado` int(11) NOT NULL,
  PRIMARY KEY  (`idOfertas`),
  KEY `fk_ofertas_factores1` (`factores_idFactores`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `persona` (
  `idPersona` int(11) NOT NULL auto_increment,
  `segundoNombre` varchar(45) NOT NULL COMMENT 'Apellido para una persona natural, razonSocial cuando sea una persona juridica',
  `primerNombre` varchar(45) default NULL,
  `fechaNacimiento` date default NULL,
  `direccionRasonSocial` varchar(60) default NULL,
  `telefono` varchar(20) default NULL,
  `nroIdentificacion` varchar(20) NOT NULL,
  `tipoIdentificacion` char(1) NOT NULL COMMENT 'E= empleado , C = Cliente, P = Proveedor',
  `fechaRegistro` date NOT NULL COMMENT 'Puede prestarse para: Fecha_Ingreso => Proveedor, Fecha_Contrato => Empleado, Fecha_Registro => Cliente',
  `eliminado` int(11) default '0',
  `idUsuario` int(11) NOT NULL default '3',
  PRIMARY KEY  (`idPersona`),
  KEY `fk_PersonaUsuario` (`idUsuario`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `unidadmedida`
--

DROP TABLE IF EXISTS `unidadmedida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `unidadmedida` (
  `idUnidadMedida` int(10) unsigned NOT NULL auto_increment,
  `descripcion` varchar(45) NOT NULL,
  `valor` int(11) NOT NULL,
  `eliminado` int(11) NOT NULL,
  `idUndMedida_Padre` int(10) unsigned NOT NULL,
  PRIMARY KEY  (`idUnidadMedida`),
  KEY `fk_unidadMedida_unidadMedida1_idx` (`idUndMedida_Padre`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL auto_increment,
  `Nombre` varchar(45) default NULL,
  `Login` varchar(45) default NULL,
  `Clave` varchar(45) default NULL,
  `Cargo` varchar(45) default NULL,
  `Modo` int(11) default '0',
  `Estado` int(11) default '1',
  `Eliminado` int(11) default NULL,
  PRIMARY KEY  (`idUsuario`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `usuarioaccion`
--

DROP TABLE IF EXISTS `usuarioaccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarioaccion` (
  `idUsuarioAccion` int(11) NOT NULL auto_increment,
  `idUsuario` int(11) NOT NULL COMMENT 'Id del Usuario que genera un evento',
  `NomTabla` varchar(45) collate utf8_unicode_ci NOT NULL COMMENT 'Nombre de Tabla en la que se generó un Evento',
  `idTabla` int(11) NOT NULL COMMENT 'Clave Primaria de la fila sobre la que se realizó el evento en la tabla',
  `tipoAccion` varchar(45) collate utf8_unicode_ci NOT NULL,
  PRIMARY KEY  (`idUsuarioAccion`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping routines for database 'pydcom_bd_ventas'
--
/*!50003 DROP PROCEDURE IF EXISTS `operar_tabla` */;
--
-- WARNING: old server version. The following dump may be incomplete.
--
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`root`@`localhost`*/ /*!50003 PROCEDURE `operar_tabla`()
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
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-05-08 15:36:28
