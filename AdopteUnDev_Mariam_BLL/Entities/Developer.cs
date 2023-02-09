using AdopteUnDev_Mariam_COMMON.Entities;
using DAL_Entities = AdopteUnDev_Mariam_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev_Mariam_BLL.Entities
{
    public class Developer: IDeveloper
    {
        public int idDev { get; set; }
        public string DevName { get; set; }
        public string DevFirstName { get; set; }
        public string? DevPicture { get; set; }
        public float DevHourCost { get; set; }
        public float DevDayCost { get; set; }
        public float DevMonthCost { get; set; }
        public string DevMail { get; set; }
        public string? DevCategPrincipal { get; set; }

        

        private DateTime _devBirthDate;

        public DateTime devBirthDate
        {
            get { return _devBirthDate; }
            set { _devBirthDate = value;}
        }

        public int Age
        {
            get {
                int age = DateTime.Now.Year - this.devBirthDate.Year;
                if (
                    DateTime.Now.DayOfYear < this.devBirthDate.DayOfYear)
                    age = age - 1;
                return age;
            }
        }


        public Developer(int idDev, string devName, string devFirstName, DateTime devBirthDate, string devPicture, float devHourCost, float devDayCost, float devMonthCost, string devMail, string devCategPrincipal)
        {

            if (string.IsNullOrWhiteSpace(devPicture)) throw new ArgumentNullException();
            if (string.IsNullOrWhiteSpace(devCategPrincipal)) throw new ArgumentNullException();


            this.idDev = idDev;
            DevName = devName;
            this.devBirthDate = devBirthDate;
            DevPicture = devPicture;
            DevHourCost = devHourCost;
            DevDayCost = devDayCost;
            DevMonthCost = devMonthCost;
            DevMail = devMail;
            DevCategPrincipal = devCategPrincipal;
        }

        public Developer(DAL_Entities.Developer dto) : this(dto.idDev, dto.DevName, dto.DevFirstName, dto.DevBirthDate, dto.DevPicture, dto.DevHourCost, dto.DevDayCost, dto.DevMonthCost, dto.DevMail, dto.DevCategPrincipal)
        {

        }

    }
}

