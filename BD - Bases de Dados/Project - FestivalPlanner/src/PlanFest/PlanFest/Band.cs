using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class Band
    {
        public string id { get; set; }
        public string name { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public int nElem { get; set; }
        public Group group { get; set; }

        public Band(string id="", string name="", string telephone="", string email="", int nElem = 0, Group group=null)
        {
            this.id = id;
            this.name = name;
            this.telephone = telephone;
            this.email = email;
            this.nElem = nElem;
            this.group = group;
        }

        public override String ToString()
        {
            return name;
        }
    }
}
