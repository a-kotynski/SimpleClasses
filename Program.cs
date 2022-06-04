using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimopleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(); //creating new instance of a class
            myCar.Make = "Oldsmobile";  //setting the properties
            myCar.Model = "Cutlas Supreme"; //setting the properties
            myCar.Year = 1986;  //setting the properties
            myCar.Color = "Silver"; //setting the properties

            Console.WriteLine("{0} {1} {2} {3}", 
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.Color); // getting the properties

            decimal value = DetermineMarketValue(myCar);
            Console.WriteLine("{0:C}", value);

            Console.ReadLine(); //print out properties
        }

        private static decimal DetermineMarketValue(Car car) //what's a lower-case car?
        {
            decimal carValue = 100.0M;
            return carValue;
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }



    }

}