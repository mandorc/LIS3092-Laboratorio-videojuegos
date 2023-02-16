using System;
using System.Windows.Forms;

namespace DetectArrowKeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // Acción para la flecha hacia arriba
            }
            else if (e.KeyCode == Keys.Down)
            {
                // Acción para la flecha hacia abajo
            }
            else if (e.KeyCode == Keys.Left)
            {
                // Acción para la flecha hacia la izquierda
            }
            else if (e.KeyCode == Keys.Right)
            {
                // Acción para la flecha hacia la derecha
            }
        }
    }
}