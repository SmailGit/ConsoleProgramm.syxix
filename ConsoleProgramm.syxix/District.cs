using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramm.syxix
{
    internal class District : Region
    {
        private int _degree;

        public District(int length, int quantity) : base(length, quantity)
        {

        }

        public District(int length, int width, int degree) : base(length, width)
        {
            _degree = degree;
        }

        public int Degree { get => _degree; set => _degree = value; }
    }
}
