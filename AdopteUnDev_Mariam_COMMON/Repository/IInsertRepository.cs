using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev_Mariam_COMMON.Repository
{
    public interface IInsertRepository <TEntity, TId>
    {
        TId Insert(TEntity entity);
    }
}
