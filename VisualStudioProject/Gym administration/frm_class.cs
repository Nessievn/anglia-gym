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
        public frm_class()
        {
            InitializeComponent();
            clClass = new Class();
        }
        public frm_class(int iClassId)
        {
            InitializeComponent();
            clClass = new Class(iClassId);
            if (clClass.Id_class < 1)
                MessageBox.Show("The class could not be found");
            else
            {
                txt_classdesc.Text = clClass.SDescription;
                txt_classname.Text = clClass.SName;
                if (clClass.SType == "Personal")
                    rd_personal.Checked = true;
                else
                    rd_group.Checked = true;
                    
            }
        }

        private void frm_class_Load(object sender, EventArgs e)
        {
            rd_group.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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
        }

    }
}
