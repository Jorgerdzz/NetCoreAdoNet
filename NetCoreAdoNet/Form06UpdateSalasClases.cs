using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NetCoreAdoNet.Repositories;

namespace NetCoreAdoNet
{
    public partial class Form06UpdateSalasClases : Form
    {
        RepositorySalas repo;
        public Form06UpdateSalasClases()
        {
            InitializeComponent();
            this.repo = new RepositorySalas();
            this.loadSalas();
        }

        private void loadSalas()
        {
            List<string> salas = this.repo.GetNombresSalas();
            this.lstSalas.Items.Clear();
            foreach(string name in salas)
            {
                this.lstSalas.Items.Add(name);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newName = this.txtNombre.Text;
            string oldName = this.lstSalas.SelectedItem.ToString();
            int registros = this.repo.updateSala(newName, oldName);
            MessageBox.Show("Salas modificadas: " + registros);
            this.loadSalas();
        }
    }
}
