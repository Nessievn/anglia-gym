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

        public frm_main()
        {
            InitializeComponent();

            // OUTLOOK BAR!!
            this.outlookBar = new OutlookBar();
            outlookBar.Location = new Point(0, 50);
            outlookBar.Height = 10;
            outlookBar.Width = 150;
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
        
            // Edit Staff List
            if (sSelectedBand == "manager" && panelIcon.Index.ToString() == "0")
            {
 
            }
            // Edit Class List
            else if (sSelectedBand == "manager" && panelIcon.Index.ToString() == "1")
            {

            }
            // Membership fees
            else if (sSelectedBand == "manager" && panelIcon.Index.ToString() == "2")
            {

            }
            // Edit Room List
            else if (sSelectedBand == "manager" && panelIcon.Index.ToString() == "3")
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
            // Member Search
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
            // Class Search
            else if (sSelectedBand == "staff" && panelIcon.Index.ToString() == "2")
            {

            }
            // Room Search
            else if (sSelectedBand == "staff" && panelIcon.Index.ToString() == "3")
            {

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
                    
                    iconPanel1.AddIcon("Edit Staff List", Image.FromFile(Application.StartupPath + "/../../icons/staff.png"), new EventHandler(PanelEvent));
                    iconPanel1.AddIcon("Edit Class List", Image.FromFile(Application.StartupPath + "/../../icons/calendar_64.png"), new EventHandler(PanelEvent));
                    iconPanel1.AddIcon("Membership Fees", Image.FromFile(Application.StartupPath + "/../../icons/14_64x64.png"), new EventHandler(PanelEvent));
                    iconPanel1.AddIcon("Edit Room List", Image.FromFile(Application.StartupPath + "/../../icons/Vista_icons_03.png"), new EventHandler(PanelEvent));
                    this.outlookBar.SelectBand(0);
                    outlookBar.Show();
                    break;
                case "staff":
                    IconPanel iconPanel2 = new IconPanel("staff");
                    this.outlookBar.AddBand("Staff Functions", iconPanel2);

                    iconPanel2.AddIcon("Add Member", Image.FromFile(Application.StartupPath + "/../../icons/staff.png"), new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Member Search", Image.FromFile(Application.StartupPath + "/../../icons/calendar_64.png"), new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Class Search", Image.FromFile(Application.StartupPath + "/../../icons/14_64x64.png"), new EventHandler(PanelEvent));
                    iconPanel2.AddIcon("Room Search", Image.FromFile(Application.StartupPath + "/../../icons/Vista_icons_03.png"), new EventHandler(PanelEvent));
                    this.outlookBar.SelectBand(0);
                    outlookBar.Show();
                    break;
            }
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
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
