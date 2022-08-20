using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAISKabini
{
    internal class CalibrationData
    {
        public bool ZeroGecerlimi { get; set; }
        public bool SpanGecerlimi { get; set; }
        public bool KalibrasyonGecerlimi { get; set; }
        public DateTime KalibrasyonTarihi { get; set; }
        public string Parametre { get; set; }
        public double ZeroRef { get; set; }
        public double ZeroMeas { get; set; }
        public double ZeroDiff { get; set; }
        public double ZeroStd { get; set; }
        public double SpanRef { get; set; }
        public double SpanMeas { get; set; }
        public double SpanDiff { get; set; }
        public double SpanStd { get; set; }
        public double ResultFactor { get; set; }
    }
}
