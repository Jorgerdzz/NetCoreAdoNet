using Microsoft.Extensions.Configuration;
using NetCoreAdoNet.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form14Settings : Form
    {
        public Form14Settings()
        {
            InitializeComponent();
        }

        private void btnLeerSettings_Click(object sender, EventArgs e)
        {
            //NECESITAMOS UN CONSTRUCTOR DE CONFIGURACIONES
            ConfigurationBuilder builder =
                new ConfigurationBuilder();
            //EN ESTE ENTORNO DE PROYECTO, SETTINGS NO ES NATIVO, ES DECIR
            // A PESAR DE LLAMARLO appsettings.json, NO LO RECONOCE
            //DEBEMOS INDICAR LA DIRECCION DEL FICHERO Y EL NOMBRE
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);
            //NECESITAMOS EL OBJETO PARA RECUPERAR LAS KEYS
            IConfigurationRoot configuration = builder.Build();
            //EXISTEN KEYS YA CONFIGURADAS Y PODEMOS RECUPERARLAS CON METODOS NATIVOS
            //LAS KEYS DIFERENCIAN MAYUSCULAS DE MINUSCULAS
            string connectionString = configuration.GetConnectionString("SqlLocalTajamar");
            this.lblConexion.Text = connectionString;
            //SI NO SON KEYS CONOCIDAS, DEBEMOS NAVEGAR HASTA ELLAS
            //LA NAVEGACION ENTRE JEYS SE ESTABLECE MEDIANTE:
            //KeyPrincipal: SubKey
            //KeyPrincipal: SubKey:OtraSubKey
            string imagen1 = configuration.GetSection("Imagenes:imagen1").Value;
            string imagen2 = configuration.GetSection("Imagenes:imagen2").Value;
            string colorLetra = configuration.GetSection("Colores:letra").Value;
            string colorFondo = configuration.GetSection("Colores:fondo").Value;
            this.pictureBox1.Load(imagen1);
            this.pictureBox2.Load(imagen2);
            this.btnLeerSettings.ForeColor = Color.FromName(colorLetra);
            this.BackColor = Color.FromName(colorFondo);
        }

        private void btnLeerHelper_Click(object sender, EventArgs e)
        {
            IConfigurationRoot configuration = HelperConfiguration.GetConfiguration();
            //EXISTEN KEYS YA CONFIGURADAS Y PODEMOS RECUPERARLAS CON METODOS NATIVOS
            //LAS KEYS DIFERENCIAN MAYUSCULAS DE MINUSCULAS
            string connectionString = configuration.GetConnectionString("SqlLocalTajamar");
            this.lblConexion.Text = connectionString;
            //SI NO SON KEYS CONOCIDAS, DEBEMOS NAVEGAR HASTA ELLAS
            //LA NAVEGACION ENTRE JEYS SE ESTABLECE MEDIANTE:
            //KeyPrincipal: SubKey
            //KeyPrincipal: SubKey:OtraSubKey
            string imagen1 = configuration.GetSection("Imagenes:imagen1").Value;
            string imagen2 = configuration.GetSection("Imagenes:imagen2").Value;
            string colorLetra = configuration.GetSection("Colores:letra").Value;
            string colorFondo = configuration.GetSection("Colores:fondo").Value;
            this.pictureBox1.Load(imagen1);
            this.pictureBox2.Load(imagen2);
            this.btnLeerSettings.ForeColor = Color.FromName(colorLetra);
            this.BackColor = Color.FromName(colorFondo);
        }
    }
}
