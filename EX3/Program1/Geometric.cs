using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    internal class Geometric
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get { return length; }
            set { 
                if(value <= 0) throw new ArgumentException("Length cannot be zero or negative.");
                length = value; 
            }
        }
        public double Width
        {
            get { return width; }
            set {
                if (value <= 0) throw new ArgumentException("Width cannot be zero or negative.");
                width = value; 
            }
        }
        public double Height
        {
            get { return height; }
            set {
                if (value <= 0) throw new ArgumentException("Height cannot be zero or negative.");
                height = value; 
            }
        }

        public Geometric(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double SurfaceArea()
        {
            return Math.Round(2*length*width + 2*length*height + 2*width*height,2);
        }
        public double LateralSurfaceArea()
        {
            return Math.Round(2 * length * height + 2 * width * height,2);
        }
        public double Volume()
        {
            return Math.Round(length * width * height,2);
        }

        public override string ToString()
        {
            return $"Surface Area - {this.SurfaceArea()}\n" +
                $"Lateral Surface Area – {this.LateralSurfaceArea()}\n" +
                $"Volume – {this.Volume()}";
        }
    }
}
