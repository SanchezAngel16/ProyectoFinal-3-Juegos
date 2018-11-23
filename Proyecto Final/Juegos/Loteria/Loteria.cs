using Proyecto_Final.Juegos;
using Proyecto_Final.Juegos.Loteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Loteria : Form
    {
        String ruta = Application.StartupPath + "\\..\\..\\Juegos\\Resources\\Loteria\\Cartas\\";
        int[] cartas = new int[Utils.numCartas];
        List<int> cartasPasadas = new List<int>();
        List<Image> imgCartas = new List<Image>();
        int contadorCartas = 0;
        System.Threading.Timer timer;

        Jugador p1;
        Computadora computadora;

        public Loteria(String nombre, int[] jTablero, int[] cTablero)
        {
            InitializeComponent();
            recorrerArrayCartas();
            griton.SizeMode = PictureBoxSizeMode.StretchImage;
            computadora = new Computadora("Computadora", cTablero);
            p1 = new Jugador(nombre, jTablero);
            recorrerTablero();
        }

        // Recorrer tablero jugador persona
        private void recorrerTablero()
        {
            int index = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    // Cartas jugador persona
                    Carta c = new Carta(index);
                    c.Image = imgCartas.ElementAt(p1.getTablero()[index]);
                    tableroPersona.Controls.Add(c,j,i);
                    c.MouseClick += new MouseEventHandler((o, a) =>
                    {
                        if (cartasPasadas.Contains(p1.getTablero()[c.getValor()]))
                        {
                            c.Image = Image.FromFile(Application.StartupPath + "\\..\\..\\Juegos\\Resources\\Loteria\\piedra.png");
                            p1.setCartasContadas(p1.getCartasContadas() + 1);
                        }
                    });

                    // Cartas jugador computadora
                    Carta c2 = new Carta(index);
                    c2.Image = Image.FromFile(ruta + computadora.getTablero()[index] + ".jpg");
                    computadora.getCartas().Add(c2);
                    tableroComputadora.Controls.Add(c2, j, i);
                    index++;
                }
            }
        }

        // Iniciar arreglo de cartas
        private void recorrerArrayCartas()
        {
            for(int i = 0; i < Utils.numCartas; i++)
            {
                imgCartas.Add(Image.FromFile(ruta + i + ".jpg"));
            }
        }

        private void btn_Empezar_Click(object sender, EventArgs e)
        {
            timer = new System.Threading.Timer(
            m =>  mostrarImagenes(),
            null,
            TimeSpan.Zero,
            TimeSpan.FromSeconds(3));
        }

        // Pasar cartas
        private void mostrarImagenes()
        {
            if((contadorCartas >= Utils.numCartas) || (p1.getCartasContadas() >= 9 || computadora.getCartasContadas() >= 9))
            {
                if(p1.getCartasContadas() > computadora.getCartasContadas())
                {
                    DialogResult r = MessageBox.Show("Ganador: Persona");
                }
                else
                {
                    DialogResult r = MessageBox.Show("Ganador: Computadora");
                }
                timer.Dispose();
                Utils.printLine("Acabo");
            }
            else
            {
                int carta = 0;
                
                do
                {
                    carta = Utils.generarNumeroAleatorio(0, Utils.numCartas);
                } while (cartasPasadas.Contains(carta));
                
                setGriton(carta);
                cartasPasadas.Add(carta);
                computadora.checarTablero(carta);
                contadorCartas++;
            }
        }

        // Cambiar carta del griton
        private void setGriton(int index)
        {
            griton.Image = imgCartas.ElementAt(index);
        }
    }
}
