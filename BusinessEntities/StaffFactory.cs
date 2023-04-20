using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class StaffFactory
    {
        private static IStaff staff = null;

        public static IStaff GetStaff(string staffID, string firstName, string lastName, string email, string curPassword, string mobile, string staffType)
        {
            if (staff != null)
            {
                return staff;
            }
            else
                return new Staff(staffID, firstName, lastName, email, curPassword, mobile, staffType);
        }

        public static void SetStaff(IStaff astaff)
        {
            staff = astaff;
        }
    }
}
