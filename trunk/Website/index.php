<?php
/**
 * @desc It displays the index page and holds the login safely
 * @params [string] login Login entered
 * @params [string] password Password entered 
 * @params [string] logout When the user requests to logout
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
 * Stores the login data
 */
$login = $req_data['login'];
$password = $req_data['password'];

/**
 * set the cache limiter to 'private' 
 */
session_cache_limiter('private');
$cache_limiter = session_cache_limiter();

/**
 * set the cache expire to 30 minutes 
 */
session_cache_expire(30);
$cache_expire = session_cache_expire();

/**
 * Starts the session to make all the session variables available
 */
session_start();
/**
 * Logout
 */
if($req_data["logout"]=="1")
{
	@session_destroy();
	$smarty->assign("logged_in", "0");
	$smarty->assign("template", "index");	
}
/**
 * Login
 */
else if($login != ""  && $password != "")
{
	$sql = "SELECT m.id_member, CONCAT(m.firstName,' ',m.lastName) name FROM users u, members m WHERE u.login = '".$login."' and u.password = MD5('".$password."') AND u.active = 1 AND m.id_user = u.id_user";
	$result = mysql_query($sql, $link);
	$rows = mysql_num_rows($result);
	if($rows == 1)
	{
		$row = mysql_fetch_array($result);
		$_SESSION["id_member"] = $row["id_member"];
		$_SESSION["name"] = $row["name"];
		$smarty->assign("name", $row["name"]);
		$smarty->assign("template", "memberwelcome");
		$smarty->assign("logged_in", "1");
	}
	else
		$smarty->assign("template", "wronglogin");	
}
/**
 * The login has ben successful
 */
else if(isset($_SESSION["id_member"]))
{
	$smarty->assign("template", "memberwelcome");
	$smarty->assign("logged_in", "1");
	$smarty->assign("name", $_SESSION["name"]);
}
/**
 * If we need to show a template we show it, if not we show the index template
 */
else
{
	$template = ($req_data['s']!="")?$req_data['s']:"index";
	$smarty->assign("template", $template);
}
/**
 * The default template
 */
$smarty->display('layout.tpl');
	
?>
