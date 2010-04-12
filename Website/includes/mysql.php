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

function clean_array($aData)
{
	$aTmp = array();
	foreach($aData as $var => $val)
	{
		$aTmp[$var] = clean($val);
	}
	return $aTmp;
}

function checkEmail($email){

    if(!preg_match('/^[_A-z0-9-]+((\.|\+)[_A-z0-9-]+)*@[A-z0-9-]+(\.[A-z0-9-]+)*(\.[A-z]{2,4})$/',$email)){
        return false;
    } else {
        return $email;
    }
}


?>
