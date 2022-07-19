using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepo repo = new EmployeeRepo();
            repo.GetAllEmployees();
            Console.ReadLine();
        }
    }
}


/*
1, Dhoni, 70000, 03 - 02 - 2007 00:00:00, M, 1234567890, Bangalore, , 0, 0, 0, 70000

2, Virat, 50000, 04 - 05 - 2010 00:00:00, M, 1234569874, Bangalore, , 0, 0, 0, 50000

3, Rohit, 60000, 09 - 06 - 2009 00:00:00, M, 1234567890, Bangalore, , 0, 0, 0, 60000

4, Smrithi, 40000, 05 - 03 - 2018 00:00:00, F, 1234569874, Bangalore, , 0, 0, 0, 40000

5, Mithai, 50000, 02 - 08 - 2020 00:00:00, F, 1234567890, Bangalore, , 0, 0, 0, 50000

6, Virat, 60000, 05 - 05 - 2011 00:00:00, M, 7894561230, Bangalore, RCB, 1000, 59000, 2000, -2000
*/