namespace NetCoreAdoNet
{
    partial class Form10UpdateEmpleadosOficios
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
            lstOficios = new ListBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            label3 = new Label();
            txtIncremento = new TextBox();
            btnSubirSalarios = new Button();
            lblMediaSalarial = new Label();
            lblMaximoSalario = new Label();
            lblSumaSalarial = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 32);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(57, 63);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(201, 259);
            lstOficios.TabIndex = 1;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 30);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(312, 61);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(182, 259);
            lstEmpleados.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(528, 29);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 4;
            label3.Text = "Incremento salarial";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(528, 63);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 5;
            // 
            // btnSubirSalarios
            // 
            btnSubirSalarios.Location = new Point(528, 108);
            btnSubirSalarios.Name = "btnSubirSalarios";
            btnSubirSalarios.Size = new Size(100, 23);
            btnSubirSalarios.TabIndex = 6;
            btnSubirSalarios.Text = "Subir salarios";
            btnSubirSalarios.UseVisualStyleBackColor = true;
            btnSubirSalarios.Click += btnSubirSalarios_Click;
            // 
            // lblMediaSalarial
            // 
            lblMediaSalarial.AutoSize = true;
            lblMediaSalarial.Location = new Point(57, 359);
            lblMediaSalarial.Name = "lblMediaSalarial";
            lblMediaSalarial.Size = new Size(90, 15);
            lblMediaSalarial.TabIndex = 7;
            lblMediaSalarial.Text = "lblMediaSalarial";
            // 
            // lblMaximoSalario
            // 
            lblMaximoSalario.AutoSize = true;
            lblMaximoSalario.Location = new Point(57, 385);
            lblMaximoSalario.Name = "lblMaximoSalario";
            lblMaximoSalario.Size = new Size(99, 15);
            lblMaximoSalario.TabIndex = 8;
            lblMaximoSalario.Text = "lblMaximoSalario";
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(57, 335);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(87, 15);
            lblSumaSalarial.TabIndex = 9;
            lblSumaSalarial.Text = "lblSumaSalarial";
            // 
            // Form10UpdateEmpleadosOficios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSumaSalarial);
            Controls.Add(lblMaximoSalario);
            Controls.Add(lblMediaSalarial);
            Controls.Add(btnSubirSalarios);
            Controls.Add(txtIncremento);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(lstOficios);
            Controls.Add(label1);
            Name = "Form10UpdateEmpleadosOficios";
            Text = "Form10UpdateEmpleadosOficios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstOficios;
        private Label label2;
        private ListBox lstEmpleados;
        private Label label3;
        private TextBox txtIncremento;
        private Button btnSubirSalarios;
        private Label lblMediaSalarial;
        private Label lblMaximoSalario;
        private Label lblSumaSalarial;
    }
}