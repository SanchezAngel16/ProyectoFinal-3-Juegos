using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Juegos.Loteria
{
    class Computadora : Jugador
    {
        private List<Carta> cartas;

        public Computadora(String nombre, int[] tablero) : base(nombre, tablero)
        {
            cartas = new List<Carta>();
        }

        public List<Carta> getCartas()
        {
            return this.cartas;
        }

        public void checarTablero(int cartaPasada)
        {
            foreach (Carta c in cartas)
            {
                if (cartaPasada == getTablero()[c.getValor()])
                {
                    c.Image = Image.FromFile(Application.StartupPath + "\\..\\..\\Juegos\\Resources\\Loteria\\piedra.png");
                    setCartasContadas(getCartasContadas() + 1);
                }
            }
        }
    }
}
