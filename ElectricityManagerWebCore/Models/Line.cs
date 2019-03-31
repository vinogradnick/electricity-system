using System.Collections.Generic;

namespace ElectricityManagerWebCore.Models
{
    public class Line
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GeoCode { get; set; }
        public int Voltage { get; set; }
        public int Power { get; set; }
        public Counter Counter { get; set; }
        public  Section Section { get; set; }
        public List<Customer> Customers { get; set; }
    }
}