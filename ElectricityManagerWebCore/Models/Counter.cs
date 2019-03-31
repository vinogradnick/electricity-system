using System;

namespace ElectricityManagerWebCore.Models
{
    public class Counter
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public DateTime DateInstall { get; set; }
        public DateTime DateLastCheck { get; set; }
        
    }
}