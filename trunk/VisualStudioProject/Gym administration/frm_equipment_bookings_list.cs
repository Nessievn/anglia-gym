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

    /**
     * @desc 
     * Form Handler for listing equipment bookings
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */ 
    public partial class frm_equipment_bookings_list : Form
    {
        EquipmentBooked clEquipmentBooked;


        /** 
          * @desc Default constructor for listing equipment bookings
          * This is for loading from main menu, 
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        public frm_equipment_bookings_list()
        {
            InitializeComponent();
        }


        /** 
          * @desc This method loads in every time the frm_equipment_bookings_list is instantiated
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void frm_equipment_bookings_list_Load(object sender, EventArgs e)
        {
            vLoadBookedList();
        }

        /** 
          * @desc This method refreshes the equipment booking list
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        public void vLoadBookedList()
        {
            // Create mysql connection            
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Create source for grid
            BindingSource itemsSource = new BindingSource();
            // Create query
            string query = "SELECT eb.id_eq_booking BookingNr, eb.id_equipment EqID,  e.name Equipment, eb.borrowedamount Amount, eb.id_member MemberID, CONCAT(m.lastName, ', ', m.firstName) MemberName, eb.id_staff StaffID, CONCAT(s.lastName, ', ', s.firstName) SaffName, eb.id_class_instance ClassID, eb.date_start, eb.date_due FROM equipment e, equipment_bookings eb LEFT OUTER JOIN staff s ON eb.id_staff = s.id_staff LEFT OUTER JOIN members m ON eb.id_member = m.id_member WHERE e.id_equipment = eb.id_equipment AND ((eb.isreturned IS NULL) OR (eb.isreturned = 0)) ORDER BY e.name";
            // Launch query and load result into source
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            // Assign source to grid
            dg_eqbookings.DataSource = itemsSource;
            dg_eqbookings.AllowUserToAddRows = false;
            dg_eqbookings.ReadOnly = true;
        }


        /** 
          * @desc Executes when a grid cell is double clicked on the equipment bookings list
	      * It loads in the class belonging to the cell
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void dg_eqbookings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieve equipment booking details from grid row
            int id_eq_booking = int.Parse(dg_eqbookings.Rows[e.RowIndex].Cells[0].Value.ToString());
            string equipmentName = dg_eqbookings.Rows[e.RowIndex].Cells[2].Value.ToString();
            int borrowedAmount = int.Parse(dg_eqbookings.Rows[e.RowIndex].Cells[3].Value.ToString());
            // Show return dialog for confirming amount to be returned
            frm_message_box myMessageBox = new frm_message_box();
            string result = myMessageBox.ShowBox(Utils.MB_CUST4, "", "How many "+equipmentName+" would you like to return?",borrowedAmount.ToString());

            // Reference how to use TryParse
            //ref  in Bibliography at (Alani, S., 2006)

            // Check the result of user input
 	        double Num;
 	        bool isNum = double.TryParse(result, out Num);
            if (isNum)
            {
                // If there is something to return but not everything
                if ((int.Parse(result) > 0) && (result != "Cancel"))
                {
                    // Save the new amount into eq. booking
                    this.clEquipmentBooked = new EquipmentBooked(id_eq_booking);
                    this.clEquipmentBooked.BorrowedAmount = int.Parse(result);
                    this.clEquipmentBooked.IsReturned = false;
                    this.clEquipmentBooked.SaveEquipmentBooking();
                }
                // If all amount of this booking is to be returned
                else if (result != "Cancel")
                {
                    // Mark the booking as returned
                    this.clEquipmentBooked = new EquipmentBooked(id_eq_booking);
                    this.clEquipmentBooked.BorrowedAmount = 0;
                    this.clEquipmentBooked.IsReturned = true;
                    this.clEquipmentBooked.SaveEquipmentBooking();

                }
                // Refresh eq. booking list
                this.vLoadBookedList();
            }
        }
    }
}
