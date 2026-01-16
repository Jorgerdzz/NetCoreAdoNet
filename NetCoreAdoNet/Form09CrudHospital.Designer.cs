namespace NetCoreAdoNet
{
    partial class Form09CrudHospital
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lstHospitales = new ListBox();
            label2 = new Label();
            txtHospitalCod = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtDireccion = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            txtNumCamas = new TextBox();
            label6 = new Label();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 30);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.Location = new Point(46, 62);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(350, 229);
            lstHospitales.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 30);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Codigo hospital";
            // 
            // txtHospitalCod
            // 
            txtHospitalCod.Location = new Point(421, 62);
            txtHospitalCod.Name = "txtHospitalCod";
            txtHospitalCod.Size = new Size(206, 23);
            txtHospitalCod.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 103);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(422, 134);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 23);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 182);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(422, 210);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(198, 23);
            txtDireccion.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(427, 253);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 8;
            label5.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(429, 279);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(191, 23);
            txtTelefono.TabIndex = 9;
            // 
            // txtNumCamas
            // 
            txtNumCamas.Location = new Point(428, 346);
            txtNumCamas.Name = "txtNumCamas";
            txtNumCamas.Size = new Size(192, 23);
            txtNumCamas.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 323);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 11;
            label6.Text = "Numero de camas";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(46, 297);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(350, 23);
            btnInsertar.TabIndex = 12;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(46, 326);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(350, 23);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(46, 355);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(350, 23);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form09CrudHospital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(label6);
            Controls.Add(txtNumCamas);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtHospitalCod);
            Controls.Add(label2);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Name = "Form09CrudHospital";
            Text = "Form09CrudHospital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstHospitales;
        private Label label2;
        private TextBox txtHospitalCod;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtDireccion;
        private Label label5;
        private TextBox txtTelefono;
        private TextBox txtNumCamas;
        private Label label6;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}