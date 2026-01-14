namespace NetCoreAdoNet
{
    partial class Form04EliminarPlantilla
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
            txtEmpleadono = new TextBox();
            btnEliminar = new Button();
            label2 = new Label();
            lstPlantilla = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 43);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero empleado";
            // 
            // txtEmpleadono
            // 
            txtEmpleadono.Location = new Point(62, 75);
            txtEmpleadono.Name = "txtEmpleadono";
            txtEmpleadono.Size = new Size(143, 23);
            txtEmpleadono.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(62, 138);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(143, 30);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar empleado";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 38);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(300, 73);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(189, 289);
            lstPlantilla.TabIndex = 4;
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstPlantilla);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(txtEmpleadono);
            Controls.Add(label1);
            Name = "Form04EliminarPlantilla";
            Text = "Form04EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmpleadono;
        private Button btnEliminar;
        private Label label2;
        private ListBox lstPlantilla;
    }
}