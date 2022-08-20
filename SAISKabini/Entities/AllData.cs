using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAISKabini.Entities
{
    public class AllData
    {
        public Guid Stationid { get; set; }
        public DateTime Readtime { get; set; }
        public string SoftwareVersion { get; set; }
        public int Period { get; set; }
        public double AkisHizi { get; set; }
        public double AKM { get; set; }
        public double CozunmusOksijen { get; set; }
        public double Debi { get; set; }
        public double DesarjDebi { get; set; }
        public double KOi { get; set; }
        public double pH { get; set; }
        public double Sicaklik { get; set; }
        public double Iletkenlik { get; set; }
        public double NumuneSicaklik { get; set; }
        public double NumuneNem { get; set; }
        public double Pompa1Hz { get; set; }
        public double Pompa2Hz { get; set; }
        public double Status { get; set; }
    }
}
