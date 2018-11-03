using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Torchbearer.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string QuickDescription { get; set; }
        public bool BeginnersLuckHealth { get; set; }
    }
}
