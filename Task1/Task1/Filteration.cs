using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Filteration
    {
        public static List<Employee> FilterPerAny(List<Employee> param)
        {
            List<Employee> result = new List<Employee>();
            foreach (Employee emp in param)
            {
                //if (FilterPer.PerDeptId(emp))
                if (FilterationPer.PerName(emp))
                {
                    result.Add(emp);
                }
            }
            return result;
        }

        public static List<Employee> FilterPerDelegate(List<Employee> param, FelterationDelegate del1)
        {
            List<Employee> result = new List<Employee>();
            foreach (Employee emp in param)
            {
                if (del1(emp))
                {
                    result.Add(emp);
                }
            }
            return result;
        }
    }
}
