-- MySQL dump 10.13  Distrib 8.0.46, for Win64 (x86_64)
--
-- Host: localhost    Database: poo
-- ------------------------------------------------------
-- Server version	9.6.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
SET @MYSQLDUMP_TEMP_LOG_BIN = @@SESSION.SQL_LOG_BIN;
SET @@SESSION.SQL_LOG_BIN= 0;

--
-- GTID state at the beginning of the backup 
--

SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ '12b480e2-3f28-11f1-aba2-74d4dd44d88d:1-1072';

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleados` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Edad` tinyint(1) NOT NULL,
  `Salario` decimal(8,2) NOT NULL,
  `Clave_Unica` int NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (1,'Josue',22,15000.00,159753),(2,'Omar',24,50000.00,951357),(5,'Wendy',22,75000.00,456852),(6,'Jose',57,75000.00,258654);
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(200) NOT NULL,
  `Precio` decimal(7,2) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'Tequila Cuervo Especial Reposado 990 ml',193.00),(3,'Tequila Jose Cuervo Especial Plata 990 ml',261.00),(4,'Cerveza Clara Coronita Extra 24 Pack Botellas 210 ml',285.00);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventaproductos`
--

DROP TABLE IF EXISTS `ventaproductos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventaproductos` (
  `IDventaproducto` int NOT NULL AUTO_INCREMENT,
  `IDventa` int NOT NULL,
  `IDproductos` int NOT NULL,
  `Cantidad` tinyint(1) NOT NULL,
  `Total` decimal(8,2) NOT NULL,
  PRIMARY KEY (`IDventaproducto`),
  KEY `fk_ventaproductos_productos` (`IDproductos`),
  KEY `fk_ventaproductos_ventas` (`IDventa`),
  CONSTRAINT `fk_ventaproductos_productos` FOREIGN KEY (`IDproductos`) REFERENCES `productos` (`ID`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_ventaproductos_ventas` FOREIGN KEY (`IDventa`) REFERENCES `ventas` (`IDventa`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventaproductos`
--

LOCK TABLES `ventaproductos` WRITE;
/*!40000 ALTER TABLE `ventaproductos` DISABLE KEYS */;
INSERT INTO `ventaproductos` VALUES (1,2026100501,1,3,579.00),(2,2026100501,3,8,2088.00),(3,2026100502,4,5,1425.00),(4,2026100502,3,8,2088.00),(5,2026100502,1,7,1351.00),(6,2026100801,1,4,772.00),(7,2026100801,4,5,1425.00);
/*!40000 ALTER TABLE `ventaproductos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventas` (
  `IDventa` int NOT NULL,
  `IDempleado` int NOT NULL,
  `Fecha` datetime NOT NULL,
  `Total` decimal(7,2) DEFAULT NULL,
  PRIMARY KEY (`IDventa`),
  KEY `fk_ventas_empleados` (`IDempleado`),
  CONSTRAINT `fk_ventas_empleados` FOREIGN KEY (`IDempleado`) REFERENCES `empleados` (`ID`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
INSERT INTO `ventas` VALUES (2026100501,1,'2026-10-05 12:15:59',2667.00),(2026100502,5,'2026-10-05 12:19:45',4864.00),(2026100801,1,'2026-10-08 16:02:51',2197.00);
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;
SET @@SESSION.SQL_LOG_BIN = @MYSQLDUMP_TEMP_LOG_BIN;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-10-08 16:06:15
