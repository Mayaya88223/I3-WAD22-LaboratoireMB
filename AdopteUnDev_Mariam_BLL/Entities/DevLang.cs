using AdopteUnDev_Mariam_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev_Mariam_BLL.Entities
{
    class DevLang : IDevLang
    {
        public int idDev { get; set; }
        public int idIT { get; set; }
        public DateTime Since { get; set; }

    }
}
