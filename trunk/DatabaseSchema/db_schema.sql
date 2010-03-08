CREATE DATABASE  IF NOT EXISTS `gym` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `gym`;
-- MySQL dump 10.13  Distrib 5.1.40, for Win32 (ia32)
--
-- Host: localhost    Database: gym
-- ------------------------------------------------------
-- Server version	5.1.44-community

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
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `id_user` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(50) NOT NULL,
  `password` varchar(33) NOT NULL,
  `profile` varchar(50) DEFAULT NULL,
  `active` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_user`),
  UNIQUE KEY `login_UNIQUE` (`login`)
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','21232f297a57a5a743894a0e4a801fc3','manager',1),(60,'pam@pam.com','c29b2d78629b6e875de4975aa4c19019','member',1),(61,'asdasd@asd.es','c29b2d78629b6e875de4975aa4c19019','member',0),(62,'skarvin@asd.es','2a157d0eb15265b90c76ce6cbaaddb4e','member',1),(66,'skarvin@asdfas.es','c29b2d78629b6e875de4975aa4c19019','member',1),(68,'skarvin@asd.esa','e6af806a6406a15e0c71035f176e46d3','member',1),(69,'asdasd@asdasd.es','14e1a4e1dca3afa182db7005365ea7a4','member',1),(71,'skarvin@gmail.com','09e3701a258c25ea16514fb4272a81d3','member',0),(72,'skarvin@marca.es','74803fdf0df9cc0dbc5748743bce962a','member',1);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipment`
--

