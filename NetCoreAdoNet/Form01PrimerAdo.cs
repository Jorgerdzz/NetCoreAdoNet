using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form01PrimerAdo : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        string connectionString;
        public Form01PrimerAdo()
        {
            InitializeComponent();
            this.connectionString = "Data Source=LOCALHOST\\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.cn.StateChange += Cn_StateChange;
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblConexion.Text = "La conexión está pasando de "
            + e.OriginalState + " a " + e.CurrentState;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                    this.lblConexion.BackColor = Color.LightBlue;
                }
            }
            catch (SqlException ex)
            {
                this.lblConexion.Text = ex.ToString();
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblConexion.BackColor = Color.LightCoral;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string sql = "select * from EMP";
            //Indicamos la conexion del command
            this.com.Connection = this.cn;
            //Tipo de consulta a realizar
            this.com.CommandType = CommandType.Text;
            //Incluimos la consulta en el command
            this.com.CommandText = sql;
            //Aqui deberiamos abrir la conexion
            //Ejecutar la consulta
            //Como es un select, utilizamos ExecuteReader() que devuelve un DataReader
            this.reader = this.com.ExecuteReader();
            //Para la estructura de la tabla se utiliza for
            for(int i=0; i<this.reader.FieldCount; i++)
            {
                //Leemos la primera columna de la consulta
                string columna = this.reader.GetName(i);
                //Leemos el tipo de dato de la primera columna
                string tipo = this.reader.GetDataTypeName(i);
                this.lstColumnas.Items.Add(columna);
                this.lstTipo.Items.Add(tipo);
            }
            //Debemos indicar el metodo Read() para leer registros
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }
            //Siempre debemos salir: CERRAR
            this.reader.Close();
        }
    }
}
