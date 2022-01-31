using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramm.syxix
{
    internal class Region
    {
        private int _length;
        private int _width;

        public Region(int cost, int quantity)
        {
            _length = Length;
            _width = Width;
        }

        public Region()
        {
        }

        public int Length { get => _length; set => _length = value; }
        public int Width { get => _width; set => _width = value; }

        public override string ToString()
        {
            return _length + " " + _width;
        }
    }
}
