using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public Reptile()
        {
                
        }

        public string ScaleColor { get; set; }
        public int ToeLength { get; set; }
        public double TailLength { get; set; }
        public double TongueLength { get; set; }

    }
}
