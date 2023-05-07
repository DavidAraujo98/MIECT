using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class Concert
    {
        public string id { get; set; }
        public string dur { get; set; }
        public string dateBegin { get; set; }
        public Stage stage { get; set; }
        public SoundCheck soundcheck { get; set; }
        public Band band { get; set; }

        public Concert(string id="", string dur="", string dateBegin="", Stage stage=null, SoundCheck soundcheck=null, Band band=null)
        {
            this.id = id;
            this.dur = dur;
            this.dateBegin = dateBegin;
            this.stage = stage;
            this.soundcheck = soundcheck;
            this.band = band;
        }
    }
}
