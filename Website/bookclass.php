<?php
require("includes/mysql.php");
require 'smarty/libs/Smarty.class.php';

$smarty = new Smarty;

$smarty->compile_check = true;
$smarty->debugging = false;

session_start();
$link = connect();	
if(isset($_SESSION["id_member"]) && isset($_REQUEST['enroll_to']) && $_REQUEST['enroll_to'] != "")
{
	echo "<script>
	var answer = confirm('Enroll tho this class?')
	if (!answer) history.back();
	</script>";
	
	//TODO: Check if there is enough room
	$sQuery = "INSERT INTO class_bookings (id_member, id_class_instance, booking_date) VALUES ('".$_SESSION["id_member"]."','".$_REQUEST["enroll_to"]."',NOW())  ON DUPLICATE KEY UPDATE booking_date=NOW()";
	$result = mysql_query($sQuery);
	$iId = mysql_insert_id();
	if($iId > 0)
		echo "<script>alert('You have been enrolled to the class successfully!');</script>";
	else
		echo "<script>alert('You have already a booking on this class.');</script>";
	echo "<script>history.back();</script>";
}
else if(isset($_SESSION["id_member"]) && isset($_REQUEST['cancel_booking']) && $_REQUEST['cancel_booking'] != "")
{
	echo "<script>
	var answer = confirm('Cancel booking on this class?')
	if (!answer) history.back();
	</script>";
	
	//TODO: Check if there is enough room
	$sQuery = "DELETE FROM class_bookings WHERE id_member = '".$_SESSION["id_member"]."' AND id_class_instance = '".$_REQUEST['cancel_booking']."'";
	$result = mysql_query($sQuery);
	$iNum = mysql_affected_rows();
	if($iNum > 0)
		echo "<script>alert('Your booking has been cancelled!');</script>";
	else
		echo "<script>alert('There was an error cancelling your booking!');</script>";
	echo "<script>history.back();</script>";
}

else if($_REQUEST["showclass"]!="" && isset($_SESSION["id_member"]))
{
	$iClassId = clean($_REQUEST["showclass"]);
 	$smarty->assign("template", "showclass");   
	$smarty->assign("logged_in", "1");
	$smarty->assign("name", $_SESSION["name"]);
	// Select all the classes available
	$sQuery = "SELECT c.description, c.type, r.name, ci.id_class_instance, ci.date, c.name, ci.start_time, ci.end_time, CONCAT(s.firstName, ' ', s.lastName) instructorName, IF(cb.id_member IS NULL,'NOT_BOOKED','BOOKED') isBooked, r.name roomName FROM classes c, staff s, rooms r, class_instance ci LEFT OUTER JOIN class_bookings cb ON cb.id_member = '".$_SESSION["id_member"]."' AND cb.id_class_instance = ci.id_class_instance WHERE r.id_room = ci.id_room AND s.id_staff = ci.id_staff AND c.id_class = ci.id_class AND ci.id_class_instance = '".$iClassId."'";
	$result = mysql_query($sQuery);
	$class = mysql_fetch_array($result);
	$smarty->assign("class", $class);
}
//checks to make sure the result returned is within one row in the database
else if(isset($_SESSION["id_member"]) && !isset($_REQUEST['book_class']) && $_REQUEST['start'] == "" && $_REQUEST['end'] == "")
{
 	$smarty->assign("template", "bookclass");   
	$smarty->assign("logged_in", "1");
	$smarty->assign("name", $_SESSION["name"]);
}
else if(isset($_SESSION["id_member"]) && $_REQUEST['start'] != "" && $_REQUEST['end'] != "")
{
	$start_date = clean($_REQUEST['start']);
	$end_date = clean($_REQUEST['end']);
	
 	$smarty->assign("template", "showclasses");   
	$smarty->assign("logged_in", "1");
	$smarty->assign("name", $_SESSION["name"]);
	// Select all the classes available
	$sQuery = "SELECT ci.id_class_instance, ci.date, c.name, ci.start_time, ci.end_time, IF(cb.id_member IS NULL,'NOT_BOOKED','BOOKED') isBooked FROM classes c, class_instance ci LEFT OUTER JOIN class_bookings cb ON cb.id_member = '".$_SESSION["id_member"]."' AND cb.id_class_instance = ci.id_class_instance WHERE c.id_class = ci.id_class AND ci.date BETWEEN '".$start_date."' AND '".$end_date."'";
	$result = mysql_query($sQuery);
	while($row = mysql_fetch_array($result))
		$classes[] = $row;
	$smarty->assign("classes", $classes);
}
else
{
	$smarty->assign("template", "wronglogin");
}

$smarty->display('layout.tpl');
	
?>
