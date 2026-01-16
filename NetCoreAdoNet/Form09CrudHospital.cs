using NetCoreAdoNet.Models;
using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form09CrudHospital : Form
    {
        RepositoryHospitales repo;
        public Form09CrudHospital()
        {
            InitializeComponent();
            this.repo = new RepositoryHospitales();
            this.LoadHospitales();
        }

        private async Task LoadHospitales()
        {
            List<Hospital> hospitales = await this.repo.GetHospitalesAsync();
            this.lstHospitales.Items.Clear();
            foreach (Hospital hospital in hospitales)
            {
                this.lstHospitales.Items.Add(hospital.HospitalCod + " - " +
                    hospital.Nombre + " - " + hospital.Direccion + " - " +
                    hospital.Telefono + " - " + hospital.NumCama);
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(this.txtHospitalCod.Text);
            string nombre = this.txtNombre.Text;
            string direccion= this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int numCamas = int.Parse(this.txtNumCamas.Text);
            await this.repo.CreateHospitalAsync(codigo, nombre, direccion, telefono, numCamas);
            await LoadHospitales();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(this.txtHospitalCod.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int numCamas = int.Parse(this.txtNumCamas.Text);
            await this.repo.UpdateHospitalAsync(codigo, nombre, direccion, telefono, numCamas);
            await LoadHospitales();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(this.txtHospitalCod.Text);
            await this.repo.DeleteHospitalAsync(codigo);
            await this.LoadHospitales();
        }
    }
}
