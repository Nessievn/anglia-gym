<?php
require("includes/mysql.php");
require 'smarty/libs/Smarty.class.php';

$smarty = new Smarty;
$smarty->compile_check = true;
$smarty->debugging = false;
$req_data = clean_array($_REQUEST);
session_start();
$link = connect();	
//checks to make sure the result returned is within one row in the database
if(isset($_SESSION["id_member"]) && !isset($req_data['details_update']))
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
else if($req_data['details_update'] == "1" && isset($_SESSION["id_member"]))
{
	if(checkEmail($req_data['email']) == false)
	{
			$smarty->assign("error", "1");
			$smarty->assign("error_desc","The e-mail is incorrect!");
	}
	else
	{
		$sQuery = "UPDATE members m, users u SET emerg_contact_name = '".$req_data['emerg_contact_name']."', ".
									"emerg_contact_phone = '".$req_data['emerg_contact_phone']."', ".
									"emerg_contact_relation = '".$req_data['emerg_contact_relation']."', ".							    
									"address_1 = '".$req_data['address_1']."', ".
									"address_2 = '".$req_data['address_2']."', ".
									"postalcode = '".$req_data['postalcode']."', ".
									"phone = '".$req_data['phone']."', ".
									"mobile = '".$req_data['mobile']."', ".
									"medical_notes = '".$req_data['medical_notes']."', ".							    
									"email = '".$req_data['email']."', ".
									"login = '".$req_data['email']."' ".
									"WHERE m.id_user = u.id_user AND m.id_member = '".$_SESSION['id_member']."'";
	
		$result = mysql_query($sQuery, $link);
		$rows = mysql_affected_rows($link);
		if($result)
		{
			$smarty->assign("error", "0");
			echo "<script>alert('Your details have been updated!');</script>";		
		}
		else
		{
			$smarty->assign("error", "1");
			$smarty->assign("error_desc","There has been an error while updating your personal details, please check the data.");
		}
	}		
	$smarty->assign("logged_in", "1");
	$smarty->assign("name", $_SESSION["name"]);
	$smarty->assign("template", "changedetails");
	$smarty->assign("user_data", $req_data);							    

}
else
{
	$smarty->assign("template", "wronglogin");
}

$smarty->display('layout.tpl');
	
?>
