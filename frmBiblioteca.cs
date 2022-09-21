using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryArlaEPRBioblioteca
{
    public partial class frmBiblioteca : Form
    {
        public frmBiblioteca()
        {
            InitializeComponent();
        }
        public string[,] matLibro = new string[20, 5];
        public int contador = 0;
        private void cmdConsultar_Click(object sender, EventArgs e)
        {

            char separador = Convert.ToChar(",");
            int i = 0;
        
            StreamReader srLibros = new StreamReader("./LIBRO.txt");
            
            while (!srLibros.EndOfStream && i < 21 )
            {
                string[] vecBiblioteca = srLibros.ReadLine().Split(separador);

                matLibro[i, 0] = vecBiblioteca[0];
                matLibro[i, 1] = vecBiblioteca[1];
                matLibro[i, 2] = vecBiblioteca[2];
                matLibro[i, 3] = vecBiblioteca[3];
                matLibro[i, 4] = vecBiblioteca[4];

                //StreamReader srEditorial = new StreamReader("./EDITORIAL.txt");
                //while (!srEditorial.EndOfStream)
                //{
                //    string[] vecEditorial = srEditorial.ReadLine().Split(separador);
                    
                //}
            }
            srLibros.Close();

        }
    }
}
