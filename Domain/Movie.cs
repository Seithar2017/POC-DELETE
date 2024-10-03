using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMDbAPICaller.Domain
{
    internal class Movie
    {

        //Dates
        public DateTime Released { get; set; }

        //decimals
        public decimal Rate { get; set; }

        // ints
        public int Runtime { get; set; } //in minutes

        // strings
        public string Title { get; set; }
        public string ProductionYear { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }

        //lists
        public List<string> Actors { get; set; } = new List<string>();
        public List<string> Awards { get; set; } = new List<string>();
        public List<string> Directors { get; set; } = new List<string>();
        public List<string> Countries { get; set; } = new List<string>();
        public List<string> Genres { get; set; } = new List<string>();
        public List<string> MainActors { get; set; } = new List<string>();


    }
}
