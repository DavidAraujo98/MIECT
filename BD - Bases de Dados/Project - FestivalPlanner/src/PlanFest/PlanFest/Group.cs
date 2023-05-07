using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class Group
    {
        public string id { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public List<Escort> escorts { get; set; }
        public List<Technician> technicians { get; set; }
        public List<Musician> musicians { get; set; }

        public Group(string id="", string telephone="", string email="", List<Escort> escorts=null, List<Technician> technicians=null, List<Musician> musicians = null)
        {
            this.id = id;
            this.telephone = telephone;
            this.email = email;
            this.escorts = escorts;
            this.technicians = technicians;
            this.musicians = musicians;
        }
    }
}
