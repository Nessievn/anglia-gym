<div id="centre"><strong>Class ({$class.name})</strong></div>
<table id="one-column-emphasis" width='100%'>
<tr><th scope="col">Class Name</th><td>{$class.name}</td></tr>
<tr><th scope="col">Date</th><td>{$class.date}</td></tr>
<tr><th scope="col">Start Time</th><td>{$class.start_time}</td></tr>
<tr><th scope="col">End Time</th><td>{$class.end_time}</td></tr>
<tr><th scope="col">Instructor</th><td>{$class.instructorName}</td></tr>
<tr><th scope="col">Description</th><td>{$class.description}</td></tr>
<tr><th scope="col">Type</th><td>{$class.type}</td></tr>
<tr><th scope="col">Room</th><td>{$class.roomName}</td></tr>
{if $class.isBooked == "BOOKED" }
<tr><th scope="col">Enroll?</th><td><a href='bookclass.php?cancel_booking={$class.id_class_instance}'>Cancel Booking</a></td></tr>
{else}
<tr><th scope="col">Enroll?</th><td><a href='bookclass.php?enroll_to={$class.id_class_instance}'>Enroll</a></td></tr>
{/if}
</table>
