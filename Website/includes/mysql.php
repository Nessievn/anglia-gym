<?php
/**
 * @desc It holds all the functions to handle the mysql database connection and useful functions
 */
 
 
 /**
 * @desc It connects to the database
 * @return [mysql_link] It conteins the resource number to link to the database connected
 */
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
/**
 * @desc It cleans the string received to prevent sql injection attacks
 * @params [string] $string The string to clean
 * @return [string] The string cleaned
 */
function clean($string)
{
	$string = stripslashes($string);
	$string = mysql_real_escape_string($string);
	return $string;
}

/**
 * @desc It cleans the array received to prevent sql injection attacks
 * @params [array] $aData The array to clean
 * @return [array] The array cleaned
 */
function clean_array($aData)
{
	$aTmp = array();
	foreach($aData as $var => $val)
	{
		$aTmp[$var] = clean($val);
	}
	return $aTmp;
}
/**
 * @desc It checks if the email address it's correct
 * @params [string] $email The email to check
 * @return [string|boolean] It returns false if the email is wrong, if it's right it returns the email
 */
function checkEmail($email){

    if(!preg_match('/^[_A-z0-9-]+((\.|\+)[_A-z0-9-]+)*@[A-z0-9-]+(\.[A-z0-9-]+)*(\.[A-z]{2,4})$/',$email)){
        return false;
    } else {
        return $email;
    }
}


?>
