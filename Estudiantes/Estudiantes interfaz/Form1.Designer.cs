namespace Estudiantes_interfaz
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
            txtN1 = new Label();
            txtN2 = new Label();
            txtN3 = new Label();
            txtN4 = new Label();
            label10 = new Label();
            cmbarea = new ComboBox();
            btncalcular = new Button();
            btnLimpiar = new Button();
            btnsalir = new Button();
            groupBox1 = new GroupBox();
            rbfemenino = new RadioButton();
            rbmasculino = new RadioButton();
            txtNombre = new TextBox();
            txtnumero1 = new TextBox();
            txtnumero2 = new TextBox();
            txtnumero3 = new TextBox();
            txtnumero4 = new TextBox();
            cmbseccion = new ComboBox();
            cmbcurso = new ComboBox();
            groupBox2 = new GroupBox();
            txtpromedio = new TextBox();
            txtstatus = new TextBox();
            Status = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(49, 47);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(49, 90);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 1;
            label2.Text = "Curso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(49, 137);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 2;
            label3.Text = " Sección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(49, 187);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 3;
            label4.Text = "Area";
            // 
            // txtN1
            // 
            txtN1.AutoSize = true;
            txtN1.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txtN1.ForeColor = SystemColors.ButtonHighlight;
            txtN1.Location = new Point(49, 262);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(31, 21);
            txtN1.TabIndex = 5;
            txtN1.Text = "N1";
            txtN1.Click += label6_Click;
            // 
            // txtN2
            // 
            txtN2.AutoSize = true;
            txtN2.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txtN2.ForeColor = SystemColors.ButtonHighlight;
            txtN2.Location = new Point(49, 312);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(31, 21);
            txtN2.TabIndex = 6;
            txtN2.Text = "N2";
            // 
            // txtN3
            // 
            txtN3.AutoSize = true;
            txtN3.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txtN3.ForeColor = SystemColors.ButtonHighlight;
            txtN3.Location = new Point(49, 359);
            txtN3.Name = "txtN3";
            txtN3.Size = new Size(31, 21);
            txtN3.TabIndex = 7;
            txtN3.Text = "N3";
            // 
            // txtN4
            // 
            txtN4.AutoSize = true;
            txtN4.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txtN4.ForeColor = SystemColors.ButtonHighlight;
            txtN4.Location = new Point(49, 404);
            txtN4.Name = "txtN4";
            txtN4.Size = new Size(31, 21);
            txtN4.TabIndex = 8;
            txtN4.Text = "N4";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(129, 9);
            label10.Name = "label10";
            label10.Size = new Size(244, 25);
            label10.TabIndex = 9;
            label10.Text = "Ingrese Los Siguientes Datos";
            // 
            // cmbarea
            // 
            cmbarea.FormattingEnabled = true;
            cmbarea.Items.AddRange(new object[] { "Informática ", "Gastronomía ", "Contabilidad", " Electricidad ", "Enfermería   " });
            cmbarea.Location = new Point(160, 189);
            cmbarea.Name = "cmbarea";
            cmbarea.Size = new Size(107, 23);
            cmbarea.TabIndex = 12;
            // 
            // btncalcular
            // 
            btncalcular.BackColor = Color.White;
            btncalcular.ForeColor = Color.Black;
            btncalcular.Location = new Point(94, 469);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(81, 23);
            btncalcular.TabIndex = 13;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = false;
            btncalcular.Click += button1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Location = new Point(214, 469);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(84, 23);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += button2_Click;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.White;
            btnsalir.Font = new Font("Segoe UI", 9F);
            btnsalir.ForeColor = Color.Black;
            btnsalir.Location = new Point(347, 469);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 15;
            btnsalir.Text = "Salir";
            btnsalir.TextImageRelation = TextImageRelation.TextAboveImage;
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbfemenino);
            groupBox1.Controls.Add(rbmasculino);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(302, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(161, 116);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generó ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbfemenino
            // 
            rbfemenino.AutoSize = true;
            rbfemenino.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            rbfemenino.ForeColor = SystemColors.ButtonHighlight;
            rbfemenino.Location = new Point(6, 22);
            rbfemenino.Name = "rbfemenino";
            rbfemenino.Size = new Size(97, 25);
            rbfemenino.TabIndex = 19;
            rbfemenino.TabStop = true;
            rbfemenino.Text = "Femenino";
            rbfemenino.UseVisualStyleBackColor = true;
            // 
            // rbmasculino
            // 
            rbmasculino.AutoSize = true;
            rbmasculino.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            rbmasculino.ForeColor = SystemColors.ButtonHighlight;
            rbmasculino.Location = new Point(6, 62);
            rbmasculino.Name = "rbmasculino";
            rbmasculino.Size = new Size(102, 25);
            rbmasculino.TabIndex = 20;
            rbmasculino.TabStop = true;
            rbmasculino.Text = "Masculino ";
            rbmasculino.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(107, 23);
            txtNombre.TabIndex = 19;
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(103, 264);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(40, 23);
            txtnumero1.TabIndex = 22;
            // 
            // txtnumero2
            // 
            txtnumero2.Location = new Point(103, 314);
            txtnumero2.Name = "txtnumero2";
            txtnumero2.Size = new Size(40, 23);
            txtnumero2.TabIndex = 23;
            // 
            // txtnumero3
            // 
            txtnumero3.Location = new Point(103, 359);
            txtnumero3.Name = "txtnumero3";
            txtnumero3.Size = new Size(40, 23);
            txtnumero3.TabIndex = 24;
            // 
            // txtnumero4
            // 
            txtnumero4.Location = new Point(103, 406);
            txtnumero4.Name = "txtnumero4";
            txtnumero4.Size = new Size(40, 23);
            txtnumero4.TabIndex = 25;
            txtnumero4.TextChanged += textBox7_TextChanged;
            // 
            // cmbseccion
            // 
            cmbseccion.FormattingEnabled = true;
            cmbseccion.Items.AddRange(new object[] { "A1", "", "A2", "", "A3", "", "A4", "", "B1", "", "B2", "", "C1", "", "C2", "", "D1", "", "D2", "", "E1", "", "E2" });
            cmbseccion.Location = new Point(160, 139);
            cmbseccion.Name = "cmbseccion";
            cmbseccion.Size = new Size(107, 23);
            cmbseccion.TabIndex = 26;
            // 
            // cmbcurso
            // 
            cmbcurso.FormattingEnabled = true;
            cmbcurso.Items.AddRange(new object[] { "4to", "5to", "6to" });
            cmbcurso.Location = new Point(160, 92);
            cmbcurso.Name = "cmbcurso";
            cmbcurso.Size = new Size(107, 23);
            cmbcurso.TabIndex = 27;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtpromedio);
            groupBox2.Controls.Add(txtstatus);
            groupBox2.Controls.Add(Status);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(239, 290);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(224, 119);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultados";
            // 
            // txtpromedio
            // 
            txtpromedio.Location = new Point(108, 28);
            txtpromedio.Name = "txtpromedio";
            txtpromedio.Size = new Size(79, 25);
            txtpromedio.TabIndex = 21;
            // 
            // txtstatus
            // 
            txtstatus.Location = new Point(108, 67);
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new Size(79, 25);
            txtstatus.TabIndex = 20;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            Status.Location = new Point(19, 69);
            Status.Name = "Status";
            Status.Size = new Size(56, 21);
            Status.TabIndex = 1;
            Status.Text = "Status ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label5.Location = new Point(19, 30);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 0;
            label5.Text = "Promedio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(505, 515);
            Controls.Add(groupBox2);
            Controls.Add(cmbcurso);
            Controls.Add(cmbseccion);
            Controls.Add(txtnumero4);
            Controls.Add(txtnumero3);
            Controls.Add(txtnumero2);
            Controls.Add(txtnumero1);
            Controls.Add(txtNombre);
            Controls.Add(groupBox1);
            Controls.Add(btnsalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btncalcular);
            Controls.Add(cmbarea);
            Controls.Add(label10);
            Controls.Add(txtN4);
            Controls.Add(txtN3);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label txtN1;
        private Label txtN2;
        private Label txtN3;
        private Label txtN4;
        private Label label10;
        private ComboBox cmbarea;
        private Button btncalcular;
        private Button btnLimpiar;
        private Button btnsalir;
        private GroupBox groupBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private RadioButton rbfemenino;
        private RadioButton rbmasculino;
        private TextBox txtNombre;
        private TextBox txtnumero1;
        private TextBox txtnumero2;
        private TextBox txtnumero3;
        private TextBox txtnumero4;
        private ComboBox cmbseccion;
        private ComboBox cmbcurso;
        private GroupBox groupBox2;
        private TextBox txtpromedio;
        private TextBox txtstatus;
        private Label Status;
        private Label label5;
    }
}
