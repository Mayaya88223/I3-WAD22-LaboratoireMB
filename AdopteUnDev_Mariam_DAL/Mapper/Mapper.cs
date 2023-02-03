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
            {if (record is null) return null;
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
        }


        public static Developer ToDeveloper(this IDataRecord record)
        {
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
        }


    }
}
