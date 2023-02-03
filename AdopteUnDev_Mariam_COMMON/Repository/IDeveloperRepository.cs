using AdopteUnDev_Mariam_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev_Mariam_COMMON.Repository
{
    public interface IDeveloperRepository <TEntity, TId> : IRepository<TEntity, TId>
    {
    }
}
