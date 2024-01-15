using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationWrong
{
    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area()
        {
            return Length * Width;
        }

        public double Volume()
        {
            throw new NotImplementedException();
        }
    }
}
