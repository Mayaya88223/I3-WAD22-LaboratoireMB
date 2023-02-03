using AdopteUnDev_Mariam_BLL.Mapper;
using AdopteUnDev_Mariam_COMMON;
using AdopteUnDev_Mariam_COMMON.Repository;
using AdopteUnDev_Mariam_DAL.Entities;
using AdopteUnDev_Mariam_DAL.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = AdopteUnDev_Mariam_DAL.Entities;
using BLL = AdopteUnDev_Mariam_BLL.Entities;

namespace AdopteUnDev_Mariam_BLL.Services
{
    public class ClientService : IClientRepository<BLL.Client, int>
    {
        private readonly IClientRepository<DAL.Client, int> _repository;

        public ClientService(IClientRepository<DAL.Client, int> repository)
        {
            _repository = repository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BLL.Client> Get()
        {
            return _repository.Get().Select(e => e.toBLL());
        }

        public BLL.Client Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(BLL.Client entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, BLL.Client entity)
        {
            throw new NotImplementedException();
        }
    }


}



