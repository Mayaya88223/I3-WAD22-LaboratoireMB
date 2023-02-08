using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev_Mariam_COMMON.Repository
{
    public interface IGetRepository <TEntity, TId>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TId id);
    }
}
