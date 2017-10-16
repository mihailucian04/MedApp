using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedApp.API.Models
{
    public class PacientDiagnosticsModel: BaseModel
    {
        public Guid PacientGuid { get; set; }
        public DateTime Date { get; set; }
        public string Diagnostic { get; set; }
        public string Treatment { get; set; }
    }
}
