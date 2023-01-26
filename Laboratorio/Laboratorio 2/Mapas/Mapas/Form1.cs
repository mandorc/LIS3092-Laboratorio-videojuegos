using Mapas.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapas
{
    public partial class Form1 : Form
    {

        Bitmap bmp;

        static Graphics g;

        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(250, 250);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            DrawMap();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DrawMap()
        {
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.Black);

            for (int x = 0; x < Class1.map0.GetLength(0); x++)
            {
                for (int y = 0; y < Class1.map0.GetLength(1); y++)
                {
                    if (Class1.map0[x, y] != 0)
                    {
                       
                        g.FillRectangle(new SolidBrush(Color.FromArgb(35, 35, 35)), x * 10, y * 10, 10, 10);

                        if (Class1.map0[x, y] == 8)
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(200, 200, 200)), x * 10, y * 10, 10, 10);
                        }

                    }
                    else
                        g.DrawRectangle(Pens.Gray, x * 10, y * 10, 10, 10);
                }
            }
        }
    }
}
