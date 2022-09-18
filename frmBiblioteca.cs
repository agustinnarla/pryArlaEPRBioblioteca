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

        private void cmdConsultar_Click(object sender, EventArgs e)
        {

            char separador = Convert.ToChar(",");
        
            StreamReader srLibros = new StreamReader("./LIBRO.txt");
            
            while (!srLibros.EndOfStream)
            {
                string[] vecBiblioteca = srLibros.ReadLine().Split(separador);
                grlLibros.Rows.Add(vecBiblioteca);
            
            }
            srLibros.Close();

        }
    }
}
