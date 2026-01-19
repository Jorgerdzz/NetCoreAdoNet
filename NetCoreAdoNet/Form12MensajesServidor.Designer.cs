namespace NetCoreAdoNet
{
    partial class Form12MensajesServidor
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
            txtId = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtLocalidad = new TextBox();
            btnNuevoDepartamento = new Button();
            label4 = new Label();
            lstDepartamentos = new ListBox();
            lblServidor = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 36);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(55, 69);
            txtId.Name = "txtId";
            txtId.Size = new Size(126, 23);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 113);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(55, 141);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(126, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 193);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(55, 225);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(126, 23);
            txtLocalidad.TabIndex = 5;
            // 
            // btnNuevoDepartamento
            // 
            btnNuevoDepartamento.Location = new Point(55, 269);
            btnNuevoDepartamento.Name = "btnNuevoDepartamento";
            btnNuevoDepartamento.Size = new Size(126, 43);
            btnNuevoDepartamento.TabIndex = 6;
            btnNuevoDepartamento.Text = "Nuevo departamento";
            btnNuevoDepartamento.UseVisualStyleBackColor = true;
            btnNuevoDepartamento.Click += btnNuevoDepartamento_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(252, 36);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 7;
            label4.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(256, 69);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(414, 259);
            lstDepartamentos.TabIndex = 8;
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblServidor.ForeColor = SystemColors.HotTrack;
            lblServidor.Location = new Point(67, 347);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(95, 21);
            lblServidor.TabIndex = 9;
            lblServidor.Text = "lblServidor";
            // 
            // Form12MensajesServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblServidor);
            Controls.Add(lstDepartamentos);
            Controls.Add(label4);
            Controls.Add(btnNuevoDepartamento);
            Controls.Add(txtLocalidad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form12MensajesServidor";
            Text = "Form12MensajesServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtLocalidad;
        private Button btnNuevoDepartamento;
        private Label label4;
        private ListBox lstDepartamentos;
        private Label lblServidor;
    }
}