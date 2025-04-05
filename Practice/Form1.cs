using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void btbSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string dire = txtDire.Text;
            labelSaludar.Text = "Hola" + nombre;
            labelDire.Text = "La direccion es:" + dire;

        }

        private void Ventana_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido");
        }
    }
    }
