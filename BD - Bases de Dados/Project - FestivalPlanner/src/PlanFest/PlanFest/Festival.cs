using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]

    internal class Festival
    {
        public string name { get; set; }
        public string dateEnd { get; set; }
        public string dateBegin { get; set; }
        public string dateProposal { get; set;  }
        public string id { get; set; }
        public int nDays { get; set; }
        public int nTickets { get; set; }
        public Promoter promoter { get; set; }
        public Manager manager { get; set; }
        public List<Meal> meals { get; set; }
        public List<Concert> concerts { get; set; }

        public void addStage(Concert e)
        {
            concerts.Add(e);
        }

        public void addMeal(Meal e)
        {
            meals.Add(e);
        }

        public Festival(string name="", string dateEnd ="", string dateBegin ="", string dateProposal ="", string id="", int nDays=0, int nTickets=0, Promoter promoter=null, Manager manager=null, List<Meal> meals=null, List<Concert> stages=null) : base()
        {
            this.name = name;
            this.dateEnd = dateEnd;
            this.dateBegin = dateBegin;
            this.dateProposal = dateProposal;
            this.id = id;
            this.nDays = nDays;
            this.nTickets = nTickets;
            this.promoter = promoter;
            this.manager = manager;
            this.meals = meals;
            this.concerts = stages;
        }

        public override String ToString()
        {
            return id + " " + name + " " + dateBegin +" " + dateEnd + " " + dateProposal + " " + nDays + " " + nTickets ;
        }
    }
}
