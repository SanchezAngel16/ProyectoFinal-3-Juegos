using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Juegos.Sopa_de_letras
{
    class Letra : UserControl
    {
        private Label labelLetra;
        private char letra;
        private int valor;

        public Letra(char letra, int valor)
        {
            this.Size = new Size(35, 35);
            this.Padding = new Padding(0);
            this.Margin = new Padding(0);
            this.labelLetra = new Label();
            this.letra = letra;
            this.valor = valor;
            this.labelLetra.Text = letra.ToString();
            this.labelLetra.AutoSize = false;
            this.labelLetra.TextAlign = ContentAlignment.MiddleCenter;
            this.labelLetra.Anchor = AnchorStyles.Left & AnchorStyles.Right;
            centerLabel();
            this.Controls.Add(this.labelLetra);
        }

        // Centra la etiqueta
        private void centerLabel()
        {
            int x = (this.Size.Width - this.labelLetra.Size.Width) / 2;
            int y = (this.Size.Height - this.labelLetra.Size.Height) / 2;
            this.labelLetra.Location = new Point(x, y);
        }

        public Label getLabel()
        {
            return this.labelLetra;
        }

        public char getLetra()
        {
            return this.letra;
        }

        public int getValor()
        {
            return this.valor;
        }
    }
}
