using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Juegos.Timbiriche
{
    class Linea : UserControl
    {
        private int xIndex;
        private int yIndex;
        private Color color;
        private bool ocupada;

        public Linea(Color c, int xIndex, int yIndex, bool ocupada)
        {
            this.ocupada = false;
            this.color = c;
            this.BackColor = color;
            this.xIndex = xIndex;
            this.yIndex = yIndex;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MouseEnter += new EventHandler((o, a) =>
            {
                if (!getOcupada())
                {
                    this.BackColor = Color.Green;
                }
                
            });
            this.MouseLeave += new EventHandler((o, a) =>
            {
                this.BackColor = this.getColor();
            });
        }

        public int getXIndex()
        {
            return this.xIndex;
        }

        public int getYIndex()
        {
            return this.yIndex;
        }

        public Color getColor()
        {
            return this.color;
        }

        public void setColor(Color c)
        {
            this.color = c;
        }

        public bool getOcupada()
        {
            return this.ocupada;
        }

        public void setOcupada(bool ocupada)
        {
            this.ocupada = ocupada;
        }
    }
}
