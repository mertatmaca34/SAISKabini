using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAISKabini
{
    public class API_Diagnostic
    {
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public Guid stationId { get; set; }
        public string details { get; set; }
        public int? diagnosticTypeNo { get; set; }

    }
}
