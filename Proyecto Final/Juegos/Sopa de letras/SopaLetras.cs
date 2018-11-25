using Proyecto_Final.Juegos;
using Proyecto_Final.Juegos.Sopa_de_letras;
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
    public partial class SopaLetras : Form
    {
        int programar = 0;
        int compilar = 0;
        int codigo = 0;
        int isc = 0;
        int linker = 0;
        int csharp = 0;
        int holaMundo = 0;

        bool programarCompleto = false;
        bool compilarCompleto = false;
        bool codigoCompleto = false;
        bool iscCompleto = false;
        bool linkerCompleto = false;
        bool csharpCompleto = false;
        bool holaMundoCompleto = false;

        private char[,] sopa = new char[10,10]{ 
            { 'J','K','G','B','C','O','D','I','G','O' },
            { 'L','F','C','A','T','P','D','I','S','C' },
            { 'I','Z','C','S','H','A','R','P','A','D' },
            { 'N','Q','T','V','P','X','Y','B','F','B' },
            { 'K','R','A','U','F','G','D','Z','E','C' },
            { 'E','P','R','O','G','R','A','M','A','R' },
            { 'R','S','H','T','N','O','J','D','K','G' },
            { 'H','O','L','A','M','U','N','D','O','H' },
            { 'M','K','I','L','J','M','J','I','K','L' },
            { 'C','O','M','P','I','L','A','D','O','R' }
        };

        private int[,] sopaLogica = new int[,]
        {
            { 0,0,0,0,3,3,3,3,3,3 },
            { 5,0,0,0,0,0,0,4,4,4 },
            { 5,0,6,6,6,6,6,6,0,0 },
            { 5,0,0,0,0,0,0,0,0,0 },
            { 5,0,0,0,0,0,0,0,0,0 },
            { 5,1,1,1,1,1,1,1,1,1 },
            { 5,0,0,0,0,0,0,0,0,0 },
            { 7,7,7,7,7,7,7,7,7,0 },
            { 0,0,0,0,0,0,0,0,0,0 },
            { 2,2,2,2,2,2,2,2,2,2 }
        };

        public SopaLetras()
        {
            InitializeComponent();
            inicializarTablero();
        }

        private void sumarLetrasAPalabras(int valor)
        {
            switch (valor)
            {
                case 1:
                    programar++;
                    break;
                case 2:
                    compilar++;
                    break;
                case 3:
                    codigo++;
                    break;
                case 4:
                    isc++;
                    break;
                case 5:
                    linker++;
                    break;
                case 6:
                    csharp++;
                    break;
                case 7:
                    holaMundo++;
                    break;
                default:
                    break;
            }
        }

        private void checarPalabras()
        {
            if (programar == 9 && !programarCompleto)
            {
                programarCompleto = true;
                Utils.changeLabelColor(lblProgramar);
                Utils.playPointSound();
            }
            if (compilar == 10 && !compilarCompleto)
            {
                compilarCompleto = true;
                Utils.changeLabelColor(lblCompilar);
                Utils.playPointSound();
            }
            if (codigo == 6 && !codigoCompleto)
            {
                codigoCompleto = true;
                Utils.changeLabelColor(lblCodigo);
                Utils.playPointSound();
            }
            if (isc == 3 && !iscCompleto)
            {
                iscCompleto = true;
                Utils.changeLabelColor(lblIsc);
                Utils.playPointSound();
            }
            if (linker == 6 && !linkerCompleto)
            {
                linkerCompleto = true;
                Utils.changeLabelColor(lblLinker);
                Utils.playPointSound();
            }
            if(csharp == 6 && !csharpCompleto)
            {
                csharpCompleto = true;
                Utils.changeLabelColor(lblCSharp);
                Utils.playPointSound();
            }
            if (holaMundo == 9 && !holaMundoCompleto)
            {
                holaMundoCompleto = true;
                Utils.changeLabelColor(lblHolaMundo);
                Utils.playPointSound();
            }

            if(programarCompleto && compilarCompleto && iscCompleto && linkerCompleto && csharpCompleto && holaMundoCompleto)
            {
                DialogResult r = MessageBox.Show("Lo lograste");
                this.Close();
            }
        }

        private void letraOnClick(Letra letra)
        {
            letra.BackColor = Color.Blue;
            letra.getLabel().ForeColor = Color.White;
            letra.Enabled = false;
            letra.getLabel().Enabled = false;
            Utils.print(letra.getValor().ToString());
            sumarLetrasAPalabras(letra.getValor());
            checarPalabras();
        }

        private void inicializarTablero()
        {  
            tableroSopa.ColumnCount = 10;
            tableroSopa.RowCount = 10;
            tableroSopa.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableroSopa.ColumnStyles[0].SizeType = SizeType.AutoSize;
            tableroSopa.RowStyles[0].SizeType = SizeType.AutoSize;
            int letras = 65;
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Letra letra = new Letra(sopa[i,j], sopaLogica[i,j]);
                    letra.MouseClick += new MouseEventHandler((o, a) =>
                    {
                        letraOnClick(letra);
                    });
                    letra.getLabel().MouseClick += new MouseEventHandler((o, a) =>
                    {
                        letraOnClick(letra);
                    });
                    tableroSopa.Controls.Add(letra, j, i);
                    letras++;
                }
            }
        }
    }
}
