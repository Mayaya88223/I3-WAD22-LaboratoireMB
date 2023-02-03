using AdopteUnDev_Mariam_COMMON.Repository;
using AdopteUnDev_Mariam_DAL.Entities;
using AdopteUnDev_Mariam_DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev_Mariam_DAL.Services
{
    class DeveloperService : IDeveloperRepository<Developer, int>
    {
        public string ConnectionString { get; set; }
        

        public IEnumerable<Developer> Get()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
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
            return null;
        }

        public int Insert(Developer entity)
        {
            return 0;
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

