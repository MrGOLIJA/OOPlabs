using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlabs
{
    public class Figure
    {
        private int _square;
        public int Square { get { return this._square; } }
        public Figure(int left, int right, int top, int bottom)
        {
            this._square = (right - left) * (bottom - top);
        }
        public Figure(int width, int height)
        {
            this._square = width * height;
        }

        public Figure(int square)
        {
            this._square = square;
        }
    }
}
