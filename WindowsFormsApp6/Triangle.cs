using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    class Triangle
    {
        static int randomize = 0;
        public double length, high, perimeter;
        public double square;
        Random r = new Random(randomize++);
        public Triangle()
        {
            length = r.Next(0, 20);
        }
        public void High()
        {
            high = (length * Math.Sqrt(3)) / 2;
        }
        public void Perimeter()
        {
            perimeter = length * 3;
        }
        public double Square()
        {
            return square = (length * high) / 2;
        }
        public string Out()
        {
            string cout = "";
            cout += $"High and bisector = {high}\n";
            cout += $"Perimeter = {perimeter}\n";
            cout += $"Square = {square}\n";
            return cout;
        }
    }
}
