using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OutlookBarNm;

namespace Gym_administration
{
    public partial class frm_main : Form
    {
        private int childFormNumber = 0;
        private OutlookBar outlookBar;
        private User userLogged;

        internal User UserLogged
        {
            get { return userLogged; }
            set { userLogged = value; }
        }

        public frm_main()
        {
            InitializeComponent();

            // OUTLOOK BAR!!
            this.outlookBar = new OutlookBar();
            outlookBar.Location = new Point(0, 50);
            outlookBar.Height = 10;
            outlookBar.Width = 170;
            outlookBar.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(outlookBar);
            outlookBar.Initialize();
            outlookBar.Hide();
            
        }

        public void PanelEvent(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            PanelIcon panelIcon = ctrl.Tag as PanelIcon;
            string sSelectedBand = panelIcon.iconPanel.sBandName;

            foreach (Form childForm in MdiChildren)
                childForm.Close();

        
// Edit Staff
            if (sSelectedBand == "manager" && panelIcon.Index.ToString() == "0")
            {
                // Creating the child form login
                frm_staff_list mdiFrmStaffList = new frm_staff_list();
                // We check if the form is already opened
                if (Utils.bIsAlreadyOpened(mdiFrmStaffList)) return;
                // Set the Parent Form of the Child window.
                mdiFrmStaffList.MdiParent = this;

                // Display the new form.
                mdiFrmStaffList.Show();  
            }
// Membership fees
            else if (sSelectedBand == "manager" && panelIcon.Index.ToString() == "1")
            {
               // Creating the child form login
                frm_payments mdiFrmPayments = new frm_payments();
                // We check if the form is already opened
                if (Utils.bIsAlreadyOpened(mdiFrmPayments)) return;
                // Set the Parent Form of the Child window.
                mdiFrmPayments.MdiParent = this;

                // Display the new form.
                mdiFrmPayments.Show();  
            }
// Edit Room
            else if (sSelectedBand == "manager" && panelIcon.Index.ToString() == "2")
            {
                // Creating the child form login
                frm_room_list mdiFrmRoomList = new frm_room_list();
                // We check if the form is already opened
                if (Utils.bIsAlreadyOpened(mdiFrmRoomList)) return;
                // Set the Parent Form of the Child window.
                mdiFrmRoomList.MdiParent = this;

                // Display the new form.
                mdiFrmRoomList.Show();
            }
// Add New Equipment
            else if (sSelectedBand == "manager" && panelIcon.Index.ToString() == "3")
            {
                // Creating the child form login
                frm_equipment mdiFrmEquipment = new frm_equipment();
                // We check if the form is already opened
                if (Utils.bIsAlreadyOpened(mdiFrmEquipment)) return;
                // Set the Parent Form of the Child window.
                mdiFrmEquipment.MdiParent = this;

                // Display the new form.
                mdiFrmEquipment.Show();
            }
// Edit Equipment
            else if (sSelectedBand == "manager" && panelIcon.Index.ToString() == "4")
            {
                // Creating the child form login
                frm_equipment_list mdiFrmEquipmentList = new frm_equipment_list();
                // We check if the form is already opened
                if (Utils.bIsAlreadyOpened(mdiFrmEquipmentList)) return;
                // Set the Parent Form of the Child window.
                mdiFrmEquipmentList.MdiParent = this;

                // Display the new form.
                mdiFrmEquipmentList.Show();  
            }
// Add Class
            else if (sSelectedBand == "manager" && panelIcon.Index.ToString() == "5")
            {
                frm_class frmClass = new frm_class();
                frmClass.MdiParent = this.MdiParent;
                frmClass.Show();
            }
// Edit Class
            else if (sSelectedBand == "manager" && panelIcon.Index.ToString() == "6")
            {
                // Creating the child form login
                frm_class_list mdiFrmClassList = new frm_class_list();
                // We check if the form is already opened
                if (Utils.bIsAlreadyOpened(mdiFrmClassList)) return;
                // Set the Parent Form of the Child window.
                mdiFrmClassList.MdiParent = this;

                // Display the new form.
                mdiFrmClassList.Show();
            }
//Edit Arranged Class
            else if (sSelectedBand == "manager" && panelIcon.Index.ToString() == "7")
            {
                // Creating the child form login
                frm_class_instance_list mdiFrmClassArrangeList = new frm_class_instance_list();
                // We check if the form is already opened
                if (Utils.bIsAlreadyOpened(mdiFrmClassArrangeList)) return;
                // Set the Parent Form of the Child window.
                mdiFrmClassArrangeList.MdiParent = this;

                // Display the new form.
                mdiFrmClassArrangeList.Show();
            }



// Add Member
            else if (sSelectedBand == "staff" && panelIcon.Index.ToString() == "0")
            {
                // Creating the child form login
                frm_member mdiFrmMember = new frm_member();
                // We check if the form is already opened
                if (Utils.bIsAlreadyOpened(mdiFrmMember)) return;
                // Set the Parent Form of the Child window.
                mdiFrmMember.MdiParent = this;

                // Display the new form.
                mdiFrmMember.Show();  
            }
//Edit Member
            else if (sSelectedBand == "staff" && panelIcon.Index.ToString() == "1")
            {
                // Creating the child form login
                frm_member_list mdiFrmMemberList = new frm_member_list();
                // We check if the form is already opened
                if (Utils.bIsAlreadyOpened(mdiFrmMemberList)) return;
                // Set the Parent Form of the Child window.
                mdiFrmMemberList.MdiParent = this;

                // Display the new form.
                mdiFrmMemberList.Show();  
            }

//Book Class
            else if (sSelectedBand == "staff" && panelIcon.Index.ToString() == "2")
            {
                // Creating the child form login
                frm_class_instance_arrange mdiFrmClassArrange = new frm_class_instance_arrange();
                // We check if the form is already opened
                if (Utils.bIsAlreadyOpened(mdiFrmClassArrange)) return;
                // Set the Parent Form of the Child window.
                mdiFrmClassArrange.MdiParent = this;

                // Display the new form.
                mdiFrmClassArrange.Show();
            }
//Search Class Bookings
            else if (sSelectedBand == "staff" && panelIcon.Index.ToString() == "3")
            {
                // Creating the child form login
                frm_class_instance_list mdiFrmClassArrangeList = new frm_class_instance_list();
                // We check if the form is already opened
                if (Utils.bIsAlreadyOpened(mdiFrmClassArrangeList)) return;
                // Set the Parent Form of the Child window.
                mdiFrmClassArrangeList.MdiParent = this;

                // Display the new form.
                mdiFrmClassArrangeList.Show();  
            }
// Book Equipment
            else if (sSelectedBand == "staff" && panelIcon.Index.ToString() == "4")
            {

            }
// Search Eq. Bookings
            else if (sSelectedBand == "staff" && panelIcon.Index.ToString() == "5")
            {

            }

// Room Search
            else if (sSelectedBand == "staff" && panelIcon.Index.ToString() == "6")
            {
          // Creating the child form room
                frm_room_list mdiFrmRoomList = new frm_room_list();
                // We check if the form is already opened
                if (Utils.bIsAlreadyOpened(mdiFrmRoomList)) return;
                // Set the Parent Form of the Child window.
                mdiFrmRoomList.MdiParent = this;

                // Display the new form.
                mdiFrmRoomList.Show();  
            }


// Login Options
            else if (sSelectedBand == "all" && panelIcon.Index.ToString() == "0")
            {
                // Creating the child form login
                frm_login_options mdiFrmLoginOptions = new frm_login_options(this);
                // We check if the form is already opened
                if (Utils.bIsAlreadyOpened(mdiFrmLoginOptions)) return;
                // Set the Parent Form of the Child window.
                mdiFrmLoginOptions.MdiParent = this;

                // Display the new form.
                mdiFrmLoginOptions.Show();
            }
                // Log Out
            else if (sSelectedBand == "all" && panelIcon.Index.ToString() == "1")
            {
                Controls.Remove(this.outlookBar);

                foreach (Form childForm in MdiChildren)
                    childForm.Close();

                // Creating the child form login
                frm_login mdiFrmLogin = new frm_login(this);
                // Set the Parent Form of the Child window.
                mdiFrmLogin.MdiParent = this;
                // Display the new form.
                mdiFrmLogin.Show();
            }

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frm_main_Load(object sender, EventArgs e)
        {   
            // Creating the child form login
            frm_login mdiFrmLogin = new frm_login(this);
            // Set the Parent Form of the Child window.
            mdiFrmLogin.MdiParent = this;
            // Display the new form.
            mdiFrmLogin.Show();     
            
        }
        private void loadOutlookBarButtons(string sProfile)
        {
            switch (sProfile)
            {
                case "manager":
                    IconPanel iconPanel1 = new IconPanel("manager");
                    this.outlookBar.AddBand("Management Functions", iconPanel1);
                    
                    iconPanel1.AddIcon("Edit Staff", Image.FromFile(Application.StartupPath + "/../../icons/staff_edit_128.png"), new EventHandler(PanelEvent));
                    iconPanel1.AddIcon("Membership Fees", Image.FromFile(Application.StartupPath + "/../../icons/payment_128.png"), new EventHandler(PanelEvent));
                    iconPanel1.AddIcon("Edit Room", Image.FromFile(Application.StartupPath + "/../../icons/room_edit_128.png"), new EventHandler(PanelEvent));
                    iconPanel1.AddIcon("Add New Equipment", Image.FromFile(Application.StartupPath + "/../../icons/equipment_add_smaller_128.png"), new EventHandler(PanelEvent));
                    iconPanel1.AddIcon("Edit Equipment", Image.FromFile(Application.StartupPath + "/../../icons/equipment_edit_128.png"), new EventHandler(PanelEvent));
                    
                    iconPanel1.AddIcon("Add Class", Image.FromFile(Application.StartupPath + "/../../icons/class_add_128.png"), new EventHandler(PanelEvent));
                    iconPanel1.AddIcon("Edit Class", Image.FromFile(Application.StartupPath + "/../../icons/class_edit_128.png"), new EventHandler(PanelEvent));
                    iconPanel1.AddIcon("Edit Arranged Class", Image.FromFile(Application.StartupPath + "/../../icons/class_book_edit_128.png"), new EventHandler(PanelEvent));
                    
                    this.outlookBar.SelectBand(0);
                    outlookBar.Show();
                    break;
                case "staff":
                    IconPanel iconPanel2 = new IconPanel("staff");
                    this.outlookBar.AddBand("Staff Functions", iconPanel2);

                    iconPanel2.AddIcon("Add New Member", Image.FromFile(Application.StartupPath + "/../../icons/member_add_128.png"), new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Edit Member", Image.FromFile(Application.StartupPath + "/../../icons/member_edit_128.png"), new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Arrange Class", Image.FromFile(Application.StartupPath + "/../../icons/class_book_128.png"), new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Edit Arranged Class", Image.FromFile(Application.StartupPath + "/../../icons/class_book_edit_128.png"), new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Book Equipment", Image.FromFile(Application.StartupPath + "/../../icons/equipment_book_128.png"), new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Search Eq. Bookings", Image.FromFile(Application.StartupPath + "/../../icons/equipment_book_search_128.png"), new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Search Rooms", Image.FromFile(Application.StartupPath + "/../../icons/room_search_128.png"), new EventHandler(PanelEvent));
                    this.outlookBar.SelectBand(0);
                    outlookBar.Show();
                    break;
                case "all":
                    IconPanel iconPanel3 = new IconPanel("all");
                    this.outlookBar.AddBand("Login Options", iconPanel3);
                    iconPanel3.AddIcon("Change Password", Image.FromFile(Application.StartupPath + "/../../icons/password_edit_128.png"), new EventHandler(PanelEvent));
                    this.outlookBar.SelectBand(0);
                    outlookBar.Show();
                    break;
            }
        }
        public void vLoadOutlookBar()
        {
            // OUTLOOK BAR!!
            this.outlookBar = new OutlookBar();
            outlookBar.Location = new Point(0, 50);
            outlookBar.Height = 10;
            outlookBar.Width = 170;
            outlookBar.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(outlookBar);
            outlookBar.Initialize();
            outlookBar.Hide();
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
        }
        // Loads form options depending on the user profile
        public void ShowUserOptions(string userProfile)
        {
            switch (userProfile)
            {
                case "manager":

                    this.loadOutlookBarButtons("manager");
                    this.loadOutlookBarButtons("staff");
                    break;

                case "staff":

                    this.loadOutlookBarButtons("staff");
                    break;
            }
            this.loadOutlookBarButtons("all");
        }

        private void vSetUserLogged(User user)
        {
            this.userLogged = user;
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
