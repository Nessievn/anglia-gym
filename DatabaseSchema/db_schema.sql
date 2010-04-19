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
-- Table structure for table `file`
--

DROP TABLE IF EXISTS `file`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `file` (
  `id_file` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `file_name` varchar(64) NOT NULL,
  `file_size` mediumint(8) unsigned NOT NULL,
  `file` mediumblob NOT NULL,
  PRIMARY KEY (`id_file`)
) ENGINE=InnoDB AUTO_INCREMENT=65535 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `file`
--

LOCK TABLES `file` WRITE;
/*!40000 ALTER TABLE `file` DISABLE KEYS */;
INSERT INTO `file` VALUES (8,'xSTA70963.jpg',53959,'ÿØÿà\0JFIF\0\0`\0`\0\0ÿáøExif\0\0MM\0*\0\0\0\0\0\0\0\0\Z\0\0\0’\0\0\0\0\0\0\0¬\0\0\0\0\0\0\0\Z\0\0\0\0\0\0\0À\0\0\0\0\0\0\0È(\0\0\0\0\0\0\01\0\0\0\0\n\0\0\0Ğ2\0\0\0\0\0\0\0Ú\0\0\0\0\0\0\0‚˜\0\0\0\0\0\0\0î‡i\0\0\0\0\0\0\0ş\0\0îSAMSUNG TECHWIN CO., LTD.\0Digimax A7/Kenox D7\0\0\0 \0\0\0\0\0 \0\0\00090.0017 2007:12:28 07:09:04\0Copyright 2004\0\0\0!‚š\0\0\0\0\0\0‚\0\0\0\0\0\0˜ˆ\"\0\0\0\0\0\0\0ˆ\'\0\0\0\0\0È\0\0\0\0\0\0\00210\0\0\0\0\0\0 \0\0\0\0\0\0´‘\0\0\0\0\0‘\0\0\0\0\0\0È’\0\n\0\0\0\0\0Ğ’\0\0\0\0\0\0Ø’\0\n\0\0\0\0\0à’\0\0\0\0\0\0è’\0\0\0\0\0\0\0’\0\0\0\0\0\0\0\0’	\0\0\0\0\0\0\0’\n\0\0\0\0\0\0ğ’|\0\0\0Ì\0\0ø \0\0\0\0\00100 \0\0\0\0\0\0\0 \0\0\0\0\0\0@ \0\0\0\0\0\0° \0\0\0\0\0\0Ä¢\0\0\0\0\0\0\0£\0\0\0\0\0\0\0\0£\0\0\0\0\0\0\0¤\0\0\0\0\0\0\0\0¤\0\0\0\0\0\0\0\0¤\0\0\0\0\0\0ä¤\0\0\0\0\0\0\0¤\0\0\0\0\0\0\0\0¤\n\0\0\0\0\0\0\0\0ê\0	\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\n2007:12:28 07:09:04\02007:12:28 07:09:04\0\0:Üp\0L\0\0\0+\0\0è\0\02\0\0è\0\0\0\0\0\0\0\0\02\0\0è\0\0Â\0\0è ZP:814; FP:224; AWB:440,367; PWB:516,288; PMF:88,81; LV:312; \0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0 ET:128; RL:10 10 35 18 34 38 18 3 RW:0 85 17 17 17 86 17 17 \0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0DF: 2 2 3 2 2 2 2 2\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0R98\0\0\0\0\0\00100\0\0\0\0\0\0\0\0\0d\0\0\0d\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\Z\0\0\0\0\0\0H\0\0\0\0\0\0P(\0\0\0\0\0\0\0\0\0\0\0\0\0X\0\0\0\0\0\0—\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0ÿØÿÛ\0„\0				\r\r\n\" \Z) #%&\'&*-*%-\"&&%				%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%ÿÄ¢\0\0\0\0\0\0\0\0\0\0	\n\0\0\0\0\0\0\0	\n\0\0\0}\0!1AQa\"q2‘¡#B±ÁRÑğ$3br‚	\n\Z%&\'()*456789:CDEFGHIJSTUVWXYZcdefghijstuvwxyzƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹ºÂÃÄÅÆÇÈÉÊÒÓÔÕÖ×ØÙÚáâãäåæçèéêñòóôõö÷øùú\0\0w\0!1AQaq\"2B‘¡±Á	#3RğbrÑ\n$4á%ñ\Z&\'()*56789:CDEFGHIJSTUVWXYZcdefghijstuvwxyz‚ƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹ºÂÃÄÅÆÇÈÉÊÒÓÔÕÖ×ØÙÚâãäåæçèéêòóôõö÷øùúÿÀ\0\0x\0 !\0ÿÚ\0\0\0?\0ù—išLÖ7¹½„Í9U˜à\n\0¹lŒm¹SÍ\r“‘3çÕ¹§a\\‰æd~^6#ëš.]—çÚÃı¼Ÿ×­\'`R±]FÍÃ§=°j2»K„tùÇX\Z{-C™1 ¢À“øz\nœ°a‚\r&û(üÀÛ@ù{mSFáØÒM wc²{ŠŠá¿rpiİ0³DPusèµ³­¡X––Çó…[ÿ\0f¥.£‡C-xÉ µ8…MÍ›7n›Éóì95’abxRk•NfÑÕ^ƒ…‰Ü¿Ï°©Æ\0ÀÒ6.êdÁT8&˜ŠH…ÚŞõcÎ+dv<Ó —O³²“O7wIæ4Z[¡;ğ\0%ºp9Àú\Z¯sf-Ö	Ñ8—?*0,˜8äv¬ùåÌÓZÀ¿üSgfšzÿ\0Áµ¿QÒIéÖ ó[~NïÀÖ\\Å6¶- d6àÀvaœÔm€ãŞ¡$‹mˆ\r2sûœ{ÕKùişçõ»âD}ÿ\0§;Oı&¢[?ëª5¦¶1šM8“SsÔ4ŸxU~ÜÉ©]Éıµª°Xµ°6î‡©$cŸsíŒç\'SÖmõ‚ĞÅ#û«Â§Jó0øYB«–§¹ŠÌ”é:M\"€”ÁÏÒ¿Ş½CÂcÑC„RÜãŠZ6ÚêTúŠvÃ†#5Ä®1Œ}(–6)%şÉö€IÚpzf™ªîÜÌÇ”\\›©4ªŠ¼Í‡f™*oQÈıi€SgQõ¢áam—\"SşÏõ­ÿ\0u‰TË5#ÿ\0\0‰úT7¿õÕS[…xğ¨ØÆ¿ÅÏ¢óU\rŒê|D²(ÔÓ$±a`u\rF;`Ûww®ûGğ^œu‰!ûLR3î1†b#@BG·~zÕÆİHkS»ğÿ\0‡ôÛë·‰  ÄPË&:öëqÛY¾%ğ…¯Ë\"‘ÉX»œ1UùTxtíÖªé†¨ó-wM}\nH’á¢•¤†ÀÀmÏ×§ÿ\0¯œeı²\"y¿áY=44ßSwÁö¶SO}q~»£Ùœ›†?(éY^@,B:O\Z’ZrvAö)ÈùT7ĞÓZÚuëşU*q{2åFqø‘W_¼Œ?\nr\rÌO­6ÈHì´o†\Z½áù5«O*;h4şğ\'¨ë›ñ?†ïtFK{¸°¨åCƒ•lwW•K3¥<CÃßTzµ2éª>Ñ¶™¢_¼îª?Ö¿ŠœMâQÓkÙ˜Øo5èÉœF\rÖBõÉªÊæ´†Æ5¢gµ*òùFw¹ê¿\r¼#6¯k@C9#.AØû¾œ^õî~ø#n.…Ì²‰;—ròõæ±«W•¤šTÔ“lît¯„V6š‚Ü${c©\'%¿?çCYø7¥:ÈÈfÃg»\0s“üë\'Q¥q¥+=ã‡V6?h³Õ`ãs¾J(zrËÏ¯\\ç¿JùÚæ\'ŠæD(Q•ˆ(‡•¼\'ÏÈ©Y4løwNûn©Ì]ĞÇĞFqÉ±ôóªhâ8ò>•5¦¤Ü»\Z–Âxü¦ÊÈí´68ÿ\0=*è¢”A¥^­Õ£1LÊ~Fó²=ğ¤~5äbynµ>›98É5±FeÀÁ´ã©\\V-ÍÔ–í¾6+Î8\0ÿ\0:×9Iïte¥N1º™FñÖ³ <¦ÖKy’Tu)q8®á‘Á‰õÏÜ]I<â7”Ég\nHÁ\"º©áá¹¥¿èxõkÎQ³f—„á[XÅÆ$¼…9÷qUîå3Êó7Yœş&µk©„ÌÍ»ûËôªàä~5´60©¤‹‘FŒ·9=Æj_³Ã-ôH@v É¨»¸ì¬}5ğªN«m00Â 1…8ÀúšúHXÖUQXW~ù¼?„l¨P•^ä¡CĞÓ—ÂqBîG”|W±_ì£*º¼‘×“üëãÏˆVQYxêúe_ÈÙQ€IE,GãšxwîµæuÖZ¦C ŞËiá­EUG–ÅŸvÈş@ÒC\r·‘Hçzäñ4ë·4m„dä¤¯¡Ù·‰,,àÑ­--ÔAo;Ë:‹r\ZVbpK=c\0Àâ´|Eã­6çN³‚ŞÕ×mÔlÄÆFFyòÕ²êµêSíï]ëéú]CO\r\n«~«O]	5OxnîÜGä¯˜p9Œã?¦k‘ñ¾“=¸’Á°rO éO/Âb°s;¦Íq˜œ..‚z£˜¼#\0Å*°Àü8ª‰H¯*²\0€d\0qÀ<ŸÂ¾¦œô»>/’fï‚†ßÙJGË¦á¾‘©sú)ªR/îc^œZrvMz~¤SFm÷Ë0«š¬§¯jÖŸÂsUøËˆcŞáÜTĞÏæÜF‘.Ä\0rO¥‹o@„ÒÑŸDx#\\Oi¿hº·ºk‰%mñ¤D¸(v‘İGë^×áßŠ¾‘#K¸ï¬˜à¤Ûºş\"¹Ü9¤äuj£ÊF†æÚæÕg…Õãa¸ÜW#¬|F°²¸{k}\'T¼dÈ&feãı¡ÅTœ^‹säİ»¿â“®Ø^ÛÜi—öº0Y\'ˆ¨ÀİÏNõòoÄ$½Oß>¥oqnò*4bPs\"mXàÁ¥N<·_×S¦£ºMXÄOÃ}Rr9këuÏüb¥`&\0ašé×âsÿ\0_‘*Èp\0cúÖÍ—†uÍJ özeìñà0d‰Šzô¬*J0W‘¤[z&g?‡µE’Uk€am²|§ä>†˜×Æò*ªN1G<*é{“N›¼]„šF*wÊÿ\07©Îj(\"$.îpc\n€†9ç\'<qìj¢¬´Cœ¥).ftŞ_²ø{TÔÛ›X:É/ÊGıûşB³nT¢ ?İüFk)ôõ:iës*ôæeö\\~¦¥yìßG‚µt¼I]3+\"»Wn8 ƒÎyÏAŒ¬ÜW+ş®s6”ß2ş¬lÃ¥X]Z3FÒ*í\n§Şq’OãÇáZğìqxïCk‡óWûNÛ+—j}já~k1Ê1ÑÄúŸÂŞ\Z‡ûÄ6Öò5n]£‘Wî±oÒºÍÁW–z“ßŞjw-käÍ“¹dß_¯~¸ÅrÒvzêuT—*fÎ‹#&‰w±„öSUğl~\'ÒmâK»‹?\"a.ëwÚdÇU>Æ¦“´¢É©îóKĞÈñ_‡–ÃÂ·ÂIMå9	»°\'œ}kÂ¿j¯ŞIâîĞ,Ğ}€Å³ø·+–$£ø{U-dïÕÿ\0˜s^7‰ä²$v¿\0­ÜKw®J§é	ÖS\\fàu-[8/bÈh¾ÏUËŸ¼Û¸ƒÚøsÇ¾8†ÂeÓ|cªÚ[ÙBª\"û|ˆ6 Âª/N\0Vâ¹[¦±÷šH¹sñOÅZ¿|<-ã]u¬æŸÌ’[‰w4€Îzp8•sâ‹»ËëÍOS×EİÎ©†êâçOYî`v³d©Úåp~lv®?dùbÜ5{êô4i&Õÿ\0D“D›\\¶\Zìw#OBLâÜ#/û9à\Z,t+­NfÓ,ç’(·3I¸UÏıyşUÙjŠV{Ã‘x?{úèok–/e§Ùév`5½°,Ï<é[ïÉ¸àÊ:k\'U‹Ê¸XÈù–4È?îŠ™ŞçE&¬eÜÀ…Ô‡Ë«éEå„š}ÀŠñ6I€ØÈ<~Q©k.äÊîÎ®$Fp\0…ké!¢Ô­åIFVo4˜öÛ±íŠÛcŸBøÆºV©ãëæÒ.·-ÌqJÊP®ÆÁB9ëÂŸzõù®wiÒ¹,T!\'Jäš”¤¬vÍBZÅÜÇ°–a¦j`a0>SÀùAşµ·¦ÌRÍz¸©Áâ¡;j]h¦šG-ñò3¤,SÌËÊ¨î ’ ‘’\0äàf¾sø¡âïøMõÕšİ$ŠÎŞ3º±ùˆ\'%¡?áZRmÈçvQ²<ÏÅsÜ\\x^EQäÚ\\¼îòZUE,ïØÅí-Ò»#Üâ«¹ —Ë`£ ëõ·=î—ƒRxKj“NZI„‡Ä\0ÂíÛŒ–ÉÎîØÀï5\"ä•Š„Ò½ÌxåÄ$wµjÓ›E¸K†ºkß—È\ZóóîxéŒuö¢¢½Ï/ø\"Œ¢İ¤PÆN+Ù<!«Y/Âƒc\"N×4êDç\\>ßÏÚ‰î™ŸC‡ñ}ü‹â˜YÖH—…)Ç$qÔf²åIÂM)Øqì8şUœâ”QÑ†•äı\n7ä$à©9#‘UK£5¤ˆ‰Éó3¹TÂ§Öº_\n}®ãX{\r?L7ò]Âc“¸Çûä\\t>Ô=S7¥i¥kÿ\0_ÕÏXÔí´Ïêº]Æ‰§ÅbSÇ½OÍ+\r¬¡»tWèZõHu»†Ğ£™0°Rx#­qI©jtÆ£©+Ù/$Ih,šáä,Çæ\"6ç*Õìëi/’£Cò±\\séÍ7kÔ¥4›g\rãC_º±ÂöÆêøH[i]Ácä0?\ZùæRdŠíÿ\0gÓÚ´£Ë·_Àå”_%ì­Ÿü1TYGwrc–=ñ:•g¨íüÏç\\æ¹àY­ƒK¥Içc$À~øx=úôë]	Øçœ9–‡ÊUŠ° ƒ‚jrÙ­=‰£Œ:’Á°$”Ìİ)=Çm—*@­M/XŠÌ[«Ç(0°g ‚<¦KW@•Ù¡}¨Ú>°÷?dûdr…\n&Ê¼~SÁ<‚9ÅQ¾u{·X¢òT,`îÛíõ„Úi#®Œ[l­}n’Ê†\'$ôlööşu¶ØIä…9äUFvI*ww;Xşa^…ğ¯Q6\ZÍÄk¹MÌj2ò¹÷È?…9h™Iµ±éš–•÷…®şØÌY3Íæåvç«qÓØöÍ[øYã<E W%\Z$°·Tô#Øö5ÇÊä™½Òæ{_æO¶ÓÜC˜®]S…ÿ\0\nÉ×u(´Û?.2Ic…\\òæ‰Å´¥ZíÜâä€Ùu–qt *Wwî×œ£ğÁú~Å<An\"ñ&¢UWíRm\n0\0Ş{v­i7±ËÌ¤îŒÛ–ó\nÈéZPãNiùÔ‡õàñÊ¶nÅGS‡ñ~‹¶òê0F‘aœ|Ä\'ŸQÇ5ÅÁ\"Á6ù!YWÑ‰ÇéZÅÜå­V^mBÆXÙ\ZİãälÆG¶}=ª€>œŠ±œì#1íIñS{75×ş> ^¸*?•FÌZbz’k‘­nzb}>Í¯/ \0³§Ö¶õÜÁ§™íÉ—3^ÕP\\ÌÊRå5-ld–L Æ8$ö®ÓÁÖp¿Š4øf…C·Î«v£#\"µ{Ws¬øŸ«$°ÑàË\\]JYİIìví÷gßut‡Ã¥G£Ühó´v–‰4‘‚&Fù¶¸œg†ÎAö8®‚îÿ\0Eşlß›÷)«öûÛ¢:K¯_i¾—UhDVÉ—«?bqÛĞÖ6“â(uï§ˆouhØŒF½±ÿ\0|œş%Ì›]?¯Ğ[ÁÉü¾V¿àÌM+âg…o¬‚j]ÙNîYÀeÀäqÆ8ø«‚ÔamRYfÂ¬“HòŸO˜çq¤ã«CöpIJ2¿u³LÄK_&÷lùãÎµÌ~i”ºadãËÏOJ¦ÅcßÙ­ÅŒÖ#É(\'§#ŠòÛÍ,ÄÌ›J2œkZZœøŒË’6Ê°Á¥J*°=GåZ3™94±ô?Z—°ã¹­cQCıÃ»òÿ\0õTHI¸P9É®c¾ú\Z¹·`ÑÁâ»Ø¯>Ù¥!·*w\'\\ãhÏ?B=©P½Ùe³„­¯nÚ„$0ŞA¡+Yl[Øïümm¥i:u¶¥âk+’ĞÈ¿gh¸bßx`ãxÿ\0ëÕh¾/iš…âÉ}a}c„$R²n\0\0AÏèk(RHÛÏñ2Tœu½ö·Eÿ\0Ø×Õ¼YáÑá»»]Z|Ã}kæD¾[n“²‘Çúã½pŸu}E­ŸM˜ÙÚÉöâƒ?3¯ ì>c»ß·§‡5)IY[òş™1ÅESåZ½gúXéü}¤øz-\"	­´a\rãHª²Ã&Hçqdğ¸ëüUÉFB!fè£5…$’vnİ»z.³¬“’Wîºú” xŞ_6Y3pà.äL?z/gkxq´™íQWf-•Ê.V]âSÜ×âˆå½yœ*†]Å‡9<Ö´·0Ä|<Í4…ˆÆ{Svşç~{ã£w8P±ª˜ä\'9#ó¥„eÔzš–\\w.¤Ÿé,G£#Qù†2uÖ:î+j\nÑÊÙö<WGá?[ØÚÉoxá0ÙŒ·`zÕB›‹0•^c¨ŠpAlõâµ4NûNÕa¸Ñ¢2ŞŒ¬*y`W?†sŸnÔÚ:ã«Z_Ë¹è¾ÓõK‡ákôŠ@öĞLß»|÷$‚qÓêsZ,Ó×ÄŞ“MHíí‚$+aT8éç‚FNO5Êç5(-»ôô5Äâ+4èÊJİ×^×}®§˜xÖş;·°ŒH›ìíE¹	ÏİcŒÄt>İ:\nÚøs«hóÇ‰oÊjwr	\ZéåDä;‚ò:¸äõcô¯gïRj=áÏ3\rMN§,¾VïÓª4|}3ZÛJon[9ùNöÆ>£Êÿ\0Ç…s³ÊJ,@‚ÀÙ¯.–\'t\"â¬Õ…yÀçvGjÍóÚâçÍ—8è‹ıÑş5IYÙBèùó80;U:¬¿è‘ßø~á¡P\'¶ıò\"£8aùÿ\0ÀjÖèÎkİw<Úh\'ÚêÊ}¦…Ê1ÏLV§:,o ô ÒÂ~uÇ­&Tw,Fß3AM$llú\ZÈè¾…x×{úSÚ%–ç\"¶9Nÿ\0Lœ$J™ùGÜÿ\0tçáøWcà›­šÅÎ×Ú~Êı88$ëXM´›;VÇ¤‰¦¼ò„+$®¤mUœ“Lñ.µcá9§×o\'è¶±ó9ôÇEüy†¸Ô\\˜R¤ê;GşwgŒÃr·ºÜ%€<ÊB\0·Cù×ªx–Æ$Øt™¬È’)a€*’zîØ31;×¥Œ÷U4ÒÓóFXZÎr³i=»œÆ5I¯Zó|®Âà±\"Ej°Ï \n\Z·=èI T ûü¤ÿ\0JÃG²±ÛÌå«mù½Ê\Z•èKb7cqÇÿ\0È¬Õ¼.vbİ‘#ñªHÎORÄ{S÷ƒ)ŸOaRZß,ÁåÆÀğîÏdzg…5¸Ç—kvMa¬Onw²)ıÙcœ¯cTæˆE­Ôr+Tï©Á%gb!S[©y\0QÎ	ü†iK`ãÔü®\ncŸİš‹· Ø>ñ5aai#ã€GZĞçGÿÙ\0ÿÛ\0C\0		\n\r\Z\Z $.\' \",#(7),01444\'9=82<.342ÿÛ\0C			\r\r2!!22222222222222222222222222222222222222222222222222ÿÀ\0»ß\"\0ÿÄ\0\0\0\0\0\0\0\0\0\0\0	\nÿÄ\0µ\0\0\0}\0!1AQa\"q2‘¡#B±ÁRÑğ$3br‚	\n\Z%&\'()*456789:CDEFGHIJSTUVWXYZcdefghijstuvwxyzƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹ºÂÃÄÅÆÇÈÉÊÒÓÔÕÖ×ØÙÚáâãäåæçèéêñòóôõö÷øùúÿÄ\0\0\0\0\0\0\0\0	\nÿÄ\0µ\0\0w\0!1AQaq\"2B‘¡±Á	#3RğbrÑ\n$4á%ñ\Z&\'()*56789:CDEFGHIJSTUVWXYZcdefghijstuvwxyz‚ƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹ºÂÃÄÅÆÇÈÉÊÒÓÔÕÖ×ØÙÚâãäåæçèéêòóôõö÷øùúÿÚ\0\0\0?\0ğpHúRç=Gjnx¥Ï55ŒóI’8§‚8šF=s@X^y£\'­\0˜¥ã´ktíQš•…Fi¢$\'¥Ç8¤§)ÁÍRåŒ°8íMsõÒiú”!\rÍ\n£Xº¯5jæÃFÕ¿³®<»½—ùTûcóè(m W0td«Z«.åiW#×šõ}~şWKˆí¡XÄØ`z–#¯çšó½İm|Gn·œ$o’W¾:JôÕ‰†™¬ÜHBÇ\",ıCõ«LCN’%|G”éyÌäà9ÈÉì)×šcK“£®©5¯vöFî$,İPğ*X®!èÆ!U?À@É?ZÎ:ÚÆ†-š­ĞÂXJOÍ”ÿ\0\Z³5ÍŞıÛÛå=+bîÂ5¶Y£?6ì`ÿ\0\rHÚ4¢ÄË¸3ŠWUe{°Ñøvµ2n$&KÊÊ9\0u?çÖ´õlïçù’~ì\"çûÌ}úÒ5­Æ›áï%¤ò/™1|¿äôö«^·“T¶(¾\\©÷ISĞUKßnÛ\"oÔÆI&–c*Á0Iy\0<z“øU‰ôk{«hnRşß‚WÊC“îI¸[ñ^‘q¡èöª$@²ÌKÕ€Ö©ÛiS]”#Æ¾gã&¦Î×AÜE\"†I|á†#ŒgµIg¬\\N&*DŒ_çŠæmï/`$†\\º7Œƒ]š÷ş¦·Ekƒ÷•†=ñÖ…	?ˆ‘wD×üİJKp2ø8tïS\\\\I¦ÜNópó#‘ëØU¡¢ˆuK‹¥\n¯CµG Vˆç—U’ÎÓ,²lóH—YÔIYD#«+i]ÂÜøe‡šßÒ5nô„µ€°»NK~¸ËAqn¯%»@¿1µvŞ\rŞ;sp‰™JîÚ¼lÏ¯§zÖ+Mv	i±jA<³y”	‚çÆ3íPÉ`—2˜w,o€~eÉ\0c€{\nĞüÛ×yãÉëÔb¬ÿ\0g¥Â³°nåJBöæ’i}My‘<á‚–!‚„?w=?­qéóë§‰Šù2´ÔôÎy?á]>x‘Á$‘ÊwçlŠz‘Y‘ï¹ÕL¨ËlÄîvîOz5s¸-\rmHö!ädÊüí2i.õì§ß$HÄÑÆ§çÒ²|A¨6‡skkm´©§u*OÔıkjæĞŞŞÀò01Æ›°EŞwè±-½ÚÉæÈ°Ç#®éW‘ÆFk”ñ¦±iª_Çg—÷\nw£9è9ë[º—×3\0h€<Wk¥¼ú„×¦V™Â6‘†cÎçQsÍk¢)4•Í{9Ö8Òo³¼Â™û¥Y?Û:ƒ$j+2w>@QÇSŸo\\Q=¤—ºµîûPG²(ê8ÅAmª¾Ÿa5©*·J¥I+ÉAÕ¿úÕrK{\0·òÙi¶ÑÛ£¬·ËLí‚>‹ıMr3¢]4Ï>«<l‡\n’“´Ÿ¨£%Ü—†-ar:K¼†QêMdê¶—æKiX?»üûÖiI»½ÁhjørI‘…”ÒnBIÁã¡?sºß‡½A·›qıÎp¸õ¬iÚÅÔÆ‘¨Ş@”sÛ5°Úv£¨#ËjÖóGåY‚7®y<ÿ\0õªù%pØã¬on4İv	˜l‘0¬c ŒT/âßÏ\Z€\0s€\0uÅvóiÚ±ûL7L£ä0Ê=oZÍºÓÉ	WjÈF^8KröÍ\'r”În=6öhÄ©_üôe!3ÅA4FÛ½Xÿ\0²r+c\\²»Šuâ{‰8R^ö\n2C§ø~öòxÕ£1!êò RåmöC¹“ZTFb\0“Úº[­?Cµºk™ú1U\'Ÿ@:Ä×K¦xSB\ZÍôíòÚ[LÀ±ÿ\0lÕv„aÏ-„äïcÏolÚÄF“eg#s!pzz¦r;Õ»ëÙ/îå¸›¤bÍäš®TãÖ±NåXnãëÆiÛÛÔÓ;ûÑœQayÒŒi~Õ/÷ª.üÑEöAjE¿pz\n§“ïAqE‚Æ€ÔqšxÔ¾yÖa\'ŞƒÁö¢Ì,eÔ#ÎcŸN´ñwk\"\r\Z…„ÅqH\rÇzbĞ\\{u¥°ştÓÉ¤\0ûĞÀÏ=éqíIøš2zÒ‚0ãÖ¢Ç§J•GÛš¤L…Räf¤ÊfùòµEßš|jYÀ^¤ãI]’_HÜ|¶¹˜©•=¨xÃ…EVıE[¶¸em­í–i¿å¤Š@?Aé[gØ‹öËĞË¶	Lú{Óº[C….õkd–#’z–â»®Òm>xËBç`¼{~UÉØi²Á©}ª)¶_õnÿ\0&îÿ\0ä×_¦İÜ	–+_)IËI;\0J¯ ª¨Ó˜ç%.‚-uµ` Ë¯½^¶°*^…\\g‚@È©u;±kªØwK¶UcŸãõ­?][İé){—h$¨à§àjTÒŠc,¾•eˆfûJ‰üŠA&¹D¸vÖ¡‰&İ¶Y}ªõ©–2K3È0±÷˜Š‡I²a,—rŞËœŒgš›¾fØ[BKËá-ôì<I†ã€R‚[íXß”óFpò¶O\0ûÕ	íš]e @È¤ñÏ__çZ¯ow5ŠDĞ¯Ë*Æ[©íŠpÑ_¸ôØÚÕn\'»Ö-í®®d–e$œîlöÏA]ıše‚âÜ ?hœytÎ¶¦ë,ep«\ZË298¯PÑµ¨®<=¤$Ë \0¨0=«m/t™Şç úc©<Í.XÊ¢—BµÑõ(õ=&ù.¢Œ0Ëò0{ş=ë­ºšé&’_7—³nï.ô;6Æ—Œ²Øş_eíea#.úşFÑc¾_İ‡Ù9sÀŒ‘ôãùVv‡e>«s¨j.DÌêQ;@¬oT6TLR)HE`FiŞÕ.4¶šØ£œçØõ¨§}ecK	iºÏL¸‘JwÈÁlvşu¯àûmv–áÄK)9$û×ñ§Ë:jÅ¡’$…×ËÆGjËg–Æt’(¼ÆWC‡óÅR{¡\ZRj¯m¯\\[ØGù‰ç#üó]/‡õ\0Ó·Ú$.†ôÅrqOu­İ}´¤‘T“£§øV¬B+Öh_|à–ÏŞnÿ\0‡Jp½×¸¦òÛìÖî9„Ü÷\'¨úf§hÒŞëg–JJALv­+›tœÚM8$×½\ng›Mº¸†y-	Hôöü\r;ô$å|t&]:NØåaFOqÏàj}&öhôÓçœÜÛ.¹Áe=?OåZZİ[IŞ-¯ÊÄqãó?•`\\ÀšÕÔd\"FÄÎÚ¥;EÄ¢Ö³2]øzê”p»‰\'wo×•PğØšÃJµ´fY`{±,§p%Gô¬»­i–×Êm†mêË»Ò·¬bIm°çËP\0-ÓiÓn)ƒZ\Zw­¯Rå†È&„¢Œñê?ÍQ»c§ø¹u	ÕšÖT1àŒäöÊ¢ÕoãUâE*|êx8üMT±ÔÓT¶kv\r$ˆX!c…sS\Z—Cu}(µ‹ˆãŞBäÀ?€ÇãOÓ¡piÈö©\Z1XM§9\"Ÿw©C6“xù,ÉÕ\n8ÀVW†$ùnA1¡ÜÈÇ>ã½\\wò´.Ká(åœêK“d§yi3Ï?Âÿ\0^’şÖÖÑ™hÈwq–o¢óø~ÓG}{<Éxùkx¸Š \0şY¦_<z•±ÿ\0Gs+}äcÆ}è•K«	\\Ìíá’tî?\01ÊŸÀ’gx¿p€Â[*3ß=ªİÆ“\rÉsI\'˜GT<Æ°íô9t‹·ka,òo6 ªèsI$ú¢!–Æò#róÈ÷YÀL7ô÷¬©ô[[½\\Ãq;ƒ+–$û*óÇ­l=¹M˜â“ì×î«d+g¿ä)ºÜV3<ÇeÖÂÛœó ëÃsô§ğ»öû4íAğ¬É}xá§1‰È1ÆÇ×’=+ñF¯¨ø“[’yÒ9\\±˜3·olgééW5Kû½wPT6·>qlü)Ï@ sSËi†\"Iu $½qòB˜eƒÓ#Œ·µfÜ¥iÖ~ˆ´­¢ÜÃOÜ$K-Æ#\r÷#_šGúÛß5Ÿxæ\ZËÚH<å¿ı+rçÅ÷\re%­µ´0™ó.ç•½³Ğ`1\\ã|Ù\'¯z—>gµ‘I>¤F3Š1AÅšv=©€ñŠpÆ:\ZĞ£‚˜ı³šZÿ\0œĞõíKÇlRQœS$\\~Tw4´„ñŞ†ù4b™ºŸÜP%a;ãš\0#¯áAêsùS”s@X>†½)qO	¸c½¢3ÏQQ0*g‰ÀŠ„j”Z!±0M^Òö­Ú»`ª‚H?CÛ½QÇÖ§¶“Ë“’@<ŠdØ¸—l×¬ÈpÌå€dûšßÓ­â_´İÊÒ¤g;CpMfZéÜÎ¾B—,«ÈÒÛÄğé{P<Â	ïŸğ«·,n;“ë7ÎŞI–\"»†Tg\nn*»]‘h°Ar!gÉ‘˜õ‚³¯î\Zç;‰qéÜŸ¯¥-£‘R\\E…İ‚äõ?çùVqÖ¥lhı©fbººh‘1¾M½¾‚˜—òŞ´šu“¸±r~f_œ¨êxííU5¿4H¥eSäyj6ÿ\0õşµbÕ\\é³˜Ğ((Ÿ<Ôék±æ¸R«eL‘£e˜ıç÷¥´½šÑ™+°Îj’–cäO1äuOrY0\'$õ¡yrÍÓ	orÀÆ£uçÖ¯è¬.¯$’i@[XX¨näğg›_·@JIó(ÎÓÜS\nM¦Æ‘¸ Ì7°é‘Û>µpih&†ŞÕ\'Ñ¬ËÄ“ÊåÛ©<·§é]>›¥êóF±0WêIéıs\\Ì×ˆ¾ÓÌ‚m_Œ~Ÿ‰4Ï¶Éæ}à#™pÀÇğ¥)6œP$mA~×q†‘Ye•AÜ^=*ÔšÀ…ABã ÷—+åFˆXœîïíZ²$Ée¹XŒí`08¬çd‡mNOP–%µ’ÚT’3×\0úV—ˆá‰5[(l‚ŒZ)8ïƒÚ±uKg–ú+pKNFó1éLîå¯àmÛš4Ø;ü¿çQmÚÅ8êuRAö%½ä2–ºw\"H‡U<ã¯¥SÓ¯®g¶º°”ˆÖL6‹®*}.Xôír)µ8™­î!c¿úşµŸ|^ÏWóP0ó	Ã¶3éM¤å©)]Y›ñ/Ûõ5YeÚÉ\0X@zg?ıjŠêÆXbe(O8$d¿àjæšm¡´‚y¤Q&Ñå6ázmÊ	®şÒ$M–+œ’=´Ü­-]~Õ‹·¼Â<M…;²H­+¨íuVF‘ÒÚéÙd©\'\'ÿ\0­\\¼/k/™},\"¯¦:“ï]ÊÚ+¥,C€ÃÖª]É°jğ\r:U{fÛŸP;VM”°ééwÄ²£±Â8ÈÉÅmê\Z‚’í 2+Fâ¹™%w²‘ÃÊ2Gùÿ\0<Ö\\×º\ZG%©Z3K˜·yöòr›xÚºÍ\nktĞ¤I€kÖ•²„ò2*¶¶]cO–vdéI»:súU=FÍlu6v6Ælã#Ï­iuËÈ6Š:¨º¶¿™§ˆÙò ==ª®–ßf‘F_{ù•­âXî µ†yéæ<°ä¨í“T4¸|ˆZâà³Nëº zû\Z˜FÛ…•ìé…ˆ•$¹iŒO`u÷­Kk°k\n\"òÜ=±wÜrG=qëXÑéÿ\0d³º¿¹‘–w`ªÏåM[ÍBğjr±´Q€YÔ ôÂõj÷²$ÚH·JñFæyù¡Ü=;qPÍ©M¦DÊÖ³A°WE#j}[?Ö¬éº\rœ{=Û\'ÌÒP’yÀÉ5…ª]İ]Ï¼·;“jÒc’ÇŸÏ52µùopZŒÕ®¬gœµš¼eFL­1\0ñö›q­ÜÉ\Z}®ĞŞÄ¼oA’O¦qŒWO:×‘Û›‹XãU-°>ìŸSIö¥Õâµû+B—Ğm`J„P¿ \'~í!ê`iÚüh©exÏ›HÉeŞ\0Ï<™®ÂóÁñêöiwc¾9Ó˜†â?Â¸MNÖÒÎÅe€HDƒçiYw÷Wüj=Å—Ú9ûÌğ(û‹ÇëÒš©o„\\·:˜ŸEk‰bó®\n§8ÇË•åšƒİ›’·jë&sµò1{×¥MãhµÏôk›tù¾WÜÁ×<dœtª^!ğğ 	Ö\0\\¥Ä2ùüª¼ù¤RvĞó|ŒR‚{ÕË½6âÕˆ1±NÎF>µGo¦zR±w\ZÔzÒsíÚŒqÍ\nQŸjB)1ü©‚Ğ_qÖò)HÁêqF8æn4\n_À}sFZ^:q@¬\'¥¥8ühÎ\"¤î)‹ôü)ü­”†ı8æœ	ÒtãšÒ÷©!•’@Ã½G¸Í(<ûP™V;\r;ZğıÍ©¶Õl)˜afCOlÿ\0ŸÆ´íşkÀn4É ¸€Œä¾~ÕçÂPFÖ\\¥møy/d¼X´›‰ÖWê‘’2;ÖğM§c)hG©xVşÆR¢ŞLg\063YĞi—rÈ\0‚@Oû&»YãÔ¬\'á™Ÿ8ıì™öúâ¤ŠäÜHÊì\nFBäŒëñ¨Œ»ÙÆ6gymx#Šb¬Fv¯ ŠêãÖ-ÚÚK]NÖ¸Œ|¤üIÉşUWìÁ®\Zö<±ŞKnÀÿ\0ëU^îØá—ˆe#,1’OÖ¦¤ïd7Ë3iºqq;\\Æƒ\nŒ_İ?>\r2+•Âb)Å¤íXöÖ“İH=Ø8ÏlûV®\"kIõ®ª0ÀQIİiq¨¢{ı;Ìêèx\0.*Ë²º”·ynÙÎ*úê|o’#ğ<Vlp	ÉÉMJ½ıâ’-}‰–c2)Ù“r@ş´“Û[™_1†Fá[zf%„³\\¬?/Ær}:Õy­•dÚÎ®s–‰I\'b’FDÉÈ±ê=)×)-î®¾i\0¹êxü+f%XY]äÿ\0z¹\rŸs=Ü÷[¢H£2* ÎM5%{²YÒÅµœl³,‘“µÓ=óÖ«Ã`s,şí²8ÏËéNÓšUÕÉpõ­¥İFäG9Ëg496î†£¡šï5Ñ‰¾TÇ¸­û›h£·RÒíEv<S—JÙ8Ù¡öª:°Y¦[VœÂ­Ëöö¬æù­5Üäíâ{İRòôçbñ×Œtş•bÓOsª%Ê®ØÛÏNkªÒôø­m„‚ü`òO½E£Ÿµk?Ù¬ŠmÕËŒc–õÏ·¥mNÉÙt½®UÕì&’%,XAÊ`téş6±mæ€·  Ú™ ãú×U«é,¶ì±ñ‘Ò¸mBé¬-\r¡b_<œôúV}Ò¾¥H´QvŞeÆÉ”+4}NOoş¿JÛ\r\"^Æ²…9ûÁzŠ¡gš$¼•Ê”\0¨nKÚ¬\"û1Lƒ·aëZÉ¶ìÁFçA¤YDé<Q¡^I\'Ö¬iÏræÎà|¨~Oz“Ã72i“I3Æ’$«·ç#Ÿş½hßZd-Ô)¢œ¤Û¡—y[`d@Fc×°®×Ê„ + ×o¦ÜÛ]Yy7ˆ0ü{†÷¬«½1#u;CãÒ³zìÎc[óM´˜’VÌ`ËùV}¦u(çYÁ29ëéò+rş&ÒDe&<X6Q}†\ríÇœÙR\\bŠ{êU´:->xaĞKÔà2<¹h$9!OP	öşU‡g2A|òÌşlŠä1#ƒOj½®¬¿Ù‹(%#ÆN:çëYzlk™T)ŞëÔñZi·&ÉQĞÒÕ/šúe¾~~P‹ÿ\0êÅSûDv¶?h„V.Õ\\î¾jÅô\Z‹=¥¡3\r3Ê;\nÎŒì±†Ô—vÉxÒ…¶ÊMası«ªAÈîûIù:œŞ•™â¦\Z—“j-¡@ŠHïŞ¯A³›Ê«&0zœ/¥A¨Íæ\\·™\ZXd‘ÀÅjèZzz^Ÿ¨Ë¶âÂ×Ê»SõëøV¤×MjHï— 0‰©öÉ¦JÂêU3İÍ\r¬kÂÇüXéšÎïƒ°5<Eœ`{š»ó;™sP°†ê•6Cs\'ßCÏãÿ\0Ö¬ñ£Jº{J³±@ØÀLõÉà~¼\rŒnÎÖ\"_âk{NÔ#XÕ!ÓĞ)S™æA\ZqŸjÔâ‘}?O\rß\'‰J$š@£òVÊk‹i\ZŞ	K¤Ÿ!ÀÊ`ãµw/gwr‹+±RH\rÈsì{ŸÆªM¤íü‹lÅ,ÇÌó±‘×îñÎ(æŒµkA=K­+û2İ¥’úÍ—˜£„°Qß¿?­qÓ˜âfòY$Ë}í˜ÇàkÓ4½>ÇR¿k9Úhß¦çèû&²<gà­GGE–Eí»\'9Qè@éõ¦éÜ•Ï=É™Ïj¦2:\Znß\\f²qiêh7zfôõ§äŠLÑ¨	zNÇ9Å/¥×œb€tâŒ~\"—‚œ{óA!ŒÒ:QIÒÆ´¼õ¤½©± èiÃ§øÓ)Â¡Øçñ£zP3éJ<P“cºœğ?úõ×i\Z²ø{M2Ûe5´KŒùkíîk²Ó¦»,PÈÌOFk¹¶ğT–6\"÷[¸[hÔ|°úñõ®‰C–æìŒÛW9èã¹š7»¹¹yÜ¶rç$š»hÆee5ˆ §µ+¼b­íçÅ²œ€ƒ99árzÿ\0*Õ‚ÂØGkˆ,›w9ÜßSÛ”mo\"ïmÊP´r[5¤’€òğNyÇ¥9´‹{@Qı¢aËoª~U¨.-àØmà-1Wp\'Ô¿‰«ÂòÎŞÜ$ßéR°ùm­†ìycÒ“š[\nÍ˜Möë›¬[ğËÀò—`ü(]:èî’îê1.ï¸ÇqÍ9’êîBÂ9\"A×‘ëÓùU¨mªÆĞ»ÕÉäTk¹j\".™çB^8ãY”c·ÊªÚ[«Á4n	rNÓŒVÑç*û&lã¦r)ğiÎĞç]¡G-»Š‡\'ÜÑGCN]>b’9h‡e§Ãq.«z!‚/%XıâF}É=*ÍÅ„w$F™`½”rMZ³ÓE„4¸øU+ÀüúÕQQ·3	.Ä±ø~kióÆ3ÀîÏãSı…¢ó1#2²|Ç×dé·?gK™d<GÇçZvvsºì1…j[ac+J´†8è\0­uÑ~õƒÔcœÖ¦Ÿå·Î[Ôt­ˆ¡Ø ³/y¡Ï°™›+Aµ²qŒb¹fu½×VVBØàzë]=Ô2_Ü3)+\nñõª-bËtH`}ªiü|Ì,¬iÜ@¢Æk–*»S,ı+?Ãšvf[­„;’{VÕÆ›-Å¢Dù0HÖ´¬¬…¤Šü¸â´Rå»#¥ŠÚÕäv¶M,„½ëÎ-´¹õ-[í7h’MÅqª+»»²}Rr$BaCµ¼Vúiâä…]ßĞVtíÏ-ÊòF%í”HòHÛ?•&iı ÷¼{xØª;Ÿz‘f]FyOÏ9ù7Œ³şÙh\Z`ŠÍÆĞXŠÚ9HrÑXÆ‚ÅâÔ©$œ/5µ¤0H¾Ï1ç$ÕÄ´7µDmZ‘!\\ç“QÍqXË—Nûì¦5>\\§$vÍ$Ln\\ß0à­ub®áSÜVMÖša¼k‚OjnŒ-sPÓ’îÀ«š¼ÒY•¤\\¬Kó(#Ò½	‘e”Û ûÕ	tÿ\0=\0Iô¡=Ahj;VºÒZİ“2‡Ş¹û{y`g\00Æà1ùW¥%——Æ8#³gÑÕ$l(\n(¾·rkfd¸XI+›Û>¾µ`é¿Ù÷ª›ƒ§Ê~µĞZé^d-´œzUË›%¸Ô¶ãå‰@\'Ş©´úœƒiŞPÈ3rI¬Û:[öwl,HàqÅwŠÒ8éƒUÔCSŒk.n¥Øä­¬™ ddŒ/BHÉâª¾”Š<j]~¦ºè¬wÄr9¨d‘ÎÀ­ƒ˜ªç)Á\\Û^<‘Ñ!@:ıúõ^úğÜ$Š@1Æ+¶¾@Ä¶1¦>dFÎïÆ¹›‹i¥(ÂN{äfŸ2z29YKJ¾òQnD¦D9û©ÇL_¥j›™ï&–+«ÃÑ.a˜ñœã\0èk*ËOò®Ót™Œ°Qx\'Öº/:ÂÂûV‹22ò§·ÒºLÉ¡šXÖnmçX.Õî,Ç˜ğ²†İŸJİ·Ö¦í-ÏÁ+õ®v`ÚEÌ·Şyv»Ñ°</¡q×é[vú”-›3¢«à˜×¶¸ö«|¯¡wˆ<*Úí„w±ZÀnsÎ¯=æ¸[	<R<—%-#¯ÏÁúÁşuêZ”úv¥çi%æ·”UV\n‘ÜéPÙêöWÖ²Ez–’Ê­µ ”’«Ï t¡M-öÙä—\ZM”Vè\"½Y³óí¹ÆXşUqooj¨Âx®]º¬dá~½+ÕuéÓKæÚÁ¦$°DÌ2Oa{Uùt­Åô«;»İ£ËxâTT>¸ïõ5©]²“ocÊ¤GŒèW<Œ‚3Qæ¯j_]¼ò’]ÎNMQd5	Ü¦š\'×ŠLõëL9£8§bn<(ü©´Í¸ õéÜR/\0QúR²iW×µ\0Zv284ÂÆË¼onyÅlYİhêà>Ÿ+äÍıbÿ\0\nÖÒî-ìÀal³\\¹ùTı+H;QğÚéÖ1®©\r£¤›O“	rr¼sÀÍë·wz¥ô‚êã ¾àà{Uã½½X8œ’Ã2•sĞRÌ]‚™ZW=1ÈïşMDù§>i|„•„»vŠÅ!Œ$kİ—¹ô§èÆ;{ÃËÜİ0Æ;uàTpéww\n… ’7u\\·Ñd²$¦Xÿ\0°Ò¯•«ß¨ì„¹ıÔ’Ípñ=ÃŸ˜qßşª’(·2F<’zöâ®Ã¦Æ°aaKœ—$–5¢–‰ :4Ğg ¬[QÑšE\\­glgU%J®:ôÍt6V0Ù´ã­$j«\Z¢Æ3ô­kE0Ç¼ŒŸAY¹ö4å!{(¬à.¤\0=k–•.uGg8€}Ì5ØÍ]/ïåşééSÃhÆ0ª¸\\qÅfµwe-&ÊÖúÜyj±FÌz°é[±ØIp»n&+İk¢\ZDn˜ã“QG¡n—÷nB\n»†åc\"À	ÁõÍU{«ød1RG‡L×Dºpˆy1ç–5ÒšI~L…XRİ‰#>Ò;»™?|Ùõ…·„arİ}jì`qèE][`cÆi¶º	£VwxÑv9İN·Ó÷O—\0àq]VÁ3øR¬\nBãëB•…a²˜FEV¹fÒ6o¥jÆ›S­S¼¹òÁHS{CwbHÁšòk[fTƒi\'nIü+¾Ğñ³^mïµ@É®Ù;1y	’cü+ĞT‘è¬\0’R­ÂËZE-Øì‘Îhú#ù‘ÏpŒäs»ÚéşTA”¤œàÕûkD‚@•í•Ãjç;è‰Ñ½Jn‹3W\0ğsI8ÁNõÅ\\ŠÍ`}iE¸^;VVÕÊK& Hô«[D©µ×\rVR¤ŸZy@{sL—$dOf¤åxjªmÊƒƒ€;VëF3š«<D6à2;ÔìRi”ZÔ:/<zU«g3eTàVÌI† ŒÔù#Èí@ì`ÙÅ·vOÌ\rßc\nA\'5¨-R6\'¿z ÊE\'\"’1šØy¡ºûUK¨] sßšÚ)‚ÂªKm½·t¥r¬cı<ı*6€\"r&¶^=¼UIí•¹iÜ\\¦œ•tÊ•‡{eyÀÜ1ø×`ñe~aíX×6­%—#µƒG2Ædùvò¬OÍVíõM‘´OiÓd0IrIÀ­SjwšÃ9µR˜AÒ‰¢Õ_;±‚m	˜Î#õ-WJº‰~Ïo6Ÿp½#pÛ}ò:V9fy#%V7Vİ¹¾ëWGg,1Ü¤ZŒfk$Dï€\0>ÿ\0ãZ¯¦ZÁnY ‚âĞŸ¶$+ø×DyR»¹Ï--\"ëR•<”ÌBiNÆ;N9éÁSY¾\"°ò5¢Ã¡*°c|’wÿ\0\"¶~ÑfuLQß„\\€¹öqÿ\0ÖªìmşØğ\\Ú$±äíP¿túƒÖ‹¦ôB8{YğĞŞ¢‰UNN7ïÛ5&°ÒHÏË‘´·¸ıà¸öık¾ñ„Ù}¾m>+í4\rŒãÁÇ¯çúWê¶\ZCƒu¤^¸B2m®F×Øô5Œ}\núRHBÛBóĞt¦öävõ¨ÃcƒÚÅE¬iq\nñÈÅ1£ô©:OJQ÷pzzÑq8¦WÚ@4•`¨5LÕ&K†Š^i?—4Í0ŸÂ”riºÓÔzh°\\wR{\nµi»£¿$ô[é÷SV#©$`~uÒi¶KkjeÀà\0Çw>ÀU¤nædD–\'©ö_·Ñg½¹Îı¤d¼¼gß=ªÚYµä£òN¤ÿ\0²=j[“Y»+f%)ŒÈÒ6É=…Td¹´ÎIk§éŞE´BêqÃ9o‘\0íY²K+¬o\"‚ı²8…^… .\"‰—Ëï²ÓÒŸqn×7*Æ#F\09Î=ë\n[²¢ˆíc•ù} ø­+kE/¸ä³wÍ%´”ñJÕ‚‚\0ú×4¥®‡ZVAG†¯¤˜0\\(¢ŞÙ9Í^U(¸·\Z‘¼*Ô`(À¨ÕpjÄi‘@Ò)aVÃ“@‰‡İ\\Ò<Nâ/ºN4µz!ØŠ0×ùh8ÏÌŞ†µ­í’Âõ¤µ´[t@­\0i·Ñ@£ÀÅ(A\0§…Í<\n,¬ñ…;…*DÙÉ56İÍ“Ğt§šÆ„Êã5]­\'’µ^U§Í;Íbœp,Qáÿ\0^œÉN{U˜éR*\nv™\Z†#Ş±`Ô¡@¥ª2r(›)ÔPMÙ9£O=)˜Í\"“Ôlµ!ÓI”ˆv{SYjÁZ…&Z‘]…Br#Š°â˜FEAªevŒ1ÍDÑVJç¨¨ø>ÔR–,‚{ÕY#8ã­iºYÓnsAV¹•$9É¨ÜA¼Â¶ü°Ù&«É ‘Ö¨”¬r—Ì§æäcYÂ½Â‘Ûé]…Ôiâ¹û¨|¢Ç¨ôô¡;	ê`Çw%væD\'”l•Çûµ­%ÜÖÀ^Y[´lÊ7íåY~ŸÖ³.ãh˜9ù—©9Çb;ã§ÀŒ1$Dä\rßtzbºa-59ªFÌ[¤‚úÙ®£¶HåNJ¡ù”œò?\Z‚\rB+E†ú}Í:gpûÊËS½3W“)3i×„a˜°Ãƒ•FÚò;K¶³¿1ÆÙÛ/F\'¡ÿ\0>µ¥ìdÑ½ua§ÜéMuhªñ].fULÏq^U¯xzÊÑI†ïl–dúÓ§zï´JKº³8\nÇk.ÕœåqÛşµÎxÊkû6¹K„89ü(”ô¡æòFñ6\ZŒ“ş4K’İsîh\nHà{T”…É£·ÒqÅÅ!Ü“<{Òƒ“Qg¦)wsÖ•†˜…q‘ASHızyq´ÉVƒÁ©â¹’%ÄaAşö9¨Ã‘íOTÜE4;\"í»\\ßÜ–is–\\1ô¹mqWÚß\n¸ÇŸåQi‰¤ Ì¤“ƒ°wúŸéVeSvIÆ×sç°«ëdû‹O¶²Üêš”`m€–1ÛúÕ¨å¸¸ƒìºlmŞv$núÓtû}.Ñî<Û‡å@2\\û[i-¿ÛaŞGäùC¯ãøUZÚ‹¶	ö{Xğ°ÆÇ\"I÷«rG+Ÿ6GuÀéQCary\"í‹»‘ŒûNg`áB€Jå­-lmN7Ø»fIçÖµ¡P~aY–çjSë[6Ñî\nq\\öw:YfÎ\rMÔâ¸T±&h‡\"ÉäÕÈS<ÕuOAš³T`i…‹H1Ş¬ ·5KòS*óHLpçµ<R…§ªÓD6 §xõ§§Í2&8§b— f™\r€ZpZP)Â©Ø¥J8S±\rˆ)qAö¥Å¤§QŠq”OÛFŞ(šn9É©ˆ¦í¤ÑiãÒµ!¤ÅM2³¨¨qW2*¬kœP¼AªÁR\r#/¬h™OË+À&¢’Ü’M\\+ÍFË¸t¤]ÊEp8ªÌ„}jû!¢hò\r+™W1ŠÁ»·8<WS4CiÇZÃ¼@$éÅ;ˆç®-âhŠçÒ³Ş( ™rã¿º}«£¸FY·k(‡ +õ¬$Ìæ´1È²†·¹¶i¬Ëó!1ûøÿ\0ëÖf­`©ºµÙ4>hQ“ÈÏëZJè_ÍŞ‘¬ô§Yé©”hdfYŒ¹ÍtÆû³–Zãš8#ó˜\rò®¬z¨ëô>õRö]KFh`‘ã|¬Š2WœuôÅK«I<\r•ƒåVÃS†8ÏZƒI¾´Häû<ÍKò2>\0ÁôÏ7w¨?¾‰¢”«\"¸€ø#8ªÆY{\n=†+¬×ôaam8fY£Ú$Še?˜ü¿•r_CøÖlÒ(ˆ§4»0:Sş´Æ(¸ì3m&Ê“ŒRg¥‘>jîiş[š60n”îM‚(šW ’Ç\0æ·—I}>tKÉbÜË»dm¸Lú\ZÁ\n{úÖÎ—h_×äàu&´Zì5¡½mk{Æ˜p	ÍhXÁÌçjå\\\0ô£K¶7îÒÈÁT6Ğ\0å±éì=kû.Ê1¶A)€Ì½ãNöÕ±\\Qç¤&=s†ÓŞ´´{H,–P%¾ù\'9úšdQÁc|éC““×Ø\niŠáÜ^L@~Tcó?áPêv®jÜÊ×*G!@{ş•FFó]JğjHóuv*œ÷4)>i*8è+[4Í5Şã&ºuù@À¬{ÁÊºp01A©\"F@ö§„Í==ªUO¥!ÜXcæ­ÇsLvõeFN(b¸ôP1Š˜H‰Å<-6\0TŠ)rj`1LÊLhéO´à)Ø†ÄÅ4ì\ZvÚv&ã@4à)qJ)“qAã£ŠAN¦KQŠZ*ì!¸¥Å“;\0´QŞŒP˜i\r/z1HcH¦)ÆZ’ÆÂ*`)¢ÃL€ ¨Êâ¬0¨ØTš&V)Ş¡m>ÕeÁ¨\\d`Ô³h»2çš‰àœTÇ)§)\Z]F+P‹“]¯<+/R‹)‘Á¥p±€S|l¾•p’¢•e[ÛœV°]¬Gê*9Ójİ;+Dg#->Öû<Ò40ƒ‘1f•ºBi×2C,şK›r§ä|{şUni\Z8ŞL\rË÷—³/Ò¢¼jzTğ#,öS,‘Ÿö}«ª3ÒÈæ’ÔÇşĞ…Ùã)óVEq‘»Õk#Tµ[S.Õ\"&\nHœÙõÍC•ÖÖ%]Š¶ï—«ãŞµì$ÚâÒfV[ÕÁß• ÿ\0v­+u!®Æä_kµ—ÌŞİ“\r$„Ç¥pW6şD»A%H¤÷µêöúPKV¶œ\"ù<qï•ç~\"…-ïÌP XGÜ’qõ&¢JÌ¨3ƒG®hÎ}húT—pÇh¾i($@ã‘L9?…8´¥A¤W¨èÏl¾œ×M`­\rˆUs¸ÈöÍs¶¡<à[$Ã½v:|n–ğ¦İ¾cno_óŒVñZ\"ö—i°GæÎ¾l¯Œ{cŸÂ´ïçµh‚ÚAçoúšÆˆF·e]w¹8Ú¿ızÓkx`n,¾m„p>¾õ3»Ü„‡Ã$#ÌÜ\'ºÁ ¹Î=ı)Ö—Wºœ0Z~g=ÿ\0úÕ\rÜrÎ©o¸‰øÏ//éÒ­A%¤_e¶‹ƒ÷¸É?à*/Õ–,YWèF1RB7È “Øv¨#fÚZpôÇ¥\\±¾nùíŞ°{êtÃDoX¯@?[°\'ËY(8=ó[¶ëòûÔ”Jƒ©Õ3ƒúSUÔËÏ­H1ê*t^j ¾•<}9ëA$ªx§µ95*óA‘jNM5}éâ¨ÅŠ4ğ1M\0Ó…R!\\PqIJ\0¦H‚F)1@‡QM§U aKEh@i1E,0=*gĞÜĞ¹©EtHii(bHiØ¦í5#B`ÑÔRÒ”†4Šm8â›Å\"ÑUäNõi‡Œæ“4ƒ*‘ƒÉ¥ b•—&”\n“{•äCT/StgŠÕ|t5s‚¤RcG6Ü;É¨%bñ•«sª‰\rU•CÉ¶*‘ÜÄÔ$Û<`5Nxî+\rÒõ\"’{\';xiBPúÖİ÷É!’@HÁlÖN¢“Xù3ÛH„?-°õ>õ½>æRDz¨ÇO‹PŠ/41+: Øc>¢¹ö¹[«Ç*eÃŒÜİëGºhî2FÂÓP“k*U»â¨êú\\\Z?ˆ\Z<·†Éì˜ïŠéPW0ò4­55º‘b»Ù\rÁÂ«Ÿº[ô>µÄøÇE¾±ºó&¼’ AÛÿ\0ë®ÒûNûT‰á‹!ù•F8ÿ\0Z¥ã“tº® »ao0<îşé?†**h®‚/SÊ§áMéŠ{ÌÄçµ4Æ Ğo¾iqÍ/zOc@œ})FXã9Ï|ÓH9¡rñ¦– nèöŠ÷h\\sÀjêbC-ë»¸Ù\n0¬D.õi\\\0£©ô­Ø_í7ion,’cw¯¿Ó­m}RfİµªÇnÓ¤\0»¤“=}i‚9n–K¢0‰üDd“è?Ô\\Ê¢´Ybœ°şñì?JµÑıAp6‘\0äŸZ†ï©%qæ¼¥gv0ç@ÇJĞ³´¶µˆ¾ã¸ôi-­ÄJU-+üÌ©÷\'Ò’òA,ÿ\0\"Âµ”İ•\"|âdç`éîkRÑÀ\0v¬K7i÷ÈÃlHp£=knÌîŒwÉ¬‡DN†Çœv­ÛpH‰§`:v­ÈOJLhœSÀ«œQ‚:â¢áqëĞT«Q)ÉÅH>´®2AS\'ñS!ª3‘0éNÁOÌXğiàzÓ\0Å;4Èbæœ:S@æŸŠ¤KÔR`zÓ©ˆ(¢ŠhBÑŠ(­%-%\'`QE\0ŞsN¦–Å&4(Îh¦ùœô§f…`wi†¤$TmÒ¡aÅ4{ĞÄŠfâzÔÜÕ!íÒ¡5#SŠ‰.j?ºjcÖ£#4S#oZ¡t£+AşïFà’:Re£¹\\Jr?\Z¬Ê’qZ©†éY²ğÁ;‘ÅTE$P•iÚİÔã‚8 Ö-ì,VKY6yĞVµööòÈùYO&©Ş~íñngQ–À­`îc$sËwsi»yÜ[àÆÄğÿ\0&µõÚeËJÑùQdP Àõ?Lf«ßÙ. ì`(\ZKrÈ¬z‘Ô{\ZŠÚİ•³\\¿g%IÏ$g¸®•ª1eÍ®£k”Î.­àÇ•¸1Aùºsş3wµÓ¼‡Rmî¢,¡úŒAÅtVğ>¬ù‘‚ŞÁÈëÔ}9¬ˆ!ßI·‘£ó³ÊŸàq‘¥maGsÈÙH8Î}Å>¸©œ§˜vôÏ\0Ó03Y\\ÚÄxâ‡µ #<šLàıh¸¬×9çñ¦÷÷§\0Z‘Wv=ê£¸\Zz-¼¯6åm«ƒ“šé¬`•o˜Ç0_-:úgëUmôã‡o22‰%bHUı0Y¥`»A\0óÔç¥oèC-Ç·3·—¸ê};ŸjÈË<ãË‰O.xSµÒe¸UYYBƒî.y«M2GjÆÏ­g{-né‡zI&İò¿\n:W=r\ZëR”¼Á¢^×§ĞT·\Z„–VAPŸ6^·z¡o/Ÿ03Ç<ş5„½é\\Ò\Z\ZÖÍç6ÔbSò.ZÙ‚\" cõ¬í2%2îRHè\rm¬xÀ¢Fè×°áEmÚšÄ±ÆĞé[VÌ1Í&2øn=©Ä’£¾ãR˜²h<úSÇ^i:f•OÍ@îL¦§\\P¢ãš”t«DH™qO\'Ò¡”gvh2h•X“O\0Ô`ÓÃ{Õ\"\Z$L§UÇ\n8£µ‚E¢Š*„-RÖ±BŠ)*d04QE@4€zÒ“ŠJ–Æ„Ú;RçSKb“~E+•f8ôâ™ÔsFìÓXÔ!¬¹¦•æœZÔ‹W\ZFj21On)„ĞR\Zy¤Å.(4‹EwùAª3äƒÅhKÉÅQ—ÓµI¬L»´+6îè\0#Òµ¦F*Œèq•¦œÅÜÄKår?:¤/İX¾LL6°ö­\rzÕŒ_i‹‡^¿JÈ€»i ¸Ç¨­ e$@bd9Š¦r^jÆg››×¸C±|Äñïüêƒ^yq¼3QˆÇ¸©4›Ë‹ç–&ÁR@\'§Òº ßC	#u#[¬„IG–ñF¬O4sZßÛ:¤ wôf×ü+u¥M.Õ@Ã•;†\0aÍrºÍÑƒNÔ&‘NŒ¬¸ä\0x\'ğÍLõ%#É®âã~N*<ŸÃ5fş)#œ—;•ÆU½ETäòi%¡l\\æ“Í†i­Ôç½;Ëàcµ=Xjh<gúÒJå#¨Ón·éRÆ¿}xO\\ÖöŸ$2[iñˆÂE•‰áˆÁ®+O’TCŸ“¡íŸjémİn-¢‰†Q€\0ŸóŠ×RZÔ¹¨\\I5ëİ)s\0¸\0+E%X~óıkòwVlï‹H¡\0-Ê·©æ¦»‘cFÙóº®=5“ÑY‚kÁ,ªÄüÍù\"V½„<H]Y!ëÓ“õ¬‹K\"ò\"·‘˜ôÿ\0õV¼·{×ìÖìsÓ\'©µvV[šGSvÆUáVVÓ\0šÈÑÕb‡bŒœu>µ´©•$ò}ë)›-rª0kN `\ZÉµnqØV”-ótâ“jFpœÕ23UcbØ«\np*,Q 95*Œ‘P)ïS†é@Xiàš‰Niâ©Ñ 4ìúÓT\Zz¯­36=y§âšéOÎ)™±êiÔÕ§ïTfÅ£šB\\ÓC6qšbZ)€‘Ş—&©1X}¦9¥Í>aXZ\r&i‡¥&ÇaÔÆp;ÓL v¦o\rü5-”¢?Ì¤.7şHyíRÊIV3HhP1Ò”)ˆgjiâÙÅ$œ\Z’ĞÖ4¹Å=—½FTŠL¥a“šLñÍ)>´Ö4ŠH3JNE3­5‰®U†Ê*¤Üsš²ÏòóTælŒv¤Z(JÜ‘P2àäÕ‰EFêv3T6fŞ[¬±È§¡í\\3ÿ\0¡K$	òK+Î7\nô	>Uaí\\F»\Z=Æ07¶T7¡§­ˆjæLL×7R—XÈ$e»Š¹Çc3LˆÉ²@¬{`óÇçPéVÊdóóçÅ€\0û¤Æ®%¼º†¡íG w®Èè¬sMê[–H^ÓuÀ\n&‘-¤“œóô®c\\„¼÷QÈ\"emŒFAç“ÅiXÏpÖ1¤À6Ü¨Éç àÑ©Àñè1+J²Ü\\ÃÔgÚ”ÕµßCË®cg²1ÀW’zdğáüeù`ôÅ^»ºyÎÏ-b]ÛŠ¨ïêj§LVi›XË÷úSğ8æ“Ó&ÅaBí9«ÖMl­æ\\Ã¾1ÕAÁ5G8àjG`\"ŒM64şØ“H›U\"Oú¥ÿ\0]–´qmA”cÂ¼şĞ¸EfÂç$× Çz‰dV<åã ‘Àk[ÚÉjU6¾mÚ²¾RG-Æ1Å(-ååa¶>‰ê­7JW†E‘›=@Ş—S´O5@mÒHÅØÙíYIÚÉ’@·¬˜ğÎİ=kJˆ%¶í¿¼c–cÎ}«šUŞmEáN\0ô®¿ELÄ<Âp\Z“²FñGA¥Âc„–àŸjÓC˜ñU-¾èÇCW£LqÖ¹Ş¥ƒÆM_…‰Ç<\n Í´|¸©ã~qœĞ†ˆcš´µB\n¿1¬©ŞÃ\'Š\Z(²¸ëR)ã¦*äcµJ‰ƒÅM€•r{b¦Ö¢QŠ˜Õ\"$<p)TŞ‘EJ¢©7`ôğ™ SÇ=*¬fØ¡p)EM<.*¬CbqGìRb•‰¸˜ æ”\nZ,#àu£ÜS±šk)íI¸ãœÓI {Ñ“@ì4¨<ÓpjlS6x¢ÃLU^(+éO´ìSå¹<ÄaqÖ”¨Å<ŠLQ`¹\nfÚœŠi^zT´R‘^)¸À©Jâ˜E+™	ëQµLÕ`Š†bÈI ÒïHà†>•n*MAÉ<ÕY@9æ¦gÚ0Njœ‚sM\rp7t Ÿ•;°ÏZVû¼”ÀÎ¹RNZã<KÛ0ûAd‘O?^k¸œ3v+—ñ@ØÜw*zˆå Úëƒ½%`§Ø€Ekéìœ[oŞŞÅ`BWÍpF]vûqş\n±o?—˜‡u˜>ÑßH>¼dWlYÍ49e5rÌBÆ?ROJ›Å2X‰£\\ vÁ>˜şX¬ıjU’íÛT\"6˜ÆÉêG§Ò¯Å\Zê\ZqK‘‚Ñùˆºõ§%î­ã÷Ò„»”\0y9æªo2gñ§Şï’¬¹Ü¬Tƒ×Š€:1R–…9»–ñÖ”wüª¨v:Ó„„ÑÊÊSE¢3À?O¥%=¨¦3š”XäÈ9®¯Jºk˜Ö/˜…#$~Ë¦ºÍ5ÆS¼\rÄ(¹ïı+h¿wRd[¦‚Î×pl±8_z«,ÿ\0¸3*î•†Å\'ß½Fâk»Ò[\"°úT>S†ŠÜ¶Ş¯ôõ¬í}ÅdiéV„#`uÏZèì¨^3ĞU+vê€cŒçÚµ-ÆAÁ¨“ÖÆğZvƒ89­\0\nÆO|UL…ä\Z¾Çƒô¬YL‡Ì*£pæ¥‰Á—ƒ“Yw8—ĞV–7ÎÙÉ§}@Ø„|¢¯Û¯µS…p¿7Ş¯FÛ€Úx§aÜ´ ñS¢ÔQ\n²ƒŠ›	°U©TqÒ€¼T«ÍUŒå!y©Bæ›Œ\Z‘zU$e&\0NR3AZz Å4ŒÛ)i1KZ$@RRâ–Ÿ(†â—¸¤£”aIŠv(Å>QÚ)p)Ô†“‡q„ñN—´”;…Æ‘KF(§Ê £QCC‡¥:šH¨hc@È¦§œSKTØ¤BËíQ:ñéV	ÍDüƒš–bÊ®0:fª¾7qWŒ\Z¦ìø\"¡£dÈ%È\'5MØ1#=*ô€¼dc‘Ò²¦,¤ñ‚)$Q8nJ>ašÍã}\\â›µÖ\\î¦‹<¤b·®ßå=+áFŒœT5p<şX¾Ê-ò£$“Ğv¦Y«ÙËb\\ó\"ZÙÖl¶Ã„a6ã¾k1º[d\r‰…FaÂ€z~UÓIô2¨jh3o¶ÔôÙ\"\\‡szsœşF³#¿»6òbVhR6ÚxÏ@8Í^ÑâÛÄî%Lêq¹r	õ¬¿Ü2âæÔÑ›~µµ]Î·<Æöw»½–wå‰\'Ö¡Æ5=ĞİHª0=ªñÓ4–ÀĞÓÖ”O­ûS£ûÜP$µ\'İ‚x\"—<Š\\{R0ô¨:6»¦sZúdîÏ#\\b±ÔdóÖº¡K¦Ÿå²q’HÇøÖ°K©2¹¹¨¶E˜dàÔ\Zzı®ğK.DiÉÀàûT××^u†Ö º}ÕôúÓl	xR\0»Xú\n˜õd}š—ˆ»¾*Â+#€ûÓm,¾ÙÅNT1Ï¹äõ:a±£nß ¥¹¼X`äŒÕEœC=ª¤-%õŞX|‹ĞT%ÌìVÅı>ØİKç:Oè+¥V²N095JÜ,Æ•d^jow?••·VÁoï\Z¶şÌIÜÛmL;m^€ãë[VM¹Wšäí¡Œ2²©cïÍmÛj1+Ë†a×ZI r]]Tu«°<ÖDW¹5;_ ùS\0¤š‹X›ÜÖR©?JËŠì•ù­Z[‚{Šd´]Ï<Ôªxª)&O­L³\0pHÍ4Èq.ŠpéU„€w©<Õê®dâÉ¨¨Ä€ÓÁÈªL†‡QIFjÔ„-QNàQE0\n(¤©l¢“4›….dIIšMëœgšNHvœQ‘Q¼ \n®ÓŒõâ¡È¥ËLàT\r(\rÍ@×\n¹ËUIoT7<Z—#XÂÆ“H¤u¨ZC9›öÈÔ¶Aª­¨2I„oÀÒ¹J)Ûøã­DÒñÉ¬YµPù€eG\\T_ÚÁ°ñ†õéš£±nòGGã§¨5‘& \"—÷‡ôO|n_\0áó‚3X:½Ä‘ÂáÆ3ÁRH®c¯µŸÌÃ+¤Ôz„E_+y¯;³×¤Ñ¤]¼¢pQÎp=«º‹TƒP³IQã4å¨»™—ÄÁÇİî1W ¹Y`õ¢A‘#$Ö2Jm®`½ª€Ó»l;gjÀÚ1j“Ííö9¦M–~EHŒ}v#=•\ZàƒÉ®FÅ\\´r/Ü_¯zíu?f‘±Æ;×,“	gÈ\n\"Qæèx­©=Lç±zêâæ¶º•‚Ë–Ôö<cò®KÅ÷K\rÌ÷I*<Ï(!º6qîytë4>M“>é£ÚH\0\0œızWšx’æIïÙ$ûÁİØá,sŠÖ[ØÅhe8ÜÙäîç9¤eÇ	<z\ZV(¿@Jêå~½*X‰\'\0dÓqƒøzT‘8C¢›zßREút¥!ª“şU:Èz‹3dÓ­li×owF7zVWSŒsÖ§·ViÁÉÈ«‹»÷…¢½S&\',}kFÊM¨³Éş•$›ÄYbqÛ5§oqˆİA?6OÖ©lE¬wö¾%$òzÕ¬d¿#Ò©iCt\n	Å[bØxä×%M$tÃb§t!‹b“–â¯éeaµÌ{“\\¦¥v_RTãå<‚*Íî¦ÉQD?xÒÔ}F÷7õ]i!Ç™…<½Oµ`i‰dBÏäÇœ$CïŸ¨®vşöIeÚ¯’§;TpÜ´,\\ä¹àg®j©Á­Ho¢;;Ï4+ä/îÑG@y>Ôİ?Rš<LT€~è=ş•Æ5ÌÖàÈURsótœšÃ“#ÊPôÈëZ¥bnz}®¼àâiG˜åšsŠÕ·ÔVWQ#c¾Å?Î¼¢ÏZ†Ä~ìz±9bjâk×«ˆc$“’h¶¢=lê.pŠË\Z TÑëj£éÕJò{?½´_¼,I9$ÔÍât¸%B°_ö»Ô4î­Ã­yÃå~~ó€IS^Ciây¡\\D¨Aè}\riÚkw\0¶ò>F3ÕEò±ûÃµj23¸W™E¬M	À;Øw&µàñË\0?:-ØMòÌ	À©–^Ù®B×]Üøc–­¡¿œfIäLßVÍ.j”2–PA©D™<ÑÍcÎh¦+dSª¹ˆ°´RQš9€ZJ:Ò\ZR\rgÇ\" ›æLô5#œU[™Ü\nÍ³XDI®ŒJN	ã€:šç\'×oD²4h©\Zğ	9ÍM{xÊnö$ö¬6vºClzZKVodñ)gØøÏzlºà_ºXçÒ¹›Æ[5o%w“üDÖÚ½ÌNåØ€;ÓÑìq&·37Ë‘õ5Mõö191Çx®%¼A8!·‘Šl÷	:JÎØ‹ı}*”n\'tu_ğ’Ø(Àö*HµË{Ôyq½:£pkŒÚY\';&dˆA9ÍOöY#“j/f\'§Éa]3}<U!™¡ …^#¨©ø\\³5´€\02àœW<…eß5ß=/LTÒ4	1x$’\\c 4rKëê²Œ©ç\0ûg¥^\ZÕ«måÈÊêÜÜcÛë^u{=ÄÏådªÄóYÑÁvÙH¦\n‚	ëB…Ö¢ĞêuÌE?Ùöù°‘ÃqV4-VçLhí¤e{fæ7Î1ìkÎÂö	¤ìêzìÇJÔ½Óˆ¶FŒLÛ›;YxÍ4œUŠOS²]eQDáÁ@~e¤½–+ˆ…Äqí\\[Ü¹L\\ˆ¯u=qZ–sˆíÎíôìEdÑfşŸu½0NpzÕârız\nÃÓŸ1:g»ùrOn\r\r	èTºeki£c­rS –ßíÉ\0h¤cÉÔ«c\0ŸcıG­tZ«„¶sÓë´’Kù¤Š9™¥p¹Â’9Î?\nÒ¬‰ì[ò#³ğ}ÅàPÎªW$´úâ¼zéÚ[©d|–f$çÖ½KÄW+cá±­´IĞv,zsŞ¼ÆåŞây%o¼y\'­7“f²+œS·€zRŒmïMlòŠ`´æ¤‰w1ŠˆŒw©¢p„“Ö“Øk}J¹æ¤BEGŠzu­¾„#[IÓæÔn£†5És;W§Ûø.ÖÎÇå|Å~f?AšÌøa¥E+=ËgxÀ¯PuŒ€Ò°Å·Ë²Š²»</Q±hïYq…\rŒ\n–9O·üMdaÔÉè	à~•Í\rßl+Œ(n	ãŠ0ÓæŠ¸VIKCÒtnmãb85bä`;tã>µWE`mcÏjåÂd¥eY^E@áî¤?n/œâ¬Ã\0»½ÌÍĞ-Yº´\"ríŒuúÖÆiÑ+ì\0zzÕCá	w9Y4éİXÂ¤\'«rOù÷ª+o5¬êäƒÔ×¢Km,L\0µ;=ºÓ¡Ò,¯¡U{~}Hãõ«‰óë‹ùodò\r©ÆXš‰´K©4HPœr9&½zÛ@·á!Œ{…®Ã¢ÚÂsä‚Şµ¥à¶\"ìğó£ê\0ªı•Éöå²¹·fsá{â½Ûû6oõ`S¿²-6bCîEÖ=‚Ç…‚&İ¿*{f´íl ‰#’æpòÀu?•zÓh:kgèIôRÚÜò ·J^ÑtEr3Îlíái‘Ÿİç€MkEªÁØÄe@Eu?ğ‚Ä€´HAíT.|\ry+\0\0I§¢cög>úâ+°	É8­}e%!ÁvêE/®ã|¹Ï«b«ÿ\0Â/q†çhô¬İ—RÔ¦ÃPŒ®@Ëw®Æı€ã5ÂÙAsj„8’Õ¡ü±N0^ÔîK¦zeÈÎĞF*ú¶NkÓ¯™KŸjéí¦Ü£&³d¸š*ø lÕt5(éJç<‘&êBsŞšXŠh<æ¨IAlŠAÍ5©0°Éå8ª\\ãš³!ëY·”*ZÉ³¢œNræïÌ–T=3Æ«]Nm¡òÒ0_É«Ïh¾i*=óQ=d;Ÿ“Uuk\Z8¶Î:î+©‹4“ÍÓojË—K™ĞçsŞ½¬¢Q€š½e¢¤¤<Ã	éëWŠµ‘âóh—óÈ¤nå§§…u¤\\íÙÿ\0¯yM6Î#‘\nŒvÅMö{@8E…m\Z‰l‰lğë/jñıçÎJÛMP»‰ûµzŒ–VÎ¹Ú£éUÎŸ¡…7Rı	åLò÷ørñıøóƒŸSëJ<zƒh#Rp™\'ñÍzCÚ2Ÿ‘ê&ó—¨Ü=ª}¬‡ÉØàÃû@…¥¹•Ÿ¾ıUx+wó-Uåpyó~ïåŞ½fˆ®¸>â¬¡‰‡Ê¢lú’âÑæÃZ¬MºÜˆ¹ËÄı+Liš¤ñì¸Eé]ÌÑ#.Ñ¸Ÿj¥%‰<y»A©sO jqxzŞ\"Æd“Ó<\Z‚ê‘áàTÀÀÇøWjtô\'Ì%½ë\"öÙCçïSPäRe+8±f»†ßÂµmE÷*,GÅKàc5-ÜF‰f0iÌİ\0 ‘ê+’²ºûjÊe@6“…õÈ#ú×Sâõß¤È;‚ë\\v©\r:Vº’5Á]–á‡(OÅm‡Wlš›Í¿†­<CpÓİÄ^vò£‹$ø­ğóGXíD2c!ãõúWwáİ5¬´¸ãÄn`N~cÖ¬]¢/Ş•YÉJÉšSŠ¶§Ë> ğıÆ‡zĞÌ§ùX«ÁşuôOŒü0šŞ—\'–€Î€´dzã¥|ó4mî…pÈJŸ¨â®”ù•™•Zj>òıqHÑ’ONõb†á’kVìŒ’æeVB)QIaÒ¥8cÚˆ#İ\"¯©ÅoEsI ”l{7ÂË—I{‚¿#6á]¾ ŸgA,@³úS¾iËoáaÉqïÉæ¶îm‘æòÀÔšåÇëU¤uQNÇ‘x²a6$DÃúzW\nYŒù\'©ÇèŞ8,äİã¦{WœÆKN}ÃİØ¬D,“=/EÛö(ˆÈëZR.]Bğ1Ş²ô†\"ÙŒµ¬>iÔÔ\nÒ®²&;ÚÅdl²Œš³c§ã#$x«æ  Š³iÖ¦,M‹”¤\rÎzUû{P\0~$kéÖ¦i¹‚Ä1ªt8¨ê$ã?7¥WÔ.Z(˜¨ö¬Ë@]ÌIsÜÔE¹2ÔRWfÚÈójÒB \rÇ\'Ò±&Õ­ìáß$ª0qæ³¤ñ˜¬¶V²ÜIáè?\ZÚ0mh³³8\0UÄ\0\"¼¦Oj	?–ÑìÇP*Xüu{%Óæ=9ÿ\0ëSH-\'±ê¡~~zSØ^kÌOÄÕYP<\0OOzÚÑ¼f“C‹d#$ör¶\rI‘H¥]¬ƒšÉ½Ò$c#Ò¬YêÖ·«û¦É­¾e œÖSƒBLåÖ(ÎAAøŠM6ù‚€kv÷NŞ‘}+/”%XœŠÊæ‰_b;hV&À85»k0Ö6A9jä\rÇª÷D´tQ6FjtäÖ}¬ÙQµ£JkSš¢±!^(e8j@8¥Ç5¢FÄAJz‰‹f¬š«)ÛšÎeÅİJÛA¬»‰T’:š³s)9³äEd¸ÆÈˆäÒ\n2j@™µjŞÓ\'yI\\ÓDµ!·µï“ò­\0Á@ŠFPƒš§s;¹1Û.ù{V“nÈ–ÓÔ{€ƒæ`µyâg’\\…<Õ›ílæ¿ÔîYØ.DJpyn§*Hd’Aäà˜úUÉr5¤Á©»#Ğl¼Ymy8H‡™èz©/Ä]\"/1	\'wgo¯¥yå†Ÿ©^,§$„… ˆÉúV\"H«;Ã\"á!àæºëa§F*RZ1/fäâ™íVş3ÒnH:Œ€FMhA{ot¤Å\"¶Gc^S£XØKs™~BpNìw®ÆçÀwöh—\Z&£ \r±ùüŒuÍDiÂQ½ìL¤ ìtr¨|‚fI<–­r¾•ÍcZÑî5hNŞ€¯C[qêv—ÖÊñ8%†qŞ¹çHÎû›×‚t\Z”Ü¾µŸf™Á\\aZG…û¸5›v+”¯\"~&²î -*úÒ¶Š±SÇçU&‹¾9õ¥rZ3ç‹j¶{TQ€TZµ:Üâ«GÂŞ’dÿ\0‰bÍ¬¹<8¬_èĞêº³K1\'Ê*¡×©ünx·iÒ\0¹b½*/…8:¥ÖB«í$ŒuçŠéÃè¤LÑêÎ‹c…Ÿqf×«æd…SÆ;Õ‹ÇwñüUrËæµÆ:\næZêÍSåW2 ÓÛkn^‚¼Yğ-„Úæ¨T9•ä,‘Œ(\\ó’Oj÷­»Pñ^ñvşïMñ$2ìh•˜ÉçÒ°¬ªI¥fkJp»rZ}ªx^æÎV165ş%V\'0¹¨®ûNÕÃid\\N¬\n’ÎÙ\'ú×|Ñİ]4‘ U=mB­FÜjtzÔyà÷èe¢³>ÕÉ5rÕ|r3ZÕ!…€^G~õRÑÓ—#wÍÒ½|+N¢8-d}[áXVÖ01ˆ—ùU™ÀŠ)¤ gÉ¦øx…Ò ÏŒ*ƒX›1yjOÌkÍÆK÷²;)œ`YtÍä\rÃ‘^U\0)z§XWµëöhÓzµä\0-òÆ‹÷_k,»Q¢ê´éÖ”ÃÈSÜş•³kóÎ20?ZÂÑ›¨GİÖõ‚–›8à\Zêš÷Œ#±¸±nN•$Pùmš³nzÕ±o‘Ò²ÙiÓ2ÇZœÑlLúV>£ª\\D¥ ˆ±=ûVS“èir‡‰oá¶‹—\0zä£Ôõ;Öe³R©Ÿ¼iú•ÕìÆ[©IÈ@OZê4Ë8“LD@7u8¶	.iz+\"…àwÔH—P‡r<ş5Ú=…–‰¤º[Â€*}ê-VŒüv¦ÕA¸´•\0<ŠÚ½Y8òÇc•Å¹jyEäÈòK!_Ş9\'¥b†–êùmã’$tÍn_[:—FÎGZçdiôû¡s;‡=I§•JŒk^±Ñ>gînuÚ÷ƒ5èjÒËBv¬ˆOÌŒOõ=ê¦/œ›¶äÖ¡â={ÄJ–××RÉ\nËáWĞë]N‰h ³A´ï8Î•tT~Ò»›ô\"“š‡¾zF“¤E¨è(öÿ\0º¹QÃZ}¤—–\"¼C¸q¸t5¯á[6´ÑÓWù±ZóÛGp»]A¨Ä+É¤sB«‹ÔÉ‚xæN£ÕKRÓ7/›ŞïŠµ}¥›hŒ°¸y\"¢µ¾`»\'\\gŒšá©qw\\Ğ9ÉDzÕ›Y² ÕıBÕ.+6±ˆ”£Õ\\Ö´›æÅnÛ6TW-˜væºWùEo\Z‘º4ÇJZ‰Š–®çVœU+¦àÕ¶Æ8¬ë³€k)šÒZ”[–ÍV‘¼Ç\n=jĞäzÔ\nŸ¿ÄX··İŒ•bYCj)fƒ¥;n S#ÔV8ä‰â ûµ¤l÷!óKT® ±¸¸¤A÷­Km(£qêÕ¤NĞ»°=jìZ‚“ÍtBQ[UW¡SÅ5Æ…:($ãµxÆµdÿ\0gŞ¤½…{Ë¼SÂÈİ`Šóé-iq\"*î…ÖURS@ÃÉÅÙœ„¼|Ic’È\\fÚF+“Ôo¤Ö¼Es~Êª÷™/AÕ¹{áğò™<–dÏ-´Ÿ­Am¤,.0 zèÄcy\'(ÙšÃ£&ÖÌĞÓwGå¨nÈ¯rÒ	\Zlÿ\0º?•y…¼=-ıÚ;£#9$¯ZõEE·E@\0cíÉM)ne]©JÈÄñe¾¡jauóšò½KKºÑäK‹]şRœ0µzİ÷ïÜ‘ÂõËë$I	Š(Ãd`æ¹[¶¨Ö”lTğö»\rÀUÏï\0ä]tR¬¨\"¸K?‘¶HĞ£g\'ØiğI\Z5œ•õ6ieÂ­6HÇ•Ò¬]Eû°GjdaØ(#Š‹õF\\ñ\0¤ûVxû€ñÖ¶¯m*+U íïTˆg7â£6@™ÜÄÖ¬|8·É%ÎÌ6\n?AâFÙbØnÀô57€$A¦M(\'Íó™“Ô˜«zM¨²Yé…{MÇniút˜•¢ªéÄ«ƒŒTi!†ö3ëÅaï\Z¨Ş66ÇŞe5óÿ\0ÇhJkv/¡nÇ“šúpd\rê+Ä~>ÀŸñ,äd\0ãéCVš3‡Txx•ùPÄ@jÌwÔÕí9ÍYŠãhêkªQÓC(JÏSt¯ÈH<úÕ\r97ê± m¹ş5¢ÊJ79ôª:`Î·çhí]X?â’Ï«4EÛ¤Çß+6PnoÊäá;V®»4”ÏËT¬£{!ó\\Õë³®	õšµ£‚;b¼KY·ò5Vé·qé×Ò¾ƒ»·/(ExwŒm<½]À%øë\\Ôß-dTW4Z/éa‡^§šé4µŞ¼×3¦†[u\r×Ğw®«G]ÀF;Wt¾+˜ÚÈé­*ŠÒ>@j…¾â´b<XÈB4>aäqTî¬Š@\0\nÓ9\nk¯ËÉ¨±IØãï´ÄHÛ\nsN95GJyb˜¦Î3Ív0SÅ`›cçiIÙš^èÙ¶(Ä {V²$N˜lsXP 0W­Y–êkxP\0Y˜ã³\"P¹‰â_f¹¶\'ªú×6œæR²@Û‡ÚN+Ö<Ùœ¢0ëÉö¥û$nä¤\0¯©k?b›»C‹pĞóÂó]¶ä„®Ñ¸–®«BĞN²]®ØÔğ¦ºHc`¹XŠœqš»öV]€yÅtEòkD¤å£eÃx‘ÆWZ]Bà}ÄÍHĞƒ”İ¤b°œîDcĞÎîñÎ]I\\ıÑUåšy`‡ï[Cåi<-a+½M•D´±™´ˆ°Ş•“Ì{fµ5)66Åı+.\nj µ)»«“f­Ë3„°¢æ_¥lÚœ[-‰’ĞÖŒà\nŸw^•©J³ŠKR)FääU¹j¤Ø\"²‘½$TBi¸!òiT~òËŸ­I¿RÔNFiæÛ¨J9\n>1Å\\rä*’¹œ“LaŠ5<\n\\&rTf—ƒÔRªT®‚ıÄ\0‡šíçk¨aß5ibâ¤`\ZÑ;æŒBÖÖâÆ=9¢b@QßŸñ5—…tØö¹Ë.z3Ív)m•úÕTÓ£Ù9mØ­¶¢S[â¹‚ÊßËUz\nmB6 –§=š‡‘1ÃŠ†kEó¨éÖ¦Nú³H¨­Š—’ÊW‘„#µfEfÒOÈ$f·&„Êp=­ C’*®[vC`±EEÀdBœm©Jğ1By¨–¬‹±¦ WT, b­Ÿ»ïP8¬ÚÌ‹¥³X×™89­«Âu¬y$-ŒÑ³—ñS‡ná»¡à{@–î‘¨ù¤ßë0?•R×£?gnpÇ¹ô®ÓÁZPµÑc†ƒ*PµÑOàd»#}-İĞTõbªG#šİŒt¨® Ş‡=ë	Gª&5m\"µ¤l¿¨¯øøm4çáßù\nõ»#åïŒ\ZóMuá˜¦@KE(8<Í&ÕÓ5JÒgÎ-Œb‡#4lAëÒŸO­vÛC©ÕíT´È÷ëğ(ÁÌ«ùf´\0¥{ãŠ« &ÿ\0Z\'c:>¢·Áÿ\0Ñì}I§äij1ƒ·š‡Hég»Uˆ.œ1éPh|Îäz×Ö´¨üAq-ñßâ¾=·XoÔºûÎ½¶îeH	=…xoÄÍÍÒÊ	¿h÷õ®)ÿ\0XXvìîE§ŸôbXóJê4qûµÅr6\'|(¹ãuúB‘ık½’ÎÜ\0¥^Œ#U1€+FBk¢\'	‘I\"8©×€(<M2‘Œ:ÕYíCd÷­O/i\Z-ÄU$;˜ÑÂèq·\"­F¡åVeû½8­\0ô¡myéúU&>nâÕ°@äŠ¹\Z P1ĞSu«ZfR’\"‘Sµ)áqNìÅÈiÛ•Š™Bç5›WH[ùU9î6)Ãb¬JB‚I¬«ŒÈHå¬¤Î¨$Q•Úiú÷¡€E©HÛÅFß14#K\nó“Z¶äqšÍŒm\0Ö²’¢¬Æ´-ÀÁ©˜œqUíÆš°ÇŠ³Š_:ÕY¹«.\rU|àÖrF´Êdü\n°‡åæ \Z–3òÔXİ5$LTã<\Zo½>1¸SM¢^Å»°EH‹Šd|pjÂŒÖÑ9äì9\Z—`¦c¤IIŒ({TmUŠ1MÄ™Eâ5CÇJ¼S&˜ÑÔØÑT(ˆ†zT¾VO³ST²¹î@W*R3Le¤Ñi‘ŸZ…ÉÅNF*´‡š†‹F]èËtæ±§|¾=ëjñº’+níÖ”Jf6¨ld¾¦ºÍ.y´ûxTÃ´ek•¼£\'ºİ ­æ‘	ï·¢~é,ê­¥Æ®¼‚3ššoõF²4‰LlÖÎzr¿J×Ÿ˜N({óV‘‡\"úQØ×;ñ\"Ínü5(<U¿\0k¢C¶÷š¥â¸¼ıåHÈØOéX¿„ìûHù²óGæOõ|úµ‰wáû¸yˆoÉí]“Ë”E)Á<g§4¦@Œqœ×\\[±„¢›1¤lFz`¸éLğ’,Ş,´¶Ÿ4GsRL39«xFQŠmú\rÒ\0	õÍtá>6K{L¦Mˆ=)Ú8(ÇÆi¶_¼³_÷iö¿¹‘ú×Ÿ,ÙØ¾]rè¥£€Ø8¯)ñ”A4ËF?y¤äüt®ûXºY“«WxÎà=¥¤g ù‡?®Mæ…4*ZHV(öñœ]¦’çË@kŠ…~HO¸®×Kÿ\0V§Û½z-èdÎß<b´aÉ=Mf[rkRƒoZÉ†ÅÅ$ã4õ\Zlc×š—)Éğ¢R(5h–*Æ1Nà(š¤gq@©b‘j@8ªD6(<R\Z1š0)Ü‚6¨d8«@VO˜ŸJÊLÖY²üvªáFÑZğ3Y¯Ë’k\'¹×WlŠŒ/ÍS7sšM¸4ÑbÇÉ­Ko»šÍˆ|ÜV”\0\n´D¶/ÁÍY#¡€dU‚{\ZĞâ›Ô¯%T—Š½ ªrãÒ²‘¥6QdäP‡éZbcñ¨GR¿µI€Ø5)ª—=©¡´š5†¦FÇZ¯eEYÆEh)ïbUäS±Q)ÛRf´LÅ«EU’ÓïN¢¦ÃGµDËÍNyÂ*\Z*,®ËƒQ°«%zÔ1RÍ¢È[Š§)È=½ªÔƒƒTd\'iÏZÉ³h™·mœóÅcÊv‚;zV•áà‘Y¶ÑÜÓE2…Ö^&Àë ğŒ¦[5B~éÅsó©r}=+oÀ£÷\r“œŠÒ2Ô²yW²ŒàÖ¤²f?Â°5á\rÚs‚jÕ¥ú] ÇJÎ÷V…ìÆ°&ã­G¬.t¹‡ûùU¡2ä~u_Vû>o÷MgĞÖ÷hùŞú5œÊ€ò›È5VÒpàÃ#l‘:†ïEÔo¨N»ƒ1‡×šâ¼HŠ$ËĞ‘ÛŞºáğ™ÉêVeÄ:¶9¬})ür<m”6|\ZÖl•\'ŸÆ°ùTV|Üg¥taß-C&}M¢Î’ÙFÙê8©îÀÍé\\Ï„/„šD¸\'hÉ®‚åÌĞ¾•Éˆ‹çg\\v3¡„ÎÏ#.rkønbmFìd“^©¦Ä¿fÆï­p_íB’SŞ¹j{³‡vÎfÚF6ñ’{ö+²ÒäÊ\'~+‡±;­×·NµØiNKÏnÕŞÙ™ÖÚr<V´\'å\0~•‡føµ “¦;ÖL«\ZÑ}ÜTµZ&Àş5d)#6‰\0ÍJ84üóLÍ¢QK)ŠM<\ZflQòÓÃ\n…š™¼‘Å[–KŒSÔ{‰£(bå³ŠÛ.xæªÜÈf³“±¬İŠ×sT˜åK#e²zÔ;>~¦¥jvÆ6BÉéNa€J©M‘N3Ş¨†Èá!Xš¹å€ÅgçŠ’	NìsM0Q¹ĞBø©ËqYğV<ÂJ»œ“†¤®xäÕWnµ#HHâ«;m¨eB$M@¤–éNüüw§*ŒZ“£aÊC\npäğ*8²ªP{\n–`lUµbHô¬õc¸UèØÍh™ÏQu\'&”f˜XfSG;CƒsŠZfA¥İT™6Fi›é§p°òi¦šŒ¾G\r!XÔMƒM$–Í#*^¦©X¯!ù±Tç<qÖ¬ÌÙbZ£$‡§¥C:b´2oÜEb\\Èw…Î3[7g$õ¬“ûá¹ëHl¯xÛm›Ô×IàH¶Ù9=IÎk–Õ_m¶ÁÔ×eàäi*ç2sZÇálÍ—.-–{¶=NqU	lîPÆ8=…h[7›4¬„òi—!¼Ğ¤®k#E±§ïˆ0ô¬Ü4«†ôCZòlˆb¹oŞªèòŒõSœTË°–ç†\\fIİ³Œ±${æ¡?)ÜÓ$ƒ99çĞw¦7Ê0zøŠëŠ²2½İÆ…ùvçŒV¢À#‚x®€/<·CT5+]ğ–Ï½T]¥rè5c5°·,x<W¬Û*´<æ¾tğ^¡%©\Z•%w`Ø¯¡ô¹ã–Õs‘Ö¯´éJñ±$HĞ“s>9Äú$¯S“Šë\'RSX ³ZdÑ…Nq^e]Q¢Vg’XÉ¶2»±Î+°Ò0Eq–ˆÖ×ÄøÜ§=y®›C<ÍÒ»£¬t%«Hîíî–µ-ÉÜ	éX¶r|ª+f6qšÍ”(¤Õ¥pZÉBÊ¼“V¢—#9 n&Š¿õj¨¬qRF9äÓFR‰mN9¡¤ÀÍ7#§jR ö¡˜Û¸‹ 4‡æèqHW)Û:R¹Z\'œİ)›°(İ‘CdXBxªsõ«MÒ«MŒVr5§¹F@sMU òjÎÌóQÈ¸©½®n¸M‘‡—Mşõ^i01M²Hd“æÀ«6¨¬Òù“ñ­{<¼š¸hß-´U˜Z¤œ5[ Osh\\\r¦©\\¹9«®êfÜH•œŠ¤›e_0´Õf3‘ÏJ§€§9©à|­>†ÒEŠ\0*qSF¦N”$K$òÆXi«Ç4cæÅR0nä¡ÁlSÁÍF M>75W2hxõ¥$t£#­0·9¦M®8ğ)ŠÙ4æ|­EœR\ZC¤r¨ò¡ÏÌ)¤ç¥&ZC„˜£2ƒšFÎÒj\'oRlÒ1LIprEfÌH$æ®K\'—cØU\ræEÜ{óPl´3n¸İô¬9esÈ­«æÁ8®zGÃ‚O~ÔÊz³†8ƒÄğ+¶±c´İ®(ÍÖ¬™Ï\rÚ»«e8P8ÏSíZı‹¾#BÌycjüÄúU‘I(ë‘QÁ \"<gÖ¯[¯–¹nIêj,SĞ¥z<”,\rywµ\"Ğ›t|İG¨ô¯@ñ6¥­¹,àÕâZÕûßjà€àjb®ÂNÑ1ÈQ»„}qQ¶ÒrI\'µIË#¨¦„Uè8÷®£%<ŒÕk§Ü\n˜É>•31D9ê{“P21„ g9ÍkNÌ‰;^°7fI@\nõ5ë>škHÄ3·±ö®sÁ\Z\"Å¦ÆÒp:œ× ÈšzÚù{Æğ¹õªÅJ0Ñ•EI»EDbaHéUnìšhYsœÕ\r/SŒ\nqŠèbÛ2õâ¼ÉÆëC±§©á:å«iÚÃî‰ÉjÎ….geÎs]7Ä-\"Š+£“†úW¥Måß§80k„ãÊú\n¥´’=+O9U=ÅlÆÇå#ò®sO—‘Ï½“·‘Í\\‰L¾‡wŞà\Z¶Š¿*úU8Àf«¼H©¹W,Æ1Ö§Ü1UãbxÍLœS\"H‘[ıÆ¢fSƒóŠW3h™1Á¦ëHàçÚ‚m¨Öšv6ŠMÔ»R9ºŠM…—šx9â¥Ì|Ö+\n2k2îà	6*õüâ(˜æ¹uî$cÛ5VoM]]šbpÇ­Au ‘N†<•ÜxŒûÕI\ZØ§‡|{Öå©ÂšÃµçşµ¹nQƒÖ©l\rhhÆÙÅZ š­%LÏ´qÒ©œ“Ücòš¤UrsVŞAU¥›5§¡Fc´œffÜóÒ£œóíN¶\\Ó[\Z´X’l15¤ù=j¤ˆXf …Ù&<fœAÁ5cª‹´¦!»\"¡´û£š´FZ¦6^ì¬A\'£FÅM\"P8Ò‹—U‰òSqÅ2&bœN¬ì9”…âš·Ÿ»¹¦‡¢âW*óÇJj¨ÅN@+“Q€9¤R–ƒqP¸3·2j[4‰F\\êzUyT*œt«rã8ª7N@Ú=)\\»˜·­¿<ğ+Ÿ¶rN0+kP?(¥s×ò\r§ÛDwoÃ±ïZB\0ŸÆ»«KmàuÀ®oÁ¶™³yÈæG?•vğ>x­jhì„µF¼Õ=CRÊvaÀ¨5Mb(™İ‡µå>#ñdº„9òºnïVjòØ­¬ƒÅ#“P¾ØŒ6r8=+“frÙn¿¥HÀÀ$`äñHF@ÁãÚ¶Š²3r»!öÉn})¬ ŒÔÓñÉ=zúĞªOáœUèIœYeœ/aÖ¯4*FíÌãüıj\r.\rò¨ åNGlÖ–·•»ïÇùö­e>F‘œ<µ;[=IãÓáŠ2€Ò¬­ÌŒàïl÷jæ¡»Q[˜/N¦¥—_·[v\0ïd~‹Ü×YT©6Ñôt=k¡ÕA¹A1°Ş=ë£Òu`øØnõæ«âÈ‘Õ¶å[ïòiâæIL©\rƒ thÕZIhaŠ­‡¨®§£xÊÙ5\r\neÁ,ájñt•­îâcÑ[¯LÓü[iªiíHB¤Ğæ¼¾ïtwóAŒcééE(Jgp))@ô.à:©çµtPI•Ï¥púÎëtÉµ×ZI¹kièÌÓ6­n2¹>µ „¹\\+1Zv’†PI¡§ ôÅXsP+îJ?ËPNä™­==ª\0A©€Æ1Å;‰¢`wLb@¤ÎÚBùŒÒdÓ”Ò#SÔ‚M1°Eæí´P0*)\\b¢L•«9íbà–ò”òj­¬;Bğ)oÏ™zØíVíbàéD4GrVE„\n«_\"\0u«\0ÅR¾B(‘KR„8\\V­©ŞÃ5“Ş@µ±kPªCvHÒ‰2ÜTädŒôÛtl9«DÄ\n»hpÊ^ñJ@µJæ@ â¯Ü#(éY7DY3¢Š¹]›y«v±µAX—÷­[1‘ÅRØÒzxT•\n¶{\nÕ+T®W\0â—S8Jú\Z6RnOµ^V-YškfZiÒ­œu—¼)<T€\rI\'\0Õv“#,˜ R9©¨	æ¦1Š’yâ¯¥.3O\nD^Ââ£v\n)ZN*¼I”\\¨Æâ3Ò£àSÆ\0«\\Æ*Yª+Èä¿NR¾ROZºß(ÀëT.Î;Ğ6`j-†À<×9¨8i¸ôÔÖõûâ^½k$óõ˜ä‚ÜÖ”÷!— Z­¦™xşSêwñYÛ;³…\n2I=+*ë]µÓ-\ZI%U\n=kË<KâûrG† c´Ïvå©I9ËB“Ij3Ä^\"›X½p¥²}Ñêk,@ØŸJhRFÜ¯^Ô¥l6ş˜ÿ\08­”RV3rmê4œÖ“®yéÛiûB¶ÑÉõ*3Ô‡)ˆkdàdñéIò~€ÓÀ\0€_~”Ù\0r	¦Î‰fc„Hè70ÈÕC[•ÄìùORk£¶‚.Ï˜m\0çŠæüMÙ\"mß7<cV2Ÿ5Baî™77<rp¼\0\r!.Á	?/Lfª¦|Ã´Ş¥ÚÎıxnx=+ĞŠIhEJ’“Õ“©Æã#ô¤vbz\0Ç ŒõÆH«sgµ#\"|òj†f{O=¿Ï	ÚÊzƒPÁ©´÷Ì&ÎüãšRUv“zVÎ`ÔUÚ±q»ÔÒœÚØôÜyslã¥v¶—ÆkÏti¿yç‚:×mdÈ\'S¥-©İr\rj@6°>µcq‚qZñHH¬‹¹¶«Ç­<1\ríT¢|	5h:j\'©*ƒ¿#¥[SÇ5YOAScJã–¤ŒIôÄSÎicç­J«L†í Õ^}jP‡½*ÓÍ;Ù97UyØjÃõ¨d?/5“Ô¸­ÆWQ`x´àeU¨õ_4ùˆ9^sò½Tv±ØõF ™õªWä2\Z’3g~TÔ-.-	lï†ŒÔµ+Ú\rÏÛ­tv°ü£&¹kK€²†©é]U¤  #Ò´Z!ÔmÇCVÙ\0â­`zU8¦Ú*UŸ5´d¬y³Œ›æñœW=yÒVºO5Yk&ıQC?jç«kİi¸»3œ@›ElY2ªdµŒ\Zåˆæ¶m,\ZtØaM-º³]K2\\!ã\"ªÏ òÎ95Å¶“vòG½BŠg™æ¥jô\")ZèÖÓ ­1Ò©Û D\0\nµœÕIœµ5Ù2EW)ÍLÏÍGsSpĞÜb÷ºÒ0$Ó”sÍô&åÍ&úİæšW(3Vˆ¨›kŸ¥±U÷¨·2GãHÑ\rœœ\Zd mÍ+7ÏLwİÇz\\…ÈU\'½e^¸\\œÕù>µ‘u“ÁÆ:Ò*æë“×™¦\0u)§ÁZşY­İ»]Éè8ªz<gÈš@9/Ï=V´‹±œ¶3üCm%Ä\r×(rA<WmÉl€sî+Òïm‰‰·rrzõ?äb¼îú!ì«ÊØéN›ÖÄ&ÆcéœóRsœ€3Šg;AÇ·­9‰èrwvkVUymÙşTÆÀÜ@üGJyè@ûŞ•ÏdŸ\0 \'HëÖ˜äã¦}ª]ŠF2›÷øh¶L\"\"Ç÷Oa\\¯Šá+±Üœg+º¶Óe¸Á2ÄqÚ±|e¡^A£ı¡Ñïİ×Õ“„£$Ù	­<Œ¨aÇËĞÔƒsw öÒ˜«¸àô>µ¥\r„Ó1©88×£t•Ù\n›“²+ª|`¾¦§†û¸f8É\'©®†ÏÃJªÓ\0›»µ½m¢[Â«gÄ{šå©§\r§¡G+©=e¡À}‘ØnòÉ9ç¥bëV3F‹/–ÀÉÅ{\'ötD\0P\\õƒâ%$ÒfË*’8®)f7’V;?²Tc{œ¯‡_Ï¶Œnùí]å£°M§8¯7ğÄ…gòÏğµze¨B7tãŠí«ª¹æÛ—Bı£…“–5·Æó\\ç˜ƒtÅlZJ%±L\rèÜŒ\Z·nÛ”³g¯¬èe\nµ£‚¤qJCE¨Ü‘ÏZ²*¤{5e\"²f„ËÅN£\"«g5a©3)¢]¸¡›å¦³üµ~´™šÀœsQ±Ü§˜SHÚ)XÑ´Ci¬»›@Í•ã§$Ã$µìÍ!çŠ:!~¤QM$*[›‘*nAâ Ÿ°9¨‚´œv­]®6Ñ‘¨Ùµ›ˆ!H­=+UVP¥±ê\r= 2¦ü¾•Ÿ.œ‘>cÊ¹9â­[ffæu‘İÈ\"×ª;×?\r¼êª<Ì¶:Tßg¸#ælsI«	r³p^¨Lî™{v÷_$wÖ¡òJ™éØÜ0‚•$“º\r¨ˆ‡E_ìªá[š¥±ğï­4#n•L«®¤Ó´—-Œü½ÍY„ùJEG\nI¨ãœ‰yõ©JÅ&š5ásÆj×j„OĞÕ…“$\niÇRM´Öâ¤$LnjZ!1 P£êajEnIA`85\Z¾E2BM†ÈAnµ¤\0)¤õcÖ y²y¤PæníÅFÒ£½*>QéM‰JÙÀÍf\\Œ)=M]ŒdúV}Ãnp¾´-Ê15%ge=Ç¥]Óô›¸¬-XDÊÌ¸cŒ\Z§}\"%Ü[¸Pã?Ló^5½8Èˆ%LJ¹·«¦\\—\"Pœ¾s€º¶•mÀ‘XwëÅy÷ˆcİ+Ã7$×Ş½êYt­I\0‡zœcƒÇõ¯$ñætë—æˆüÁ½EfãÊÈJQÒJÇ·rğ°¥#7$°àÒ&Ğ™­9ÔÏqÅh^ãGß+’Ç©¦mVPH9Æiüdã=j#ïÉÇ¡Vëœ“ô äŞ•İrzS\\Ù4Ğ4{÷ö®•bÒƒŒ\nä<y¯Á{fĞ[Ç•+‚ÄqY.îíóœgšÏÕ]$ÓÀVË¼ö¯>¥wQ¤{ÊéA]îsZNšoî_ ¨Lœšî-,’„ªà¼sXú/”Fqë]m¬NÊ©$8­ë:•,Mp¸zt•Ø±.ÌÇÂç¦O5f(¦a•Şoi”´o>s]t\ZUµ¼@lîMÁ¥¬ÙŒÊ=#©ç±é’ıØÏN3Rğ­ıÅŒ‘¬jCFAÜØãélm`Â’£#?…gŞjöI n£šU0ôÔtGŸ,Ö¤´HùsL´knX$R¥IOnkÑlGîÆsâ¸½zé?á>¼hÓhi9®¿NÃ…=+tÜ©&ÎiË™Ü¹0İĞàvÅKg;Dä±êx C’aT÷ì|ôùªè+TŸ,1ıkZÉ÷!>µÎÚÌ\ZÎksO`ĞÀØRğsSÇ÷EQ\\‚\r[FÀ“4E….HàUo4ôõ˜hI’ÉKæ˜eU^M@ÎÍš¨ïƒ×š«\rE¼ñäÓ&Ÿ\rRóvM1¦FsO”«+’F,Xt¨Kî]İ)ÈwuÅ  Õ$S—A»5¤U!@É§D|ÇPxQN’/›¯Z„\\j©À&¤\'ÎGÒ•q½@~$D	ç<Šh™2´qË»5$øTÀûÔé	è y4ÆÈÎîOz\Z+˜Ü–Í>8vŒMI°ŒTÙĞv .V6€sL  Qµ\'RKµ¸uÍ$Ìd<t&¡X«LûÃèiC‚qÛ¥2“.y ¨ÛÒ¦‚PsßEHU`¦­D¡gœŠ,\r–÷dõ§«sUÁÜ>^Ô«¹Xçğ¥b\ZV$yƒÏ\ZI¿$SnR¦FÀnÇAÖ¡¢’I¤›[¤vÀÍT2sNw,£ëR\rÊÜŞ«0hº`½ù5Y_æ=¸ªD´[Œ¶NzUi$ŞÄ‚•ùdt¨	%±Û¹ ±,0zUÏœIì*ã6IÒªÌ{<‘šÎ§p©{üSÄÍ™1ŸİÀÔ\ZÄñ&¥­âù‡?/­e\'Š÷, Â*ønàñPéUš¼OŠ£F-MŒW’E#2\rßœ}*/ê\r©éMäyÉĞû\nçì¼Sh±*2²‚¬\'¦\rZ¹˜]GæDÃçmª¡4Z¬¤´6­:ˆ^/TrhcƒùÔ²O]½:S1ìŸ.C*&c’rI#ò®£Ãz1¡ÁÀ#¿ZØ`0=éHNsÀàu59?­1\\z}Ò1ÒA\'å\n½r=¨eb¹c=h×^$¸“ËdÂ®0Üu¬Ç¿¸¸‡˜á†jròJ™ƒgŒá«¢•GDŠ©Œ­Që#¶ğe¼·\"¸–Å{‰¤Ach¸’{W’|2XƒK#ì8Óë^ƒ{­4ƒË*«Æ3÷ª±<´´[—S)ÁA3~ó^†ÛÉéŸJÅ¹Öî&#v‘€;V0ÊÛˆ{äğ)ÜT}=+…ÍœÖ\'šêáäÉ•˜ØÕiÙŠNêr¶©‘Q8fm¹À=zÎmµ`Gø5‡Æ„¯İf\r–®ßI*`Vİø×3ñ\ZĞZßÛÜ¦H9Ü}ësÃr,–13’ÇÅmKZ+ÈÙntp0bN:V]Öw0<sZ°íL®?\Z«¦rMdôc$Óf^ÂGĞÚIó\Zã¬œ¥Ã.p;WOe&+F	:å©\'šp“œf©Ç&QA4gÎ2kjh™w%›¯ó6ÀÚ«$Ÿ!\'Š’2§=Íh‹QÊÉªœÒ\rùíR,˜R1øÕy:ï@+ÜG2àúUebğqNÈ<ãšh2QŒûSH«“…jB›xçšTÚ«†”íîÒÃÂã~îİ€c½?ò\'’9§¢3œÔÕµ·\nrEKb±Yc#WÌƒ9À§A_Ú­<†\0â®ú-Êr…E9¨^T=¹5sÈ8ÃTš@Z–TlI]Àcš–DÂgš®Šá×sZkäù©µ ¥de.:6~”ÙPâ´Z\0¤µZXò8)†û]|sÉ5[Ì# ëWşÎXnÔß\'qÉÅ>a­\nqÈÅğA¾õoÏ#wªåBÌ9Î)ZVóU@§pfœ2nè)ÒK¸£š†=êen‡bPJ€{u¨¤\0TqS·j„­™1Ú¥3± ‚:Õˆ¤ùqUî\0A•6ÈİéPËè6ìÙ&ªG f9æ¥¼sÀè5ZÔ—§ˆ‘&\\,TÚ«î/¼=ê[®ê½\0ªÅŠ®\0ëŞ‚F+®séP]8KrÌyïR*ç\' ª\Z„Á# ò\0¥\' Dòÿ\0Ü¿]§æLŒÙ¬ÀŞ7¡*r ‚´5‰…Î©u—ÊäàcÒ³Tn;”©,¼t¯B‚å‚0¨ï\"P¬Fİİ=*Õ¥ÛB[ÉL†SÒª’\\‚ªeƒÒŒÈï’r}y­eª³&q•Ñ¦7c-ó0àzb›òç±ÏQN„†ˆ³çh*F}1×Ò¹6ĞŞ÷Ô†R~ñéÓ˜\0-zã4Ù.c#ß½J€¨\no±&y\0}ãßÚ£Ã“R68#ÔÓYNw‚Ol\n@såƒ0cÏ52ÆFF23‘íV¬´Ù®ÃlC•µ†e•WyÙ ×C­\n<-ZšÅ^¾û8–\"¸/Ôú×d§sä“×ô®#M±şÉ»@X²¹ü«µˆà)=1\\õêª¯™:3¥¤‘mÊÊy°©CüØêê:ö¨¢\\‚9û´íÄ`õqÕÎd=Ês9ÅW/ÏÍJàà±j7R©‘ÆGZO`8oˆ¯q£€°Äw¬ïŞ‰m„yÎÓŒZíµ›UºÒç…”|ñ‘ÏÒ¼»ÃW/§êrÛ±ş,qZaÔ Zîz‚1cèA¨o·†ü*›c&	$ãŠ³>éc;?Ê¦JÆ¨Ì€·“ÀÆ?\Zèì$ÜG§¥s#&mİ‡»¦J†Ğp1VµCgL¬ËÉ§F\Zhæ!O…°àw©AĞ¸‘Âç¥*¯”çŒM0§»=hL1a°qUgÊàõÍHÒíQŸJ§qs–Ò•Æˆ¤bÄ2­M\nãæ=j³J€˜TĞÜ R\r5\"ãôcsÕ¥Œ\0¤ŒšÍ#9V©…öW®úìİÍE1§†\0Æk$Ï#æ™½ÑfÊT‘¹\räa…hG,rôë\\Ÿ ä5X†îTã5¢dÔÃ)j™ÑÉ\0aÃTc*CY‘ê3Ö¤}Bbh2T*-.i¬¼’)&º!ŒŠÂûTìN\\â”¼sRõ/êÎ÷“4$Ô<\néyª;p2j\'`§éR_±…´5	Gÿ\0\n‚|m;k<İ²ôj…õ&{\"ÚªŒ“Ö¢ ™7VqÔ7?zš9gŸT®L©´h,¤r\r[…÷øÕ±¹Ú\nD3«{Qs\'T°Á\\ÕaÌOQšXÜ–äš‡µ+“b­Ùì)·Ê¥s–§ ù3H}\nWÌze£àÿ\0*õ·9^Â¥±Qç§jqØ–>ãp\rÜÕvp8nÂ¥‘¾|c“Pù#ëB¬Dp\"¹Ÿ]˜l¥|íùO>Õ½+ù£üˆ+Ôß_­¡?*©fÇ®:TMÛViJråG–Ld{”ù‰…éKÆ®pHn8ê+Ğ“C¶6ŠßÅ):{*d¾µ`Ÿö«e˜SJÍrÊ*=npH¨NÒ?6HïMœ……@lÜOjí$ğ¤JÆÿ\00c’}ë•ÔôÉlØ\\zâº)â©TÑ3†¾µ-d´\'‡å	ÀÈ#”Éˆî±ÿ\0M‚]Ø\\Ø¨gl¾Ğy_QŞ¢KS(ì, räÙãéVKŒñšdC=9ÍHé–Çg ĞìP‡ï ZfX¶	Æ:S¹$Î{ĞIã ‘è:Ò¸\\êì-Dq¬kLàV²FNâ‹ÁàšÔÒ4+‹Öj‘Ôú×egát€$Šç9é\\ÒÂÊZÉŸGWCî£Ë5HO–Tñ[Vºİy•×x‹ÃVí`â5\nTg#¯Æ[€±Jœ\\S‰ãâñ0¯¬ME;/B¿™§©ş,çŒTJŒNüıŞI=êMİ3Â\0îjÎÄ‚pç!½=ÿ\0_Éd%~îx©\n¡21ÚƒëŒÒ`f]‡•[#çµy\'ˆ!:_ˆ|Ä$+¶Â½†à¹¸æ¼ÿ\0Å:C]Á$£q’>@¡.I¦RÔ¿¤İı¢Ş9Iê+pååPHÚOZó¯j$6îsƒùWy¡¢OÊ+z±ÖèÒ.åY³ó‚?*ÑÒ%Ø«ÔúUâWS·ƒÅKûeP£=…D;Ğí ”´@ÕØbw¬›Ş‹Î+nÛå4IX±±â”@sVÔdšr«£õ–£*›qœÒ\r>yƒ,kQ>QQÌ‡£šÅ£ŸIB2„ô¬É¬.#\'k±“]+9ä\n©2eHÏZw:\"sK¸HÜµ4W·@ÛZ2@‚03RGjŠF\0Å4ÍÒEhïç_—Ë\'ÔÔæíÉ!Ïz±ö~ã$q€:\n¥\"¹bW7,GÜ4ä¸$”æ®ù@ÅMºĞS!¸¤gÂ:FMÚ,F6ÊµÅ¢ÂÓEš+rhdsÀÊû[d|†¥2ÿ\0Ï3Wd¶ÁájTƒó$78Ø ÷ã1Uİfs×¤ğäğ)†.æÆœLw¶›ıa¡,Ûçc[>zR)\rÉÒÁU†+ZÒ ¸ã‘PÆ9É«ñ£&‹˜T––,¢†¨ŞÙCÛÍ=<T¸ÎI5/¹Év™$j`Uva¿i¤Ê¡·TßhäéR™OR¸„’ô¤¹uŠ2}ªvç¥Q¾bWhâÄdÎæIjí°<g\0UDMó°^Üf­¬A\0çëZt$ŠSºU£u\"ìE>FÄªGAU&˜³^Ù¤(^ÜùáxÉÉ5—¤ÂòÎ÷t”ÜU‹¢o.RÎ6‘‚çÓ5é\ZW†l¬ìmá`ÇO^µ~Ã6¡^eÏ#ÏE´¦%EYk~\\S¤Œ‰¥ätà÷¯R\Z]–ZM€çå5^ÙJªã\r’}}«XÑë9¦Ş¨óaåmÛFÇ+‘ñ=˜\rÀÉÏáÖ½~÷Áèc*B7Ø?¥y—‰­%´Fá·§ò¬cFT¦™´±t«Á¨³‹	äÆ©úUTùÜÈHãÖ§™ñÕo™úTq\r„®5é-ug„Õ‰†å\0’=!ùy#¹ïN\\« 2M5¤,©ä\Z7oÌ8É<{Ó†U¹ÎZ@Hè:wö§9\\ğøĞÓjmtÈÆü <Y7^%vgŠ,/¡ö®nÿ\0TöY6pxÇòªğ±Ù¹ÏÏéRê6dõwf¥ö­srİÆ1Šäì¥?o’)	b@\"ºpz\0Iê+–Õ#k}Ug\0áˆ1Ò²OŞ*Úho™ˆáyÇZ’&_3sŸ”÷ªVòy˜ pzæ¯F=½©µ¨‰WWiñïN*NOLÒ+à\01ÆïZI3ÔœzŠL\n—Bí#½fy+$®®>VRõ­‰UF0íYW¡–@W‚?ZÍ«è<—S‚MÄ2¦PÙ=«´Ón„Ö|¶î3‘Lñ¶†÷šrê¨\rùÈëõ®_Ãº‹dÁ#AïŞº)K½QwÖçlP2’8Æ)a}†7jm³+&x©š ÊÖ¥hÍQ½¥]o½Çº¸\nšáì%òåk¤¶˜6Ì÷«–¤ê…–3V pà\nÆKÍÊA«ğÊiÈ¬ZîRÔÑÆƒ´Ôi6ãœñN2n\nÍ–‘E×ƒõªnJ’\ri¼Gn@¬ë„;òi£XÈ‰£àc¥\"ç<Ò‰00y©‘CŠÑÂdĞª‘ƒO0¢„‹«\n09«Vb”µĞ†8ÎãŞ¬ÇsOˆ.3S``œÕèa:Œj.4ón§šE]Ï×\"Áº\Z«#ßB?$+[c¾jpÉŒæšÎ1Ö¥Ø\\Ò)¼x>Õ]×5tàœw¨Š*k6Í£+È!©K\n’f1f\0w5îjç ø—/Ó¯¨àqPD„:ŒqW\0¡˜JWàĞÒ|Â›œQõ©l…‹1\rj¤ËG^Õ9ÁÕi[zázô‘[I6©ÏZ¡s)efmcÕI@fØ:w5}HehËF£håºš•¤Ìd*9xlQ¼¼gÓ¥S$vÅŒüÕŸrû-”à°äšYä2H_$â¹íZ[)CcvQêio lf®½ö-z€4KZô¥×.wÛH®Àá”íéŒ×„XJóêö!\')c×\'5ì±H’KÌcicÛ×dÛ„FNnZ\Z‘ë\"Í×{í2nëïWÇˆ®CLìyØ\0t>µÎÿ\0Ë•Æ[¦}êc°ùŠå‡ËƒŠËÛHTux‰á*€«}«‡ñ„qİ¨¸Sç{VŒà¨ 9NWÕPÛ ä¦”ß´F”_$Ó<†T>q\\¡ˆ©0:¨9éZZşŸ%†±sñ…ØCz•˜\0Ú:œñD»©­Ksh `zf•7|Å±”¬3ŒqéBƒ¢«s1QI )q“Ô’=)Xr¸ÜF:æ“ ò\r=ù­Í\\ˆMÅáŒT#\0·Px~½w’7‚°3-F¼nSïYÚí¹k`àğ\r_…‹7<àÒ_Æ­nàœñÆ*eÜHÎÒ˜4ï~µ¥\\m÷ùkKO³ÊÑ0À=>•½|¼¼:\Z¶Ğ\\˜;x§RGÙYe;ÇİÏ>ô]ËòåÇiIwÁê}*@B0„x—v™ÜOŞíZ¨§Ë‰õ\'Ş«İFd.IéÅ. ŠO\ZÍda˜µäÚş™.ªâSä–àû×­\"Ü~e9ÅRÔt˜õ[y-\\‘qĞÒMÂ\\È¤ú©Gs\Z<Ÿ½Ítñ€ã+Šó3ø\\šÎ`B«`{Œõ¯FÒîÒXAİ+¦iJ<Ñ4‹èiB §¡­KY|±´}+8( 0ü9«qHQFFsY\' Ù·­^YB¨ÏZËOİƒŸÆ¬£ä\n–TMX±ÏjŸv8ªóç\"§3lw©hÑ2ÒÈi’ÄŒR#©c‘]©Xf\\öû@Å1$ ñÒµ¥‡Ì8ÇZK-‹•ªRî	Øb\\*õ©şÒ„{Vl>şÅ*¤‡Š´“&h¨úgï¶G½Ò²„N¤†ïOkfP0MP¹¿OZbß c“Ö¨ùDié\0a’8¦4ËãRN€Po²ztª[eúU“l»H&¦DÜF¼à‘P­ÛÊ¦ißd.yÎ*Ä6‹ qKAİ•—{¶OJµ_0cÖ¬­º¥?`Cõ¨l›‰Âò)ËÓ&šGÌ>”¥¸©¸„vÃb«¿ÌÜS¥WÜÄ\rNål<±éÛ5±ä(yÎíµ6ç¥RD¶E#Üt¦±šlŒ½#€ª£?Z¡æÌ»\n*•Ô»ÑÁÆjİÌª§ƒÀê=kæB®]ÛæÉ\"ººhp?‹­y÷ˆ¡¼º¼ó%¹\r¾•Ü y§k‡\\¤u}j´ÖKqjÂDœó‘ş}«?oì§±èĞËİZnOCÏ4(e›Ä6‘.Fù”Ÿ`+Ùa‡aL\0•ıI¯9³ÓŞÓÅöªª~ñÛíÅzgñº©ùWmZŠqMUJN•G\r}´JB’\\wæ¥ò€y3Âğ\0šWÈ6Ãœ‘Ø\nzHkdc\':V‘LBÆÄŸ^•SFÔ>Ç|[ç¶qRêgB3YÖ1¸3`ç½T%Êî&®düFòæ¸‚ù	>[úúŠáÇÎ8÷®çÆÖìÚS9pe ãÜWoÁªå­‰²Xİ½)İOR\0<\nj·ƒ’EK»8Ç|•c»*NHÅò¡Ta½}iáK/ÍÁÍƒ\' sG¨Îı[%‡Vè=Í_€m@Àd¯QêjŒjŒŸz¸’ÜzÖ;—‘¶¦TsÜ\nYA2Ãñªà–#oN¥zÔâ0\'ÛÒ¥ˆç®dj%œpqZ¶òîÆ=ª¾¯j\Z ~*6}ØãsN6jÀk®İàŒåxsëS`œ\r§€¾•9lúç¥J@+€rh\0ÎÓ€wÈ¥•FÕ“K±UÆÿ\0XS˜‡ÉüA¤ÀÈ™\\Ë0:b®iöÍu2yk§‘Iq	 ¶8«OC»·Ó­&A—Ïİ½8&›afİ¢WÇT·mF\0Vá2B¨ê0ÀWøoU{gûÀÚéÀ×¹ëş!ZR,,~CÜWx»M›JÔRöõmÎFzık\nuã\Z®“ØîX:ª—´hô›k‘°œzÒ…wF¹lŸå\\†õ„Ô-Â³áÇcŞ»KH<V•)¸³îkÛÉƒ°óŠ¾¸â²rœóWbrJóÅgaìh+0`®Gò¶HªJÊ\\Ú¯+‚¡Trirgl!Á¤·-Œ÷¡š™ ©ØÒ,°­š‘—rÔQ\rÏíV(&L„[«EFÖÀ:UœóHA4År©¶\\gĞŒò3VÕ	4Š¶{VˆM•Ü8#¦¥·=]L±<qN*(µƒšÅ8âÛœ\nzÆÕgç£§Nhbæ+:…Bã$RIcŠrAåšEs+j*Ç4².XzTƒjcÚ¥™§v1ÛëLbÀ§>¢fÚI©,I*q×L¯´rMYi0Ø# 0$ÓH.A6İø‰¦1	ãÒ’cóWwÏ^ÔÄFâG5„¹<ğ*9fÚH*Åâª6ŞÂ“&ä7·B2ÍœöÅ_ğÎ•o¨ŸíA€€6Øã?ÆßÔ{V4BV’@É™­«exRÁÛ\ZØ®Š-Gs9¾ˆìn´+	‰T7°ÁÉí\\­áf¶C:9q@üjk}bh$šíŸ;²£5½a«Åqh°\\çHOQÆ=M*¸xÔM£ZÊÔ^ú[ih_ZŠGÈ`ÇËùWO*í’áÊ‘ÎÓ¥\Z†œl|J­\Züó(Å™£\'œïè;w¬)¦£ÊÍq•cV|è~{\Z•àÔR,kó1ù©7Û÷qi›ı}3VqZŒª¸vwµ>ÀìC»úTWË¾àaFT©lÔ´$`d÷¡lo‹ãóôk²¬G–›ğ9éŠó$\063×-^¯®ÂE¼QÁhœ~:W•ZÇæi±J>ö3ÓßÒª–ìÒ;•àwá•äü\n\"YqíS(Ä2jÔw0‰9ô¿…1O=úŠ“ƒÇ\0zóQ„ÆN7~\\ş)ÍÃV²‹ŒrÃ¶jŒ8s’y5fßYö¬™m&*ùäóõ«ªv`sØv¬ø\\¸·@*ÊnŞ/q@Ée,F}+›“ıø|¤óÅu\0qÁÊ²µ«]ÑAÓ’jSå‹J<¥aÔõ©†ç#-Ôg¥cé×ªĞ€qòşµ¨ æ’N{\Z¶€”¶0)úšr»¿OaHŞ1’F~•jÂÂK¹vGĞ÷õª„¶ÊòFò’ª¹ã·zÊÔ­g³…dl¬yù¯LÓôxmP3¨gîMaø½,şÄèH9àw¢²ä‘¦oÚ&‘Á 1g zW-¬ÜÙêv2Z–HÁä˜ª:¾¯4:‚åÚzb±nåc1™&O¼{f¹éày½öÏ_™¨û‘FŸzúeñ`H\\ôükÓ´\rao]H şÕæ—6kdu<Óô]N]>ëˆóšô¹T—+ÜñÕMn{x› ÏsŠÒ´6=+Óu4¹…0Aük¢³›9ë\\6v4ó:°ÄŸÖ¬ÄÛ>íQ·lÁ?­OØ‡9Éõ©\ZeĞå¤Í^AÍgBØ5*;dSK”´Í(ˆ)åzÕeãœÔÑ°Æ:šVÃîÍ*¾[^V!:ÒÄHeÏz¸«•¹yŒÓ‹n4İ¼T¨½êùL›[{\nqŒäæÃ\ZW$\nd6î\"…šBjDLi®¸Î)4$õ!-Í4¿­=‡š‰¶\rC4V$WRœÔrH¡HÅFÀíQ³nV\\riX,†&\\zzS]ÀcéObQqMbŒxê&Š¹ÌZ@:TLNÏ9¡É#$r\rS‘İ†zsE‰a<Ÿ1QÖ©Í2Æ‡¹5#å~næ².n„m´hÅº¹;\nÍ‚)o§UlùİñB£ß´œF3[ñÂ!hUáWni¥Ô™JÛÂ¡\"€¹À÷İæ7\\4ªÙL(œÔ1’äù`§ğÍ$\"IDG˜!˜ç©¨ã½$4­òˆÆAñĞSÎd“ÈˆîŒòòç¸ªs‘!hÕq\\–õªŒš«q|5`šFÙ\"DrŞäÔcQJ±>İê­¤Nö‡iyïéVÂ·˜Şã9¢M6=ÂÌ^Uyõ”¼¬LÌŸ7®)ÃF,zRI6•†@äÔ±³©7Ùè@­M¢qÈ+4üòƒÆ´¢\\F=xüèP/ö}ÁíPŒ!^_j‚;u “½zV°ìt«°s4oøÈ¯7ÎÔµGÆàœş@USİ—‘äR®æ’3ÖŸ¨Ç…W\0ã¥G1˜ıkTSZÉH\0õ£‰À>õ!#ŒL ©%€ç¥!š>8Çn%pXî5IX*ŒÕ»`d“Y2‰ƒåã>õfoõ™ëÛĞUU;ˆSõâ¬Œ\0}áHE¨İV0éĞö4³¢Ë\\$t¦¨ÀÜ8=Æz\nj¹åÇê;ÒzÏ\Z×QÀáçÑÛ²ù9\"©j‚e/TäñŞ¥ÓÌ;ô­iGŸ@z:}‹ŞÉ¶1Çzì4ı>=><3Z“H²ÊÕNâ2Æ²µÍwËv†.Tdw5­Z‘¢¬‡F”«Ï–$ÚÆ¾-3œ¢¸kÉåÜÊÇÛ54ò4³c»=¥P’@ †û uí^=Zò›>›\rƒ§F>gâM-VF›¯ÎÀ‹$EQŞº¯ê‘>è#Ãà\\Šn,{ã¨í^¶Ÿ’Ò<LËÙºàßİì$g+È÷¬«»RäÈƒâ·¶y’©‰IµbğíÌ“*2B§€:Vµ§jÙËBŒê;EŞƒ­Ég\"ÆÍ…-Ş½GL¿Y6a†XdjòM_N—M¼Ái<ZŞğî²ÈÊ®Ü¯÷¤œkG™\Z¸8>YÉm Ø	nM^.Y†:W5auæÛ¡<WAhCD¤‘šÂQ³&æŒvò8*MóqÖ¡IqíOƒ‘SÔ´Ë‘ÈKŒçv>	=Mg¤™#Š¹€¹cÍ;Ç²‚ÙïR¬cƒH¤db§B\0¡!7¡$cjÂ¨Ûš¬\nŒSy‹ŒU™Êìv“‚y±Ï¢@ÇX°\0ÇõéNó8À¨Õ³ŸJ’#ln5^Qš²@ÜI¨%ëŠ‹r¾ò‡Ö‘Ü <óR‚¹9ì*³áÉ÷¥Ô´<•}¢ eÙ)Á¤–@dTSNÔã=¨°˜\\JêEgË7ÌIè´·W–=:\nÌ½¹DCÏàiZÂ¸]_‘ Ö46æúók9ÉcéQ5Ã\\ÌUõ=­”–Y•rcÁã94ZÂr±-¬	šmÀÁÆ1ïSÍ*ùy8¨¡2âFÚaO“bŸ—ß\'©¤@×bÈw¨Q‘€:Ñå¨‹yhsÓ©§«HS(ƒ \rÌislc#ÔXZˆFøŠ§î¢I¬«§,FÅÛn§®{ş£rÙºr‘’1\Zõj¢ò<·J€½ã¥-ÀÑ·÷6ñãß>™§0fVF×ÒŸîÃìã<ô¦áäÛÓ$äãÒ¨+±:ôÏZ¯yû¸ßg\\U¶Á|ôÇ5FşP±maÛ©6õ£\'ëÅlÆª 1=şíe@„ºíÜxÍhFNy\'øS§ÿ\0 Û’8o-º{Šó\"K^¨¬Q…úŸóüëÑõù>Í¤\\KŒ7”T{“À¯7µßÜîäšªKVi‹,4l‡¦:õŸcÊ?UãšÖ\\äxÀªwÑ~ôH?àU¯Rºd¶Ñèz\n\\Å›·ˆÂœ±=©|d\Z	:›y„¨¥Tæµ!ÿ\0Tp\0üëğÛ\\ië¼ôÉæºØR\0zÔU+±šw-@NM_ƒŞÿ\0ÃÏÔÖm³\0…$ñõ«ÅşE÷Ígq’I)v|¤rG­M\0ß1Ã–ªêáŸ¼¾ıéêKHNÛ×=ÍLË*˜ê)Ú}¸Šı È$Tjwã8\rüªÒ„/sĞÖ´eÊî\'©¿­êŸf±Xã|4œpkŠšåšF|å}IéV5XoHó¤ŒJ8ÏqY‚_İ±näû\nóñR“§Ğe°§\Zzn>êô[Å½#–oZãõİ}›ä‡[qÁ£[×I|ÂHÍsJ¯¸¶2sô×„Áı¹£Ÿ˜rû”ÆÊ3—ÜIÏzP—$t=NjI_ø uæ•o\rÜ8¯Q+lx|Í½N·CÒ )–ÏË“í]\"Æ±;+ğKW#áİSÊ_\"Lrx5é:.’u-’:“ï^V#\rV¬õØúŒ%Z0£ÌÄ“YŒˆ!g—¨Tyt±O¥ß=¼ÊÈñ¾\n:WØ–Ú%¶¢¨Æ9ï^9ñ‹Â–köšÿ\0¤™¶ÿ\0wŞŠkêí.‡“ŠÅB¼ïaxOYÂ±³r9®şÂàdrOjğQk+œ#•ìÔ#¹†)7ñ•İ8¦¹‘Ê™Û€6‚iñÉÈª¤s—Ó4G#¹¬2Ò³s“S«,f ‰Àm¤T¬¸úQq¦hÛ¿˜µ>ğ£µ…6Ş¬³àv e¼ägÚ¡ótëšG.1My\0±¢ö$™eÏŞ4ñ ^ë:Iqõ=)Èä€I \r7µ=I*MTÁ`j7x6#í©Èå€Å:Ydı*26%+ŠÂK¸ò§2ù€g­)”´dõNVÀ‘In6Nò”$·AÒª4€.HëÍ2îbvƒÚ«Mr±cLI•µ	À Årúé¸ºX-²Ä‘œUVüÎëm\0-!ô«šV–°Ä®À»’;Ğ»±=\nÖš|¾Qˆüª[×“Zö¶É@Ç#šºèŠˆÉzš¡R@ç§57¹e¾w`i²]¢4ŞØå¥<ùl#,4é74xlDƒƒô¤ˆ˜ù’döEô #>R@9f¥gˆ»ƒ‚ÍÒ¡›knûCï8+±Oz\0dÎ¤î{ƒÌ‡ ¨l\"/pd-ÆM6äŸ-?º«Ú¯ÛÀ\nTqùšJ¹(FìùSğY—î…Æ~^´ÀBœ6G8¤ÜÅËBäphaÜóT5)\0súV€r~2Ã ¬›·ó\'Q­ &µVUUÆ9ã>•pÆ±…#æ8=*ºdª–˜íS»89$P?ã9vhê™ùŒ¨£?‰?Ê¸kq¶İX\\äş5Òøş|%°ãÌvoĞêk›PT £µ¤´¹¤v,ÇÂäœ}iÓ ‘vô¨×.2{rjXîÆî1Ú´jå]aY$h‰ú{ÓœcÓğ«÷¶cÊŞœ2òEPRJ’:Š”ÄÑWÂR´l!9\0œW¢ÛÆ¢=ÄçĞWœhèb`Àá÷`×2Fˆz¢GÌ®)Ã—Rıºf<öÏ~Õ9ÆìÕnXQÂ÷©!›‡­`AeT„İØ:`\0AÀÇ­1Kœx§¡àpp9?Z¢dÑ­ õõ5ĞèÚa¹q$ ‘šÆÓaiçXÀã5èV%­¨QØd×\\`¡fDŸDVÔá¶Opê¸Û€\rx‡‰î\'§{e\"&8Æ{W¡x“V7Ÿ\"CŒm\nŞ¹+«u¹’®OLû×“Vºö¼ÖĞ÷ğ89*NMêÏ0rÌ7wÏ~ÔÈˆ^	À$õ³­i¦ÅŞ@¸BqX¥ÿ\0y:ãÖ½º5HŞ;&&”©TqóÁõ8ÂÚ‘†çÉn‰¹Üwù\n–Ú–Qå©<ãÖµÛS«½vVìóªÄ¥˜sú×ºø\"ò(4Ô·‡˜£“^s¦iQ[,N1æù‡q[i$Ğ11’\0«šXø;Àö©åÒöZ½ÎóYÕÄ‰‹wù‡Aık“¾OíHßÏù‰\0÷¨­ne|™8Ïj–Üœcƒ\\U=ãÍ•7ÊÏ\nñ‡äÑµ7–1˜]¸`8ÏZ½àıwÈ•m¥8Rr9¯OÖô}rÍ uç„œcŞ¼c^Ğo<9Ñ¼¢ÇËp1‘ŸÒ¶ÃW·îæ-õG¸Øß¬Š¡Xy­˜¤V`s^3áOa„S¹é–wË,jÊÀŠÚ¥>]‡{,N7sŠ´¬vşu‡×˜Ëƒ€+A.L€Â±qì\\;³Ú§ó°\n¢\'Ã`T¾`Ç&‘IÜ³æ‚¹Ï_zYdUMıN*˜e-Óµ$³dª­Çòß3SË£i¨$*A¨ç8¢Ä¶j,şZŒhû^şƒŸjÌ$•,W§¦ŠF’Ì	ö¦I0ÎIü*¯Ú\'‘PMt¡wj,$ï\0qQoTMÍ÷ˆÍPí[©\0Õ9¯Â\'Ìİª’\'šå›»Ğ±’y¬;ıFIWìñ³v­iöWzä\\yÁlr+V_G¦N)|§š©.U©\rÙ™z~–¶ÄI\"î˜òÇĞV²§=³Kœ),¼v¦ïÜFÑ‘1Y^â%pXqÓ8¤Tù€vÎG v§3Y‚:¹¤V8;K§Ú€¶U%Wj¯İ\'Ş¢‘Óƒ)/ü;WÖ¦r¬I•òO8rœ¿—QÁš\rq4ˆ†¸Ç~*„¯\Z‘*@ÏŞ=MM$¼À\\ÈÊy=…WÉ’MÃœQ«¥ºŒ08VàP¡TsO¨*£™ü£Œ8è*ñÓ.‘bp8¦Õ„WeÚ­’GE\\Ò`‹òà÷§Ê®cd~éìiÒ‡Ú\0Âàâ¤dD¿Î³p$¸bµ[–P3Ç8ëUìÃÌNsŞ„Kİ¥[#•,deqÈÕM¤ñßÖ‘† dñRØ¥ó¼Gm\0÷Pî?V&³jü£’FI©õ™Vê3õHB ?îıj´*J9Ëçì+¢’÷MVÄè¸\nOj°¨£?\Z‰=\0¦PvàóVìŒ÷çéX“ÇäÊA$#ŠÙdïùÕi£Æ—${T½¸íHy£yTCó[ee¶˜yÁ”7¨­O„uer/è+½¼ğõ¥ÜeŒjÇo~”ñetiDy&9¶œBœ<šÑ€“óõ\r÷‡çÓ¤ )0¯İõ¨¡¢*§€=ë©ÌíĞÔçêjX¸;›×8õ¨RDòò¸É?{Ö¬@»˜ğI\'½]8ŞV&çIá›-Ïç2ã½ixUû\r°Şı½ªÎ‘‡O_\\f¸]ÍAà•Mê¼‹•8\nÚ®»#1æ·Œ8QT¯nâ¶RÒ0UOÔúT¹\nOÍÑq\\Ÿˆï°ŞIù•O8îkË¥KÚO”újõU\Zw2µ[Öº¹13\rƒ\'Í`ÌYdpùÕÆRå?3ıîyUÂ°\\t¯¡¥MB*(ù\ZÕ]Y¹H–ÌÁy¾=+®ğşŸ%´~{¨mÃ¤p+GX>Ù>SÏµz$[GLjåÆÖp\\«©éå˜hÍó²ÂÆ¢2ªpøù˜•¡¥éï2¨•^ÚÕî\\F¹÷Åz¦Çmn­°Ç&¹°ô÷äzXÜR¡-Ê²èP.˜*ïQ×ëŒ7\";–ƒuº×m­ê(ÊFşÕÄİÄ$ÜøÃÔUM®cæÜœŸ3\'+‚<¿LYZ¾k­CöyÔ\0xö<Wfòäà“Á&®€²©+ÔŒ\n‰BàñƒnôK6×sEŸ“ÔSôO\\Y‚àœ)îzW²ÍoèRUQŸ•zt®W]ğ\r…ô-,\n\"Û ‚z\nÚ–&P\\³Õ£-i^#¶¸ŒínúÖÄ\Z’™ÖÍy_ü\"º®™.Î3ÁdUëwÖí±˜Üíº\ZŞôŞ±e(Üõ„½F8Ü*eŸ<—â¼Î=OWCóÛJ?ºjìZÆ©¿d˜ätÖ§—³FwÒ\\ñÃqQ­àÙœ×\"—š«D?Ñ%üGJ³\"`Ú²÷çŠ›X9YÑı´›ïCŞ¯+˜ûˆ%,H	ÿ\0kùQ‹âxf=)éÜ9Óı±‡çQÉw`0dûÖğÖ¬Tî½ÁÇaÀ¦¯„¯]ÃI¨¹ƒ¥+Ç¸rÛ©®uH‡AŸsTæÕ˜‘ÄœqV-<3klJL’y7Tº²ÒmÌ¤\"¸(îMKk¡%6yÂy“² ık>¦»¸c‡Ô×;q¯\\^ß¬¬ÄÇ»„Íuús‹˜–D9Ïj*óÓJG¡¥	¶ÙØøJd¶+\0P5Ú\\ÙÃsnU+Î,ä{{\"õÈ¯DÓ.…Í¢±l¶9úÖÉª´îg˜áı›S[UÔf	^&å$Ô;ŒjÊ‹Şù®‹ÄVª‡z(@N]ë˜Â¦Ğs!\rúW*ìÎ©32¹¿B)³–XÑ™‚.ìàuÁ¥ıéŒˆğpjUlğelcé@WÎbMÇ?y‡]Á1©’BÎAùV¦™Ûiójäa­S•Œ(Ï«Ï©¢à$®‚/,œœTú[[µĞàc“\\ş£|¶öìû†ğ3Šn’D3HÇ.r1Çp”c¬Ì6ÛÑe%©JÚTU¶H™`	è\ry¤wˆÂ#àwêk@k—K4NÌX¨ş|VÊ­)u5U4ıÖvé6ó# 3“Xw^¸]í¤œjK/3©2§WÀíšİVµ™NÙãNTSÕU0Õ©?y\rõ¬Öññ‘Û8ªÖÊV>8bk³ÖL7Š°FA$õM|3*C¹[æ8®wŒ¯ÜçÔ0ÆåäSÙ¶¦â@=kF}*ê!‚„àõõ¬}H5¦Ÿ<®¥BÄüŸ\\\ZÎ[·<—Í7W/Ô™æw|ÿ\0wÿ\0¯WÛ9U\npJÏÒA6¢r1¼\0£Ğc¿½hŒ‘»Òº¢¬‘¡*}*e8mC\Z“‚:Ô²tàö hF §?@dç8©¦#Ë\0jÈŒuíBC5ü+tmåp¡ãšô­/Y}Ê²–¼‹D%Ë‚kº²íVÎ+¢Uo¹Ï(¦ÏD;[û6QÎ¸Â¼ãUÒMœò|¤D[å5µkzñ‡àõúV¬×V×öDL ±ùPf¹*CíDQÅÂNÕ\\ü¢´¬_÷ª½³ÔÕI­¾Ï+&r3ÔŠ³hUfAsÖ®ƒ÷†Îõî:k°ìœWœŞÎ²\\7RGzí/eÙ¢ËÈÜS8÷¯;’Be\'ÔñŠóñÎõl{y<RNDz„«©“9Ø3Šó»›³=Ô‡;”ÜŠêüCpÑ[ìÈùâ¸‚ûˆ\0íÉÉÅtåô´ædfÕ®ÔùŸÇßĞSLCfæ8ì>´¬1,FOšVÆWº§#êf/İ0\'’\0é]Fƒ¨ÜMr‘(f¾:\näÓs`Ù&»Ÿ\rØHcd…gYÁFó=½Tu=ÃÔ¼3`®‰) ‘]ıÚÙÛäu®MÕä±p•Ç\"¬]ê_³±Ü#=q\\Óšå÷M1´*¹óKb¾¡?Ú\'fw°ªßz23À<šy\\Ãè)Hû©Æ=Ms,©=´w“Á Y$²M¯œÖ´…HärÔÙ`3?9ûP#+pªCğJ[?ZÍ=´ÃiùGJ¸—)1*OÍhÑì¦³Işl\r§½VH¼‚HE#<\n¾™UÙíK\"#Sà\Z°®:Õ ‚º€~•­\r´\n@©Œ±œœdšÚòHW\róUò¦Rfèµ‰¹TPÑ¯ ôª1j#œMYIÄœúRä±hs*ü ÅU!Û\0pI$‡Ìy­5˜ƒ×Š,Z\"*½O<t¨]ñØ\n[‰â‡,[Zæ5¥¤ÑÏúPµƒes]‡M‰‰p_(ë^_ªjSjs™fr@Ï”ÛÛ÷¼¸y$l±99ªª7dŒÕÙN—.§,¥­‡Ã…R8-MvşŸj¯¸ÂÆ¡xàâ¶¼?|–Ú¤a·÷B™5uéóÓhéÁTäªHÜŒ‚ºß\rŞHçÊ\\êkˆ“%Bí5±£°ûrn”¢g\\)ZN,÷qU(³°Ö YìÙYwqÈ®c 0™~•è3 ’Ì€xÆkÏï6‹‚$s´0*ª+Lùˆö ]¡˜;ààzÓ•äQŒˆÔ}iÈ¨h#R6’}*¹)iï d15\nòØ8#ï\ZÉÔ5£V²@9&§¹¸óm¤rH¡Åq:ş¢RÓ¿\rïŠ¨C™…Ò3nµE½Õv>H m®ËNÔm@âA€=zW˜rß2õõ£o;El`¯8µÕ<4g41Ò£²=R;¨İ\";˜°§¿ó©Ä«€U±×ôâ¼ÎÛVšæ7`{ŸÃ¡iâIàHcÎåB\'Óÿ\0×\\SËæ¾z”³jrø•@Yç‚·\rå3c®k™‡Ä–G\nK.ïİ©ïZÑ“ «ajôôgr«J¢ºf–¬ñêcæ&1ØõÜ[ø¢Ğ¡ŞHÚ=+Ê¡b÷¬ªÀ÷­_8\"’Ä’k¥bÒŠRG-L\r:ÎìôØõ{Y¦Û¸`\0y÷®[â>¡§ÛøRæİJı¢pbŒ¹=JæVâ@Å÷‘´Ÿzâu}RM[Ä²¦òöÖ£İ±É­#RGdqÖË£IsÜ‚Ş†İ#À03R®ÓÒœy<R÷XÖ—8XøÁÁàŠ{\0E$c\nr*Nƒñ¤ô¹ZCò˜ (èB’9§0ŞäsĞÒ]Ù<Ğ\ZKºù¹ük¾°;ĞpqÅyÕˆa¨ ‚9®úÅò„Ğ~µ3zKsIrH<í5*HyaœôQéïQG’ã ëCÊTœ£²RhEMVåŒ0¤)»<»UM>÷uÎÙ8e8­\\6îÀÉâ³æ±ua*Œ;ãÚ´£;KQt;i§WÒrGJóû©\n;0õë]^—r—6ŒÕNyï\\•Â“;†\0‘ø~ÉªÜör©Z-¯‰î<`ŞŸÖ°v\"ƒÈ#Ç­kx-³äœŒt5‚¹yìkÑÂ/İ«va&ë2RÀ0ÚxqÅ9@\n€ò[“šlq³#o={úÒQHë¨âF¦“möË¤@¹ÜØé1Cq¢ã“\\W…¢\"äÉÎuëÍvöá›Î{œ×—›sQGÒåtTióíS{$\\å¹jï´İ\"5°	\';†Ms~±İou\'\'9®ÖæEµµ\' Æk\Zjõ93LCæTâq\ZÅºÚ^ºÅ÷qÛ¥g¬¹ cî>¿Zµ{pÒİHq‘š¦ÌíÑ‡JçHòÉ°r=ÛëJ«·\'ñ9íLI1÷ùÉ÷¥PÎ¤ãëì*¬Rmb¯9ªóZ“óÄ@nµi€Àã¸ÂŸ\Zü€ã;º})!”\"¹’)UfÉÉëWE’EØF3)óBŒ tâ³\r¬1hÙ­;ßp5’Q´†>¥\'—æTã#¥QKÈÎøÇó©â—|Ç:b˜‰Ğn8uï×Ú‹µ÷+piR|R¹À£ÌFp1W¥¦Û½ìœ“´q‘SkZt–6ŞlL[ıšÓğü>\\w¯z‹ÄÒH¶çg@¼ÓÄ®H]\Zaï:ª\'ŸÜ¤×$ù’ƒĞ\Zç¼Cj°XŒÊÜjéÔîsÔ€2N:ŸJÅ×İ’İ$E;ùŞHé^e:³uÏ£«F¦ì;hÀ9=zjÈÀ1ê:Ò4»A,3ósQ¡*xb\nú(ê“šÔ‘v¨b œ0&®ZÎÑêk$(¨ÁZ©\"¾ÖÆĞ’Ù@ºîXœ>•OT]7i#Õ ğ’Lädã¹­=:@·•\0Aæ²´Éb[Ú2\0ÆâsšĞ°wà</$¯A^-ãYŸXäOJI?ĞƒH1òò+€¾p.$ —ê}+RçYÁäÃ¸ÆóXPy\ZYØà…=MtÖÖW>Y¤¤Ä”´€ºå¶÷=*º[»åc±{zš²åÌäˆ—£©öªw×;c8ã”zVI6^·v‰n@ dt«ÎµVó×Jª‘É÷®«Pv™üµù™ˆÀõ•â{í\"´‚>võëÅu¦©$º²©Ñuo.ˆçbŒƒ“ÕwË@è§$œõÅSŒıXÀ˜î÷çÿ\0×]G5Åÿ\0WmÈİ‘ìE:\"[jmêNx¦î1D¼òÀŸ‰¦ä³6:w\\–Éwü*Ay$h¾[²•çïw¨òpı\0ü*\'RA\0Œc\'ÌšwLÓ°×. rN[=I5Ğ[øšØ¡YT—éšã `=¸Ç­}şPçéXO\rN{£¶–aV‰œŞ%†ÓJ¹—y-ÎĞEsú4DZùòŞNÛÏãX7Êo/,¬P±Şw¾9ùGÿ\0ªº¸€Tt\0`Æ¥a\Z¦Û]Mjc\'^<²&#3Ÿç@ÎáÁ¤ÜI˜©dñÔuªè`J€tÏJ	ÛÏ\'Ö•FXdŸjcÕ!r&#qı((>OÊ€7O@@äqŞ˜ngØÚŠŒqµŞY®Ø†8®ÈŸíç½wÖ\\F¸õ©ÆOsR3¶<§¥U^UÏ@qR‹ì¤ŠŠcSß5ÄYA’ìØ;)Z@™»ŠHÉ\"<úÔR¹¹ş\")_P*İÛI«[»$‡%±Ò±–ğ·™çğr@lWK/HşíszôIöhÈ\\eùÇzÎ¢SÜìÂb\'ärºüŠû©Éü«#-·¶3ÿ\0Ö­}O‹x€é¸\nÇÉ‡jôpªĞ±9óTæ$fbvªàc<ÓPoÉÉüéò¨¤µ§¹ÇJéV8ã«=A³iĞ¸-×=ëz0Ä’£¯µNÃ@\0|¢¯ÂIW¶kÆøëê}…£IXï<5[@HëÅMâ¿\"¸Æ\Z³¢€¶1€1ÅaxÚd×n%ÛCå«Ë³lÂêÀú|Æ£=A<çŞü$˜õ™)\"I`‹jæ vAŒŒd±ô¨Áu%Fy¥ˆŸ0ÁiÑ®îš\0O0œ‡1à{¥H²*ÉÈjıig\0Æ2J­	ûƒµ\0\\Mœ»ä€8÷5‹k1o©,2¨=3šLîTÏ÷¨h\n³ZÄã£waUÍ‹Æw#Ÿj¾ytÏ­=¹=sI]l38Ï4,.GsŠµÔNÃ¦iÀ€yÙbE+…ƒZSzê#¹Ñnb6*»Ô\ZÂñE×™r±Fùç3YĞ³(P¬@Çc[ÚÀĞå£ã½i‹445ÂIS¨¤ÎEH÷¨­s~$œ<d\0wúÖÖ¨Ån)À®gQdFŞ3ŠòéE)&Ï£©\':~§<€àÀ=©»€\'ŒRÊŠ„FqQº)	$sù×ĞAésåjFÒh•nn×$T¶ª$ºùç±>µ`modâlÍæGÏñ-SÕ0…”ÑèÖVËmgO1bG +§ğÓÁæË¸mOZåƒwWhãğ­XdteEb#^E)Z£¹õ’©K”ô±§ÙŞ[\Z©ô5Éë‚Êå‰RF~Q]/‡˜‹\0ñ¸ÿ\0:§â°Ø%¹5Ñ^\n.èùz‘ä¨âr±Èyçä€:\nåõÍHD®«2Œœœd\0ı	ü+{P8¶,:ç­yÅù.îìIlj°´ÔçfD–‡Uá}çT¶›Wœ•µä‹ı£Î[éTõ,Ş\\=Ü~TØ€€\Zõï\nZ[ÿ\0Â½Ó£ò—c[®G®z×œx€\0ÓÀàNMsc¦áˆ¼O[-”jRtä>\Zt±1™×*rÙÇR½¼Ñãe`Íóş|×ai\Z5 ğ¿©æ£Ômâÿ\0„îcµkOş…_-KŞ‹8àáKïçhÀ:\Zk+ˆãÊíêÄÕ«ôU³@>?ö¨×äúøWl*)«UZNœ¬A´0#9ÆíÍBûÈcÏÖ¬´)’	5U¹v\'Ÿ–¬Å«	€K×µJûv1ÀÈ^\Z£`cP^’ºdŒ¦}¨{±áØ\rÍíÅû¯\0ùqg+§Ø2~µ Ä‰¢ÚP)cîkQÀ\0‘×Ö¹¥+Èé†ˆ`é‚;šš>¹¨P¤÷ÏZ²G÷jYh_»Ï\0Ô29Ç©[úT+ÊzæSœãÒ[§Õ\Z“´ó“üêxùëÍ;ÿÙ');
/*!40000 ALTER TABLE `file` ENABLE KEYS */;
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
  `amountinset1` int(11) DEFAULT NULL,
  `amountinset2` int(11) DEFAULT NULL,
  `amountinset3` int(11) DEFAULT NULL,
  `amountinset4` int(11) DEFAULT NULL,
  `amountinset5` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_equipment`)
) ENGINE=MyISAM AUTO_INCREMENT=42 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipment`
--

