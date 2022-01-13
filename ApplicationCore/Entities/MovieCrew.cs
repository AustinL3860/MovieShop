using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class MovieCrew
    {
        public int MoivieId { get; set; }
        public int CrewId { get; set;}
        public string Department { get; set;}
        public string job { get; set; }
    }
}
