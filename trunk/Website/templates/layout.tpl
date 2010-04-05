<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:::: Welcome to Oak Trees Gym and Fitness Centre ::::</title>
<link rel="stylesheet" id="styleSheet" type="text/css" href="../css/nonmembertemplate.css" media="screen"/>
<style type="text/css">
<!--
@import url("../css/table_style.css");
-->
</style>

  <script src="../js/jscal2.js"></script>
    <script src="../js/lang/en.js"></script>
    <link rel="stylesheet" type="text/css" href="../css/jscal2.css" />
    <link rel="stylesheet" type="text/css" href="../css/border-radius.css" />
</head>
<body>
<form action='index.php' method='post'>
<div id="wrapper">
  <div id="masthead"><a href="index.php"><img border="0" src="images/bannernew.png" height="100%" width="100%" alt="Trees banner image"/></a></div>
    <div id="content"></div>
    <div id="leftpanel">
    {if $logged_in == "1"}

      	 	<div id="login">
      	 	    {$name}
			<table><tr>
                	<td>
                	<input type="submit" value="Log Out"/>
                	<input type="hidden" name="logout" value="1"/>
                	</td>
                	
                	</tr>
            </table>
        </div>   
       	<div id="menu">
       	    <a href="updatedetails.php"><img border="0" src="images/membermenu1_1.png" alt="Change your Details"/></a>
            <a href="bookclass.php"><img border="0" src="images/membermenu2_2.png" alt="Book a Class"/></a>
      </div>

    {else}
  	 	<div id="login">Please enter your membership details and click the button below to log in.
			<table>
            	<tr>
                	<td>Login (E-mail): </td>
                    <td><input name='login' type="text" /></td>
                </tr>    
                <tr>
                	<td>Password: </td>
                    <td><input name='password' type="password" /></td>
                </tr>
                <tr>
                	<td><input type="submit" value="Log In"/></td>
                </tr>
            </table>
        </div>   
      	<div id="menu">
	    <a href="index.php?s=registernew"><img border="0" src="images/nomembermenu1_1.png" alt="Become a Member"/></a>
            <a href="index.php?s=staff"><img border="0" src="images/nomembermenu2_2.png" alt="Meet the Staff"/></a>
            <a href="index.php?s=contact"><img border="0" src="images/nomembermenu3_3.png" alt="Contact Us"/></a>
      </div>
    {/if}
    </div>
    </form>
    <div id="centre">
    
    <!-- Here goes the template content -->
     {include file="$template.tpl"}
    
    </div>
	<div id="footer"></div>
</div>
</body>
</html>
	