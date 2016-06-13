using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { Make="BMW", Model="550i", Color=CarColor.Blue, StickerPrice=55000, Year=2009 },
                new Car() { Make="Toyota", Model="4Runner", Color=CarColor.White, StickerPrice=35000, Year=2010 },
                new Car() { Make="BMW", Model="745li", Color=CarColor.Black, StickerPrice=75000, Year=2008 },
                new Car() { Make="Ford", Model="Escape", Color=CarColor.White, StickerPrice=28000, Year=2008 },
                new Car() { Make="BMW", Model="550i", Color=CarColor.Black, StickerPrice=57000, Year=2010 }
            };


            // LINQ code
            IEnumerable<Car> bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;

            //methodised version
            var _bmws = myCars.Where(car => car.Year == 2010).Where(car => car.Make == "BMW");

            //project onto an anonymous type with fewer properties
            //var resolves the type at runtime dynamically
            var newCars = from car in myCars
                          where car.Year > 2009
                          select new { car.Make, car.Model, car.Year };

            //sorting
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;

            foreach (var car in _bmws)
            {
                Console.WriteLine("{0} {1} - {2}", car.Make, car.Model, car.Year);
            }

            //Sum functionality
            double sum = myCars.Sum(p => p.StickerPrice);
            Console.WriteLine("Total inventory value: {0:C}", sum);


            Console.ReadLine();

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
        public CarColor Color { get; set; }
    }

    enum CarColor
    {
        White,
        Black,
        Red,
        Blue,
        Yellow
    }

}
