using AdopteUnDev_Mariam_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev_Mariam_BLL.Entities
{
    class Categories: ICategories
    {
        public int idCategory { get; set; }
        public string CategLabel { get; set; }
    }
}
