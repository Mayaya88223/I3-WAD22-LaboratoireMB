using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev_Mariam_BLL.Entities
{
    class Developer
    {
        public int idDev { get; set; }
        public string DevName { get; set; }
        public string DevFirstName { get; set; }
        private DateTime _devBirthDate;
        public string? DevPicture { get; set; }
        public float DevHourCost { get; set; }
        public float DevDayCost { get; set; }
        public float DevMonthCost { get; set; }
        public string DevMail { get; set; }
        public string? DevCategPrincipal { get; set; }

        public DateTime devBirthDate
        {
            get
            {
                return _devBirthDate;
            }
            set
            {
                _devBirthDate = value;
            }
        }

        public int CalculateAge (DateTime DevBirthDate)

        {
            int age = 0;
            age = DateTime.Now.Year - DevBirthDate.Year;
            if (
                DateTime.Now.DayOfYear < DevBirthDate.DayOfYear)
                age = age - 1;
            return age;

        }
    }
}
