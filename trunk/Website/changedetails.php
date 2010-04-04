<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:::: Change your Details ::::</title>
<link rel="stylesheet" id="styleSheet" type="text/css" href="Styles/membertemplate.css" media="screen"/>
</head>

<body>
<div id="wrapper">
  <div id="masthead"><a href="home.php"><img border="0" src="images/bannernew.png" height="100%" width="100%" alt="Trees banner image"/></a></div>
    <div id="content"></div>
    <div id="leftpanel">
		<div id="login">
		<form action="loggedout.php" method=post>
			Welcome {member name goes here}
			<br />
			<br />
			Not you? Click Logout to return to the login page.
			<input type="submit" value="Logout"/>
		</form>
        </div>
    	<div id="menu">
	    <a href="changedetails.php"><img border="0" src="images/membermenu1_1.png" alt="Change your Details"/></a>
            <a href="bookclass.php"><img border="0" src="images/membermenu2_2.png" alt="Book a Class"/></a>
      </div>
    </div>
    <div id="centre"><strong>Change Your Details</strong>
    <br />Please note you can only change your contact details online. Any other details you would need to speak to a member of staff at the Fitness Centre.
	<form action="thankyou.php" method=post>
    <table>
    	<tr>
        	<td>Forename: </td>
            <td><input type="text" name="firstName"/></td>
            <td></td>
			<td>Emergency Contact Name: </td>
            <td><input type="text" name="emerg_contact_name"/></td>            
        </tr>
        <tr>
        	<td>Surname: </td>
            <td><input type="text"  name="lastName"/></td>
            <td></td>
			<td>Emergency Contact Telephone: </td>
            <td><input type="text" name="emerg_contact_phone"/></td>   
        </tr>
        <tr>
        	<td>Address: </td>
            <td><input type="text" name="address_1"/></td>
            <td></td>
			<td>Relation to Applicant: </td>
            <td><input type="text" name="emerg_contact_relation"/></td>   
        </tr>
        <tr>
        	<td></td>
            <td><input type="text" name="city"/></td>
        </tr>      
        <tr>
        	<td></td>
            <td><input type="text" name="county"/></td>
        </tr> 
        <tr>
        	<td>Postcode: </td>
            <td><input type="text" name="postalcode"/></td>
        </tr> 
        <tr>
        	<td>Home Telephone Number: </td>
            <td><input type="text" name="phone"/></td>
        </tr>
        <tr>
        	<td>Mobile: </td>
            <td><input type="text" name="mobile"/></td>
        </tr>
        <tr>
        	<td>Email Address: </td>
            <td><input type="text" name="email"/></td>
        </tr>
        <tr>
        	<td>Medical Conditions: </td>
            <td><input type="text" height="50" name="medical_notes"/></td>
            <td></td>
        </tr>
        <tr>
	        <td></td>
        	<td><input type="submit" value="Submit Changes" title="Please click here to submit your changes" /></td>
        </tr>
    </table>
	<?php
		//includes database connection
		include("connectMySQL.php");
	
		//requests info from text boxes
		$firstname = $_REQUEST['firstName'];
		$lastname = $_REQUEST['lastName'];
		$address = $_REQUEST['address_1'];
		$city = $_REQUEST['city'];
		$county = $_REQUEST['county'];
		$postcode = $_REQUEST['postalcode'];
		$hometel = $_REQUEST['phone'];
		$mobtel = $_REQUEST['mobile'];
		$email = $_REQUEST['email'];
		$mednotes = $_REQUEST['medical_notes'];
		$emergname = $_REQUEST['emerg_contact_name'];
		$emergphone = $_REQUEST['emerg_contact_phone'];
		$emergrel = $_REQUEST['emerg_contact_relation'];
	
		//this protects against MySQL query injections
		$firstname = stripslashes($firstname);
		$lastname = stripslashes($lastname);
		$address = stripslashes($address);
		$city = stripslashes($city);
		$county = stripslashes($county);
		$postcode = stripslashes($postcode);
		$hometel = stripslashes($hometel);
		$mobtel = stripslashes($mobtel);
		$email = stripslashes($email);
		$mednotes = stripslashes($mednotes);
		$emergname = stripslashes($emergname);
		$emergphone = stripslashes($emergphone);
		$emergrel = stripslashes($emergrel);
		
		$firstname = mysql_real_escape_string($firstname);
		$lastname = mysql_real_escape_string($lastname);
		$address = mysql_real_escape_string($address);
		$city = mysql_real_escape_string($city);
		$county = mysql_real_escape_string($county);
		$postcode = mysql_real_escape_string($postcode);
		$hometel = mysql_real_escape_string($hometel);
		$mobtel = mysql_real_escape_string($mobtel);
		$email = mysql_real_escape_string($email);
		$mednotes = mysql_real_escape_string($mednotes);
		$emergname = mysql_real_escape_string($emergname);
		$emergphone = mysql_real_escape_string($emergphone);
		$emergrel = mysql_real_escape_string($emergrel);
		
		//sql query
		$sql = "";
		
	?>
	</form>
    </div>
	<div id="footer">
	<?php
	echo date('jS F');
	?>
	</div>
</div>
</body>
</html>
	