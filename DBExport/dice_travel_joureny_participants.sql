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
-- Table structure for table `joureny_participants`
--

DROP TABLE IF EXISTS `joureny_participants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `joureny_participants` (
  `user_id` int NOT NULL AUTO_INCREMENT COMMENT 'User azonosító\n',
  `journey_id` int NOT NULL DEFAULT '-1' COMMENT 'Journey azonosító\n(-1 esetlben nem lett létrehozva neki journey. ez baj)',
  `accepted` int NOT NULL DEFAULT '0' COMMENT 'Ez mutatja meg, hogy az adott felhasználó elfogadta-e már a journey invitációt. (1:elfogadta; 0: elutasította)\n',
  PRIMARY KEY (`user_id`),
  KEY `journey_id_connect_idx` (`journey_id`),
  CONSTRAINT `journey_id_connect` FOREIGN KEY (`journey_id`) REFERENCES `journeys` (`id`),
  CONSTRAINT `user_id_connect` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci COMMENT='User - Journey kapcsolótábla, hogy kik melyik Journey-n vesznek, vettek részt. Egy usernek egyszerre csak egy aktív journey-je lehet.\n';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `joureny_participants`
--

LOCK TABLES `joureny_participants` WRITE;
/*!40000 ALTER TABLE `joureny_participants` DISABLE KEYS */;
/*!40000 ALTER TABLE `joureny_participants` ENABLE KEYS */;
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
