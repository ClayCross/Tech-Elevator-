using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car
    {
        public string make;
        public string year;

        //derived property
        public int age {
            get {
                return int.Parse(year);
            }
        }

        //constructor
        /*
         Car myCar = new Car("Toyota","2017");

         */
        public Car(string make, string year)
        {
            this.year = year;
            this.make = make;
        }

    }
}
