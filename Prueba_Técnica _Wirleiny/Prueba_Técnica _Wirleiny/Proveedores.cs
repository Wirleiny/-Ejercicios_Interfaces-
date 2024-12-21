using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Prueba_Técnica__Wirleiny
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            DialogResult resultado = MessageBox.Show(
                "¿Desea regresar al formulario principal?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Ok, Continúe utilizando este formulario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRNC.Text) || string.IsNullOrEmpty(txtnombre.Text) ||
            string.IsNullOrEmpty(txtdireccion.Text) || string.IsNullOrEmpty(txttelefono.Text) ||
            string.IsNullOrEmpty(txtcorreo.Text) || string.IsNullOrEmpty(cmbciudad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string telefono = txttele.Text;

            foreach (char c in telefono)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Ingrese solo valores numéricos en el campo de Teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
            }

            string rnc = txtRNC.Text;
            foreach (char c in rnc)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Ingrese solo valores numéricos en el campo de RNC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (txtnombre.Text.Any(char.IsDigit) || txtdireccion.Text.Any(char.IsDigit) ||
                txtcorreo.Text.Any(char.IsDigit) || cmbciudad.Text.Any(char.IsDigit))
            {
                MessageBox.Show("En los campos RNC, Nombre, Dirección, Correo y Ciudad solo se permiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string RNC = txtRNC.Text;
                string nombre = txtnombre.Text;
                string direccion = txtdireccion.Text;
                string telefonoF = txttelefono.Text; 
                string correo = txtcorreo.Text;
                string ciudad = cmbciudad.Text;

                dgvinfo.Rows.Add(nombre, rnc , direccion, telefonoF,correo,  ciudad);
               
                MessageBox.Show("Datos ingresados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRNC.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txttele.Clear();
            txtcorreo.Clear();
            cmbciudad.SelectedIndex = -1;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dgvinfo.SelectedRows.Count > 0)
            {

                DataGridViewRow filaSeleccionada = dgvinfo.SelectedRows[0];


                txtnombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtRNC.Text = filaSeleccionada.Cells["RNC"].Value.ToString();
                txtdireccion.Text = filaSeleccionada.Cells["Dirección "].Value.ToString();
               
                txtcorreo.Text = filaSeleccionada.Cells["Correo"].Value.ToString();
                txttelefono.Text = filaSeleccionada.Cells["Teléfono"].Value.ToString();
                cmbciudad.Text = filaSeleccionada.Cells["Ciudad"].Value.ToString();


                dgvinfo.Rows.Remove(filaSeleccionada);
            }
            else
            {
                MessageBox.Show("Por favor, haga doble clic en la celda que desea editar.", "Información ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvinfo.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (dgvinfo.CurrentCell == null)
            {
                MessageBox.Show("Seleccione una celda de la fila que desea eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta fila?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {

                int filaSeleccionada = dgvinfo.CurrentCell.RowIndex;
                dgvinfo.Rows.RemoveAt(filaSeleccionada);
                MessageBox.Show("Fila eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
