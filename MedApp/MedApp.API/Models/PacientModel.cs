using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedApp.API.Models
{
    public class PacientModel: BaseModel
    {
        public Guid DoctorGuid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Occupation { get; set; }
        public bool Active { get; set; }
        public DateTime Dob { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public string BloodType { get; set; }
        public int Sex { get; set; }

        public ICollection<PacientDiagnosticsModel> PacientDiagnostics { get; set; }
    }
}
