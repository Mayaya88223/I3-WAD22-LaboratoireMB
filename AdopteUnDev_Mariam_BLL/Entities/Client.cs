using AdopteUnDev_Mariam_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Entities = AdopteUnDev_Mariam_DAL.Entities;

namespace AdopteUnDev_Mariam_BLL.Entities
{
    public class Client : IClient
    {
        public int idClient { get; set; }
        public string CliName { get; set; }
        public string CliFirstName { get; set; }
        public string CliMail { get; set; }
        public string CliCompany { get; set; }
        public string? CliLogin { get; set; }
        public string? CliPassword { get; set; }

        

        public Client(int id, string name, string firstname, string email, string company, string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login)) throw new ArgumentNullException();
            if(string.IsNullOrWhiteSpace(password)) throw new ArgumentNullException();
            idClient = id;
            CliName = name;
            CliFirstName = firstname;
            CliMail = email;
            CliCompany = company;
            CliLogin = login;
            CliPassword = password;
        }
       

       public Client(DAL_Entities.Client dto): this (dto.idClient, dto.CliName, dto.CliFirstName, dto.CliMail, dto.CliCompany, dto.CliLogin, dto.CliPassword)
        {

        }
    }
}
