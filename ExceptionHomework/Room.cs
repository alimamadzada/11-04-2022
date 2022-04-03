using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHomework
{
    class Room
    {
        public Room()
        {

        }
        public Room(string name, double price, int personcapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personcapacity;
            ID++;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public int PersonCapacity { get; set; }
        public string ShowInfo()
        {
            return $"{Name} - {Price} - {PersonCapacity}";
        }
        public int ID
        {
            get
            {
                return ID;
            }
            set
            { }
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
