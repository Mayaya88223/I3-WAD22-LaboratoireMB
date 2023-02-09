using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = AdopteUnDev_Mariam_DAL.Entities;
using BLL = AdopteUnDev_Mariam_BLL.Entities;

namespace AdopteUnDev_Mariam_BLL.Mapper
{
    static class Mapper
    {
        public static BLL.Client toBLL(this DAL.Client entity)
        {
            if (entity is null) return null;
            return new BLL.Client(entity);
            //    entity.idClient,
            //    entity.CliName,
            //    entity.CliFirstName,
            //    entity.CliMail,
            //    entity.CliCompany,
            //    entity.CliLogin,
            //    entity.CliPassword
            //);
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

        public static BLL.Developer toBLL(this DAL.Developer entity)
        {
            if (entity is null) return null;
            return new BLL.Developer(entity);
            //    entity.idDev,
            //    entity.DevName,
            //    entity.DevFirstName,
            //    entity.DevBirthDate,
            //    entity.DevPicture,
            //    entity.DevHourCost,
            //    entity.DevDayCost,
            //    entity.DevMonthCost,
            //    entity.DevMail,
            //    entity.DevCategPrincipal
            //);
        }
    
                
        public static DAL.Developer toDAL (this BLL.Developer entity)
        {
            if (entity is null) return null;
            return new DAL.Developer()
            {
                idDev = entity.idDev,
                DevName = entity.DevName,
                DevFirstName = entity.DevFirstName,
                DevBirthDate = entity.devBirthDate,
                DevPicture = entity.DevPicture,
                DevHourCost = entity.DevHourCost,
                DevDayCost = entity.DevDayCost,
                DevMonthCost = entity.DevMonthCost,
                DevMail = entity.DevMail,
                DevCategPrincipal = entity.DevCategPrincipal
            };

        }
           
        

                
    }
}        



