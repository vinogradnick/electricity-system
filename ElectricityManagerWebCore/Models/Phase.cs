using System.Collections.Generic;

namespace ElectricityManagerWebCore.Models
{
    public class Phase
    {
        public int Id { get; set; }
        public Line Line { get; set; }
        public List<PhaseData> PhaseDatas { get; set; }
    }
}