using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class Person
    {
        public string cc { get; set; }
        public string telephone { get; set; }
        public String name { get; set; }
        public String sex { get; set; }
        public String email { get; set; }

        public Person(string nCC="", string telephone="", string name="", string sex="", string email="") : base()
        {
            this.cc = nCC;
            this.telephone = telephone;
            this.name = name;
            this.sex = sex;
            this.email = email;
        }
    }
}
