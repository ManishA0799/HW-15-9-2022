using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_15_9_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a class Emp with empid, empname, accept bs from constructor, & calculate salary as follows
 
             HRA -> 40 % of BS
             DA  -> 20 % of BS
             PT -> 200
             PF  -> 12 % of BS


             Calculate the total salary & net paid salary
             total=bs + allows  
             Net paid = total-pf -pt
            *
            */

            EmpSalary empSalary = new EmpSalary(021, "Manish", 25000);
            empSalary.Calculate();
            Console.WriteLine(empSalary.DisplayValue());

        }
    }
}
