using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClassFacebook.Models
{
    class User
    {
        public int DateOfBirth;
        public string Surname;
        public bool isSingle;
        public string Email;
        public Post[] posts;
        public string Name;

        public User()
        {

        }
        public User(string Name, string Surname, int DateOfBirth)
        {

        }
        public User(bool isSingle, string Email)
        {

        }

    }
}
