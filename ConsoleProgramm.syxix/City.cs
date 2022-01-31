using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramm.syxix
{
    internal class City : Region
    {
        private int _degree;

        public City(int multifunctionality, int quantity) : base(multifunctionality, quantity)
        {

        }

        public City(int quantity, int width, int degree) : base(quantity, width)
        {
            _degree = degree;
        }

        public int Degree { get => _degree; set => _degree = value; }
    }
}