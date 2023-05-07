using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class Promoter : Person
    {
        public string type { get; set; }
        public Festival festival { get; set; }

        public Promoter (string nCC = "", string telephone = "", string name = "", string sex = "", string email = "", Festival festival=null, string type="") : base(nCC, telephone, name, sex, email)
        {
            this.type = type;
            this.festival = festival;
        }
    }
}
