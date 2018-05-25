using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2
{
    class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move (Point newLocation)
        {
            if (newLocation == null) //Defensive Programming :)
                throw new ArgumentNullException("newLocation");
            Move(newLocation.X, newLocation.Y);
        }

    }
}
