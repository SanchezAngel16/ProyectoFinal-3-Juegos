using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Nombre del equipo: Catia
 * Integrantes:
 *      Sanchez Romero Angel de Jesus
 *      Casas Torres Hector Alfonso
 *      Reyes Peña Moises Alberto
 *      Rodriguez Montiel Luis Jesus
 * 
 * Bitacora de actualización
 *      * Fecha de inicio: 12 de noviembre del 2018
 *      * Descripcion: Se estructuraron las carpetas del proyecto (Loteria, Timbiriche y Sopa de Letras
 *      y se crearon las ventanas de cada juego y un menu de inicio.
 *      Se implementaron las primeras clases para el juego de timbiriche (Punto, Adyacente y Movimiento)
 *      Se implemento la clase general (Utils)
 *      Se implemento el metodo getAdyacentes(Punto punto) en la clase "Adyacente", que calculas
 *      los posibles movimientos admitidos para determinado punto en determinada posición para
 *      el juego de Timbiriche.
 *      * Autor(es): Angel de Jesus Sanchez Romero
 *      
 *     * Fecha: 13 de noviembre del 2018
 *     * Descripcion: Se hicieron pruebas con el metodo getAdyacentes(Punto punto) para tableros
 *     de 3x3, 4x4 y 5x5.
 *     Se añadio la carpeta Resources para los graficos necesarios en Timbiriche
 *     Se implemento la funcion registrar movimiento para validar los movimientos
 *     Se implementaron colores para las uniones entre puntos para diferenciar turnos
 *     * Autor(es): Angel de Jesus Sanchez Romero
 */

namespace Proyecto_Final
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_Loteria_Click(object sender, EventArgs e)
        {
            Form loteriaForm = new Loteria();
            loteriaForm.Show();
        }

        private void btn_Timbiriche_Click(object sender, EventArgs e)
        {
            Form timbiricheForm = new Timbiriche();
            timbiricheForm.Show();
        }

        private void btn_Sopa_Click(object sender, EventArgs e)
        {
            Form sopaLetrasForm = new SopaLetras();
            sopaLetrasForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
