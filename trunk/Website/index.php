<?php
require("includes/mysql.php");
require 'smarty/libs/Smarty.class.php';

$smarty = new Smarty;
$smarty->compile_check = true;
$smarty->debugging = false;

$link = connect();	
$login = $_REQUEST['login'];
$password = $_REQUEST['password'];
//this protects against MySQL query injections
$login = stripslashes($login);
$password = stripslashes($password);
$login = mysql_real_escape_string($login);
$password = mysql_real_escape_string($password);

/* set the cache limiter to 'private' */
session_cache_limiter('private');
$cache_limiter = session_cache_limiter();

/* set the cache expire to 30 minutes */
session_cache_expire(30);
$cache_expire = session_cache_expire();
session_start();
if($_REQUEST["logout"]=="1")
{
	@session_destroy();
	$smarty->assign("logged_in", "0");
	$smarty->assign("template", "index");	
}
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
else if(isset($_SESSION["id_member"]))
{
	$smarty->assign("template", "memberwelcome");
	$smarty->assign("logged_in", "1");
	$smarty->assign("name", $_SESSION["name"]);
}
else
{
	$template = ($_REQUEST['s']!="")?$_REQUEST['s']:"index";
	$smarty->assign("template", $template);
}

$smarty->display('layout.tpl');
	
?>
