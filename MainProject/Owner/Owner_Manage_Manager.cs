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
using System.Text.RegularExpressions;

namespace MainProject.Owner
{
    public partial class Owner_Manage_Manager : Form
    {
        #region Instance Attributes
        private User_Login ULogin;
        private IModel Model;
        string logID;
        #endregion
        public Owner_Manage_Manager(User_Login ulogin, IModel Model, string loginID)
        {
            InitializeComponent();
            this.ULogin = ulogin;
            this.Model = Model;
            logID = loginID;

            foreach (Staff manager in Model.ManagerList)
            {
                dataGridView1.Rows.Add(manager.StaffID, manager.FirstName, manager.LastName, manager.Email, manager.Mobile);
            }
        }
       
        private void btnHire_Click(object sender, EventArgs e)
        {
            string newID = Model.makeStaffID();
            if (fName.Text == "" || lName.Text == "" || email.Text == "" || mobile.Text == "")
            {
                MessageBox.Show("Input is empty! ", "Warning");
            }
            else if (Model.validateEmail(email.Text))
            {
                Model.addManager(newID, fName.Text, lName.Text, email.Text, Model.ComputeSha256Hash("12345"), mobile.Text);
                dataGridView1.Rows.Add(newID, fName.Text, lName.Text, email.Text, mobile.Text);
                fName.Text = "";
                lName.Text = "";
                email.Text = "";
                mobile.Text = "";
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
            else {
                MessageBox.Show("Invalid input! Please try again! ");
            }
           

        }

        private void btnFIre_Click(object sender, EventArgs e)
        {
            Model.deleteManager(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            fName.Text = "";
            lName.Text = "";
            email.Text = "";
            mobile.Text = "";
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fName.Text = "";
            lName.Text = "";
            email.Text = "";
            mobile.Text = "";
        }
    }
}
