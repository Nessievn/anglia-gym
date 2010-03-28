using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gym_administration
{
    public partial class frm_equipment : Form
    {
        Equipment mbrEquipment;
        
  
        public frm_equipment()
        {
            mbrEquipment = new Equipment();
            InitializeComponent();
        }

        public frm_equipment(int iEquipmentId)
        {
            InitializeComponent();
            mbrEquipment = new Equipment(iEquipmentId);
            if (mbrEquipment.Id_equipment < 1)
                MessageBox.Show("The equipment could not be found");
            else
            {
                txt_equipmentdesc.Text = mbrEquipment.SDescription;
                txt_equipmentname.Text = mbrEquipment.SName;
                textBox1.Text = mbrEquipment.SIdSet.ToString();
                //EXTEND DATABASE AND Equipment class WITH IsSetName ->boolean
                /**
                if (mbrEquipment.SIsSetName == "True")
                    rd_setname.Checked = true;
                else
                    rd_setitem.Checked = true;
                **/
                    
            }
        }

        //Set radiobutton to default state
        private void frm_equipment_Load(object sender, EventArgs e)
        {
            rd_setitem.Checked = true;
        }


 
        //SAVE
        private void button1_Click(object sender, EventArgs e)
        {
            //string sType = (rd_group.Checked) ? "Set Name" : "Set Item";
            MessageBox.Show("CLICK!!!");

            if (txt_equipmentname.Text.Length == 0)
            {
                MessageBox.Show("Please insert a name for the equipment.");
                return;
            }

            mbrEquipment.SDescription = txt_equipmentdesc.Text;
            mbrEquipment.SName = txt_equipmentname.Text;
            mbrEquipment.SIdSet = int.Parse(textBox1.Text);

            mbrEquipment.bSave();

        }

        //CANCEL
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                mbrEquipment.bRemove();
                this.Close();
            }
        }





  
    }
}
