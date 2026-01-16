using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryHospitales
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryHospitales()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<Hospital>> GetHospitalesAsync()
        {
            string sql = "select * from HOSPITAL";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Hospital> hospitales = new List<Hospital>();
            while(await this.reader.ReadAsync())
            {
                Hospital hospital = new Hospital();
                hospital.HospitalCod = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hospital.Nombre = this.reader["NOMBRE"].ToString();
                hospital.Direccion = this.reader["DIRECCION"].ToString();
                hospital.Telefono = this.reader["TELEFONO"].ToString();
                hospital.NumCama = int.Parse(this.reader["NUM_CAMA"].ToString());
                hospitales.Add(hospital);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return hospitales;
        }

        public async Task CreateHospitalAsync(int hospitalCod, string nombre, string direccion, string telefono, int numCama)
        {
            string sql = "insert into HOSPITAL values(@hospitalcod, @nombre, @direccion, @telefono, @numcama)";
            SqlParameter pamHosCod = new SqlParameter("@hospitalcod", hospitalCod);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamDireccion= new SqlParameter("@direccion", direccion);
            SqlParameter pamTelefono = new SqlParameter("@telefono", telefono);
            SqlParameter pamNumCama = new SqlParameter("@numcama", numCama);
            this.com.Parameters.Add(pamHosCod);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamDireccion);
            this.com.Parameters.Add(pamTelefono);
            this.com.Parameters.Add(pamNumCama);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task UpdateHospitalAsync(int hospitalCod, string nombre, string direccion, string telefono, int numCama)
        {
            string sql = "update HOSPITAL set NOMBRE=@nombre," +
                "DIRECCION=@direccion, TELEFONO=@telefono, NUM_CAMA=@numcama " +
                "where HOSPITAL_COD=@hospitalcod";
            SqlParameter pamHosCod = new SqlParameter("@hospitalcod", hospitalCod);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamDireccion = new SqlParameter("@direccion", direccion);
            SqlParameter pamTelefono = new SqlParameter("@telefono", telefono);
            SqlParameter pamNumCama = new SqlParameter("@numcama", numCama);
            this.com.Parameters.Add(pamHosCod);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamDireccion);
            this.com.Parameters.Add(pamTelefono);
            this.com.Parameters.Add(pamNumCama);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task DeleteHospitalAsync(int hospitalCod)
        {
            string sql = "delete from HOSPITAL where HOSPITAL_COD=@hospitalcod";
            SqlParameter pamCod = new SqlParameter("@hospitalcod", hospitalCod);
            this.com.Parameters.Add(pamCod);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

    }
}
