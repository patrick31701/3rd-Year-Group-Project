using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using BusinessEntities;

namespace MainProject
{
    public partial class GMManage_StaffDetails : Form
    {

        #region Instance Attributes
        private IModel Model;
        private Manager_Dashboard md;
        #endregion
        #region Constructors

        public GMManage_StaffDetails(Manager_Dashboard md, IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
            DisplayProducts();
            tbFirstName_MNGStaffDetails.ReadOnly = true;
            tbLastName_MNGStaffDetails.ReadOnly = true;
            tbEmail_MNGStaffDetails.ReadOnly = true;
            tbPassword_MNGStaffDetails.ReadOnly = true;
            tbStaffType_MNGStaffDetails.ReadOnly = true;
            tbStaffID_MNGStaffDetails.ReadOnly = true;
            tbMobileNumber_MNGStaffDetails.ReadOnly = true;
        }
        #endregion
        public GMManage_StaffDetails()
        {
            InitializeComponent();
        }

        private void GMManage_StaffDetails_Load(object sender, EventArgs e)
        {
        }
        private void DisplayProducts()
        {
            foreach (Staff staff in Model.StaffList)
            {
                lvStaffDetails.Items.Add(new ListViewItem(new string[] {
                    staff.StaffID,
                    staff.FirstName+" "+staff.LastName,
                    staff.FirstName,
                    staff.LastName,
                    staff.Email,
                    staff.CurPassword,
                    staff.StaffType,
                    staff.Mobile
                }));
            }
        }

