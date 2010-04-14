using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gym_administration
{
    public partial class frm_equipment_bookings_list : Form
    {
        EquipmentBooked eqEquipmentBooked;

        public frm_equipment_bookings_list()
        {
            InitializeComponent();
        }

   


        private void frm_equipment_bookings_list_Load(object sender, EventArgs e)
        {
            vLoadBookedList();
        }

        public void vLoadBookedList()
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string sQuery = "SELECT eb.id_eq_booking BookingNr, eb.id_equipment EqID,  e.name Equipment, eb.borrowedamount Amount, eb.id_member MemberID, CONCAT(m.lastName, ', ', m.firstName) MemberName, eb.id_staff StaffID, CONCAT(s.lastName, ', ', s.firstName) SaffName, eb.id_class_instance ClassID, eb.date_start, eb.date_due FROM equipment e, equipment_bookings eb LEFT OUTER JOIN staff s ON eb.id_staff = s.id_staff LEFT OUTER JOIN members m ON eb.id_member = m.id_member WHERE e.id_equipment = eb.id_equipment AND ((eb.isreturned IS NULL) OR (eb.isreturned = 0)) ORDER BY e.name";
            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_eqbookings.DataSource = bSource;
            dg_eqbookings.AllowUserToAddRows = false;
            dg_eqbookings.ReadOnly = true;
        }


        private void dg_eqbookings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_eq_booking = int.Parse(dg_eqbookings.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = dg_eqbookings.Rows[e.RowIndex].Cells[2].Value.ToString();
            int borrowedAmount = int.Parse(dg_eqbookings.Rows[e.RowIndex].Cells[3].Value.ToString());
            

            frm_message_box myMessageBox = new frm_message_box();
            string result = myMessageBox.ShowBox(Utils.MB_CUST4, "", "How many "+name+" would you like to return?",borrowedAmount.ToString());
 
 
 	                        //ref  http://social.msdn.microsoft.com/Forums/en-US/winforms/thread/84990ad2-5046-472b-b103-f862bfcd5dbc
 
 
 	                        double Num;
 	                        bool isNum = double.TryParse(result, out Num);
 	                        if (isNum)
 	                        {

                                if ((int.Parse(result) > 0) && (result != "Cancel"))
                                {
                                    this.eqEquipmentBooked = new EquipmentBooked(id_eq_booking);
                                    this.eqEquipmentBooked.BorrowedAmount = int.Parse(result);
                                    this.eqEquipmentBooked.IsReturned = false;
                                    this.eqEquipmentBooked.bSave();
                                }
                                else if (result != "Cancel")
                                {
                                    this.eqEquipmentBooked = new EquipmentBooked(id_eq_booking);
                                    this.eqEquipmentBooked.BorrowedAmount = 0;
                                    this.eqEquipmentBooked.IsReturned = true;
                                    this.eqEquipmentBooked.bSave();

                                }
                                this.vLoadBookedList();
 	                        }

        }



    }
}
