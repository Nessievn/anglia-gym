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


    /**
     * @desc 
     * Form Handler for listing class instances. 
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */ 
    public partial class frm_class_instance_list : Form
    {

        /** 
         * @desc Default constructor for listing class instances
         * This is for loading from main menu, 
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */ 
        public frm_class_instance_list()
        {
            InitializeComponent();
        }

        /** 
          * @desc This method refreshes the booked class instances list
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        public void vLoadDgClassList()
        {
            // Create mysql connection  
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Create source for grid
            BindingSource itemsSource = new BindingSource();
            // Create query
            string query = "SELECT ci.id_class_instance CID, c.name Name, c.type Type, c.description Description, s.firstName Instructor, DATE_FORMAT(ci.date, '%d/%m/%Y') Date, ci.start_time Start, ci.end_time End FROM classes c, class_instance ci, staff s WHERE ci.id_class = c.id_class AND ci.id_staff = s.id_staff ORDER BY ci.date, ci.start_time";
            // Launch query and load result into source
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            // Assign source to grid
            dg_classes.DataSource = itemsSource;
            dg_classes.AllowUserToAddRows = false;
            dg_classes.ReadOnly = true;
        }


        /** 
          * @desc This method loads in every time the frm_class_instance_list is instantiated
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void frm_class_instance_list_Load(object sender, EventArgs e)
        {
            this.vLoadDgClassList();
        }

        /** 
          * @desc Executes when a grid cell is double clicked on the class instance list
	      * It loads in the class instance belonging to the cell
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void dg_classes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Get the class instance id at current cell
                int id_class_instance = int.Parse(dg_classes.Rows[e.RowIndex].Cells[0].Value.ToString());
                // Open class instance form
                frm_class_instance_arrange frmClassInstanceArrange = new frm_class_instance_arrange(id_class_instance, this);
                frmClassInstanceArrange.ShowDialog();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.ToString());
                return;
            }
        }

        /** 
          * @desc Executes when the "Search" button is clicked
	      * It creates a new list of class instances based on search criteria given by the user
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
            // Create query
            string query = "SELECT ci.id_class_instance CID, c.name Name, c.type Type, c.description Description, s.firstName Instructor, DATE_FORMAT(ci.date, '%d/%m/%Y') Date, ci.start_time Start, ci.end_time End FROM classes c, class_instance ci, staff s WHERE ci.id_class = c.id_class AND ci.id_staff = s.id_staff ";
            // Check user input and create query for search
            if (txt_classname.Text != "")
                query += " AND c.name LIKE '%" + txt_classname.Text + "%'";

            query += " ORDER BY ci.date, ci.start_time";
            // Launch query and load result into source
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            // Assign source to grid
            dg_classes.DataSource = itemsSource;
            dg_classes.AllowUserToAddRows = false;
            dg_classes.ReadOnly = true;
        }


    }
}
