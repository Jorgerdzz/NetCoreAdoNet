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
    public partial class Form04EliminarPlantilla : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form04EliminarPlantilla()
        {
            InitializeComponent();
            string connectionString = "Data Source=LOCALHOST\\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.loadPlantilla();
        }

        private void loadPlantilla()
        {
            string sql = "select * from PLANTILLA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstPlantilla.Items.Clear();
            while (this.reader.Read())
            {
                string empleadoNO = this.reader["EMPLEADO_NO"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstPlantilla.Items.Add(empleadoNO + " - " + apellido);
            }
            this.cn.Close();
            this.reader.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int empleadoNO = int.Parse(this.txtEmpleadono.Text);
            string sql = "delete from PLANTILLA where EMPLEADO_NO=@empleadoNO";
            //DEBEMOS CONFIGURAR LOS PARAMETROS
            SqlParameter pamIns = new SqlParameter("@empleadoNO", empleadoNO); //SOLO HACER ESTO PARA TIPOS PRIMITIVOS
            //EL NOMBRE DEL PARAMETRO NUNCA PUEDE ESTAR REPETIDO, NOS DARA ERROR
            //pamIns.ParameterName = "@empleadoNO";
            ////INDICAR TIPO DE DATO
            //pamIns.DbType = DbType.Int32;
            ////POR DEFECTO, LA DIRECCION ES INPUT
            //pamIns.Direction = ParameterDirection.Input;
            ////VALOR DEL PARAMETRO PARA SUSTITUIR EN LA CONSULTA
            //pamIns.Value = empleadoNO;
            ////AGREGAMOS EL PARAMETRO A LA COLECCION
            //this.com.Parameters.Add(pamIns);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int registros = this.com.ExecuteNonQuery();
            this.cn.Close();
            //DEBEMOS ELIMINAR LOS PARAMETROS
            this.com.Parameters.Clear();
            this.loadPlantilla();
            MessageBox.Show("Empleados eliminados: " + registros);

        }
    }
}
