using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryGordillo1
{
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            string varToneladas = txtToneladas.Text;
            
            if (varToneladas != "")
            {
                
                StreamWriter swToneladas = new StreamWriter("./Toneladas.txt", true);

                swToneladas.WriteLine(lstLocalidad.Text + "," + lstCultivo.Text + "," + txtToneladas.Text);
                
                lstLocalidad.Text = "";
                lstCultivo.Text = "";
                txtToneladas.Text = "";
                lstLocalidad.Focus();

                MessageBox.Show("Carga completa");

                swToneladas.Close();

            }
            else
            {

              MessageBox.Show("Carga de datos incompleta");

            }
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            //cargamos a las listas con datos de los archivos 
            char separador = Convert.ToChar(",");

            if (File.Exists("./Localidades.txt"))
            {

                StreamReader srLocalidades = new StreamReader("./Localidades.txt");

                while (!srLocalidades.EndOfStream)
                {

                    string[] vecLocalidades = srLocalidades.ReadLine().Split(separador);
                    lstLocalidad.Items.Add(vecLocalidades[0]);

                }

                srLocalidades.Close();

            }

            if (File.Exists("./Cultivos.txt"))
            {

                StreamReader srCultivos = new StreamReader("./Cultivos.txt");

                while (!srCultivos.EndOfStream)
                {

                    string[] vecCultivos = srCultivos.ReadLine().Split(separador);
                    lstCultivo.Items.Add(vecCultivos[0]);

                }

                srCultivos.Close();

            }

        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            //Borrar archivo 
            File.Delete("./Toneladas.txt");
            MessageBox.Show("Archivo Eliminado");

        }
    }
}