LOCK TABLES `equipment` WRITE;
/*!40000 ALTER TABLE `equipment` DISABLE KEYS */;
INSERT INTO `equipment` VALUES (1,'item',0,'Pingpongball','propro',0,0,0,0,0,0,0,0,0,0),(2,'set',0,'Pingpongset','best',27,4,29,0,0,2,3,1,0,0),(3,'set',0,'Tennisset','for 2',31,16,0,0,0,1,10,0,0,0),(4,'item',0,'Tennisracket','very nice :)',0,0,0,0,0,0,0,0,0,0),(5,'set',0,'Judoset','indoor use only',31,29,0,0,0,1,3,0,0,0),(6,'item',0,'Basketball','brown color',0,0,0,0,0,0,0,0,0,0),(7,'item',0,'Football','pro',0,0,0,0,0,0,0,0,0,0),(8,'item',0,'Pingpongracket','pro',0,0,0,0,0,0,0,0,0,0),(9,'item',0,'Tennisball','new',0,0,0,0,0,0,0,0,0,0),(10,'set',0,'sfsafd','New Set',29,1,9,16,1,1,4,1,3,4),(13,'set',0,'chdf','dfghdfgdfg',1,0,0,0,0,1,0,0,0,0),(14,'set',0,'dbdfb','dfbdfb',6,0,0,0,0,1,0,0,0,0),(15,'set',0,'xcvc','vdsav',1,0,0,0,0,1,0,0,0,0),(16,'item',0,'xvfaxcv','xcvzscxv',0,0,0,0,0,0,0,0,0,0),(17,'item',0,'dddd','sdfsdf',0,0,0,0,0,0,0,0,0,0),(18,'item',0,'rtyt','rtyry',0,0,0,0,0,0,0,0,0,0),(19,'item',0,'yrty','zxczc',0,0,0,0,0,0,0,0,0,0),(20,'item',0,'23423','234234',0,0,0,0,0,0,0,0,0,0),(21,'item',0,'www','wwwww',0,0,0,0,0,0,0,0,0,0),(22,'item',0,'Lollipop','Tasty',0,0,0,0,0,0,0,0,0,0),(23,'item',0,'Blah','hah',0,0,0,0,0,0,0,0,0,0),(24,'set',0,'Hehe','Haha',6,23,0,0,0,2,3,0,0,0),(25,'item',0,'Newforbooking','new!',0,0,0,0,0,0,0,0,0,0),(26,'set',0,'Newsetforbooking','Spanking new!',4,6,0,0,0,3,1,0,0,0),(27,'item',0,'NewTest','ddd',0,0,0,0,0,0,0,0,0,0),(28,'set',0,'NewTestSet','sss',4,0,0,0,0,4,0,0,0,0),(29,'item',0,'Newtest2','sss',0,0,0,0,0,0,0,0,0,0),(30,'set',0,'newsettest2','ddd',1,4,0,0,0,3,3,0,0,0),(31,'item',0,'newww','www',0,0,0,0,0,0,0,0,0,0),(32,'set',0,'ggg','ggggg',1,0,0,0,0,2,0,0,0,0),(33,'set',0,'sdfsd','sdfs',1,0,0,0,0,0,0,0,0,0),(34,'set',0,'luyo','',4,6,0,0,0,3,1,0,0,0),(35,'set',0,'dg','dfgd',1,0,4,0,0,1,0,1,0,0),(36,'set',0,'ghdg','fghfg',1,4,0,0,0,1,1,0,0,0),(37,'item',0,'444','444',0,0,0,0,0,0,0,0,0,0),(39,'item',0,'sdgsg','',0,0,0,0,0,0,0,0,0,0),(40,'set',0,'sdfs','',1,0,0,0,0,1,0,0,0,0),(41,'item',0,'Ferrari Sport Car','Brand New!',0,0,0,0,0,0,0,0,0,0);
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rooms`
--

LOCK TABLES `rooms` WRITE;
/*!40000 ALTER TABLE `rooms` DISABLE KEYS */;
INSERT INTO `rooms` VALUES (1,'Medium Room','good for medium stuff',100),(2,'Big Room','good for evertyhing',100),(3,'xcv','',0);
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
) ENGINE=InnoDB AUTO_INCREMENT=94 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `class_bookings`
--

LOCK TABLES `class_bookings` WRITE;
/*!40000 ALTER TABLE `class_bookings` DISABLE KEYS */;
INSERT INTO `class_bookings` VALUES (1,4,1,'2010-04-01'),(2,1,2,'2010-04-02'),(86,10,37,'2010-04-01'),(87,17,37,'2010-04-01'),(88,5,38,'2010-04-08'),(89,16,38,'2010-04-08'),(90,11,38,'2010-04-08'),(92,20,38,'2010-04-10'),(93,10,38,'2010-04-11');
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
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipment_bookings`
--

