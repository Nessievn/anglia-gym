	{if $error == 1}
	<font color='red'>{$error_desc}</font>
	{/if}
    <form action="updatedetails.php" method="post">
    <div id="centre"><strong>Change Your Details</strong>
    <br />Please note you can only change your contact details online. Any other details you would need to speak to a member of staff at the Fitness Centre.
    <table>
    	<tr>
			<td>Emergency Contact Name: </td>
            <td><input type="text" name="emerg_contact_name" value="{$user_data.emerg_contact_name}"/></td>            
        </tr>
        <tr>
   			<td>Emergency Contact Telephone: </td>
            <td><input type="text" name="emerg_contact_phone" value="{$user_data.emerg_contact_phone}"/></td>   
        </tr>
        <tr>
			<td>Relation to Applicant: </td>
            <td><input type="text" name="emerg_contact_relation" value="{$user_data.emerg_contact_relation}" /></td>   
        </tr>
        <tr>
        	<td>Address 1: </td>
            <td><textarea rows="3" cols="18" name="address_1"/>{$user_data.address_1}</textarea></td>
        </tr> 
        <tr>
        	<td>Address 2: </td>
            <td><textarea rows="3" cols="18" name="address_2"/>{$user_data.address_2}</textarea></td>
        </tr> 
        <tr>
        	<td>Postcode: </td>
            <td><input type="text" name="postalcode" value="{$user_data.postalcode}"/></td>
        </tr> 
        <tr>
        	<td>Home Telephone Number: </td>
            <td><input type="text" name="phone" value="{$user_data.phone}"/></td>
        </tr>
        <tr>
        	<td>Mobile Telephone Number: </td>
            <td><input type="text" name="mobile" value="{$user_data.mobile}"/></td>
        </tr>
        <tr>
        	<td>Email Address: </td>
            <td><input type="text" name="email" value="{$user_data.email}"/></td>
        </tr>
        <tr>
        	<td>Medical Notes: </td>
            <td><textarea rows="3" cols="18" name="medical_notes"/>{$user_data.medical_notes}</textarea></td>
        </tr>
        <tr>
	        <td></td>
        	<td><input type="submit" value="Submit Changes" title="Please click here to submit your changes" /></td>
        </tr>
    </table>
    </div>
    <input type="hidden" name="details_update" value="1"/>
    </form>

	