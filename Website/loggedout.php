<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:::: Logged Out ::::</title>
<link rel="stylesheet" id="styleSheet" type="text/css" href="Styles/membertemplate.css" media="screen"/>
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
    <div id="centre">You have been successfully logged out. Please click <a href="home.php">here</a> to return to the home page.</div>
	<div id="footer">
	<?php
	echo date('jS F');
	?>
	</div>
</div>
</form>
</body>
</html>
	