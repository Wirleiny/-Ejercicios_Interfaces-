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
    public partial class Productos : Form
    {
        public Productos()
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
            if (string.IsNullOrEmpty(txtproducto.Text) || string.IsNullOrEmpty(cmbcategoria.Text) ||
            string.IsNullOrEmpty(txtstock.Text) || string.IsNullOrEmpty(txtprecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (txtproducto.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El campo producto no debe contener números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string producto = txtproducto.Text;
                string categoria = cmbcategoria.Text;
                int stock = int.Parse(txtstock.Text);
                decimal precio = decimal.Parse(txtprecio.Text);

                dgvinfo.Rows.Add(producto, categoria, stock, precio);

                MessageBox.Show("Producto agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos en Stock y Precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtproducto.Clear();
            cmbcategoria.SelectedIndex = -1;
            txtprecio.Clear();
            txtstock.Clear();
           
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dgvinfo.SelectedRows.Count > 0)
            {
                
                DataGridViewRow filaSeleccionada = dgvinfo.SelectedRows[0];

                
                txtproducto.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                cmbcategoria.Text = filaSeleccionada.Cells["Categoria"].Value.ToString();
                txtprecio.Text = filaSeleccionada.Cells["Precio"].Value.ToString();
                txtstock.Text = filaSeleccionada.Cells["Stock"].Value.ToString();

               
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













