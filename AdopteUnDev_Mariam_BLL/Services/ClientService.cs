using AdopteUnDev_Mariam_COMMON.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = AdopteUnDev_Mariam_DAL.Entities;
using BLL = AdopteUnDev_Mariam_BLL.Entities;
using AdopteUnDev_Mariam_BLL.Entities;
using AdopteUnDev_Mariam_BLL.Mapper;

namespace AdopteUnDev_Mariam_BLL.Services
{
    public class ClientService : IClientRepository<BLL.Client, int>
    {
        private readonly IClientRepository<DAL.Client, int> _repository;

        public ClientService(IClientRepository<DAL.Client, int> repository)
        {
            _repository = repository;
        }


 

        public IEnumerable<BLL.Client> Get()
        {
            //return _repository.Get().Select(e => e.toBLL());
            return (IEnumerable<BLL.Client>)_repository.Get();
        }

        public Client Get(int id)
        {
            return _repository.Get(id).toBLL();
        }

               

        public int Insert(Client entity)
        {
            return _repository.Insert(entity.toDAL());
        }


        public bool Update(int id, Client entity)
        {
            return _repository.Update(id, entity.toDAL());
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }



        
    }
}


