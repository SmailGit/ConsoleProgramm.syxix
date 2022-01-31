using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramm.syxix
{
    internal class Village : Region
    {
        private int _degree;

        public Village(int length, int quantity) : base(length, quantity)
        {

        }

        public Village(int length, int width, int degree) : base(length, width)
        {
            _degree = degree;
        }

        public int Degree { get => _degree; set => _degree = value; }
    }
}