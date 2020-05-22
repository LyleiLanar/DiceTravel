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
-- Table structure for table `trips`
--

DROP TABLE IF EXISTS `trips`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trips` (
  `id` int NOT NULL AUTO_INCREMENT COMMENT 'Trip adatai\n',
  `journey_id` int NOT NULL COMMENT 'A triphez tartozó journey_id\n',
  `serial_number` int NOT NULL COMMENT 'Ez határozza meg az egy journeybe tartozó tripek sorrendjét.\n',
  `end_location` varchar(20) COLLATE utf8_hungarian_ci NOT NULL COMMENT 'Itt van eltárolva a trip célállomása.\n',
  `end_date` datetime DEFAULT NULL COMMENT 'Ez mutatja meg, hogy vége van-e a tripnek. Ha a Journeynek van olyan tripje, ami null, akkor az az aktív.\\n',
  `visibility` int NOT NULL DEFAULT '0' COMMENT 'A trip láthatósága. (2: public, 1: friendOnly, 0: private)\n',
  PRIMARY KEY (`id`),
  KEY `journey_id_idx` (`journey_id`),
  CONSTRAINT `journey_id` FOREIGN KEY (`journey_id`) REFERENCES `journeys` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=252 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci COMMENT='Trips tábla, ez tárolja a tripek adatait.\n';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trips`
--

LOCK TABLES `trips` WRITE;
/*!40000 ALTER TABLE `trips` DISABLE KEYS */;
INSERT INTO `trips` VALUES (245,200,0,'A','2020-03-13 08:06:53',2),(246,200,1,'B','2020-03-13 08:07:56',0),(247,201,0,'B','2020-03-13 08:31:47',0),(248,201,1,'E','2020-05-14 21:51:16',0),(249,202,0,'Szilvás','2020-05-14 21:53:38',1),(250,202,1,'Eger','2020-05-14 21:54:04',1),(251,202,2,'Hatvan','2988-11-08 00:00:00',1);
/*!40000 ALTER TABLE `trips` ENABLE KEYS */;
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
