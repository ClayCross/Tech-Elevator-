using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    abstract public class Wall
    {
        public string Name { get; set; }
    public string Color { get; set; }


        public Wall(string name, string color)
        {
            this.Name = name;
            this.Color = color;



        }

        abstract public int GetArea();



    }
}
