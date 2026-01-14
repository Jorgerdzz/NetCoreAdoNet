using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetCoreAdoNet.Repositories;

namespace NetCoreAdoNet
{
    public partial class Form07DepartamentosEmpleados : Form
    {
        RepositoryDepartamentosEmpleados repo;
        public Form07DepartamentosEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentosEmpleados();
            this.loadDepartamentos();
        }

        private async void loadDepartamentos()
        {
            List<string> departamentos = await this.repo.GetNombresDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (string name in departamentos)
            {
                this.lstDepartamentos.Items.Add(name);
            }
        }

        private async void loadEmpleados()
        {
            string dnombre = this.lstDepartamentos.SelectedItem.ToString();
            this.lstEmpleados.Items.Clear();
            List<string> empleadosDepartamentos = await this.repo.GetApellidosEmpleadosPorDepartamentoAsync(dnombre);
            foreach (string name in empleadosDepartamentos)
            {
                this.lstEmpleados.Items.Add(name);
            }
        }


        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            string apellido = this.lstEmpleados.SelectedItem.ToString();
            int registro = await this.repo.GetApellidoEmpleadoAsync(apellido);
            MessageBox.Show("Empleados eliminados: " + registro);
            this.loadEmpleados();

        }

        private async void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dnombre = this.lstDepartamentos.SelectedItem.ToString();
            this.lstEmpleados.Items.Clear();
            List<string> empleadosDepartamentos = await this.repo.GetApellidosEmpleadosPorDepartamentoAsync(dnombre);
            foreach(string name in empleadosDepartamentos)
            {
                this.lstEmpleados.Items.Add(name);
            }
        }
    }
}
