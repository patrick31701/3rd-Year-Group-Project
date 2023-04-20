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

namespace MainProject
{
    public partial class Owner_Dashboard : Form
    {
        #region Instance Attributes
        private User_Login ULogin;
        private IModel Model;
        string logID;
        #endregion
        #region Constructors
        public Owner_Dashboard(User_Login staff, IModel Model, string loginID)
        {
            InitializeComponent();
            ULogin = staff;
            this.Model = Model;
            logID = loginID;
        }
        #endregion
        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
