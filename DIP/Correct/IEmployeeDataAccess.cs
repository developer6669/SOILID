using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Correct
{
    public interface IEmployeeDataAccess
    {
        Employee GetEmployeeDetails(int id);
    }
}
