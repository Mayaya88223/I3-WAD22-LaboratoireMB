using AdopteUnDev_Mariam_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev_Mariam_BLL.Entities
{
    class Review: IReview
    {
        public int idReview { get; set; }
        public string ReviewName { get; set; }
        public string ReviewText { get; set; }
        public string ReviewMail { get; set; }
        public DateTime ReviewDate { get; set; }
        public int idDev { get; set; }

    }
}
