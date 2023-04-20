using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IStaff
    {
        string StaffID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string CurPassword { get; set; }
        string Mobile { get; set; }
        string StaffType { get; set; }
    }
}
