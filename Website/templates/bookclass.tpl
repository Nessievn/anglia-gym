<div id="centre"><strong>Book a Class</strong></div>
<table><tr><td>
    <table>
<tr>
<td colspan='10'>
Please, select a range of dates to find the class you want.
</td>
</tr>
      <tr>
        <td style="width: 20em">
          <div id="cont"></div>
         </td>
         <td>
          Start Date:<span id="start" style="font-weight:bold; text-align: center; margin-top: 1em;">Click to select start date</span>
          <br />
          End Date:<span id="end" style="font-weight:bold; text-align: center; margin-top: 1em;"></span>          
        </td>
      <td colspan='10'>
                <span id='my_span'></span>
      </td>
        
      </tr>
    </table>
</td></tr>
<tr><td align='center'>
{if count($classes)}
Showing classes between {$start} and {$end}
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
        No classes available between the dates {$start} and {$end}
{/foreach}
</tbody>
</table>
</td></tr></table>
{else}
        No classes available between the dates {$start} and {$end}
{/if}

    {literal}
    <script type="text/javascript">//<![CDATA[
	  function load()
	  {
		var start = document.getElementById("start").innerHTML;
		var end = document.getElementById("end").innerHTML;
		var url = 'bookclass.php?start='+start+'&end='+end;
	    location.href = url ;
	  }
      var SELECTED_RANGE = null;
      function getSelectionHandler() {
              var startDate = null;
              var ignoreEvent = false;
              return function(cal) {
                      var selectionObject = cal.selection;

                      // avoid recursion, since selectRange triggers onSelect
                      if (ignoreEvent)
                              return;

                      var selectedDate = selectionObject.get();
                      if (startDate == null) {
                              document.getElementById("my_span").innerHTML = "";                      
                              startDate = selectedDate;
                              SELECTED_RANGE = null;
                              var myDate = Calendar.intToDate(startDate);
                              document.getElementById("start").innerHTML = Calendar.printDate(myDate, "%Y-%m-%d");
                              document.getElementById("end").innerHTML = "Click to select the end date";                              

                              // comment out the following two lines and the ones marked (*) in the else branch
                              // if you wish to allow selection of an older date (will still select range)
                              cal.args.min = Calendar.intToDate(selectedDate);
                              cal.refresh();
                      } else {
                              ignoreEvent = true;
                              selectionObject.selectRange(startDate, selectedDate);
                              ignoreEvent = false;
                              SELECTED_RANGE = selectionObject.sel[0];

                              // alert(SELECTED_RANGE.toSource());
                              //
                              // here SELECTED_RANGE contains two integer numbers: start date and end date.
                              // you can get JS Date objects from them using Calendar.intToDate(number)

                              startDate = null;
//                            document.getElementById("end").innerHTML = selectionObject.print("%Y-%m-%d");
                                                            
                              var myDate = Calendar.intToDate(selectedDate);
                              document.getElementById("end").innerHTML = Calendar.printDate(myDate, "%Y-%m-%d");


                              // (*)
                              cal.args.min = null;
                              cal.refresh();
                              
                              // We add the search button
                              
                              //Create an input type dynamically.
							var element = document.createElement("input");
						 
							//Assign different attributes to the element.
							element.setAttribute("type", "button");
							element.setAttribute("value", "Find Classes!");
							element.setAttribute("name", "find");
							element.setAttribute('onclick','load();'); // for FF
						    element.onclick = function() {load();}; // for IE
						
						 
							var foo = document.getElementById("my_span");
							//Append the element in page (in span).
							foo.appendChild(element);
                              
                              
                      }
              };
      };

      Calendar.setup({
              cont          : "cont",
              fdow          : 1,
              selectionType : Calendar.SEL_SINGLE,
              onSelect      : getSelectionHandler()
      });

    //]]></script>
{/literal}
