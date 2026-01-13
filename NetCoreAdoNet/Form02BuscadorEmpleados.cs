using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace NetCoreAdoNet
{
    public partial class Form02BuscadorEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            string connectionString = "Data Source=LOCALHOST\\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            //Recuperamos el salario de la caja de texto
            string salario = this.txtSalario.Text;
            //Consulta SQL
            string sql = "select * from EMP where SALARIO >=" + salario;
            //Conexion
            this.com.Connection = this.cn;
            //Tipo consulta
            this.com.CommandType = CommandType.Text;
            //Consulta
            this.com.CommandText = sql;

            //Abrimos la conexion
            this.cn.Open();
            //Ejecutamos la consulta
            this.reader = this.com.ExecuteReader();
            //Dibujamos los datos
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string sal = this.reader["SALARIO"].ToString();
                this.lstEmpleados.Items.Add(apellido + " - " + sal);
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
