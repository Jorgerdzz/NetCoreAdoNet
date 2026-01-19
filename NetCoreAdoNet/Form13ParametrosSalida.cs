using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region
//create procedure SP_EMPLEADOS_DEPARTAMENTOS_OUT
//(@nombre nvarchar(50),
//    @suma int OUT,
//    @media int OUT,
//    @personas int OUT)
//as
//	declare @iddept int
//	select @iddept = DEPT_NO from DEPT where DNOMBRE = @nombre
//	--LA CONSULTA DLE PROCEDIMIENTO
//	select * from EMP where DEPT_NO = @iddept
//	--Rellenamos las variables de salida
//	select @suma = SUM(SALARIO), @media = AVG(SALARIO), @personas = COUNT(EMP_NO) from EMP
//	where DEPT_NO = @iddept
//go
#endregion

namespace NetCoreAdoNet
{
    public partial class Form13ParametrosSalida : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form13ParametrosSalida()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.cmbDepartamentos.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                this.cmbDepartamentos.Items.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string sql = "SP_EMPLEADOS_DEPARTAMENTOS_OUT";
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            this.com.Parameters.AddWithValue("@nombre", nombre);
            //LOS PARAMETROS DE SALIDA DEBEMOS CREARLOS DE FORMA EXPLÍCITA
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.ParameterName = "@suma";
            pamSuma.Value = 0;
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);
            SqlParameter pamMedia = new SqlParameter();
            pamMedia.ParameterName = "@media";
            pamMedia.Value = 0;
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);
            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.ParameterName = "@personas";
            pamPersonas.Value = 0;
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstEmpleados.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEmpleados.Items.Add(apellido);
            }
            await this.reader.CloseAsync();
            this.textBox1.Text = pamSuma.Value.ToString();
            this.textBox2.Text = pamMedia.Value.ToString();
            this.textBox3.Text = pamPersonas.Value.ToString();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
