using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTAOOPPractice
{
    class Rectangle
    {
        //Fields - usually lowercase
        //Properties - uppercase
        private double width;
        public double Width
        {
            get { return width; }
            set {
                    if (value > 0.0)
                    width = value;
                }
        }

        private double length;
        public double Length
        {
            get { return length; }
            set
            {
                if (value > 0.0)
                length = value;
            }
        }

        public double GetArea()
        {
            return width * length;
        }
    }
}
