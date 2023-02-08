using AdopteUnDev_Mariam_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev_Mariam_DAL.Entities
{
    public class ITLang: IITLang
    {
        public int idIT { get; set; }
        public string ITLabel { get; set; }

    }
}