LOCK TABLES `equipment_bookings` WRITE;
/*!40000 ALTER TABLE `equipment_bookings` DISABLE KEYS */;
INSERT INTO `equipment_bookings` VALUES (1,NULL,4,NULL,'2010-04-01 00:00:00','2010-04-15 00:00:00',1,0,'1'),(2,NULL,5,NULL,'2010-04-02 00:00:00','2010-04-07 00:00:00',2,0,'1'),(3,NULL,6,NULL,'2010-04-05 00:00:00','2010-04-08 00:00:00',3,1,NULL),(4,1,NULL,NULL,'2010-04-06 00:00:00','2010-04-07 00:00:00',4,3,'1'),(5,-1,5,0,'2010-04-02 00:00:00','2010-04-06 00:00:00',5,0,'1'),(6,-1,0,0,'2010-04-02 00:00:00','2010-04-09 00:00:00',2,1,NULL),(7,-1,0,0,'2010-04-02 00:00:00','2010-04-09 00:00:00',2,1,NULL),(8,-1,0,0,'2010-04-02 00:00:00','2010-04-09 00:00:00',2,5,'0'),(9,0,5,0,'2010-04-02 00:00:00','2010-04-05 00:00:00',2,0,'1'),(10,-1,6,0,'2010-04-02 00:00:00','2010-04-09 00:00:00',2,3,NULL),(11,NULL,5,0,'2010-04-02 00:00:00','2010-04-09 00:00:00',3,0,'1'),(12,NULL,5,0,'2010-04-08 00:00:00','2010-04-02 00:00:00',1,0,'1'),(13,NULL,5,0,'2010-04-08 00:00:00','2010-04-03 00:00:00',3,0,'1'),(14,NULL,11,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',4,3,NULL),(15,NULL,11,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',5,2,NULL),(16,NULL,10,0,'2010-04-08 00:00:00','2010-04-13 00:00:00',7,3,NULL),(17,1,NULL,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',3,0,'1'),(18,NULL,10,0,'2010-04-08 00:00:00','2010-04-14 00:00:00',9,2,NULL),(19,NULL,5,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',6,1,NULL),(20,NULL,11,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',16,1,NULL),(21,1,NULL,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',1,1,NULL),(22,1,NULL,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',8,0,'1'),(23,NULL,4,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',6,0,'1'),(24,NULL,12,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',4,1,NULL),(25,1,NULL,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',1,0,'1'),(26,NULL,12,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',7,1,NULL),(27,NULL,12,0,'2010-04-08 00:00:00','2010-04-15 00:00:00',16,1,NULL),(28,1,NULL,0,'2010-04-08 00:00:00','2010-04-09 00:00:00',18,0,'1'),(29,1,NULL,0,'2010-04-08 00:00:00','2010-04-17 00:00:00',7,1,'0'),(30,NULL,NULL,38,'2010-04-09 00:00:00','2010-04-15 00:00:00',7,3,NULL),(31,NULL,NULL,38,'2010-04-09 00:00:00','2010-04-16 00:00:00',4,5,'0'),(32,1,NULL,NULL,'2010-04-09 00:00:00','2010-04-16 00:00:00',7,2,'0'),(33,NULL,NULL,38,'2010-04-09 00:00:00','2010-04-16 00:00:00',4,1,NULL),(34,NULL,17,NULL,'2010-04-14 00:00:00','2010-04-18 00:00:00',5,0,'1'),(35,NULL,-1,NULL,'2010-04-18 00:00:00','2010-04-25 00:00:00',6,0,'1'),(36,NULL,NULL,40,'2010-04-18 00:00:00','2010-04-25 00:00:00',1,1,NULL),(37,1,NULL,NULL,'2010-04-18 00:00:00','2010-04-25 00:00:00',1,1,NULL),(38,NULL,35,NULL,'2010-04-18 00:00:00','2010-04-25 00:00:00',4,1,NULL);
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
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classes`
--

LOCK TABLES `classes` WRITE;
/*!40000 ALTER TABLE `classes` DISABLE KEYS */;
INSERT INTO `classes` VALUES (0,'Yoga','Good for you!','Group'),(1,'Badminton','Hehe','Personal'),(2,'Aerobic','sss','Group'),(11,'Newtest','','Group'),(18,'34','34534','Group'),(19,'sdgd','fgdg','Group'),(20,'fsdf','sdfsdf','Group'),(21,'dgfdg','dfgdfg','Group'),(22,'uhrfh','fghfgh','Group'),(23,'dance','break','Group');
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
  `receiptnumber` varchar(45) DEFAULT NULL,
  `paymentmethod` varchar(45) DEFAULT NULL,
  `receivedby` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_payment`),
  KEY `id_member` (`id_member`),
  CONSTRAINT `payments_ibfk_1` FOREIGN KEY (`id_member`) REFERENCES `members` (`id_member`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments`
--

LOCK TABLES `payments` WRITE;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
INSERT INTO `payments` VALUES (1,5,'2010-03-03','2000.00','2 months',NULL,NULL,'1'),(2,6,'2010-01-12','2000.00','sdfsd',NULL,NULL,'6'),(3,5,'2010-01-31','2000.00','dfgd',NULL,NULL,'1'),(4,5,'2010-12-31','2000.00','dfgdf',NULL,NULL,'6'),(5,10,'2010-12-13','2000.00','sdfs',NULL,NULL,'1'),(6,11,'2010-12-31','2000.00','dfsad',NULL,NULL,'6'),(7,4,'2009-12-31','2222.22','test',NULL,NULL,'1'),(8,5,'2222-12-22','2000.00','',NULL,NULL,'6'),(9,5,'1212-12-12','100.00','',NULL,NULL,'1'),(10,10,'1111-11-11','1111.11','',NULL,NULL,'6'),(11,10,'2010-04-14','200.00','Membership fee paid until 01-08-2010',NULL,NULL,'1'),(12,17,'2010-04-14','200.00','fee until august 2010',NULL,NULL,'6'),(13,5,'2010-04-15','1111.11','','sdfsd','','6'),(14,4,'2010-04-18','2222.22','asda','13213','','6');
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
  `id_user` int(11) DEFAULT NULL,
  `is_active` tinyint(1) DEFAULT '1',
  `address_2` text,
  `emerg_contact_name` varchar(45) DEFAULT NULL,
  `emerg_contact_relation` varchar(45) DEFAULT NULL,
  `emerg_contact_phone` varchar(45) DEFAULT NULL,
  `emerg_contact_mobile` varchar(45) DEFAULT NULL,
  `medical_allergies` text,
  `medical_notes` text,
  `id_file` varchar(45) DEFAULT NULL,
  `medical_doctor_name` varchar(45) DEFAULT NULL,
  `medical_phone` varchar(45) DEFAULT NULL,
  `email` varchar(75) NOT NULL DEFAULT 'N/A',
  `member_number` varchar(75) NOT NULL DEFAULT 'N/A',
  `phone` varchar(45) DEFAULT NULL,
  `mobile` varchar(45) DEFAULT NULL,
  `sid` varchar(45) DEFAULT NULL,
  `studcardnumber` varchar(45) DEFAULT NULL,
  `gender` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_member`),
  KEY `id_user` (`id_user`),
  CONSTRAINT `members_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `users` (`id_user`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `members`
--

LOCK TABLES `members` WRITE;
/*!40000 ALTER TABLE `members` DISABLE KEYS */;
INSERT INTO `members` VALUES (4,'Janos','McDonovan','1091-06-24','my house','Cambridge','Cambrdigeshire','CB2  2AS','',1,1,'my house','Jennah Jameson','Mother','081231232','071231231','Clorhyne','I have had 4 heart attacks.','8','Dr. House','612361263','admin@ad.min','N/A','','','0819563/1','','male'),(5,'Ricardo','Da Force','1991-05-15','kh2443','','','     ','',2,1,'kh','Ã±lkhÃ±','Ã±lk','kl','jh','hlkj','Ã±lkh','','lkh','lkj','asdasd@asd.es45','N/A','','','','','female'),(6,'Joana','Ferras','1012-11-12','qwdqd','','','CB4  2NJ','',3,1,'','Cuenca','','','','','None She is fine!!!','','House','','skarvin@asd.es65','N/A','123123123','123123123','','','male'),(10,'Jonas','Pendejo','1221-12-12','','','','     ','',4,1,'','','','','','','','','','','skarvin@asdfas.es877','714 271 422','','','','','male'),(11,'joan','asda','1990-09-14','','','','     ','',5,1,'','','','','','','',NULL,'','','skarvin@asd.esa','698 911 330',NULL,NULL,NULL,NULL,'male'),(12,'Isidro','Catalan','1111-01-01','Ã±lkÃ±lknlkjb','Ã±kmmkljbgfgjhguigh','ghukghbkghhl','CB4  2SQ','Group',6,1,'Ã±ljnblknÂ´Ã±lkÃ±klbjknÃ±jhlj','fas dfad f','asdfsd fasd','sdaf sdf ','asd fasd','lots','asdkjaskjds ek nsgksfghfgh',NULL,'asdas d','asd fasd fasd','asdasd@asdasd.es','972 513 629','','',NULL,NULL,'male'),(16,'gh','hgfgh','1981-06-24','gf','h','ff','     ','',7,1,'zxdfsdf','','','','','','','','','','skarvin@gmail.com','330 568 590','','','','','female'),(17,'Mr Joan','Donovan','1990-07-12','House 1','Cambrdige','Cambrdigeshire','CB4  2NA','',8,1,'House 2','My Contact','None','1231231','1231241','Lots and Lots','You dont care mate\r\n\r\n\r\nHAHAHAHA',NULL,'House','','skarvin@marca.es','393 620 591','921231231','666666666','','','female'),(19,'assdgf','ssdfsd','1212-12-12','','','','     ','',10,0,'','','','','','','','','','','zxczxc@sdfsdgfs.es','822 556 789','','','','','male'),(20,'dfgdfg','dfgdf','1111-11-11','','','','     ','',11,0,'','','','','','','','','','','sdfdsf@dfgdrg.com','321 265 755','','','','','female'),(21,'Jano','Mano','1980-12-12','','','','     ','',12,1,'','','','','','','',NULL,'','','janos_hefko@yahoo.co.uk','633 402 358','','','','','male'),(22,'sfdsd','sdfsdf','1980-01-01','sdfsd','','','     ','',13,1,'sdfsdf','','','','','','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high/ok\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:','','','','asdasd@sdf.com','219 980 637','','','','','female'),(23,'','','1980-01-01','','','','     ','',14,0,'','','','','','','','','','','a@b.d','324 466 816','','','','','male'),(24,'Janos','Hefko','1980-01-01','','','','     ','Individual',15,1,'fgdgsfg','','','','','','',NULL,'','','a@b.v','939 563 120','','',NULL,NULL,'female'),(25,'Come baby','score the wikblits','1900-12-12','','','','     ','Student Full Time',16,1,'','','','','','','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:',NULL,'','','d@e.f','983 605 587','','','','','male'),(26,'','jjjkkklll','1950-11-11','','','','     ','Student Full Time',17,0,'','','','','','','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:','','','','w@f.h','160 942 534','','','','','male'),(27,'','','2000-11-11','','','','     ','Student Full Time',18,1,'','','','','','','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:',NULL,'','','t@r.k','802 795 886','','','','','male'),(28,'','','2000-11-11','','','','     ','Student Full Time',19,1,'','','','','','','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:',NULL,'','','e@T.h','249 157 243','','','','','male'),(29,'','','2222-12-12','','','','     ','Student Full Time',20,1,'','','','','','','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:',NULL,'','','e@q.a','895 821 289','','','','','male'),(30,'','','1111-12-12','','','','     ','Student Full Time',21,1,'sfsdfsefsdfsdf','','','','','','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:',NULL,'','','r@g.v','951 134 654','','','','','male'),(31,'','','2222-11-11','','','','     ','Student Full Time',22,1,'','','','','','','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:',NULL,'','','t@r.h','523 963 583','','','','','male'),(32,'Janos','Hefko','1976-05-06','Flat 11, Mushroom House','Cambridge','Cambridgeshire','CM21 0DF','Student Full Time',77,1,'Futrinka Street','Bernadett Samu','Partner','01223999000','07876444777','none','Heart trouble: 		n\r\nChest pain: 		n\r\nDizzyness:		n\r\nUnconsciousness:		n\r\nBlood pressure:		ok\r\nJoint problems:		n\r\nBack pain or injury:		n\r\nTakes medication:		n\r\nPregnant or recent birth:	n\r\nOperations in 2 years:	n\r\nDoctor is against exercise:	n\r\nAny reason not exercise:	n\r\nEpilepsy:			n\r\nDiabetes:			n\r\nAsthma:			n\r\nComments/Other:\r\nnone','','Dr Bubo','01223777888','janos_hefko@yahoo.com','848 281 181','01223444555','07838123456','0819563/1','000111222333444','male'),(33,'','','1111-11-11','','','','     ','Student Full Time',78,1,'','','','','','none','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high/ok\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:','8','','','r@t.y','968 383 596','','','','','male'),(34,'','','1212-12-12','','','','     ','Student Full Time',79,1,'','','','','','none','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high/ok\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:','','','','j@dd.gg','508 221 375','','','','','male'),(35,'ddddeeeee','','1111-11-11','','','','     ','Student Full Time',80,1,'','','','','','none','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high/ok\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:','','','','dd@dd.gg','339 440 921','','','','','male'),(36,'ggggg','TEST','1999-12-12','','','','     ','Student Full Time',81,0,'','','','','','none','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high/ok\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:','','','','tes@t.t','678 444 583','','','','','male');
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
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `class_instance`
--

LOCK TABLES `class_instance` WRITE;
/*!40000 ALTER TABLE `class_instance` DISABLE KEYS */;
INSERT INTO `class_instance` VALUES (38,0,1,'2010-05-05','19:00:00','20:00:00','Daily',1),(39,0,1,'2010-12-12','18:18:00','18:19:00','',1),(40,0,1,'1212-12-12','12:12:00','13:13:00','Daily',1);
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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (1,'Jani','Mani','1980-01-01','78 Tower Bridge','','','CM21 0DF','Full-time','','Instructor','2010-12-12','2015-12-12',23,'','','','','','','','','','janimani@a.com','','',''),(6,'George','Clooney','1999-01-01','','','','     ','','','','2001-11-11','2001-11-11',24,'','','','','','','','','','a@b.qqq','','','');
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=82 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin@ad.min','21232f297a57a5a743894a0e4a801fc3','manager',1),(2,'asdasd@asd.es45','a21653c0d8bfc7a610adce04a20563a3','member',1),(3,'skarvin@asd.es65','c29b2d78629b6e875de4975aa4c19019','member',1),(4,'skarvin@asdfas.es877','2a157d0eb15265b90c76ce6cbaaddb4e','member',1),(5,'skarvin@asdfas.es','c29b2d78629b6e875de4975aa4c19019','member',1),(6,'t@r.h','4117a218ebdf403bf4093536232846f2','member',1),(7,'skarvin@gmail.com','bcef43f532a3dd35af1c6bcf7228d3f2','member',1),(8,'skarvin@marca.es','74803fdf0df9cc0dbc5748743bce962a','member',0),(10,'zxczxc@sdfsdgfs.es','6189bd36da9400207d59ab95e73b3810','member',0),(11,'sdfdsf@dfgdrg.com','ffd5028b197fc0395be5bece481a5524','member',0),(12,'ric@2.com','21232f297a57a5a743894a0e4a801fc3','manager',1),(13,'asdasd@sdf.com','a07d6d3386eb54a223ad282dee1fbfe4','member',1),(14,'a@b.d','e0e73285f609bde970589181a0e1d915','member',0),(15,'a@b.c','1ff38bb62e741aef065a57f555f4b838','member',1),(16,'r@g.v','47310bbcef87ae0a6257bb2b5d1d2046','member',1),(17,'w@f.h','bcef43f532a3dd35af1c6bcf7228d3f2','member',0),(18,'e@T.a','bcef43f532a3dd35af1c6bcf7228d3f2','member',1),(19,'e@T.b','bcef43f532a3dd35af1c6bcf7228d3f2','member',1),(20,'e@T.c','bcef43f532a3dd35af1c6bcf7228d3f2','member',1),(21,'e@T.d','bcef43f532a3dd35af1c6bcf7228d3f2','member',1),(22,'e@T.e','bcef43f532a3dd35af1c6bcf7228d3f2','member',1),(23,'janimani@a.com','bcef43f532a3dd35af1c6bcf7228d3f2','staff',1),(24,'a@b.qqq','bcef43f532a3dd35af1c6bcf7228d3f2','staff',1),(77,'janos_hefko@yahoo.com','8b7523a4232f236111f3c8c495e5bf47','member',1),(78,'r@t.y','95ad068a8b78061f6c4ed0bc68f586b6','member',1),(79,'j@dd.gg','14e1a4e1dca3afa182db7005365ea7a4','member',1),(80,'dd@dd.gg','95ad068a8b78061f6c4ed0bc68f586b6','member',1),(81,'tes@t.t','5493e8142dc17220cd4143e5c2781fa6','member',0);
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

-- Dump completed on 2010-04-19 14:25:54
