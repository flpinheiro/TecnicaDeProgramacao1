using System;
using UnBCineFlix.Model;

namespace UnBCineFlix
{
    class Program
    {
        static void Main(string[] args)
        {
            var mt = new MovieTheater(10,10);
            mt.AddChair(new Chair(5,5));
            mt.AddChair(new Chair(3,6,true));

            Console.Write(mt);
            Console.WriteLine("Hello World!");
            Console.ReadKey(true);
        }
    }
}
