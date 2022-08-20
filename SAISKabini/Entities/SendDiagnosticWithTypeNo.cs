using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAISKabini
{
    public class SendDiagnosticWithTypeNo
    {
        public Guid stationId { get; set; }
        public DateTime? startDate { get; set; }
        public string details { get; set; }
        public int? diagnosticTypeNo { get; set; }

    }
}
