using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    public class RectangleWall : Wall
    {

       
           public int Height { get;  }
        
             public int Length { get;  }

        public RectangleWall(string color, string name, int Length, int Height) : base(name,color)
        {
           name = Name;
            Color = color;
            this.Length = Length;
            this.Height = Height;


        }

        public override int GetArea()
        {
            return Length * Height;
        }

     
    }
}
