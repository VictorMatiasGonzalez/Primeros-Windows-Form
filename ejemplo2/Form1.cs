using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem); 
        }

        private void Form1_Load(object sender, EventArgs e)//cuando nace la ventana
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Negro");
            cboColorFavorito.Items.Add("Azul");


        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;// Nombre en caja texto
            DateTime fecha = dtpFechaNacimiento.Value;// devuelve fecha/hora en datatimepicker
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta"; //operador ternario > es un if en una sola linea.
            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rbtSquibs.Checked)
                tipo = "Squibs";
            else
                tipo = "Wizard";
            string colorFavorito = cboColorFavorito.SelectedItem.ToString(); // devuelve un string dentro del menu
            string numerofavorito = numNumeroFavorito.Value.ToString(); // transforma en string

            string mensaje = chocolate + " , es" + tipo + ", su color es " + colorFavorito + "; su numero es: " + numerofavorito;
            MessageBox.Show(" Nombre:" + nombre + " Fecha:" + fecha + mensaje);

        }
    }
}
