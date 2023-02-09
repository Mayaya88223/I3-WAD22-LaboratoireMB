using AdopteUnDev_Mariam_COMMON.Repository;
using AdopteUnDev_Mariam_DAL.Entities;
using AdopteUnDev_Mariam_DAL.Mapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev_Mariam_DAL.Services
{
    public class ClientService : BaseService, IClientRepository<Client, int>
    {

        public ClientService(IConfiguration config) : base(config, "DB_AdopteUnDev")
        {

        }

       

        public IEnumerable<Client> Get()
        {
            using (SqlConnection connection = new SqlConnection (_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idClient], [CliName], [CliFirstName] ,[CliMail], [CliCompany], [CliLogin], [CliPassword] FROM [Client]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToClient();
                        }
                    }
                }
            }
        }

        public Client Get(int id)
        {
            using (SqlConnection connection = new SqlConnection (_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT [idClient], [CliName], [CliFirstName] ,[CliMail], [CliCompany], [CliLogin], [CliPassword] FROM [Client] WHERE [idClient] = @id";
                        command.Parameters.AddWithValue("id", id);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) return reader.ToClient();
                            return null;
                        }
                    }
                }

            }

        public int Insert(Client entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Client_Insert";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("name", entity.CliName);
                    command.Parameters.AddWithValue("firstname", entity.CliFirstName);
                    command.Parameters.AddWithValue("mail", entity.CliMail);
                    command.Parameters.AddWithValue("company", entity.CliCompany);
                    command.Parameters.AddWithValue("login", (object)entity.CliLogin ?? DBNull.Value);
                    command.Parameters.AddWithValue("password", (object)entity.CliPassword ?? DBNull.Value);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }



        public bool Update(int id, Client entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Client]
                                            SET [CliName] = @name,
                                                [CliFirstName] = @firstname,
                                                [CliMail] = @mail, 
                                                [CliCompany] = @company, 
                                                [CliLogin] = @login,
                                                [CliPassword] = password
                                                WHERE [idClient] = @id";
                    command.Parameters.AddWithValue("name", entity.CliName);
                    command.Parameters.AddWithValue("firstname", entity.CliFirstName);
                    command.Parameters.AddWithValue("mail", entity.CliMail);
                    command.Parameters.AddWithValue("company", entity.CliCompany);
                    command.Parameters.AddWithValue("login", (object)entity.CliLogin ?? DBNull.Value);
                    command.Parameters.AddWithValue("password", (object)entity.CliPassword ?? DBNull.Value);
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }




        public bool Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [Client] WHERE [idClient] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }

        }

        public int? CheckPassword(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection (_connectionString))
            {
                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Client_CheckPassword";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("login", login);
                    command.Parameters.AddWithValue("password", password);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return (result is DBNull) ? null : (int?)result;
                       
                }
            }
        }



    }
}

