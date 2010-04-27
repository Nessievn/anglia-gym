<?php
/**
 * @desc It holds all the functions to handle class bookings.
 * @params [string] enroll_to The class id
 * @params [string] cancel_booking The class id to cancel the booking
 * @params [string] showclass The class id to show the class
 * @params [string] start The starting date of the class to display the classes available
 * @params [string] end The ending date of the class to display the classes available
 * @return [none] No directly returned data. 
 */

/**
 * We make the mysql functions available
 */
require("includes/mysql.php");

/**
 * Smarty template engine
 */
require 'smarty/libs/Smarty.class.php';

/**
 * Connect to the database
 */
$link = connect();	

/**
 * We clean the incoming data first
 */
$req_data = clean_array($_REQUEST);

/**
 * Smarty object creation
 */
$smarty = new Smarty;
$smarty->compile_check = true;
$smarty->debugging = false;

/**
 * Starts the session to make all the session variables available
 */
@session_start();


/**
 * If we want to enroll a member on a class
 */
if(isset($_SESSION["id_member"]) && isset($req_data['enroll_to']) && $req_data['enroll_to'] != "")
{
	echo "<script>
	var answer = confirm('Enroll tho this class?')
	if (!answer) history.back();
	</script>";
	
	$sQuery = "INSERT INTO class_bookings (id_member, id_class_instance, booking_date) VALUES ('".$_SESSION["id_member"]."','".$req_data["enroll_to"]."',NOW())  ON DUPLICATE KEY UPDATE booking_date=NOW()";
	$result = mysql_query($sQuery);
	$iId = mysql_insert_id();
	if($iId > 0)
		echo "<script>alert('You have been enrolled to the class successfully!');</script>";
	else
		echo "<script>alert('You have already a booking on this class.');</script>";
	echo "<script>history.back();</script>";
}
/**
 * If we want to cancel a booking
 */
else if(isset($_SESSION["id_member"]) && isset($req_data['cancel_booking']) && $req_data['cancel_booking'] != "")
{
	echo "<script>
	var answer = confirm('Cancel booking on this class?')
	if (!answer) history.back();
	</script>";
	
	$sQuery = "DELETE FROM class_bookings WHERE id_member = '".$_SESSION["id_member"]."' AND id_class_instance = '".$req_data['cancel_booking']."'";
	$result = mysql_query($sQuery);
	$iNum = mysql_affected_rows();
	if($iNum > 0)
		echo "<script>alert('Your booking has been cancelled!');</script>";
	else
		echo "<script>alert('There was an error cancelling your booking!');</script>";
	echo "<script>history.back();</script>";
}
/**
 * If we want to display the class information
 */
else if($req_data["showclass"]!="" && isset($_SESSION["id_member"]))
{
	$iClassId = $req_data["showclass"];
 	$smarty->assign("template", "showclass");   
	$smarty->assign("logged_in", "1");
	$smarty->assign("name", $_SESSION["name"]);
	// Selects all the class information
	$sQuery = "SELECT c.description, c.type, r.name, ci.id_class_instance, ci.date, c.name, ci.start_time, ci.end_time, CONCAT(s.firstName, ' ', s.lastName) instructorName, IF(cb.id_member IS NULL,'NOT_BOOKED','BOOKED') isBooked, r.name roomName FROM classes c, staff s, rooms r, class_instance ci LEFT OUTER JOIN class_bookings cb ON cb.id_member = '".$_SESSION["id_member"]."' AND cb.id_class_instance = ci.id_class_instance WHERE r.id_room = ci.id_room AND s.id_staff = ci.id_staff AND c.id_class = ci.id_class AND ci.id_class_instance = '".$iClassId."'";
	$result = mysql_query($sQuery);
	$class = mysql_fetch_array($result);
	$smarty->assign("class", $class);
}
/**
 * Default case to display the calendar for selection class and booking
 */
else if(isset($_SESSION["id_member"]))
{
 	$smarty->assign("template", "bookclass");   
	$start_date = $req_data['start'];
	$end_date = $req_data['end'];
	$start_date_ = date("d-m-Y");
	if($start_date == "")
	{
		$start_date_ = date("d-m-Y");
		$start_date = date("Y-m-d");
	}
	else $start_date_ = date("d-m-Y",strtotime($start_date));
	if($end_date == "")
	{
	    $end_date = date("d-m-Y");
            $time = mktime($end_date);
            $new = strtotime('+ 1 week', $time);
            $end_date_ = date("d-m-Y", $new); 
            $end_date = date("Y-m-d", $new); 
	}
	else $end_date_ = date("d-m-Y",strtotime($end_date));
	
	$smarty->assign("start", $start_date_);
	$smarty->assign("end", $end_date_);
	$smarty->assign("logged_in", "1");
	$smarty->assign("name", $_SESSION["name"]);
	// Select all the classes available
	$sQuery = "SELECT ci.id_class_instance, ci.date, c.name, ci.start_time, ci.end_time, IF(cb.id_member IS NULL,'NOT_BOOKED','BOOKED') isBooked FROM classes c, class_instance ci LEFT OUTER JOIN class_bookings cb ON cb.id_member = '".$_SESSION["id_member"]."' AND cb.id_class_instance = ci.id_class_instance WHERE c.id_class = ci.id_class AND ci.date BETWEEN '".$start_date."' AND '".$end_date."'";
	$result = mysql_query($sQuery);
	while($row = mysql_fetch_array($result))
		$classes[] = $row;
	$smarty->assign("classes", $classes);
}
/**
 * If there is no user id in the session variable, we display a wrong login template
 */
else
{
	$smarty->assign("template", "wronglogin");
}
/**
 * We display the default layout
 */
$smarty->display('layout.tpl');
	
?>
