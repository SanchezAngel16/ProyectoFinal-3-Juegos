using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Juegos.Timbiriche
{
    static class Adyacente
    {
        public static List<int> getAdyacentes(Punto punto, int filas, int cols)
        {
            List<int> valoresAdyacentes = new List<int>();

            int pCol = punto.getY();
            int pFila = punto.getX();
            int pValor = punto.getValor();

            if (pCol == cols-1 && pFila == 0)
            {
                valoresAdyacentes.Add(pValor + filas);
                valoresAdyacentes.Add(pValor - 1);
            }else if(pCol == cols-1 && pFila == filas-1)
            {
                valoresAdyacentes.Add(pValor - 1);
                valoresAdyacentes.Add(pValor - filas);
            }else if(pCol == cols-1)
            {
                valoresAdyacentes.Add(pValor - 1);
                valoresAdyacentes.Add(pValor + filas);
                valoresAdyacentes.Add(pValor - filas);
            }else if(pCol == 0 && pFila == 0)
            {
                valoresAdyacentes.Add(pValor + 1);
                valoresAdyacentes.Add(pValor + filas);
            }else if(pCol == 0 && pFila == filas-1)
            {
                valoresAdyacentes.Add(pValor + 1);
                valoresAdyacentes.Add(pValor - filas);
            }else if(pCol == 0)
            {
                valoresAdyacentes.Add(pValor + 1);
                valoresAdyacentes.Add(pValor + filas);
                valoresAdyacentes.Add(pValor - filas);
            }else if(pFila == 0)
            {
                valoresAdyacentes.Add(pValor + 1);
                valoresAdyacentes.Add(pValor - 1);
                valoresAdyacentes.Add(pValor + filas);
            }else if(pFila == filas-1)
            {
                valoresAdyacentes.Add(pValor + 1);
                valoresAdyacentes.Add(pValor - 1);
                valoresAdyacentes.Add(pValor - filas);
            }
            else
            {
                valoresAdyacentes.Add(pValor + 1);
                valoresAdyacentes.Add(pValor - 1);
                valoresAdyacentes.Add(pValor + filas);
                valoresAdyacentes.Add(pValor - filas);
            }

            return valoresAdyacentes;
        }
    }
}
