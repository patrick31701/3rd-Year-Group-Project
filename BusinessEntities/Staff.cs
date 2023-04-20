using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Staff : BusinessEntities.IStaff
    {
        #region Instance Properties
        private string staffID;
        private string firstName;
        private string lastName;
        private string email;
        private string curPassword;
        private string mobile;
        private string staffType;
        #endregion
        #region Instance Properties
        public string StaffID
        {
            get
            {
                return staffID;
            }
            set
            {
                staffID = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string CurPassword
        {
            get
            {
                return curPassword;
            }
            set
            {
                curPassword = value;
            }
        }
        public string Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }
        }
        public string StaffType
        {
            get
            {
                return staffType;
            }
            set
            {
                staffType = value;
            }
        }
        #endregion Instance Properties
        #region Constructors
        public Staff()
        {
            throw new System.NotImplementedException();
        }
        public Staff (string staffID, string firstName, string lastName, string email, string password, string mobile, string staffType)
        {
            this.staffID = staffID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.curPassword = password;
            this.mobile = mobile;
            this.staffType = staffType;
        }
        #endregion
    }
}
