-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: dice_travel
-- ------------------------------------------------------
-- Server version	8.0.19

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
-- Table structure for table `journeys`
--

DROP TABLE IF EXISTS `journeys`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `journeys` (
  `id` int NOT NULL AUTO_INCREMENT COMMENT 'Journey azonosító\n',
  `user_id` int NOT NULL COMMENT 'User azonosítója\n',
  `title` varchar(50) COLLATE utf8_hungarian_ci NOT NULL DEFAULT 'Új Utazás',
  `start_location` varchar(20) COLLATE utf8_hungarian_ci NOT NULL COMMENT 'journey kiindulópontja\n',
  `start_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'journey indulási dátuma\\n',
  `closed` int NOT NULL DEFAULT '0' COMMENT 'Megmutatja, hogy véget ért-e a journey.\n',
  `visibility` int NOT NULL DEFAULT '0' COMMENT 'A journey láthatósága. (2: public, 1: friendOnly, 0: private)\\n',
  PRIMARY KEY (`id`),
  KEY `creatorUser_idx` (`user_id`),
  CONSTRAINT `creatorUser` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=203 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci COMMENT='Journey tábla, ez tárolja a journey indulási adatait\n';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `journeys`
--

LOCK TABLES `journeys` WRITE;
/*!40000 ALTER TABLE `journeys` DISABLE KEYS */;
INSERT INTO `journeys` VALUES (200,23,'Journey1','A','2020-03-11 16:30:16',1,1),(201,23,'Journey2','A','2020-03-13 08:31:19',1,0),(202,23,'Bükk túra','Ózd','2020-05-14 21:51:43',0,1);
/*!40000 ALTER TABLE `journeys` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-22 17:33:18
