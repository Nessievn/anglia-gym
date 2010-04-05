<?php
function connect()
{
	$host="localhost";
	$username="gym";
	$password="gym";
	$dbname="gym";

	$link = mysql_connect($host,$username,$password) or die("cannot connect");
	mysql_select_db($dbname,$link) or die ("cannot select database");

	return $link;
}

function clean($string)
{
	$string = stripslashes($string);
	$string = mysql_real_escape_string($string);
	return $string;
}

?>
