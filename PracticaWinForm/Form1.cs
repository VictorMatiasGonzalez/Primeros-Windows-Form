using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaWinForm
{
    public partial class practica : Form
    {
        public practica()
        {
            InitializeComponent();
        }

        private void BtnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direc = txtDireccion.Text;

            labelSaludar.Text = "Hola" + nombre;
            labelDi.Text = " La direccion es:" + direc;

        }

        private void BtnDespedir_Click(object sender, EventArgs e)
        {
            string nombre2 = txtNombre.Text;
            labelDespedir.Text = " Adios" + nombre2;
        }
    }
}
