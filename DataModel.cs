using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    public class RepairRequest
    {
        public int RequestNumber { get; set; }
        public DateTime DateAdded { get; set; }
        public string CarType { get; set; }
        public string CarModel { get; set; }
        public string ProblemDescription { get; set; }
        public string ClientName { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public string AssignedMechanic { get; set; }
    }

    public class Mechanic
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
    }
}
