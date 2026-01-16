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
    public partial class Form10UpdateEmpleadosOficios : Form
    {
        RepositoryUpdateEmpleados repo;
        public Form10UpdateEmpleadosOficios()
        {
            InitializeComponent();
            this.repo = new RepositoryUpdateEmpleados();
            this.LoadOficios();
        }

        private async void LoadOficios()
        {
            List<string> oficios = await this.repo.GetOficiosAsync();
            this.lstOficios.Items.Clear();
            foreach (string oficio in oficios)
            {
                this.lstOficios.Items.Add(oficio);
            }
        }

        private async void btnSubirSalarios_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            string oficio = this.lstOficios.SelectedItem.ToString();
            int registros = await this.repo.UpdateSalarioEmpleadoAsync(oficio, incremento);
            MessageBox.Show("Registros afectado: " + registros);
        }

        private async void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstOficios.SelectedIndex;
            if(index != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();
                List<string> apellidos = await this.repo.GetEmpleadosByOficioAsync(oficio);
                this.lstEmpleados.Items.Clear();
                foreach(string apellido in apellidos)
                {
                    this.lstEmpleados.Items.Add(apellido);
                }
                int max = await this.repo.GetMaxSalarioAsync(oficio);
                this.lblMaximoSalario.Text = max.ToString();

                int media = await this.repo.GetMediaSalarialOficioAsync(oficio);
                this.lblMediaSalarial.Text = media.ToString();

                int suma = await this.repo.GetSumaSalarioOficioAsync(oficio);
                this.lblSumaSalarial.Text = suma.ToString();
            }
        }
    }
}