        private void lvStaffDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem x in lvStaffDetails.SelectedItems)
            {
                tbFirstName_MNGStaffDetails.Text = x.SubItems[2].Text;
                tbLastName_MNGStaffDetails.Text = x.SubItems[3].Text;
                tbEmail_MNGStaffDetails.Text = x.SubItems[4].Text;
                tbPassword_MNGStaffDetails.Text = x.SubItems[5].Text;
                tbStaffID_MNGStaffDetails.Text = x.SubItems[0].Text;
                tbStaffType_MNGStaffDetails.Text = x.SubItems[6].Text;
                tbMobileNumber_MNGStaffDetails.Text = x.SubItems[7].Text;
            }
        }

        private void btnAddMNG_StaffDetails_Click(object sender, EventArgs e)
        {
            string NewStaffID = Model.makeStaffID();
            string FirstName = tbFirstName_MNGStaffDetails.Text;
            string LastName = tbLastName_MNGStaffDetails.Text;
            string StaffType = tbStaffType_MNGStaffDetails.Text;
            string Email = tbEmail_MNGStaffDetails.Text;
            string Password = tbPassword_MNGStaffDetails.Text;
            int Mobile = int.Parse(tbMobileNumber_MNGStaffDetails.Text);

            tbFirstName_MNGStaffDetails.Text = "";
            tbLastName_MNGStaffDetails.Text = "";
            tbStaffType_MNGStaffDetails.Text = "";
            tbEmail_MNGStaffDetails.Text = "";
            tbPassword_MNGStaffDetails.Text = "";
            tbMobileNumber_MNGStaffDetails.Text = "";


           if (btnAddMNG_StaffDetails.Text == "Add")
            {
                tbFirstName_MNGStaffDetails.ReadOnly = false;
                tbLastName_MNGStaffDetails.ReadOnly = false;
                tbEmail_MNGStaffDetails.ReadOnly = false;
                tbPassword_MNGStaffDetails.ReadOnly = false;
                tbStaffType_MNGStaffDetails.ReadOnly = false;
                tbMobileNumber_MNGStaffDetails.ReadOnly = false;
                btnAddMNG_StaffDetails.Text = "Add Staff";
            }
            else
            {
                tbFirstName_MNGStaffDetails.ReadOnly = true;
                tbLastName_MNGStaffDetails.ReadOnly = true;
                tbEmail_MNGStaffDetails.ReadOnly = true;
                tbPassword_MNGStaffDetails.ReadOnly = true;
                tbStaffType_MNGStaffDetails.ReadOnly = true;
                tbStaffID_MNGStaffDetails.ReadOnly = true;
                tbMobileNumber_MNGStaffDetails.ReadOnly = true;

                var confirm = MessageBox.Show("Are you sure you want to add this product ? ", "Decline ? ", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    Model.addStaffDetails(NewStaffID, FirstName, LastName, StaffType, Email, Password, Mobile);
                }

                tbFirstName_MNGStaffDetails.ReadOnly = true;
                tbLastName_MNGStaffDetails.ReadOnly = true;
                tbEmail_MNGStaffDetails.ReadOnly = true;
                tbPassword_MNGStaffDetails.ReadOnly = true;
                tbStaffType_MNGStaffDetails.ReadOnly = true;
                tbStaffID_MNGStaffDetails.ReadOnly = true;
                tbMobileNumber_MNGStaffDetails.ReadOnly = true;
                btnAddMNG_StaffDetails.Text = "Add";

            }

        }

        private void btnEditMNG_StaffDetails_Click(object sender, EventArgs e)
        {
            string StaffID      = tbStaffID_MNGStaffDetails.Text;
            string FirstName    = tbFirstName_MNGStaffDetails.Text;
            string LastName     = tbLastName_MNGStaffDetails.Text;
            string StaffType    = tbStaffType_MNGStaffDetails.Text;
            string Email        = tbEmail_MNGStaffDetails.Text;
            string Password     = tbPassword_MNGStaffDetails.Text;
            int    Mobile       = int.Parse(tbMobileNumber_MNGStaffDetails.Text);
            

            if (btnEditMNG_StaffDetails.Text == "Edit")
            {
                tbFirstName_MNGStaffDetails.ReadOnly = false;
                tbLastName_MNGStaffDetails.ReadOnly = false;
                tbEmail_MNGStaffDetails.ReadOnly = false;
                tbPassword_MNGStaffDetails.ReadOnly = false;
                tbStaffType_MNGStaffDetails.ReadOnly = false;
                tbStaffID_MNGStaffDetails.ReadOnly = false;
                tbMobileNumber_MNGStaffDetails.ReadOnly = false;
                btnEditMNG_StaffDetails.Text = "Save";
            }
            else
            {
                tbFirstName_MNGStaffDetails.ReadOnly = true;
                tbLastName_MNGStaffDetails.ReadOnly = true;
                tbEmail_MNGStaffDetails.ReadOnly = true;
                tbPassword_MNGStaffDetails.ReadOnly = true;
                tbStaffType_MNGStaffDetails.ReadOnly = true;
                tbStaffID_MNGStaffDetails.ReadOnly = true;
                tbMobileNumber_MNGStaffDetails.ReadOnly = true;


                var confirm = MessageBox.Show("Are you sure you want to edit this product ? ", "Decline ? ", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    Model.editStaffDetails(StaffID, FirstName, LastName, StaffType, Email, Password, Mobile);

                }
                tbFirstName_MNGStaffDetails.ReadOnly = true;
                tbLastName_MNGStaffDetails.ReadOnly = true;
                tbEmail_MNGStaffDetails.ReadOnly = true;
                tbPassword_MNGStaffDetails.ReadOnly = true;
                tbStaffType_MNGStaffDetails.ReadOnly = true;
                tbStaffID_MNGStaffDetails.ReadOnly = true;
                tbMobileNumber_MNGStaffDetails.ReadOnly = true;
                btnEditMNG_StaffDetails.Text = "Edit";
            }
        }

        private void btnDeleteMNG_StaffDetails_Click(object sender, EventArgs e)
        {
            string StaffID = tbStaffID_MNGStaffDetails.Text;

            var confirm = MessageBox.Show("Are you sure you want to delete this product ? ", "Decline ? ", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Model.deleteStaff(StaffID);
            }
        }
    }
}
