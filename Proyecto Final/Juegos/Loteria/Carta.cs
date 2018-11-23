using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Juegos.Loteria
{
    class Carta : PictureBox
    {
        private int valor;

        public Carta(int valor)
        {
            this.valor = valor;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Dock = DockStyle.Fill;
            this.Size = MaximumSize;
        }

        public int getValor()
        {
            return this.valor;
        }
    }
}
