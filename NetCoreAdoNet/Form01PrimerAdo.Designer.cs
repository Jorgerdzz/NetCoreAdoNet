namespace NetCoreAdoNet
{
    partial class Form01PrimerAdo
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
            btnConectar = new Button();
            btnDesconectar = new Button();
            btnRead = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstApellidos = new ListBox();
            lstColumnas = new ListBox();
            lstTipo = new ListBox();
            lblConexion = new Label();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(38, 61);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(92, 32);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(38, 99);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(92, 39);
            btnDesconectar.TabIndex = 1;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(38, 144);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(92, 32);
            btnRead.TabIndex = 2;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 30);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 30);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Columnas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 27);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Tipos dato";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(189, 61);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(120, 154);
            lstApellidos.TabIndex = 6;
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(341, 61);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(120, 154);
            lstColumnas.TabIndex = 7;
            // 
            // lstTipo
            // 
            lstTipo.FormattingEnabled = true;
            lstTipo.Location = new Point(494, 61);
            lstTipo.Name = "lstTipo";
            lstTipo.Size = new Size(120, 154);
            lstTipo.TabIndex = 8;
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Location = new Point(38, 221);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(71, 15);
            lblConexion.TabIndex = 9;
            lblConexion.Text = "lblConexion";
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblConexion);
            Controls.Add(lstTipo);
            Controls.Add(lstColumnas);
            Controls.Add(lstApellidos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRead);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Name = "Form01PrimerAdo";
            Text = "Form01PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Button btnDesconectar;
        private Button btnRead;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstApellidos;
        private ListBox lstColumnas;
        private ListBox lstTipo;
        private Label lblConexion;
    }
}