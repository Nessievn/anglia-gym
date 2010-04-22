using System;
using System.Collections.Generic;
using System.Collections;
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
     * Form Handler for listing staff
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
    public partial class frm_staff_list : Form
    {

        /** 
         * @desc Default constructor for creating staff list from main menu.
         * This is for loading from main menu, 
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */ 
        public frm_staff_list()
        {
            InitializeComponent();
            vLoadStaffList();
        }

        /** 
          * @desc This method refreshes the staff list
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        public void vLoadStaffList()
        {
            // Create mysql connection          
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Create source for grid
            BindingSource itemsSource = new BindingSource();
            // Create query for retrieving all staff
            string query = "SELECT id_staff MID, firstName as 'First Name', lastName 'Last Name', DATE_FORMAT(birthdate,\"%d/%m/%Y\") DOB, email 'EMail' FROM staff s, users u WHERE u.id_user = s.id_user ORDER BY id_staff";
            // Launch query and load result into source
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            // Assign source to grid
            dg_staff.DataSource = itemsSource;
            dg_staff.AllowUserToAddRows = false;
            dg_staff.ReadOnly = true;
        }

        /** 
          * @desc Executes when a grid cell is double clicked on the staff list
	      * It loads in the staff belonging to the cell for editing
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void dg_staff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Get the staff id at current cell
                int id_staff = int.Parse(dg_staff.Rows[e.RowIndex].Cells[0].Value.ToString());
                // Create an edit staff form
                frm_staff frm_stf = new frm_staff(id_staff, this);
                frm_stf.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        /** 
          * @desc Executes when the Search button is clicked
	      * It creates a new list of staff based on search criteria given by the user
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_search_Click(object sender, EventArgs e)
        {
            // Create mysql connection            
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Create source for grid
            BindingSource itemsSource = new BindingSource();
            // Create start of query
            string query = "SELECT id_staff MID, staff_number NO, firstName as 'First Name', lastName 'Last Name', DATE_FORMAT(birthdate,\"%d/%m/%Y\") DOB, email 'EMail' FROM staffs WHERE 1 = 1 ";
            // Check user input and create query for search
            if (txt_firstName.Text != "")
                query += " AND firstName LIKE '%" + txt_firstName.Text + "%'";
            if (txt_lastName.Text != "")
                query += " AND lastName LIKE '%" + txt_lastName.Text + "%'";
            if (txt_email.Text != "")
                query += " AND email LIKE '%" + txt_email.Text + "%'";
            string sDate = Utils.sGetMysqlDate(txt_dob.Text);
            if (sDate != "0000-00-00")
                query += " AND birthdate = '" + sDate + "'";

            query += "  ORDER BY id_staff";
            // Launch query and load result into source
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            // Assign source to grid
            dg_staff.DataSource = itemsSource;
            dg_staff.AllowUserToAddRows = false;
            dg_staff.ReadOnly = true;
        }

        // Cancel/Close
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /** 
          * @desc Executes when the Add Staff button is clicked
	      * It invokes the frm_staff panel for adding a new staff
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_addstaffmember_Click(object sender, EventArgs e)
        {
            
            frm_staff frmStaff = new frm_staff(this);
            frmStaff.ShowDialog();
        }



        
        

    }
}
