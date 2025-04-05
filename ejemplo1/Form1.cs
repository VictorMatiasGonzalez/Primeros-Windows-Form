using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Saludar_Click(object sender, EventArgs e)// (metodo que se ejecuta cuando hacemos clic en el boton saludar)
        {
            // MessageBox.Show("Hola Mundo");//( hacemos clic y tira el mensaj "hola mundo") METODO EVENTO >> vinculado a un contexto , cuando hacemos el clic lanza la funcion/evento.
            string texto = txtNombre.Text; //guarda el texto(nombre)
            labelSaludar.Text = "Hola" + texto;// cuando hacemos clic en saludar_clic , en la etiqueta de abajo aparece "Hola Matias"
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(" Te doy la bienvenida");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Gracias por usar la app");
        }
    }
}
