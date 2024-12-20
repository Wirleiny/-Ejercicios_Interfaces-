namespace Reserva
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lstdatos = new ListBox();
            txtCliente = new TextBox();
            txtPrecio = new TextBox();
            cmbtipo = new ComboBox();
            dtphasta = new DateTimePicker();
            dtpdesde = new DateTimePicker();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F);
            label1.Location = new Point(70, 70);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F);
            label2.Location = new Point(70, 125);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 1;
            label2.Text = "F_desde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F);
            label3.Location = new Point(70, 179);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 2;
            label3.Text = "F_hasta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 12F);
            label4.Location = new Point(70, 236);
            label4.Name = "label4";
            label4.Size = new Size(140, 28);
            label4.TabIndex = 3;
            label4.Text = "Tipo_Habitación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 12F);
            label5.Location = new Point(70, 284);
            label5.Name = "label5";
            label5.Size = new Size(61, 28);
            label5.TabIndex = 4;
            label5.Text = "Precio";
            // 
            // lstdatos
            // 
            lstdatos.Font = new Font("Segoe Print", 11F);
            lstdatos.FormattingEnabled = true;
            lstdatos.ItemHeight = 26;
            lstdatos.Location = new Point(465, 110);
            lstdatos.Name = "lstdatos";
            lstdatos.Size = new Size(176, 134);
            lstdatos.TabIndex = 5;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(235, 70);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(235, 284);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 7;
            // 
            // cmbtipo
            // 
            cmbtipo.FormattingEnabled = true;
            cmbtipo.Items.AddRange(new object[] { "Suite", "Doble", "Individual", "Triple", "Familiar" });
            cmbtipo.Location = new Point(235, 236);
            cmbtipo.Name = "cmbtipo";
            cmbtipo.Size = new Size(100, 23);
            cmbtipo.TabIndex = 8;
            cmbtipo.SelectedIndexChanged += cmbtipo_SelectedIndexChanged;
            // 
            // dtphasta
            // 
            dtphasta.Location = new Point(235, 184);
            dtphasta.Name = "dtphasta";
            dtphasta.Size = new Size(100, 23);
            dtphasta.TabIndex = 9;
            // 
            // dtpdesde
            // 
            dtpdesde.Location = new Point(235, 130);
            dtpdesde.Name = "dtpdesde";
            dtpdesde.Size = new Size(100, 23);
            dtpdesde.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ButtonHighlight;
            btnAgregar.Font = new Font("Segoe Print", 11F);
            btnAgregar.Location = new Point(182, 356);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(83, 31);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ButtonHighlight;
            btnEliminar.Font = new Font("Segoe Print", 11F);
            btnEliminar.Location = new Point(310, 356);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += button2_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ButtonHighlight;
            btnLimpiar.Font = new Font("Segoe Print", 11F);
            btnLimpiar.Location = new Point(439, 356);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(79, 31);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ButtonHighlight;
            btnSalir.Font = new Font("Segoe Print", 11F);
            btnSalir.Location = new Point(566, 356);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 31);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 13F);
            label6.Location = new Point(226, 10);
            label6.Name = "label6";
            label6.Size = new Size(231, 31);
            label6.TabIndex = 15;
            label6.Text = "Reserve sus habitaciones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 399);
            Controls.Add(label6);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dtpdesde);
            Controls.Add(dtphasta);
            Controls.Add(cmbtipo);
            Controls.Add(txtPrecio);
            Controls.Add(txtCliente);
            Controls.Add(lstdatos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox lstdatos;
        private TextBox txtCliente;
        private TextBox txtPrecio;
        private ComboBox cmbtipo;
        private DateTimePicker dtphasta;
        private DateTimePicker dtpdesde;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label6;
    }
}
