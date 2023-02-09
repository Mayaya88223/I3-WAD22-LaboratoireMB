using AdopteUnDev_Mariam_COMMON.Repository;
using DAL = AdopteUnDev_Mariam_DAL.Entities;
using BLL = AdopteUnDev_Mariam_BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdopteUnDev_Mariam_BLL.Mapper;
using AdopteUnDev_Mariam_BLL.Entities;

namespace AdopteUnDev_Mariam_BLL.Services
{
    public class DeveloperService : IDeveloperRepository<BLL.Developer, int>
    {
        private readonly IDeveloperRepository<DAL.Developer, int> _repository;
        public DeveloperService(IDeveloperRepository<DAL.Developer, int> repository)
        {
            _repository = repository;
        }






        public IEnumerable<BLL.Developer> Get()
        {
            return (IEnumerable<BLL.Developer>)_repository.Get();
        }

        public Developer Get(int id)
        {
            return _repository.Get(id).toBLL();
        }

        public int Insert(Developer entity)
        {
            return _repository.Insert(entity.toDAL());
        }


        public bool Update(int id, Developer entity)
        {
            return _repository.Update(id, entity.toDAL());
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

      

        


        
    }
}
