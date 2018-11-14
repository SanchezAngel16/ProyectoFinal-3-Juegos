using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Juegos.Timbiriche
{
    class Punto : PictureBox
    {
        private int x;
        private int y;
        private int posX;
        private int posY;
        private int valor;
        private int radio;
        private List<int> adyacentes;
        //private PictureBox pictureBox;

        // Constructor por defecto
        public Punto()
        {
        }

        public Punto(int x, int y, int valor, int radio)
        {
            
            String rutaImagen = @"..\\..\\Juegos\\Resources\\Timbiriche\\Images\\punto_negro.png";
            String ruta = Path.Combine(Application.StartupPath, rutaImagen);
            this.x = x;
            this.y = y;
            this.valor = valor;
            this.posX = x * (radio + (radio/2));
            this.posY = y * (radio + (radio/2));
            this.Location = new Point(posY, posX);
            this.radio = radio;
            this.Width = radio;
            this.Height = radio;
            this.Image = Image.FromFile(ruta);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, this.Width - 3, this.Height - 3);
            Region rg = new Region(gp);
            this.Region = new Region(gp);
            adyacentes = new List<int>();
        }

        public int getPosX()
        {
            return this.posX;
        }

        public void setPosX(int posX)
        {
            this.posX = posX;
        }

        public int getPosY()
        {
            return this.posY;
        }

        public void setPosY(int posY)
        {
            this.posY = posY;
        }

        public int getRadio()
        {
            return this.radio;
        }

        public void setRadio(int radio)
        {
            this.radio = radio;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public int getValor()
        {
            return this.valor;
        }

        public void setAdyacentes(List<int> adyacentes)
        {
            this.adyacentes = adyacentes;
        }

        public List<int> getAdyacentes()
        {
            return this.adyacentes;
        }

        private Punto getPunto()
        {
            return this;
        }
    }
}
