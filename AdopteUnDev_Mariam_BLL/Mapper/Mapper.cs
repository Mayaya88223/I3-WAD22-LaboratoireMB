using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL = AdopteUnDev_Mariam_BLL.Entities;
using DAL = AdopteUnDev_Mariam_DAL.Entities;


namespace AdopteUnDev_Mariam_BLL.Mapper
{
    static class Mapper
    {
        public static BLL.Client toBLL(this DAL.Client entity)
        {
            if (entity is null) return null;
            return new BLL.Client()

            {
                idClient = entity.idClient,
                CliName = entity.CliName,
                CliFirstName = entity.CliFirstName,
                CliMail = entity.CliMail,
                CliCompany = entity.CliCompany,
                CliLogin = entity.CliLogin,
                CliPassword = entity.CliPassword
            };
        }

        public static DAL.Client toDAL(this BLL.Client entity)
        {
            if (entity is null) return null;
            return new DAL.Client()

            {
                idClient = entity.idClient,
                CliName = entity.CliName,
                CliFirstName = entity.CliFirstName,
                CliMail = entity.CliMail,
                CliCompany = entity.CliCompany,
                CliLogin = entity.CliLogin,
                CliPassword = entity.CliPassword
            };

        }

    }
}
