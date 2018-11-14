using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Juegos.Timbiriche
{
    class Movimiento
    {
        private int inicio;
        private int final;

        public Movimiento()
        {
        }

        public Movimiento(int inicio, int final)
        {
            this.inicio = inicio;
            this.final = final;
        }

        public int getInicio()
        {
            return this.inicio;
        }

        public void setInicio(int inicio)
        {
            this.inicio = inicio;
        }

        public int getFinal()
        {
            return this.final;
        }

        public void setFinal(int final)
        {
            this.final = final;
        }

        public String getMovimiento()
        {
            return inicio + "-" + final;
        }
    }
}
