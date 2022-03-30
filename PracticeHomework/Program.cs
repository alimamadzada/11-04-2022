using PracticeHomework.Models;
using System;

namespace PracticeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee("Ali", "Mamedzade",16,15,6);
            //emp.CalculateSalary();
            Student st = new Student("Ali", "Mamedzade", 65, 65, 13);
            Console.WriteLine("age = " + st.Age);
            //Console.WriteLine(st.Name);
            //st.ExamResults();
        }
    }
}
