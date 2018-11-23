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
    public partial class RegistroLoteria : Form
    {
        int[] tablero = new int[9];
        int[] tableroComputador = new int[9];
        private bool eligioTablero;
        private bool tableroGenerado;

        public RegistroLoteria()
        {
            InitializeComponent();
        }

        private void btn_Empezar_Click(object sender, EventArgs e)
        {
            generarTablero();
            if (!txtNombre.Text.Equals("") && eligioTablero && tableroGenerado)
            {
                Form loteriaForm = new Loteria(txtNombre.Text, this.tablero, this.tableroComputador);
                loteriaForm.Show();
                this.Hide();
            }
            
        }

        private void generarTablero()
        {
            List<int> cartas = new List<int>();
            int carta = 0;
            for(int i = 0; i < 9; i++)
            {
                do
                {
                    carta = Utils.generarNumeroAleatorio(0, Utils.numCartas);
                } while (cartas.Contains(carta));
                cartas.Add(carta);
                tableroComputador[i] = carta;
            }
            tableroGenerado = true;
        }

        private void tablero1_Click(object sender, EventArgs e)
        {
            eligioTablero = true;
            tablero[0] = 1;
            tablero[1] = 12;
            tablero[2] = 11;
            tablero[3] = 39;
            tablero[4] = 35;
            tablero[5] = 21;
            tablero[6] = 13;
            tablero[7] = 4;
            tablero[8] = 51;
        }

        private void tablero2_Click(object sender, EventArgs e)
        {
            eligioTablero = true;
            tablero[0] = 0;
            tablero[1] = 6;
            tablero[2] = 8;
            tablero[3] = 9;
            tablero[4] = 18;
            tablero[5] = 23;
            tablero[6] = 26;
            tablero[7] = 47;
            tablero[8] = 53;
        }

        private void tablero3_Click(object sender, EventArgs e)
        {
            eligioTablero = true;
            tablero[0] = 10;
            tablero[1] = 28;
            tablero[2] = 31;
            tablero[3] = 33;
            tablero[4] = 36;
            tablero[5] = 38;
            tablero[6] = 40;
            tablero[7] = 48;
            tablero[8] = 49;
        }
    }
}
