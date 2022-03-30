using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeHomework.Models
{
    class Employee : Person
    {
        public Employee(string name, string surname, int age, int salaryofhour, int workinghour)
        {

            Name = name;
            Surname = surname;
            Age = age;
            SalaryOfHour = salaryofhour;
            WorkingHours = workinghour;
        }


        private int _salaryofhour;
        public int SalaryOfHour
        {
            get { return _salaryofhour; }
            set
            {
                _salaryofhour = value;
            }
        }


        private int _workinghour;
        public int WorkingHours
        {
            get { return _workinghour; }
            set
            {
                if (value <= 8)
                    _workinghour = value;
            }
        }


        public override int Age
        {
            
            get { return Age; }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Ishlemek huququ yoxdur");
                }
            }
        }
        public void CalculateSalary()
        {
            double salary = 30 * WorkingHours * SalaryOfHour;
            if (salary >= 250)
            {
                Console.WriteLine("Monthly salary = " + salary);
            }
            else
                Console.WriteLine("Illegal work");
        }
    }
}
