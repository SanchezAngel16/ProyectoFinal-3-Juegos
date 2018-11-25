using Proyecto_Final.Juegos.Timbiriche;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Juegos
{
    static class Utils
    {
        private static Random r = new Random();
        public static Color lineaSinConectar = Color.White;
        public const int numCartas = 54;

        // Funcion para depurar 
        public static void print(String message)
        {
            System.Diagnostics.Debug.Write(message);
        }

        public static void printLine(String message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }

        //Funcion para dibujar una linea
        public static void drawLine(Color color, float x1, float y1, float x2, float y2, Form p)
        {
            Pen pen = new Pen(color);
            pen.Width = 5;
            Graphics graphics = p.CreateGraphics();
            graphics.Clear(SystemColors.Control);
            graphics.DrawLine(pen, x1, y1, x2, y2);
        }

        // Funcion parar generar un numero aleatorio entre un rango
        public static int generarNumeroAleatorio(int valorMin, int valorMax)
        {
            return r.Next(valorMin, valorMax);
        }

        // Funcion para cambiar de color un label
        public static void changeLabelColor(Label label)
        {
            label.ForeColor = Color.Green;
        }

        // Funcion para reproducir sonido de punto
        public static void playPointSound()
        {
            SoundPlayer simpleSound = new System.Media.SoundPlayer(Properties.Resources.score);
            simpleSound.Play();
        }
    }
}
