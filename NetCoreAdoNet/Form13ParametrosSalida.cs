using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form13ParametrosSalida : Form
    {
        RepositoryParametersOut repo;
        public Form13ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new RepositoryParametersOut();
            this.LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            List<string> departamentos = await this.repo.GetDepartamentosAsync();
            this.cmbDepartamentos.Items.Clear();
            foreach (string nombre in departamentos)
            {
                this.cmbDepartamentos.Items.Add(nombre);
            }
        }

        private async void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string nombreDepartamento = this.cmbDepartamentos.SelectedItem.ToString();
            EmpleadosParametersOut model = await this.repo.GetEmpleadosModelAsync(nombreDepartamento);
            this.lstEmpleados.Items.Clear();
            foreach(string apellido in model.Apellidos)
            {
                this.lstEmpleados.Items.Add(apellido);
            }
            this.textBox1.Text = model.SumaSalarial.ToString();
            this.textBox2.Text = model.MediaSalarial.ToString();
            this.textBox3.Text = model.Personas.ToString();
        }
    }
}
