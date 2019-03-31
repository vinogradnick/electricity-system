using System.Collections.Generic;

namespace ElectricityManagerWebCore.Models
{
    public class Customer
    {
        public int DocumentNumber { get; set; }
        public Fider Fider { get; set; }
        public Tp Tp { get; set; }
        public Line Line { get; set; }
        public string Name { get; set; }
        public Counter Counter { get; set; }
        public string ObjectName { get; set; }
        public string PlaceInstall { get; set; }
        public string ObjectAdress { get; set; }
        public int Category { get; set; }
        public bool Status { get; set; }
        public List<PowerUsage> Usages { get; set; }
    }
}