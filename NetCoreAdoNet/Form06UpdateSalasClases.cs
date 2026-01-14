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

        private async void loadSalas()
        {
            List<string> salas = await this.repo.GetNombresSalasAsync();
            this.lstSalas.Items.Clear();
            foreach(string name in salas)
            {
                this.lstSalas.Items.Add(name);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string newName = this.txtNombre.Text;
            string oldName = this.lstSalas.SelectedItem.ToString();
            int registros = await this.repo.updateSalaAsync(newName, oldName);
            MessageBox.Show("Salas modificadas: " + registros);
            this.loadSalas();
        }
    }
}
