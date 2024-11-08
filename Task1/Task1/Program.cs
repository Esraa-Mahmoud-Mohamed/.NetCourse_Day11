namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.Employees;

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
            Console.WriteLine("--------------Filteration without Delegates--------------");

            var filteredEmps = Filteration.FilterPerAny(employees);
            foreach (var item in filteredEmps)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------Filteration with Delegates--------------");

            FelterationDelegate del = emp => emp.Name.Contains("m") && emp.DeptId == 20;
            var delegateFilteredEmps = Filteration.FilterPerDelegate(employees, del);
            foreach (var item in delegateFilteredEmps)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------Builtin Delegates--------------");

            #region Predicate takes one generic param and return bool
            Predicate<Employee> pred = item => item.DeptId == 10;
            Console.WriteLine(pred(employees.First()));
            #endregion
            #region Action takes from 0 up to 16 generic params and returns void
            Action<Employee> action = (item) => Console.WriteLine(item.ToString());

            foreach (var employee in employees)
            {
                action(employee);
            }
            #endregion
            #region Func takes from 0 up to 16 generic params and returns generic
            Func<int, int> func = (r) => r + 2;
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Id} : {func(employee.Age)}");
            }
            #endregion
        }
    }
}