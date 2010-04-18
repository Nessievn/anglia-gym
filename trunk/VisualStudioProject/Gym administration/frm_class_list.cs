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
     * Form Handler for listing classes
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */ 
    public partial class frm_class_list : Form
    {

        /** 
         * @desc Default constructor for listing classes
         * This is for loading from main menu, 
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */ 
        public frm_class_list()
        {
            InitializeComponent();
        }



        /** 
          * @desc This method loads in every time the frm_class_list is instantiated
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void frm_class_list_Load(object sender, EventArgs e)
        {
            vLoadClassList();
        }

        /** 
          * @desc This method refreshes the class list
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        public void vLoadClassList()
        {
            // Create mysql connection            
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Create source for grid
            BindingSource itemsSource = new BindingSource();
            // Create query
            string query = "SELECT id_class CID, name Name, type Type, description Description FROM classes ORDER BY id_class";
            // Launch query and load result into source
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            // Assign source to grid
            dg_classes.DataSource = itemsSource;
            dg_classes.AllowUserToAddRows = false;
            dg_classes.ReadOnly = true;
            dg_classes.Columns[3].Width = 300;
        }


        /** 
          * @desc Executes when a grid cell is double clicked on the class list
	      * It loads in the class belonging to the cell
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void dg_classes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Get the class id at current cell
                int id_class = int.Parse(dg_classes.Rows[e.RowIndex].Cells[0].Value.ToString());
                // Open class instance form
                frm_class frmClass = new frm_class(id_class, this);
                frmClass.ShowDialog();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.ToString());
                return;
            }
        }

        /** 
          * @desc Executes when "Add Class" button is clicked
	      * It loads in an empty frm_class form for adding new class
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_addclass_Click(object sender, EventArgs e)
        {
            // Passing "this" as parameter to lett the frm_class form to know where was it called from
            frm_class frmClass = new frm_class(this);
            frmClass.ShowDialog();
        }

        /** 
          * @desc Executes when the "Search" button is clicked
	      * It creates a new list of classes based on search criteria given by the user
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
            string query = "SELECT id_class CID, name Name, type Type, description Description FROM classes WHERE 1 = 1";
            // Check user input and create query for search
            if (txt_classname.Text != "")
                query += " AND name LIKE '%" + txt_classname.Text + "%'";

            query += "  ORDER BY id_class";
            // Launch query and load result into source
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            // Assign source to grid
            dg_classes.DataSource = itemsSource;
            dg_classes.AllowUserToAddRows = false;
            dg_classes.ReadOnly = true;
        }



    }
}
