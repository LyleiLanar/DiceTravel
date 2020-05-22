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
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT COMMENT 'User azonoító.\n',
  `login_name` varchar(20) COLLATE utf8_hungarian_ci NOT NULL DEFAULT '' COMMENT 'A  user egyedi neve a rendszerben.',
  `pswd` varchar(32) COLLATE utf8_hungarian_ci NOT NULL DEFAULT '' COMMENT 'A user jelszavának md5  hash kódja.',
  `sur_name` varchar(20) COLLATE utf8_hungarian_ci DEFAULT NULL COMMENT 'A user keresztneve.\n',
  `first_name` varchar(20) COLLATE utf8_hungarian_ci DEFAULT NULL COMMENT 'A user vezetékneve.\\n',
  `birth_date` date DEFAULT NULL COMMENT 'A user születési dátuma',
  PRIMARY KEY (`id`),
  UNIQUE KEY `login_name_UNIQUE` (`login_name`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci COMMENT='A userekkel kapcsolatos információkat tartalmazó tábla.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (23,'Patrik','1234','Molnár','Patrik','1988-11-08'),(24,'Tündi','1234','Töttő','Tünde','1985-07-24'),(25,'dani','1234','Kiss','Dániel','1988-11-17'),(26,'Ricsi','1234','Lajos','Richárd','1993-05-10'),(27,'Csaba','1234','Lakatos','Csaba','1977-10-10'),(28,'Lylei','1234','Molnár','Patrik','1988-11-08'),(30,'Emperor','1234','Lukács','Dávid','2020-02-12'),(31,'Disznó','1234','Kiss','Éva','2020-02-19'),(34,'Pokolka','1234','Véres','Hurka','1988-11-11'),(35,'Tünde','mama','ma','ma','2020-02-19'),(46,'Proba111','1234','Kicsi','John','2020-02-28'),(50,'Kacsa','1','k','k','2020-03-05'),(51,'d','123','123','13','2020-03-05'),(52,'Teszt2','1234','sdfd','sdf','2020-03-05');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
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