DROP TABLE IF EXISTS `equipment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipment` (
  `id_equipment` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(75) NOT NULL,
  `description` text,
  `id_set` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_equipment`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipment`
--

LOCK TABLES `equipment` WRITE;
/*!40000 ALTER TABLE `equipment` DISABLE KEYS */;
/*!40000 ALTER TABLE `equipment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rooms`
--

DROP TABLE IF EXISTS `rooms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rooms` (
  `id_room` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  `description` text,
  `size` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_room`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rooms`
--

LOCK TABLES `rooms` WRITE;
/*!40000 ALTER TABLE `rooms` DISABLE KEYS */;
/*!40000 ALTER TABLE `rooms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `class_bookings`
--

DROP TABLE IF EXISTS `class_bookings`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `class_bookings` (
  `id_class_booking` int(11) NOT NULL AUTO_INCREMENT,
  `id_member` int(11) DEFAULT NULL,
  `id_class_instance` int(11) DEFAULT NULL,
  `booking_date` date DEFAULT NULL,
  PRIMARY KEY (`id_class_booking`),
  KEY `FK_class_bookings_1` (`id_class_instance`),
  KEY `FK_class_bookings_2` (`id_member`),
  CONSTRAINT `FK_class_bookings_1` FOREIGN KEY (`id_class_instance`) REFERENCES `class_instance` (`id_class_instance`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_class_bookings_2` FOREIGN KEY (`id_member`) REFERENCES `members` (`id_member`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `class_bookings`
--

LOCK TABLES `class_bookings` WRITE;
/*!40000 ALTER TABLE `class_bookings` DISABLE KEYS */;
/*!40000 ALTER TABLE `class_bookings` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipment_bookings`
--

DROP TABLE IF EXISTS `equipment_bookings`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipment_bookings` (
  `id_eq_booking` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `id_staff` int(11) DEFAULT NULL,
  `date_start` date DEFAULT NULL,
  `date_due` date DEFAULT NULL,
  `id_equipment` int(11) DEFAULT NULL,
  `id_member` int(11) DEFAULT NULL,
  `id_class_instance` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_eq_booking`) USING BTREE,
  KEY `id_staff` (`id_staff`),
  KEY `fk_id_equipment` (`id_equipment`),
  KEY `FK_equipment_bookings_3` (`id_member`),
  KEY `FK_equipment_bookings_4` (`id_class_instance`),
  CONSTRAINT `FK_equipment_bookings_1` FOREIGN KEY (`id_staff`) REFERENCES `staff` (`id_staff`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_equipment_bookings_2` FOREIGN KEY (`id_equipment`) REFERENCES `equipment` (`id_equipment`),
  CONSTRAINT `FK_equipment_bookings_3` FOREIGN KEY (`id_member`) REFERENCES `members` (`id_member`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_equipment_bookings_4` FOREIGN KEY (`id_class_instance`) REFERENCES `class_instance` (`id_class_instance`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipment_bookings`
--

LOCK TABLES `equipment_bookings` WRITE;
/*!40000 ALTER TABLE `equipment_bookings` DISABLE KEYS */;
/*!40000 ALTER TABLE `equipment_bookings` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classes`
--

DROP TABLE IF EXISTS `classes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `classes` (
  `id_class` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  `description` text,
  `type` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_class`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classes`
--

LOCK TABLES `classes` WRITE;
/*!40000 ALTER TABLE `classes` DISABLE KEYS */;
/*!40000 ALTER TABLE `classes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `payments` (
  `id_payment` int(11) NOT NULL AUTO_INCREMENT,
  `id_member` int(11) NOT NULL,
  `date` date NOT NULL,
  `amount` decimal(6,2) NOT NULL,
  `details` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id_payment`),
  KEY `id_member` (`id_member`),
  CONSTRAINT `payments_ibfk_1` FOREIGN KEY (`id_member`) REFERENCES `members` (`id_member`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments`
--

LOCK TABLES `payments` WRITE;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
/*!40000 ALTER TABLE `payments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `members`
--

DROP TABLE IF EXISTS `members`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `members` (
  `id_member` int(11) NOT NULL AUTO_INCREMENT,
  `firstName` varchar(60) NOT NULL,
  `lastName` varchar(60) NOT NULL,
  `birthdate` date NOT NULL,
  `address_1` text,
  `city` varchar(60) DEFAULT NULL,
  `county` varchar(60) DEFAULT NULL,
  `postalcode` varchar(15) DEFAULT NULL,
  `type` varchar(50) DEFAULT NULL,
  `payment_method` varchar(50) DEFAULT NULL,
  `id_user` int(11) DEFAULT NULL,
  `is_active` tinyint(1) DEFAULT '1',
  `address_2` text,
  `emerg_contact_name` varchar(45) DEFAULT NULL,
  `emerg_contact_relation` varchar(45) DEFAULT NULL,
  `emerg_contact_phone` varchar(45) DEFAULT NULL,
  `emerg_contact_mobile` varchar(45) DEFAULT NULL,
  `medical_allergies` text,
  `medical_notes` text,
  `picture` varchar(150) DEFAULT NULL,
  `medical_doctor_name` varchar(45) DEFAULT NULL,
  `medical_phone` varchar(45) DEFAULT NULL,
  `email` varchar(75) NOT NULL DEFAULT 'N/A',
  `member_number` varchar(75) NOT NULL DEFAULT 'N/A',
  `phone` varchar(45) DEFAULT NULL,
  `mobile` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_member`),
  KEY `id_user` (`id_user`),
  CONSTRAINT `members_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `users` (`id_user`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `members`
--

LOCK TABLES `members` WRITE;
/*!40000 ALTER TABLE `members` DISABLE KEYS */;
INSERT INTO `members` VALUES (4,'Pam','McDonovan','1091-06-24','my house','Cambridge','Cambrdigeshire','CB2  2AS','Individual','Debit Card',60,1,'my house','Jennah Jameson','Mother','081231232','071231231','Clorhyne','I have had 4 heart attacks.',NULL,'Dr. House','612361263','pam@pam.com','N/A',NULL,NULL),(5,'lkjg','lkjh','1991-05-15','kh','','','     ','','',61,0,'kh','ñlkhñ','ñlk','kl','jh','hlkj','ñlkh',NULL,'lkh','lkj','asdasd@asd.es','N/A',NULL,NULL),(6,'Joana','Ferras','1012-11-12','','','','CB4  2NJ','Individual','Debit Card',62,1,'','Cuenca','','','','','None She is fine!!!',NULL,'House','','skarvin@asd.es','N/A','123123123','123123123'),(10,'sadasd','asdasd','1221-12-12','','','','     ','','',66,1,'','','','','','','',NULL,'','','skarvin@asdfas.es','714 271 422',NULL,NULL),(11,'joan','asda','1990-09-14','','','','     ','','',68,1,'','','','','','','',NULL,'','','skarvin@asd.esa','698 911 330',NULL,NULL),(12,'Isidro','Catalan','1111-01-01','ñlkñlknlkjb','ñkmmkljbgfgjhguigh','ghukghbkghhl','CB4  2SQ','Group','Debit Card',69,1,'ñljnblkn´ñlkñklbjknñjhlj','fas dfad f','asdfsd fasd','sdaf sdf ','asd fasd','lots','alsdj lasfakjsfdn sladfn lasdkng fñasldbgadfg sdfg',NULL,'asdas d','asd fasd fasd','asdasd@asdasd.es','972 513 629',NULL,NULL),(16,'','','1981-06-24','','','','     ','','',71,0,'','','','','','','',NULL,'','','skarvin@gmail.com','330 568 590','',''),(17,'Mr Joan','Donovan','1990-07-12','House 1','Cambrdige','Cambrdigeshire','CB4  2NA','Individual','Cash',72,1,'House 2','My Contact','None','1231231','1231241','Lots and Lots','You dont care mate\r\n\r\n\r\nHAHAHAHA',NULL,'House','','skarvin@marca.es','393 620 591','921231231','666666666');
/*!40000 ALTER TABLE `members` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `class_instance`
--

DROP TABLE IF EXISTS `class_instance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `class_instance` (
  `id_class_instance` int(11) NOT NULL AUTO_INCREMENT,
  `id_class` int(11) DEFAULT NULL,
  `id_staff` int(11) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `start_time` time DEFAULT NULL,
  `end_time` time DEFAULT NULL,
  `frequency` varchar(40) DEFAULT NULL,
  `id_room` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_class_instance`),
  KEY `id_class` (`id_class`),
  KEY `id_staff` (`id_staff`),
  KEY `class_instance_ibfk_3` (`id_room`),
  CONSTRAINT `class_instance_ibfk_1` FOREIGN KEY (`id_class`) REFERENCES `classes` (`id_class`),
  CONSTRAINT `class_instance_ibfk_2` FOREIGN KEY (`id_staff`) REFERENCES `staff` (`id_staff`),
  CONSTRAINT `class_instance_ibfk_3` FOREIGN KEY (`id_room`) REFERENCES `rooms` (`id_room`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `class_instance`
--

LOCK TABLES `class_instance` WRITE;
/*!40000 ALTER TABLE `class_instance` DISABLE KEYS */;
/*!40000 ALTER TABLE `class_instance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `staff` (
  `id_staff` int(11) NOT NULL AUTO_INCREMENT,
  `firstName` varchar(60) NOT NULL,
  `lastName` varchar(60) NOT NULL,
  `birthdate` date NOT NULL,
  `address_1` text NOT NULL,
  `city` varchar(60) DEFAULT NULL,
  `county` varchar(60) DEFAULT NULL,
  `postalcode` varchar(15) DEFAULT NULL,
  `contract_type` varchar(50) DEFAULT NULL,
  `natinsnumber` varchar(50) DEFAULT NULL,
  `position` varchar(50) DEFAULT NULL,
  `contract_start` date DEFAULT NULL,
  `contract_finish` date DEFAULT NULL,
  `id_user` int(11) DEFAULT NULL,
  `address_2` varchar(45) DEFAULT NULL,
  `emerg_contact_name` varchar(45) DEFAULT NULL,
  `emerg_contact_telephone` varchar(45) DEFAULT NULL,
  `emerg_contact_relation` varchar(45) DEFAULT NULL,
  `nationality` varchar(80) DEFAULT NULL,
  `allergies` varchar(90) DEFAULT NULL,
  `medicalNotes` text,
  `qualifications` text,
  `phone` varchar(45) DEFAULT NULL,
  `mobile` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_staff`),
  KEY `id_user` (`id_user`),
  CONSTRAINT `staff_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `users` (`id_user`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2010-03-08  1:32:52
