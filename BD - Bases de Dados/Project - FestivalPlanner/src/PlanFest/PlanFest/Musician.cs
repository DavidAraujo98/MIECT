using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class Musician : Person
    {
        public string artisticName { get; set; }
        public Instrument instrument { get; set; }

        public Musician(string nCC = "", string telephone = "", string name = "", string sex = "", string email = "", string artisticName="", Instrument instrument=null) : base(nCC,telephone,name,sex,email)
        {
            this.artisticName = artisticName;
            this.instrument = instrument;
        }
    }
}
