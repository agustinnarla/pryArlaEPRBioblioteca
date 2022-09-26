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
using System.Text.RegularExpressions;

namespace pryArlaEPRBioblioteca
{
    public partial class frmBiblioteca : Form
    {
        public frmBiblioteca()
        {
            InitializeComponent();
        }
        public Datos[,] matLibros = new Datos [21, 5];
        public int contador = 0;
        public struct Datos
        {
            public int Codigo;
            public string Nombre_del_Libro;
            public string Nombre_Editorial;
            public int  Codigo_Autor;
            public string Nombre_Disitribuidor;
        }

        private void frmBiblioteca_Load(object sender, EventArgs e)
        {

            char separador = Convert.ToChar(",");
            int i = 0;

            StreamReader srLibros = new StreamReader("./LIBRO.txt");

            while (!srLibros.EndOfStream && i < 21)
            {
                string[] vecLibro = srLibros.ReadLine().Split(separador);
                //borramos espacios en blanco
                for (int indice = 0; indice < vecLibro.Length; indice++)
                {
                    vecLibro[indice] = Regex.Replace(vecLibro[indice], @"\t", "");
                }

                matLibros[i, 0].Codigo = Convert.ToInt32(vecLibro[0]);
                matLibros[i, 1].Nombre_del_Libro = vecLibro[1];
                matLibros[i, 2].Nombre_Editorial = vecLibro[2];
                matLibros[i, 3].Codigo_Autor = Convert.ToInt32(vecLibro[3]);
                matLibros[i, 4].Nombre_Disitribuidor = vecLibro[4];

                //Asignamos los nombres de la editorial por nombre y no por numero 

                StreamReader srEditorial = new StreamReader("./EDITORIAL.txt");

                while (!srEditorial.EndOfStream )
                {
                    string[] vecEditorial = srEditorial.ReadLine().Split(separador);

                    //Borramos espacio en blanco
                    for (int indice = 0; indice < vecEditorial.Length; indice++)
                    {
                        //estamos remplazando una expresion por una cadena 
                        vecEditorial[indice] = Regex.Replace(vecEditorial[indice], @"\t", "");
                    }
                    //Asignamos nombre 
                    if (vecEditorial[0] == matLibros[i, 2].Nombre_Editorial)
                    {
                        matLibros[i, 2].Nombre_Editorial = vecEditorial[1];
                        
                    }
                }
                srEditorial.Close();

                StreamReader srDistribuidora = new StreamReader("./DISTRIBUIDORA.txt");

                while (!srDistribuidora.EndOfStream  )
                {
                    string[] vecDistribuidora = srDistribuidora.ReadLine().Split(separador);

                    //Borramos espacio en blanco
                    for (int indice = 0; indice < vecDistribuidora.Length; indice++)
                    {
                        //estamos remplazando una expresion por una cadena 
                        vecDistribuidora[indice] = Regex.Replace(vecDistribuidora[indice], @"\t", "");
                    }
                    //Asignamos nombre 
                    if (vecDistribuidora[0] == matLibros[i, 4].Nombre_Disitribuidor)
                    {
                        matLibros[i, 4].Nombre_Disitribuidor = vecDistribuidora[1];
                       
                    }
                }
                srDistribuidora.Close();

                i++;

            }
            srLibros.Close();

            txtCodigo.Text = Convert.ToString(matLibros[0, 0].Codigo);
            txtNombreLibro.Text = matLibros[0, 1].Nombre_del_Libro;
            txtNombreEdit.Text = matLibros[0, 2].Nombre_Editorial;
            txtCodigoAutor.Text = Convert.ToString(matLibros[0, 3].Codigo_Autor);
            txtNombreDistribuidor.Text = matLibros[0, 4].Nombre_Disitribuidor;

            cmdAtras.Enabled = false;


        }

        private void cmdAdelante_Click(object sender, EventArgs e)
        {
            contador++;


            txtCodigo.Text = Convert.ToString(matLibros[contador, 0].Codigo);
            txtNombreLibro.Text = matLibros[contador, 1].Nombre_del_Libro;
            txtNombreEdit.Text = matLibros[contador, 2].Nombre_Editorial;
            txtCodigoAutor.Text = Convert.ToString(matLibros[contador, 3].Codigo_Autor);
            txtNombreDistribuidor.Text = matLibros[contador, 4].Nombre_Disitribuidor;

            cmdAdelante.Enabled = true;
            cmdAtras.Enabled = true;

            if (contador == matLibros.GetLength(0) - 1)
            {
                cmdAdelante.Enabled = false;
            }
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            contador--;

            if (contador >= 0)
            {
                txtCodigo.Text = Convert.ToString(matLibros[contador, 0].Codigo);
                txtNombreLibro.Text = matLibros[contador, 1].Nombre_del_Libro;
                txtNombreEdit.Text = matLibros[contador, 2].Nombre_Editorial;
                txtCodigoAutor.Text = Convert.ToString(matLibros[contador, 3].Codigo_Autor);
                txtNombreDistribuidor.Text = matLibros[contador, 4].Nombre_Disitribuidor;
                
            }
            else
            {
                cmdAtras.Enabled = false;
            }

            if (contador == 0)
            {
                cmdAtras.Enabled = false;
            }

        }
    }
}
