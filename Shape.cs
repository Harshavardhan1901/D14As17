using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class Shape
    {
        public string ShapeType { get; set; }
        public virtual double Area { get; }
        public virtual double Perimeter { get; }
    }
}
