using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOPS
{
    internal class Emp { 
        public int empid;

        public string empname;

        public float empsal;

        public string Name,Job;


    }
    internal class UserDefinedTypes
    {
        public Emp getEmpDetailes(int empid) {

            Emp emp = new Emp();

            switch (empid) {
                case 101:
                    emp.empid = 101;
                    emp.empname = "John";
                    emp.empsal = 45000;
                    emp.Name = "Manager";
                    emp.Job = "Sales";
                    break;
                case 102:
                    emp.empid = 102;
                    emp.empname = "Smith";
                    emp.empsal = 55000;
                    emp.Name = "Sr.Manager";
                    emp.Job = "Sales";
                    break;
                case 103:
                    emp.empid = 103;
                    emp.empname = "john";
                    emp.empsal = 55000;
                    emp.Name = "Sr.Manager";
                    emp.Job = "HR";
                    break;
                default:
                    Console.WriteLine("Invalid Employee ID");
                    break;
            }

            return emp;
        }

        public void DisplatEmployeeDetailes(Emp emp) { 
        
           Console.WriteLine("Employee ID: " + emp.empid + "Employee name: " + emp.empname + "employee Salary: " + emp.empsal + "Emp JoB : " + emp.Job);
        }
    }
}
