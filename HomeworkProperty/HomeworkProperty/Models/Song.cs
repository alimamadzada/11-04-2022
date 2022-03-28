using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkProperty.Models
{
    class Song : Singer
    {
        private string _genre;
        private Singer _singer;
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                if (value.Contains("Pop") || value.Contains("Rock") || value.Contains("Jazz") || value.Contains("Tehcno"))
                    _genre = value;
                else Console.WriteLine("Listde qeyd etdiyiniz Janrda musiqi yoxdur.");
            }
        }
        private int[] Ratings = new int[0];
        public void AddRating(int rating)
        {
            if (rating >= 0 && rating <= 10)
            {
                Array.Resize(ref Ratings, Ratings.Length + 1);
                Ratings[Ratings.Length - 1] = rating;
            }
        }
        public double GetAverageRating()
        {
            return Ratings.Average();
        }
    }
}
