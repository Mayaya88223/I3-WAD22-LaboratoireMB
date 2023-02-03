using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev_Mariam_DAL.Services
{
    public abstract class BaseService
    {
        protected readonly string _connectionString;
        public BaseService(IConfiguration config, string dbName)
        {
            _connectionString = config.GetConnectionString(dbName);
        }
    }
}
