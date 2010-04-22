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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `file`
--

LOCK TABLES `file` WRITE;
/*!40000 ALTER TABLE `file` DISABLE KEYS */;
INSERT INTO `file` VALUES (9,'avatar105487_18.gif.png',73658,'‰PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0–\0\0,\0\0ÙBí„\0\0\0	pHYs\0\0\0\0\0šœ\0\0\nOiCCPPhotoshop ICC profile\0\0xÚSgTSé=÷ŞôBKˆ€”KoR RB‹€‘&*!	Jˆ!¡ÙQÁEEÈ ˆ€ŒQ,Š\nØä!¢ƒ£ˆŠÊûá{£kÖ¼÷æÍşµ×>ç¬ó³ÏÀ–H3Q5€©BàƒÇÄÆáä.@\n$p\0³d!sı#\0ø~<<+\"À¾\0xÓ\0ÀM›À0‡ÿêB™\\€„Àt‘8K€\0@zB¦\0@F€˜&S\0 \0`Ëcbã\0P-\0`\'æÓ\0€ø™{\0[”! ‘\0 eˆD\0h;\0¬ÏVŠE\0X0\0fKÄ9\0Ø-\00IWfH\0°·\0ÀÎ²\0\00Qˆ…)\0{\0`È##x\0„™\0FòW<ñ+®ç*\0\0x™²<¹$9E[-qWW.(ÎI+6aaš@.Ây™24àóÌ\0\0 ‘àƒóıxÎ®ÎÎ6¶_-ê¿ÿ\"bbãşåÏ«p@\0\0át~Ñş,/³\Z€;€mş¢%îh^ u÷‹f²@µ\0 éÚWópø~<<E¡¹ÙÙåääØJÄB[aÊW}şgÂ_ÀWılù~<ü÷õà¾â$2]GøàÂÌôL¥Ï’	„bÜæGü·ÿüÓ\"ÄIb¹X*ãQqDšŒó2¥\"‰B’)Å%Òÿdâß,û>ß5\0°j>{‘-¨]cöK\'XtÀâ÷\0\0ò»oÁÔ(€hƒáÏwÿï?ıG %\0€fI’q\0\0^D$.TÊ³?Ç\0\0D *°AôÁ,ÀÁÜÁü`6„B$ÄÂBB\nd€r`)¬‚B(†Í°*`/Ô@4ÀQh†“p.ÂU¸=púaÁ(¼	AÈa!ÚˆbŠX#™…ø!ÁH‹$ ÉˆQ\"K‘5H1RŠT UHò=r9‡\\Fº‘;È\02‚ü†¼G1”²Q=ÔµC¹¨7\Z„F¢Ğdt1š ›Ğr´\Z=Œ6¡çĞ«hÚ>CÇ0Àè3Äl0.ÆÃB±8,	“cË±\"¬«Æ\Z°V¬»‰õcÏ±wEÀ	6wB aAHXLXNØH¨ $4Ú	7	„QÂ\'\"“¨K´&ºùÄb21‡XH,#Ö/{ˆCÄ7$‰C2\'¹I±¤TÒÒFÒnR#é,©›4H\Z#“ÉÚdk²9”, +È…ääÃä3ää!ò[\nb@q¤øSâ(RÊjJåå4åe˜2AU£šRİ¨¡T5ZB­¡¶R¯Q‡¨4uš9ÍƒIK¥­¢•Ó\Zhh÷i¯ètºİ•N—ĞWÒËéGè—èôw\r†ƒÇˆg(›gw¯˜L¦Ó‹ÇT071ë˜ç™™oUX*¶*|‘Ê\n•J•&•*/T©ª¦ªŞªUóUËT©^S}®FU3Sã©	Ô–«UªPëSSg©;¨‡ªg¨oT?¤~Yı‰YÃLÃOC¤Q ±_ã¼Æ c³x,!k\r«†u5Ä&±ÍÙ|v*»˜ı»‹=ª©¡9C3J3W³Ró”f?ã˜qøœtN	ç(§—ó~ŠŞï)â)¦4L¹1e\\kª–—–X«H«Q«Gë½6®í§¦½E»YûAÇJ\'\\\'GgÎçSÙSİ§\n§M=:õ®.ªk¥¡»Dw¿n§î˜¾^€Lo§Şy½çú}/ıTımú§õGX³$ÛÎ<Å5qo</ÇÛñQC]Ã@C¥a•a—á„‘¹Ñ<£ÕFFŒiÆ\\ã$ãmÆmÆ£&&!&KMêMîšRM¹¦)¦;L;LÇÍÌÍ¢ÍÖ™5›=1×2ç›ç›×›ß·`ZxZ,¶¨¶¸eI²äZ¦Yî¶¼n…Z9Y¥XUZ]³F­­%Ö»­»§§¹N“N«ÖgÃ°ñ¶É¶©·°åØÛ®¶m¶}agbg·Å®Ãî“½“}º}ı=\r‡Ù«Z~s´r:V:ŞšÎœî?}Åô–é/gXÏÏØ3ã¶Ë)ÄiS›ÓGgg¹sƒóˆ‹‰K‚Ë.—>.›ÆİÈ½äJtõq]ázÒõ›³›Âí¨Û¯î6îiî‡ÜŸÌ4Ÿ)Y3sĞÃÈCàQåÑ?Ÿ•0kß¬~OCOgµç#/c/‘W­×°·¥wª÷aï>ö>rŸã>ã<7Ş2ŞY_Ì7À·È·ËOÃo_…ßC#ÿdÿzÿÑ\0§€%g‰A[ûøz|!¿?:Ûeö²ÙíAŒ ¹AA‚­‚åÁ­!hÈì­!÷ç˜Î‘Îi…P~èÖĞaæa‹Ã~\'…‡…W†?pˆX\ZÑ1—5wÑÜCsßDúD–DŞ›g1O9¯-J5*>ª.j<Ú7º4º?Æ.fYÌÕXXIlK9.*®6nl¾ßüíó‡ââã{˜/È]py¡ÎÂô…§©.,:–@LˆN8”ğA*¨Œ%òw%\nyÂÂg\"/Ñ6ÑˆØC\\*NòH*Mz’ì‘¼5y$Å3¥,å¹„\'©¼L\rLİ›:šv m2=:½1ƒ’‘qBª!M“¶gêgæfvË¬e…²şÅn‹·/•Ék³¬Y-\n¶B¦èTZ(×*²geWf¿Í‰Ê9–«+ÍíÌ³ÊÛ7œïŸÿíÂá’¶¥†KW-Xæ½¬j9²<qyÛ\nã+†V¬<¸Š¶*mÕO«íW—®~½&zMk^ÁÊ‚ÁµkëU\nå…}ëÜ×í]OX/Yßµaú†>‰Š®Û—Ø(Üxå‡oÊ¿™Ü”´©«Ä¹dÏfÒféæŞ-[–ª—æ—n\rÙÚ´\rßV´íõöEÛ/—Í(Û»ƒ¶C¹£¿<¸¼e§ÉÎÍ;?T¤TôTúT6îÒİµa×ønÑî{¼ö4ìÕÛ[¼÷ı>É¾ÛUUMÕfÕeûIû³÷?®‰ªéø–ûm]­NmqíÇÒı#¶×¹ÔÕÒ=TRÖ+ëGÇ¾şïw-\r6\rUœÆâ#pDyäé÷	ß÷\r:ÚvŒ{¬áÓvg/jBšòšF›Sšû[b[ºOÌ>ÑÖêŞzüGÛœ4<YyJóTÉiÚé‚Ó“gòÏŒ•}~.ùÜ`Û¢¶{çcÎßjoïºtáÒEÿ‹ç;¼;Î\\ò¸tò²ÛåW¸Wš¯:_mêtê<ş“ÓOÇ»œ»š®¹\\k¹îz½µ{f÷é7Îİô½yñÿÖÕ9=İ½ózo÷Å÷õßİ~r\'ıÎË»Ùw\'î­¼O¼_ô@íAÙCİ‡Õ?[şÜØïÜjÀw óÑÜG÷…ƒÏş‘õC™Ë†\r†ë8>99â?rıéü§CÏdÏ&ş¢şË®/~øÕë×ÎÑ˜Ñ¡—ò—“¿m|¥ıêÀë¯ÛÆÂÆ¾Éx31^ôVûíÁwÜwï£ßOä| (ÿhù±õSĞ§û“““ÿ˜óüc3-Û\0\0\0 cHRM\0\0z%\0\0€ƒ\0\0ùÿ\0\0€é\0\0u0\0\0ê`\0\0:˜\0\0o’_ÅF\0åIDATxÚœ”Û•WÆŸw­õfæ°÷f¨í…iCDJJÛh…*QŠƒ˜jz¡^Ô£©VCŒ¥1¦áVmÅhlLISmF‘LØF˜Ba¬-PçÀ>ÏŞßù[k½^Lãà{û¼§‹çùÿo€çO^»¾ôØ¡ÃíÍ<OM®A@Yä	ƒÙc­r\r‡C¤ôµo|IĞi”\'Ñ–Ûn9ÙksÆÆjIå0˜HX«ABfk!ÄëçÿäûşÎ{?¡\0TÇŞfutÔu½T$D¤”+¤$t‘±µD$¤bf}x÷šáù¾\0¥ÑÖ­wlš›•Ò%f!ƒ¶Ğ9@\"\"c6V\nQ®T€©\r7	SÓ¤#3­7“dÁH)­ÑB(‘ÑZ:N¡µ\00ùk[«	B‚\\¶°¶Z8–Ù²)Œ¶Dlli¤¬\0°µÚäDÂäÅÜäÌÒÊrfò°Ö‚Ù°!\"\"f¡”€pÅa(\0$I$¥*Šâ¦M¯//ÆHé\0 \"ÃF `Xk™Y­™ˆ¤\0 ¥*´Ã³¯a6\0k“3D‚°R,›4‰Ù`0X+W\'}A!¤fc,-3\0óº7˜Y)—ÍÖØ8;gÙ\n0,[Xf¶Ì€ÁÖh!$33˜@$Äº¤Ö7‘…±š­µÖ2ÀHH%ıÀs\'Ï‹(Œ’$äç<’õzo^¾H\0æ6n¶Æè<7–~ğógÏÑ¦xîÈÓ\'MTëõº£¼ŞÚğĞö¾yfKR¾øÊŸ	ÀìÌsà;î™Ÿßû¾ıµ.[+¤øÑSG^=s†â|¼ÑØÿÉß»m›S““,„ó¿›ö×\'^~ì›ú­n·e´(“—^}%·¦_øÔçòtÈ@¯×!\"f\0£c5åyÓõÚõ«‹IÕjõôşgæ÷gYN„nw%Œ†IUF«Ì°\0°k×R8çÿq)\nínsey‰¤`f&¸û‹§îw×Š\\[k{½^)¨0à¸®pû¶ÛÒ4ß¾eK¥2Úív7oÚØlß*—ªá0™­×8t¨VŸ\ngÚ`F+c£cÀÄÄØÂéSI\ZUÆÓS:½ïõÚäµ«Wòì\"=V-Ï?pÿÅóÃxX.—“3ã\ràÚµ·£µè®-ï=şÚéG>˜ÄCW©jeüğ‘ŸıåscÕêììì¿/_Ü³wÏ§¿øàoŸ}~ßı©ON€:òä3ë…ùÍË/Œ×ÌøıÑcyÎmšu”ˆúÃ¿\0ÍA©,”$Gø«\0‡!ƒG«#Ë+Íp­Óo7×:}¡³ p:¦t¼$ŒX\n£SmÒ±jÍ².òD`ƒ<ÏÃ0qƒp8t]¿°EP.¥ Îât-ŠºİJàç¾o™5\n­‹Á` \0´ÛmÏõ¢8)Š¢ßéŒÕ\Z‚Èsº4È‡iÑ‡:‰Ò¨Ü¨DD¬óh©õK)]Qsé?£5G9«o_şÕ‰¿N¾k“!¡ÓkİX~ã­©©Ú{î&æVkU¸cÇöË—.K!­1îÛ·Çó]å¸[¶¾Gê%è=k§64n¹õİJ	cŠKÿ¼¢\0ø¾\'„¨VÊín7Í£N§ÛhÔƒÀÏ’äÖ»·w»ıÕ¥yÃØ0\\c–YjVV[ÀÍ7oşèÇö†aZòK‚äáï=Ç±çBR§ÓNÓ0Óq%á°/Ò$úk½ğÁ]ï¯7¦ë†ë8wŞµãìÙó_yğË¿ûí©é™1Ç+¬!v†Q¯×í†qØkµÿø‡¿Œ88wæx½1\'¹µ|êo§úêÃy¶ÿüí¸§È“şj¿Õj¾ùÖâ¹³tV”Ÿ\n€ëyY–dY¶{çşÜ¤è¼°Ì§N-LNNyßn¶¯\\Y|ƒ\rû§HÄ:\0¬åN§÷¡ó¹N	\0`ØH¢~o­½´:1:^òƒv»E,’dÁ+\0­vëäÉ×µÑD0\00œÀKÓtáÜÙz£‘&IçÖ–Ù:–YØ¼yúğ÷j¬!3ƒˆ@#år’$:7iYa­]i·¥rX%•¶VHRk¬Y‡ò;hò$«LÔò0Zü×Õ ´LÁH¥:n‹Œ`0[ Ë\n¼3&°ş.AkíJõõƒß\Z-Gqö»ç¥á0Ã´Ğ…5–Y\0HâhêÌv]\0´Ñiœ<ùÃ÷Úıé©™}»÷äY\nfR\"Ó9˜ÿË‰¹şÈY•üyÎ9ïmî;»3³³×¶Ë¶K%Ş°‰Db¼E#IƒÅTP011ÆDÀ/\Z>cü Áš A`1)4-VÅ„;ô’@[Z[º½w[vwvfvvæ}gŞ÷=ç<ıüÎ‡“óœóûıÎÿ­& ßxußOúIq¤°²Ú)Š¹ —Ëd…R©PÎ™ŒïWÈ²Ùl.“ÍxŞ›oıãìéK(Q*–Œ5®är9FÖ&ef`ÒV \0–Œ5•tkÕÊÒù‹,X*%kÕJ©\\‘RI©†k‡ÆÀ ¤’JQj’]7Q*Y.WE£¹–ÏoúĞÎ…ù)`DR)Tÿë3\0‘u\\O*åºrQ¯MúA±RÏæ²Ì„(I0\n`\"dşàİ@	ÄÌ,•ò<O3“V(åX²D|H¬P¡¯¬%KÄÌœšD’cÒ´×İTëY!\n!Ad‚ÌFo³§Óÿ¯±©ëxCòKéæ@9€ <?›¤±1‰5º†ÍÍ¶T®rhÖj%]m40Xk¤”±NºaD}+zu%å`^¾´LLP§1\r‡‰…`¦á>0Õ)3¥iÒ‹\"%¤k=yòôáCG]ÇC‰d‰‰HfÀ(¤@…ˆışNMÎ\0€µF	‡ØX\rÄ™‰˜„ÀŒ(\0‡‰¨\nk“Õ–¬µ`É¸®—õå8~Æcâx±ÖúS_øÊÄ¶ékç–^ûçßıì{ù¥ã§Ïm›¿²|ı‘ıPòÕ‘R1ìÇA¦4¹mËg\0éøÿ:zgg¶Y­‰øà¡W_yåõ_>ğ Ö)\0(åşfñ©ƒOÿebvË7ïıÖ—o¹U§q¥Rq\\Gázr\\O§ÉâsÏºÊyañ™ÙÙ-Ñ dbkÌCß»ÿ±}{o˜™Ä¹¹9&Ûén¤ILa‰]»nT»°°pß7¾½Ñn €’Ø*©²Y¼<ßùú=n3Œºù\\$\nR\nµcÇV\"\'êšk×‰Œ5fzvK£±F@(„1æñßÿ!Ñ}66±:IÏË$é ŸÍ‹Ïös33õ¥3gFF«…B1_(Fa×-ÊÍvK‡İ~öĞäÄìÔôôÌôVÇqÆ«ÕÚ¤0i¯\\¹ÿî{÷ı52ëÇI¿T,×ªõëË×–(–òx¢67×ëFaÔ«–Ê•BqLôÂ~cu=N¢co]ÜÿüHe¼^Ÿ˜œ›xğ“Õ££åñúxwõê£O>şéÛöÌøc<ú«›>±ÿôÇ_/>ùü±ãï‹Åß>ö»ù¸%jµZo¾ør&ãÖë£i_o4[ÍÖÊÚj«P.»¾ÇÈ’j³­®­I!ãA&¾rîLw3l7Ö%h!ÔZ£i-5Úëíf\'ÈzÙL0¼ùa¯#:n’¤A. ²?àá$Iˆ,Öª~>g:ë«pq¤ ‚``\0ê…İf£¡’T§‰)\\êt/^½…1¡” #­WzĞ¤[½¶…¤45îInöNŸ]R\0Òq†@1Zû_\"¾÷ö‰ÿ>[›šªÍN¿­Õh­¬/¿“àÒBŞètu¥¡\\×õ½@)5äBØí¹z®›¾anëüüåãK+GNX“ä	w~æÖ€¬Nãd\rä_»=ìF§N–RQetd|zÆQ\n™½ ;6SWÅ\\P.ŒT+šŒ@k.\\¸Ğn÷ÄÌdµ6Uõ<¯VC{÷îo®µˆÉüN«ÛİHôÀ˜4‰#£cfè÷£õõÆ ßWSSã{öÜ9QŸÄéöíó¾ïİwï÷¿{ïİıä-££eML(?ÓÜh§=ÛÜÜ8øÂ‹>:\n½±¼>Ç‰TA»İ¾íK·{eç»ïº#›éuÚ›íîò•‹KçÏ?{!ëø¾tû:V€¨µ.ä‹ç/]¹c÷\0×u/^¼|öØÉ¹ùí+ï¯&ıèğ[‡MÊ×— ™˜„ëzívãõ·|u÷]CrC&—M’øÔ»§ 5SµzÔÙ²@@W(f\0±´tjs3ıÁ}?f–\n\0´6Ì¼ÚX?·ô^¿5Û-ÇQQÒ÷”KLÌÊ8pğoÄŒˆ@d°†A&\'Ék‡ßõ\nÅ„ı$qÇ\nQ‹ååë/|s˜=Ãø`fö=_ùAë#ï¼Ó	#«¥*‘šÔ€…1Fá0µ>P)†ÑX­fÀq–¯­Æ›İj¥–jíeÈ\0ƒ\0@‘Øa§5†!2ÍÕÕùO=ûç$ÑõëW…\Z€”Bı‡)s±«ºîøZkïó¼Ï¹·v0NJš„Ö¥TR>@£4‘\Zµ)*%X„%mD¥¨Uú4­ª¾Ôª\ZUy´P§¤R(‰*db°q	~×±\rc›`ÌÌ`ÏëÎ½÷ÜsÎ=g¿V?œ±Ûoçwëh¯µ×ïÿÛ\0G<\'¤L’Áj··´´üìs‡¯\\YÇ[	]Û-Q‚[ÿMUìfËU\0p-İÂÿËÈ‚Då?ÆÇ;››}$éy#H\0H†Ï÷ÛÛ¦“T%IEµ ¬5Fi`t`U$¤DFFvà\0-*‚\0H‚¬5UâG@@dæ\'Ÿzâ¥ÿ›-?½ÿY‚ˆ\0&Æ\'wÌïãxqéB-wß°£^oz¾O‚¬µÆêª²œs€ H\n”€\0Ì„„@„‚@TI^\n)H\"\"²sHbåòê‘#Ç¾ğ‡’$@Œê1Àâ¥³Æh!¼4M—×mqñ£\'N²Ü*euÎ\n±5x™Ù\Zã¬avÎY $ffB\"AîêÈ—ÂC(IzÒ‚Z½I\0páüÏŠ<\r‚`|bzjª3;;Y¯×ƒ vì¬³€(„¬H˜\0*Ãˆ\0è#¢u‰œsÕæ»\n®\n!HÊ0jµ:@§ÕÙ6>†\r)E½Ö¬ÕjRJv[pâœev[ë0\031¢sÎYv€˜­(€˜Ù9kL,„Ä\0Æ(f\'Ê‘.«ÌZkyaÌl	É÷Ã8®ùAh¬${>8g”ZYg-ÛÊÌ!³c\0D°l‘ [\0ç€G\0‘Q\n\0Zí¸,K\0éùİõ+¥\ZUå^õ¶Õö†sP–ÅfÒëeÃAŞWFYpÚh`¬J)QD¸µ *£Œs#S*cJU\n/ğ…—õ6#H\0l®m›˜uÖZçJ¥Ò4ÓJõ666V®T\\n™\0qkG	$Şâ;bÎZ$´ÎI!É“~5 *ıøA–¦JMå$\0$é`vî=‡ƒašmnn>ıô3à;DÆZ\"\0•ÚfÇ-#bµUˆÈì€}Ïgàª‰¦h4š^´Ûz«yİÜ|g|`fö:B¬š¶„Yå+l¯pÌUG:8v„Äì\0É9C(ª—×ôo%:ÄkéË1\\	7Iä,38WUªqÎ9g€ÙYg\0€°u–ˆÀ\0€E·Õ•»C¬\"CE¼‚¤ã­#€	©ò§H\0h\r;¶VÀ×fƒÛ±ó=ãSSy¬]Y-òl+,\n)‚0ˆjqàyUpå…ÑÆh«½÷³İü+{¯›ğ=	­µ…*<ğ¿ôA€s×;çÀ9mğ}}öá?xø­ÅåÙÉ‰ÏïûÜ¹S\'+êœ»÷>yï=O?õo‡şë‡­fm~n¾ÙhGqèŠ¢ìlßşûû>ı‰;îTEV™m\0R6šÍ©‰ ˜™»`Çü.«5;ËÌ’üñ}ÿïşş±7z²,3«´6:/ò,M‹¢ÔZ13\"ıÍO´gg[­ÖôxÇ—²2»ã.°e-®	ÆB2Ö\0°~UŞÒ÷\0>ù[{íä¹jÉ—O•R|õOÿúÜ™¥i¥šV>Êò<gv•dF CÂCô¿ıƒgHP§Ñ ÂÇ¿ş­Õ…óËË—úIP bÅ½^×YËÌ[Ó­*Ÿé™‰;>Ò<qülY”ˆ¸1è/œ>Ñë¯	JÓ˜š½²²ÌÎ!ƒEÎÙF=lÄñæ ±5‡@?~ö?ÓÁº@²Ö\0;!½Á ?53ÓÛÜäJ#H!$\0Ü~Û-‹ËõZãõ×/]-E8î~Kj¥ŒÕç[k«šıHÙl¶Ó4}åÀõ+ï{üç~í+_Íò!QÈl‡IÅ±ô=¶.ğCÏ¢ ’\0°{÷®Z­¦T^êÎ[o;òÚ‰z{\"Ö[Ól±ƒQ‘}k­2?ğå¥Åå]7î9şê1t6r}eåà÷¿ÿé/~áÑG¾4;3Õ¢vkÒ9§•j×ÇÂ(ò<OÊ B	\0İîjš˜å©\'GYş‘½·>õÜzIÿ+|É¨Ò\Z#„ü°Ù£(\n‚X8sêôs‡~|äÅ…QqŠñ1Á¶ßOşçĞ¡¿ø‡¿òÍıÿômŒŒRÊÀIxÒów¿ÿ}÷şŞ=\0û¿ûø…·–Î\\xõ\'ÇÒ,ó|¿İi}í›ßØ³ç\0 Ûïÿë7ÿİæ¥c«Êâû~{ÇüÜìÿj=Öiu:íÀœå<I’A¥I¯·±Ñ\rƒÈj™ÉÙùykì¥‹?Gv~àAˆ\0ğäw¾~æìùa}µ[”E»Õ²Ö¦Yşä÷¾ã…;6Æ–ù¨,Uåå¨!ÆqC’}åà‘Ùù¹n¼Á}é­‹?;uzç®ù,Õëµ±mÛ¼ f°B\"´l¡Ö¥\0€_½åæõnïüÂùQ^ÔêµÀ—ƒdùáÎ³ÓÛ·KO\"°5ÆcÊ¢,Fa5ÛMé	\'qû®ù¨Ñì\'ı$KÉ÷;“ÛdFØ|’‚Ğù¾‡FÎÙ4ËÓd( Ëòth¥­³iš3³qúñÇ¾ñ·{nŒã˜„tÌÆháûíñHø$HèÒ°bV†‡#ìçÂØ,K(<úäy%ëÂ:§µ/DYêÑ¨ÈFÃîê†\0*å,~Ğj6ÉĞ9[*[*•õ{„ \0KÏË³ŞÆÆ¦5å«‡ÿÎ¾ûÇææ1é÷[c­å‹o_?9yåò»(¤svéâ›ÏüËş»îşõ©íÛE-RªÈ²l”ç~^T.ß—y®£8\"ÄkZğĞK‡?úñßô)$Dce1*\nºëî;O?°(ÊÍA?/Fíññ4ËõhÄeÉìâz„¡øÄÇÃóB0–\0ÉjõÎâb2H$\0ÄqèÀÄµ(¦++RJmt…Ş?úá_Ş»È‹âPIÏŸš.²‘˜™ß	Æö×º½+kƒAß¶M^ä.n4¢VÍ°QEÉì8/\n5*‡É0I†Z[\0>x©l­QëwûÉ ‰â¸ºÙªÄ—¿ò‹7½O!	B$A‚h­ŒÖŒ<²Ô*É¢±‡ä‘.U–¥ì¬‘6Y--/¿}i¹,”€];ç<OD¡h¥izèÀa@l6›J+Bñ™ÏæòÊê™×ßØ»÷C‰mAXÆB2­Jf#	\\}Ï\Z«ÊPëRkI4F´¶¥qÖ¼üÒÑÍ^Ï#y!À±Ÿü¨Ñs@eaV××»İ®Ä¡ïu:$±ÑİÜwßàIO[ó›núğ·îºqO×„™­ó2•Ê”e‘¦ıá0fƒ¤?|çÒâò;ËRzI‰Â1kg*‡IéÍÌÌ×êí©éq`0†WVVùâ—Ï{£\ZDŒkµd08}öìÅ‹—n¾ùıÛçvxadÙYgÊ¼,óBéb$iš®¬¬Xmó,·ÖD~ @HhØ €±±IÏ’aŸÒT/.-êw?UáÌU‰ÀœBJkL–§gÎ,°…÷¾wÏôÌvêõ»ªP«««ïö—VW×œcµ ª\rcD’DÆ:ãŒ«æåêÚåÎØ„±pòÔëòG¦ùğZJ½ú°õ+®ÕÓd\0€EQ¾±° ‚qS“õZc³ènln‡CD$äÀ´-”Ö	¬c$dÌ \0à£wß¾¸ôî…7ÿìË9*2ø¿¾¬Ø÷Z—6;c£<·VàÆF7tYdI¶±¾6HúUkiàa2BR*kI€²æêH··²:8|ğ¨2eµ\n\"m]ÿ\0rğ\0 (G\"÷š­¶±f”¥Î¹·—.¯¬5›µ±vË÷Â¸KëVk)}ª(ék@ 0\0¸ı×nI’âôOŠrÄpí£¶r8^ûÆÊ @G¼í–µ•u`TF\rÒ´»9H•úÖşï~èÖÏÍïÜ66v~á‡?÷Àñc¯)£¤ ¬ÙâX­´Rª,F˜_Û¿Š¾·Ğûj!i­€Á¥…\ZŒsSS½µnØ†½Vú¡û÷]¼p¤ôñûçÛç’^¤\n!}f@äÿååÜŸ,»ªû¾ÖÚ{Ÿ×½·ïíîééy4\Zc@.FI9±I!ìD”T¶Ea¢B±l P6 H9UNÅ1¨Â~T¨r•©Ä!”–\"22ÉD¤ÍûÙ3ı¼İ÷q{ïµV~8·G.ş€ÜŸNßºÕ}Ï9{}÷ZŸï÷4ü~áç?û‡ãÉ$ÏòC‡EÆ«+×~ÿş™ƒ°€Bˆ\0Aw1=\n‹GQQaDÒİáãÙS(Ây‘çy>WÎ9E¥C=|ÓmÇ_Óï/noO.\\¸bsÖ9›¼2Ğ¨¨èìPÛE[ø!*»œHDZ’ óÍ/‡£øácO=õ×!Fóş÷¾{a°ĞëõwF£\'_>{öÜ•kk,…[Eçİ“°Ö)ì\",\0Ue	mÅ’!Ræ@d˜ùC€€ıA¿¬ëw¿ûƒY–‘sÎå².Ô¥%(:]B›¤©u@…y×ğ 	‘Ğ´WÌmŠ  -àÚ«\"\"!ğëúuûØoŸ>}ÎX„bªÉNİTd M’›n:„HdLûİg&\"\"\Zkq&­©§ jÈªh;¡\Zkœ·ŸI’äöÛ_óÀ¯=¸½½£\"išÚÑv–sƒ=óÓrqa:óşåíËWV¢³‰Š\ZnqµóŸ±„±ĞÂ˜Ù‹\nŠ3hHdXøMo¼3ï.]¶.1ÖÚÛ¿#Ç½û3¸I	WWVĞÇ(Ì@Æ\n3!¡AİBgøNfĞ %IDF˜É \0²I‘¢µÖ:B¤Ó§^Ø\\»ŠˆÆàÅÅùA¯ÛíXZhá#QÅİ%*g9\0\"šyAÔ‚,Ğë™}\0hnnÁGo­ëöIšõzİ¼Èƒ¾u6\n#Í(( QqÎ‘i+\0@„…¹Íoµem¬ƒv½q$BƒªJƒÅÁüRw\rÙ¢èõzıN§×éuw£<ˆ€Ìa†Ñ¶µÛ\"QPVÙ[!Ta6dT\0ŒqªŠ„–¬!Ó‚«\0D¤ÊÁO! €#\"ˆ²¨Y˜™ëŠÊb\0	QEZù€Ùí˜‰seA…À!F1Ò3Ï}oaaÙº\0“¤ƒDÆ¢vÏäËµM-K†˜6íey‘¤İ´(\\šÙ$5Ij\\äMË°„#*2³²E@öõ?ù!ÆĞ®¸¹1³!cÈ²„<qIU|ˆ“T¥•Öüm[^CFDgn¤A²6R Š!”ÓÉ\\`‹Îœ‚–Ó,ï¨ª1	½÷%µ¶×™ÛmOcí£ŸU:Ì2ÌÜÒ™6D ª»²‰ĞÚ¸ª*Ñ¢!‘Ü%0ÆhËéÈ¥y§è\Z²9ªÈh<éur^İØl|5Ó}lYƒ¶—©(!2°iopËU[Ô\0@Ö«\0PÑø²ìuºÖZGD,Ì\0‰™™ãæÖ¨*«íáZ”OÆ«Ê-î±dÚÉ„9\n 1FZ¡\nHÌ	g’M†cPÑöí;|ŒÆ“ñh«©+Q\r¡ñ>xt4ÚAlÕ\0$„:rh·{A\\m×÷Ldgy95ÆR+1F\0H’4Ëóà›“\'DU]©Hšå#×÷>yùe\01x_Ïty—¶B²›ä#\0Ô€ZÚ4`»¥¨2ÇF;[.I<j‹yÑIÒÑ4uU–3‹pŞ;£D\0(* ¢¢\nLD:CGŠ3Óö«8\"@Ì‹N’¤i»Ä-.-\'.]XÚ³¼|À* +îìl÷ûeåŸ{îù/üÅ_:ëœq€H\"³İÇ(¨\n˜İİ±İPUÚPeUBœNÆS·‹æÊ…ó­øˆ2î;xØÎ2T™õ\rD†UPD…%\Z47z¡V™ \0°0í¶q\"¼+¤¯4” €„65¦­¤Ö9kIpÛ¡\"ÎÄ…€v]h“³æ DF8*™İÚ#Q\"jİÙ‚´\"ÒöÔíeVA\0ŒìQQAe·¢gtµ½¼dY¤ÕMB`D&Æ¦uë@h·	Û–·İnZ×@¤\rB`Û¶¨èL«ÚÑ×`âR2ˆ€ÖÙ$MÈ³®ªËĞH!„blç‚AÏ[ï»¯?˜kF“õk+ãÑğìK/YÜxi×3\"Šj¯~íëXB9\Z_[YáàE¸5äÀX›e	!Û«¨®DœM¦e•õºùøÇ:0?è\"†àÏœ¿Ôí¶½çÂbÈ´N3“±o»ûîw>ğÀ¹‹+ƒ¹bq~®öÍx:=uòôç?õ©ĞxATç\\\'ïdi„¾š8êÇ÷?ïÛ¿ü«¿xw]U”È(÷/ŞvçïüŞÂ›oºÅ{€ª,,*JÆ=sòùiYUu}âå“Şÿï+$£ªƒÁâ§¿øÙQY}ô×ßcH÷ïß»wqÑ)¬³5ùÀüèø­Ÿzî‡\"QD	‰²<?°ïK¨âÍÇ^½×¶ÊD¬I{êïD5qî—î¼ksízğ\rs”q\'\"“¦İÏ?ò•\'~öÿ~ë[{÷ìéôúú/ïüWûìèãŸxâë_U\"“yQ‰K˜ĞDÄcÇÇĞ0Ga&²ß{öé‹këGöí{ï¿}OU9„bí«¦nÆã‘÷¡m„œK¿ñİ¿»x}õÈıs‚D	~îö7õûsyšöªÂ,\nbÈF†¬\"Ò«n»…È¥6+ëæĞÒÒøMĞĞJLˆA˜µ?è//ïİ¿ÿÀââ¢sî=ï¼ïÂ‚ˆ¬5ÎšûåşãÇb~~dI¿?È²\r Ç0KY3S¯KiÑ$$Ã ßzâIÏ±“ºÍ­ÕÑhÛû¦(Š¶İÓÖ@µÖôæ\nßŒ–÷,¨‹ !ŞzËMû–öÖMå}SWeš¦İN¯Õ®Y‹‚H½^ñú×Şâ’”ŒuYú¯ßòó|ÿGÎŸ;šFUT˜…çç[Ç§Eæ„¤ˆôÉßÿ¸%ÂYTÛxéùN>ËÛ`|Y–yÛÄ¶¥5sk–——Š<?xğ µ‰EË*õp‹ƒošº®Ë|]•dŒµmå‚´ı<ÿÏŠ(³°¨ª‡*:O¶¶Ö\'ãÑd:‰Ñ§IÖÂˆ¶Ó·óƒ®Š56[_ß¼÷¿Œ€×¯¯p¬©òA˜­µsı~’ÇĞŠ(\"‘!B(§ÓG¿ò•PÇ÷}ğßÏõõtœg\0zßˆq6#‚±ÎYgìßÛï“èå;î¸ıô©3D¸°°X—#\"Á×u“f	ÅØ@+‰„&KòN§›gÅù³gŒhY§e577ˆ¾1†D¢¨ô{ëÜ¤ÚIçlb]’¸Ô;vÛd\ZwFãi9½|áœªÎïÛıÂT‹8›\nƒğ,öfq.M’$2ßó®wL6¶™P•ŸúÄCo~Û[Ÿ~ô1c ƒ 3É´šZc±Yš%IæÒ”œ³İNÚŸ+Ò$¹|ùâ÷İÿĞ>´°´¯?¿g~aáğ¡£Y–O&#U1Æ$I’çE§[¬¯­]ºxñµox½*ƒ²µ4n:zä…\'O¾ür9®›º™L\'1ÆÔ%E§[t»yÑ)²MÆÃCQô¬µ™ëª›eb\\ˆŞ7~:™VU%\"Æ¸\"ëôºınoÎÙ¤œ–oÿå{N¾xÒ\"d¹+:^·xú±Ç>õ?ÿ,^]]\r£DcMÑév‹¹<ë¦I–fyï‡Ã­­íS\'Î^|ñGDøé?ÿÓ X…fZOY\0º^Ñ-ºİ^·Ó76ô—~õ7ğÓ‘sI’¸,OŠ4/ÒôËÿã3ú¹?ïïY^Ø³wn~¡?X(:½¢ÓM²\"I;ğ\'ŸÀÇùìµµ­ó®óëß>{álÓø……=_ûÎ·ò4{è“tıì…ªœ!eiê’ÌZg³ìÃ¿óáÏ}ú¿:¼ßÙÄ¢ˆçáÖÖæöp}}m8ıÆ‡>tÓ­·|ç;O=q¾i&7;zÏ¯Ü\nO?ó4>òµÿuîâÕÓg.}û±¿][[!Î\rúÎ¥óäd\"~ñá¯yşƒÅÁ¯¿ïşi9şÒg>7ôç{İ®5¶L\'£Ñh2ŞŞŞ©ÊñÖÆÎ`aÒô–WO³bıúÚx´…YšZïCÓÄ¦	¡iıztÖ”“Éı/¿{Ï½ï8zË-wßõ¶ğÒ–ÇÉ_úú—{—Š\"Mãk&\"—Ø<Í6âõıûö†ã4±iš®^8o­C©%2”X²@6²–ã²	™Ó4KŒ6;ÿÄ÷ŞşKw_<{J\"û&4uS–eSÕ%@ ÊTä™ï>yñÜÕ7ıìÏôæº1Æ§¾ÿTQ$×¯®åyn­3Æ:$ Ó¶*ìmYNw¶‡—/_!ˆŠµ4-§\"|åâeviÊˆÅ\Zc	kaáè¬KWÕ“#Ço=öS?),¥oÊ²>|ëMåtšvb$¬œI€P4\"™9„Ú6ãñ8Æ(\"YšÖM“&™%\nŞ\'i €\"Ê¢*1k;½u…84ÒÔa:€u.+²YlÛ´I©&I3¡n7Umƒ!xDB€¼(ºİ|4\Z\ZU¾iêÊ£\n¢Ê]gÆ$iÑ«Ä ,\\O¤ª)!$›aEª\rK–˜VÏëÆ7>4uicäédâ}£ª©µUY‡Èˆ’$8\Z\rÑ:çP`dÈ‘5–Œ5\"jP¬4¥©!¶œLšÈ\Z“\Z“%bLTñ1>6UU••eU 4\"ª 1r‘©*şæ7¿ëŞ{\r¶ÓIˆ1Š\ZL!H³1ª&Ul¢™§¢XÔËtsP(µİÅMÓU\"Ç¹*+Ë,ˆblG‘y7‘¡ûïşÂİw¹DA2£LFÃñhòı\'¼ãŸÿüÍ¯=	İ¼×é\\½|©(:eUz¶‡[ãÉÎşì3–Ì¿¹ç	Ñ‘\n3Ç¸µ5´\0€d„¹M45¡¾Aé\'Óq¨ë¼S´ñD_V—–¿üÅ¿ğ_‚ùşà§şéOïÛ¿uuu:n7-ê…“§ëi½Ôï¹åHğ>/\nkmŒ1¿±µi‘H8:ç@ÁG?Cc³ ù¦é#š$± 2×øöŒÖ·&ÓéµçNœıÁ³y·kŒ©¶6y¹3—ìÛÛé÷:s}Î\ZÃ¬*|S×uÎY—tŠnËG[\r›E	Œ­ë*ø&) Xë²N§ÛCæ¶Û×/^l|Õln®ûºQ×ë1‹XYØ³Øß³Ğ(ÊÌ¼µµí›`‹<7Gn>zæìf9r`ÿ´,cª *ÿÄSo}û’M\\’$`­É³LU­sGşÉmÍN¹¹ºæò¤®+a©Cí—v“»xOˆMŒTX¦Óé´¬l’ØN§;Ü™ÌúÃáÎæöÖì¹<Pyô±o¾ùgÿ™KS\"c\00I“àeÁÓ~1pËØÍ¦“²ª¦©ªp 4‘½o\ZÄ–QIdõ>øU—––ºîñŸxµ5v¸=î÷çlûX \0=ûÌ\'£‘÷^UŒq†ùà«²òMY7uÙTãz\\ùfZËr\\W“j2®›ª¶…ƒ÷õd:^ßØ‰”ev~¾Ûïw{G2dÇ“i–¥Î9DJ“ôÿ<öíÍõº¬\"G@°ÎcTuZ§eÉ\\¨#²‰µÎXáÈÂYšŠ‚Ü4Ş{‚nnGÍûßwšåm;šw;q8ÜÕ^¯‹Hİ^çŞwİ»zıºqD¨H	‰‚Š!0Æ2†(±‰³–ÚöÍ:D\rQšà}ÃÍá·Ò‘³HPúIr|yß¡K—®îßào~“sn~~şæ›Xk¯\\Y9wêìÃ_úò ßÿwÜ·|èPÑé9g­í\n¨(¢­EÉQh¨Œ*\ZcïCğ±)§å…óO¾t*³©Aƒ¨øıï~Õº¤ÓéÆÕµµóçÏËÎÚN\'ëvŠIÙ|à}¿¹±±aŒf—¦w¿ıÎÛ^óš=ËËÆ&ˆ¨ÂÁ7£á$4±®«²š\';Óéh2¬­®Ÿ:y¦®jgljœE$ZQ\rÁkŠN>˜»õğÁ.é0Ç¦®/\\<ÿ}ïUeHÓ´®ë¦®yôñíÉ‘cG¿êV@+ìƒ÷å¨jÊªnšñhgcsu8Ü¾téÊöæPER› %bfQ±ÛÛóK†l‘wY˜†‚êÖpó]ïü5k¨•·²*-YAlêúÅO¦™«k¯h94¡McuSîŒÆë;Û#\0m}ã@%ªMÒ,Mr\"ª›ª¬¦Ö¸õ­ÿöÇŸ~ôÑGŒ¡]iSPpÖja<¯­®-Î/Í\rz‰MvF#œt{|nıìÎp„Jís!¼–è\0¢‚Ú$ÍŠ¢[7å\\šçÙÜµÕßşèï½ğÂspÃ¸ØÕïV–\0 ñÍ•+«÷œô;yX-`9)wvv„™ĞT¡N¬ÍÓŒYÒìÑiUµ¨Ğî½“ÉÔG÷GŸü“½ğ\\kÀı˜}8Zk…9„0NÖÖWççY–çY§®ë&4!zß\0HŒ•(ÎØ£Ajé=\0­®­4M$ÅÖp|öìÙÇ\\^ùc?ş\"Ó>¾Ì|íÚêÎh»š”ª‘cˆ;£\"!*Ã\"„(ªb™ƒˆ6Æ°¾~mnnïÆæÎ‡Şÿa öqñY~°Ån-kæl.Û©kPõ>lnm_Y¹’¥Yˆƒ”å¤¥¼H˜§éx<v@Â¬d^AU\06Mò«W¯=¿ò£çN‘ìÚ»¸Nv\nGéõçÆÛ;ÌB8wş’³n_ãCˆUY9kó,c666­µjcĞØ:zD\Z£ãÆeµ²²ùğÿJñF,²ÍMîÚñ ¨-1„6Ùb0Æ”U}áòeD2ÆF‰µÁÄÑVëÈc‰\Z¢rbµ[øêõkÁk]G3+µv¬¼Á2[X=ûa:8›HDBÛ;ã§N¯\\_)ë*/º×‡Ã2çE\'Š„f–¨Î0)\r··gŒó•2[K7\Z™Y	(‹o|o®—÷æÈ%€#O&Ók«k+«k£ºR0‡n¾‰ÈÖu¥¨¬2#«(m”Ğ¼å-wL§ÍÖÖÖË\'ÎìZşˆøãÿĞ }Ò4³Ö¼á7níìDÏª!2³«úÿûáî`ÏÍG¼ôü‹!úÄ¦–0pLmÂ*¬bcŒ¢ˆhQo\\À­ïÓì™Uí½ßŞÚ~éùu†ëWVÔ úBüú#ßøÈƒ~áÄââb§ÕpâÁ.%2!¶yw¡6ş­ rc5¶á|ã|ÛÊ5Æ¼ùgŞ°ĞíæyŞ4ş¯¾ú—1ÆÈqíúÊ‹?|¶ª¦×®]mšÚ\Z¨MÂ,í¨‡Hûöaá¦jv/Šş£ ¼’çjS÷>4!ø¿şê#?øÁV¯]ÌÏ_¾xé·ü °7V[šÊÌMS€€&Ib­mİ	\0øl{´íWUßçœkı^{ï³Ï9÷›¹’„D2©P±Eì€\nõQµ¥EÛÑÇPZkk;hGmk©j­+DGh­HD \"IH äÜ÷=ïıø½ÖcÎÙ?ÖoŸ{c½wŒŒÜ›ss÷ïüÖšk>>ßïB\0ø¾»nšëNŞÛß=ºy´ë;$»±yüñÇ¹ùæ<ü•/>ùÄ•ßóiQ!D¬**2ÈEE¯AX9¤Í\ZØÑ#UM@½ª¤æ;sclú¥0#ÑaÓ\\•ĞÃÌ©(ŒH©¦\'cMÃ(A“\\‘¾ñ^záÒùo|ÉK÷gû7ŞxæäÉŸ}ö™[o½óOÜ3ŸøÂ—¾BD–,Iùâê£oHßy…a†œ\"pØ`cUHã€mUPæFá€À8•a¬CHÈRRg&•¢‚ª²\n7õòşîùôŸ}ä_şëw Ğ›ÿæ>úñ÷¿ëgßyç7¾L2˜ØXß8{ş™—¾äeW¶·^şW^hqm2ıÊ#_^ß8ñĞCe¶Ê‹Âf9 A4”f1ÌœÊ\0U10Gæ(S‡:í&$Ö…Ó8È™4Di=%şbxIÏ*Â)ê%Y†€Âoıï÷Ìög.^®ëæÎ;oÃ¿ı5¯~ó\r×œ®M‘Y\08vä¸nSÕãGO€jQËÅ–1YYvwgYV8±>›ØŒ\0*Æ@\0Œ0KŒ’&ÓÃñ94hWkÈ$×!V±Ä4ì4špÑ«u…|¬¢¸¦\\0©Œt@º Ü»Î¿â›_ú?ñSïø±¹óÎ;6§Óûï°ªÊ¿û¶K³R  ´cTµ\Z¯™<oë¹ï›|ß-]»,ò¼(‹ÇÅ(Ïc2\0²Yfì 6^E§J“È« IŠ]ÂÊiğ<0a	0I;Vÿ@LAĞ!2©ç>9”¤Óãñè‘¯>úÓ?ı“6³ñ+ozó¶·wÓ6DcµÆÀ|1›N¦Y^\"b—Ì²XÌw¶Œ-G£ÊûØ¶í/~şÏ\\ôÁcxĞµ/¤4À£ZŒ1,œV\ZJ!h%&Ğ²õp(L\n\0`È¤Ô8å2¸ˆT!!«÷f¯=Á\"ÇK—®Ø\"Ë›ßväÈfÓ4çÏ]²&SkmgÆd\0ŸÿìİÖZ\"3!2ª2ÛßiÚn¾¨]À/ooïíïíÌêG{\\„û¾WNxHL¶+‘cšŠU0Æ \"sHáA\0ª!úı0n=Yà\ZÂg•‡™™”¤ú7˜ÊBÆ1‡ïÿpeZ›Y›cFã±€Ùbvòø)	®ËË\0L7­mÀæ‘°·?ó½Ş{Î‹\"ø`\r‹F‘\0y˜s’Š²ª`­Q\0A!Hx$@T9z@$kr¢\ro&­NM@KÒ2\rÛN…YQ¬±Êk€på@\0D†ŒÉòÌØ¤kP›VÈÎŞöx4¯mL×6L^(Ç¹µm×÷Óéxm>jê²ïò3Ï»á‰\'ŸÂ?¨(ÃÊÆ)‰ŞWJ Q%UĞ$ HH*:€Š«=4‰a•¤UQcŒ¨@“HÒ‰‘±€c@ÄÙpÈ\nEÅPvè—4\ZO	\0Š¢0Æô®#“I\"¾l–çy‘ev2÷ªÑ»¶(Ê4§IÉÃde94„U5é	\rZ› ((\nó$¤¼ş°JZ¥3\njw¸İSk*•ƒ¾KÒëJ]˜†ÆXkmšæE!-\0¼ğÅ/K¶G)v%F…	amºé¼T£ÉdÖ¦N–-\rŒª¢*ÂlM–z¾BhÒ£k‚<”…5¥2*2Àd$2­êk„kJÃ @ñI[íØ”P¥¿UÕõ=YcíDX W\0>ğ©Ó§n<}ı™\\YÔØ\"†^cèUx2™¶gùµ! \0\rÑŸ_˜W”Š16q)y$Â&¡ˆJ @([MQÒ˜$l$‘\ZH¨’”£ÑÚÌÚLTğR¢fP	8vÀª6ËÖÖÖĞéºÎÀ-Ïñúæ	c3“\r…`ô\0d6/ÊI–õy^\nGB2ÖÆè)iİ8úNBQcÈ’1D&Ñ8Ã1‘cÊlÒØWŠ®ŠJòÅ‚a®šìVBfB\"›‹2šXH9±5Yà˜ôˆ`PEE%íß÷y^¦”€z9Ëò2Ë²¢%º,¥¼iîhL¶Rf*ÇèCäÈ„IËXŒòÂ\0(³‘9>(‹èj}¥E—tâ*Â\"šgùaB@ˆQX¿z\r˜mÈˆƒk@`BCÍŠ““‰Ñ§ŒÉ*‚±V\0\\ßÙ<kÏ²,™­±÷]çËÅAYVY^*KTÅÃ!h†ˆ®ï•……×ªjsíxÛ´óeİõ§Å&\"élL£xÅä‚6ïšÖ²ÑÈ†ì{EdVyŠ\n¡¹¶ØOÛ’…”ueÛü!jÌ‚¸¾¾	ª}Û63AD5+²!E 2M³\0æŒ¢·6Ï³2‰ú…%ù½ˆêå­½QUœ¹ñô?¹»»›>bˆaĞW Ìî®–ï)´àŠD­<”Q\nƒŒtÅÔ‰ftƒ~Ye•ë­Ò½Ñ>„ó!x_7\r‘ÄÖû#Ç›İ*Ë-\0°H=ßC2ÇOŞ@CÙâº®¶¶ aæõõ£—/^üòW	Ş¥˜rÎÁfè §*Pp¥â6d†BQ“œUV94ª(Òj1§,\r€äŠ­B!ÔÃ#‘ŒC=, *¸¾K¹áÓÏ>}ÓÍ·d&·\0P”£ÑhLÆ:×O×$V7Cô!ô]×v]S/Û¶VÕ{?û§))@b€€\n+bZ“‡{O_\0‰¸½Va‚ˆ0`Z±l«r4\nyßÕ}I©–m(¯E£XyøRïºµéædmz°¿Ó¶íÎÖeHÌ7?èŠj4\ZO]ßæY¡\01xÄy×»Ğ»À,wßıQ>Ë²¤qWac,¥×¸ŠLiÅìÀ$ÔeõWŞV4p–WÛx«.!³‚é0‹À¢=aé½\"¤h¤ª¹Íq>Ûì$R«,GGOœ°\0°l“ñ4ËËª\Z™ÈÑÚœ•ÚfÙ´İ|vP×uÛ4‹Å’ŒQkó!€†à0—ÂL‚i†òo¥L_e«Ó9ÕW…&Ã×­^‘Ê\n|]AàŠ«¾õğG$ù8! @zé6…«¢LÈ•0‡¦™õç\0Ş‡¥t?uñÉ\'Ÿyä‘Ç|ğK34†Lbü\0A•\0ìa\'\0(ÏËCLz‘\0©	9ÀÛ«*IWÂ	XUÈC™;TÊ˜¾Xñppxµ,Ö”È¡¼û=Á=ç¬9´,~Pˆ§Õ2øà\nkTMÓ†Õ–He\n¦Í-\"é¿¦°vØœKQuu\Z®”C£m\'Wı,@T†Tû\0MZâ´WA:¥WÉ°®¸Ú{¼¦5Ÿ”÷é{:è3‡]®\0(</T1åS+R›EäZ•òª6½Šß^ó·^ÅgÓcé¶‚‚—@«²jÆ$“\0ĞAMp5:aê¼obÕßUZÕ“:f•ÚßŒ«tj’\0¨*ˆ `Ô¸Raj:y‚£•\"-!²Â2t\r/2¨\0i¥\"K!\"\"E\"Ìl\09fHÃ\Z\"U4¨©}\'Ê1âUÇMùPŠOCŞÄ‹¢²YÙÌ¹ŞdÀ“˜@‘Ûkd‰8ˆsTY$¥É	:Nü¹÷NUVç,@ÂåX„ˆ²,Ï‹Ìf™µTcˆÂ1MeÒz£A1†Œ1d¬!kÈ!²Æ\" ‚„…5×»¡UÊ™#Ç3gn{Åşz9]·6+«|\\•™µ5Æ°³³»»µãú~m}:=²nÈl™ÚUMªšÄ[ŠH8Hdµ•Vå<«\nÏ»åÌ÷ıı·¿ñÆÙrÙÔMY–÷}òOò*Û<~JUg;[xââ³ÏÔu=’ †\0(\'@Tk‹<Ï2KÖÀÔ:ÊBˆ]ßzï³<3d˜•#÷½ÿÖ7¾áo}Óx¼¶6;wá3÷üÉƒŸ»wokÛ9Ç‘¨¬Ê3·İú]oúßúí¯c>X,÷f³!ÒFveUefV…ÌÚÈ|¸ç2[œ¼é¦üŞo·}y{÷üÅí®;~lsjŒ‚İsgÏ^¾x¹ïûéÚôæ37Ÿ¾á4\Zr½[6İ½vïİïW/ÉJGE™F£*¯Ê²,‹2-cEˆÌ!D\"Ãª\"zİónşÁ·ÿİªªîºë}zïÿ‰ƒOÓèsØ©\'c‹¬Ì‹b<Y+Ëòë-ßÿCß‡\0pó™[”YVÈı°tÕàBÅÿø_ßõmßñú4	ˆÌ¹n›}û?9ûÄ£ *Â«I‡<r:S/÷oyË?üÑT·İ“Ï>û±ışÙ¯=†VO=6][ŸL¦ÕhTå N@\n>²Âw¼ùo\\úT™gÿ‡şŞù\'“\0A˜-Œ³,7DeY•ea³Ä˜ÌdÆÚUçÍ\0Îœ¹EDT$ÆŒ}O\"zÙ7¿ò~õÛ¾_4Í‘ézeÿég~îé/=}½!8×÷Î…‚÷Î9æ8X!ã*/CJ.-e¹ö?õÎoú«ß|áÊöŞÁlss}:™X\"­ªj2•eÉÌÌ‰‡âşßşc cª¢ÌÒ²6€Æ¤=%†%‚½Ìäê‘4ë\0/¸íà]¢“T…#\"QÍlşW¿åUÿá¿ş\rÂ£¢øƒßó©}LCl»:Fç½ãE4Æ\0¨’ÈöÁ!G™%†¼gfÂ¡BÅšòwïùˆ-Ê+e¯¯M&£Q‘Ù«q_~áİ¿ô™»?:D„D4èØ¤sI»’êé$yÕ(õê,“âÍ\0Àk^ıÒeÍ)X\'_+QA$kŠ÷}ğ·:çŒ¡qYıÂ»í{>µ\\,ëY.`È2ÄÂÎõ\"caø44ÆXk‹¢UUU£q5«Qù¡ßşİã\'OÜù’oà¤®4d­5ƒ\rñ_~øsûä‰ãÇ\'ãµ¶m–ËY×7>Í²|4\ZUÕˆˆD›sƒA^¶É¨€²*_ø‚SËæÄc=!1¡!‹D·ŞöüıÙ¬nÛçİtã‡?rÏÖãO7ËY]Ïx8bE‰‘Ö&kÕhÔw]ÓÔzµ›è|†„8¤Päö7ÿÇ{n¹íÖ›Î|]3Ãj~ŸpÒÿı?ßßÖ‹®Yô}Û{gˆXƒéò1zU˜N§yQ,—ó|Êç®1\Z—ÕĞ	\0ÖÖÆ›››å7½ì%e56Ö |ò©gOŸ:yó7!Ñß{×ùsO×õ‚9¨Ço……#‡ıÙ^a2Y;²yÜÚlUè ¢È*mC$LıÂÿöS?[0KB*uÕüØßº¼··å½ëú^…½÷}ßu®nû¥>‰|ööö@e:e«6]2<òA±\0päÈZ˜çE]×/{Ù×?ø…Ç%FùÖo{mÛ9\"zâ™g›Ùh¬›eŒ@‘¦7G!Bïü‰S…±”å¹¦$«ÒWÓkD‘ÌfÆ˜e3ç÷]ïÎŸ;zwû·ªÊ€=˜íµ‹Ç\0ªD€†(ª¨ªS?è²ˆ6Ö7¬ÉŠL$ªsı¡d-ı0d†¼ôæ›nèzÍ–“µiSw¯ø+ùöÖâÜùKÇMC&Ï\nŒªR%?Œ!FÎó,õ¿•I\rü¡ ´w‡%­ŸÍòQ5bVïÜööîÃ÷İK ¾÷İûùŞ~û+_óªW¼öÕ_¾÷>ÁyïÓ–Vn»^T7\'“”+§ä}°)D°Æ\0’1ÆšÌ\Zk­µ\00]«&3][kÚ°¨ûÙlTVãÓ×ûó/|ñgVn»åùy5në…±™H4d@Õ{ß÷.Ï³,Ïf‹ÅéS§É˜®ï|pÉ[ó\rÅÌæ„DÆy™Ğ»w}ïüå§ŸšNÖšÅB¼ëšæÏ|ºioÿ‘şÏg/äŠu=Ÿ/æYfÛ®ö!Ä¨\nk“õ¼,©ë»< e‘ŒYfÉÈXC4øø|âşWdmÛ¾ëcÛñööîŞş¬kÚÏßû@UÿÏş~çÜ~ïÃŸÿø\']×³«*ÇòÓÌä€btÎï:×§:ÃĞ\Z1Æ5¹1–c<8˜õ‹,ÿ÷pöÂ…‹O>ëÛ®YÌº¦nš&D~ş‹_tÇË_ş¯şé‡®Î³l:]+Ë2±)–,IÒÍ³KDq;³)|¯\ZûHƒòM-át:-JYT£ÊÎççÏ›Ï.o]¹ó¶Ûøê¿ÿ»ßtöég|è+1å¨Ì©óiÈô\\	i‚cT\"²Æ\Z“¥cÀštFë¹sçº¶7d@ñ·?úû³E}ùés  ÉhT	áº~ì¡/-fówş—ÿÀ}üîû~k6›eyvüè±jTE0ğ !\"k‰Œ1™±&s6³D‘¬Ílê—\Z2‚ÈŠ]×;ïóÍ²¹xábšÑ‚hÛ6=úäOş‹w\\ØÚzç;~U]ğ1ø$XºiÌ€JDe12H6³ÖdÖfÖZ2dŒq½.Z“¼îú_ûàû¶wwxø«„B	3Kà\r\n—(bº®_ìî|úÃğ¯yÕ»ó=Ü÷àoıÊ¯ïÏf×U%YJœrå&É~ÓR–„ÏDdÈf¶*?öÎ†\0ğ§Ÿü×‡>ğöÎÁÎÎşl¶üó{<ábİÔ!ø™Œ}å«^õó¿úKs“j´µ¿÷ÎşoÚå,xÇ‘a(àÁ±ÆVÕQÓRA2e^%zbëÊV×öïùàoŸùÔŸ‚ëGãè0ñçĞsŒÑ¹¶iúÎµm§½s{{ûËºyõw¼ş¥¯|Åh4º÷şyğË¹±ªcè»Î ±ÄÁ“Z ŠÜòâ}ïüÍ²(X˜E\0şø>Ğvn{{woVomíø¼ÿ¾+Û[}ß‡TÁ;LÖ¦kwıÎ²¢ŠÌÓ©1ôô¹ó¿ş+ï¥ d!*Ër>K?á°€^ó†o}õ·¼R„?ù‰O>õÕ¯MÖªñdT”E–å™±yåÖ\nKôÁ;çú¾ë»®ï;çšºv}×÷^¢™c§N½ê¯}Ç­/|µ+bqå¨dLÓÖşÀƒ~åk°,\nk\rÀ~ø®Ù¼^4şòå­ıƒù¹\'Ï>úØ£MÓ	‹ó«jd3“Yß…ô?ıÜ»^÷ú×ÛÌ¦ym‚g¸Ò÷Y\r¡µ†ˆ|Øuı÷İåÂB Ğ²,Ëª,Š¬ªÊ¢(ˆPUTbäÈ1×5½sÎ‡Ç 1°ğŞŞ¬×å¨,ËÊÚÓ”bØá`l†Dªœú\0˜æ„ÖP\Z/ûÀ!Êr±hÛ}ÜÙİIêë\0¤H8*«¶i½÷1òûßû¾“ÇÖÉfhl²ø1$N*†\0\n1²w™9rcŒ«Ü b–e£Ñxm2ÔóÏ<õ‘ßséòÖ©S\'ßü–ï:zôˆÄ¡5ŸÍõWÃfæö¯¿õÌ™›Çãq³hˆĞ\ZSyQVI@¯ Š	‰\05\" \0™%KFA8„ÔÕ×Ş¹zY÷}wöÙ³ËfÙ¹n¥;„²,Ë\"‹Ñ³°÷Ş}íË_3j\r¢!ÈŒHÎ‘9r äÈŠB^Y@TTA…P!DèûÖ»V„ËÑø­û»Ñ\ZB²DA˜%†ƒw^ä{¾ÿ-Î;Pí:×vû63EU\"a=æe™eYê§îer/¥k‘lã,\0t]·˜/š®m›f>ŸG9¦óFG£Šó<[.›Ş9CÈ,]læ{»Ó£GA,Y›0PD]©ÇA•EE™£rˆ1XkÓgJ¸˜HTU`’É>pmğ.yÙ‚¡¬*Õ¨ˆden“!$4ÖkpÖZk³¤NO¶Æ‰dI\'WÎ[\0pÎ÷½‹(¨2Gk±vc}­m:ç}ÊKÀİı»yëßù@c‡!…®H(YU‰¢¨J˜e1\ZeYf³ÌX\Z†d‚¬œÌt5ªÄè½ó®!¤<È`‘›•j}u/ÅàG\nIlPA\"‡dT†ª‰ÍfÑb²ëp]o 1¹ÊÊô_ªª4U¤s}‘W&zï}¼éûŞE³¼°Æz+áôˆ‘YTÉšÒæH˜´½Æ}ä_‚\nÈ€¤Š¢è<ôÁFNU @ €\n d‘HqÕB†Äóˆ5&ÏŒˆ\0Hˆ‘#ûRoÙGêe=L×0rì»¾ë;|Œ1µ†ÖF£¾÷1Š¨\n«JLíkPüò—¾òÂ;^”†\'ÉyIE£Ä=µÂ2xÇ¯ÜQ\0Ğ\0ƒQ”=F\'â¼kûÀ.pï÷b`/ ,¢¬B„Yf(+ó¬(²ÜD\0VQÄÈ¬ †¬¥Á‡ =d7um½·w`W0RŒÀ \0´Æ‚jfLs*ÛW³*~øÿ~äù·>Ôäe!&õ\0˜¥¨½ïÓTQòÜZ¤nÑúÆZ$¶¡¼,)+Da¼6ÅùRëZ39~Ã;©º¾İ¿²½yÃé®išıı¼*vÏ_ö~ç‘ÇÛÙÛû†;^tæùg²²’HjÄä™ˆ„˜Ùû \"1Äeİ^º²ÜCêD%ãˆ‘0È\Z}®Ÿİ0M9ñb»\\NL’£cª2kf3‡°¨‹ù\"t~g÷ÓŸıÜ¨\Z×[ßzÛK^0™ŒmVˆ°1¤ÂŞùéú:/æû¾÷£ÑXœï«£S$º´uáKş9>ñèce–)HYËÙbog÷È±#åhÆLmp^9JÌìúöàà m[›jœdt•Js“º>Â„YU–IBÍls5ÌP9wşÜ-eeóŒcó<‹9òh\\…0æX–Óé7ß¸syë©/~áÉÏ?Ø´Í¬m‹¼8züè‘ë	\"šŒlæú8²*û¾Û¹pÉ ,æ(Ì*·İ|ƒµ¶UkÓ¼(ÊrDhUÔ¦y8Š€Ffˆ.]¹²X,ƒÇ¢(‹jLuW*ksk=­\\Ô$¥æ1òsô\nÆÚ{şèOoºé¦ÜÆ²†Ò¬0Ã	hmºA”õ}‡\nÆšc§N‰Wv{ÁGKÔ¶m}nÛ;—:;\"lˆT!]³†Ä\"ùÚ\ZPfMfÇ“ñx}\rÉ$xL@„R#¨ÄC‹Ù\"øàœN|BU‰ÆPŒşÔ‰ë.„s³¹’ªÖu;gaqÍÈ65”}öÜÁÁ>ÙÈ\ZkÌ0ñ\"²jcà(õ&\rYcG8ÙÜˆÎµûË®î]×qd×umS{ï½÷À¸’x°ˆ!¯Šéæ´—d“P*‚(!ZƒÉ–…Cˆ10(–uí}èÚ^,\0lli»àƒ,‹§,ëƒårÙ´]q>¯o8u²®Û$\0\Z,ÍV¤5 şÊ/¿ïGßñ•¬\0Ä˜eYfs!J8“¥&/ød2–eyUU“\ra\rŞ»¾÷mïº¾ï;ïû#£ Šh\0Q@DE˜SW€çÈNU4!ÔuÓvİ¢®÷„Ö\0Àıà÷úàóˆÆ‡°¹y¬ëš®íSjºhê“\'/ë&¹uÃà© ª‘ã—¾ğğí/z¡î K;0Ÿ*B‰œ‡Dˆ\rB˜$WNw7å^¸î9¶¼*à ‘UD”E8ÄĞ÷Şõ1xfÎ¬U•Ô`M)Š°„ÈMÛìì/–õşş<±õ\0~äí?0˜î3³°óıñ\'\'Õx6›³ˆ(,—õtm’-e5ëÄ«³axàó_¸íÖ3HD&fÚúœ,%s}f	!zßûĞïcğ!xï½óŞù.‚—è…½röÉµŸcà˜ƒ.İÑ`­%Bk-hB……óÁuûû{M]oïøŞ÷]/éJÇÑ¨Ø0ÆE1\Zæ“z±\\ÚÌ¸ñäã_}ìÒÅ+cS·@8\ZUÆ“È\0“!¢1tüä±oyík·÷çg/mİ~Ç£q9ªJ.‹Ìf©nDÆdy†à¼aà•\rA!hn3kÓ<€E8&×˜èhf-ŠRA(İ!bjC\r!ÖËå¹—~êÙÜæˆ”Û|˜[ÜÿÙ»0Dm;wp0«[W×íl6¯›¶ïúGyòñ\'Î½à¼KçŞ¸\Z\'ã¢ÈßöÃoKšÀÙ|>ŸÏw·wïùØ¿ñ¯{Ñ‹nM§£µiQU™ÍA²l\\MV¼\r°HğÁû}T–$ç+º”C§§NÇX‘cé7%òîÎŞC}µïz\"cÉ Î0ø¿ÿswçyem#[8ç»ŞÏççxoÇûà½O\",\"\'£ª\ZOªÉx’å¹a¹XÎæ‹»~ã®‡~˜\0ŒÉ!å}¯{İkÏ|İÍG¬­oŒÆ£,/¬¡g2Xì)€p!öcÏÊ\"c!zuÁ9ç‚÷ƒCzVöŞum³\\4/\\ŞÙŞUC”™,9ÖªB\Zò¦ÿÆ“ijT³j¯©i;DÚÛÛY[;’d‘	OÏ‹\nbm×7M÷ö·ı°K·Î!*@UºÆ£j|ã\r§oşº?yòúë6)ÊÒØˆ@’r!¦’ ï|p^¢pÔÀÌ1D\\è¼ïÚ¶ñŞ5Mİ4MÛ¹zQÏçó¶îœs`­5@–Ì`â	ˆH¢ÊÊÀC_üd—ÉŸ>a’£j™77)@–ˆ3{ßõ}_×Ëù|îœÿÌ§?÷?ÿncÌµtVÂQÊ²òÎ¥¶*!¦iÑM7Üpúú“EYŒ×§k›ÕxŒU‘À9pôA‚HŒ!¦uã]çóm×´m]×Mï\\³l»¶ó®?„\Z«¢L×¥\"\ZZbÈÊ‚Y†‹¶·.®M7«r4\ZO‹¢L¾iÒÖu³È²¼ëZDêAf³ıÇ{ê_ıø;ÓÖÚç8!¯Ø&Cd$MÌU!ïÃ¹|èn¼éúª\Z»EÃ[É½¡oûbôiÂ‡Á;|İÔ‹z±X.CïcdƒˆE‹HFU•x8T H!;¸(EXÒtM\0õÌùŞG_•“éú†!³¾qLDÉ…n>_t}ÿOşÁ^¹|‘…WFÈø—ß»Ğ6MUXxX0\"Ş;\0İÚŞ³6—\'Oœ¬òõªªÊ²2Æzçê¦öŞ	‹*ÄÛ¦Ù;8Pß9ñ¢‚F•Y\" Sæ&®MˆhH«‰aì¤ínÀbæåræ½‹ãà|ŸeE‘æ‹ÅîŞ^ßû_şïïùÒC¥PvxáÑsßŞs~ˆJ\\VäŞ9ĞT!DC´ueÛ Æ ä6³ÆVåÈ íÓ¢ô>ÄĞµ]Û4MS{$™v¤ëé@Ê¼Ğ[@kV¾¯ƒkİ ¦SQH³\'ç|Ò23’á(1úº[[Û»{ÿúÇÿèPø®o˜b]õ’ıoQTŠ¢J½6\"*!†´Œ.]¹9‘² àh$e5²™Í8‹!¨ªóı²YÖmİ»^D\0ÔP†™ªz2²1&-bÒ$%tPnm`bU‡w¸\\ÌÖÖÖ§“) šaY/·¶÷>ô>ügŸşŒ\0ª&¯}{‡¨À_òJUÔy7\Z—V.lŒ‘‰zwåÊ6!>éE¢›¸É$äecÑbÛ5M½ìÚ–Ãp±Kêèdyîœ“g–g¹D’û]r>MÒ’$uIãîÄµ±ëû²ZC¤­İºî‹æçÿó/Ì÷’+âaYø‚Ê¡P÷š=‰écÙã§o_ÙN^1€ZU¸xér×uMÛÙÜìú¦(JÊÌ]×º¾Oa-%6&0è|±ÔÔm°Öy_æE‚Ë£¤Â*6h ˆŠ\0fõ1îïí#ÛÛ{Û;»¿÷»õlÅìz	>$ŞsıÈaå¨<ÜZ|0Ö¶M7û®‹1Šª!µšTugw¯ë»e]onlŒª±!3$/ÌD8]›0kÓ´.„ÀR7­ŠX›qdBasC–emßY‹¬‚¢†Ì\nS$C†A0]Ô»¬ë¢\0^Ö{³Y}şìå­í­¤(H\rÂ¿ !¿6ˆêJ\\ˆIN‡t(“1Ä­o¬{ï`dÍb>aÓ+Ï—uÓíÌFe¹6gÖ&0ºÈKç\\Û7”™¦iæók­É\0H8F±¢¹ÍX$³VD(Ò¢Æ„‚Aºå-ŠÖû3j\Z·˜×Şÿ…¤ÛEXQËÏ‘Èÿÿ£×>/_û‹¾kSñ^VUÃd}“ƒŞÜÅà©Ê³ƒùÂ,÷ª²¨ªª,‹,+€ˆ‰.]ÙF¤j4â…Ù‡ ªy¢FvÁ—E\\ï9$U$\0cL²şO ©€Éx½ëöf³ù|^/—M×t+ß5ğõUÏñkï¿¦3u>ëĞ!%¾Y‘‚õédY·‚¸vü(*ÔsåÄ–E\0\0fç]Ó¶D2fº¾a‹<Šşâ{~e{çà`6¯³ıËWşğ÷>Üv­»”uT”\"bñ1*J–@RPÂkÒ\0xë[¾+FİİÙİÛßßßßİ¹<ï]‡s­wÒ!«}õñ®Æ›ÕÿÓ]»?‘5\ZW×]úy·|İüï?áâ|6K#$›ç¶È$}± u½{Ó[ßü®Ÿı™cÇ½÷=¿ş©üQ3› BX,g\"üòozùöÎ.(äÆ²°&™ª*D]y}\Z\0ø¶o{E×õmÛ÷1^<{%FŸÑ_š¸\"æÿ•®!‡¦‡s1)¡ÆãqFö£w¼*\'¯ÿÎ×=şÈcğÆçİ$€Í²>¤û¤ó¬øéŸy××¾öåïùÎï~ö‰\'Úåâò¥çÎ/æ<ÇE.]ºc@BÍm–ìOpS‹!q5\0;;[óù,Ñ~ëGL]aã×ÆÏ•O…^óPÏyZ|ÎwDµÈĞAG”À;—·¶®\\ö¾›ìüÁ‡>òòoy™ì™\'}ß]¿ş±O~ôE/ù†TCèŸzüÑ÷/ÿ Šr\Z,ú¾ëÛº©—)s&¢¢ªL)¥œ\0\\ğ\nDÉàê;|Å+ïôC`Š>êYÇá/X¶ ^sá÷sü\\-¥Ÿ£7?Ü)ÛâÓˆ‘£sD@Dv¶v±íºÏşÙ}wıÆo.õo}Áöö¶D>şÒ•ËWœëa7$CÆ¤½›v±Æ !P!Ë¬Ş\Z›‘e‰>†Ô4ûÜ½ù»f×Uß¹ÖÚÃ9çîT£Ê¥Y–lc#›ÁÆ` 6ÓBÀ4!Ì!˜$$„Nh\ZÒ	¤›BŒb0$!6ØØX$KÖPR©TRMwzï}‡3ì½×êÖ>çŞ¦ÿ€¾?HÏSOI÷}Ï°÷Úk}¿Ÿ/üÿşîghmºá¬+Š²ğ~{wçÄÖÉëÛ7Î½u1Ÿ.æç_tÛ_ÿo+J§[GŒAµõzë”4Ç¡\0Ğû?\02U Å$=I@RÔ\'• ùe}òe~æÕ„„YÍ)ÙÌşQ‹i	¥·‹È(CŒÑµàÙËÏĞ·İ5Ÿ=s‹µv±\\ŞqÛÏ>wé®;ï½rõyë«åƒ>è¼=‚› êÀìˆxÒC1÷yOÆ–c6é=Î½ƒ¹75ğ°ÑäHÌ-pÎÅ¡ä+1¬ğ\":¥ŞØX;uòÄh<BÄ¦í¬·)%ÕÓ\0yï}Qád4”Éd‚`Ö×O¬Vu]wMw÷fÖ:\rq\'4>$ÇH¶Q†\\Ètwıø)!°È`îÉcOÖ VÚéî¬4D‚~v¢6M‘ÁÔWZò–¯ÿêÿò»¿òK¿üÿ8ëš¦ûı?øµßxû¿ıæo{Ë`Š ãé“g¬+ªñôüù»¦k\'o¿ãîår¹6İ<<œÏfm½/Ô\"\0Î9{l@”ÇÚ¹©|ÍAãIû±dË€7LÚĞ³ÚõŸ¤Ù†Ú›%D\">º”Ø;‚à¿>ğ®­­ÍøƒƒƒùÿÄ×uó~ñí_şe_rîÜ­Åéàğ (üşş¤8ªªİ§N½vıŠµnv0[,—)e¸>=ŒRĞ·e8_¤µ+#ÌŠ®è	H9¨\"±®¥¬ª\"cŒN›qØO±r¡€‚ˆ1»gÕ–q|yßÚÚøÍßş¥íëÛ§NŸ|Ã}Ş~Áçşô¿şw=ôèb¾¸|ùªªÙ©,Êéd­*+\"êš%IˆÔµíj¹hê&¥Ä5VTó PCQ0ktr\\\n—–iAÍÆÌÛW»C&O!*÷üøå‚ë(Häè»e¼2óßyÛßzü‰§>ãÓß°³½û¾÷~0¦ôÔS—.=ûü7üõ¿]øBısöÄÖIkìd<‘éÆ)Ù¾~u}}so<Y[,Ûå²ö®Ğ	ºAC`BL CUaI)ª\0CğÈazÀLKò‹Ê\04™V&D8X™4Ó˜û¨S6\'Õ2g¾H6Ş¹tñÙ§N9}ê¯}ÍW¾˜Ï—³ÙˆXk8¯ëª„÷EY×RŠ 2\Z¯-çû\0œÑ»¹¾nŒu¾$ÔÊSo\ZgËZ>È9È8…7¿9r,ãŠòíèÅ¤_—uöf†ü[^\0ÊÂ?~ÏûOlmüò¯şìt:şÊ¯|ãÎî^‚B~4Ä	È•ˆ¨ÁÛÔ‹zyp0ßSYÇ¨\ZYko9{2Zua1¤}\n9N ¹¹\ZŒy¹Îëš½Cƒ²Í{H!Aé‡hH·\n5K+Iˆœ˜ùÒ¥ËŸò²ûÎ;ó7¿ıïŸ>}ªmÛaN)9ç\0€vv®iUTãÚñdİû²ëÚ.4)uL„“ÉÉ¨¨™\r~lD ~o<‘H™d­3ÆÔ7µx`‚àã]PMv¿ZæÅ\'‡?X›¡J€&GóïZ,WÎÙ~è¡÷üñûçóEˆ)Æ y\\eYê‹M­ÆX)ÊqJ±7×7Ÿºøôt²)Ò,ıª®›[›³Ù¾:R²ñ2ò‹…UÖ©ß¡G¢nYš÷¥0<fã-Éz~]rÓ`*9^ö²ÜÔdÀ!œ%r,Ëâ÷ßùßF£Ñ¿úÉRT1¹¾#Ö9\0°Ù\r\n½/ê:k77Oœ88,ªÍUs­ªF‹Åòìé-…!\Z‚ˆÑ\Z—2d0–\Z1ğŠhÍ¬ÕŒ1V‰=*šêŸEêM³Bˆ’S´Ìqïó1T$Nú Äq:™?w¿²Y~ı7Ş¡âYÖKD\0–™1º‘ÕõRßgİææ	Àrmm½nBQ1Dc­ò€8õY~”² KKıãü)uº\0BHÜ78…½\'îë:îƒÍ’c5¾H-=ƒì_YU•ÃQñJ¬Á\0Ø—¾ôUš`ĞµõEh›ª\ZÓig‹qİÄåª9œ/}Q¬V«µñry(|É—¾”D½\rYaºH ¬p}Øp8n¡à°$‚Pf×©lov-÷ı>]¿2y1—oH™à‰ÇI6¹€ÔığÑG?Tør}mCD&ë[D6„–9ª\n0ŒG£jT•eå‹ÕÉ­õç¯\\s®à$	âQb$BŸ	‡:#ÑO¥%XLi¸\núJ$ #÷µsR•œJısõwÀÎz}á§dU‰d,’±ÖXçs]Ú´uLq¾8TGÛh4ÖÃÔx4!„²,\ngÊ²0D£Q¥\\½W,Ÿ†UoZğ1\"].Åó	Ô÷u¼‡¥:ƒŞ»ÆZå¨Š1Ä0$¿ezG6êŒY”áOôW# ÷¾¬*\0°U9ê9!2™¬;ëõ“‰„ÈeQ8gË¢pÖXg±m­µ)v@À¨)gZ¿÷ÍµŞò‹’súğú¢ÀLdY\rë˜ÓãixbSŠy|@šÊJìå+¨Ûör@‰RŒäİ\0&B\0ë, ´m³Q!{~úÃA]¯bŠ\0llaÈ AQl­)¼\'\"cs…B±7Ë«01³^sÍJcÓ¼Ñ¡ÑæƒÃŸ‡l¥ü‡¢ª•áX­v<*t![èqpÂ÷¨,\"ë¬¾¾(”CÌ¼¾¶\0£ÉºsÎeÛÖúó)ÅĞ.…Ób¾Ÿ8Z«Òj0Æä7gè@Æ)\0ğÚ|ŒTb^ş`Ç0|½ì6¯ŸÇ¼ü–FpaÆc)å×´D¦×.áÀğÎc®Ù\0ìéSg9¥;ï¸Ç“\rcüh\\$¾UŒãI}êÌmQnlXíîíùÒ/‰™û	…â)¥”8XrCJ±Gçb\0$Š1–êvÖ6Y>\nğg¸yr õP‚É+e”ßğV*-M+Âjz{öÜ*•!\"áD„6I×u+k]Ó,VËCí”éÁóæÖ?x9ßì¨=Î\0&—Ÿ¬ar œğ¨+9ìyŒ’ÌÁ›Mƒe¨{zXN4ëC=·E\02†€š¶)‹2¥¤gKûì3Yc­ó[\'ÏZcŒ+…E ÄØ‰HèV[[g¯]ßv¾0ÆXpÀ’$iø$	á@\rÈ(;4I*×û|GÎÁl¢DQ¡‹œ˜†ó‘^É¼-èTtÆÌœ«ºSŠ.ÈD¼÷\0B´Ş€}ìÉ‡_òâWœ9w‘!ã¬±\"`ÙóaY¯]ß×÷÷æ”‘+tì÷Ä™£Ññ\'-Øôx.@Ñ8•÷‡Ã|áş²1°¾ª‰uñ£OéÂ\"ÀH†ú³JJL¹ò§²ª\n_t±\0ò®xşê³NÓ8S\nÚ’@ñh\r\0«rÒçBäS4Æ\n³rq«m?÷fÔ|L²N \0ã\0­¥„Â(œ2›TD£yç*GÔ(AA4H–V¾,„ˆd‰PøˆÉ\"‰óèQ$Åd\r1f÷g~æëu®õ‹g§°ú†Éd$—ç„ó¡•È‘#2) ˆ·\"«Ö\0}\ZûåDÕõj\"ÏÍ¨l.f[G3ã›rC\nò°×\'\01aad26÷õ¥Û¶ñ¾Ğ™İİ¾bq¾p®°¶8¾€ééc8œ\ns×5zŠ\'$!Òs®*{´ì1\'‘cÊÊ\\÷h~! (SŸÍãÍ_Á¡…H(¹fÈÅ:õÇ(=p`a¡ìÈUh+!0Ç‚ºÀ:ëªÉ:dqdDÑÁ¿2YİLş’ÂQ[GlµD•/9g\nrLš—Á-G‡@muêÁ<Ÿ<Ad¨<ûÅ—ÛĞw„sHz¨!Õ_¤„\0–‘5D&\nQLÀ\"QhëÕj1¬Å®Dë0…Îº‚cÒx\\èÕ±12‘	†hRFEY¯VuÛ¶]—˜“¨Uw4z¡K>m˜,ÉÙ‘Ğ\'g1¤ş”¬àèç—ÊÌÕEHaHµÆÄ”Œ1(@#_rLD”¶‡‡³~øM[2„dœ×›c{œASl»V€Ï93ªÊår9[.æ«eà9êh¾•ËqíÆ±;Ú÷åúı=O‘È=È¡¹8`‰2ñ\'…;…N+7m…Ñºr4NÌ¡í<\"‡Xú\0¨ªFz™ËCfîB›]åDÃ£&)EC¶ë:cèóçEdÿà`1oC—8…ĞÅtºr“ŒO™fı¹¾çQF  ’³Ná×ñ´®ªd(ÂñîòÀMÕy”.Î)Ä°l\Zã½ Îsäd²ro˜æjÉ8‘ºwP²ØzçÎ>q¸?»vízˆA7Ï¾ÎÈBŒ~ØwÔÀ5B”ÛÇ¹—Ï‡Ü3ã”nÚ£/3JF/Eƒ@Üô	˜ÛÊGOÓéZJ¼··\0¶ëZ_´ƒä}\0!´ÂÉ¹R[—‰Yq*mÛnmlrŠW¯]×6I6&`Ïy\'‹9Œ:õ³´<v{Yø¸jch™fö”(EÌè¡6×¥\0 £XÒœr£Ã¶”’C„™Sjc\0ÄƒÃù¹İvbëäãO?fqy¸ÇÌ›\'n±Æ\"™”häpnÈ\n 	`èÒd<şğ‡>(½:6Ÿµ±çsƒGÖ\\Ærgê~b&C2Œ¬µÏ\rÆ‡!\'jİzu¥­ƒÕ¼¨µ_–\r„‰Lä0_¤$\0`Û¦NùÜê_–cWT1F²*Y\'„`ËòÃ~@z»ƒö‡mŒ]JLÈÇ%)CClÆÁ£§phLåfÜ±ÕH@¬¦=ƒ$fK¤4ú¾ñ6tĞó‚œUXÆ8çŠÑˆ \"êÙş®1\0ì‰g&“uæä}á}é¼Ï¬ìÄ‰9¦c!¤Ÿ~êiÑiQ¾´cdnû…ú‘Ù±ç€:ÈÏxD^NLÇ4=lYÑğB}n?±ƒÜËÊ§çu³êB<yú¬0oo_E$•`Ùíí«)´ˆd¬óEÙµMQR¢Â9¥„D<ôğğ`…¬‘¡ÏÃ‘_NL>¨÷Ó3E`û”ÃD@zô¥’›zŒQsL¤:96ı•Ô;oœ!¤ĞµW»hŒ›N×Îœ=¿¿¿\0têÄi}ô,”}îhB×`ÛµêÊ\\Ì\nòL)ÆØi*1dh(PCnú¹i×Ïƒ#R\0(À[ó#r{`8öÉ,ÃDëa=ˆJOÏ£ c½.xœÂşîÎ¥‹O¹å\0ØÅr>O«å‹n[×\"SoUŒ‰»¶\r1^¸ğ´5&†0P2ˆ	3õñ.ªƒ~Ğ}¼¬£Gèï†–H&/˜\Z*4t·Œ5ÄÙ Oºu®ªFD&qò¾(Š‚¬„õõ­¢ª$‰/Šj\\mnl\'S_UôGØº©\'ãéd4M)Æ(¾¨bŠ@ĞÖõA½ZµmÛ5Íµ«×Tø…HŞm9kr¶ˆcb“«0aa*¡‘p˜İj3NéxLvSB„”z¦ğPÿå–ª\0¤˜óy_ã-ôoY²»Wo$fc¬\Z×Cj‡˜»6]¤b498˜‘1c_–HbÜÛ;xöÒå‡úøC=¼»»gˆİ0ŸMëÓÓªó¦_ZĞä­-á Ì8Šp‡P+}zdDTˆpŸi#éçÊÇ\"h`HÄIjÀ¼P3sRy€½±sukãÌşÁê]xøáGŸ|âéG>ñD‘Œ±ÆÀĞº`î  B‚Üãë)¥@D*¥š1G0cÈo–4ô™ú>ÿÀ/Ecİ8Z“òÑX„Iwñ&á ô¬şÜ’\"“;®xÛwu]G¨¤Hé‡—‹L9†ŞCDD\rSÒ·S\"ÂÈÑ\Z«ïØñ$‘aašÃWcãñf™v.@nÒ²]$:6…¹é·MãRÊã7‘kÛ×,0;cÔ¿—K§\\ŒKBBG«¨¬Ÿ& êºŸ‹Û£‰<‹tœx4š^—iú¡?mà ¸F€›N\'Zéô°S¦ş«Êt\"DSĞ%\0,Jf®âqIl?H`Õ}ä“#”¢Ú †xuåçŞ.öáH2¼_L¹­¡à|HCM\'yÒEU§Ox<Z.Czó£#CÂ0!ğpùQ?¶Ui~kî|)%—ˆtõ?J¢¸I,Ò³ûeø=Â³‡ÜÊ1¼óQ?u`ÕqJ¬gQ†\"È½ƒsh\Zçñu=¶¸§/ô™&’\0‘r¾ÓÑ3lû–Ş±s.KÎÍaZ)B@Ü·^z…Y^TdÅ=J·?ßBâD\0ª†pÃoĞ{ NÚãcÃì–ÉÕÏMm£¥A‘‚@”¤âêv¶»ß|­YYFÍÇ°\Z£Âój)}bÇ øâb1_TÏ»ŠQS¹)mMíß)%…WbßŒcÖÔ\ZÑõO2#ZÓ\"¨ÇOBU•eYµmdBl$ÅÌB(ƒw2×-7Âzâ‹ÑÛ©-Æ˜†›£ÀŠ#‚ñ Ô­_¿¤µ\0¬µ„yQèÏÇ”Ç]–Èd´&Ú×M\r€9F…T°F§”bJ\ZÕ ËŠµæî—¼ü¥¯~õôÔ‰Ñh4ßÛ1h`µ˜ï^¿Öu-Y»ãÚÿ8\0àm·Ş¥z÷ »Â`µä»77Ğ”üÌÉ9ï¼óŞYk5H­­½líˆ#ŒHÖ)èÒéÿ­#Af]Š‘õ4£JŒ±ŸRÙãëŞôæ»>õŠ «J?*Kk	R<˜/n\\½>Ÿ\ZG›§OXkÖ×6¾÷[ÿ†Í1_ù £Ën~×3÷=kd¥§Æ£ú5c××7ÎŞrn¼¾ÖvMJ!´]½\\ÍÕ½sLŒ \' V\\‹#ëœ!rNk:É~Er_œÈƒH€ÌğÒO{Õ_ş«eº¾¾µ¾¾6•EiŒÁÕÎÚ>œÏ?ö‘¯mm¼è–³\0`u}‹VoSçåî¨ô*şd,YtöMÿË›_÷Æ7Ùá<†¸X<ö¡Ÿ<w®ëÕrûÙgŸşÄ#{;;)Í: ”D5ë¢!KÖXÊØk·Z-Û¶3ÖpLH&%¤µÍßú÷¾óE·Ş¾>]K)>øşßıûğô“V‹eˆ@ÈĞÖéÓ¯~í«¿æëŞrû¹ógOjºvwv OéGíõTêƒšk.‘˜¢±\08ñÖ‰SÿèGşÉ]÷İw}g÷`¶X¬êQå7××\no­ÁRŒ©\raY¯f»ûxâ£ï}ßsO=İ¿íLÖY_¸¢¨Ê²tÖúÂYcY½Ò1†“¢Öº¦s¶xÃ—¿ùuoøüñxôØãıÔş‹k—M©;vÎ4j?ë[a´yúÔ÷şÀ?|ík_Û¶íı/¾o¿í®1¯y6‰5kÜhaÕ#Ç\r‘ÿŞüş¯úê¿òüµë/_á;o½¥pÎ:»¬WW{şò¥K»{3CtöÌÙ;ï¹km}ªxág.?ÿ»¿ñ[{ÿ{µ\"ÉZ3Œ‹²•£²(«ªê±ƒ¨l\nR\rpJğ–oÿæÛn¿m±\\üıïüîık7R\n\"œ8ö2@TÛ¤Â÷¬óEU&Óéæ©“?ò?öê—¿ï¼ã¥MçÚ‡9æÌˆ~a!2¾¿ó¾«\ZóÎŞ¾wN[,¿ğs?ÿ®ßzÇ|¶RĞı7{9¾¼óŞ{¿õ­ßy÷½÷ÖMóÄS~ùßüìçŸ·Ëª˜ŒG››“jÍ{osŞåa C×@l»ğõßñ-§O~ø‘Gş¿ó=Â!†nhk_Ÿo\"¾ğŞÓÉÚx416—™‰ñO?ğ¼ûîûb:\0ÈãÈÌË‰aDtâô™şÇïµ]ĞjˆÑ\Zû+¿òŸ~ş_ş$Ç sPJ–Ök4ƒI¹:ÁÍ\'ô_ıËSgÎ,êúwßùÀ£ïû³½½õµÉ©“§&ãµj4®ªÊ9¯KhšîÖ{îùÂ/ùCôèã}ß·}\'sÈ‡•¤íFÑ 8kmU–eU1¨~|ÓïğˆˆøŞ÷ÿ	Şq×‹AÂúß£hfMfµWãé}à=³ù\nçuYëw|×‹—æó™Œ™LÔë{ò˜zIA¡ÏùÂ/øşşÅªşÀGN1<ş‘Ôû‡ëkãÉÔûBc\"ñî—Ü÷Ÿõéªe[5«¯ıKo¡¡ËJ#\"\"ãœ­ÊÊ:k­±Ær/ëÑSå tµÆ~àÁ÷ã]wİ«*æcB=\råŞ€àşé»É¹ùj5,šk»;?ø÷şq\n«Úb×eĞaJ©®ë”b¯¼èµN:Šp®8Ûİ?ûk¿°¬›‡¿0U\'¶6½5à¬ŒÇ“ñ‰bˆ:¶Ö|Õ›¾rvãjè\Z\"rÖz_(\0È{\0À{¯{&)ÅWK(\"óá}Øú¢¬ë•Öå†HTZÑW}ÍW—U•XÚ.œXwû‡‡?ô=?èIˆÈ;\"*|1B\nkiMwêº®ST˜r‘À¹MÏ\\üÄßøª¯û•wüæ+î½çòõRU£É¨òŞÙ>WUSN„ù—şÃ¯.övœ5kÓ“DT%\"0§È!Ç>f³	ÖMMDD6O¯‘8%Q˜€¹ï¾—,–KBê›}¢mC†~öÿmd7ÍÙ­MãÜ?xÛ÷½ÎœŒÄaVƒÖÓúneY…µÖæ”¾Ü¤™^xòâ›¾ìM,™½³…wŞÚŞˆ¥^úpcmºµµ9™NÆ“qá½³6Gnäø¢$À¹\Zëu\0p¬!”RÚÙİ±gÎŒ÷gãzµà¡\'¹owşüy²NB˜V%\"şøOşŒgiÛ¦íje³f&‰)ja«¹Ê¦°ÖjB´ÎÛ®)ĞG?ğÁÇ?ñÈ÷Ü»;_äÑ·Ü \r¿ğK¿zòä	*îBÓ÷oØûÂû\"„P7uJA„4xV˜ÉÀpĞ…@²\0wŞyÆZ¯y7šo¡Í×¼æÕ!„§y¶pnÙÔÏ=~q¶¿7ŸÏêzÙµML!I4Ö’5ziõNŞÔÕÛô…Œ«ñ¸*GîÿïŸŒÇk£Ê ¦”R¯ëÓK\\8÷èƒ<yòä‰SkÓµÕjµXÎ‡MÛ4M-ÌeQÇãÂ—Ğv¤&£û‚d¯\'9ç\noN<a×n®¼hèô-§wövÏŸ=%¿şïØ\\[#„®kÚ¶®ëåb1_,œ’w®,«^Œ–OÀùÔß‡0­¡w¾ã…wÎº7¨Öæ«åÚhTŞ;c!ã¬5V%OuS7mMHeUyï2/|½’şÈßÜ©*cèüù¢!Q6ï1Ë—~Ù›>ø‘nml’¡\'>òğõ«Ïî‡Ğ*åEU&MSsâ¢(Ç“i?1˜°ox	æàÑ¾{ÿ[¿úëUY9gôÏ\\º¼¿·wåÊå§ŸyòégŸJs·¢7\"kcÚZ[”¥±”U¼GCéƒi0KÁFUiŒ½÷Åç«jÜWwhœ}ğCşÊ/}SLé±»tq{ûº0Ç´ÑCTˆº\0À;WU•îúÅz}¡h\'åH!\0 ‡û³İÔûÏÿ¾våÚlw6Û[,ç‰£äÀCV?©ò‰êº&T®;Ò¿ã06?ê/Ğ‰ÍM_xcp4*ªÑØº¬Õ$Äg.\\Ôô\'ïıS\r²é›<c±í¢¸ÛÃƒ\0ŒÇÓªc†şM~hó„H=`ù-Šòâã@pHvÌ-Qk×®’çµVX4B¢éê¦]¶]£Â¼”bÓÔ1¥ª,µLË¡4¬6£>İÜÚD´\0f¹\\İs÷™Gm»¶I1ƒq^Áø/\\ M«Œ±m›!\'´¶ÅºiÖa­5ĞJÕ÷ğYN4ĞË;K†.=wùì·Å”RŒÂuË©Ûİİi›Ua­îE}\"#b45[èÄ‰“6£á@”C{¤^$Ò>«¸/AÎŸ?{ñâ³dl\né¯Ó70Káİ¥\'/Îg³.4!4)&<jIä£\'…ĞYëÑc3ÍÅ^	{Ìfˆ³\'Ü½v]×M³XÎ¾ríÔ©“/}é}œxmº¦x¥¦i˜Ğ¨µ„u8­‡Uï\nB#€U1:‡Ã\"§İ*cr»õŞN§cë˜ÈÎgNOw¶§³ÙœóI„\0ëÕ²íjM*°Ö  ö SL,`ˆ03k]0Áú¯xdF#•Å \"®V«”âÇ?öĞîÕ«àÉ}ğc_óõ_}ûwy_z2m× ŠÁ¬÷ÒÏ¦m¬µÎ9õÏhbô÷F2k\r!9ëÀn®¯®s®#r€v¹XÜÿ‹?ôáÇ›ºÑ§ÖÖ¦Ø¶)¶‰ÓCÁ,MÛ¼#2]º½æ@ôÜkÍCì%ËjÛ%2e9ò®X›®%–Ï_yÚ6¶aïF#,÷ÜygY”Tø²,Võ$»7,P¤´ªy:5Ùum&ƒ73oŞz§#c \Zkk“Í­Íét2\Z­u¯xùİãñxwg˜åÄéÓ^…oÆZï¼÷˜£€Øyï¼%¢¢(\0¡í\ZNI³23[@±ğeá+ïËQ9)|U8şÖó]×n­O-áÔu+‰áïÿ€µvıäI–i#STU–òş¸ğ…ˆhááœ5Æ8çÊ¢*Ëª(Jï}Q–Y*pbëÄéS§×§“ñ¨,\nçïÿŠWÜû¾?~öKï{ù§„3\r‰Yß«ĞE}ÓVu;ëµX|AWW¯ªµÎ!‚÷…÷»îxñ=‡‡3o­îuÄP/?ğ?Ş½¿¿÷9_ü…çÎÑ¹[O8=×ÖÖ´âŠIÕ	túÔ™ÑhlŒ\r!CÇsÎyk­w¾ĞàØ¢\0:±u€	¹,ìææÆæÆÖx<.|á,ıÖÛÛ{\"¯}ígÅÉ ¡A ç|LLdº.zW;{N\0B8å®yŞrHû…¬÷Î{|ÌÇk“İë»êC·d$†P×‹ÿşûïzõg~ÚöîşŞÁ~Q”“ÉZUNŸ>{êô™[Ïßvß½/{Ñ‹ÎëiU×\0X¸Â\Zï­÷Î—EY–•÷¾,ªì™ÙÜ:½yâÜÎöõÛ7–«UJ\rs\0àıİıW¯}à½ï}Õg½úe÷İ»uút¬§’gåZšL¦Êù°ÆEN]×©°H÷+Ô#\\OqD\"ï\0Ö«úúŞ˜âßüeuS¯æsN<·±­›g{âÖ»ï~ı—¿ñßÿÄ¿.½­ªr:bN1%k\\Ótš\r Š‹³Îj*ˆ¡œLbSbíî\\yö™Gç‡;ÆÀx<ŞXßUã²*oÜ¸Ş…ö»ÿæwíÜ¸Ì·Üq{`,A»üê6 J	š®]®MS‡Ğ¦”÷Œ1„Æ9ç¬wÖ—EI„‡7nÜh»†“|ã·óìà0†\0œD¢:!Ô«å“?òÒ—ÜwÛİ÷Ìwvw·wvRˆÊKŒ1Ä4x³’Æ»¢Ğ±¾/œ±ÆjF‰±\0@“Éºw~sëÔt²n­±‹)Ä®[,æzZÿ÷?ÿóò]oıöÌûN1„.(“³éBm×Æµ¥o Î\'¼/\nWŞë‘g±Xìîî¨®ë5Ÿû\Z4vû¹ë‚¢<Î;_x\0~ş©\'¯_¿úwÿáÛF“õÓüp¾³³Ë1ŠH§l>Éª%kó…w‘!²DÎ»ÂgÈ¨˜êzb7?ØošZÊr\\£ı½Y]×œ$†ô]ßõõªT£/øŠ/%4º°@b1†Ğ¥˜º.~Wç¼weáïWx]¸œõm×åZ4ß÷Ã?0_.—óõ¶(¼s®,ïlYx¹ğ‘‡‹ÅşôY_\"àj¹ìºÀYw­Ö1°ÎEáœóıoq¾Ğ¼ïM`¡ì ·]×´MèÚgŸyÎ Q\"Õ¿ü±ŸÜŞÛëºî¿ökÎÜs\'+€!†.v!…˜B\nt]\Zîg-‹Ò¹¢(J]»%!gÉÿğıhÓ³O]@Ch,YkÈ µ„.g§Ø®^=òà%ÉOıÒ¿9uş6@êb$CdŒ ¸Âû¢ôEAÖè/uÎ«Tjã]hî}Õ+´À&\"Û¶MŒ©mÛÃÃÃĞ%Ù2sŒİï¼ı7Ÿ|ä‘KW®¤ôŸşàæ­·$€ÀI+Ã6tIP¾uŞù²,õšºÂEá\\á\\d\rzg‹ozëw¾ìU÷_¿v½Y,!2Ö\ZoÈ\ZµT…w¾ôEágÍç®üÙıOaşç?õÏ_÷e_º6İÚÚ:½¾¾¹¹y¢\ZMÊrTUc_TEYEé\\á|a]é‹\n]ñÍoûö¯ûú¯\0|×;‘—ËzÕÄÙlyc{ïÊ³WşØÃ{»û«fÕuˆ”ÅèwşğèÖ[n±Æıß?ñSz÷»»¦I1ªz_»XÖZg½/|†KXk7ÆQ×…§¼ğußüoüŠ7îìÿáùİÛn}‘\rrJ¡1´ËUS·«åªög³ííİ“gÎ~Å[¾vcs³éº~ûqÙh¯±mê‚%Ò¸:ÅmáÿòWù«?óU*Ìş”;îÀ÷üÑo\"ùƒÃÅşşáÕk7nlï>ó‰gòÉıƒYŒÊf…Ñxò¢[Ïÿöï=ğÔåçï¸å~ğ#ıÅŸşKc×)¼”Œ¶!M“rÖzBcâr±ü†¿ù÷Ü÷âU½zûüµÉ¨\\_ŸZk@ZÙ±tMS×u]¯ËUL±®ë½½ıå²®ŠêÓ?çµ¯ã—U•˜ì©‹O=7Û…¦MXÂÚÆúK^òâû_õŠéd’˜à¹ç}ä¡‡ÿöw|¾óƒìÏöö;»³Uİ=õñ§¿ğÄb±H)…`<™L¦k¯ùüÏù?ÿÙ|ôñ\'^~Ï=,bŒù¥ÿøë|è¡Òª²\\Íç!¶Ú#µÆj\0[b^?µù­ë›³‹ÅâíÿáW¥étTV¥÷\Z0c\nçIÏmS7MÓ´íª®Û¶]Ìç]×¶u‡€¾¬^şiŸöY_ğù›[[½-á( ‰DøÒågßÿÇïÏfeYŞÿãïÿ~[úÑ25eµæ–Œ¸èšÅÁr_ñÃé(»Ğüéÿ|Ï÷|÷ßıÿú\'Û6XgDäŞòWéıköá}èÏ>z°}PTSì£ôü~ÿ«ïÿ¼Ï­J§>ö‘}è}6UeéËQQUÕ¨ª¼÷Ö\ZÍŠ\'jµgªc­s\0˜«ºjæ~ú\\¾ğU“êÔÙ[¦ëSk|ä´Z,wwvB×!3\nO\Z{jÛ¶i›ö`vxxpP×«®í‹eŠ©—\n‚Ö\\†°©ë÷ÿÉûŞøú/yû;ŞîıúàÍıôû_şé÷¿‰bJuÓ¢5d­M¬Qxé™KúÓHŠëkSïlY–eå‹¢¨ÊÒº<¸–È†ZŸRÎ9(KïíZJa4ªÚ¥¦¯¡s†ÈH×m?wyïªSE±$yK ‚>÷¯ôg%“H\0cL¡)rŒ<È”œa8rVõruñÉÇíx:İØÜ\ZO¦ÆPb‰!bévMçóùÎöö³O_œíìKa,£Yïıh4\ZJk!…“!´ÓKdœÃƒÃ½ıñ¨šLÆ–l[ô±jJ!Ò¬4(@4H÷­!cŒ@\0KÖ‘q€­2÷÷wsÿ²×˜Xk4\0º®5Æ6õª(G«Åbµ\\&%Š§$Œ)F¬Æ®!¦”B×Y‚$I8!êvg]-çï÷Ÿ¼÷½2Èk>ûÕŸ÷ºÏÖn<Äßõ®?|ğÃ=±µşé¯üÔÓgNÕuÇœ¬%cHCUAy0ª°Qc…u›Q^Øb¡®W]Û\"âşlRÈèşpPx·ZÕê°D€ùÁ/*UÆ4B¨W?\"Äjbfâ®t¡CHÛW¯Zc>å%÷­­OïyÉİMÓÙ¹‹Ëåòü­ç¤(ıdmº½³—b²ÎkôÅ@ÃDÑhJ\r^|U¼•HÉã‰’E0‹åB\0\"§lm³V@ˆPXBŒzö¹|ñò‰S§	ó\0HÃ‘£DcÄKÈ„I$qÔPIÈ $LÚ6u-—ãñK_ùr¡<®°ÆD‘Œ‚™nnÜ^(9’/ŒóÎ:$1´†­5@)ÀÙ$¥]\"%œƒ\r¡›Ïgû{ÛûËÃFX¡·\'ƒ³Ö9Ûu+„9=öèã÷Æ+!k!AXd\nBr{‡¥p¢\\Œ“ö6EXDÅ¸V³àXÓ}8*}=¤DÎúQÚN6ì3ŸJ!r´à2İ`°!«¤ˆA581¦\0VEÖŒY\ZËjîQ¯¤j{\nïBmŒáÄÏ<ó´¶Ò³\r2z|Œ:È…™#‹xë‹¢0Öª°€%)mˆ\0‹ºÚ¶I)\rÏ\"±õVÄ\nT¾a’‚:ôN±qï‘Râ¤Âô¦âb>«ëåşşaˆ1Æ¤v[ï<ykëU“‘Ak½¹zõˆ¤ÉZÂ#%¾ d`~?Şcœ·ÖŞ:Eaâ¬0#&õ÷î!n:Á,{qÏw#B4„„œ8Ù~Å‘˜r’ü0Ä˜ïaL‰Œ3ÆÇ­q«T«œÜyG9•…YÁ:ÂÒ6]Û6Y˜^|)x­Ä\":È\"Dëœ³Î8C¤€A–”9S9S®åØ¥¤€´…	Ää,$ “µ“\0˜@\\d<2áÄ˜8I!¥Øum¦·Ä˜º¦€¦m(‡©\'$4ÖTUÑv¡WhŠ\0\ZfŞ¹¾}úE-;¢^bÊĞƒå@Ğ\Zgr£µõa€§¢Ş3à(1HÈ`´¨±0¸OHTäªæQ‹!Š5”¥¶ú>è«œD÷°ü”†Ô›B—r;YrÇÈY«yıÊtek/<vaóÔi\0†®PÓ)`ÀšõE4©—ÔªL€d¦ E1	s\"DŸ_¬\0D9ØM„1«Q$ÅÅ`oëŠ!¦™%¥bŠú”\Z4\n\0ÀzµÒMYŒ!I¬øœ–òÓ¢}äÑG_õÚÏ$±”èpŠÂÀ¬\nOC™?H@–\r¨ıaƒ™Ó—\0$†ÔvÒ%èÀ$#\"¡m›N“û\rkÀxƒDÆ\Z!“$¦Ş~’„1±5¤4I,)Å¶mSmÛ€íùU¨Ø5õâõmæ>d¹/v¡€.„‡~¾E„ˆ*Íä^”£¼õ#DGÖ5\"X2,	Ä&r¸ëºe+1¦&¶M£]Å\n\0$a«QKŞú²´…×§˜YĞPbH”ñ—9mF7‰BÛ4\0`Y5² „¦ë:BCHB¢–a1f=Ñ@ÁY.W±íDÈ\0Š¡^õ\' -j–˜1ƒ(Ø‰5\Zn×†nÕ¶‹UÌ)IbŒI¨t¥ &”U³²ÎËáòÀZC5…ı=24š]U\0KbƒPöºeÙDLjÒYé7,ŠÊ¹™£0C5‘ARÚû0d?âŒ!ÂşŞîÖ©³)2\"22ÄJ¡‰‘cÎo-$9Ü9€„†Bë½íjå¼ç£pjš³\'ìÚ,îŞ¸î«ÊÇxñ™jR5‹Õl{{¾\\ş÷?~ßd:~íç¼z<Y3P˜­Aà>&ªá<tİb±\0ÛÔ«# Ù±¢p\"Ğ«q¤?—ŸşÊúÖ©Ş\\Ñ×eˆL\0I@RŒ¡^ÕMÓ¡ğÁlÿ÷øƒ/~Ã›îûÌO-Šb²µ.€íªİØZ;˜ÍFU5Növww®]_ßÜ,Š\"Ä`\'­u‚·:çbŠ2¶³Ç/4MÛuİ“=õÒW¼´ ²Æ°ˆU&lµ²nMİäµTc{áT.ØÛ+Y\nÇ¥ùçÙg»÷%/ƒŒ¥Éä.2D,@àl²j›º^Ô©í>òÁ¬V«İåd<FÕ«¢pÆ¬M&Ş;gİt2‘S¡,*c­M¦éª¶iëfùÀoşçqQ]»zm¶»g\'e9N&ãQ/\ntV‚Ö˜.Û‚9¥Ø4MÛu\0`QB4E™I©ÌÆD,œïbwÌÙxdI`‘§Ÿ¾È!¤”¬°ä|È—EÄhçĞºÎt¶,^ş²—:qâ‰]øçOµœÎ;SVåÁÎÁK^ùò.EcèEçoÛŞŞn›Õü`QGóÃƒÃ½ıÚ“›6¤ç®\\4HãÑ¨*É™\'7\'ÓI–6gÔKf•k„fLa±Zv]ÈZ}Õjw¡³Ö\"é»¤‚*-mÿZnììÄRÌŞh†b@2HEYú¢¨X„y4OÖ×Ê¢lWmèºùl±»=ÛØXóy1®šU½sízŒÊQ»h¶ÖÖy¾š.ší´ª·Æc$ªª\r­o®¦cç\nƒĞ€ÊçûlK\0áº©ç™OÓÃ‘S*|é\\MH)ïŠ<Œ\0An²^ËááB$2+›Õö¬_´Æq®(«ŠEbŒéÔÙÓUYí^¹šödÜêº®nêgïbhC\\[_7ÎÎÓÉx9_î¦Úà@§õjl½µ¥²fº±V”¥2?5U\'s~˜9tQ7êÅ·¾(¬uÆ˜ñx²¿¿¯T$\r)óÎ\n€AŠ{­ôœ2Ÿ/ªÑ„Sdq¦ÇÌ£%ŠÆÚ¢¥$ÆtDÖS–U5\Zí_¹Ñ¬jæj-NV«z¹\\&1¤X·ëÆÈb5!Šb $BJ’Ø\0)…«pë›ë¾ªDpøFQD)I8±HìB³j8‰&\ZZ\"ä…sZ_ß¸|ù²®:úıd„7ÇWÛ‘¹ôôåõ-W$ëYLOßR$	´Şºà1Ÿq­1Æ…ónv}\'¶1…TU“q5©›U!vA€Õdl¬Ñ:„\0Ù:S”åÆÖ¦¯J!Œ‘$« g\"äû1¥.NœôZc÷Ö9a.Ë²ğ…s&DÔHØQYY%¦!<e°Ë}ä¡G^úŠ—êI…LÊ¼8ŠdsÎFï7 «—õníÄfQ«ıe½¬CÛù² C¡kš6ÅˆˆèŒ†û@L‰QÖ6¦Õ¤*ªRÓUubeb¦­$ˆ‘ADBèBŒ!--E	ÂÆ!O«ÙÌaÓj\"[k»0«Õ$‹¯˜Ñ˜O>Õ5]WuÆÚ²ÇÔmz§­µ’HÎy\"SÕx²^ÏWõjÙ,–\n+F#IŒ«¶ÎQÂj4Âj:ÊUYohguGI\nÿMa;<œ‹pÓ¶¹OSUUQøñdm>_íííœ9söÆõ9¿%¦Ùì`TÚ.ÄÄÀ1?ƒ=€4¥xñéK÷¾¬²E©MtZc‰\rŠJ×\"44öÖN¼ŸTÅú¤­›…®-C—İÓZğ\"aRf¥fŸ±Í1FaÅ3q¡ëR×…®‹ \0†€}QT£iY–››Î9Ì/–‹ñ¤a§°ÁER„w¾óšzÕ6M)qÎƒ>\"ëªNÉZTJ—–¡©§ë’ 1ä-N\n—œë\Z„èLr6ZŒˆQ€“®#1umËÊ‘†ğ>²@\0ë¶”ºi…{Y“1T–eYUUUE·Nl•e¡r¸Óá|Y–e–IÃ1A\0g‡‡Ï<u±/Ú¦!Uò‘¢—ÅjÍ¡{LÊªbÎá¨1„”º»šØÕ¡í8†Ä!¥.t!v‰cJ!v!t]èÚ˜Bˆ{AmF“$íè%æBclš6¤P\0PY–ãñx:G£j42Ö<sæìÙ[Ô£%óÉdbÔø,Ã]Èâğw¼«©õjÙµmŒ)Æ4P×õx¯8\ZDLú…¦kÛĞuúib!†”\"§B›bS¡\r]Ó6u×5]hchöNh!¤Ôg`\'ÊïH).W«¶íàà`¦÷bYzÍ&D”.6·ßqÇ‰­Ö\ZU¦ŞØŞÙ\\_3D6\'f\ZM¾G(òî÷5«Uèb1¦UtYtœar„ ChÛºíš®ëB‰§(œ„#H\"NLJ3“¨ò½S½\\ªï$ú^Ä˜˜S×µ)Æ®ÂÚ \'>ó-ßô\n!0ç3g&“ñîî®\n›\rf.Š‚…uN¤‹ª!ã¼C„í½3gOO×71öè#á†„”ÔŸÃ9“@îHå©`şüHıy&âˆĞ9g­Q-§jÄ¤²LM]7õêòå+ËÅJ÷§E½2oı®o1Ö‘±¹Í˜µ÷lœ=}úäëÛªe)!€ó.¥¤aê„FÕM_ü—¾è¯ze×…¦©ÇÓ1ÂÅŠ\r›4‘{5(ÇIziQÆ«²Âuï‰î˜i>Éäw™™…cŒÌiµZ-ó?ôğj¹r\Zu€f¾Z˜où¦¯…^)IÆtÍÊ•!c0Ö¿õÜŞÎ^ˆQDyr0ª*-]Œ1Î»/şKo8wş¼® õª®—ï¬¤¨ø5Î¢xÀ,†áù&C\Z5›#JQõ’H˜eTºtë”ûÄj	Rñ`H)ƒÕ˜C×=ÿìÕøá‚·AşŸ®æÛ¿åë„¹(+­ƒtVá}!ÂÖ:$ºıÎÛ777Wu£3ı.t†Ìtº¶¶¾öÚÏyÍg½ö5ÖY¡€w>ğû}ğ£ço9­N¨=0(#‘P‹LµZ²ÖX«d$}>MFU#Jæ‹ôbÈËt”¤÷MõCu½úØGyòÂÓœØY‡\"9Bñpµ°àŠÂÚÂ9ïËj}}kUw³ƒÃÉtíğà`µZ…&“éİ÷ŞCÆ\0sQgÎœLÊµµ\rDèº`¬	!t]÷ŸßşËóÅÂ;ÿ³?÷‹ŸıÚ×|ÆgÜ?ÙØO§E9*|a-! £°jY`‘%1Q½ÇypI£	X›õ,Sº¬…X¯š>ôñÃıCÆ*OŸ2\'kMcìz³MÆ@S­1X~<®–‹e!†È€†È¾*ËÉx4&Ó)ãªöµã”~ú_ı´ú]Q@ü“?yß3/}ñ½~óÔÖt}sº¶V”¥sNAõ”›Ÿ ˆaíh)73ĞsàcHBBº®iëÕ²í^|ê™º®upÖ)(2wÇuşY”ãj4&4€˜b±óOlmŞMÆUÓ†÷àÜÿŠ×\0ê‹.EYF#kÈt8ñ¥‹—~äŸı¨sNŸHµâµë×ßñ»¿ÿY¯~åÙsg6N:uúl9ªœ÷ı›8€wY„õK¥´$ˆ1IJ¢[eº¨&²®kÛnq¸88˜ííÎöv÷™ÙYKpôõ@@¸Q§kªOCDïË¢¬F£±s³ 0‘mºö_òfc¼ş7DXVcNÑÔMİ¶á÷ø½ÿôk¿®Ştı)Ê²	Eøp~øà‡zÉò­½ƒvÕ<{j4ZçÉµëHŞÑRÛ†®ëRˆz®‹¹]Û6íªmÚåjÑÔõá|ÑÔíÁşÁ|¾X-WÊj1\n70ª±ÎüA\0ı†EY•å¨ôeÛu„ØÔ‹Ğ6®(Oœ8!û³½›\'3!RêfBûû»MÛıâ/üòüÁ#Äñ¢m|ET³0Ç0?œ_¸pñnI2Ûß?sş–éæfY˜Q@„Kä”Bº&hµRŒùOš¦]Í‡MÛ¶uS7õlv8ÛŸ5u£‚^\"òÖjã(ïÀ\0S„!foÜx~:İçıh4OÖ¬õ)¥ÂÌéÌ™[ªÑšM[7«e½Z®Võjµzëw~ÏÁÁˆ•¹¹ßv-‘\ZcŒ‹ÅòÒ³Ï9ë´%=šLÖ7ËjÄ¢¸ÂÀ)å<à˜bBìBìšºkë¶íÚùò°®ëÕ²®ëz¹X5u-œ•–Hûè]Ãz\"DŠœ“¬2À‹ªò®ĞU¹k›éÚfY‹ƒ®]\"B„Ú.v]xìO~ß?øgéxˆŞñÒx¨ELi±XíîíU£Bw«ö0îÍd¯ß\0\'I!Æ¶ëº\0,1…”bÓ¶«zÅ,óùÁb¾lÛYĞ;?$u˜²ÑÙÕW¢=–|€³\0Ø¶ˆx_F“¢¨¬µM³Z,¼/ˆ¨iêSi±X,ëúG~ø_üÙ?`Ì°¿ÓuíÆtıp²ó¤pwoo:­F£‘Ardô<BèBJ!†¦]L1\" ¤YÚµíì`V¯ê¢†üM\"…+ò7d1ÇPšˆ’Ë<ÆØ;_×Ë²(ëz!\0ãÑ¤ëÚ¶k«rºX®êz>_îíÎ¾û;¿·5mä7Çê2º`kRJêN)µM·¿8L½+«¢ğÎùÂcSL]Û.—ËÕªÖâ,tºğÓAƒ¨b\0 ÇEg®Ã¯*8|EØL\0V\0ÇãétºAdºĞEYø\"Æ¸6İdÁ¶‹1™Å2<öØÅÿíûşfn‹ô>yA\'5“$[“îº®[.V«ÅjU.GUEPzc+ÀŠ¤T…UJ‹@Š!%nš6„€@¤@{Õ[cpTUÔ#cO›âÑÒPNéJã¬[.ëzaŒN6Ê²r®t®1­êÕªîvv¶ww÷¿ï{¿ï8?æ Ç›ßFiÛÖûèŒRİ²(WM»X¬¦ã¦©›²,€Kƒˆ¥¯$1!Æ˜b%I×´MSÇ‡q]L1I2H!vÖR ?‹\nd•¥ú\"r_ÓÈúÚfUMb\n)ñîîë7®z_VÕÚõ7êU³½½û¶ïş>cIÃh>Ù­;–ëÎ»‚Ng5FNDRŒ³ÙÁæÚ´­ë0ª:¬Özç<³ŠšÚ×\"ùP,„%cˆº.xçÔ¬ŒUro–dDËğ€Y\"³XÌ÷ö¶q4NÆëë§»¶íÚ‚ìÏşÁÛş±18Pz^œû¥\n@Y]ÛJÏBN)¦dêfu°˜kÇ¤(ÊÎ\Zc,‘5d4Ú$*øE¥ù}l‚Òú¤ˆ\"À×GAÇL)ãÔV»XNÆk§N¿È qŞw]÷ÜsuïíÏ~ú\'~¹Û;²J¿0âù…?‰Ù;¿ªëaŞ×ãŞşl\\–ãÑ¸m\Zk¬³Á{\"ÓÖDZÕKvgîŠ !3	pŒ‰z,õM˜tÈş®!šiHs±1†Ùlw¹œ—å¨ª&EQ­­º±½½\\4=úÄ“O>)ĞÇW‹T=‘÷É“#â\"€\'D8qÛ4‹¥îß«Â¡ëpàØ\0@L±m»‚†8DP¸2uÓT}\nKâ€YE\në’FÏ÷\"dHİÅ¶iêªO&kÖz_TÖ–Û;»Ëe3;8ø™Ÿü™üàŞ7ÿ¯ÇQ tíxs3t]×¶ziRJlLJ©m»½ÙA5\Z…\'«0È2\'–®kbìB×râ”\"\"gòõ¨ªæó¹â•Ê¢Ğ°±y”4ß2±1¯4¡kµêéºÎùñşl¶\\ÕËåêÇô\'YâĞEãiGiã¹£ÉŒı7ÎÚ¶mÇ“qˆGmSJÉb–¦nGUéœuÖ2hF¨µ(Æ=KZ|*+`¾\\°pˆE£7S\"ƒb	•~dÈŞÃ²¬\"§ë×r¸»\'bW«îÑ‡ßßßëõÓxóŞ~SŒ¼^®cˆrÕ±°eÕ¬jÈÒ áÄ	R×uûû…÷JbI&F¡kê•²&ÀYÃ¬ŠJéBlêU:DÈÌÖÚÈÚ†ÈÉô½?p;ú\r›¶+\\QÆ®˜´m¼rõú|±üßø/Ç³Àä¦84¸9âz-Ö\0YíßõÄ€i4k+3£÷DHD1ãûûÚG\r!ZãE¤i›¶íôL\\e3sHe5Z.÷òŒÙX\n1zï‡îFÖ!õ¡L*×\0°ëÓõU½ºzíJ]wM›Vu8<X®šUn\"¢šg“oBUËQh¢åàÂ¦nœu¡í2¨ÿI‰—_8%Í2t‚YX\nç¬±DfY¯a1_(u! ²ğ”‚C†bb=lA„L¼³»û{e9Ş:q¶iÓl6_5{|ìqÕf\'ó\'‹®¾I¸ Aº™ª›œ÷„ DÖ993³\'FD]ÜİŸ)à ğ…^ş˜¢ÊcÈ|»åª!hÆ,Î9C6ILÌÖØÄ!1$ÖU>„~lë¬]»»»·7;\\Ì›Uıø£G¶CRúMÃîcaÖÃB«ÕS†¦\"…ÊQ5LóÅd:],æ*¥S‰\\Ru_€½ıYÛõ¯æ£5\0Eˆ)„Ö8Û†.Å„†¬±„&„®ã`ˆB…÷ú2c”r•õJY°\0`w÷vó£õµœ­å¶kşü];Â_¾à&J>†·Èob×tj¿3Ö&Óùá§”q²ÌÀIº.&^t]7ªÊª,sÓjŞÔW·wœs„¤}(ïh4\Z‡ĞIÌ\Z-C˜˜	Àš>ŒÎä8\r\0+ˆ¸\\®–Ëöp¾\\-8¾0ÂÍ Õ›ŞÀ>«/øò*lkA\"Ä\0U5¡ã¤€u…&î31F¥÷e\"HÀË¦%2Æ: hŒ11¶Æåî)Ãœ4S‰…sÇ.n\0ØÂMRâ¶m»¶\rm ¢>OøÏÓÂ?É©ğÏ]WÂl¼õµé²m[aBOÌ³ì?B’pŠ5§cÓµ£*ú²h™»Ä\0tæÖóÍbyıù«º	k„9¤`‘˜™3¡ØÌw@ƒÄÇØ&öàğ€…\0¬ó¥/¸­ùæÍà¨dò&o>1İLT×eÈ!c0¥˜bdç]Q–Írš6ÅD\"QM	)µ!¶!m¹û³ƒ/}ó—½á_òÌ¥çóù|ÿ¡?{ğ£~(´z\rŒ÷)Egígç]œwDºı¶»Îœ¾%ÅtõÊsW®\\~î¹g‡ Š¼„ôÉ—ÔÆÉ\\àœÍÌ\"«e\r\"·ß~ëç~áçmÜJÌEQZçÈZÕm3B`fA¢»{_ø%oø¶ïø¶édê\\!Èx×=÷Üy×=º‡Çãûï9ôİQˆYa()Å>Í€\0À|Æg¼äàà0±9$pÏ<ıÌ1´åQúç±8€£åTn|ö3d\'ÊØÖ¿FÖ0àİ/¹ï‹¾ø|ğA1:ç\\áµ4EAgmŒÉ9÷Ó?û3„tá©\'îÇêıXaíîíÙşl±8¡›Œ\'×®okSÙ’=\"‹#q/\Z ¢E½´çn¹5%|îÊ•ÃÃ;»;Û×ö$O¿nâxÏ<cÀœã9ÌGqäG*sÛ$,©âÄW½|8;˜]ßû®¿ıÖûgÿ—·Öç¼‰!+_#YûÊW~ZŠqv0{Û·¾µ,|Jiogûì™³ËÕÂZºvo,Y¨|ÑÆLNKÌ†(†vˆİ±Ï\\z*F`¦-f„è‡ÃëX)#ÇÊ·£Û+/lÕ¼ğIfNZl„1´µ±ùèÃ”eñ¢[Ïï\\½–b|Õ+^ùş÷?Ø5­*,¼µ¯ú´û»®û†¿ö‘Ô¶5¶Â—Ÿ»\\–å1¤tbDB3˜Ñô¸á#5PU66¶q¾8lšFä¦Åãø+\'ÇV ?÷¦~²Ug·:ı«—õë^÷šqUµMı‘>ø©¯|¹±.&~İç}î›ÿÊ›/´š	!ŒFåSO<1Û™¡c)„¦®5ÆS×d2-ª2I2d’¦ùô~Ğ‡‰™×¿şÕ]B”Ğ%@Ú}úÆöşöñØ¥cè\'Ùàõ\'½JÛËôY€Ğu7¶w®]»Öv-3/ËªªV‹årUÿĞ?ù¡ÂS]!Ä^óÙŸÙµí{ŞıÇÌñˆpÜ§œç’ÚZM”H):c»@[Œ@‘“ò>—ÍŠÖ6NÕM­©ÆX“>ÉùN½ò<Ÿ”­Ç,\"!uj_á½İ¶i¼ui¹X;w/=si±\\~Áë>ÿs>ïó„/<q!„nhfS•æ]!óÖ@Ú¶À|RËİ\ZÒXæ!¾Ä|ÚøÅç^~{Œr8_<ÿÌs‹zù‚?wšñº¯Tµ}¼ÀÙ4Tä}\'*\"Ã\"UY†`gwW¿Òïø¯ÿù7ç`vPE½Z]¾|eÕ4—Ÿ½<°ôp`Xe\0â¨\Z©ÁÅræ:RZí).›úÿeïOã-É®»@t­=DÄ9çÎ9gÍUª*Õ K²-Y–äAÈSÛÍmiCö3¯~\r6~\r=ıšù×MCÓtó\0²\rrc@–mäÛ’%kp•TRÍUY™Y9ŞùL±‡µŞ‡µwDœ›UÂıŞ—÷á]×OÎª¼yóœ³cï½Öı€ùá¿/›úâù‹ˆøÚ•K÷ŞußÎÎÎå+¯9ç{ôñÅrñÂK/¼õ­o;{öüÓŸÿ¬kÛw¼ãİ»O=ı™Ç{û©3Ï>÷ô+¯\\ù·ù¤²oQLöÄİ!	 ‹Ş†óŠYöÀÀ>«á¸›–çbŞèİ×rgp²Ä¦ìÂ<(’/ípàBÂ\rIƒ]â=ã ¥VVô‚/\r‹°ûÅ\0Bwék¿Ï‰3,ØEbuWOŠYRÚ¤0R¥Å*·€!³«¯_F\0øgÿä¯ooï0s]×k“µñxB8ílŸb¦élV••ÖÆ_×ÍÆæÏóQ5™Î¦1D¼-Šÿñıü¯X«3+Š‰İ+wH¼šGI0¹ÈªZV3¦?<¨1îØûØŸ2À üî¯ğB•:‹:.a¿”MÀ\nu×Êç›Åˆ A+6j£_h‡‹±Cê^X÷\r“CŒ$q’ÂFQZ)¥•‘„ùşdEŒCÇF¸zõ5\0³ùì‘·<jŒùâ³ÏŒGã»/Şs{÷Öå+—ºÿ-UU]¿ùY­ô£¾íú×®ş{ßBÏ¿ğÜ©SçOŸ>éµ—¯\\yíá·<ŒZëDcBÕ]#Ì\"V\0¬;uJ¾\\¹÷ÖK½s^şàOt¦ıRIRÒ’g©ºJ2¢˜c®VÓ2æKi®r˜ò‰Ş“bvP«uaò:%jXvªˆÌSv7ô‡jßRs¤?ü¿ï­=ªV\nó{{ûO?õÌ§?õpï~ÏW>şø#€¸»»{ùÒÕ×^{İ¹€ª7M4\0°±±Q×uY–[›[ÌÔ´µ1z}}ÓX«ŒİÜØÚ9uN›ÂEUM˜À9hÛ6L§ó¦vmfÄPU#ŠŒF¼™H+ %ˆ8BN¾ÜCêDšIŸ:Ş=æ‰|¿»“sÄrw$õÁÉÜ™®S–çÜÁnOˆı…8 2÷ùFØ…² ÷ÉpÃåVjå\\M(Ÿ¡Éİ/»LôıMÓ~ñ™gÿÊşyTÊ9÷ò+¯ıí¿ı‹¿ıÙÏà»ßõğÿF5ª.¿võ§ÿùÏ¾ómO~û·óÇ?ş[ÿşW?±·w`¬•×©à‡şÒ_PZEâ{îy`{ûÔáÑáúÆÖé3ç•töÌk‹Û·o\ZcËb¼·wóğğPëb¹¬¯ß¸^7mñ`ÿğõk·s8(PS#ÊéÊ—cŠ¹ÏHî¼”“£kf\'rŸwÕ/Õ u0ÔëòK»Ó\Z:z2öÙ#İ5Ø‹Nuwç@\nÉ·;K…*oµ^§.ÈDÍØ-ğ\nÂšR³ñC_õ)õÀƒ÷¯O&?ükÛçù§~êÿüüÓ_TJmomşÿøï6mû3?ósîûèÛ¿ıƒßû}ß­´:88zæÏ-µØQ\0¨ÛeÓ4³ù,§µ‰1RğÛ§ÎNgÓèÜhsÛxp°G1NÖ6½Æõb>PDàœSF1DP`´I‘ÄBÓ¿äI]È¤XCä.Šòú1ÍP:/ö7ÓU(‰øwVD¨IÍ $œÉçÎ°:©çáÆAƒÆŸW¶\"11¢Ò°²‡1\'¦qİß†ˆ§Oï¼íÉ·¾ıO^¿~óÕW/à½÷Ş]/Û§Ÿ~æxß©Ó;¿ô+¿ñKûµª*ÿç¿÷ÿ÷ÿãÇ6Ö×ö´ÒÖØ„2\0CØÚÜ¾pî\"‚QvQë­Ím™ÀnnlzZç¬µ\nkqì×êº¡Hˆ°6©v÷Xa“Î>Y»ƒ\n€Q¢Æ\'š„IÜCÙ´~ø1	à¬ÉmÃ¸(•Ò\0Rª‡»Ó4I´¤N¦AÃ~EÌ1…­|Ú|GÅ¡CnTïNû!¬ñæ€ô0ÀrYÿ™¿ú=ßñËç¿ğìÇ~ñWê\'~æù_ÿÆ×ãû|ËƒeU:µ½XÖ7oŞ¾}{Oœ´ˆùh:³V$;}ÿ#wá–56U\\\0¦(%ò,G 33Å–ó)RZEµR¢Š3ÆŞÙ¼}û iš¢(y†B\"ÓCD\0’T§L	ÒâõegÏ„‘ÿCHùƒ˜àı7æ_wÏş\nÿ,Í¥Ò¤“F¶oD”î\nN\n€œ)\'?ˆ˜SşíSÍ”÷˜«Éè:‘=¼@IÁ×ÚÇßüø§ÿÀøQ|ğ›¾á[¿å‹z¹6ß{÷Å²°‡‡ËeMLJ2	QîÒt†È*\Z\0×$ĞQnwmß6)D‡X)zf:<Ú×Êj­96eYc‰ˆóãñèî‹ç^»|]Ğ_ƒˆ1ú2şBTC7I’·š¼\rR´Ü Àylˆ;¾?å«nØ\"a¾Š2¤Ù§Jó ï`¢ac²ÚŸä	èğ¯í2d‰ ó¹»î°—®ws}]ê6\'b>< ç\0bQØgyöğğøÉÇyü­¯¯¯Å§G³µñèî‰‘^xñ•ÙlBD…ÄlPuáìÆh@=¾€7®Lšå¼YÎêå¼YÎÊñd¼¶BX.¦®­—óc¹·[WOæ‹ã¦]úváÛZ\\ñïÜÚ^ßØÜç¹®`û?è’î¤~ë­;-Æ‰,Ïyy©É¶€RJìs­?ŠLeåúFÉzsbñv.ßƒÁq—\'¶q)Í8¹oC\n»‚&Ñb0Û}k´Mf+ùâÔ:=Ìƒ`rÎÔ~6ÆÜ¾µwéÒ•ííÉxtıÆ­ÿíıÈûß÷»ÿúßøûÖZfö!´m+F6\n‘(ÆˆXk£µ¶¦Uã¬ş\0¼J©j¼.–ÔJéÑx\r•¶¶rmsx|`İÛÛÖFÕ¨uÁã¦qDÌ¼$¢‚ì=wŸ¹tùfŒ^ˆX9ó]	N‘CŠSæ`¢jÈ@Ãro0öÈúĞ”äÂ)u„‡WO×Ów¡y©Õà®LINÌœ9O]æ­Jû*¿\"±ÎÊ[‡gûj°«3ûì¼•á[×ÀåûBÈãÚM­ÔîŞÁGş—?ô£ÿb4½òÊkMİ®¯¯i¥D:fµVÉ²$‹@kƒ£Oçòb979x†‰@\0TÕ8Fï½—í­ñxÍyw|<İÜØXÛM§Sâx4ÿ¥â¨²çÎìMçu‘™(Æ.âV!‚ÖAHÄ3`P€ÉÍ KSXåÊ§ òÇÆÃŞJAOCã$L£h!&$SnI¥NÆ]fÓ†”\r*S\"Ê¦SRïñAÛ1š¼2ë6cFUQÚı³?ÿk¿öÉÏ|æ)ç}Y7oŞ~ç;?(© bú…y¦Êá#bºØéÌ‰¦f9›llËÍ­µ	Á Nºëü=e±§Ğj[qÄÄeYt¾ §v6\\à:qÌ¡‹Ú–ÃY\'èRP’ßGIÀ‹°:aF9çtŠµÏ|I$Wj˜¯ØE?ä s)WX‚êEÌ!EÁêì>!“r/ÏÑàº”äEuç¨tõşæd£l6‰3z1t(\0şĞıu•*LÁ˜\0Ç“1`%Ï¬D~‹bp„€Êh+ÖÁ\0NŸ:;YÛĞÚ†à-Œ±Æ–x²¬&²5×7¶ƒmëN½§®kçcY-)§³¢fÆ#3xïÎŸÙ\\,fM»Æ¬÷>dL»½J£J§\r«îe³Vz™	C~Îåğ‘áPáûŸ\0]û›†§\"Ÿp¿89IÒZá‰ê:âÈp-Qk#†ÿ€¢ş#@èRŸW~l^§>\nÒgì“tßjÍ)lP(`Jş³ØåicÒ­×&ë¹¯b¥M5YómÃLE9Ö¶ c$™wi•*¼÷UUø0òâú\"v’1jM§w6@¡.,j¥™ÄÛ\"Má¦ù­Š/QÿÙ*-j2`Âî8Yáyr\nËéx\nÇ)E+Ò¾Œx¥ßC¥Ş î’;š›œÙ’ÂÙ¹èŸ‹Cj4£T¿˜ªñ„`w‡õrqÎ]@3rìè-òiLy¦€ %\"-áí½ë;[g‰âb9—¡D\"ı™Â˜B)UeğŞ1kÄj4¦HÎùùrYX=ªJï½¯Jï\\ˆ!Æ ìÕ­Í­õ£ã™ÖÊ·>†ìğ\rˆÔ¥2SdHSìºé¬2•\'ZpÅÃ\0»a<’“¦K);B}Ã×¥œç#¡K5ÖSb	‡ˆÙ7ö\r¦÷!HºPZVòÃAŞ1æXFîK6Ã)ä`Ş†İ¼R†¢Újc’‰¾Ğ¢“Î	\0Ö×6å£¨›:RÜ\\Ûd€r4ÑÚŒG“¤-›\\Q{€¡,\nB,ÚÖZ]¦ô¶mµxß2¨­ÍÙ¬f$ñÆÄÄ‰¹›`¥€zÏ›~~–Sè¸[y¡ãäÒS\n@ÕS¸‡»\"åĞrùÜòªMIæ@q7×Bà7ötÿşÌ”{»V5õï}ßK¨t·f˜û]Š“ˆJ‡Qš25,­(EÕ#\Z­•R1„î9²Öe%í’\0#üS\0DtŞµŞ•E‰\0Öİc«ÁDMÌšYGcöF[kÆ£QÓ4eYxçkcYJ´\\QJ«$ÿ\\ŒTRğ\'% «ï‡Wiœİ ‰ò!ÛÕvišÕ§¸Zû\'¯ÛAÅˆ¬òúó(—şA¸JÂ—0ø~¼ƒ»ßÙÕİY‹æ†¨{¥Üˆ}<vÌ%©­ÿºOAu\'¼h¾ÅfYŒ-Ñò\0`CÄª\ZYc§³cÁ51·mˆŠuŒ´ÑJ32ÇâşÅâšìš…Ä$2ÅÈ1F/BÆX‘Õ3SÛÖé¼’sŒò<6ÃÔı…Ä+éŞİ›C@J‰-ì½D”ì3¹³Ñö0dRJÊ2ã~\r á“¥Aßrrï ÂÌxã‚ôsˆ¹KK?AåLQ¼9\rªƒVóIŞá‰*‡Ì`l\nJ$\"D%±$ˆH1Ú¢ìv¡Ñ¨\n[ìl\"ŠÓùñx²YUckD,ÊJ)cìr6Ër‚h´j‰uÓîÚ¢4ÖÎæŞ{[–X×RÓUUTÅrá|h#E\"–‹X<ËA©ÎÎO)¥»Ó•8`¢¡÷šÛÌ°eÆnšÕ±W¨»GÒï\n¬I·#³³¹wäÎİXi+¢ñ”îÑÖÜ=$y`¯8¢~@¨µFÖ9=%Gj®ÎˆuÈÁª.\'C	eDU¡ˆbô(ÔoLŒÀ\0Àı>&ø-*c¬ÖF+Öù¯X£M~?Lj£××·¦ÓÙÆæ£ÅãcšÍË²Š‘š¦AÌêT¢I¡bdŠaø¦8“é{RdÃ\n`–{1U€¡!æ?8lÌòèŠ»‚=Ëı÷h5ªã7H$d_ãJ³øæ|Ä$òÔe°¥s´³ÄÆ;T\rˆŒ*‘Û§¤Q Ğ;Ú*F\n>hÃ¨°4U>HmQîÎ§GÌ„ÚT£Éd¼^–ŠPiæØÁô1ï›àƒ¨–Ä©Ë»†(\Zc‹¢ª›•¶5jJ¾!I,ˆ9±œ;æ]7ø•Å\réxQöOÌ\n.ÖU’Ù‡€\'È‘Ë92\rSÅŸx &¿ÜÍrÛ@‰ã—œfzDA ¾U-\'³÷ã”ìÈ\"T—Ì´W«µÎUK?ô&&ˆ„¨’AW\nÄ#\nÄ\0ÒtR$ÔJicTZ3SÓÔi	Ÿùâg.¿[ÆÓÛ§Ë¢’¤‹c\nÚ2sNj-¦Ö¹†)SYVãñÄ¹@¤j…ÊhÓ6A£Q+ÔJ+Í*i»C,7÷¸Â9îÆ\r<l¼¡»Á:€“{ŞcŠU¹‡`&1qNÒÃîIgd6\'\0U‚sfçù,±HöÊŸXâç*ü ¾¢–×†0±#	ˆ²._ÔªSæé[œ”¢Š#e*½²ÖE)Qª|ˆÖè´„û»ÓéÑéSgÏ½8ª&Æ1\0F¥¥GŒÁwQÚš	@YPLŠx‰h›æ0„¶ªÖF#jÛC…JkàåÈå”	ÜWÛ½%ñú\"o·²ü»J\0\"¹Û…ı^Å<¦Sk{eÈ`êÛ\r°:$õ7%¬2»û®a…Úƒ[àŞy@`[9P‘¤¥0Å;’]~7ØC(OÒ’!x::H*kÌòDxá]HKxşìÅÙü•ŞØ<]”#f¶E	9‰&Ó8-d9+4¶¡±¶(‹qÓÒ((¥ÒÚ…\'Obœ\0R©e˜8ƒ•ªùUùPª`ré˜°\0±¸sŞ‚éÕn7dH\"b–1É,óŒyÀwÜÄ8TjŸ :òŠFzcñ27VèùÂê\Zs@ Äb›ß÷°İäIZE!Ú\0U„(â\"–ŒâØÿäè=Fr\0.^¸½o½o«µ6(‚¯ÿ 4;}üIÙ°·•ì•(Âm£´x‡k¥™In»Î+s¼´ÂdÂ\'¾nàŞqß;‹íälœbA)u¯ ó½;—{DPY>·2sÏ·©DU0æ¡#%z`Ú-1Æa«Öïr–ïA”(€Aw‹ Ç /ÅRwdµMÇõ\0ç“ÚJÌÀz&C2Pb‚ÕÔÊ;om!Q«ÄÔú6-ağNV¸(*fÁ[‹BKBe˜ã	Xö²çºÇ¿‹wb_`îüsÑBñÖÙgE\\´­RVñ÷£bfN˜\\vã†‹|âİm?ÀÃ’Å`‚É¤1J±2Æ0Ÿlë”R(RÀtîÇ®ôŒ´ò¬ª=pi€˜ÈÁéªMŸ®ˆ«L;É#’™%”)/ZMq‡‘wŠ‰\rŒ\"âò¾E]·^\\™¥î1‚O6¶eµÑµEQÆ*Zæ˜”ÒÚ\0¼SJ+m(F&0¶Ğ>\ZmßPyè½>\"hÈë\"†fò)ÖÊJPˆ1Y¡”ò™òIb¢¹§\0&±(ÊÎNØÁ+=Å´§wg‘c$î¼ğ{>q®¹;\\Òó‘ÖÁ+Â	å@¶GL¥ñ÷ûÄp—$Ë)Ó0°ï*˜b@@­”µF‚„P)ÑÜc¾5¤ÍÊ“ŠÖ5|´‰lQNÖ·Ê¢d¢àìec¬23µ’(JWNä)_ûÄPJ+mÓSÅJ’BŒ‘+ÄQQ®MÆZ©èSfOë}Ó6âVÒÕœJaò\rgê­Sb‡PG\'\n<A:ëJß©«1q0>ğá0é4òØX(SÎ’Á;\Z»ÁÙw¨«³YèßãIrwËäÿXhmŒ#A	_¨ŠÂÚcˆ`tY”ÒTgbll9šŒ&ëB>câ¦­Ë²ªª±,›Ä[\n~\"ø<Q”ô€\\ósŒRù\nï#æßZ«ª*v¶6«¢X,—MÓÔuÓ4­OëœïjDõÂp°7Øz¨{g€=(eüŸo¢!\r‡ü\'|.T¦	`R›\rä®¶îHHÈß…pL×ô Æ!gkp\n;‘Y±QˆãõQ5:Øß‹ŞSCmÓ\Z£Ë²\Z™*FRÉ43a¤*ãW\0Ò0\"¢s­è3ŒàİBÅDÔº±í&i.tĞNA¬ô|QG\n¨pscıÔÖ¦Uj6›_½~£ijI—ZL¦¦Ê\"õ*étûŒò®îîi÷‡ÉnˆÀIOİïhØxBX.Eoş\rJ¡Ûp\"W[pÁÒÁªL\r‡Gz\"—ö&{ĞW\n¨nâØov\"ˆ!@¦3‰a¥˜A+$€ºmõÒ\Z»¾±QV£´„ò@Û¢Z¡õ \Z&]@K—Ö2Í!\0(•!eæşW‚¶kÚå²•ÕÚdT3ŸÍ®ÜŞ],1„tK¤Ó˜±,½•Éï‰ÙNhP3ÿ>TòÇTF5;»U†€^oÀšÈ?}Hƒ[?p®…Å÷¶SË¥Fœ³=p7ÒÈö¿Bìï™¯Gy–•É’½dDTmh˜(ÆQD&¨FÕÅ‹wñ|6ŸM§™xqö.¥¤Ïf¦èª[D4¶@€|ÛÖÆX¥Œœ”Ÿ˜c¢Üƒ€eÎ£‹‹ç/ÔõâÚµk³é,eÒek¯|<æA6åª{ÿ=CŒò_Ğ?Ú‰DÔU‰â¢•Q+È\0öxUî¿LŸƒï\08Òt\'*ôçh!$özá„}ç|=bF±<GGD\0!à	 Ÿ_RB…Qİ6³Ù¬¬Æç/ÜõÄo™¿xéy\0—^}v}²1\ZäÉĞÆ®mîTÕXì„#‘kk\0		-“ªŠ“ñf$\n¾£ØâG±‰Œ0Y¿üÒû»»òZct_0\\ÔÊ ÎÕ×êI@1PO|p«`ùøR?Êİ\\ï¬ì@yØï È¨œÕ÷I_ãô¬á´9áÆ–Sf1#2\nğMO¥\'±ó‡î}ì%ŠÎc”6)A1CL˜ÈÅ`»\\Î¯]»ÂÙ»xà­9+…áÚ7)J©D0×é<\'HÁW”Tğ!Æ¢sŞµw-QTÆàç¾ôÌôø8µÁ1vã˜DØ’ş<æ¤º\\ù©DænÂĞAa\'\n\0\08QLŞÉ\n¼Óhu:›X©À\'LƒV6î ÎL)WÃ›lå®¾¾;gŠ¼êš)Ò”\"¯¼ÖÚŒÇk;§6b¤º^Ê@\"éŸÌ”éõ…—.½ÀÀ›ë›eQ±-ŠÑdS)5YÛ•RâÍƒÉÛ‰\0c„Ìu\"fI½ŒÂ&%æÙtúéO|jz<Ò „ÜI™ävVÃ0¬;”\\«HĞ¥&àÉ•¢u«ó€;¾eeÄÑ¹¬Ìz{‚FrcäøÔC»]–IAoäC”…Ú=­®kišÌàİññÁtzlË¢°eU¬µ9ùµ@Ô®mÓñ\0\0ãÑ¸*+c¬üÅJi¥•5–réaŒE¥)x	C†H$ı)*tÎµmë¼$5½øâËûÙºS—e«ƒÚ˜,RÆ¡ƒO§íÄè<ƒfqó¾\r]IFˆó]Ä\'†B\"óGäÜn™ŸÌÃz_>Z:zÆ¬Cë+_æz+\Z(¸Cz(C–äiØ«ìÒÁ(¬İÃI¡­}»\\0 ÒJåh2Ş¸p÷=1ÆkW¯¤%œŒ×w˜Î‹¢MÖ­-ÖZ[1ŞB€2EŞ»ÚûÀ }mÓÔõÒyï%”ƒ\0®_¿ñâ‹/\'¾2¢RŠbÁËò¨®UàAcĞ281IN#C%şŠJ¬_¾DÃ†„¬‚#]eGæ)IèğÎ#xeä…¹ÄHéB:¼®8yvhÑ\nE±Sg Ç¤\')Ex$c8Deli´QÚxï1†\\wr	ŒÓããå¢ŞØŞ¾çş_xéó\0vn¯OÖÇÕd2DŠÆ˜Âb÷ªŒ‰Á#Gù[eî€Ú´‹eë|!Fn›¦m[¡’¶mûüó/ÉL’8!÷\0Jk‹½Áƒ”,Ñ&&ÅhvÂJqa$\ZÄ*àŞ©‚ï<«°oÌ{:Êæá\Z}ÃqD8«²Æ¬Cœ68Àßô\n•†´Òº“káu319Œ5FkÄÄ2’¬ké¬-Œ)´ÑÆÔÊh­¬AcŒµe·ÙécÿÊ${?	vGU nÛÖ\'ùñh¨#EAqs>0†ÈÎû¶­ƒ$Åà§ÇS…\n™%¥Àß›ìĞô¿Ÿ±Ec²Zš{& ê%Ô=gMG‰9éÉuröš„•\ZäB6\\v4Àd_‘œ$s”ìN˜ñ›5+¼ºã“Óq7#@µBÌá¡ù€Lş‰³:.u€\0°µuF+ÊØª°Æ2ƒs2¬˜y1Ÿß¸qëÖ­½›·v÷ö¦³Ùµ×¯O÷öö§‘¢!øt7’7¤\\ò€çÉo@<¡š\'~‰ó‚\'5Ñ<0>^Ñ¡ğP/È}ÂQƒ Ss†½+œüáğ|µÌì‚“üñ7$Òtzÿ“À‰‰«Ï¬ÆİpØ²¢®ê¢ÚÒ”<$\0~öß|äÖ­£k×oÍf³ùl¾hÛV¼ı¤ÙoT\\1ŠXyJD@6ÄÈ†]eI_7\'U¨rÃ—³AÅ|\0eCrp‰Ù?¯‚;äx`õÚ_{ıÚÃ\n÷FƒÎˆ`¼\0\n+Â½7wgıòş‚x²~îO…ßáJ.ª?‡põÇßÿÀCœ§İÙ’	x óêj\'Î¹Xjøé0Ÿ LğÀ£ih#8è´xøÁ¥Mìöeîš™xxÊfÚIò-Ñ«ãçÁô`°ú†r…~|g€CåuºˆŞ©û¤iòªT6ÂhíÉ›V›Å7è˜ŞÔğæî\r\0,úÍ	l)òU”¤î1~L>N,„ÏUƒ‡•µ™<F(Ê°WèC:›\n\nZŸîƒ˜±™c3Rî0”Á—Ú€öKöÙÆäï;taÊú±“î)RBDFëşÓGH™=ù…›ØÉ½iPÿlw.¾Õ±¯‡;.<fÆ0¢êÉc÷Ü}ŸÔÇ{3R]»ÍHÕ	1:¤Dl…4˜ÃõÔ[<Á	]iËî$ŒÂ…ş›œ3\'&À+z¾UY=wU¬\ZŒû‡İ!~R¢$q?×ñîŞØ\nO¨3ÖÊC;šÔ0uj¦•a5$ÄñË˜ŸtOÍÍİ›¦sœÔJõy7…LO½Êø:ñ<Ö”Z“è{ƒA*É•&\"9œÃ„;jÇ~ÄÙllÀÃı«ëVkPdtR\r¢%Kº”Ulw¸\r˜OÔİ³ßí•ê|ÁpÅç2õ…İ†€jıc¦„·ˆƒ]wb§&¾öv8!¨wÌwî\"ôìÙÅ‡8Ê÷ßQ’ID„,%iÚ)Y*¢8ôÚO®4^û[êNğ—^¿w¸ónëç«•&Ø£}mÙËPzÅ°¬ízêpà;ùSùè(Y2¨ù»’RŞx–[(F`&Å:û8à€Ò=‘i¢ªd0 A‘¨PE’·`VÒôò¸èQ+î¸oVİ£$ïÈ.TBV‚5áÀ3’•°`V^QUÎˆˆT*¬îiMwO—`™“WúùÉÖZ©ÌÑr“z*SëZbâHo™’&Å”Ö“‹>y$3ñ ‘€º£–y\0¥ĞŒÇ“ÉæÖ©³çÎ^¸»Z_«F…1&†°œÏ›e=?<ZÌgÎ5‘<9ïbŒÑ×´®mœs10Aì‹Ó{î¹/©£ndÇ+Ú+^eÇÆÁè”¦]ÇĞß%—ëp	Wúû´0J¤uÂ%B(©4P*ûxuïÀP-/ÊÆi9…,BæÃZÌ@˜Ù¹¶‹\"IùÄ\"ê†ÛtŞï2õ¾Ë4ŠaR ÊbtöìÅ‹>xşş{×NŸ6ÖF¦(a¾Ú­cğóã£f±€åEc”Q¶(”ÑŒ@1ÄèÏÌ¨,fûG¯¾ğâ/ÿÂG\0î½÷ş&E¦—9’uU\\ÙYØ­Ì¸OŒoT÷•œ$©¶,ÊÂ…-­ÖÚ\'#H¦¥ÁHNy¿\'H+°jIÚİqØyÕ¤1*•crŞl«Û‰Ê\"Eï}Œ„€,É<ŒÄ¼—\\±¼á§Í‘ûdXØh»µ³óğ“O>ôä“­-cŠÂ£qµ6®ÊÒÖ\Z£­Öâ^#U×ÕJDwëür¹<<:>Ü?Ø»µ?;<¦ûyxscCÀš?õ~¿¾ı¡A‡La¤jê/Ÿr)ö4¡L†ï¬ò¤ÕË†¸‰O­•\"¦à*µ¹µ}ÏıŞ÷ğƒçî¹k´±¨@&®½uõµı×Q©j<*G“²ïfG‡Çûóããz9ÎÁ\nTb‰ÆYyß9…$#âÈQ2Öjc•RÚh¥0Yk:²„„‡\nÊ:k`ğŞ·®1ÆÀ¢ÕÆ\0³1¶Ûw1’R!¯•¹pÿ½_õ¾÷<úÄc[Û;EQ…­\n[¥µ†‰\\ë¦³éÑááôx6=:M§Î{ŠTUÕx<.Çåæææ™sg···ÎÚQÚPQn„Öù£Ù¬išÒZfh]ÛûÎt^Wp¢«èUq›(Ä»K²\rPö“Ò\Z\0•ü@ \"fc{çm_ùÎ¯ıú÷?òø[«É¤nÚeİ´­kZW×uã<2[k‹bûÌù3Íréš&Ï³\0‚!úÖ5®mêùb1N÷önß:><¬2ty_Â½…HÂê×‚$+9QE|¤¶&É÷„Á½ˆI‰{•ÖZFÜM’’~óke5ºïá‡ßıõï}ä­ŒF#­uUU|õõkO}ê“_úü_}áÅÃİ½‚¸ÿ201É±>\0Z;Œ\'“»î¾÷ïzçû>ğşÇl}²µ±6‘Dñºm§ótŞwïCU*‹.âa#«É…48?™òá¦¢VJS$m‹¯ÿ]üßùû{ò	i6_´Î5­›Í—óec´^6ÖÆ£ÊJ›)PiêD½â]Î¬Ô¤wk[·˜Ï¯İ¸şòó/¾úì‹7¯\\nê¥Èœ:~tÒQ\Zmmò\ZĞÆXù…ÒJ)kŒ-l>gUçÂÓ]º!æ¾“m\"3û9²RæÌ]ßÿÁo|üÉ\'Ä^<ÿüs¿üÑ_zú3Ÿ;Úİ¥ÄšOB›`…é3\\äÎ#“ä•Ö2>TJoŸ9óî¯ûÚoÿ=ßñØc‘á+zàşûêG Ğ£3È«³\rF&–”oÈáD°*+1¦0¦|÷ûßû\'¿÷O¾í+Şæ½wÎÓåk7¿øü«k“ûî:·³½¡s`9QÜÛ?xé¥WöKW^}u÷ú­ùôx>›µmK:Íƒ1ÆX»¶¾¾½sêì…3wİßÃ>r÷}÷noï\0€kÑ…¸»·ÿ…ÏÿöSŸüÔõK¯µm#\ZqĞZ—…µÖj«kË²,la´-l¡µÑJV3İ™‰›Š\0ˆ1R!éh2n#ùìw=xÿ¿í›Ï;ˆUU>ûÜ‹?öOşÉóO}ƒ§CôD¤•\ZxÈsuÂ	CkêİºƒFEY–#£µ-\ncŒÖZÃÉôÎ<úäW|×w×·|İû\0xàa\0©¸¸ÛX¹#ì‹TD%6ìA¼µ½ıû‹ÿ÷?øŸü!@!v›•Äb–(DÒJ¡V/¿réçÿíG>ù«¿¶ó6ÇHÑG\"¥°3šì<xFºÚU‚bŠ¢ÜÚ9õ¶w¾ãßöM>ñ¸Vªu.Æxx<}ş…şôg.?ÿÂb:%Æk5*¬ªrm2•£¢¨ªr¤„odŒÖÆ-æö…K²@$ bˆTÆ<úğ;ßõÎ­-b(ŠâÓŸùÜ?ıÿğÚ¥W‰8JòfÎÕÀ…}ô•hDJ‹µV¶(Œ5rÆkm\nSHôp¶ıX™Œ)¥õ¯ü—\0zË[c,iXY\\Ò«†ÊgæáPE®}¥TŒ´¹sê/ı×?ğ-ÿÑ·,ë&ë±³‘oñKÏşäıÄ3Ÿúìr>QèŞÔë<™xÛ[éVåiC{-9yŒ.î¾ï¾oı½ßşßôÁÑdÜ¶m ºqëö¯¼:?N÷ön\\½<?:P€kkë“ñZU–EY–e¥ÕFk­QéôJ™iLªvÎœzô‰Çîğ~£hÊ¢xíÊå¿÷wş§ç?÷Å@(^±ºd‘‚tv©¨ĞšBçzØS•e6bÈ–×i«*D„$•líì*=JâS¿!“Š·tŒúîK\nú$¯ÊTİFºh”¶ìOı‰ïısßç|hœKvk¬Ğ5·öö>üáŸıìo|¢Ï@ğ.xD8‚ó>]pEñCS¡hc¸“Ü1¾±3‡a0¦@4<öØwïŸ|ûW½½u>Äxs÷àúÍ]Ôª,…èëv~t|´¿ßÖùAZ£6¦¬ÊÑx´¶¶¶¹½yêÔ©SÛãÉD¦â9¢–•RÌôÃ?üc?û¡Ş,æ¨ ¸¶Ãh*y¤t’F¦êWk#U•B•ÜÇò®”íÈœ¤¦RVë<Ôô@2¾:TH˜Ÿyê3\0o}ëÛ¼w¡cjpò\r´Œıüº;Ğ4êíSÿİßúŞõµï™/—R”^ºvıÜ©S§67ˆ¹°æÚÍ[?üOü•/<g…=QH ±¨¹„!bòÁS»\'JÚ\Z¢¤_}ïÌ\'¨1«#Ó‹Õé³g¿ï/ş…oø¦ßåœsŞßÜ;˜.Ö˜²,ª²\ZÊQUU©IÀ:«@TË§c´¹qëÖ_û¿úò¿C+Öâ+\"—®µÖ\Z«´ÊÌUñìÆvİ|b“Ü¡²Ópm¡Rk@º2ÅìóÏ<\0ğ¶·}õb9K˜õ¤úüºÓY7P	Hëçïÿİw|õWÏ—KDÓÙ¹m£5*lœûg?ú_øÄg-\"Åà%¾>Ñ<Ä¢„ÒÕÇL1’`\Z$¢çîKâd™åZM_pç*qˆj\nìJ#¨‡}ë_ùïşŸ>òHÓ´³e}8ŸËÙPÅ¨¬ÊÂÖXmLò’…7²ŒI<ŒÂš/<÷ÜßúoÿÆW_ÕZ­”FaI¿‚·\"ÅH$	±¢ó‚mQE+úæLÇ“€WÂ#ñÂøE¥ùÒ3\Z\0ŞõÕOú ½w=A G\\±“¹d»­1e™ü…¿üç¿ñ›¾i¶X*D‚ñÌæ¦Rª°öùW^ùŸşÎß?xíZa´ÊÑ1ˆ\"WÆc²!¢HâßFƒµë/dDÔJ	òd‹Â\Z[–eYeUVUUUU‚vŠB82¡Yi­§GÇ¿ôÑ_Š‘¿êk¾Ú\ZS÷v˜	¸ìt²¦Üiùª²øÜ¾ğ÷şúÿLËz}}mcc}2ŒGãªÚ™X\nKö.jmä%)%·¬ŒÄUVF„R÷ä±a&Ø\ræF³D×8ˆÌŞÁ¾€¢Ô=pæêu½·w\02c+Ô¿y\0dÔ\nX}Õ»¿êßüÍ‹e­LgJ«³Û[DPXû«ÿÍŸù‰ƒóâèÍ1úà‰d	 #¢1F)’Ài@PL>Š´úì¯jw“6Ÿ;KâtL!…”ÄÀ‰IJÌ\Z€ÿåÿÄÕ+¯ı—?ôëã‘1ºn] (HoŒ:ª¨†ˆ=¸˜A\'«õİİŸşñiª\r•HêÁ{ç]‚—t#©Y²~XbQ”9¬šçœ÷^²$`&ë\nz¿“Ş)­˜Æ¥à§<ÊG€\'Ÿx”ˆ¶·&Öœ‹¼Cu£ü¸LÈF@¥Í·şGßò®÷¼›˜ŸùUïı÷ÜED¶°ŸúÜÓ¿øoib\nßÖ‡‡ûóÙñl>/¦Ëå¢^.ëºn…91k­²,!)»á.›OhùºédiG‰NòÄÈ©ÉÓÊ\Z!fjkõk×?÷[Ÿıê¯ıš­Í„½uZ#Ñá¥ëğÎã•R¿ğ±_¾úÂ+Û›kãñd<Z›LÆÕh}2!ŠóÅ<RÑGÊ¦s­k½w!D\0¶Æ±Õ.\ncŒøroÔÒ÷öÄ½(:›°ªÁ<¹gøïîïi\0xçW¾M+bôúú8ED1„¤ì¤|˜ßRãÉø;~ïwœ½páW~ã7¼kßõw“Öæ¹—^ı·ş9í¼wÍb~\\×‹Öµ\0$N,\nA©Şİ\'†Ğ4MÛ6Zi9	­µEY¦†w1ãö_$\nE•Ş®0Ìrm0d\nÉAy|xxıÚµ¯yß×¶†‡*ìÎR•<G÷”Vêú­Ûÿî#¿„!\0E\nmS/ëåìèøàöŞ­£ãCñû’[kcµP˜İ$Q²mÛ@¡°ÖX#Í¨6Z8º¶\Z†±whÄ;İ4»%4\0`­HJ•>„ñÈ<øÀÙk×ìŞ>0Eïœ8#©äpŠJ!E>áüO<>ªª¼ï}UU13(<ÏÿåO~øÕ/~‰!º¦ñ®%ˆ1ølSßÑ:ı\'±R\0Š‰‹eQÆ\ZmÌXëãRağŞ)iw%4l8îàìA’­>f>ç´8¥Ñš­ÑÏ|îéş›üá?ò]q(j]1KO#¬î±PJ½öÚ•—Ÿ¾]ÌÚf)!!–J,åäã•î\nÑîÖC€bÛºªª¤¹ĞF3°w.H5x\n‡²*†7ÏÁÔ\0ğş÷¿;Æ¨µVBeBØÙYGÖuÓŠÓH/YëããéÎöö»¾æİ‰X`Œı÷Ÿøø¯şüÇ‚kƒwQ.¿ä™\'\ZY¼Rov±¿ä&—ò\"ËÆPÌöW_`Åü5ÿË`\"ß›HvOv‚®µÑJ¿ã«¿jmm-fF<\"\Z­¥–Æ™J«Ï|ö·Ÿ}êL9&ÇÄdì‘İ¹\"â\"¢î$K¸l½÷Ö˜.ŒªÓÜ0ÜéÑÍ‡I=á/íÂ­Í²(ÛÖ…ÈMÓ0#Ü{ÿ…r4ºråš&†CàŞµŠªK¯]©›&Y0!ÔMı…§>OÎŠ\Z*†˜Œ¤ºØ\n¥1œ”T>ñBäÆ5k“5­GˆXeâÀ1LéVœºûù0óHs‡ÖÜ(¨|Zéƒİ½K/¾|úì™®	ëbV”ø-]2<Óé¡÷-SˆÁÖ*4\0Ê{hš6ÁÅ<&ì]Z…*ÕÓˆìW\Z«ªDc¬Vª&&$îyğæpEf×‘7¹£F¥>¼Ön4M+’³sg7¶6\'Ï¿p¹®J›ÄÙcbâ»ï¹çıñ?Š¨²¸ÙÛß½|é5”ñãt¶t®eæ¶­SHLDºœP+EÙÑ•òŞÕª.ËJYIó`<qÚõòNš¥|ŞA¹WJ	|ŒJùènÜº!£¾£÷\Zmª¢À\\B“d©ŒEQ8×6Ëi]/öO´ôÍıC™‡‰zM@İö¡ŞÖÊ¢ÔÆDŠÀˆ`#¤‰&[¸Ş5·s÷áî6êìF£¢iëñ¸\"ÂºqÆXçBÓÔÆ”!Ìßşoyñå×÷÷ö¤Õ¨Ñ{Şóî{ï»//ü0£ÕÁşÑí×oÌö÷)z¦HY˜ÙÌªs\ZaˆØ+˜³8»Ñ:\"4Mã\\[Ebh*UUˆ‰¨§¬@Nö‚“ÂÁ\ZsŠ´H>=>8Á™h~tä½§½w‡‡G7¯ßØ½u«mjŒ,×™óçŞûu_{îìyµgÎñ1(4U9Áï;’¢²iVœó‰Só>ğ5’™™+;m´2\nµ±6„XXÔ¨ºe½ÈlØ¾-î°hìÃc{×vÑVÖ\03›ÏG£Él>Cd­\'óùl2Ù˜ÍßúÈİû§·¯^½µXÌbJaY¹[‡ÜKˆ2¦€D‰\0f,ŠùnD,Ş›Ò¶wü½É@MñI6Ğ‰aÏaã¡T7Àzfd›WcLQ¢R œ\'ïÕuó¹O}Æ-çãñÈˆ6šX1ìß¸ñ³ÿüg¾ñ›>ğèã:ï}ô±ûzğæ«¯!–\Z¥ûŒ!¸”‹Ã©¨AT*_^sİ¶1­ÔhTi­Ñâ+FDÚ <1„=QÌ(aµêğ/,.…*OÆÒ…&MÓ?×şşîÎÎÎrÙÌçóííããÃÍÍéôhg{¼6¹kww¹p\\/·nŞò®U¦ÀL(ÛÜ\\ÛŞÙV.$æ…Î ›izdÓ´DdŒ©Ê¢SxÄH¨ĞVi->&Ş;Å(£óÁd´?^x ™’Ñ&e9eQJÊUÒÚ–EJ“¥w_D`ÃşŞ®Eln0Q ò1z×Æµ2ê·?óÙ³Ï®MÖNïœzÏûßÿïv÷‘É5QŠXEŠBëNfËD’’!H* â.[£°…µ6Äè½›LÖŠÂÊ<’÷Ñ	Ã¶(Lïø95B\0Sİ*D´ÆŠõ­€?ğû¿v¶O9WïìœaŠeY‰×ÚÚfÓ,ÖÖ7½w…­ª‘:½³	ÊÖMóàC÷_¸xW—Ÿ[”å3_zöàÖn*sÇ‹íva¦A;ï™ÙZ[V…ÒŠ™—uí}˜Œ×Æ£±€,!Á:qx¦ãq`j?ÂÉŒÛt\\D4Êm­-¥¡VZ3Ã¨\ZğÛ¾y´¾6Ow_¿¦sÎ–#‚÷Bp.x7?^~íò©³§«ÑèÔé3¯]¹ê¥´5VŒcLìç\\œwY^bYá[ç…=e¬ÑÊ(­GÕh4\Z)eÄ“×9b¾tÚ^ZøiŠ)I\ZËğ€6Öjm^¹ô²€ïşOÿÚÚ\ZqÜÜ<E1¬¯o\"¢1z4^\'¢µµ-çšQ5‰‹b¤´:{zçøèğÆõ×¿úİï¶E)Ç×¸\ZÍšå~ûéå|¼§nâ/Q|aY71&“Vc×mC\\_[ßXÛPJ3cˆÑ9ÇuŸÈI}[FT”R2Ü‘7¯e´£u\"[“vI¡®›w¼û«Şû_W»vïöíãıƒä /Èt$Qpyï]Œa9_\\¹t™­ŞÙÙ:÷…W/]†H“Ñdm<Çk“µÍÍõµõõÉx\\U•µ¶(Š¢,[–¥@Å¨\Zm¬onmmÇck-jIEá¦m™c67R\n*e´5Æ\næj´6Úhm¬µ6Í¥­1ÖØÂ\ZóâË/\0ØXßTÚj]„&kçšÆU£qS·óe]Uã£ã£uz6›y¼\\.4â|:şÖ•+?¼õO¾ÿ/şâTè½ï×¼ç·?ıôõ—_åè›¦Á\'ÍdÔ)waTÚ(må\ZSˆ…-‹²ÜÚĞÚ˜¤Y!D€RÏ8ôC\"*+%»/!sm²t\0 mjbğ¡qmëÜ÷ßÿ­ßñ­i6ŸíBÌiír%+:Şx$ç=qëÚú©b6;>ñ®ßó¿ÿÇÿ_?úü3_,SX[ÆhS…Ñš€Qé¢¬pm’j•¬)2¤î™€	eµrSùŞKLmŒJ¹›}!CÄªüQZ…Ğ”ebDˆLA1‡QUmC§£²d†\"–¾u·oß>Åæ_|ø·?÷ÔùƒÿÕÛŞşvÂöÆú·şîoûĞ?ş‘¸\\–#±?¤>f§3ÓHö4*ÁûècŒ1H‡ãb²\Z¥¡äEuÙÈ¨\0@k£Ä«;Û¢Ë¨™bˆËår6›;çò©[[ßóızçüÙãÙ|ïæmW×µG–9	Èí•z\n(ï÷oŞä½‹§ÎıÏşô÷üëÿì¯ıâÇ˜2£Â¢(Š¢ÇeQJú|—mdÎêˆ¹ÏnˆÙÙ} `ËËf¬Ñ™óºzjA~óğD¥»ğ»¾ó;66¶ëz¾¶¶Õ6ËõíƒDÃ.—s±»1\0ñæõ›7oÜ˜ÏçÎ;çÚÛ·nô_äâ]çÛ“Î¹{.^(Æãg>ÿÅ‚!’d<±’ü-ç\\ğÁ;c>:ï›¶i]S·s.„à]ë|K9:y¸í´\\uZe”ÒF9m¬š-Ê[ßïíîÎfó‚\0ˆj}mıÏÿ¥ÿÇW~Í»ËåîÍİı›·) BŠ2¼ád6Éd\"¦CŒ´\\Î÷ö”±åhôöw~Åƒ¼õ…g_¬ë{ï\\ÛÖMã\\ˆ*µJj·}ˆ1pH®ıì%’utgep)×`º\n¤ˆ1¶ĞZ˜5rOZmÌ3_zZÀŸıS´i—£j<ŸO×Ö·w•2‹åÂyÏ¬–‹9¢Y.—1ÆéÑÑ‹/¾4›N‰€ˆc `(Šâ]ïùê·<ú(3Ä~è³÷İı…g%çsd‹Ş¢“eKÁ“·ÌBPÙQ¡Ê,iƒ”1V«|\rÈ}`eáä;ÏÊ\\óèğğàà0†x\\JiÔ›[ù¯ıÀW~í×ÌëåşîÁík7€\"\0!¦$L\0–—Œ‰Pò ”R\nCô2ÈíÆÊñøü…³øÖßÆ¼~éõè½L«½®m‰Y\')§xØ>X£±+­•µR¤;¹/¨	·Z­­1…Nc‹Bkƒ¨´µ_øÂç4\0|çw~ûúÚÖr¹(ËÑñôp2Ù:<ÜÄËe=›M‰àğğ\0@/æ³K¯\\><8Œ!Æ@!)á.œ?÷=úO–ãñ3Ï¿P•UU–w]8ÿ¾¯ï«×®ïŞ¸­”ÊÎä‚íÄÈ$î)ñ%ïÅÀƒ²+°LŒ±ÖÂjÑÆtïĞ¦2ÍZcµ±JkcÒm‰fÓYÛ´\0ˆ ÿİ>úÄ“íoş÷÷?úğ¢©oİºuóêU¦€@	dP\n²`&»\ZCŠ+f•FÊ(­gÇÇÓƒ£b\\”UõøğÛ¿Y—ÕÍ×o”V‘ˆ™µOFr\n9Óš”6Ù	CŞ”î¿Œ1ÚH­Î@¤³µT6Ú(4ŒH\0çî½û“Ÿø÷\0û…ÅÖ&›³ùl<Ù<ØßS¦<:<¬W7îøxŠh¦Óã›×w/½|©m›Åb)µrŒÉ$Ìhógÿ‹ïÿãßó\'^º|…	yğ~Th­}îå—şñ?ü\'·._ à\\.öèí/#	“`8&Ì½4aP\Z…¢\"%·5V*x­´üÁîlZwíêëÓãc)c·OşîïıÏ>ømßÒzß¶îúÕ+û·vu‡p\'u!–z4u3Şµ­÷>8½€Äº‡Ñ‡Ø¶îü=w?òö\'6·¶¬-Œµ¯¼òÊ¿şğ¿yñég\nk6·6Ç“±1š³\r\'e£²ŠXşS:“V¨%À »«ËM™*U«ÅÈ“í÷~à½ïyï»[<xá<À/üÜªQİ4ZÛùbn‹ÉááAˆ0Ÿ/–Ëf±¨—õ²Yú—ñ`ÿ`¾XÄ›¶•ùeš:2>ğĞ[şÛ¿ù?>ñO¾úúµíÍ-*¬}îå—ôG>ôê—\'ï–Ë¹¤ß\r©.ı¸şÔ•šr+‘‰Ì“Ğyh2†r8ß¾uË·n4^û}ßõû~ÿwı!ôŞ?ûôç]½ØÜHDä?…<P‘…}#…à½ÎÇ¼“Q{ \"ÎÃ<ïı²®—ËeÛº÷ŞıÄ»¾êî{î)lYEdzñÅ—~ëŸ^LKkÕ,.A‘r¤2‰]¸(|\0aĞÈªïJt\rFPx×ı÷¼çı_óäÛ+lá½gæÈôÄı÷#\0üÊÇş¹°éë¦Mã#«ùlŞ´~±¨çóyŒpåå×n\\¿±X,f‹EÛ¶­k…¨cìªU5.Šâ÷ù¾?÷ı­»‡G[këë“	[k‹Ÿû¹_üø¯üj3[$N‰0…r”o&ååU‘ö6G4Jf‰,°f\0Zk	˜KåÎ¹ãÃ#]¿÷ÿoøà7FâCİÔO}î·_}î…qUîœÚ²¶/†¡}¦Ğı™ò\0–8†è‚£†àœoÚ6Ä ã!ï|ëÚÅ¢^,ŞUå[{ìm_ıÎ»ï»Ï¥5F[st<{íÒå+—®í…ÖÖ:U‰»‹Ìäƒ‹ä%Ï1b5oloÜûÀ}O<ùÖ{ï½§¬Ê“Ì[ ÆX7õáÁÁ7½÷½\0ûù1¢È­ó³ÙÜyª›v±hšÖµMÛ.ı«Ï¿´»¿»xèœs™,*¦ArúcË²*ÊÂóÄ;¿â/şåÿê¡:œÎ®İŞ=µ¹uf{K¬µ·~ã7~ó·>ñéåñÌ\Z­°÷½‚WÄÑ‡¶mbÙŒ1e}vØ…8JÁ~åÅDæ{ßòÀ·|Ç7ß{Ï]Î9\0¨Ûæ·?ıÙ¾ø¬(K[V…-R¬’HMp8ÔZ+5$7vQÊéàÓW‘ºÿšºn]+ê…Ú(#ş§Ï}äÉÇzü±s.e)g „{9œómëQ“‘‹Ö¦*‹É¸²Ö*…œ³‘¥‹Z,W¯^½võõãÃƒz¹d\"^ıÕ¿òC\0?ÿ‘QÊ4MãÕu[7mÜ´áèèx±\\Æ@G{G×^¿º¿°\\.ë¦õÎQ¦Æv¿p&”VUUI)ü÷¿ÿÏ~ÿ÷]¼x×ñ|N“ª‚ÁÈjícxíÊëÏ|ñ¹—yv4ƒHÉãŠÙ©$d•(‹‘±¨Š³wë“?şÄ#Û[[‘\"0£Âë×®}öSŸ¾}ı¦¤Œ£¬5¶gÖÇˆä$…ÙKá©ä‡Çc‰îBˆyÑäw¢èƒ.S!†cÛ¸Hšñ€j´¶¹³}úü¹3ÎoŸ>µ¶¾^VUY–Zk$n¦&Ä¦uóÙlz|tûö­İÛ·šeEYZk×Zicà‡~ğ¯ \0üÒ/üdÓ¶!Ğb±@]2˜ƒƒ}ïi¹\\ºÖßxıúõë¯OgÁ…ºicÓ/RVK+¥¤HTZ£µÑ™G‚÷ŞóÇÿäŸø¶oûVSÙ­`%\"YèÛJ«â²®¦{{GûûÇÓùb±t“İ(4…±U¹µµ¾µ±qêôöÎÎÖ¨ª€!DY6å½»şúµ{~ïÖmL6E µ.¬›Ö„OS¤VDgÂfgvâHÄQú„³Åàeı¢Ğ“…¡œVÚ\'ïWŠ!„étŞÖNÎ|[Z£6Vëd…ÎÈ¢Nh(m?1»&0™AeD*;W¥r z	ÍùÁø	9hjï[@}tx€ÊîïŞvB¤fŞ,uS;\nbÌ¬w´ú†<tJ­\nk½÷®õÒà]yåÕ¿õ×ş‡ë¯]ú†ßõ\råh²¹½=¬•e!õgÏk9è«²8öô¹3§WF¶+ö½Õu=ŸÏoßÜ½uíÆìè8Æ T£IU\n‘D>Ek¤ÑF§İ—æc«i³L”è¹{Cf¥Yç&•”Š\n!*Ö\ZÀb÷)‡HLHa\ZC|G)4Fş:vI›‰İ‚%¢êóÚ¨¯2¿bµ€Í0ùöËÈw­m}Qæ‹ƒñxóÖíe9Nokmƒo½u½h,†4ĞŠŸyMÒm€ †DÑ¹\\Ã—.½òŞö]®m³#DÍmVÂuµœşL”DdSz¦˜÷@ğ¾msmÛ4®mó®ıİ5’Ò\"JQ`K+i‹Â–ea´Î„SjêÅt:İß;¬ë¦(Š­­ÍÍÍª\Z±´=©]ˆíÒ£«ÃƒƒgùÒ¥K—õb\\çÏ9}jg{g{k{ËZë\ZW/jŠÔãs‚GX£´‘R–¹OŒêp²>2i`\rÅ]Fs‚â@œŸBOŒ¤\Z4[.—¶íŞ¾Êìïî1¨årªÀÜº}k¾\\´Î‹²5¤»d|Á ba­Ñºn\ZÁ´æ—ÉÁ+/½²XÌ\'“5à¬ğIêVâÈÁû‰;ih]-ŞÙÿHn!q­UÀA)E@L12<FØyá¨N°—µS1:ßìİºyé¥Wn\\»uëÖŞñt‰Ê¢8áÜ½÷ßsêÌ©Î­­­\rœe’Ğb¹¸rùÊ•+W/_¹Z/k­ÔÚÚx}}R*f>88lÛÖ¹ i.R8wfÈ]¥ÊgÏ.@Î;Lå@!a]äiÇÿë&ç9„ºQ­mQjsxxPV“Ùîn5^;<Ø×.¿zy:=öŞE\nmhQ.Ê™Ùm‹B†SÖhÑ²Èœ,†Ø=Ê{7÷n_¿õĞ#ëÄ¬äXO9F\ZW\'-ŒÄD1§áx¢oƒBH`BBáœJùm¦¸c¼¦ !x×\"\"D´6÷<pßÅ{ï	1£6¦•EQ(¥d@—A™8F`!¦­Ó;å¨ºûŞ{\\Û\nZ)k-\".›¶mZ•]eŒÖÖh¥P	‹S³ÖÚ¢N™:ílG•ÏBåY/\0€Bâ¡¯u÷<§DùnÖ‹ºiË¦YÖóeÃˆ‹Ù•n–õr±Œ!2±8Ú‰r3ÄØåÜYk	”*bğÎ\"…H²5PÇGG/=ÿòC?ÈŒÀ$¯êQCfD& \0„¨´¢ä›\'5(”ìĞì²ÆL(Rõ\"¨…QªU7I4Ç?ª0ãb]i­”†n©3.0q’•ç)‰Â½\0ª°•F;*I\0Ó(’D™%éˆT\ZÚé9?êâqÂ¨\néš”ê\r–²æ®·\'¢®ØÀßr–ï\n)§hy	C¤9†(3…º®‰Ø{ Ú¶u²Ÿˆ)Š·urc¬Ñš‘«²P\n½Â¹ğ!ˆ;¥$ˆĞç•—_i›Ú%“b¢¬ íMÊYÂ\n0§*ÓLØ©î)s2i\"\n|%QK‚25fB\'@M!»Ùâ³ñˆhH¢}8)»ÂMÂP’ùØ0`äÈÈ ­£³5ï;£ä¹Q9‘(\"u*_ÌR´“>Š}¡È(¼7êEƒÉG*à´„Db1z\"qÎâbÑ´ŞQš¶D¢(&,K@¥5¦*Ë4sU“ùCÖõåË—woŞ:Ï=1FT\n#\r¾•Ğév	bZı.L€‘bÊ>¢Î’#ÍgŒÉ2Ú+?ĞH&sTÛty•1æhr×‚!»Ş¡±Ì”¤ã`¯:=åÔE5EPÈÀ1†}Ê£èyÄÄÄ$\'•xVĞà+½Î˜h1-AŠ©j›\ZQ»v®”].ë.º ¤Pô.Î­5ÚhD(‹mëbˆ!&+qÚG\0­´däéñì…g_<{ñ#*Ô\0\nyàÆù:ïì: œr¥Ø9f­VŠ_P=Üä3ã:Yå\'W]È™ÒxÉ@ÓÆ&£¬ ªãdåÓ‚ÚRÄˆ½™4Ë­]€Õj6Wbú¤¢EŞ°’h¡¸a§È ±ˆ„’1õ;DiÿQÆZvè’ÓˆˆCŒ!f¬—sml½¬}Ûj¥c› úM”·(Cj[Xb\ZUåxTÕu#\ZÔ„W˜\ZWie£Ä—ÆøÔoñïşÊÑÚZ@Ôe)İô¾z”c\'åéşé’…’ã‹ÑZiÕE`dì»÷çÊşvÄÄ¨$ÕSvgrÛ\"b\"‘\"&©w=ÅHÁ“vP}\0;\0j…\nTLqÏ\0„œQ=0õNûV¶\'01(Åé*Ì2Á4cé“Grwš¬¸Ó/bH^Ä‘Br~aÛ$Ì™Ø{gl1ŸÍŒ)ZßÊÇ–[ˆD°Í£Dº–¶p>´¢ƒN8ç¨FÊ~äi~tíÚµ«¯]}è±GbdIfÏ™ú2ˆºíÎÂ¡¡QLGïK…Dæ¼\'_rI·Ê™p}¦…Ğl$isXŒb—qIÌn–İœ	ò&,SŠi@çf•KŞé#ó½‘€8*fìE&Ğ9EÇNùÜ\r‚ˆ1c yÖIà½´„ÆØºñ2	AÔm3G¥ëå¢­[Š!§)%{B´RÌ¬µ6Z·®e†H#ÇHâš B%¯[à›Æù/~ñÙ{¼µe`	àê­ÑängZmk»“<¦&+yfz—Ü£:ÛødB„H€Üù2³\"T³#»:FQEÖ¤ *\rw…`êcŒ±S¯¤¤Jàœ‰ŠEYa†Å$N;_Æ£Jñ VZ* ìƒŒ\"F—‘EÊãp©Cú·½óMİeùvx qˆƒwÌ˜Ú»än&KçjÌ…5}€-÷Ê)óó³™ñ#¥˜àóŸÿâW¿ç+Ïœ?\"\Z¥)@H©½_ŠtùQÊhAº9µwÅü’¤mFì-•d» V¬€\0™äÊQâÇÅ¢\0øÀ12st>ú@1Pæ‹DŞ»‚¤\ZP¶n‘Â†´B±+¥´Õ‰×ÙFiŠI„ŸƒhÍ|É0G–Ÿ‘µ»¤­¬ùŠ©Ô—î$xCp®]Öu\'	Ö¨µB­´±EåêzqcDTIL&P\0cr/\0àÂ˜ì_@1ÆŞg(»;PÆñ\0\"*ÄÛ·÷_zşÒé3g)ú¤xĞ	{PéÚH…%(™:×QÀôö7é„bD$ù¡ Á½åfºNc\ZÄGÈ‹©\"I04’–I¬¹˜€=ÄÀ2–HÆQƒ´Œ Å‘ T10‰E—ø¥§Uc2)1\ZB­e–İ“£)@º¨”è,—‡´£”>9O»BTNQ×ºùb™—0†ÈùNM†ÔÀ>x@¥”Q¨\"&o)£QÅ¥	ƒ|<w„—®Ç;ß™¹m›—^xé_õ6cK9™Qk@VI>ƒCï]ì:óú“9 ¾Q+­1Ñ59Rp!ú@H–0HX_æyŸAâŸ•0;8²’”­AYc…Ø¯µ2š‘]pkˆ¹\ZLQ\0âr±˜ÏµR\n0FekŒ¡n\"ò1 B5ªÖ6×Ç“qQ”Jkì€\0ÅÑ7îÅ‰k$/›RÏO@‘¼Óùâhš#(å)cŠbˆcğıC©Ë”C_ÃLJRÊùĞECöÑÉoîŠ®4¾òò¥×®İ}ß}\0ZøNéLb˜”¦Ú)¡©¹²‰}\\¢ò\"Eù„•BŠ¡™/n4µWkkk“õÍMm2êñ¨•¦,c¤à<*5ŞZ×ÖøÖµ‹eô~}gk²±c\\ÌÍ|áÚ¶ÎàÆ…ÓvT)­8øĞ¶õüxÚÖÍdcİ%Lšf2›)…EU*­½sóÃÃz6ßF>Ş?zê©§woï…ğôéÇ{äìù³eUkQiDŒ\0H„µ IyÏqÇ\nKä[gyçÚÅbÑ4Mğ¡‚…<Çd¬›ì·´K‡l)v†xU2€LK©íj°wâ7quG\0˜Îg¯_½~îü\"De4ëTfuRïÊ¬Ä¼—ˆ	´DÍdcŒŞ¹¶m½sÒRˆL±^,_yùÕ/=÷BÓ¶¼åá\'ßöÍÓÛ›÷İ]®,¬-Pk\"\nŞcYY…*Äà#Š£jTFˆ¸¾µÙ6u½\\Ôu€ãñÄ#~#‘bé‹¢,œ÷Jic\r¢2…v®QZU£’æ‹Ùõ[·8†ÅñìÕç^:<<´Æ”ÖZkKSWU¹¹\rˆ kmD(ˆ\n”F 4Z)¹2ÄHG:s!ß¶m]×‹Å²¿›fÉ\0>¸ÔŒä¤ËA]Ê©P¨1Ùåkk\n\0”0sXxÃÍÎõÔÿÊ+¯=şÄc£‘\"mHi¥;‹±^ô™	ú@ÌŠ‘ kC&ê •FğD#… 7Yp~TV>ôĞ|±˜NŸúÜ§Ï\\¹ôUßğ¾û~h:=b€.TE¹\\._~á×úÇßöxU@‘bX,FáÚÚDiÍÀ!h[˜Í|¾T\n…ÔÔ¶®®ëÙññÕËW÷nßRıÁşÁşî¾¯›CÛ´\Z…JB,.8k£µ-ìd2ŞÜÚ¨Æ#!f’ TºÜ\'ïifT\n\035‚ª´’š¦/\"!Å\0Àx¼ØZë¼\'Ñ®Y[*µŠUnºPêÌN¦´26ÏÀà‡p+~XôúµkÓéÔ¥VŸ*ºD„$ıõ±\Z©5D`\n\nKTôÉ¤Æp$…j¼69uútÛÔóé|ÿàp:›5‹ÅÇ?ò‹?w<;šMë¶	1*¥F£ÑÖÆæÎÎöç?şÉj}¢¬AÀèc°¶@Ô!ÉálG!br-RÜ6Mô®YÖL´³½y~{ëhk{ïænÛ4MÛˆ5]i‹Ô¡*¶y5®&“‰¶ÆšÂX‹¨”ğ-€Îl>1¬êê¡r®-f³ù¼mÚÎaA0RQÔyïç–Äì\\#vbÆêèÓH—cÈî6é¯sè±7Ù|«1îJ©Ã£ã[·oïœÚ‰ÑéH\ZÓ v`”‡¹ I£à\"+4h\n.³½‘6!HaÀeUM6Ö¶vvNŸ;3?œ-æß¸{Î—ç€ˆ]!ÄÄŠYÖ­ó¶,´5>Æ¢İX_ßÙB¥]ëšº¡Ök¥k™xq<«½+\n»œÍ›Å¢]ÖDñøêÔğ Nl±^UJ!+ÀÎ8ZaUUÅ¨²ÖŠ.NÈ÷\Z\r‚FV@ Q£N<wJ¢âºÀ˜Ã°š¶­ëÆ‡ ‡j¿å86¦°E´.:·@TEY–Õh>_$ØX)\"•Ñ(÷=g\"a1CÌÕ\n„å²~å•×~äAM†bà¨)ƒ4„ Î=}Räe1!j´¶È–ŞÇHl(Q÷µV\n×6Ö·vvšE]O‹é<úD\\®(]Û!$Bš[4^¦Q1ŞŞ=Ø}õJrWPÈÌ\ZUŠ%\0\0G˜KÀÑhÜÒuşdJ£Ò\ZJ(.Âh4\Z¯MÄe•’Ü‡>•˜uò~J}LqšÄY²@DÑ;\\ËÎûcòÆ3\0 ¬Õ8ÁMQøXkc··NÍ¦³¦i2yC‰ì˜´ÖrÇ–e±X,³•\"ˆCó–;-‹°0/=ÿÚ;ß¾{ş®ˆ\nQwìD\0}2®G˜ÍZ!F `P\ZlaíóÊ†˜)Ş§ÿWN66Âéàëvy<m–µwÎ» Qr%½ÎµI\"0æ>² [He ‘æ¢5™rjT@’	ˆJ+kmYUÕxd¬UFbŠÑƒ<Å>šÅÅ™#@dù\')LDj\ZæóÅrY‡ÈY!ÄĞíÂ4xCF`¥‰`\"†µÉx{sç€öa¹\\F\n²!Fà}t>TUU•eM5*%Cf~ãS4;¨	js<=~îÙ—NÙI!UJ*èÆ{JuÈôVø)ŒX&ÃºOT)”:M,²\0LQ£ªZùºiæK×¸ècŒD¡»Ù9„Ø6s­xÂ†ÔŠÅaö` ˆ9`QEJ&b dÛÂ–U9\ZLaµ12Œ°:3f¡WEvv<2›L„XŠ!r\'‚bğ¾Mæm$]\Z¤t©ÖÊ\Z‹Ø@z–5„PËÍéü°i©(‹Ö»¤\r m€a±¨Ï>µ6¸Æ±‚I+L+=P3pîîñ‚ûìo?ıÀ[î»ûî‹¨ Tr“k­4(¥P†QÌ+C;Èy\"\0¦LÆ$õxu)Åe	k“õjƒwÁ5­kœwmì0Ä¢°Î•Òÿ;ïz9bŠƒÍëLRsje´1‚–£r¼6ÖV69tƒI‰NÃ£ä¬†JiD@f%L˜ìX102‚ lÁ»Ùbî½g€bÓ4Î»Î¢Y¼ì¨…Èuİ´YÖì=ÖÍ|²9Şnv¼wŞ»²(¼	D4´;:®O&Ëe½¨kÍ:Eopçæ1p¡Ëü­DøQj:~ü×>õÿîo°–‰šMœM40Àn“c(zG+Ô¨@dìZàŞÿIp»ì‘Fÿ”‚_	†æ$ƒØçÒ¯CÈ!ËØ9¿EŠ‚\'¤ÊN`2ÚD¥QË_ÖY¦‡+œÍYa>R(ÊÁ#\\\n\"\0I0äÈ‘“dA˜ÈŞ‡¶õÎ{ñås>ÄH\n àı‘?Ø´­Ä&§¨zÅGb¦õÉ:·m+[8Z¦ÌŠ‹ÂZkš¦åŞ5 gNæ05´4è§>pxt]¼û¼Vº·Rä•’h˜‡È+1j½ÿE×ûô!uµl¿5±İQ‰\nÌj]U\Z]º*ô¨4£RW…©JS•º,ÑZ6\n£ÊÂŒJ[U¦’o(LY Ñh4äÑ¼4sœŒy©c$Kè”>˜NQmv…IÊÈÌ1Dñ!\"×ºÙ|Ñ4m¤èœ_.›¶u1&I×ÑìXÀúƒßQeÛÔ1DçZPš(ÁIøšÑ™ƒ!XèÜ¸v<k£[ç¤…ê!Ò^s~\"Ø³c’Òµk7\\ãÎŸ?‹i$İÛê.\"\\¡÷‡*\'7è–*ƒä}ÌY~bp%§0Íß(æ¡\\d¹£xã:ŠÈ1yŠb`À@\0D#Q#|f\n ²!x/Ê!™¿#‚$“¸ëŠQâÉ ¼‘cŒmÛ,–Ëº©#Å¦me-‘•$L)¥§G\Z\0¾÷Ï|Q4E)¡Ò#(dâCY•ÖJ#»‘‰üe1’óa<\Z[c:™îÀßODyuŸhšO(õúõë‹Åââ…’Ø™¼I`Àˆ9¬S5ŒÙªpuTœE×”²JÒÄM2„dc2OÑP!FO!xç£ËW’\0º1M§¼#\ncweEŠÁ»Bp>)„‰e¡9‡@öÏhÜç‡1›Æ˜˜h1ø¶mG¬ëf>_Öuíœ1?¡^.çõRÀ÷}ï÷»8jcói£™HÃ>[Øq5™ŒÆZiç<÷qˆÈ€i±\\*Tëâ£€kÖ§ÔİñÕ•9ÖÚ½İÃİ[{ÎŸÎMŠûÓÊø{Å¿³œJµë×é(©œfßbˆÑ‡6QZ,ÊÁ31Æ|ğ.$ËO1hÅb ù‡sàˆ\"\"a\'ÆeŞMQ¡“	ïr\nœXÜ\'–w8fó¶re™†Ñ/ëår¹pÎÕm3Ÿ/Áµ˜½óMÓ0ó²©5\0ü‰ïşCòEïš¢Š1dúcj8µQ›[Û¶´Z+ç\\ŒQF]X©÷Á9·6™”E!ŞìA:LØXuÑZRí´ÑÇÓéK/¼lŞØÜ\0\0…º;³SX‡$â0¼0hcÇ^ò¡ÄŞi?&ÃsÎt0–9KAAïP¦§QÉ\Zäj)Ó=‘;Jlâé¦x­¬øwœ”ô”xëùîL´núîwmB`\"ïÜl¶¨ëÖµÎ9BáŒ+\\Ôµxs—âsHÌÆUåæË¥Öf4\ZÇMİ4Mİ¡Ôû0YO6î?{îôÕ+Www¼÷{§Âiÿè¨,\nñ™•¿P§¹5¸çò\rB46Ö×ï¾çõõxùêõ3gÎ0%Q¾ˆ–DÑBZkMŠåSïö¡\0XÆ\Z,ˆ# bÔ\Z†¿\r’Å2©&Ñ\nµ¼¼$ûæ®¬çn\ZÓÛ`°\"Èv 9+)sºRÎ¥ÊUÙ;\'§Ä÷Q‡©Ú¦\\›‰˜*xÇ@Î¹[·÷nİÚÏæ\" ÍÔn„\0ğ™Oş|$Rº¨\\,­õr¹\\ÖuÓÎf3×úÉûØ¶MÁ9ßºV)]¸|éµ›7nûÖQ÷Fe¯+PjŠB¢dÈyZiZßXÿà7°\Z‰!*å\nŞonm]¸ûbYX	Í²Ö\Z«µ1J•5ı>ÍA7ì¦˜tò`çÃ˜‡ñ¿é&\"Nc\\ÊçA)wq~Ü×@ÔC9¥!¹„SCFsr´æ|ffàL˜)Ô•Úâ¼—º¼s‡GÇ×^¿qëÖm×:@0Êhm°#¬BZÂ«»7\0>ó›?\'ä„²œÌç3@]/—.Ä¶uÓét>›‚Á9çC¬—õ²^J™œè¿DÓÃãk¯_ßÛ;yV•¤vŠÕnö¿‘f¬3àÿ×½÷kŞû¦m½÷­ô>Ş7Mí½‘ñpÿ`ïàío{üüÅ³Z«¢,Šª4¦0¶œ°~‡Ö´]”çøÏî£§~\0pC‚ÌÍL|æ‘pwz7ÔDf‰jn¤}ˆiûÌèLËzêrFS|,u5¨¸cQŒÓãÙÍ[»»7÷§ÓŒğ)­D¦°âù.\'Øåİë²?JuŒ±\Z¯ÍgST¦^.œó¨ì²^«Åb`ËeÛ¶MÛ\\ë|ğ!„“0@æd‹ùb1_L§Ó£££¦iä”_¯=sv{{kskcçÔööÎöÚÚúÚú$F’àŸ¶m›¦Y.ëº^6MÃ7oÜüåıòb¹÷¤²,î½çâO>váâ…²*‹ª,ªª(J“äŸ¶7Gê7Ü	èòĞ?Ï4y%Ë<5¹<&¢CŒrAdÂejRÌºÁ•\Z©8ì×&Käü¥4n‘n¯;\'\0€btÎïîíİ¸qûøèØûÎA…×,$ DN‡äß)ıÊîM€OòçŠ¢t®¬m-Ój´¶˜O•ø>Ù¢Z.–¶¨æóEŒ´¬k\"ËYÛ:JŞFâWØ#“rÛ‰%“Ñj4^/ŠÂh(¬×l‘ê^	öiÛ¶©ÛÅrÑ4ír¾øØ¿ûåÏ?ıy¢˜ü6•6Ö¦+Fkíı÷İ÷oâôéSå¨ªÆ£²\ZÙ¢°¶´…5ÖŠ—^®8xè6›ÙÙÜóŒ»—‰#y9wƒÀ]¥óµ…\Z(­qbI	)“9ícY\\H¬”‚´‘Â	Œ!ÄàC]7{{\"‚!HT‘\\æÉ\0@qR;õÆÑé æ«û·\0>û©Æ6¶NÍgGe5v®µ¶”€5c‹¦®mQÍfSmËz±@eË%ê¦	!\0àõë—\'“ª\Z‹pWLdD©•ÒFY£‹²*‹B)0¦0Ö\nš,^IMÓÆ_xî…Ÿü‰~íÚu±è”1Fâù([\n)¥NŸ:ıĞ÷]¼pn¼>Oªj<M&e5ªFã¢(´6*ÅÊ©ŞW°VîÕû”‹8„à]ˆAlh¹»û„”˜–c8,œ–zœ@¸´árÛ¼÷Ş5mÓ:W/Ûùl>Ÿ-’v8ùê2# ÑÚ(¨àd•\"¸Òƒ)2Àõƒ]€ÿúÿYUãüh´‚&Ddm)mŠKÇãõ¶m­)Z×\nwCˆˆê™/~f}móÂÅ‚wâ“€gf\0²¶,Gãè[}Bğ!xb%û™?ıÉOÿÈÿèÁÁ(¼NĞ§¬-Œ1Ş¥„á×Kcom±6™œ?wúÌéS›[ëÕh\\F›[kë£ñØ–…6\"Ö€jĞàÀºœ!÷üSÄƒÒAæ¢ÒMF1“¤_\'ïš1…àƒ1Èä82).Rğ¡išzY»ÖÕuÓ¶®mZç\\æ¬ B4Ú`–‚¦Ã»%Ä.&.·!b`€‡{\0¿ñïFÆx…diƒˆEQY[(­‰ÈC\0¥ÄDu±˜Ù¢R¨¼w‹åÂšÂØ‚ú›1Ïb31E	€Â\num[×Ëº®…ßú‘óÑŸüñŸ’ªÏI]å´¯¯¯[[Ìgs©a°”ÒÖ\ZklY•§wvNŞY[ªñx<MÆãõÉd}M¨‚RÇbBº;Püw¨ËœMK$?ª«9:Zg\'\n\"	›.º½wÎy\'bÒ¶m%Õ§nDZî\\ë¥N¾\'!ä„O±JÔIt(ò7í{Î‡á•Z*²È$%7÷Å½EÅõµõºYF×6EY-ëùÖ4[Ù£µ\nqQ/¬)Níœfà‚Ö¨5VÕ¤\ZMº¨TNÔÇäíQ7õŞŞƒ÷~¾˜[[¾øüK?üO?ôò+¯Z£³X’Vûì¨luÓø…ÍÖ•séıÄàRíÈ·w÷æËåöæÆöÖvÓ4æøXY]–åx}2Z[«F£r<¶¶PJ¸hÜi·Õë-¼H¤âOÂüË”xÊÊĞ(2æàCˆ®nj\\ò÷õŞ‡¼÷!4MëœsMª´{„6§:k¥­6Ji1Ü‘[T‹ùURothGÑõ\0\n”2lšÏ67vvwN?8¸½±¹S×‹­­S1EJEÓ,G£‰Rjkc\'R´¶$ŠÖFéK­­Bpb\'vÄ Ã¿@DÄ…Éy|<ÿ©Ÿüğ¯üÊ¿÷ŞYcª²ŞJoöB°ÖVUÕÔVB›@‘ÌBCˆmÓ6;súÔÆÆÄjÁ×óE[·ÚXc­2Æ˜BÆO\"5‘á˜P™RşK–ÄÆAC]Óê}ğ­÷>ˆµ®n\ZñétÎ§ú&„¾õŠ‘‰ä$äì.ˆV¼Ó²)bR¨tš_äPµd˜2<MÎ\06\0PU“éüèÔÎùıı[ÛÛgnŸ=s×Ññáh4)K»\\Ì×7¶óéúúær9Äº^DŠ¥-CFamaL©Ó‰bÛ4Îû¦iˆx6›}ô#ÿîçşí/ìì‹úÇhÕé}~\'_mÛÊÙ’ây`Ì¬Ò\0R3sğáğèÈW·;Û[UUm•Ñ\Z”bÀH!6	[K€Qª1¥JŞ4eÂ\nÒpÅñY~Ó%âOÙZM+›Ò9—“ß°»PÄœÙ¡ë\Zbñ½-m!Ï\"æœÊì}Ñ³¡3{…€— ¸˜âbº˜5k¥ğğp÷Ş{ßrãúå».ŞûöõS§ÏÕËEÎÚòÖ­«ãñÚŞşÍÍÍéô°,GÌ´le9šŒ×Å·i\Zyú¼ˆÜ´í¯|ì7>üÓÿêà`_ô:ñ˜Áo²{­!PŒÀPÕ2,	@kP”•#âI&£€ˆ\0‘—ËZÈK››(JÕR!ò‰\Zñqë„€œØ(R3º¶u²ˆ)¢„”G3ç¢‹å¢®ë—\'ÃX<G$‘G˜Fdı\nc³*®ÿï‰ûÃ=Ûº¤{…È9R‡Îäÿ1\0P·K&ZßØ¾zíÕ3§/¾vùÅ3g.ŞºıúÆú®iëµÉÆlvtúô…ıı[ëëÛˆ[S\Z3r®˜Ø[ºÖ1ÀóÏ¿ôÏşñ¾ôÂZ+‚Há¢>~ù#4Ù—§i\Z&2Æ„à‰1¥owãa±õË	qn1Êh«PËÅ†c0º2ˆ\ZUr5Úh\0ÒÚzçƒñŞÚª7„È Ê1%gµŞµ-3yâÂC‘ªÈHaŸ\nÃáA§šİï¬kä>ÿnuè	YøØM9)3Nğ’ä\r„¢¬‹éöæé½İëw]¼ÿàp÷ôéõr1\Z±mÛìœ:·\\ÌvvÎ…Æãuy ëºñ!:çg³ãårAÄ—_»úşŞÿ~ıúëRTúÀğ¦ü|ş ƒ‰±”Æ¨nş\0½±uz?!FŠ\n¥q±¨Q4¹Z©Ò^)£2+­”•ül@e2¢dFéÏ’5HFÃ8…èo›¶mïÛ|\ZnµÙ(H±±Kş”ÙE°°s+*uiî:ùagc\"Ÿˆ¨¸Á[>2\0à\\ã|[•£ƒÃÛÛ[göÖ×6ëåb}}Ë¹Æ˜¢,ÇmÓLÖ6›¦±E9MƒMÛ8œ÷‹åÒ;?Nú\'>ü‰O|Rü”¥/÷ÅüåÄ4ò²÷Pï“Ì€áèÀ1‚ÑÊ±s~>Ÿ­5*kŒF-Áïâò«•\"TÖjQW£MRoï “ED ÈQ±¢HŞyçÒ6Ñ1cjAT¨b\\ ½dšjc¢íÖ(Ô«!‹æÂ[J˜.“e˜åKY¸®\0ãpxy$\0|ğÖ–R‡LgGJ«År^V#)D‰¨içZÛ££\0åœó>\n­ÿøø˜êºı©ıËÏüÖgÅg$Æ“1fƒµÁ7Û…_vıËÒ)TFCi\\˜ÉF9o&\"¢\"$ÄˆÑ{8’ŒL˜\"0p$ßv¢(QZkD¢I£§l\"côÁçh!ršİyŸÂÛ³”QÚFF»€C ÈV1£Š]ò¤Q”ì7Õm±Î9»Dz	êºæáqÚ³¹Û¶^_ßò®=½y~6;Ş‰1c*£- .Š‰4ªuš66uPªüÌ§>óc?ü1Ô##®Øß­NzOH,ğw¸A‡_¢wL&UQ-–‹|\'½èŒbˆ˜àb&FÍDÔŠ¡jA¡•RÌlÈ²Y´BDm´x$G¥’Z‹\"ÅÖµuS7B_tNXñ)ö³ƒzç_‚Z,8F‚A-Ô5T’ı@9(IJ˜„Ûv°.‹¦ŸO>İïÓğÃÇ‹hLa=:Ú?wöî×¯½vÿ}\\¿qùô©‡{Ö–1Ğb9\'‚eİ çÜ|¾ğ‘~ıWãßü«$W‰\\éwÄQìf[ƒı7x|ş/¯_öÖ!¡»„zÚøª¢&M‘|¨©N‡\'*k,g‡¯Š¼È‘\rÉ8dL†»gA\Z/Â°¦i6†\n5#*”L7ê‚&s¾4>\nu‰ ‰IÄŠ§Y‚–IŠÏNÚ, ÆÂ2üì’¢÷-]¼xßÍWxà±W^}öÁ»uëú™ÓwÍgSHë¢nj»¿¿G„‡‡G?õc?ıÂ/h±3*:C÷†Çãÿ\'+×OõblÛ–˜Ê²D„°^YGXKgˆ”íD·iZéRŠ .2GQ‡”EI‘\rÚXÁ¥¥fñZñÁûàD<äÚ6vğiÎ%é“™(¤\0°,KYu£ÄÔ\r‰¢QFj%âWÃ\nP^UæuSGË{\"y˜qo%º}yJ\r\0îZc76¶nŞ¸zß}?ÿüÓ÷İÿÈóÏ}şî»ºôÚ‹£ÑzÓ´‹åÒ˜êààÀ˜âSÿ­_øèÇbÆ(bzó{ng\'Òéà$œöeÖûw•Qé­µkëkËÅ\"„ÂÅ·ÅçbòêS-SXºO€Y1Á{ï«XÙXeu’öœ“\"hLÛIšs%•èÎ¨ ÛŒŠŞ€×Æ“¦mË¥¸5)\r’«&ğ»ˆ\r(è3­úK“Cê9KƒHMì	ùUYïçóYYTÏ=ûÔ]÷¼åÅ¿tß}¼zé¥Ó§/8bäéô@û±ş»O~ü“.¶½äßğ{ƒùÄêvê¥Ş&íÍD¦œ5¦Ä$°mŒQ=^ÏgŠ±·cÊR¹ÊP)q¸$à¶q§âu|ğÁ*1ù\rÆ[­\r¦ëHI‹’2nœ>0AoJ”xs¬\0™A¡ŠH‘\"#Jr4Ÿ/¢\ræQ†>øÒjÃ’k\nJ{;H.‡TJ%ó£d	Õ%gk@È}ááÑá¨\Zùêz¹¶¶yùµ—Î»û•W^Ø9uáÒk¯TÕzÓ´Ëeí}üØ‡ñ¹ç‹Ü§	vöw,¯rÕğê—DŠ™fù†½!ò±E+ê½—\nÆã5c‹Åt¼ç“Ç’&‰VŠS*(‘Rbó$¦-“É¨ªªñh4\n[Z[h¥™Ó­CD!z¼sÎ{—¢c\n6 XÊ[fVÚ ¸q!Î¦ó¶m3È¦ÄÚVZ\nÑoÍ	ÑĞ{“DŠQõŞ9R	iŸQ!Ä¾˜XébÓ4¢%_,o®O6oÜ¸¾¾qêğğ°(Öö(BŒôë¿üñ^xÄİ0*£§ÄTê—*+zŞøÌT¸¢gËR@¢W†;„ŠJ¡â¶Ö³k³é4\'ÿ6``Í9şBusÁÅrb™hÑº¶(Ê²(%¬E’‹B™r“v?\0‹(D‚ó“i\"ŒÊÊ…0›Í½ »8Bd’!hˆË B~”\0e[¬‚ÿ}¯Ÿüæº 9ì–ĞûĞùÎ£Y¢8Î‚§¦u\n‹@í+/^úüS_®ˆ8™˜¬‚züj¹´ÒÚ­,¿AD;BA`‡ÓèI“ì•*Œ`…¨²»«w.v3Eæ„9¨4P2qMs~Ù4kãñx<ªJï}°Æˆ:±Ÿû(á ”b \"ô\ZRÕÔMsì¼Ì¤:«§ô»ÄâLò¿@ÎûRJ)k¬>{\\\'§:f®#æu¹›Ãò‡»0DÚœlÎ3kK@µ··7oNÆ›€f÷Öî\'~ı7Å¢’zo‹A	ÃdÖ79\rß\0q!è¡Ş“-şÊÁ•\0Ã”rBÆ .‹ŠM‚¹ÒÚ–%xC¤ÄJæŠÄÂ$T¬\"0s\\s~Y7ãÑ¨,jk“u~7vNvmÒ@€–öMf¡‘4\Ze›ebÊ¢Ê1â|Ğ\'È(D¼…TAŠ”—É¦ÖmÄ4ğ·2îƒ	ûNK¸±¾yp¸W•s¾iæ£ñÆ•+—ÖÖv^xé¹µÉÖÑt÷ÖõÛû{û¨ûğÎE‚7ß^oöıØ¥ÆßÁöÆ;jÚ•¥\rÁC‹ªª€Ù˜B+Ó:GL“µ5f®›ÆµwnàÛ‘¬¾Ä§[`pìƒMë$¾¢,X“3ÓRö€zœVFi¯€]Œ‹¦™/kÉGD\0£\rhHJ€$ğdÊ®Kƒ8*Œ¬1)É—â¹œİÿ œÈ™=Ÿê{\r\0ßğïºëâıÓÙ•Ñº¸~ãÚææéË—/Fk¯_»Z•“ßúÍO-KÄH9¾ÉNª&~g fO\'‡=É‰+„|‚17Î+TÆés2#ÈÛ¶¡İÓFÌ>\'“i&| cBêL&Åî•²¥]4Ít¾$bI=ğ,&#Š¨ÅùP¹È¿Ñ‡8s/‘tƒÄ»UÙ‡VÉä#ŸÑıg°hj\0wßußå+¯>uşèø¨©ÛÉxıµË¯nmŸ~õÕ—v¶Ï^~íÕÂŒOÜdouÄga~G#‰ÿğ4£—&f3¤hLÇë¨µ…€B(ª\ns\"ÆşVÉ‡\0K†w*ÿÄ%@xu^·Jk£Mc­X®ëÂbç­Œn½;˜N—ËFüWPk­PmDä-ş]ãƒÓÚ$V¤R	ÅU*fDÔF‰.µWA2#SdF@jïc²Dï$ù.|ñ¥çÎ¹pëö\rk+Túğà`gçì•+¯;w÷åË¯>}şù/\\JãdÆ7 B¿·ô‰I¼Q_oÔ×¿Ù³+Ó¹D¿gY8¹ãjT`Q7­L‡’uBa-–ÈBŒ!¤9#öö’]ã\"µc}gV«”*Ê²(+[ì nZHióàƒ¼õÉ\'N>S+ç|³\\îŞº}óÊë7_¿~°·1\nx+wÛ¸½øw‹uªÁJN/b.|%,5+ŠX”YºÏ èÑ™õõÍ›·ol¬oÆÈÚØİİ[;;gnŞ¼±³sææµ›2İŠ8äÔòL§üí»•?òFwŞª]ww	ôò‘\"³NŸ¸DóÙÂ–EğÒÈ^µŞWUië½oµ¯[`$ÀÔcd³Ün\"GÀ|ı\"%ï¥ÑDß¶#ùÇşÓ?ò{÷ïñ1ìîÜŞİŸÍæMÓTÅhm´v÷…»İÛ›¶^^~åÒ³Ï|q6Ÿz!mŠ·ÑÃ?´6YûÒ3Ï	UEæÏD’¼\Z#‘Âä,í¿P”l>9B{îÌáá¾Rfoï612£w±,ªéñÑúúæôøhsc‡è•á\'Ê_nâªİÓ`¢Äùq¹rŸ,8¨{D<a„ÂLD9ÈÑh#2ìj\\M&ã­S;çîº¸¹½=Œö÷¿øÔ37¯^[É}Ó\00£Jù\'1…™$º„9¿Ò¢©÷>(¥·Ooşàıƒ?şdİ4°½µÙÔõÑşşb:uMK!,¦SïÚå|AÎ9GÄóÅ”È#bŒtáü…\'ŸxüWõã ”FŒ!($Úš¢õm>äÉíŞ¼ÄÓÂÀ4·wÈ¯ª’µ¶³Ù\\>›¢¬œóJ›Å|¢GTR[ß±~¼:¶EX±›Á]á‹Ê<ğúòWâíUi¼¢@mÛ¢R¶°L|<><nšÖV×µ±gÎœù#ô»êåâWå×^xö¹¦®1‡‹k¨ÖFBM¬´h>Ä•RDZÎÑù‹~à¯üåÇ{Â{·6?ıù§şæÿø·®¼tIeŒJ}úÔé‹/ÃÁÁá²^…µŞ¶Mrôğğğ—~ù×ë¦fb¨µ\"¥Ğh#ĞØßÓL;Ïà}‰}—•wáéSçnİ¾±½}öÖí›Z€¸VÆµóñh²ws_yúqÄÀ¦àMÖ+WTæ7¹ù\0ñÖ¯gÎóT<½\nÉŠ›GÒ¼aâàƒs¾iÚÛ·n#ªj4:¸¹wõ•+gÎıúoü[Ø/|ö) Îá²¸¹½Ù´n:›Qô$%‰LR…7]ØŠˆ>ğ»>øĞC-‹¢0÷oÿíŸşĞOñ‘…’}rtxp|tÄ\0…µ¼—Mæ½çÛÃ#Ÿ\0#T\n+\0/n  p×\rJzç<«î T](ú×~íW<ü–ÇnÜ¼~îìÅÙlîgÀƒƒıª\ZíîŞÔXÜ¼~+ß‘6’5Ã@Sÿ;lV»=ü2;ïÎ¾|*ŞÎ˜ÂLµÖ‚ö={æ­=Š¨yø-ï{ï»o\\¿}éÕKû¯_¹úÀ÷>}êÖÍİ¶©C©\ZUÿùŸùã¦¬nŞ¼-Ó‰œÛšx`¬ıà¿ñÌÙ³ŞµÿèıoÿâC?­´K*â(:4ï}>\nü…~ª“UZ›ñxÀ1’hy’ˆ-k—:L¢ˆ§ ‘©˜A!.D¨ı§ÿóï~åÕï½÷Á×¯]][ÛœÏç³Ù´,G·nİØÚ:uå…Ë³ã™®Gåz<ıÿê(‚0ûÃüNĞœ7¨s:HH1¿]¤\0Ì¦3£õ;¾ò‰étúÔÓÏ¬¯(†ùlvãÚ­õÍµ³çÏÕ‹Úµ•jæÍx4ùoşû¿öÿ“?…Úß?>R$)Q¦}F½ÿëŞ3_¿rå_üÄ¿¬—KD` êƒ*IÓD¢±öÁIfaJ(”8FcÊj43ÍJ$ïˆˆ1Æ~„jW•\Z§{ÏU²KxÇ;ßòĞƒ¾òÊKçÎİuóæu\"RÊîonîìŞ¾I‡a:›yöŒo^4vó`ğM\0•¾şË¬_òçLÿ±s0#ñI¹UJ)¢x|tôüs/^¿v£mÚ›7n\ZmÖÖ×cŒÌt|<;sêÔd<®—µ İ¬à]ïşªÍÍí¯|ÇW~Ó·|SQ–1ĞşŞ~AtUğØ[İÜ\\¿uëöo}òÓMSKŒ	œqV¯îÎüì<“Òš”ÑâLŸOTŒ1(…Fëd-•&ZJ)-‰ö.³­WØÕ\0gÜÏ}éÙ»ï»ïµË¯•ÕÈMçMÓl¬oïîİŞÙ9»ÿâ. ajDŞ”N(\'ˆœmÂWÈ;Ê<¹`üæ-¾¸†­Ü‚9\"ÿ<Ñ\"©¨(íÈX,¥”.¬uMÌZd¾üÚ•õµ5ñ?nß¼ı¡ıqU”{{{Ç‡Çi\\ŞúÖ·>÷Ü³mÛ\Zm‚¿ò+¿¾¶±¦zŒ›†9è4»(áÀù&Y‹‡\0b”½¨l©ÒÔcLN€€@Ä¨“¬Ÿw:,–z‡#ƒáÿo(ÿÿ¯ÿßùú\0LMFÎŠg\0\0\0\0IEND®B`‚');
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
INSERT INTO `members` VALUES (4,'Janos','McDonovan','1091-06-24','my house','Cambridge','Cambrdigeshire','CB2  2AS','',1,1,'my house','Jennah Jameson','Mother','081231232','071231231','Clorhyne','I have had 4 heart attacks.','9','Dr. House','612361263','admin@ad.min','N/A','','','male'),(5,'Ricardo','Da Force','1991-05-15','kh2443','','','     ','',2,1,'kh','ÃƒÂ±lkhÃƒÂ±','ÃƒÂ±lk','kl','jh','hlkj','ÃƒÂ±lkh','','lkh','lkj','asdasd@asd.es45','N/A','','','female'),(6,'Joana','Ferras','1012-11-12','qwdqd','','','CB4  2NJ','',3,1,'','Cuenca','','','','','None She is fine!!!','','House','','skarvin@asd.es65','N/A','123123123','123123123','male'),(10,'Jonas','Pendejo','1221-12-12','','','','     ','',4,1,'','','','','','','','','','','skarvin@asdfas.es877','714 271 422','','','male'),(11,'joan','asda','1990-09-14','','','','     ','',5,1,'','','','','','','',NULL,'','','skarvin@asd.esa','698 911 330',NULL,NULL,'male'),(12,'Isidro','Catalan','1111-01-01','ÃƒÂ±lkÃƒÂ±lknlkjb','ÃƒÂ±kmmkljbgfgjhguigh','ghukghbkghhl','CB4  2SQ','Group',6,1,'ÃƒÂ±ljnblknÃ‚Â´ÃƒÂ±lkÃƒÂ±klbjknÃƒÂ±jhlj','fas dfad f','asdfsd fasd','sdaf sdf ','asd fasd','lots','asdkjaskjds ek nsgksfghfgh',NULL,'asdas d','asd fasd fasd','asdasd@asdasd.es','972 513 629','','','male'),(16,'gh','hgfgh','1981-06-24','gf','h','ff','     ','',7,1,'zxdfsdf','','','','','','','','','','skarvin@gmail.com','330 568 590','','','female'),(17,'Mr Joan','Donovan','1990-07-12','House 1','Cambrdige','Cambrdigeshire','CB4  2NA','',8,1,'House 2','My Contact','None','1231231','1231241','Lots and Lots','You dont care mate\r\n\r\n\r\nHAHAHAHA',NULL,'House','','skarvin@marca.es','393 620 591','921231231','666666666','female'),(19,'assdgf','ssdfsd','1212-12-12','','','','     ','',10,0,'','','','','','','','','','','zxczxc@sdfsdgfs.es','822 556 789','','','male'),(20,'dfgdfg','dfgdf','1111-11-11','','','','     ','',11,0,'','','','','','','','','','','sdfdsf@dfgdrg.com','321 265 755','','','female'),(21,'Jano','Mano','1980-12-12','','','','     ','',12,1,'','','','','','','',NULL,'','','janos_hefko@yahoo.co.uk','633 402 358','','','male'),(22,'sfdsd','sdfsdf','1980-01-01','sdfsd','','','     ','',13,1,'sdfsdf','','','','','','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high/ok\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:','','','','asdasd@sdf.com','219 980 637','','','female'),(23,'','','1980-01-01','','','','     ','',14,0,'','','','','','','','','','','a@b.d','324 466 816','','','male'),(24,'Janos','Hefko','1980-01-01','','','','     ','Individual',15,1,'fgdgsfg','','','','','','',NULL,'','','a@b.v','939 563 120','','','female'),(25,'Come baby','score the wikblits','1900-12-12','','','','     ','Student Full Time',16,1,'','','','','','','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:',NULL,'','','d@e.f','983 605 587','','','male'),(26,'','jjjkkklll','1950-11-11','','','','     ','Student Full Time',17,0,'','','','','','','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:','','','','w@f.h','160 942 534','','','male'),(27,'','','2000-11-11','','','','     ','Student Full Time',18,1,'','','','','','','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:',NULL,'','','t@r.k','802 795 886','','','male'),(28,'','','2000-11-11','','','','     ','Student Full Time',19,1,'','','','','','','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:',NULL,'','','e@T.h','249 157 243','','','male'),(29,'','','2222-12-12','','','','     ','Student Full Time',20,1,'','','','','','','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:',NULL,'','','e@q.a','895 821 289','','','male'),(30,'','','1111-12-12','','','','     ','Student Full Time',21,1,'sfsdfsefsdfsdf','','','','','','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:',NULL,'','','r@g.v','951 134 654','','','male'),(31,'','','2222-11-11','','','','     ','Student Full Time',22,1,'','','','','','','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:',NULL,'','','t@r.h','523 963 583','','','male'),(32,'Janos','Hefko','1976-05-06','Flat 11, Mushroom House','Cambridge','Cambridgeshire','CM21 0DF','Student Full Time',77,1,'Futrinka Street','Bernadett Samu','Partner','01223999000','07876444777','none','Heart trouble: 		n\r\nChest pain: 		n\r\nDizzyness:		n\r\nUnconsciousness:		n\r\nBlood pressure:		ok\r\nJoint problems:		n\r\nBack pain or injury:		n\r\nTakes medication:		n\r\nPregnant or recent birth:	n\r\nOperations in 2 years:	n\r\nDoctor is against exercise:	n\r\nAny reason not exercise:	n\r\nEpilepsy:			n\r\nDiabetes:			n\r\nAsthma:			n\r\nComments/Other:\r\nnone','','Dr Bubo','01223777888','janos_hefko@yahoo.com','848 281 181','01223444555','07838123456','male'),(33,'','','1111-11-11','','','','     ','Student Full Time',78,1,'','','','','','none','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high/ok\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:',NULL,'','','r@t.y','968 383 596','','','male'),(34,'','','1212-12-12','','','','     ','Student Full Time',79,1,'','','','','','none','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high/ok\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:','','','','j@dd.gg','508 221 375','','','male'),(35,'ddddeeeee','','1111-11-11','','','','     ','Student Full Time',80,1,'','','','','','none','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high/ok\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:','','','','dd@dd.gg','339 440 921','','','male'),(36,'ggggg','TEST','1999-12-12','','','','     ','Student Full Time',81,0,'','','','','','none','Heart trouble: 		y/n\r\nChest pain: 		y/n\r\nDizzyness:		y/n\r\nUnconsciousness:		y/n\r\nBlood pressure:		low/high/ok\r\nJoint problems:		y/n\r\nBack pain or injury:		y/n\r\nTakes medication:		y/n\r\nPregnant or recent birth:	y/n\r\nOperations in 2 years:	y/n\r\nDoctor is against exercise:	y/n\r\nAny reason not exercise:	y/n\r\nEpilepsy:			y/n\r\nDiabetes:			y/n\r\nAsthma:			y/n\r\nComments/Other:','','','','tes@t.t','678 444 583','','','male');
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
  `is_active` tinyint(4) DEFAULT '1',
  PRIMARY KEY (`id_staff`),
  KEY `id_user` (`id_user`),
  CONSTRAINT `staff_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `users` (`id_user`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (1,'Jani','Mani','1980-01-01','78 Tower Bridge','','','CM21 0DF','Full-time','','Instructor','2010-12-12','2015-12-12',23,'','','','','','','','','','janimani@a.com','','','',1),(6,'George','Clooney','1999-01-01','','','','     ','','','','2001-11-11','2001-11-11',24,'','','','','','','','','','a@b.qqq','','','',1),(7,'asdasd','asasd','1981-06-24','asd','asd','asd','CB4  ','','asdasd','','1911-12-20','1999-12-20',82,'asd','','','','','','','','','masdasd@asdasd.es','','','',0);
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
) ENGINE=InnoDB AUTO_INCREMENT=83 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin@ad.min','21232f297a57a5a743894a0e4a801fc3','manager',1),(2,'asdasd@asd.es45','a21653c0d8bfc7a610adce04a20563a3','member',1),(3,'skarvin@asd.es65','c29b2d78629b6e875de4975aa4c19019','member',1),(4,'skarvin@asdfas.es877','2a157d0eb15265b90c76ce6cbaaddb4e','member',1),(5,'skarvin@asdfas.es','c29b2d78629b6e875de4975aa4c19019','member',1),(6,'t@r.h','4117a218ebdf403bf4093536232846f2','member',1),(7,'skarvin@gmail.com','21232f297a57a5a743894a0e4a801fc3','member',1),(8,'skarvin@marca.es','74803fdf0df9cc0dbc5748743bce962a','member',0),(10,'zxczxc@sdfsdgfs.es','6189bd36da9400207d59ab95e73b3810','member',0),(11,'sdfdsf@dfgdrg.com','ffd5028b197fc0395be5bece481a5524','member',0),(12,'ric@2.com','21232f297a57a5a743894a0e4a801fc3','manager',1),(13,'asdasd@sdf.com','a07d6d3386eb54a223ad282dee1fbfe4','member',1),(14,'a@b.d','e0e73285f609bde970589181a0e1d915','member',0),(15,'a@b.c','1ff38bb62e741aef065a57f555f4b838','member',1),(16,'r@g.v','47310bbcef87ae0a6257bb2b5d1d2046','member',1),(17,'w@f.h','bcef43f532a3dd35af1c6bcf7228d3f2','member',0),(18,'e@T.a','bcef43f532a3dd35af1c6bcf7228d3f2','member',1),(19,'e@T.b','bcef43f532a3dd35af1c6bcf7228d3f2','member',1),(20,'e@T.c','bcef43f532a3dd35af1c6bcf7228d3f2','member',1),(21,'e@T.d','bcef43f532a3dd35af1c6bcf7228d3f2','member',1),(22,'e@T.e','bcef43f532a3dd35af1c6bcf7228d3f2','member',1),(23,'janimani@a.com','bcef43f532a3dd35af1c6bcf7228d3f2','staff',1),(24,'a@b.qqq','bcef43f532a3dd35af1c6bcf7228d3f2','staff',1),(77,'janos_hefko@yahoo.com','8b7523a4232f236111f3c8c495e5bf47','member',1),(78,'r@t.y','95ad068a8b78061f6c4ed0bc68f586b6','member',1),(79,'j@dd.gg','14e1a4e1dca3afa182db7005365ea7a4','member',1),(80,'dd@dd.gg','95ad068a8b78061f6c4ed0bc68f586b6','member',1),(81,'tes@t.t','5493e8142dc17220cd4143e5c2781fa6','member',0),(82,'masdasd@asdasd.es','84ea85a09c9e3c5f74c4b378eae465f8','staff',1);
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

-- Dump completed on 2010-04-22 19:08:24
