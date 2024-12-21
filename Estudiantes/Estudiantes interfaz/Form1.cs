using static System.Net.Mime.MediaTypeNames;

namespace Estudiantes_interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(txtnumero1.Text);
            double N2 = Convert.ToDouble(txtnumero2.Text);
            double N3 = Convert.ToDouble(txtnumero3.Text);
            double N4 = Convert.ToDouble(txtnumero4.Text);

            double Promedio = (N1 + N2 + N3 + N4) / 4;

            txtpromedio.Text = $"{Promedio}";

            if (Promedio >= 70)
            {
                txtstatus.Text = "Aprobo.";
                txtstatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                txtstatus.Text = "Reprobo.";
                txtstatus.ForeColor = System.Drawing.Color.Red;
            }


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtnumero1.Clear();
            txtnumero2.Clear();
            txtnumero3.Clear();
            txtnumero4.Clear();
            txtpromedio.Clear();
            txtstatus.Clear();
            cmbcurso.SelectedIndex = -1;           
            cmbarea.SelectedIndex = -1;
            cmbseccion.SelectedIndex = -1;
            rbfemenino.Checked = false;
            rbmasculino.Checked = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
