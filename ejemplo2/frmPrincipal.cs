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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {//Elementos menu.
         //-------------------------------------------------------------------------------
            //Como hacer que no habras esta ventana mas de una vez
            foreach ( var item in Application.OpenForms)// (coleccion formularios)
            {
                if (item.GetType() == typeof(Form1)) // gettype> devuelve el tipo de objeto
                {
                    MessageBox.Show ("ya esta abierta la venta, trabaje alli..");
                    return;
                } 
            }                           // si el tipo de objeto q estoy evaluando es igual tipo form1 > return!
            //al hacer return solo habre una ventana y no permite mas que esa!
         //-------------------------------------------------------------------------------
            Form1 ventana = new Form1();// creo la clase ventana que es form1
            ventana.MdiParent = this;// propiedad
            ventana.Show();// pido que la ventana se muestre.(showdialog) permite solo interactuar con la ventana abierta!
        }

        private void tsbperfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();// Boton tambien llevaa perfil persona(fuera pantalla principal)
        }
    
    }
}
