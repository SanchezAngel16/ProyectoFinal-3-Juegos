using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Juegos.Timbiriche
{
    class Jugador
    {
        private String nombre;
        private int puntos;
        private bool turno;

        public Jugador(String nombre, int puntos, bool turno)
        {
            this.nombre = nombre;
            this.puntos = puntos;
            this.turno = turno;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public int getPuntos()
        {
            return this.puntos;
        }

        public void setPuntos(int puntos)
        {
            this.puntos = puntos;
        }

        public bool getTurno()
        {
            return this.turno;
        }

        public void setTurno(bool turno)
        {
            this.turno = turno;
        }

    }
}
