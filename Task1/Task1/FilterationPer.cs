using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class FilterationPer
    {
        public static bool PerDeptId(Employee item)
        {
            return item.DeptId == 20;
        }

        public static bool PerName(Employee item)
        {
            return item.Name.ToLower().Contains("m");
        }
    }
}
