<div id="centre"><strong>Choose a Class</strong></div>
<table width='100%' id="hor-minimalist-b" >
    <thead>
    	<tr>
        	<th scope="col">Class Name</th>
            <th scope="col">Date</th>
            <th scope="col">Start Time</th>
            <th scope="col">End Time</th>            
            <th scope="col">Enroll?</th>                        
        </tr>
    </thead>
<tbody>
{foreach from=$classes item=class}
<tr bgcolor='{cycle values="#EBEBEB, #FFFFFF"}'>
<td><a href='bookclass.php?showclass={$class.id_class_instance}'>{$class.name}</a></td>
<td>{$class.date}</td>
<td>{$class.start_time}</td>
<td>{$class.end_time}</td>
{if $class.isBooked == "BOOKED" }
<td><a href='bookclass.php?cancel_booking={$class.id_class_instance}'>Cancel Booking</a></td>
{else}
<td><a href='bookclass.php?enroll_to={$class.id_class_instance}'>Enroll</a></td>
{/if}
</tr>
{foreachelse}
        No classes available!
{/foreach}
</tbody>
</table>
