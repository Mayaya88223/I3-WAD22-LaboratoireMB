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
    public class DeveloperService : BaseService, IDeveloperRepository<Developer, int>
    {
        public DeveloperService (IConfiguration config): base (config, "DB_AdopteUnDev")
        {

        }

        public IEnumerable<Developer> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idDev], [DevName], [DevFirstName], [DevBirthDate], [DevPicture], [DevHourCost], [DevDayCost], [DevMonthCost], [DevMail], [DevCategPrincipal] FROM [Developer]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            yield return reader.ToDeveloper();
                        }
                    }
                }
            }
        }

        public Developer Get(int id)
        {
            using(SqlConnection connection = new SqlConnection (_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idDev], [DevName], [DevFirstName], [DevBirthDate], [DevPicture], [DevHourCost], [DevDayCost], [DevMonthCost], [DevMail], [DevCategPrincipal] FROM [Developer] WHERE [idDev] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToDeveloper();
                        return null;
                    }
                }
            }
        }
        

        public int Insert(Developer entity)
        {
           using (SqlConnection connection = new SqlConnection (_connectionString))
            {
                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [Developer] ([DevName], 
                                                                    [DevFirstName], 
                                                                    [DevBirthDate], 
                                                                    [DevPicture], 
                                                                    [DevHourCost], 
                                                                    [DevDayCost], 
                                                                    [DevMonthCost], 
                                                                    [DevMail], 
                                                                    [DevCategPrincipal]
                                            OUTPUT [inserted].[idDev]
                                            VALUES (@name, @firstname, @birthdate, @picture, @hourcost, @daycost, @monthcost, @email, @categprincipal)";
                    command.Parameters.AddWithValue("name", entity.DevName);
                    command.Parameters.AddWithValue("firstname", entity.DevFirstName);
                    command.Parameters.AddWithValue("birthday", entity.DevBirthDate);
                    command.Parameters.AddWithValue("picture", entity.DevPicture);
                    command.Parameters.AddWithValue("hourcost", entity.DevHourCost);
                    command.Parameters.AddWithValue("daycost", entity.DevDayCost);
                    command.Parameters.AddWithValue("monthcost", entity.DevMonthCost);
                    command.Parameters.AddWithValue("email", entity.DevMail);
                    command.Parameters.AddWithValue("categprincipal", entity.DevCategPrincipal);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, Developer entity)
        {
            return false;
        }

        public bool Delete(int id)
        {
            return false;
        }

    }
}

