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

namespace Desafio.M
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            {
                txtNombre.Clear();
                txtCargo.Clear();
                txtsueldo.Clear();
                txthijos.Clear();
                txtingresos.Clear();
                txtAFP.Clear();
                txtSFS.Clear();
                txtneto.Clear();
                txttotal.Clear();
                txtISR.Clear();
            }

        }
        private void btnborrar_Click(object sender, EventArgs e)
        {

            {
                if (dgvresultados.SelectedCells.Count > 0)
                {
                    int rowIndex = dgvresultados.SelectedCells[0].RowIndex;
                    dgvresultados.Rows.RemoveAt(rowIndex);
                    dgvinfo.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    MessageBox.Show("Seleccione una celda para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }


        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtCargo.Text) ||
                    string.IsNullOrWhiteSpace(txtsueldo.Text) ||
                    string.IsNullOrWhiteSpace(txthijos.Text) ||
                    string.IsNullOrWhiteSpace(txtingresos.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                string nombre = txtNombre.Text;
                string cargo = txtCargo.Text;
                decimal sueldo = Convert.ToDecimal(txtsueldo.Text);
                int hijos = Convert.ToInt32(txthijos.Text);
                decimal ingresos = Convert.ToDecimal(txtingresos.Text);

               
                decimal totalIngresos = sueldo + ingresos + (hijos * 1000);
                decimal afp = sueldo * 0.0287m;
                decimal sps = sueldo * 0.0304m;
                decimal isr = CalcularISR(sueldo); 
                decimal totalDescuentos = afp + sps + isr;

               
                decimal sueldoNeto = totalIngresos - totalDescuentos;

               
                txtAFP.Text = afp.ToString("C");
                txtSFS.Text = sps.ToString("C");
                txtISR.Text = isr.ToString("C");
                txttotal.Text = totalDescuentos.ToString("C");
                txtneto.Text = sueldoNeto.ToString("C");

                
                dgvresultados.Rows.Add(afp.ToString("C"), sps.ToString("C"), isr.ToString("C"), totalDescuentos.ToString("C"), sueldoNeto.ToString("C"));
               
                
                dgvinfo.Rows.Add(nombre, cargo, sueldo, hijos, ingresos);

               
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos en los campos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private decimal CalcularISR(decimal sueldo)
        {
            if (sueldo <= 34685)
                return 0;
            else if (sueldo <= 52027)
                return (sueldo - 34685) * 0.15m;
            else if (sueldo <= 72260)
                return (sueldo - 52027) * 0.20m + 2601.30m;
            else
                return (sueldo - 72260) * 0.25m + 6648.90m;
        }

        private bool isEditing = false;

        private void btneditar_Click(object sender, EventArgs e)
        {
            isEditing = !isEditing;

            dgvinfo.ReadOnly = !isEditing;
            dgvresultados.ReadOnly = !isEditing;

            if (isEditing)
            {
                btneditar.Text = "Desactivar Edición";
                MessageBox.Show("Por favor, seleccione una celda para editar y haga doble click sobre ella.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btneditar.Text = "Activar Edición";
            }
        }
     }
  }
    
  





