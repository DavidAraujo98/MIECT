using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class Stage
    {
        public string id { get; set; }
        public string local { get; set; }
        public int lot { get; set; }
        public Festival festival { get; set; }

        public Stage(string id="", string local="", int lot=0, Festival festival=null) : base()
        {
            this.id = id;
            this.local = local;
            this.lot = lot;
            this.festival = festival;
        }

        public override String ToString()
        {
            return local;
        }
    }
}
