namespace ElectricityManagerWebCore.Models
{
    public class BusbarSection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public Workload Workload { get; set; }
    }

    public class PowerUsage
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public Customer Customer { get; set; }
    }
}