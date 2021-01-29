using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    public class TriangleWall : Wall
    {
        public override int GetArea ()
        {
            return Base * Height / 2;

        }

        public int Height { get;  }

        public int Base { get;  }

        public TriangleWall(string name, string color, int @base, int Height) : base(name,color)
        {

            this.Base = @base;
            this.Height = Height;



        }

        



    }
}
