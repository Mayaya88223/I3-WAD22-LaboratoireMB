using AdopteUnDev_Mariam_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev_Mariam_DAL.Mapper
{
    static class Mapper
    {
        public static Client ToClient(this IDataRecord record)
        { 
            if (record is null) return null;
            return new Client()
            {
                idClient = (int)record[nameof(Client.idClient)],
                CliName = (string)record[nameof(Client.CliName)],
                CliFirstName = (string)record[nameof(Client.CliFirstName)],
                CliMail = (string)record[nameof(Client.CliMail)],
                CliCompany = (string)record[nameof(Client.CliCompany)],
                CliLogin = (record[nameof(Client.CliLogin)] is null) ? null :(string)record[nameof(Client.CliLogin)],
                CliPassword = (record[nameof(Client.CliPassword)] is null) ? null : (string)record[nameof(Client.CliPassword)]
            };
            
        }


        public static Developer ToDeveloper(this IDataRecord record)
        {
            if (record is null) return null;
            return new Developer()
            {
                idDev = (int)record[nameof(Developer.idDev)],
                DevName = (string)record[nameof(Developer.DevName)],
                DevFirstName = (string)record[nameof(Developer.DevFirstName)],
                DevBirthDate = (DateTime)record[nameof(Developer.DevBirthDate)],
                DevPicture = (record[nameof(Developer.DevPicture)] is null) ? null : (string)record[nameof(Developer.DevPicture)],
                DevHourCost= (float)record[nameof(Developer.DevHourCost)],
                DevDayCost = (float)record[nameof(Developer.DevDayCost)],
                DevMonthCost = (float)record[nameof(Developer.DevMonthCost)],
                DevMail = (string)record[nameof(Developer.DevMail)],
                DevCategPrincipal = (record[nameof(Developer.DevCategPrincipal)] is null) ? null : (string)record[nameof(Developer.DevCategPrincipal)],
            };
        }


        public static Categories ToCategories (this IDataRecord record)
        {
            if (record is null) return null;
            return new Categories()
            {
                idCategory = (int)record[nameof(Categories.idCategory)],
                CategLabel = (string)record[nameof(Categories.CategLabel)]
            };
        }


        public static ClientEndorseDev ToClientEndorseDev(this IDataRecord record)
        {
            if (record is null) return null;
            return new ClientEndorseDev()
            {
                idClient = (int)record[nameof(ClientEndorseDev.idClient)],
                idDev = (int)record[nameof(ClientEndorseDev.idDev)],
                BeginDate = (DateTime)record[nameof(ClientEndorseDev.BeginDate)],
                EndDate = (DateTime)record[nameof(ClientEndorseDev.EndDate)],
                EndorseNumber = (Guid)record[nameof(ClientEndorseDev.EndorseNumber)]
            };
        }


        public static DevLang ToDevLang (this IDataRecord record)
        {
            if (record is null) return null;
            return new DevLang()
            {
                idDev = (int)record[nameof(DevLang.idDev)],
                idIT = (int)record[nameof(DevLang.idIT)],
                Since = (DateTime)record[nameof(DevLang.Since)]
            };
        }

        public static ITLang ToITLang (this IDataRecord record)
        {
            if (record is null) return null;
            return new ITLang()
            {
                idIT = (int)record[nameof(ITLang.idIT)],
                ITLabel = (string)record[nameof(ITLang.ITLabel)]
            };
        }


        public static Review ToReview (this IDataRecord record)
        {
            if (record is null) return null;
            return new Review()
            {
                idReview = (int)record[nameof(Review.idReview)],
                ReviewName = (string)record[nameof(Review.ReviewName)],
                ReviewText = (string)record[nameof(Review.ReviewText)],
                ReviewMail = (string)record[nameof(Review.ReviewMail)],
                ReviewDate = (DateTime)record[nameof(Review.ReviewDate)],
                idDev = (int)record[nameof(Review.idDev)]
            };
        }

    }
}
