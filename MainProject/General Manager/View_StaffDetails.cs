using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    public partial class View_StaffDetails : Form
    {
        #region Instance Attributes
        private IModel Model;
        private Manager_Dashboard md;
        #endregion
        #region Constructors

        public View_StaffDetails(Manager_Dashboard md, IModel Model)
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
        public View_StaffDetails()
        {
            InitializeComponent();
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
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void View_StaffDetails_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
