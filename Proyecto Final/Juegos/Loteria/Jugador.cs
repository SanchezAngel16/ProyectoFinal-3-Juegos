using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Juegos.Loteria
{
    public class Jugador
    {
        private String nombre;
        private int cartasContadas;
        private int[] tablero = new int[9];

        public Jugador(String nombre,int[] tablero)
        {
            this.nombre = nombre;
            this.tablero = tablero;
            this.cartasContadas = 0;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public int getCartasContadas()
        {
            return this.cartasContadas;
        }

        public void setCartasContadas(int cartasContadas)
        {
            this.cartasContadas = cartasContadas;
        }

        public int[] getTablero()
        {
            return this.tablero;
        }

        public void setTablero(int[] tablero)
        {
            this.tablero = tablero;
        }
    }
}
