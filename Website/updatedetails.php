<?php
require("includes/mysql.php");
require 'smarty/libs/Smarty.class.php';

$smarty = new Smarty;

$smarty->compile_check = true;
$smarty->debugging = false;

session_start();
$link = connect();	
//checks to make sure the result returned is within one row in the database
if(isset($_SESSION["id_member"]) && !isset($_REQUEST['details_update']))
{
	$smarty->assign("logged_in", "1");
	$smarty->assign("name", $_SESSION["name"]);
	$smarty->assign("template", "changedetails");
	
	$sql = "SELECT emerg_contact_name, emerg_contact_relation, emerg_contact_phone, address_1, address_2, postalcode, phone, mobile, email, medical_notes FROM members WHERE id_member = '".$_SESSION["id_member"]."'";
	$result = mysql_query($sql, $link);
	$rows = mysql_num_rows($result);
	if($rows == 1)
	{
		$row = mysql_fetch_array($result);
		$smarty->assign("user_data", $row);
	}
}
else if($_REQUEST['details_update'] == "1" && isset($_SESSION["id_member"]))
{
	$sQuery = "UPDATE members m, users u SET emerg_contact_name = '".$_REQUEST['emerg_contact_name']."', ".
							    "emerg_contact_phone = '".$_REQUEST['emerg_contact_phone']."', ".
							    "emerg_contact_relation = '".$_REQUEST['emerg_contact_relation']."', ".							    
							    "address_1 = '".$_REQUEST['address_1']."', ".
							    "address_2 = '".$_REQUEST['address_2']."', ".
							    "postalcode = '".$_REQUEST['postalcode']."', ".
							    "phone = '".$_REQUEST['phone']."', ".
							    "mobile = '".$_REQUEST['mobile']."', ".
							    "medical_notes = '".$_REQUEST['medical_notes']."', ".							    
							    "email = '".$_REQUEST['email']."', ".
							    "login = '".$_REQUEST['email']."' ".
							    "WHERE m.id_user = u.id_user AND m.id_member = '".$_SESSION['id_member']."'";

	$result = mysql_query($sQuery, $link);
	$rows = mysql_affected_rows($link);
	if($result)
	{
		$smarty->assign("error", "0");
		echo "<script>alert('Your details have been updated!');</script>";		
	}
	else
		$smarty->assign("error", "1");
		
	$smarty->assign("logged_in", "1");
	$smarty->assign("name", $_SESSION["name"]);
	$smarty->assign("template", "changedetails");
	$smarty->assign("user_data", $_REQUEST);							    

}
else
{
	$smarty->assign("template", "wronglogin");
}

$smarty->display('layout.tpl');
	
?>
