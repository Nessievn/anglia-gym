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
    public partial class frm_class : Form
    {
        Class clClass;
        frm_class_list frmClassList;

        //loading from main menu
        public frm_class()
        {
            InitializeComponent();
            clClass = new Class();
            this.frmClassList = null;
            button_remove.Hide();
        }

        //loading from class list to refresh class list after saving added new class to classlist
        public frm_class(frm_class_list frmClassList)
        {
            InitializeComponent();
            clClass = new Class();
            this.frmClassList = frmClassList;
            button_remove.Hide();
        }





        public frm_class(int iClassId, frm_class_list frmClassList)
        {
            InitializeComponent();
            clClass = new Class(iClassId);
            this.frmClassList = frmClassList;
            if (clClass.Id_class < 1)
                MessageBox.Show("The class could not be found");
            else
            {
                txt_classdesc.Text = clClass.SDescription;
                txt_classname.Text = clClass.SName;
                //txt_classname.Text = clClass.SName;

                if (clClass.SType == "Personal")
                    rd_personal.Checked = true;
                else
                    rd_group.Checked = true;
                    
            }
        }
        //Set radiobutton to default state
        private void frm_class_Load(object sender, EventArgs e)
        {
            rd_group.Checked = true;
        }
        //SAVE
        private void button_save_Click(object sender, EventArgs e)
        {
            string sType = (rd_group.Checked)?"Group":"Personal";

            if(txt_classname.Text.Length == 0)
            {
                MessageBox.Show("Please insert a name for the class.");
                return;
            }

            clClass.SDescription = txt_classdesc.Text;
            clClass.SName = txt_classname.Text;
            clClass.SType = sType;

            clClass.bSave();
            if (this.frmClassList != null) this.frmClassList.vLoadClassList();
            this.Close();

        }

        //CLOSE
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (clClass.bRemove() == false)
                {
                    MessageBox.Show("Please make sure that there aren't any class instances for this class.");
                }
                this.Close();
            }
            if (this.frmClassList != null) this.frmClassList.vLoadClassList();
        }

 
    }
}
