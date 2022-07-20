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
            Console.WriteLine("Welcome");

            EmployeeRepo repo = new EmployeeRepo();
            try
            {
                Console.WriteLine("Choose option or press 0 for exit\n1:Retrieve Data\n2:Add Data\n3:Update Basic_Salary");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        repo.GetAllEmployees();
                        break;
                    case 2:
                        EmployeeModel model = new EmployeeModel
                        {
                            Name = "Pant",
                            Startdate = DateTime.Now,
                            Gender = 'M',
                            Phone = 912423,
                            Department = "DC",
                            Address = "Delhi",
                            Basic_Pay = 30000.00,
                            Deductions = 1000.00,
                            Taxable_Pay = 29000.00,
                            Income_Tax = 1000.00,
                            Net_Pay = 28000,
                        };
                        repo.AddEmployee(model);
                        repo.GetAllEmployees();
                        break;
                    case 3:
                        EmployeeModel model1 = new EmployeeModel();
                        Console.WriteLine("Enter id of employee whose data you want to update");
                        model1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name");
                        model1.Name = Console.ReadLine();
                        Console.WriteLine("Enter new BasicPay");
                        model1.Basic_Pay = Convert.ToDouble(Console.ReadLine());
                        repo.UpdateEmployee(model1);
                        repo.GetAllEmployees();
                        break;
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

//UC_3
/* 
3:Update Basic_Salary
3
Enter id of employee whose data you want to update
8
Enter name
Pant
Enter new BasicPay
67856
Employee details updated successfully
1, Dhoni, 70000, 03-02-2007 00:00:00, M, 1234567890, Bangalore, , 0, 0, 0, 70000

2, Virat, 50000, 04 - 05 - 2010 00:00:00, M, 1234569874, Bangalore, , 0, 0, 0, 50000

3, Rohit, 60000, 09 - 06 - 2009 00:00:00, M, 1234567890, Bangalore, , 0, 0, 0, 60000

4, Smrithi, 40000, 05 - 03 - 2018 00:00:00, F, 1234569874, Bangalore, , 0, 0, 0, 40000

5, Mithai, 50000, 02 - 08 - 2020 00:00:00, F, 1234567890, Bangalore, , 0, 0, 0, 50000

6, Virat, 60000, 05 - 05 - 2011 00:00:00, M, 7894561230, Bangalore, RCB, 1000, 59000, 2000, -2000

7, Pant, 30000, 20 - 07 - 2022 00:00:00, M, 912423, Delhi, DC, 1000, 29000, 1000, 28000

8, Pant, 67856, 20 - 07 - 2022 00:00:00, M, 912423, Delhi, DC, 1000, 29000, 1000, 28000

9, Pant, 56879, 21 - 07 - 2022 00:00:00, M, 912423, Delhi, DC, 1000, 29000, 1000, 28000

10, Pant, 78943, 21 - 07 - 2022 00:00:00, M, 912423, Delhi, DC, 1000, 29000, 1000, 28000

*/