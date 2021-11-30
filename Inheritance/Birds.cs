using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Birds : Animal
    {
        public Birds()
        {

        }
        public string PrimaryColor { get; set; }
        public double BeakLength { get; set; }
        public double Wingspan { get; set; }
        public int NumberOfToes { get; set; }
    }
}
