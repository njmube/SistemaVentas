CREATE DATABASE  IF NOT EXISTS `pydcom_bdventas` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `pydcom_bdventas`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: pydcom_bdventas
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
  `stockDisponible` int(11) DEFAULT NULL,
  `stockMinimo` int(11) DEFAULT NULL,
  `precioVenta` decimal(11,2) DEFAULT NULL,
  `nombre` longtext,
  `descripcion` longtext,
  `idUndMedida` int(11) DEFAULT NULL,
  `idCategoria` int(11) DEFAULT NULL,
  `eliminado` int(11) DEFAULT '0',
  `idUsuario` int(11) DEFAULT '1',
  `valorMedidaUnidad` decimal(11,2) DEFAULT NULL,
  `idUnidadMedidaUnidad` int(11) DEFAULT NULL,
  PRIMARY KEY (`idMercaderia`),
  KEY `FK_M-Cat` (`idCategoria`),
  KEY `FK_M-UniMed` (`idUndMedida`),
  CONSTRAINT `FK_M-Cat` FOREIGN KEY (`idCategoria`) REFERENCES `categoriam` (`idCategoriam`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_M-UniMed` FOREIGN KEY (`idUndMedida`) REFERENCES `unidadmedida` (`idUnidadMedida`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mercaderia`
--

LOCK TABLES `mercaderia` WRITE;
/*!40000 ALTER TABLE `mercaderia` DISABLE KEYS */;
INSERT INTO `mercaderia` VALUES (1,13,10,5.00,'MERCADERIA 1','MERCADERIA 1',1,1,0,1,NULL,NULL),(2,15,13,10.00,'MERCADERIA 2','MERCADERIA 2',1,2,0,1,NULL,NULL),(3,13,10,20.00,'MERCADERIA 3','MERCADERIA 3',1,3,0,1,NULL,NULL),(4,17,20,20.00,'MERCADERIA 4','MERCADERIA 4',1,1,0,1,NULL,NULL),(5,30,5,10.00,'MERCADERIA 5','MERCADERIA 5',1,3,0,1,NULL,NULL),(6,5,1,1.00,'MERCADERIA 6','MERCADERIA 6',1,1,0,1,NULL,NULL),(7,7,2,9.00,'MERCADERIA 7','MERCADERIA 7',1,2,0,1,NULL,NULL);
/*!40000 ALTER TABLE `mercaderia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `controlproduccion`
--

DROP TABLE IF EXISTS `controlproduccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `controlproduccion` (
  `idControlProduccion` int(11) NOT NULL AUTO_INCREMENT,
  `idProduccion` int(11) DEFAULT NULL COMMENT 'idProduccion',
  `tarea` varchar(45) DEFAULT NULL,
  `fInicioReinicio` datetime DEFAULT NULL,
  `fFinalizado` datetime DEFAULT NULL,
  `idProceso` int(11) DEFAULT NULL,
  `eliminado` int(11) DEFAULT '0',
  PRIMARY KEY (`idControlProduccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `controlproduccion`
--

LOCK TABLES `controlproduccion` WRITE;
/*!40000 ALTER TABLE `controlproduccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `controlproduccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `persona` (
  `idPersona` int(11) NOT NULL AUTO_INCREMENT,
  `segundoNombre` varchar(45) DEFAULT NULL,
  `primerNombre` varchar(45) DEFAULT NULL,
  `fechaNacimiento` date DEFAULT NULL,
  `direccionRasonSocial` varchar(60) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `nroIdentificacion` varchar(20) DEFAULT NULL,
  `tipoIdentificacion` char(1) DEFAULT NULL,
  `fechaRegistro` date DEFAULT NULL,
  `eliminado` int(11) DEFAULT '0',
  `idUsuario` int(11) DEFAULT '1',
  PRIMARY KEY (`idPersona`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` VALUES (1,'Burgos ','Ruben','2013-05-21','','','70248833','C','0001-01-01',0,1);
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `existencias`
--

DROP TABLE IF EXISTS `existencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `existencias` (
  `idExistencias` int(11) NOT NULL AUTO_INCREMENT,
  `codInternoMercaderia` varchar(45) DEFAULT NULL,
  `precioUnitario` decimal(11,2) DEFAULT NULL,
  `precioAdquisicion` decimal(11,2) DEFAULT NULL,
  `fechaAdquisicion` date DEFAULT NULL,
  `fechaVencimiento` date DEFAULT NULL,
  `estadoMercaderia` varchar(45) DEFAULT NULL,
  `eliminado` int(11) DEFAULT NULL,
  `idUbicacion` int(11) DEFAULT NULL,
  `idMovimiento` int(11) DEFAULT NULL,
  `idMercaderia` int(11) DEFAULT NULL,
  `valorUnidadMedida` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idExistencias`),
  KEY `FK_E-Ubic` (`idUbicacion`),
  KEY `FK_E-Merc` (`idMercaderia`),
  KEY `FK_E-DetMov` (`idMovimiento`),
  CONSTRAINT `FK_E-Merc` FOREIGN KEY (`idMercaderia`) REFERENCES `mercaderia` (`idMercaderia`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_E-Ubic` FOREIGN KEY (`idUbicacion`) REFERENCES `factores` (`idFactores`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `existencias`
--

LOCK TABLES `existencias` WRITE;
/*!40000 ALTER TABLE `existencias` DISABLE KEYS */;
INSERT INTO `existencias` VALUES (2,'70248833',5.00,5.00,'2013-05-05','2013-05-05','ALMACEN',0,10,0,1,NULL),(3,'44704854',5.00,5.00,'2013-05-05','2013-05-05','ALMACEN',0,10,23,6,NULL),(4,'48126868',5.00,5.00,'2013-05-05','2013-05-05','ALMACEN',0,10,24,5,NULL);
/*!40000 ALTER TABLE `existencias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento`
--

DROP TABLE IF EXISTS `movimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movimiento` (
  `idMovimiento` int(11) NOT NULL AUTO_INCREMENT,
  `tipoMovimiento` varchar(45) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `idPersona` int(11) DEFAULT NULL,
  `idOferta` int(11) DEFAULT '0',
  `eliminado` int(11) DEFAULT '0',
  `UbicacionInicial` int(11) DEFAULT '0',
  `UbicacionFinal` int(11) DEFAULT '0',
  `idMercaderia` int(11) DEFAULT '0',
  `montoPago` decimal(11,2) DEFAULT NULL,
  `idUsuario` int(11) DEFAULT '1',
  `idTipoDocumento` int(11) DEFAULT NULL,
  `numeroDocumento` varchar(15) DEFAULT NULL,
  `vuelto` decimal(11,2) DEFAULT '0.00',
  `cantidadProductos` decimal(11,2) DEFAULT '0.00',
  `subtotal` decimal(11,2) DEFAULT NULL,
  `igv` decimal(11,2) DEFAULT NULL,
  `total` decimal(11,2) DEFAULT NULL,
  PRIMARY KEY (`idMovimiento`),
  KEY `FK_M-Persona` (`idPersona`),
  CONSTRAINT `FK_M-Persona` FOREIGN KEY (`idPersona`) REFERENCES `persona` (`idPersona`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento`
--

LOCK TABLES `movimiento` WRITE;
/*!40000 ALTER TABLE `movimiento` DISABLE KEYS */;
INSERT INTO `movimiento` VALUES (3,'PRODUCCION','2013-05-21','18:03:22',1,0,0,10,10,0,0.00,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(7,'PRODUCCION','2013-05-21','18:07:22',1,0,0,10,10,0,0.00,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(8,'6','2013-05-21','00:00:00',1,0,0,0,0,0,20.00,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(12,'6','2013-05-21','00:00:00',1,0,0,0,0,0,11.00,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(13,'6','2013-05-21','00:00:00',1,0,0,0,0,0,11.00,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(14,'6','2013-05-21','00:00:00',1,0,0,0,0,0,11.00,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(15,'6','2013-05-21','00:00:00',1,0,0,0,0,0,2.00,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(16,'6','2013-05-21','00:00:00',1,0,0,0,0,0,30.00,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `movimiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallemovimiento`
--

DROP TABLE IF EXISTS `detallemovimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detallemovimiento` (
  `idDetalleMovimiento` int(11) NOT NULL AUTO_INCREMENT,
  `idMercaderia` int(11) DEFAULT NULL,
  `idMovimiento` int(11) DEFAULT NULL,
  `precio` decimal(11,2) DEFAULT NULL,
  `cantidad` decimal(11,2) DEFAULT NULL,
  `subtotal` decimal(11,2) DEFAULT NULL,
  `descuento` decimal(11,2) DEFAULT NULL,
  `total` decimal(11,2) DEFAULT NULL,
  `eliminado` int(11) DEFAULT NULL,
  `idOferta` int(11) DEFAULT NULL,
  PRIMARY KEY (`idDetalleMovimiento`),
  KEY `FK_DM-Merc` (`idMercaderia`),
  KEY `FK_DM-Mov` (`idMovimiento`),
  CONSTRAINT `FK_DM-Merc` FOREIGN KEY (`idMercaderia`) REFERENCES `mercaderia` (`idMercaderia`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_DM-Mov` FOREIGN KEY (`idMovimiento`) REFERENCES `movimiento` (`idMovimiento`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallemovimiento`
--

LOCK TABLES `detallemovimiento` WRITE;
/*!40000 ALTER TABLE `detallemovimiento` DISABLE KEYS */;
INSERT INTO `detallemovimiento` VALUES (3,1,3,10.00,5.00,0.00,0.00,0.00,0,0),(4,4,3,10.00,5.00,0.00,0.00,0.00,0,0),(5,6,3,10.00,5.00,0.00,0.00,0.00,0,0),(11,1,7,12.00,5.00,0.00,0.00,0.00,0,0),(12,4,7,12.00,5.00,0.00,0.00,0.00,0,0),(13,6,7,12.00,5.00,0.00,0.00,0.00,0,0),(14,5,8,10.00,2.00,20.00,0.00,20.00,0,0),(17,6,12,1.00,1.00,1.00,0.00,1.00,0,0),(18,5,12,10.00,1.00,10.00,0.00,10.00,0,0),(19,5,13,10.00,1.00,10.00,0.00,10.00,0,0),(20,6,13,1.00,1.00,1.00,0.00,1.00,0,0),(21,6,14,1.00,1.00,1.00,0.00,1.00,0,0),(22,5,14,10.00,1.00,10.00,0.00,10.00,0,0),(23,6,15,1.00,2.00,2.00,0.00,2.00,0,0),(24,5,16,10.00,3.00,30.00,0.00,30.00,0,0);
/*!40000 ALTER TABLE `detallemovimiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarioaccion`
--

DROP TABLE IF EXISTS `usuarioaccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarioaccion` (
  `idUsuarioAccion` int(11) NOT NULL AUTO_INCREMENT,
  `idUsuario` int(11) DEFAULT NULL,
  `NomTabla` varchar(45) DEFAULT NULL,
  `idTabla` int(11) DEFAULT NULL,
  `tipoAccion` varchar(45) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `hora` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`idUsuarioAccion`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarioaccion`
--

LOCK TABLES `usuarioaccion` WRITE;
/*!40000 ALTER TABLE `usuarioaccion` DISABLE KEYS */;
INSERT INTO `usuarioaccion` VALUES (1,1,'Usuarios',1,'Inicio de Sesión',NULL,NULL),(2,1,'Usuarios',1,'Termino de Sesión',NULL,NULL),(3,1,'Usuarios',1,'Termino de Sesión','2013-05-13',NULL),(4,1,'Usuarios',1,'Inicio de Sesión','2013-05-13',NULL),(5,1,'Usuarios',1,'Termino de Sesión','2013-05-13',NULL),(6,1,'Usuarios',1,'Termino de Sesión','2013-05-13',NULL),(7,1,'Usuarios',1,'Inicio de Sesión','2013-05-13',NULL),(8,1,'Usuarios',1,'Termino de Sesión','2013-05-13','06:09 p.m.'),(9,1,'Usuarios',1,'Inicio de Sesión','2013-05-13','06:10 p.m.'),(10,1,'Usuarios',1,'Termino de Sesión','2013-05-13','06:10 p.m.'),(11,1,'Usuarios',1,'Inicio de Sesión','2013-05-14','06:50 p.m.'),(12,1,'Usuarios',1,'Termino de Sesión','2013-05-14','06:51 p.m.'),(13,1,'Usuarios',1,'Termino de Sesión','2013-05-14','06:53 p.m.'),(14,1,'Usuarios',1,'Inicio de Sesión','2013-05-20','06:06 p.m.'),(15,1,'Usuarios',1,'Termino de Sesión','2013-05-20','06:06 p.m.'),(16,1,'Usuarios',1,'Inicio de Sesión','2013-05-21','01:22 p.m.'),(17,1,'Usuarios',1,'Termino de Sesión','2013-05-21','01:22 p.m.'),(18,1,'Usuarios',1,'Inicio de Sesión','2013-05-21','05:22 p.m.'),(19,1,'Usuarios',1,'Termino de Sesión','2013-05-21','05:23 p.m.'),(20,1,'Usuarios',1,'Inicio de Sesión','2013-05-21','05:26 p.m.'),(21,1,'Usuarios',1,'Inicio de Sesión','2013-05-21','05:32 p.m.'),(22,1,'Usuarios',1,'Termino de Sesión','2013-05-21','05:34 p.m.'),(23,1,'Usuarios',1,'Inicio de Sesión','2013-05-21','05:40 p.m.'),(24,1,'Usuarios',1,'Inicio de Sesión','2013-05-21','05:51 p.m.'),(25,1,'Usuarios',1,'Termino de Sesión','2013-05-21','05:54 p.m.'),(26,2,'Usuarios',2,'Inicio de Sesión','2013-05-21','05:55 p.m.'),(27,1,'Usuarios',1,'Inicio de Sesión','2013-05-21','05:57 p.m.'),(28,2,'Usuarios',2,'Termino de Sesión','2013-05-21','05:58 p.m.'),(29,2,'Usuarios',2,'Inicio de Sesión','2013-05-21','06:02 p.m.'),(30,1,'Usuarios',1,'Inicio de Sesión','2013-05-21','06:02 p.m.'),(31,2,'Usuarios',2,'Termino de Sesión','2013-05-21','06:03 p.m.'),(32,2,'Usuarios',2,'Inicio de Sesión','2013-05-21','06:04 p.m.'),(33,2,'Usuarios',2,'Termino de Sesión','2013-05-21','06:05 p.m.'),(34,1,'Usuarios',1,'Inicio de Sesión','2013-05-21','06:06 p.m.'),(35,2,'Usuarios',2,'Inicio de Sesión','2013-05-21','06:12 p.m.'),(36,2,'Usuarios',2,'Termino de Sesión','2013-05-21','06:12 p.m.'),(37,2,'Usuarios',2,'Inicio de Sesión','2013-05-21','06:13 p.m.'),(39,2,'Usuarios',2,'Inicio de Sesión','2013-05-21','06:14 p.m.'),(40,2,'Usuarios',2,'Inicio de Sesión','2013-05-21','06:18 p.m.'),(41,2,'Usuarios',2,'Inicio de Sesión','2013-05-21','06:23 p.m.'),(42,2,'Usuarios',2,'Termino de Sesión','2013-05-21','06:24 p.m.'),(43,2,'Usuarios',2,'Inicio de Sesión','2013-05-21','06:25 p.m.'),(44,2,'Usuarios',2,'Termino de Sesión','2013-05-21','06:26 p.m.'),(45,2,'Usuarios',2,'Inicio de Sesión','2013-05-21','06:27 p.m.'),(46,2,'Usuarios',2,'Termino de Sesión','2013-05-21','06:29 p.m.'),(47,2,'Usuarios',2,'Inicio de Sesión','2013-05-21','06:30 p.m.'),(48,2,'Usuarios',2,'Termino de Sesión','2013-05-21','06:31 p.m.'),(49,2,'Usuarios',2,'Inicio de Sesión','2013-05-21','06:33 p.m.'),(50,2,'Usuarios',2,'Termino de Sesión','2013-05-21','06:33 p.m.'),(51,2,'Usuarios',2,'Inicio de Sesión','2013-05-23','01:19 p.m.'),(52,2,'Usuarios',2,'Termino de Sesión','2013-05-23','01:19 p.m.');
/*!40000 ALTER TABLE `usuarioaccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unidadmedida`
--

DROP TABLE IF EXISTS `unidadmedida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `unidadmedida` (
  `idUnidadMedida` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(45) DEFAULT NULL,
  `valor` int(11) DEFAULT NULL,
  `eliminado` int(11) DEFAULT NULL,
  `idUnidadMedida_Padre` int(11) DEFAULT NULL,
  PRIMARY KEY (`idUnidadMedida`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unidadmedida`
--

LOCK TABLES `unidadmedida` WRITE;
/*!40000 ALTER TABLE `unidadmedida` DISABLE KEYS */;
INSERT INTO `unidadmedida` VALUES (1,'KG',2,0,0);
/*!40000 ALTER TABLE `unidadmedida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ofertas`
--

DROP TABLE IF EXISTS `ofertas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ofertas` (
  `idOfertas` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(45) DEFAULT NULL,
  `v1` decimal(11,2) DEFAULT NULL,
  `v2` decimal(11,2) DEFAULT NULL,
  `ecuacion` varchar(100) DEFAULT NULL,
  `eliminado` int(11) DEFAULT '0',
  `idUsuario` int(11) DEFAULT '1',
  PRIMARY KEY (`idOfertas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ofertas`
--

LOCK TABLES `ofertas` WRITE;
/*!40000 ALTER TABLE `ofertas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ofertas` ENABLE KEYS */;
UNLOCK TABLES;

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
  `Modo` int(11) DEFAULT NULL,
  `Estado` int(11) DEFAULT '0',
  `Eliminado` int(11) DEFAULT '0',
  PRIMARY KEY (`idUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'mickarriaga','marriagap','123456','admin',1,1,0),(2,'admin','admin','1234','admin',0,1,0);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factores`
--

DROP TABLE IF EXISTS `factores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factores` (
  `idFactores` int(11) NOT NULL AUTO_INCREMENT,
  `concepto` varchar(45) DEFAULT NULL,
  `monto` varchar(45) DEFAULT NULL,
  `eliminado` int(11) DEFAULT '0',
  `t` varchar(45) DEFAULT NULL COMMENT '1 = Parametros del Sistema, 2 = Tipo de Documento, 3= Moneda, 4= almacen',
  PRIMARY KEY (`idFactores`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factores`
--

LOCK TABLES `factores` WRITE;
/*!40000 ALTER TABLE `factores` DISABLE KEYS */;
INSERT INTO `factores` VALUES (1,'UNIDADES','UNI',0,'5'),(5,'IGV','18',0,'1'),(6,'BOLETA','B',0,'2'),(7,'FACTURA','F',0,'2'),(8,'SOLES','1',0,'3'),(9,'DOLARES','2.50',0,'3'),(10,'ALMACEN 01','ALM 1',0,'4'),(11,'ALMACEN 02','ALM 2',0,'4');
/*!40000 ALTER TABLE `factores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoriam`
--

DROP TABLE IF EXISTS `categoriam`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoriam` (
  `idcategoriaM` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(200) DEFAULT NULL,
  `descripcion` longtext,
  `idCategoriaDepende` int(11) DEFAULT NULL,
  `eliminado` int(11) DEFAULT '0',
  `idUsuario` int(11) DEFAULT '1',
  PRIMARY KEY (`idcategoriaM`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoriam`
--

LOCK TABLES `categoriam` WRITE;
/*!40000 ALTER TABLE `categoriam` DISABLE KEYS */;
INSERT INTO `categoriam` VALUES (1,'CATEGORIA 1','CAT',0,0,1),(2,'CATEGORIA 2','adfasf',0,0,1),(3,'SUBCATEGORIA 1A','SUBCATEGORIA 1A',1,0,4);
/*!40000 ALTER TABLE `categoriam` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalleofertas`
--

DROP TABLE IF EXISTS `detalleofertas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalleofertas` (
  `idDetalleOfertas` int(11) NOT NULL AUTO_INCREMENT,
  `idOferta` int(11) DEFAULT NULL,
  `idMercaderia` int(11) DEFAULT NULL,
  `PrecioReal` decimal(11,2) DEFAULT NULL,
  `fInicio` date DEFAULT NULL,
  `fFin` date DEFAULT NULL,
  `eliminado` int(11) DEFAULT '0',
  `idUsuario` int(11) DEFAULT '1',
  PRIMARY KEY (`idDetalleOfertas`),
  KEY `DK_DO-Oferta` (`idOferta`),
  KEY `DK_DO-Merca` (`idMercaderia`),
  CONSTRAINT `DK_DO-Merca` FOREIGN KEY (`idMercaderia`) REFERENCES `mercaderia` (`idMercaderia`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `DK_DO-Oferta` FOREIGN KEY (`idOferta`) REFERENCES `ofertas` (`idOfertas`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalleofertas`
--

LOCK TABLES `detalleofertas` WRITE;
/*!40000 ALTER TABLE `detalleofertas` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalleofertas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'pydcom_bdventas'
--

--
-- Dumping routines for database 'pydcom_bdventas'
--
/*!50003 DROP PROCEDURE IF EXISTS `Categoria_Actualizar` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = latin1 */ ;
/*!50003 SET character_set_results = latin1 */ ;
/*!50003 SET collation_connection  = latin1_swedish_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`pydcom_michael`@`%.%.%.%`*/ /*!50003 PROCEDURE `Categoria_Actualizar`(
        IN param_idcategoriaM INTEGER(11),
        IN param_nombre VARCHAR(200),
        IN param_descripcion LONGTEXT,
        IN param_idCategoriaDepende INTEGER(11),
        IN param_idUsuario INTEGER(11)
    )
BEGIN
  UPDATE 
    `categoriam`  
  SET 
    `nombre` = param_nombre,
    `descripcion` = param_descripcion,
    `idCategoriaDepende` = param_idCategoriaDepende,
    `idUsuario` = param_idUsuario 
  WHERE 
    `idcategoriaM` = param_idcategoriaM;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Categoria_Anular` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = latin1 */ ;
/*!50003 SET character_set_results = latin1 */ ;
/*!50003 SET collation_connection  = latin1_swedish_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`pydcom_michael`@`%.%.%.%`*/ /*!50003 PROCEDURE `Categoria_Anular`(
        IN param_idcategoriaM INTEGER(11),
        IN param_idUsuario INTEGER(11)
    )
BEGIN
  UPDATE 
    `categoriam`  
  SET 
    `eliminado` = 1,
    `idUsuario` = param_idUsuario 
  WHERE 
    `idcategoriaM` = param_idcategoriaM;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Categoria_Ingresar` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = latin1 */ ;
/*!50003 SET character_set_results = latin1 */ ;
/*!50003 SET collation_connection  = latin1_swedish_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`pydcom_michael`@`%.%.%.%`*/ /*!50003 PROCEDURE `Categoria_Ingresar`(
        IN param_nombre VARCHAR(200),
        IN param_descripcion LONGTEXT,
        IN param_idCategoriaDepende INTEGER(11),
        IN param_idUsuario INTEGER(11)
    )
BEGIN
  INSERT INTO 
    `categoriam`
  (
    `nombre`,
    `descripcion`,
    `idCategoriaDepende`,
    `eliminado`,
    `idUsuario`) 
  VALUE (
    param_nombre,
    param_descripcion,
    param_idCategoriaDepende,
    0,
    param_idUsuario);
    SELECT LAST_INSERT_ID();
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Categoria_Listar` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`pydcom_michael`@`%.%.%.%`*/ /*!50003 PROCEDURE `Categoria_Listar`()
BEGIN
  SELECT 
    `idcategoriaM`,
    `nombre`,
    `idCategoriaDepende`
  FROM 
    `categoriam`
  WHERE 
  eliminado=0;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Categoria_ListarxNombre` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = latin1 */ ;
/*!50003 SET character_set_results = latin1 */ ;
/*!50003 SET collation_connection  = latin1_swedish_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`pydcom_michael`@`%.%.%.%`*/ /*!50003 PROCEDURE `Categoria_ListarxNombre`(
        IN param_nombre VARCHAR(200)
    )
BEGIN
  SELECT 
    `idcategoriaM`,
    `nombre`,
    `descripcion`,
    `idCategoriaDepende`
  FROM 
    `categoriam`
	WHERE nombre=param_nombre;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Consultar_Factores` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`pydcom_michael`@`%.%.%.%`*/ /*!50003 PROCEDURE `Consultar_Factores`(in par_busqueda varchar(20),in tipo_busqueda varchar(20))
BEGIN
    
    if tipo_busqueda = "codigo" then 
        select * from factores where idFactores = parbusqueda;
    else
        if tipo_busqueda = "tabla" then
            select * from factores where tabla = par_busqueda;
        else
            if tipo_busqueda = "concepto" then
                select * from factores where concepto = par_busqueda;
            else
                if tipo_busqueda = "monto" then
                    select * from factores where monto=par_busqueda;
                end if;
            end if;
        end if;
    end if;    
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Mercaderia_Actualizar` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = latin1 */ ;
/*!50003 SET character_set_results = latin1 */ ;
/*!50003 SET collation_connection  = latin1_swedish_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`pydcom_michael`@`%.%.%.%`*/ /*!50003 PROCEDURE `Mercaderia_Actualizar`(
        IN param_idMercaderia INTEGER(11),
        IN param_stockDisponible INTEGER(11),
        IN param_stockMinimo INTEGER(11),
        IN param_precioVenta DECIMAL(11,2),
        IN param_nombre VARCHAR(200),
        IN param_descripcion LONGTEXT,
        IN param_idUndMedida INTEGER(10),
        IN param_idCategoria INTEGER(11),
        IN param_idUsuario INTEGER(11)
    )
BEGIN
  UPDATE 
    `mercaderia`  
  SET 
    `stockDisponible` = param_stockDisponible,
    `stockMinimo` = param_stockMinimo,
    `precioVenta` = param_precioVenta,
    `nombre` = param_nombre,
    `descripcion` = param_descripcion,
    `idUndMedida` = param_idUndMedida,
    `idCategoria` = param_idCategoria,
    `idUsuario` = param_idUsuario 
  WHERE 
    `idMercaderia` = param_idMercaderia;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Mercaderia_actualizarStock` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`root`@`localhost`*/ /*!50003 PROCEDURE `Mercaderia_actualizarStock`(
    in _idMercaderia int,
    in _cantidad int,
    in _SUMAoRESTA varchar(5))
BEGIN
    if _SUMAoRESTA = "SUMA" then
        set @cantidad := (select stockDisponible from mercaderia where idMercaderia = _idMercaderia );
        update mercaderia set stockDisponible = @cantidad + _cantidad where idMercaderia =_idMercaderia;
    else 
        if _SUMAoRESTA = "RESTA" then
            set @cantidad := (select stockDisponible from mercaderia where idMercaderia = _idMercaderia );
            update mercaderia set stockDisponible = @cantidad - _cantidad where idMercaderia =_idMercaderia;
        end if;
    end if;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Mercaderia_Anular` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = latin1 */ ;
/*!50003 SET character_set_results = latin1 */ ;
/*!50003 SET collation_connection  = latin1_swedish_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`pydcom_michael`@`%.%.%.%`*/ /*!50003 PROCEDURE `Mercaderia_Anular`(
        IN param_idMercaderia INTEGER(11),
        IN param_idUsuario INTEGER(11)
    )
BEGIN
  UPDATE 
    `mercaderia`  
  SET 
    `eliminado` = 1,
    `idUsuario` = param_idUsuario 
  WHERE 
    `idMercaderia` = param_idMercaderia;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Mercaderia_Ingresar` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = latin1 */ ;
/*!50003 SET character_set_results = latin1 */ ;
/*!50003 SET collation_connection  = latin1_swedish_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`pydcom_michael`@`%.%.%.%`*/ /*!50003 PROCEDURE `Mercaderia_Ingresar`(
        IN param_stockDisponible INTEGER(11),
        IN param_stockMinimo INTEGER(11),
        IN param_precioVenta DECIMAL(11,2),
        IN param_nombre VARCHAR(200),
        IN param_descripcion LONGTEXT,
        IN param_idUndMedida INTEGER(10),
        IN param_idCategoria INTEGER(11),
        IN param_idUsuario INTEGER(11)
    )
BEGIN
  INSERT INTO 
    `mercaderia`
  (
    `stockDisponible`,
    `stockMinimo`,
    `precioVenta`,
    `nombre`,
    `descripcion`,
    `idUndMedida`,
    `idCategoria`,
    `eliminado`,
    `idUsuario`) 
  VALUE (
    param_stockDisponible,
    param_stockMinimo,
    param_precioVenta,
    param_nombre,
    param_descripcion,
    param_idUndMedida,
    param_idCategoria,
    0,
    param_idUsuario);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Mercaderia_ListarxIdCategoria` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`pydcom_michael`@`%.%.%.%`*/ /*!50003 PROCEDURE `Mercaderia_ListarxIdCategoria`(
        IN param_idCategoria INTEGER(11)
    )
BEGIN
select 
                        mercaderia.idMercaderia 'codMercaderia',
                        mercaderia.stockDisponible,
                        mercaderia.stockMinimo,
                        mercaderia.precioVenta,
                        mercaderia.nombre,
                        mercaderia.descripcion,
                        mercaderia.idUndMedida,
                        unidadmedida.descripcion'unidadMedida',
                        mercaderia.idCategoria,
                        categoriam.nombre'Categoria'
                        from mercaderia inner join categoriam
                        on mercaderia.idCategoria=categoriam.idcategoriaM inner join unidadmedida
                        on mercaderia.idUndMedida=unidadmedida.idUnidadMedida
                        where 
                        mercaderia.eliminado=0 and
                        mercaderia.idCategoria=param_idCategoria;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Mercaderia_ListarxIdCategoriaxNombre` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = latin1 */ ;
/*!50003 SET character_set_results = latin1 */ ;
/*!50003 SET collation_connection  = latin1_swedish_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`pydcom_michael`@`%.%.%.%`*/ /*!50003 PROCEDURE `Mercaderia_ListarxIdCategoriaxNombre`(
        IN param_idCategoria INTEGER(11),
        IN param_nombre VARCHAR(200)
    )
BEGIN
select 
mercaderia.idMercaderia 'codMercaderia',
mercaderia.stockDisponible,
mercaderia.stockMinimo,
mercaderia.precioVenta,
mercaderia.nombre,
mercaderia.descripcion,
mercaderia.idUndMedida,
unidadmedida.descripcion'unidadMedida',
mercaderia.idCategoria,
categoriam.nombre'Categoria'
from mercaderia inner join categoriam
on mercaderia.idCategoria=categoriam.idcategoriaM inner join unidadmedida
on mercaderia.idUndMedida=unidadmedida.idUnidadMedida
where 
mercaderia.eliminado=0 and
mercaderia.idCategoria=param_idCategoria and
mercaderia.`nombre` like concat('%',param_nombre,'%');
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `operarFechas_Tabla` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`pydcom_michael`@`%.%.%.%`*/ /*!50003 PROCEDURE `operarFechas_Tabla`(in tabla varchar(20), in att varchar(20), in fch1 varchar(20), in fch2 varchar(20), in cod int)
BEGIN
	case
		when tabla = "Mercaderia" then
			case
				when att = "FechaCompra" then select * from existencias where fechaAdquisicion between fch1 and fch2;
        when att = "FechaVencimiento" then select * from existencias where fechaVencimiento between fch1 and fch2;
			end case;
    when tabla = "Movimiento" then
			case
				when att = "Fecha" then select * from existencias where fecha between fch1 and fch2;
        when att = "Hora" then select * from existencias where hora between fch1 and fch2;
			end case;	
		when tabla = "Ofertas" then
			case
				when att = "FechaInicio" then select * from detalleofertas where fInicio between fch1 and fch2;
				when att = "FechaFin" then select * from detalleofertas where fFin between fch1 and fch2;					
			end case;
		when tabla = "Persona" then
			case
				when att = "FechaNacimiento" then select * from persona where fechaNacimiento between fch1 and fch2;
				when att = "FechaRegistro" then select * from persona where fechaRegistro between fch1 and fch2;
			end case;
			
	end case;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `operar_tabla` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`root`@`localhost`*/ /*!50003 PROCEDURE `operar_tabla`(in tabla varchar(20),in parm varchar(20),in t_accion varchar(1),in att varchar(20), in cod int)
BEGIN
    case 
		when tabla = "Categorias" then
			case
				when t_accion = "C" then
					case
						when att = "Codigo" then 
							select c1.idCategoriaM, c1.nombre, c1.descripcion, c2.nombre as Padre, c1.eliminado
							from categoriam c1 inner join categoriam c2 on c1.idCategoriaDepende = c2.idCategoriaM
							where c1.idcategoriaM = parm and c1.eliminado = 0;
                            
						when att = "Nombre" then                        
							select c1.idCategoriaM, c1.nombre, c1.descripcion, c2.nombre as Padre, c1.eliminado
							from categoriam c1 inner join categoriam c2 on c1.idCategoriaDepende = c2.idCategoriaM
							where c1.nombre = parm and c1.eliminado = 0;
                            
						when att = "Descripcion" then                        
							select c1.idCategoriaM, c1.nombre, c1.descripcion, c2.nombre as Padre, c1.eliminado
							from categoriam c1 inner join categoriam c2 on c1.idCategoriaDepende = c2.idCategoriaM
							where c1.descripcion = parm and c1.eliminado = 0;
                            
						when att = "Padre" then                        
							select c1.idCategoriaM, c1.nombre, c1.descripcion, c2.nombre as Padre, c1.eliminado
							from categoriam c1 inner join categoriam c2 on c1.idCategoriaDepende = c2.idCategoriaM
							where c2.nombre = parm and c1.eliminado = 0;
                            
            when att = "Todos" then select * from categoriam where eliminado = 0;
                            
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
						when att = "Codigo" then select * from existencias where idExistencias = parm and eliminado = 0;
						when att = "CodigoBar" then select * from existencias where codInternoMercaderia = parm and eliminado = 0;
						when att = "PrecioCompra" then select * from existencias where precioUnitario = parm and eliminado = 0;
						when att = "PrecioVenta" then select * from existencias where precioAdquisicion = parm and eliminado = 0;						
						when att = "Estado" then select * from existencias where estadoMercaderia = parm and eliminado = 0;
						when att = "Ubicacion" then select * from existencias where idUbicacion = parm and eliminado = 0;
						when att = "NroMovimiento" then select * from existencias where idMovimiento = parm and eliminado = 0;
            when att = "Mercaderia" then select * from existencias where idMercaderia = parm and eliminado = 0;
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
							select m.idMercaderia, m.StockDisponible, m.StockMinimo, m.PrecioVenta, m.Nombre, um.valor, c.nombre
							from mercaderia m inner join unidadmedida um on m.idUndMedida = um.idUnidadMedida
							inner join categoriam c on m.idCategoria = c.idcategoriaM
							where m.Nombre = parm and m.eliminado = 0;
                            
						when att = "UnidadMedida" then
							select m.idMercaderia, m.StockDisponible, m.StockMinimo, m.PrecioCompra, m.PrecioVenta, m.Nombre, um.valor, c.nombre
							from mercaderia m inner join unidadmedida um on m.idUndMedida = um.idUnidadMedida
							inner join categoriam c on m.idCategoria = c.idcategoriaM
							where um.valor = parm and m.eliminado = 0;
                            
						when att = "Categoria" then
							select m.idMercaderia as Codigo, m.StockDisponible as Stock, m.Nombre as Mercaderia, c.nombre as Categoria
              from mercaderia m inner join categoriam c on m.idCategoria = c.idcategoriaM
              where c.idcategoriaM = parm and m.eliminado = 0;
              
						when att = "AProduccion" then
							select m.idMercaderia as Codigo, m.StockDisponible as Stock, m.Nombre as Mercaderia, c.nombre as Categoria
              from mercaderia m inner join categoriam c on m.idCategoria = c.idcategoriaM
              where m.idMercaderia = parm and m.eliminado = 0;              
                            
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
                when att = "Codigo" then 
                    select mov.idMovimiento,mov.tipoMovimiento,mov.fecha,mov.hora,contact(p.primerNombre+""+p.segundoNombre) as Cliente, o.ecuacion, mov.UbicacionInicial,mov.UbicacionFinal,m.nombre,mov.montoPago
                    from movimiento mov inner join persona p on mov.idPersona = p.idPersona inner join ofertas o on mov.idOferta = o.idOfertas inner join mercaderia m on mov.idMercaderia = m.idMercaderia
                    where mov.idMovimiento = parm and mov.eliminado = 0;
                    
                when att = "TipoMovimiento" then
                    select mov.idMovimiento,mov.tipoMovimiento,mov.fecha,mov.hora,contact(p.primerNombre+""+p.segundoNombre) as Cliente, o.ecuacion, mov.UbicacionInicial,mov.UbicacionFinal,m.nombre,mov.montoPago
                    from movimiento mov inner join persona p on mov.idPersona = p.idPersona inner join ofertas o on mov.idOferta = o.idOfertas inner join mercaderia m on mov.idMercaderia = m.idMercaderia
                    where mov.tipoMovimiento = parm and mov.eliminado = 0;
                    
                when att = "Persona" then
                    select mov.idMovimiento,mov.tipoMovimiento,mov.fecha,mov.hora,contact(p.primerNombre+""+p.segundoNombre) as Cliente, o.ecuacion, mov.UbicacionInicial,mov.UbicacionFinal,m.nombre,mov.montoPago
                    from movimiento mov inner join persona p on mov.idPersona = p.idPersona inner join ofertas o on mov.idOferta = o.idOfertas inner join mercaderia m on mov.idMercaderia = m.idMercaderia
                    where mov.idPersona = parm and mov.eliminado = 0;
                    
                when att = "Oferta" then
                    select mov.idMovimiento,mov.tipoMovimiento,mov.fecha,mov.hora,contact(p.primerNombre+""+p.segundoNombre) as Cliente, o.ecuacion, mov.UbicacionInicial,mov.UbicacionFinal,m.nombre,mov.montoPago
                    from movimiento mov inner join persona p on mov.idPersona = p.idPersona inner join ofertas o on mov.idOferta = o.idOfertas inner join mercaderia m on mov.idMercaderia = m.idMercaderia
                    where mov.idOferta = parm and mov.eliminado = 0;
                    
                when att = "UbicacionInicial" then
                    select mov.idMovimiento,mov.tipoMovimiento,mov.fecha,mov.hora,contact(p.primerNombre+""+p.segundoNombre) as Cliente, o.ecuacion, mov.UbicacionInicial,mov.UbicacionFinal,m.nombre,mov.montoPago
                    from movimiento mov inner join persona p on mov.idPersona = p.idPersona inner join ofertas o on mov.idOferta = o.idOfertas inner join mercaderia m on mov.idMercaderia = m.idMercaderia
                    where mov.UbicacionInicial = parm and mov.eliminado = 0;
                    
                when att = "UbicacionFinal" then
                    select mov.idMovimiento,mov.tipoMovimiento,mov.fecha,mov.hora,contact(p.primerNombre+""+p.segundoNombre) as Cliente, o.ecuacion, mov.UbicacionInicial,mov.UbicacionFinal,m.nombre,mov.montoPago
                    from movimiento mov inner join persona p on mov.idPersona = p.idPersona inner join ofertas o on mov.idOferta = o.idOfertas inner join mercaderia m on mov.idMercaderia = m.idMercaderia
                    where mov.UbicacionFinal = parm and mov.eliminado = 0;
                    
                when att = "Mercaderia" then
                    select mov.idMovimiento,mov.tipoMovimiento,mov.fecha,mov.hora,contact(p.primerNombre+""+p.segundoNombre) as Cliente, o.ecuacion, mov.UbicacionInicial,mov.UbicacionFinal,m.nombre,mov.montoPago
                    from movimiento mov inner join persona p on mov.idPersona = p.idPersona inner join ofertas o on mov.idOferta = o.idOfertas inner join mercaderia m on mov.idMercaderia = m.idMercaderia
                    where mov.idMercaderia = parm and mov.eliminado = 0;
                    
                when att = "MontoPago" then
                    select mov.idMovimiento,mov.tipoMovimiento,mov.fecha,mov.hora,contact(p.primerNombre+""+p.segundoNombre) as Cliente, o.ecuacion, mov.UbicacionInicial,mov.UbicacionFinal,m.nombre,mov.montoPago
                    from movimiento mov inner join persona p on mov.idPersona = p.idPersona inner join ofertas o on mov.idOferta = o.idOfertas inner join mercaderia m on mov.idMercaderia = m.idMercaderia
                    where mov.montoPago = parm and mov.eliminado = 0;  
                    
            end case;
        when t_accion = "M" then
            case
                when att = "TipoMovimiento" then update movimiento set tipoMovimiento = parm where idMovimiento = cod;
                when att = "Fecha" then update movimiento set fecha = parm where idMovimiento = cod;
                when att = "Hora" then update movimiento set hora = parm where idMovimiento = cod;
                when att = "Persona" then update movimiento set idPersona = parm where idMovimiento = cod;
                when att = "Oferta" then update movimiento set idOferta = parm where idMovimiento = cod;
                when att = "UbicacionInicial" then update movimiento set UbicacionInicial = parm where idMovimiento = cod;
                when att = "UbicacionFinal" then update movimiento set UbicacionFinal = parm where idMovimiento = cod;                     
                when att = "Mercaderia" then update movimiento set idMercaderia = parm where idMovimiento = cod;                     
                when att = "MontoPago" then update movimiento set montoPago = parm where idMovimiento = cod;                     
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
        case
            when att = "Codigo" then select u.Login, ua.NomTabla, ua.idTabla, ua.tipoAccion from UsuarioAccion ua inner join usuario u on ua.idUsuario=u.idUsuario where ua.idUsuarioAccion=parm;
            when att = "idUsuario" then select u.Login, ua.NomTabla, ua.idTabla, ua.tipoAccion from UsuarioAccion ua inner join usuario u on ua.idUsuario=u.idUsuario where ua.idUsuario=parm;
            when att = "NombreUsuario" then select u.Login, ua.NomTabla, ua.idTabla, ua.tipoAccion from UsuarioAccion ua inner join usuario u on ua.idUsuario=u.idUsuario where u.Login=parm;
            when att = "Tabla" then select u.Login, ua.NomTabla, ua.idTabla, ua.tipoAccion from UsuarioAccion ua inner join usuario u on ua.idUsuario=u.idUsuario where ua.NomTabla=parm;
            when att = "codEnTabla" then select u.Login, ua.NomTabla, ua.idTabla, ua.tipoAccion from UsuarioAccion ua inner join usuario u on ua.idUsuario=u.idUsuario where ua.idTabla=parm;
            when att = "tipoAccion" then select u.Login, ua.NomTabla, ua.idTabla, ua.tipoAccion from UsuarioAccion ua inner join usuario u on ua.idUsuario=u.idUsuario where ua.tipoAccion=parm;
        end case; 		  
		when tabla = "Traspasos" then
      select * from DatosTraspasos;
		when tabla = "DetalleMovimiento" then
			case
				when t_accion = "C" then
					case
						when att = "Codigo" then select * from detallemovimiento where idDetalleMovimiento = parm;
						when att = "Mercaderia" then select * from detallemovimiento where idMercaderia = parm;
						when att = "Movimiento" then select * from detallemovimiento where idMovimiento = parm;
						when att = "Precio" then select * from detallemovimiento where precio = parm;
						when att = "Cantidad" then select * from detallemovimiento where cantidad = parm;
						when att = "SubTotal" then select * from detallemovimiento where subtotal = parm;
						when att = "Descuento" then select * from detallemovimiento where descuento = parm;
						when att = "Total" then select * from detallemovimiento where total = parm;
						when att = "Oferta" then select * from detallemovimiento where idOferta = parm;
					end case;					
				when t_accion = "M" then
					case
						when att = "Mercaderia" then update detallemovimiento set idMercaderia=parm where idDetalleMovimiento=cod;
						when att = "Movimiento" then update detallemovimiento set idMovimiento=parm where idDetalleMovimiento=cod;
						when att = "Precio" then update detallemovimiento set precio=parm where idDetalleMovimiento=cod;
						when att = "Cantidad" then update detallemovimiento set cantidad=parm where idDetalleMovimiento=cod;
						when att = "SubTotal" then update detallemovimiento set subtotal=parm where idDetalleMovimiento=cod;
						when att = "Descuento" then update detallemovimiento set descuento=parm where idDetalleMovimiento=cod;
						when att = "Total" then update detallemovimiento set total=parm where idDetalleMovimiento=cod;
						when att = "Oferta" then update detallemovimiento set idOferta=parm where idDetalleMovimiento=cod;
					end case;
				when t_accion = "E" then update detallemovimiento set eliminado=parm where idDetalleMovimiento=cod;				
			end case;
    end case;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `persona_ListarxNombre` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`pydcom_michael`@`%.%.%.%`*/ /*!50003 PROCEDURE `persona_ListarxNombre`(
        in param_nombre varchar(200)
)
BEGIN
        select 
        idPersona,
        concat(segundoNombre,' ',primerNombre)'nombre'
        from persona
        where eliminado=0 and
        concat(segundoNombre,primerNombre) like concat('%',param_nombre,'%')and
        tipoIdentificacion='P';
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `UnidadMedida_Listar` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = latin1 */ ;
/*!50003 SET character_set_results = latin1 */ ;
/*!50003 SET collation_connection  = latin1_swedish_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50020 DEFINER=`pydcom_michael`@`%.%.%.%`*/ /*!50003 PROCEDURE `UnidadMedida_Listar`()
BEGIN
  SELECT 
    `idUnidadMedida`,
    `descripcion`
  FROM 
    `unidadmedida`
  WHERE eliminado=0;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-06-03 13:14:54
