using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double lenght, double width, double heigth)
        {
            this.Length = lenght;
            this.Width = width;
            this.Height = heigth;
        }

        public double Height
        {
            get { return height; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value; 
            }
        }

        public double Width
        {
            get { return width; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value; 
            }
        }

        public double Length
        {
            get { return length; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value; 
            }
        }
        private double SurfaceArea()
        {
            //2lw + 2lh + 2wh
            return 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
        }
        private double LateralSurfaceArea()
        {
            //Lateral Surface Area = 2lh + 2wh
            return 2 * Length * Height + 2 * Width * Height;
        }
        private double Volume()
        {
            //Volume = lwh
            return Length * Width * Height;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Surface Area - {SurfaceArea():f2}");
            result.AppendLine($"Lateral Surface Area - {LateralSurfaceArea():f2}");
            result.AppendLine($"Volume - {Volume():f2}");
            return result.ToString().Trim();
        }
    }
}
