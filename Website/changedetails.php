<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:::: Change your Details ::::</title>
<link rel="stylesheet" id="styleSheet" type="text/css" href="Styles/membertemplate.css" media="screen"/>
</head>

<body>
<form>
<div id="wrapper">
  <div id="masthead"><a href="home.php"><img border="0" src="images/bannernew.png" height="100%" width="100%" alt="Trees banner image"/></a></div>
    <div id="content"></div>
    <div id="leftpanel">
  	 	<div id="login">Welcome {member name goes here}
		<br />
        <br />
        Not you? Click Logout to return to the login page.
		<input type="submit" value="Logout"/>
        </div>
    	<div id="menu">
	    <a href="changedetails.php"><img border="0" src="images/membermenu1_1.png" alt="Change your Details"/></a>
            <a href="bookclass.php"><img border="0" src="images/membermenu2_2.png" alt="Book a Class"/></a>
      </div>
    </div>
    <div id="centre"><strong>Change Your Details</strong>
    <br />Please note you can only change your contact details online. Any other details you would need to speak to a member of staff at the Fitness Centre.
    <table>
    	<tr>
        	<td>Title: </td>
            <td><input type="text" /></td>
            <td></td>
			<td>Emergency Contact Name: </td>
            <td><input type="text" /></td>            
        </tr>
        <tr>
        	<td>Forename: </td>
            <td><input type="text" /></td>
            <td></td>
			<td>Emergency Contact Telephone: </td>
            <td><input type="text" /></td>   
        </tr>
        <tr>
        	<td>Surname: </td>
            <td><input type="text" /></td>
            <td></td>
			<td>Relation to Applicant: </td>
            <td><input type="text" /></td>   
        </tr>
        <tr>
        	<td>Address: </td>
            <td><input type="text" /></td>
        </tr>
        <tr>
        	<td></td>
            <td><input type="text" /></td>
        </tr>      
        <tr>
        	<td></td>
            <td><input type="text" /></td>
        </tr> 
        <tr>
        	<td></td>
            <td><input type="text" /></td>
        </tr> 
        <tr>
        	<td>Postcode: </td>
            <td><input type="text" /></td>
        </tr> 
        <tr>
        	<td>Home Telephone Number: </td>
            <td><input type="text" /></td>
        </tr>
        <tr>
        	<td>Evening Telephone Number: </td>
            <td><input type="text" /></td>
        </tr>
        <tr>
        	<td>Daytime Telephone Number: </td>
            <td><input type="text" /></td>
        </tr>
        <tr>
        	<td>Email Address: </td>
            <td><input type="text" /></td>
        </tr>
        <tr>
        	<td>Medical Conditions: </td>
            <td><input type="text" height="50" /></td>
            <td></td>
        </tr>
        <tr>
	        <td></td>
        	<td><input type="submit" value="Submit Changes" title="Please click here to submit your changes" /></td>
        </tr>
    </table>
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
	