using Dictionary;
using System;
using System.Collections.Generic;

namespace MyHomework
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyDictionary<string, int> cars = new MyDictionary<string, int>();
            cars.Add("Mercedes", 512000);
            cars.Add("Audi", 25000);
            cars.Add("Bmw", 32000);

            Console.WriteLine(cars.Lenght);


            foreach (var car in cars.itemkey)
            {
                Console.WriteLine(car);
            }
            foreach (var fiyat  in cars.itemvalue)
            {
                Console.WriteLine(fiyat);
            }
        }
    }
}
