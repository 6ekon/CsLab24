using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        int n, m;
        public int N { get => n; set => n = value; }
        public int M { get => m; set => m = value; }

        public Form1()
        {
            InitializeComponent();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream fs = openFileDialog1.OpenFile();

                BinaryReader br = new BinaryReader(fs, Encoding.UTF8);
                string str = File.ReadAllText(openFileDialog1.FileName);
                br.Close();
                fs.Close();

                int indexCountTriangles = str.IndexOf("Count of Triangles: ") + 20;
                int indexCountRightPyramids = str.IndexOf("\nCount of Right Pyramids: ");
                int indexResult = str.IndexOf("\n\nResult: \n");
                string countTriangles = str.Substring(indexCountTriangles, indexCountRightPyramids - indexCountTriangles);
                string countRightPyramids = str.Substring(indexCountRightPyramids + 25, indexResult - (indexCountRightPyramids + 25));

                OupN.Text = countTriangles;
                OupM.Text = countRightPyramids;

                string Result = str.Substring(indexResult + 9);
                Cout.Text = Result;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cout.Text = "";
            N = Convert.ToInt32(OupN.Text);
            M = Convert.ToInt32(OupM.Text);
            Triangle[] conclusion = new Triangle[N];
            double averagesquare = 0;
            for (int i = 0; i < N; i++)
            {
                conclusion[i] = new Triangle();
                conclusion[i].High();
                conclusion[i].Perimeter();
                conclusion[i].Square();
                averagesquare += conclusion[i].square;
            }
            averagesquare /= N;

            RightPyramid[] concl = new RightPyramid[M];
            for (int i = 0; i < M; i++)
            {
                concl[i] = new RightPyramid();
                concl[i].Volume();
            }
            double biggestvolume = int.MinValue;
            for (int i = 0; i < N; i++)
            {
                Cout.Text += $"Triangle №{i + 1}\n";
                Cout.Text += conclusion[i].Out();
            }
            Cout.Text += "\n";
            Cout.Text += "Average Square = ";
            Cout.Text += averagesquare.ToString("n");
            Cout.Text += "\n\n";
            for (int i = 0; i < N; i++)
            {
                if (conclusion[i].square > averagesquare)
                {
                    Cout.Text += $"Bigger square then Average Square = {conclusion[i].square}\n";
                }
            }
            Cout.Text += "\n\n";
            for (int i = 0; i < M; i++)
            {
                Cout.Text += $"Pyramid №{i + 1}\n";
                Cout.Text += concl[i].Out2();
            }
            for (int i = 0; i < concl.Length; i++)
            {
                if (concl[i].volumerr > biggestvolume)
                {
                    biggestvolume = concl[i].volumerr;
                }
            }
            Cout.Text += $"\nThe biggest volume = {biggestvolume}";

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stream fs;

            SaveFileDialog save = new SaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
                if ((fs = save.OpenFile()) != null)
                {
                    BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);

                    bw.Write(Encoding.Default.GetBytes("Count of Triangles: " + OupN.Text));
                    bw.Write(Encoding.Default.GetBytes("\nCount of Right Pyramids: " + OupM.Text));

                    bw.Write(Encoding.Default.GetBytes("\n\nResult: \n"));
                    bw.Write(Encoding.Default.GetBytes(Cout.Text));

                    bw.Close();
                    fs.Close();
                }
            }

        }
    }
}
