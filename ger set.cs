using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_15_9_2022
{
    public class Student
    {
        private int rollno;
        private string name;
        private double per;

        public int Rollno
        {
            get { return rollno; }
            set { rollno = value; } 
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Percentage
        {
            get { return per; }
            set { per = value; }

        //    public override string ToString()
        //{
        //    return $"Roll -> {rollno} Name {name}  percentage ->{per} ";

        //}
    }
    }









}
