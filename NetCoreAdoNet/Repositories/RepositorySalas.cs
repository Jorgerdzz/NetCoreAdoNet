using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace NetCoreAdoNet.Repositories
{
    public class RepositorySalas
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositorySalas()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<string> GetNombresSalas()
        {
            string sql = "select distinct NOMBRE from SALA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<string> salas = new List<string>();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                salas.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
            return salas;
        }

        public int updateSala(string newName, string oldName)
        {
            string sql = "update SALA set NOMBRE=@newname where NOMBRE=@oldname";
            SqlParameter pamNew = new SqlParameter("@newname", newName);
            SqlParameter pamOld = new SqlParameter("@oldname", oldName);
            this.com.Parameters.Add(pamNew);
            this.com.Parameters.Add(pamOld);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int registros = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return registros;
        }

    }
}
