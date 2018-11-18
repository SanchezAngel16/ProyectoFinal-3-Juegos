using Proyecto_Final.Juegos.Timbiriche;
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
    public partial class RegistroTimbiriche : Form
    {

        private int boardSize;
        private String nombreTablero;

        public RegistroTimbiriche()
        {
            InitializeComponent();
        }

        private void btn_EmpezarPartida_Click(object sender, EventArgs e)
        {
            if(txtJugador1.Text.Length > 0 && txtJugador2.Text.Length > 0 && boardSize > 0)
            {
                Form timbiricheForm = new Timbiriche(txtJugador1.Text, txtJugador2.Text, boardSize, nombreTablero);
                timbiricheForm.Show();
            }
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                nombreTablero = "6x6.txt";
                boardSize = 6;
                checkBox2.Checked = false;
                checkBox1.Checked = false;
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                nombreTablero = "5x5.txt";
                boardSize = 5;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                nombreTablero = "4x4.txt";
                boardSize = 4;
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
        }
    }
}
