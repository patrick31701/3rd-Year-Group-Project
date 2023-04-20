using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BusinessLayer;
using MainProject.Owner;

namespace MainProject
{
    public partial class Owner_Base : Form
    {

        #region Instance Attributes
        private User_Login ULogin;
        private IModel Model;
        private string loginID;
        #endregion
        #region Constructors

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Owner_Base(User_Login staff, IModel Model, string loginID)
        {

            InitializeComponent();
            ULogin = staff;
            this.Model = Model;
            this.loginID = loginID;
            label1.Text = Model.CurrentStaff.FirstName;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;

            lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            Owner_Dashboard frmDashboard_vrb = new Owner_Dashboard(ULogin, this.Model, loginID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            Owner_Dashboard frmDashboard_vrb = new Owner_Dashboard(ULogin, this.Model, loginID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }
        private void btnManageManager_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = btnManageManager.Height;
            pnlNav.Top = btnManageManager.Top;
            pnlNav.Left = btnManageManager.Left;
            btnManageManager.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Manage Manager";
            this.pnlFormLoader.Controls.Clear();
            Owner_Manage_Manager frmManager_vrb = new Owner_Manage_Manager(ULogin, this.Model, loginID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmManager_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmManager_vrb);
            frmManager_vrb.Show();
        }


        //private void btnManageProducts_Click_1(object sender, EventArgs e)
        //{
        //    pnlNav.Height = btnManageProducts.Height;
        //    pnlNav.Top = btnManageProducts.Top;
        //    pnlNav.Left = btnManageProducts.Left;
        //    btnManageProducts.BackColor = Color.FromArgb(46, 51, 73);

        //    lblTitle.Text = "Manage Products";
        //    this.pnlFormLoader.Controls.Clear();
        //    Owner_Manage_Products frmProducts_vrb = new Owner_Manage_Products() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //    frmProducts_vrb.FormBorderStyle = FormBorderStyle.None;
        //    this.pnlFormLoader.Controls.Add(frmProducts_vrb);
        //    frmProducts_vrb.Show();
        //}




        private void btnManageMarketingDetails_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnManageMarketingDetails.Height;
            pnlNav.Top = btnManageMarketingDetails.Top;
            pnlNav.Left = btnManageMarketingDetails.Left;
            btnManageMarketingDetails.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Manage Marketing Details";
            this.pnlFormLoader.Controls.Clear();
            Owner_Manage_Marketing_Details frmMarketingDetails_vrb = new Owner_Manage_Marketing_Details(ULogin, this.Model, loginID) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmMarketingDetails_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmMarketingDetails_vrb);
            frmMarketingDetails_vrb.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnManageManager_Leave(object sender, EventArgs e)
        {
            btnManageManager.BackColor = Color.FromArgb(24, 30, 54);
        }

        //private void btnManageProducts_Leave(object sender, EventArgs e)
        //{
        //    btnManageProducts.BackColor = Color.FromArgb(24, 30, 54);
        //}

        private void btnManageMarketingDetails_Leave(object sender, EventArgs e)
        {
            btnManageMarketingDetails.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Model.CurrentStaff = null;
            User_Login login = new User_Login(Model);
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
#endregion