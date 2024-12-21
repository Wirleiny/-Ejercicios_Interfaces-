using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Técnica__Wirleiny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.ShowDialog();
        }

       
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
        "¿Está seguro de que desea salir?",
        "Confirmación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

           
            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); 
            }
            else
            {
                MessageBox.Show("Esta bien, Continúe disfrutando del sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}

