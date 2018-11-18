using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Juegos.Timbiriche
{
    public partial class Timbiriche : Form
    {
        List<Linea> lineas = new List<Linea>();
        int cuadrosCompletos = 0;
        private int tamañoTablero;
        private int tamañoArreglo;
        private String nombreTablero;
        int[,] tablero;
        Jugador j1, j2;

        // Constructor, obtiene nombre de los jugadores, el tamaño y el nombre del archivo
        public Timbiriche(String nombre1, String nombre2, int tamañoTablero, String nombreTablero)
        {
            {
                this.tamañoTablero = tamañoTablero;
                this.tamañoArreglo = (tamañoTablero * 2) - 1;
                this.nombreTablero = nombreTablero;
                InitializeComponent();
                j1 = new Jugador(nombre1, 0, true);
                j2 = new Jugador(nombre2, 0, false);
                jugador1.Text = nombre1;
                jugador2.Text = nombre2;
                inicializarTablero(tamañoTablero);
                panel_jugador1.BackColor = Color.DeepSkyBlue;
            }
        }

        private void setGameBoard()
        {
            gameboard.ColumnCount = tamañoArreglo;
            gameboard.RowCount = tamañoArreglo;
            gameboard.ColumnStyles[0].SizeType = SizeType.AutoSize;
            gameboard.RowStyles[0].SizeType = SizeType.AutoSize;
        }

        // Inicializa el arreglo bidimensional del tablero y lo pinta
        private void inicializarTablero(int tamaño)
        {
            StreamReader objReader = new StreamReader(Path.Combine(Application.StartupPath, "..\\..\\Juegos\\Resources\\Timbiriche\\Tableros\\"+ nombreTablero));
            string sLine = "";
            tablero = new int[tamañoArreglo, tamañoArreglo];
            setGameBoard();
            for (int i = 0; i < tamañoArreglo; i++)
            {
                sLine = objReader.ReadLine();
                for (int j = 0; j < tamañoArreglo; j++)
                {
                    if(sLine != null)
                    {
                        tablero[i,j] = Int32.Parse(sLine[j].ToString());
                        if (tablero[i, j] == 2)
                        {
                            Linea l = new Linea(Utils.lineaSinConectar, j, i, false);
                            l.Size = new Size(40,10);
                            l.MouseClick += new MouseEventHandler((o, a) =>
                            {
                                if (tablero[l.getYIndex(), l.getXIndex()] != 1)
                                {
                                    registrarMovimiento(l.getYIndex(), l.getXIndex(), l);
                                }
                            });
                            lineas.Add(l);
                            gameboard.Controls.Add(l, j, i);
                            gameboard.GetControlFromPosition(j,i).Margin = new Padding(0,4,0,0);
                        }
                        else if(tablero[i,j] == 4)
                        {
                            Linea l = new Linea(Utils.lineaSinConectar, j, i, false);
                            l.Size = new Size(10,40);
                            l.MouseClick += new MouseEventHandler((o, a) =>
                            {
                                if (tablero[l.getYIndex(), l.getXIndex()] != 1)
                                {
                                    registrarMovimiento(l.getYIndex(), l.getXIndex(), l);
                                }
                            });
                            lineas.Add(l);
                            gameboard.Controls.Add(l, j, i);
                            gameboard.GetControlFromPosition(j, i).Margin = new Padding(4,0,0,0);
                        }else if (tablero[i,j] == 0)
                        {
                            PictureBox p = new PictureBox();
                            p.Size = new Size(20,20);
                            p.BackColor = Color.Black;
                            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                            gp.AddEllipse(0, 0, p.Width - 3, p.Height - 3);
                            Region rg = new Region(gp);
                            p.Region = rg;
                            gameboard.Controls.Add(p, j, i);
                            gameboard.GetControlFromPosition(j, i).Margin = new Padding(0,0,0,0);
                        }
                    }
                }
            }
            objReader.Close();
        }
        
        // Imprime el tablero para pruebas
        private void printTablero()
        {
            Utils.printLine("*************************************");
            for (int i = 0; i < tamañoArreglo; i++)
            {
                for (int j = 0; j < tamañoArreglo; j++)
                {
                    Utils.print(tablero[i, j].ToString());
                }
                Utils.printLine("");
            }
            Utils.printLine("*************************************");
        }

        // Obtiene el total de cuadros en el tablero del juego
        private int getCuadros()
        {
            //Utils.printLine(tamañoTablero.ToString());
            int cuadros = 0;

            for(int i = 0; i <= tamañoArreglo - 2; i += 2)
            {
                for(int j = 0; j <= tamañoArreglo - 2; j += 2)
                {
                    if(tablero[i+1,j] == 1 &&
                        tablero[i,j+1] == 1 &&
                        tablero[i+1,j+2] == 1 &&
                        tablero[i+2,j+1] == 1)
                    {
                        cuadros++;
                    }
                }
            }
            return cuadros;
        }

        // Registra movimientos, suma puntos a los jugadores, cambia turnos
        private void registrarMovimiento(int xIndex, int yIndex, Linea l)
        {
            cuadrosCompletos = getCuadros();
            tablero[xIndex, yIndex] = 1;
            if (j1.getTurno())
            {
                l.BackColor = Color.Red;
                l.setColor(Color.Red);
                l.setOcupada(true);
                if (cuadrosCompletos < getCuadros())
                {
                    j1.setPuntos(j1.getPuntos() + ((getCuadros() - cuadrosCompletos) * 10));
                }
                else
                {
                    panel_jugador2.BackColor = Color.DeepSkyBlue;
                    panel_jugador1.BackColor = DefaultBackColor;
                    j1.setTurno(false);
                    j2.setTurno(true);
                }
                puntos_j1.Text = "Puntos: " + j1.getPuntos();
            }
            else
            {
                l.BackColor = Color.Blue;
                l.setColor(Color.Blue);
                l.setOcupada(true);
                if (cuadrosCompletos < getCuadros())
                {
                    j2.setPuntos(j2.getPuntos() + ((getCuadros() - cuadrosCompletos) * 10));
                }
                else
                {
                    panel_jugador1.BackColor = Color.DeepSkyBlue;
                    panel_jugador2.BackColor = DefaultBackColor;
                    j2.setTurno(false);
                    j1.setTurno(true);
                }
                puntos_j2.Text = "Puntos: " + j2.getPuntos();
            }
            //printTablero();
            Utils.printLine(((tamañoTablero-1) * (tamañoTablero-1)).ToString());
            if(cuadrosCompletos >= (tamañoTablero-1) * (tamañoTablero-1))
            {
                if (j1.getPuntos() > j2.getPuntos()) Utils.printLine("Ganador: " + j1.getNombre());
                else Utils.printLine("Ganador: " + j2.getNombre());
            }
        }
    }
}
