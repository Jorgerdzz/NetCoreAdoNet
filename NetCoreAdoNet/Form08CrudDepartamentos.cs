using NetCoreAdoNet.Models;
using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form08CrudDepartamentos : Form
    {
        RepositoryDepartamentos repo;
        public Form08CrudDepartamentos()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            this.loadDepartamentos();
        }

        private async Task loadDepartamentos()
        {
            List<Departamento> departamentos = await this.repo.GetDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach(Departamento dep in departamentos)
            {
                this.lstDepartamentos.Items.Add(dep.IdDepartamento + " - "
                    + dep.Nombre + " - " + dep.Localidad);
            }
        }

    }
}
