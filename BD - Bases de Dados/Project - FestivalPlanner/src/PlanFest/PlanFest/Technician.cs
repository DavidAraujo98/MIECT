using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class Technician : Person
    {
        public string type { get; set; }

        public Group group { get; set; }

        public Technician (string nCC= "", string telephone = "", string name = "", string sex = "", string email = "", string type="", Group group=null) : base(nCC, telephone, name, sex, email)
        {
            this.group = group;
            this.type = type;
        }
    }
}
