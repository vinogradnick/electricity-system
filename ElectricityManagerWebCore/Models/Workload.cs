using System;
using System.Collections.Generic;

namespace ElectricityManagerWebCore.Models
{
    public class Workload
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<Phase> Phases { get; set; }
        public List<BusbarSection> BusbarSections { get; set; }
        
    }
}