CREATE DATABASE  IF NOT EXISTS `sh_bom` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `sh_bom`;
-- MySQL dump 10.13  Distrib 5.7.21, for Win32 (AMD64)
--
-- Host: localhost    Database: sh_bom
-- ------------------------------------------------------
-- Server version	8.0.13

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
-- Table structure for table `detail`
--

DROP TABLE IF EXISTS `detail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detail` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `PartNumber` varchar(200) NOT NULL,
  `Price` decimal(13,2) DEFAULT NULL,
  `Name` varchar(200) DEFAULT NULL,
  `Material` varchar(200) DEFAULT NULL,
  `Length` double DEFAULT NULL,
  `Remark` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detail`
--

LOCK TABLES `detail` WRITE;
/*!40000 ALTER TABLE `detail` DISABLE KEYS */;
INSERT INTO `detail` VALUES (1,'680.00.030.00--',777.00,'a','hii',1,'3'),(2,'680.00.050.002',44.00,'b','AI 83x53',14.55,'fff'),(3,'680.00.050.003',11.00,'h','Plaat 3mm',-24,'sssss'),(4,'680.00.050.004',55.00,'c','Ck45 15x15',1144,'fghf'),(5,'680.00.050.005',22.00,'d','zzz',33.44,'zzzz'),(6,'680.00.050.004',3.00,'AZE','GT 40x6',9,'gg'),(7,'z',4.00,'fsfd','ffffff',4,'53453'),(8,'680.00.030.006',0.00,'','ddas',0,NULL),(9,'My b',23.00,'qwe','ddas',222,'hghfhfghfg'),(10,'abc',122.00,'Defr','Test Ø ',435,'Def'),(11,'00',NULL,'','GT 40x6',0,'Hello this is a test'),(12,'asd',NULL,'','Test Ø ',0,NULL),(13,'Zxc',44.00,'dasa','ddas',12,'Reg'),(14,'43',44.00,'de','ddas',12,'tt'),(15,'Wait',NULL,'sdf','dsf',222,'Ref'),(16,'zxc',NULL,'','fd',0,NULL),(17,'scsdqf',0.00,'44545','ff',0,'454'),(18,'45',NULL,'45','zzz',0,NULL),(19,'45',0.00,'45','d   ',0,NULL),(20,'xxx',NULL,'','AI 83x53',0,''),(21,'cv',NULL,'fff','as',0,NULL),(22,'ggg',444.00,'ghghf','d   ',1233,'fdsfdsfdsfs'),(23,'234',NULL,NULL,NULL,0,NULL),(24,'yolo',NULL,'','',0,'');
/*!40000 ALTER TABLE `detail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detailmachine`
--

DROP TABLE IF EXISTS `detailmachine`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detailmachine` (
  `MachineId` int(11) NOT NULL,
  `DetailId` int(11) NOT NULL,
  `Qty` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`MachineId`,`DetailId`),
  UNIQUE KEY `unique_machine_detail` (`MachineId`,`DetailId`),
  KEY `fk_detail_idx` (`DetailId`),
  CONSTRAINT `fk_detail` FOREIGN KEY (`DetailId`) REFERENCES `detail` (`id`),
  CONSTRAINT `fk_machine` FOREIGN KEY (`MachineId`) REFERENCES `machine` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detailmachine`
--

LOCK TABLES `detailmachine` WRITE;
/*!40000 ALTER TABLE `detailmachine` DISABLE KEYS */;
INSERT INTO `detailmachine` VALUES (1,1,7),(1,2,1),(1,3,2),(1,4,10),(1,5,4),(1,9,1),(1,10,11),(2,1,30),(2,2,31),(3,1,85),(3,2,1),(3,4,1),(4,1,1),(5,1,1),(5,2,1),(5,3,1),(5,4,1),(5,5,1),(5,6,1),(5,7,1),(5,8,1),(5,9,1),(5,10,1),(5,11,1),(7,1,22),(7,2,1),(11,1,147),(11,11,1),(11,13,1),(15,1,1),(15,2,1),(15,3,1),(15,4,1),(15,5,1),(15,6,1),(15,7,1),(15,11,200),(23,1,1),(23,2,1),(23,3,1),(23,4,1),(23,5,1),(23,6,1),(23,8,1);
/*!40000 ALTER TABLE `detailmachine` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `machine`
--

DROP TABLE IF EXISTS `machine`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `machine` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(200) NOT NULL,
  `CreatedOnUtc` datetime NOT NULL,
  `UpdatedOnUtc` datetime DEFAULT NULL,
  `Deleted` bit(1) DEFAULT b'0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `machine`
--

LOCK TABLES `machine` WRITE;
/*!40000 ALTER TABLE `machine` DISABLE KEYS */;
INSERT INTO `machine` VALUES (1,'Dem12-','2020-04-01 10:38:26','2020-04-01 10:38:26',''),(2,'BFP','2020-04-01 10:38:36','2020-04-01 10:38:36',''),(3,'Aanvoer','2020-04-01 10:38:48','2020-04-01 10:38:48',''),(4,'Default','2020-04-02 05:34:11','2020-04-02 05:34:11',''),(5,'Test','2020-04-02 05:34:14','2020-04-02 05:34:14','\0'),(6,'fg','2020-04-02 06:08:52','2020-04-02 06:08:52','\0'),(7,'4444','2020-04-02 06:18:10','2020-04-02 06:18:10','\0'),(8,'df','2020-04-02 10:02:55','2020-04-02 10:02:55','\0'),(9,'2','2020-04-02 10:02:56','2020-04-02 10:02:56','\0'),(10,'3','2020-04-02 10:05:42','2020-04-02 10:05:42','\0'),(11,'4','2020-04-02 10:40:52','2020-04-02 10:40:52','\0'),(12,'asd','2020-04-06 05:56:55','2020-04-07 11:31:15','\0'),(13,'sff','2020-04-06 06:07:20','2020-04-07 11:31:17','\0'),(14,'cxzcxz','2020-04-06 06:07:21','2020-04-07 11:31:20','\0'),(15,'fgds','2020-04-07 06:40:22','2020-04-07 11:31:22','\0'),(16,'ccccc___','0001-01-01 00:00:00','0001-01-01 00:00:00','\0'),(17,'vv','0001-01-01 00:00:00','0001-01-01 00:00:00','\0'),(18,'hallo','2020-04-07 11:32:15','2020-04-07 11:32:15',''),(19,'k0','2020-04-07 11:33:19','2020-04-07 11:33:19',''),(20,'tt','2020-04-08 06:29:18','2020-04-08 06:29:18','\0'),(21,'hh','2020-04-08 06:46:04','2020-04-08 06:46:04','\0'),(22,'kk','2020-04-08 06:50:41','2020-04-08 06:50:41','\0'),(23,'66','2020-04-08 06:50:47','2020-04-08 06:50:47','\0'),(24,',,,','2020-04-08 06:50:49','2020-04-08 06:50:49','\0'),(25,'utyutyut','2020-04-08 06:50:53','2020-04-08 06:50:53','\0'),(26,'zczxcxz','2020-04-08 06:50:57','2020-04-08 06:50:57','');
/*!40000 ALTER TABLE `machine` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'sh_bom'
--

--
-- Dumping routines for database 'sh_bom'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-04-08 15:23:17
