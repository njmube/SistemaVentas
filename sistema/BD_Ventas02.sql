CREATE DATABASE  IF NOT EXISTS `pydcom_bd_ventas` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci */;
USE `pydcom_bd_ventas`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: pydcom_bd_ventas
-- ------------------------------------------------------
-- Server version	5.5.19

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
-- Table structure for table `mercaderia`
--

DROP TABLE IF EXISTS `mercaderia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mercaderia` (
  `idMercaderia` int(11) NOT NULL AUTO_INCREMENT,
  `StockDisponible` int(11) NOT NULL,
  `StockMinimo` int(11) NOT NULL,
  `PrecioCompra` decimal(11,2) NOT NULL,
  `PrecioVenta` decimal(11,2) NOT NULL,
  `Nombre` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `idUndMedida` int(10) unsigned NOT NULL,
  `idCategoria` int(11) NOT NULL,
  PRIMARY KEY (`idMercaderia`),
  KEY `fk_mercaderia_unidadmedida1` (`idUndMedida`),
  KEY `fk_mercaderia_categoriam1` (`idCategoria`),
  CONSTRAINT `fk_mercaderia_unidadmedida1` FOREIGN KEY (`idUndMedida`) REFERENCES `unidadmedida` (`idUnidadMedida`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_mercaderia_categoriam1` FOREIGN KEY (`idCategoria`) REFERENCES `categoriam` (`idcategoriaM`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `persona` (
  `idPersona` int(11) NOT NULL AUTO_INCREMENT,
  `segundoNombre` varchar(45) NOT NULL COMMENT 'Apellido para una persona natural, razonSocial cuando sea una persona juridica',
  `primerNombre` varchar(45) DEFAULT NULL,
  `fechaNacimiento` date DEFAULT NULL,
  `direccionRasonSocial` varchar(60) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `nroIdentificacion` varchar(20) NOT NULL,
  `tipoIdentificacion` char(1) NOT NULL COMMENT 'E= empleado , C = Cliente, P = Proveedor',
  `fechaRegistro` date NOT NULL COMMENT 'Puede prestarse para: Fecha_Ingreso => Proveedor, Fecha_Contrato => Empleado, Fecha_Registro => Cliente',
  `eliminado` int(11) DEFAULT '0',
  `idUsuario` int(11) NOT NULL DEFAULT '3',
  PRIMARY KEY (`idPersona`),
  KEY `fk_PersonaUsuario` (`idUsuario`),
  CONSTRAINT `fk_PersonaUsuario` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `existencias`
--

DROP TABLE IF EXISTS `existencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `existencias` (
  `idMercaderia` int(11) NOT NULL AUTO_INCREMENT,
  `codInternoMercaderia` varchar(45) DEFAULT NULL,
  `precioUnitario` decimal(11,2) DEFAULT '0.00',
  `precioAdquisicion` decimal(11,2) DEFAULT NULL,
  `fechaAdquisicion` date DEFAULT NULL,
  `fechaVencimiento` date DEFAULT NULL,
  `estadoMercaderia` varchar(45) DEFAULT NULL,
  `eliminado` int(11) DEFAULT NULL,
  `Ubicacion` int(11) DEFAULT NULL,
  `idMovimiento` int(11) NOT NULL,
  PRIMARY KEY (`idMercaderia`),
  UNIQUE KEY `codInternoMercaderia_UNIQUE` (`codInternoMercaderia`),
  KEY `fk_existencias_movimiento1` (`idMovimiento`),
  CONSTRAINT `fk_existencias_movimiento1` FOREIGN KEY (`idMovimiento`) REFERENCES `movimiento` (`idMovimiento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `movimiento`
--

DROP TABLE IF EXISTS `movimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movimiento` (
  `idMovimiento` int(11) NOT NULL AUTO_INCREMENT,
  `tipoMovimiento` varchar(20) NOT NULL,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `idCliente` int(11) NOT NULL COMMENT 'Cliente',
  `idVendedor` int(11) NOT NULL COMMENT 'Empleado',
  `idOferta` int(11) DEFAULT NULL,
  `eliminado` int(11) DEFAULT NULL,
  `UbicacionInicial` varchar(20) DEFAULT NULL,
  `UbicacionFinal` varchar(20) DEFAULT NULL,
  `idMercaderia` int(11) NOT NULL,
  `montoPago` decimal(11,2) NOT NULL,
  PRIMARY KEY (`idMovimiento`),
  KEY `fk_movimiento_persona1` (`idCliente`),
  KEY `fk_movimiento_persona2` (`idVendedor`),
  KEY `fk_movimiento_ofertas1` (`idOferta`),
  KEY `fk_movimiento_mercaderia1` (`idMercaderia`),
  CONSTRAINT `fk_movimiento_mercaderia1` FOREIGN KEY (`idMercaderia`) REFERENCES `mercaderia` (`idMercaderia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_movimiento_ofertas1` FOREIGN KEY (`idOferta`) REFERENCES `ofertas` (`idOfertas`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_movimiento_persona1` FOREIGN KEY (`idCliente`) REFERENCES `persona` (`idPersona`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_movimiento_persona2` FOREIGN KEY (`idVendedor`) REFERENCES `persona` (`idPersona`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) DEFAULT NULL,
  `Login` varchar(45) DEFAULT NULL,
  `Clave` varchar(45) DEFAULT NULL,
  `Cargo` varchar(45) DEFAULT NULL,
  `Modo` int(11) DEFAULT '0',
  `Estado` int(11) DEFAULT '1',
  `Eliminado` int(11) DEFAULT NULL,
  PRIMARY KEY (`idUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `usuarioaccion`
--

DROP TABLE IF EXISTS `usuarioaccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarioaccion` (
  `idUsuarioAccion` int(11) NOT NULL AUTO_INCREMENT,
  `idUsuario` int(11) NOT NULL COMMENT 'Id del Usuario que genera un evento',
  `NomTabla` varchar(45) COLLATE utf8_unicode_ci NOT NULL COMMENT 'Nombre de Tabla en la que se generó un Evento',
  `idTabla` int(11) NOT NULL COMMENT 'Clave Primaria de la fila sobre la que se realizó el evento en la tabla',
  `tipoAccion` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idUsuarioAccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
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
  PRIMARY KEY (`mercaderia_idMercaderia`,`factores_idFactores`),
  KEY `fk_detallefactoresmercaderia_mercaderia1` (`mercaderia_idMercaderia`),
  KEY `fk_detallefactoresmercaderia_factores1` (`factores_idFactores`),
  CONSTRAINT `fk_detallefactoresmercaderia_factores1` FOREIGN KEY (`factores_idFactores`) REFERENCES `factores` (`idFactores`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_detallefactoresmercaderia_mercaderia1` FOREIGN KEY (`mercaderia_idMercaderia`) REFERENCES `mercaderia` (`idMercaderia`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `unidadmedida`
--

DROP TABLE IF EXISTS `unidadmedida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `unidadmedida` (
  `idUnidadMedida` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(45) NOT NULL,
  `valor` int(11) NOT NULL,
  `eliminado` int(11) NOT NULL,
  `idUndMedida_Padre` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idUnidadMedida`),
  KEY `fk_unidadMedida_unidadMedida1_idx` (`idUndMedida_Padre`),
  CONSTRAINT `fk_unidadMedida_unidadMedida1` FOREIGN KEY (`idUndMedida_Padre`) REFERENCES `unidadmedida` (`idUnidadMedida`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `ofertas`
--

DROP TABLE IF EXISTS `ofertas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ofertas` (
  `idOfertas` int(11) NOT NULL AUTO_INCREMENT,
  `factores_idFactores` int(11) NOT NULL,
  `fechaInicioAplicacion` date NOT NULL,
  `fechaFinAplicacion` date NOT NULL,
  `eliminado` int(11) NOT NULL,
  PRIMARY KEY (`idOfertas`),
  KEY `fk_ofertas_factores1` (`factores_idFactores`),
  CONSTRAINT `fk_ofertas_factores1` FOREIGN KEY (`factores_idFactores`) REFERENCES `factores` (`idFactores`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `factores`
--

DROP TABLE IF EXISTS `factores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factores` (
  `idFactores` int(11) NOT NULL AUTO_INCREMENT,
  `concepto` varchar(45) NOT NULL,
  `monto` varchar(45) NOT NULL,
  `eliminado` int(11) NOT NULL,
  `t` varchar(45) NOT NULL,
  PRIMARY KEY (`idFactores`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `categoriam`
--

DROP TABLE IF EXISTS `categoriam`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoriam` (
  `idcategoriaM` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `descripcion` longtext COLLATE utf8_unicode_ci NOT NULL,
  `idCategoriaDepende` int(11) NOT NULL,
  `eliminado` int(11) NOT NULL DEFAULT '0',
  `idUsuario` int(11) NOT NULL,
  PRIMARY KEY (`idcategoriaM`),
  KEY `fk_CategoriaUsuario` (`idUsuario`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping routines for database 'pydcom_bd_ventas'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-05-07 17:22:03
