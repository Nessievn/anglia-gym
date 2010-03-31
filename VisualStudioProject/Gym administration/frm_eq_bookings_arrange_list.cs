using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gym_administration
{
    public partial class frm_eq_bookings_arrange_list : Form
    {
        public frm_eq_bookings_arrange_list()
        {
            InitializeComponent();
        }

        //SELECT IF(eb.id_staff IS NULL, 'MEMBER_BOOKING','STAFF_BOOKING') BookingType, eb.id_eq_booking BookingNr, eb.id_member MemberID, CONCAT(m.lastName, ', ', m.firstName) MemberName, eb.id_staff StaffID, CONCAT(s.lastName, ', ', s.firstName) SaffName, eb.id_equipment1 EqID1,  e.name Equipment1, eb.amount1 Amount1, eb.id_equipment2 EqID2, concat('none') Equipment2, eb.amount2 Amount2, eb.id_equipment3 EqID3, concat('none') Equipment3, eb.amount3 Amount3, eb.id_equipment4 EqID4, concat('none') Equipment4, eb.amount4 Amount4, eb.id_equipment5 EqID5, concat('none') Equipment5, eb.amount5 Amount5, eb.date_start, eb.date_due, eb.id_class_instance ClassInstance FROM equipment e, equipment_bookings eb LEFT OUTER JOIN staff s ON eb.id_staff = s.id_staff LEFT OUTER JOIN members m ON eb.id_member = m.id_member WHERE e.id_equipment = eb.id_equipment1 ORDER BY eb.date_due;



    }
}
