using HomeworkProperty.Models;
using System;
namespace HomeworkProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();
            song.AddRating(2);
            song.AddRating(6);
            song.AddRating(4);
            song.AddRating(14);
            Console.WriteLine(song.GetAverageRating());
        }
    }
}
