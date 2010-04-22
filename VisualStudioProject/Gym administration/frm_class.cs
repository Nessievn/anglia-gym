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
     * @desc Form Handler for classes. 
     * It is for adding or modifying a class.
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */    
    public partial class frm_class : Form
    {
        Class clClass;
	    // Declare a reference to the class list, so this object can call its methods
        // This is basically for calling a refresh of the class list just before this form is closed
        frm_class_list frmClassList;

       /** 
        * @desc Default constructor for creating new class from main menu.
        * This is for loading from main menu, 
        * the class list reference is not necessary so it will be set to null
        * @params [none] No input parameter. 
        * @return [none] No directly returned data. 
        */ 
        public frm_class()
        {
            InitializeComponent();
            clClass = new Class();
            this.frmClassList = null;
            // Hide the Remove button as a class not yet existing can't be removed
            button_remove.Enabled = false;
            rd_group.Checked = false;
        }

        /** 
         * @desc Constructor for creating new class, that was opened from class list.
         * (To be able to refresh class list after saving the new class)
         * @params [frm_class_list] frmClassList: by taking this parameter there will be a reference
         * to the class list so it can be refreshed after saving the new class
         * @return [none] No directly returned data. 
         */
        public frm_class(frm_class_list frmClassList)
        {
            InitializeComponent();
            clClass = new Class();
            // Create reference to the parent form (frm_class_list)
            this.frmClassList = frmClassList;
	    // Hide the Remove button as a new class can't be removed
            button_remove.Enabled = false;
            rd_group.Checked = false;
        }

        /** 
          * @desc Constructor for editing an existing class.
          * (To be able to refresh class list after saving the edited class)
	      * @params [int] id_class: identifies the class to modify
          * @params [frm_class_list] frmClassList: by taking this parameter there will be a reference
          * to the class list so it can be refreshed after saving the edited class
          * @return [none] No directly returned data. 
          */
        public frm_class(int id_class, frm_class_list frmClassList)
        {
            InitializeComponent();
            // Create reference to the parent form (frm_class_list)
            this.frmClassList = frmClassList;
            // Load in class details for specified class
            clClass = new Class(id_class);
            // Check if there was such a class in the database
            if (clClass.Id_class == -1)
                MessageBox.Show("The class could not be found");
            // If the class was found
            else
            {
                // Display table field contents on form
                txt_classdesc.Text = clClass.Description;
                txt_classname.Text = clClass.Name;
                if (clClass.Type == "Personal")
                    rd_personal.Checked = true;
                else
                    rd_group.Checked = true;
            }
        }

        /** 
          * @desc Executes when the "Save" button is clicked
	      * It checks user input and then calls for saving the new class.
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void button_save_Click(object sender, EventArgs e)
        {
            string type = (rd_group.Checked)?"Group":"Personal";
            // Check user inputs and formats
            if(txt_classname.Text.Length == 0)
            {
                MessageBox.Show("Please insert a name for the class.");
                return;
            }
            clClass.Description = txt_classdesc.Text;
            clClass.Name = txt_classname.Text;
            clClass.Type = type;
            // Calling the method to save the new class
            if (clClass.SaveClass())
            {
                // Refresh the class list in previous form
                if (this.frmClassList != null) this.frmClassList.vLoadClassList();
                this.Close();
            }
        }

        // Close this form
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /** 
          * @desc Executes when the "Remove" button is clicked
	      * It asks for confirmation and then calls for removing the class.
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void button_remove_Click(object sender, EventArgs e)
        {
            // Confirming action
            DialogResult result = MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Check remove result
                if (clClass.RemoveClass() == false)
                {
                    MessageBox.Show("Please make sure that there aren't any class instances for this class.");
                }
                else
                {
                    if (this.frmClassList != null) this.frmClassList.vLoadClassList();
                    this.Close();
                }
            }
            // Refresh the class list in previous form
            
        }

 
    }
}

