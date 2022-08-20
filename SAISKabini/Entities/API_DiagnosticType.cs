using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAISKabini
{
    public class API_DiagnosticType
    {
        public int DiagnosticTypeNo { get; set; }
        public string DiagnosticTypeName { get; set; }
        public int? DiagnosticLevel { get; set; }
        public string DiagnosticLevel_Title { get; set; }
    }
}
