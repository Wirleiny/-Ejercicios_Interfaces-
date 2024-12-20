namespace Reserva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Reserva
        {
            public string? Cliente { get; set; }
            public string? F_desde { get; set; }
            public string? F_hasta { get; set; }
            public string? TipoHabitacion { get; set; }
            public int Precio { get; set; }
        }

        Reserva reserva = new Reserva();

        private void button2_Click(object sender, EventArgs e)
        {
            lstdatos.Items.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            reserva.Cliente = txtCliente.Text;
            reserva.F_desde = dtpdesde.Value.ToShortDateString();
            reserva.F_hasta = dtphasta.Value.ToShortDateString();
            reserva.TipoHabitacion = cmbtipo.Text;

            lstdatos.Items.Add($"Cliente: {reserva.Cliente}");
            lstdatos.Items.Add($"Desde: {reserva.F_desde}");
            lstdatos.Items.Add($"Hasta: {reserva.F_hasta}");
            lstdatos.Items.Add($"Tipo de habitación: {reserva.TipoHabitacion}");
            lstdatos.Items.Add($"Precio: {reserva.Precio}");  
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtPrecio.Clear();
            cmbtipo.SelectedIndex = -1;
            dtpdesde.Value = DateTime.Now;
            dtphasta.Value = DateTime.Now;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cmbtipo.Text)
            {
                case "Suite":
                    txtPrecio.Text = "10,000";
                    reserva.Precio = 10000; 
                    break;
                case "Doble":
                    txtPrecio.Text = "4,000";
                    reserva.Precio = 4000; 
                    break;
                case "Individual":
                    txtPrecio.Text = "2,000";
                    reserva.Precio = 2000; 
                    break;
                case "Triple":
                    txtPrecio.Text = "6,000";
                    reserva.Precio = 6000; 
                    break;
                case "Familiar":
                    txtPrecio.Text = "15,000";
                    reserva.Precio = 15000; 
                    break;
                default:
                    txtPrecio.Text = "";
                    reserva.Precio = 0; 
                    break;
            }
        }
    }
}


