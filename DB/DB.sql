-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: gymsys_db
-- ------------------------------------------------------
-- Server version	8.0.18

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

--
-- Table structure for table `commodity_tb`
--

DROP TABLE IF EXISTS `commodity_tb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `commodity_tb` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `type` varchar(45) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `purchasingprice` double DEFAULT NULL,
  `price` double DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `commodity_tb`
--

LOCK TABLES `commodity_tb` WRITE;
/*!40000 ALTER TABLE `commodity_tb` DISABLE KEYS */;
INSERT INTO `commodity_tb` VALUES (1,'笔','支/元',416,0.5,2),(2,'水','瓶/元',977,1,2.5),(3,'面包','个/元',75,2,5),(4,'西瓜','斤/元',100,1,3),(5,'啤酒','打/元',99,30,70),(20,'牛奶','袋/元',10,2,6),(21,'牛奶1','袋/元',10,2,6);
/*!40000 ALTER TABLE `commodity_tb` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consumption_tb`
--

DROP TABLE IF EXISTS `consumption_tb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `consumption_tb` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `totalin` double DEFAULT NULL,
  `totalout` double DEFAULT NULL,
  `time` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consumption_tb`
--

LOCK TABLES `consumption_tb` WRITE;
/*!40000 ALTER TABLE `consumption_tb` DISABLE KEYS */;
INSERT INTO `consumption_tb` VALUES (1,2000,1000,'2023-08-01'),(2,4500,2000,'2023-08-03');
/*!40000 ALTER TABLE `consumption_tb` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `member_tb`
--

DROP TABLE IF EXISTS `member_tb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `member_tb` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `userid` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `balance` double DEFAULT NULL,
  `permission` varchar(4) DEFAULT NULL,
  `createtime` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=cp1250;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `member_tb`
--

LOCK TABLES `member_tb` WRITE;
/*!40000 ALTER TABLE `member_tb` DISABLE KEYS */;
INSERT INTO `member_tb` VALUES (18,'sa','123',92,'0','2023-08-09'),(22,'cp','123',0,'777','2023-08-09');
/*!40000 ALTER TABLE `member_tb` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-09-26 10:46:53
