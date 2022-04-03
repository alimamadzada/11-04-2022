using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHomework
{
    class Hotel : Room
    {
        public string Name { get; set; }
        Room[] rooms = new Room[0];
        public void AddRoom()
        {
        }
        Hotel[] hotel;
        public Hotel(int n, string Name)
        {
            hotel = new Hotel[n];
        }
        public void Reserve(int roomid)
        {
            if (IsAvailable == false)
            {
                throw new NotAvailableException("Room is full");
            }
            else if (IsAvailable == true)
                IsAvailable = false;
            if (roomid == 0)
                throw new NotFoundException("Room not found");
        }
    }
}
