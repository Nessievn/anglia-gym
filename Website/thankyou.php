<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>::: Thank You :::</title>
<link rel="stylesheet" id="styleSheet" type="text/css" href="Styles/membertemplate.css" media="screen"/>
</head>

<body>
<div id="wrapper">
  <div id="masthead"><img src="images/bannernew.png" height="100%" width="100%" alt="Trees banner image"/></div>
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
    <div id="centre">Thank you for submitting your changes.</div>
	<div id="footer">
	<?php
	echo date('jS F');
	?>
	</div>
</div>
</body>
</html>
	