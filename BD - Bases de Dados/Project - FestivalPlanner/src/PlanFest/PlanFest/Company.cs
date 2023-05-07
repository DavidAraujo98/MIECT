using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class Company
    {
        public string email { get; set; }
        public string address { get; set; }
        public string name { get; set; }
        public string telephone { get; set; }
        public string NIF { get; set; }

        public Company(string email="", string address="", string name="", string telephone="", string NIF="") : base()
        {
            this.email = email;
            this.address = address;
            this.name = name;
            this.telephone = telephone;
            this.NIF = NIF;
        }
    }
}
