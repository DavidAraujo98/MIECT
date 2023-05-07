using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class SoundCheck
    {
        public string id { get; set;}
        public string dateBegin { get; set; }

        public int dur { get; set; }

        private Concert concert { get; set; }

        public SoundCheck(string id="", string dateBegin="", int dur=0, Concert concert=null) : base()
        {
            this.id = id;
            this.dateBegin = dateBegin;
            this.dur = dur;
            this.concert = concert;
        }
    }
}
