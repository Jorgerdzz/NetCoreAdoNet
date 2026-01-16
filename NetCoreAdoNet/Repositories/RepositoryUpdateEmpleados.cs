using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryUpdateEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;


        public RepositoryUpdateEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetOficiosAsync()
        {
            string sql = "select distinct OFICIO from EMP";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> oficios = new List<string>();
            while( await this.reader.ReadAsync())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficios.Add(oficio);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return oficios;
        }

        public async Task<List<string>> GetEmpleadosByOficioAsync(string oficio)
        {
            string sql = "select APELLIDO from EMP where OFICIO=@oficio";
            SqlParameter pamOfi = new SqlParameter("@oficio", oficio);
            this.com.Parameters.Add(pamOfi);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> empleados = new List<string>();
            while(await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                empleados.Add(apellido);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }

        public async Task<int> UpdateSalarioEmpleadoAsync(string oficio, int incremento)
        {
            string sql = "update EMP set SALARIO=SALARIO + @incremento " +
                "where OFICIO=@oficio";
            SqlParameter pamIn = new SqlParameter("@incremento", incremento);
            SqlParameter pamOfi = new SqlParameter("@oficio", oficio);
            this.com.Parameters.Add(pamIn);
            this.com.Parameters.Add(pamOfi);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }

        public async Task<int> GetSumaSalarioOficioAsync(string oficio)
        {
            string sql = "select SUM(SALARIO) from EMP where OFICIO=@oficio";
            SqlParameter pamOfi = new SqlParameter("@oficio", oficio);
            this.com.Parameters.Add(pamOfi);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }

        public async Task<int> GetMediaSalarialOficioAsync(string oficio)
        {
            string sql = "select SUM(SALARIO) from EMP where OFICIO=@oficio";
            SqlParameter pamOfi = new SqlParameter("@oficio", oficio);
            this.com.Parameters.Add(pamOfi);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }

        public async Task<int> GetMaxSalarioAsync(string oficio)
        {
            string sql = "select MAX(SALARIO) from EMP where OFICIO=@oficio";
            SqlParameter pamOfi = new SqlParameter("@oficio", oficio);
            this.com.Parameters.Add(pamOfi);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }

    }
}
