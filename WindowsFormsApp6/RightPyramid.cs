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
    class RightPyramid : Triangle
    {
        public double apothem;
        public double volumerr;
        public void Apothem()
        {
            apothem = 2 * square / perimeter;
        }
        public void Volume()
        {
            double heigh = Math.Sqrt(Math.Abs(Math.Pow(apothem, 2) - Math.Pow(length, 2)));
            volumerr = heigh * Math.Pow(length, 2) / 3;
        }
        public double Square()
        {
            return base.square + 4 * 1 / 2 * apothem * (base.length / 2);
        }
        public string Out2()
        {
            string cout2 = "";
            cout2 += $"Volume of Right Pyramid = {volumerr}\n";
            return cout2;
        }
    }
}
