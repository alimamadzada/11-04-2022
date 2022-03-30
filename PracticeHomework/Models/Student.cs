using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeHomework.Models
{
    class Student : Person
    {
        public Student(string name, string surname, int age, int iqrank, int languagerank)
        {
            if (age <= 6 && age >= 20)
                Console.WriteLine("Yashi duzgun daxil edin.");
            else
            {
                Name = name;
                Surname = surname;
                Age = age;
                LanguageRank = languagerank;
                IQRank = iqrank;
            }
        }


        private int _iqrank;
        public int IQRank
        {
            get { return _iqrank; }
            set
            {
                if (value <= 100)
                    _iqrank = value;
            }
        }


        private int _languagerank;
        public int LanguageRank
        {
            get { return _iqrank; }
            set
            {
                if (value <= 100)
                    _languagerank = value;
            }
        }
        private int _age;
        public override int Age
        {
            get { return _age; }
            set
            {
                if (value >= 6 && value <= 20)
                    _age = value;
            }
        }


        public void ExamResults()
        {
            int result = LanguageRank + IQRank;
            if (result <= 120)
            {
                Console.WriteLine("Teessuf, sinifde qaldiniz.");
            }
            else
                Console.WriteLine("Imtahandan kecdiniz, Tebrikler.");
        }
    }
}
