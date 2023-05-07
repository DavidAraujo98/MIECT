using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class Meal
    {
        public string id { get; private set; }
        public string mainDish { get; set; }
        public string dessert { get; set; }
        public string drink { get; set; }
        public string time { get; set; }
        public Company cathering { get; set; }

        public Meal(string id="", string mainDish="", string dessert="", string drink="", string time="", Company cathering=null) : base()
        {
            this.id = id;
            this.mainDish = mainDish;
            this.dessert = dessert;
            this.drink = drink;
            this.cathering = cathering;
        }
    }
}
