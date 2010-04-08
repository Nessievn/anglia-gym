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
-- Table structure for table `equipment_vehicle`
--

DROP TABLE IF EXISTS `equipment_vehicle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipment_vehicle` (
  `id_vehicle` int(11) NOT NULL AUTO_INCREMENT,
  `registration_num` varchar(45) DEFAULT NULL,
  `defects_faults` text,
  `remarks` text,
  `repairdate` date DEFAULT NULL,
  `repairername` varchar(45) DEFAULT NULL,
  `checkedby` varchar(45) DEFAULT NULL,
  `dateofchecking` date DEFAULT NULL,
  `dateofenextcheck` date DEFAULT NULL,
  `engineoillevel` binary(1) DEFAULT NULL,
  `coolantlevel` binary(1) DEFAULT NULL,
  `powersteeringoil` binary(1) DEFAULT NULL,
  `brakefluidlevel` binary(1) DEFAULT NULL,
  `tail_platelights` binary(1) DEFAULT NULL,
  `windscrnwipers` binary(1) DEFAULT NULL,
  `windscrnwashers` binary(1) DEFAULT NULL,
  `windscreenclean` binary(1) DEFAULT NULL,
  `mirrors` binary(1) DEFAULT NULL,
  `horn` binary(1) DEFAULT NULL,
  `sidelights` binary(1) DEFAULT NULL,
  `dippedbeam` binary(1) DEFAULT NULL,
  `fullbeam` binary(1) DEFAULT NULL,
  `brakelights` binary(1) DEFAULT NULL,
  `foglights` binary(1) DEFAULT NULL,
  `indicators` binary(1) DEFAULT NULL,
  `reverselights` binary(1) DEFAULT NULL,
  `hazardlights` binary(1) DEFAULT NULL,
  `interior_steplights` binary(1) DEFAULT NULL,
  `firstaidkit_stocked` binary(1) DEFAULT NULL,
  `fireextinguisher` binary(1) DEFAULT NULL,
  `bodywork` binary(1) DEFAULT NULL,
  `seatbeltsfront` binary(1) DEFAULT NULL,
  `seatbeltsrear` binary(1) DEFAULT NULL,
  `tyresfrontpres47` binary(1) DEFAULT NULL,
  `tyresback63` binary(1) DEFAULT NULL,
  `bookedintogarage` binary(1) DEFAULT NULL,
  PRIMARY KEY (`id_vehicle`),
  UNIQUE KEY `id_vehicle_UNIQUE` (`id_vehicle`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipment_vehicle`
--

LOCK TABLES `equipment_vehicle` WRITE;
/*!40000 ALTER TABLE `equipment_vehicle` DISABLE KEYS */;
/*!40000 ALTER TABLE `equipment_vehicle` ENABLE KEYS */;
UNLOCK TABLES;

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
) ENGINE=InnoDB AUTO_INCREMENT=76 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','21232f297a57a5a743894a0e4a801fc3','manager',1),(60,'pam@pam.com','c29b2d78629b6e875de4975aa4c19019','member',1),(61,'asdasd@asd.es','c29b2d78629b6e875de4975aa4c19019','member',0),(62,'skarvin@asd.es','2a157d0eb15265b90c76ce6cbaaddb4e','member',1),(66,'skarvin@asdfas.es','c29b2d78629b6e875de4975aa4c19019','member',1),(68,'skarvin@asd.esa','e6af806a6406a15e0c71035f176e46d3','member',1),(69,'asdasd@asdasd.es','14e1a4e1dca3afa182db7005365ea7a4','member',1),(71,'skarvin@gmail.com','09e3701a258c25ea16514fb4272a81d3','member',0),(72,'skarvin@marca.es','74803fdf0df9cc0dbc5748743bce962a','member',1),(73,'zxczxc@sdfsdgfs.es','14e1a4e1dca3afa182db7005365ea7a4','member',1),(74,'sdfdsf@dfgdrg.com','95ad068a8b78061f6c4ed0bc68f586b6','member',1),(75,'janos_hefko@yahoo.co.uk','ffd5028b197fc0395be5bece481a5524','member',1),(2,'ric@2.com','21232f297a57a5a743894a0e4a801fc3','manager',1),(76,'janimani@a.com','a07d6d3386eb54a223ad282dee1fbfe4','staff',1);
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
  `type` enum('item','set','vehicle') DEFAULT NULL,
  `id_vehicle` int(11) DEFAULT NULL,
  `name` varchar(75) DEFAULT NULL,
  `description` text,
  `iteminset1` int(11) DEFAULT NULL,
  `iteminset2` int(11) DEFAULT NULL,
  `iteminset3` int(11) DEFAULT NULL,
  `iteminset4` int(11) DEFAULT NULL,
  `iteminset5` int(11) DEFAULT NULL,
  `iteminset6` int(11) DEFAULT NULL,
  `iteminset7` int(11) DEFAULT NULL,
  `iteminset8` int(11) DEFAULT NULL,
  `iteminset9` int(11) DEFAULT NULL,
  `iteminset10` int(11) DEFAULT NULL,
  `amountinset1` int(11) DEFAULT NULL,
  `amountinset2` int(11) DEFAULT NULL,
  `amountinset3` int(11) DEFAULT NULL,
  `amountinset4` int(11) DEFAULT NULL,
  `amountinset5` int(11) DEFAULT NULL,
  `amountinset6` int(11) DEFAULT NULL,
  `amountinset7` int(11) DEFAULT NULL,
  `amountinset8` int(11) DEFAULT NULL,
  `amountinset9` int(11) DEFAULT NULL,
  `amountinset10` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_equipment`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipment`
--

LOCK TABLES `equipment` WRITE;
/*!40000 ALTER TABLE `equipment` DISABLE KEYS */;
INSERT INTO `equipment` VALUES (1,'item',0,'Pingpongball','propro',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(2,'set',0,'Pingpongset','best',1,8,0,0,0,0,0,0,0,0,4,2,0,0,0,0,0,0,0,0),(3,'set',0,'Tennisset','for 2',18,7,0,0,0,0,0,0,0,0,1,2,0,0,0,0,0,0,0,0),(4,'item',0,'Tennisracket','very nice :)',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(5,'set',0,'Judoset','indoor use only',9,8,0,0,0,0,0,0,0,0,1,2,0,0,0,0,0,0,0,0),(6,'item',0,'Basketball','brown color',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(7,'item',0,'Football','pro',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(8,'item',0,'Pingpongracket','pro',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(9,'item',0,'Tennisball','new',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,NULL,NULL),(10,'set',0,'sfsafd','New Set',4,1,6,7,1,0,0,0,0,0,3,4,1,3,4,0,0,0,0,0),(13,'set',0,'chdf','dfghdfgdfg',1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(14,'set',0,'dbdfb','dfbdfb',6,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0),(15,'set',0,'xcvc','vdsav',1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0),(16,'item',0,'xvfaxcv','xcvzscxv',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(17,'item',0,'dddd','sdfsdf',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(18,'item',0,'rtyt','rtyry',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(19,'item',0,'yrty','zxczc',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(20,'item',0,'23423','234234',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(21,'item',0,'www','wwwww',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(22,'item',0,'Lollipop','Tasty',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(23,'item',0,'Blah','hah',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(24,'set',0,'Hehe','Haha',6,23,0,0,0,0,0,0,0,0,2,3,0,0,0,0,0,0,0,0),(25,'item',0,'Newforbooking','new!',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(26,'set',0,'Newsetforbooking','Spanking new!',4,6,0,0,0,0,0,0,0,0,3,1,0,0,0,0,0,0,0,0),(27,'item',0,'NewTest','ddd',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(28,'set',0,'NewTestSet','sss',4,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,0,0),(29,'item',0,'Newtest2','sss',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(30,'set',0,'newsettest2','ddd',1,4,0,0,0,0,0,0,0,0,3,3,0,0,0,0,0,0,0,0),(31,'item',0,'newww','www',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(32,'set',0,'ggg','ggggg',1,0,0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0),(33,'set',0,'sdfsd','sdfs',1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(34,'set',0,'luyo','',4,6,0,0,0,0,0,0,0,0,3,1,0,0,0,0,0,0,0,0);
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
INSERT INTO `rooms` VALUES (1,'Medium Room','good for medium stuff',100),(2,'Big Room','good for evertyhing',100);
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
  `id_member` int(11) NOT NULL DEFAULT '0',
  `id_class_instance` int(11) NOT NULL DEFAULT '0',
  `booking_date` date DEFAULT NULL,
  PRIMARY KEY (`id_class_booking`) USING BTREE,
  UNIQUE KEY `unique_ind` (`id_member`,`id_class_instance`),
  KEY `FK_class_bookings_1` (`id_class_instance`),
  CONSTRAINT `FK_class_bookings_1` FOREIGN KEY (`id_class_instance`) REFERENCES `class_instance` (`id_class_instance`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_class_bookings_2` FOREIGN KEY (`id_member`) REFERENCES `members` (`id_member`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=86 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `class_bookings`
--

LOCK TABLES `class_bookings` WRITE;
/*!40000 ALTER TABLE `class_bookings` DISABLE KEYS */;
INSERT INTO `class_bookings` VALUES (1,4,1,'2010-04-01'),(2,1,2,'2010-04-02'),(86,10,37,'2010-04-01'),(87,17,37,'2010-04-01');
/*!40000 ALTER TABLE `class_bookings` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipment_bookings`
--

DROP TABLE IF EXISTS `equipment_bookings`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipment_bookings` (
  `id_eq_booking` int(11) NOT NULL AUTO_INCREMENT,
  `id_staff` int(11) DEFAULT NULL,
  `id_member` int(11) DEFAULT NULL,
  `id_class_instance` int(11) DEFAULT NULL,
  `date_start` datetime DEFAULT NULL,
  `date_due` datetime DEFAULT NULL,
  `id_equipment` int(11) DEFAULT NULL,
  `borrowedamount` int(11) DEFAULT NULL,
  `isreturned` binary(1) DEFAULT NULL,
  PRIMARY KEY (`id_eq_booking`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipment_bookings`
--

LOCK TABLES `equipment_bookings` WRITE;
/*!40000 ALTER TABLE `equipment_bookings` DISABLE KEYS */;
INSERT INTO `equipment_bookings` VALUES (1,NULL,4,NULL,'2010-04-01 00:00:00','2010-04-15 00:00:00',1,3,NULL),(2,NULL,5,NULL,'2010-04-02 00:00:00','2010-04-07 00:00:00',2,2,NULL),(3,NULL,6,NULL,'2010-04-05 00:00:00','2010-04-08 00:00:00',3,1,NULL),(4,1,NULL,NULL,'2010-04-06 00:00:00','2010-04-07 00:00:00',4,3,'1'),(5,-1,5,0,'2010-04-02 00:00:00','2010-04-09 00:00:00',5,1,NULL),(6,-1,0,0,'2010-04-02 00:00:00','2010-04-09 00:00:00',2,1,NULL),(7,-1,0,0,'2010-04-02 00:00:00','2010-04-09 00:00:00',2,1,NULL),(8,-1,0,0,'2010-04-02 00:00:00','2010-04-09 00:00:00',2,10,NULL),(9,0,5,0,'2010-04-02 00:00:00','2010-04-09 00:00:00',2,6,NULL),(10,-1,6,0,'2010-04-02 00:00:00','2010-04-09 00:00:00',2,3,NULL),(11,NULL,5,0,'2010-04-02 00:00:00','2010-04-09 00:00:00',3,7,NULL),(12,NULL,5,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',1,1,NULL),(13,NULL,5,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',3,1,NULL),(14,NULL,11,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',4,3,NULL),(15,NULL,11,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',5,2,NULL),(16,NULL,10,0,'2010-04-08 00:00:00','2010-04-13 00:00:00',7,3,NULL),(17,1,NULL,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',3,1,NULL),(18,NULL,10,0,'2010-04-08 00:00:00','2010-04-14 00:00:00',9,2,NULL),(19,NULL,5,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',6,1,NULL),(20,NULL,11,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',16,1,NULL),(21,1,NULL,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',1,1,NULL),(22,1,NULL,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',8,1,NULL),(23,NULL,4,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',6,1,NULL),(24,NULL,12,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',4,1,NULL),(25,1,NULL,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',1,1,NULL),(26,NULL,12,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',7,1,NULL),(27,NULL,12,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',16,1,NULL);
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classes`
--

LOCK TABLES `classes` WRITE;
/*!40000 ALTER TABLE `classes` DISABLE KEYS */;
INSERT INTO `classes` VALUES (2,'Aerobic','sss','Group'),(1,'Badminton','Hehe','Personal'),(0,'Yoga','Good for you!','Group');
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
INSERT INTO `payments` VALUES (1,5,'2010-03-03','2000.00','2 months');
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
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `members`
--

LOCK TABLES `members` WRITE;
/*!40000 ALTER TABLE `members` DISABLE KEYS */;
INSERT INTO `members` VALUES (4,'Pam','McDonovan','1091-06-24','my house','Cambridge','Cambrdigeshire','CB2  2AS','Individual','Debit Card',60,1,'my house','Jennah Jameson','Mother','081231232','071231231','Clorhyne','I have had 4 heart attacks.',NULL,'Dr. House','612361263','pam@pam.com','N/A',NULL,NULL),(5,'Ricardo','Da Force','1991-05-15','kh','','','     ','','',61,0,'kh','ñlkhñ','ñlk','kl','jh','hlkj','ñlkh',NULL,'lkh','lkj','asdasd@asd.es','N/A','',''),(6,'Joana','Ferras','1012-11-12','','','','CB4  2NJ','Individual','Debit Card',62,1,'','Cuenca','','','','','None She is fine!!!',NULL,'House','','skarvin@asd.es','N/A','123123123','123123123'),(10,'Jonas','Pendejo','1221-12-12','','','','     ','','',66,1,'','','','','','','',NULL,'','','skarvin@asdfas.es','714 271 422','',''),(11,'joan','asda','1990-09-14','','','','     ','','',68,1,'','','','','','','',NULL,'','','skarvin@asd.esa','698 911 330',NULL,NULL),(12,'Isidro','Catalan','1111-01-01','ñlkñlknlkjb','ñkmmkljbgfgjhguigh','ghukghbkghhl','CB4  2SQ','Group','Debit Card',69,1,'ñljnblkn´ñlkñklbjknñjhlj','fas dfad f','asdfsd fasd','sdaf sdf ','asd fasd','lots','asdkjaskjds ek nsgksfghfgh',NULL,'asdas d','asd fasd fasd','asdasd@asdasd.es','972 513 629','',''),(16,'','','1981-06-24','','','','     ','','',71,0,'','','','','','','',NULL,'','','skarvin@gmail.com','330 568 590','',''),(17,'Mr Joan','Donovan','1990-07-12','House 1','Cambrdige','Cambrdigeshire','CB4  2NA','Individual','Cash',72,1,'House 2','My Contact','None','1231231','1231241','Lots and Lots','You dont care mate\r\n\r\n\r\nHAHAHAHA',NULL,'House','','skarvin@marca.es','393 620 591','921231231','666666666'),(18,'assdgf','ssdfsd','1212-12-12','','','','     ','','',73,1,'','','','','','','',NULL,'','','zxczxc@sdfsdgfs.es','822 556 789','',''),(19,'assdgf','ssdfsd','1212-12-12','','','','     ','','',73,1,'','','','','','','',NULL,'','','zxczxc@sdfsdgfs.es','822 556 789','',''),(20,'dfgdfg','dfgdf','1111-11-11','','','','     ','','',74,1,'','','','','','','',NULL,'','','sdfdsf@dfgdrg.com','321 265 755','',''),(21,'Jano','Mano','1980-12-12','','','','     ','','',75,1,'','','','','','','',NULL,'','','janos_hefko@yahoo.co.uk','633 402 358','','');
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
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=latin1;
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
  `allergies` varchar(90) DEFAULT NULL,
  `medicalNotes` text,
  `qualifications` text,
  `phone` varchar(45) DEFAULT NULL,
  `mobile` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `emerg_contact_mobile` varchar(45) DEFAULT NULL,
  `medical_doctor_name` varchar(45) DEFAULT NULL,
  `medical_phone` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_staff`),
  KEY `id_user` (`id_user`),
CONSTRAINT `staff_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `users` (`id_user`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (1,'Jani','Mani','1980-01-01','78 Tower Bridge','','','CM21 0DF','Full-time','','Instructor','2010-12-12','2015-12-12',76,'','','','','','','','','','janimani@a.com','','','');
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

-- Dump completed on 2010-04-08  6:47:02
