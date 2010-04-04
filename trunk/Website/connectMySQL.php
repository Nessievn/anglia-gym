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

?>
