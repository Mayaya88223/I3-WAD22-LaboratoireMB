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
    public class ClientService : IClientRepository<Client, int>
    {
        public string ConnectionString { get; set; }



        public IEnumerable<Client> Get()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [CliName], [CliFirstName], [CliMail], [CliCompany],[CliLogin], [CliPassword] FROM [Client]";
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
            return null;
        }

        public int Insert(Client entity)
        {
            return 0;
        }

        public bool Update(int id, Client entity)
        {
            return false;
        }
        public bool Delete(int id)
        {
            return false;
        }
    }
}

