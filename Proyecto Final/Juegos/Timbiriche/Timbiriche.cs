using Proyecto_Final.Juegos.Timbiriche;
using Proyecto_Final.Juegos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Timbiriche : Form
    {
        List<Punto> puntos = new List<Punto>();
        List<Movimiento> movimientos = new List<Movimiento>();
        List<int> adyacentes = new List<int>();

        float x1;
        float y1;
        float x2;
        float y2;

        private static int pInicio = -1;
        private static int pFinal = -1;
        private static int turno = 1;
        private static int movimiento = 1;

        private const int filas = 5;
        private const int cols = 5;

        public Timbiriche()
        {
            InitializeComponent();
        }

        // Esta funcion se llama al abrirse la ventana de Timbiriche
        private void Timbiriche_Load(object sender, EventArgs e)
        {
            startGame();
        }

        // Empieza el juego, inicializando los puntos del tablero
        private void startGame()
        {
            inicializarPuntos();
        }

        // Inicializa la lista de puntos del tablero y los añade a la ventana
        private void inicializarPuntos()
        {
            int valor = 0;
            for(int i = 0; i < filas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Punto punto = new Punto(i, j, valor, 35);
                    punto.setAdyacentes(Adyacente.getAdyacentes(punto,filas,cols));
                    punto.MouseClick += new MouseEventHandler((o, a) =>
                    {
                        registrarMovimiento(punto);
                    });
                    this.Controls.Add(punto);
                    puntos.Add(punto);
                    valor++;
                }
            }
        }

        /* Por cada click en un punto del tablero se va registrando los movimientos y verifica si
         * son movimientos validos y se va almacenando en la lista de Movimientos
         */
        private void registrarMovimiento(Punto punto)
        {
            bool esAdyacente = false;
            int valorActual = punto.getValor();
            if(movimiento == 1)
            {
                pInicio = valorActual;
                y1 = punto.getPosX() + (punto.getRadio() / 2);
                x1 = punto.getPosY() + (punto.getRadio() / 2);
                adyacentes = punto.getAdyacentes();
                movimiento = 2;
            }else if(movimiento == 2)
            {
                foreach (int adyacente in adyacentes)
                {
                    if (valorActual == pInicio)
                    {
                        Utils.printLine("Movimiento invalido: " + pInicio + "-" + valorActual);
                        movimiento = 1;
                        return;
                    }
                    if (valorActual == adyacente)
                    {
                        esAdyacente = true;
                        pFinal = valorActual;
                        Movimiento nuevoMovimiento = new Movimiento(pInicio, pFinal);
                        if (existeMovimiento(nuevoMovimiento))
                        {
                            Utils.printLine("Movimiento invalido (repetido): " + pInicio + "-" + pFinal);
                            return;
                        }
                        else
                        {
                            y2 = punto.getPosX() + (punto.getRadio()/2);
                            x2 = punto.getPosY() + (punto.getRadio()/2);
                            Utils.printLine("Movimiento valido: " + pInicio + "-" + valorActual);
                            if(turno == 1) Utils.drawLine(Color.Red, x1, y1, x2, y2, this);
                            else Utils.drawLine(Color.Blue, x1, y1, x2, y2, this);
                            
                            movimientos.Add(nuevoMovimiento);
                            turno *= -1;
                            movimiento = 1;
                            pInicio = -1;
                            pFinal = -1;
                            return;
                        }
                    }
                }
                if (!esAdyacente)
                {
                    Utils.printLine("Movimiento invalido: " + pInicio + "-" + valorActual);
                    movimiento = 1;
                    pInicio = -1;
                    pFinal = -1;
                }
                
            }
        }

        // Verifica si tal movimiento ya esta en la lista de los movimientos
        private bool existeMovimiento(Movimiento movimiento)
        {
            foreach(Movimiento mov in movimientos)
            {
                if (mov.getInicio() == movimiento.getInicio() &&
                    mov.getFinal() == movimiento.getFinal()) return true;
            }
            return false;
        }
        
        //TODO: Leer movimientos guardados en un archivo de texto
        private void leerMovimientos()
        {
            int contador = 0;
            foreach(Movimiento move in movimientos)
            {
                Utils.printLine("Movimiento: " + (contador+1));
                Utils.printLine(move.getMovimiento());
                contador++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            leerMovimientos();
        }
    }
}