using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_15_9_2022
{
    public class EmpSalary
    {
        private int empid;
        private string empname;
        private int basicsalary;
        public int total;
        public int netsalary;
        public int hra, da, pt, pf;


        public EmpSalary(int empid, string empname, int basicsalary)
        {
            this.empid = empid;
            this.empname = empname;
            this.basicsalary = basicsalary;
        }

        public void Calculate()
        {
            da = (basicsalary * 20) / 100;
            hra = (basicsalary* 40) / 100;
            pf = (basicsalary * 12) / 100;
            pt = (basicsalary - 200);

            total = basicsalary + hra + da;
            netsalary = (total - pt - pf);     
                        
        }

        public string DisplayValue()
        {
            return $" Id ==>{empid} \n Name : {empname} \n Basic Salary : {basicsalary} \n  Total Salary: {total} \n Net Salary : {netsalary}";
        }








    }
} 
