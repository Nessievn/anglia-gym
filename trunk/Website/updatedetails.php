<?php
/**
 * @desc It shows and updates the member's contact details
 * @param [string] details_update It is 1 when we update the details
 * @param [string] email Member's email
 * @param [string] emerg_contact_name Member's emergency contact name
 * @param [string] emerg_contact_phone Member's emergency contact phone number
 * @param [string] emerg_contact_relation Member's emergency contact relationship
 * @param [string] address_1 Member's address line 1
 * @param [string] address_2 Member's address line 2
 * @param [string] postalcode Member's postal code
 * @param [string] phone Member's landline number
 * @param [string] mobile Member's mobile phone
 * @param [string] medical_notes Member's medical notes
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
 * It shows the member's details
 */
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
/**
 * Update the member's details
 */
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
/**
 * No valid login
 */
else
{
	$smarty->assign("template", "wronglogin");
}

/**
 * We display the page
 */
$smarty->display('layout.tpl');
	
?>
