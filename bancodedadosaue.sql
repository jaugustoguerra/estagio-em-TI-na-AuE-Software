-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: aueolucoes
-- ------------------------------------------------------
-- Server version	8.0.31

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
-- Table structure for table `tabelacontatos`
--

DROP TABLE IF EXISTS `tabelacontatos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tabelacontatos` (
  `nome` varchar(255) DEFAULT NULL,
  `sexo` enum('masculino','feminino') DEFAULT NULL,
  `cidade` varchar(255) DEFAULT NULL,
  `data_nascimento` date DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tabelacontatos`
--

LOCK TABLES `tabelacontatos` WRITE;
/*!40000 ALTER TABLE `tabelacontatos` DISABLE KEYS */;
INSERT INTO `tabelacontatos` VALUES ('Moana','feminino','Juiz de Fora','2004-06-18'),('Luiza','feminino','Juiz de Fora','1995-06-18'),('Antônio','masculino','Bicas','2023-06-18'),('Augusto','masculino','Juiz de Fora','2003-06-18'),('Maria','feminino','Juiz de Fora','1985-03-01'),('Luis','masculino','Bicas','1996-01-18'),('Rafael','masculino','Bicas','1994-06-18'),('Larissa','feminino','Bicas','2000-06-18'),('Miguel','masculino','Bicas','1990-02-18'),('Solange','feminino','Juiz de Fora','1999-06-18'),('Raquel','feminino','Bicas','1990-06-18');
/*!40000 ALTER TABLE `tabelacontatos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-18  1:16:01
