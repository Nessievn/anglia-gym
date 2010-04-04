<?php
require("connectMySQL.php");
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:::: Checking Login ::::</title>
<link rel="stylesheet" id="styleSheet" type="text/css" href="Styles/nonmembertemplate.css" media="screen"/>
</head>

<body>
<form>
<div id="wrapper">
  <div id="masthead"><a href="home.php"><img border="0" src="images/bannernew.png" height="100%" width="100%" alt="Trees banner image"/></a></div>
    <div id="content"></div>
    <div id="leftpanel">
  	 	<div id="login">Please enter your membership details and click the button below to log in.
			<table>
	            <tr></tr>
            	<tr></tr>
                	<td>Membership Number: </td>
                    <td><input type="text" /></td>
                <tr></tr>
                	<td>Password: </td>
                    <td><input type="text" /></td>
                <tr></tr>
                	<td></td>
                	<td><input type="submit" value="Login"/></td>
            </table>
        </div>
    	<div id="menu">
	    	<a href="register.php"><img border="0" src="images/nomembermenu1_1.png" alt="Become a Member"/></a>
            <a href="staff.php"><img border="0" src="images/nomembermenu2_2.png" alt="Meet the Staff"/></a>
            <a href="contact.php"><img border="0" src="images/nomembermenu3_3.png" alt="Contact Us"/></a>
      </div>
    </div>
    <div id="centre">
	<?php
	
	//based on script from http://www.phpeasystep.com/phptu/6.html - has a snippet to prevent SQL injections
	
	$link = connect();	
	$login = $_REQUEST['login'];
	$password = $_REQUEST['password'];
	//this protects against MySQL query injections
	$login = stripslashes($login);
	$password = stripslashes($password);
	$login = mysql_real_escape_string($login);
	$password = mysql_real_escape_string($password);
		
	$sql = "SELECT * FROM users WHERE login = '".$login."' and password = MD5('".$password."')";
	$result = mysql_query($sql, $link);
	//checks to make sure the result returned is within one row in the database
	$row = mysql_num_rows($result);
	
	if($row == 1)
	{
		session_register("login");
		session_register("password");
		header("location:memberwelcome.php");
	}
	else
	{
		echo "You have entered an incorrect username or password.";	
	}
		
	?>
	</div>
	<div id="footer">
	<?php
	echo date('jS F');
	?>
	</div>
</div>
</form>
</body>
</html>
	
