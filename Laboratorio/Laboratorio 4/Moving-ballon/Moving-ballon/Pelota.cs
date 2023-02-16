using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving_ballon
{
    internal class Pelota
    {

        private int posX;
        private int posY;
        private int radio;
        private int velocidadX;
        private int velocidadY;
        private Brush color;

        public Pelota(int x, int y, int r, int vx, int vy, Brush c)
        {
            posX = x;
            posY = y;
            radio = r;
            velocidadX = vx;
            velocidadY = vy;
            color = c;
        }

        public void Dibujar(Graphics g)
        {
            g.FillEllipse(color, posX - radio, posY - radio, radio * 2, radio * 2);
        }

        public void Mover1(int ancho, int alto)
        {
            posX += velocidadX;
            posY += velocidadY;

            if (posX - radio < 0 || posX + radio > ancho)
            {
                velocidadX = -velocidadX;
            }

            if (posY - radio < 0 || posY + radio > alto)
            {
                velocidadY = -velocidadY;
            }
        }

        public void Mover(Rectangle limites)
        {
            x += vx;
            y += vy;

            if (x - r < limites.Left)
            {
                x = limites.Left + r;
                vx = Math.Abs(vx);
            }
            if (x + r > limites.Right)
            {
                x = limites.Right - r;
                vx = -Math.Abs(vx);
            }
            if (y - r < limites.Top)
            {
                y = limites.Top + r;
                vy = Math.Abs(vy);
            }
            if (y + r > limites.Bottom)
            {
                y = limites.Bottom - r;
                vy = -Math.Abs(vy);
            }
        }

    }
}
