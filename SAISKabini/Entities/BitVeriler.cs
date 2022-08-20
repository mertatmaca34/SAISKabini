using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAISKabini.Entities
{
    internal class BitVeriler
    {
        public DateTime? Readtime { get; set; }
        public bool Kapi { get; set; }
        public bool Duman { get; set; }
        public bool SuBaskini { get; set; }
        public bool AcilStop { get; set; }
        public bool Pompa1Termik { get; set; }
        public bool Pompa2Termik { get; set; }
        public bool TemizSuPompaTermik { get; set; }
        public bool YikamaTanki { get; set; }
        public bool Enerji { get; set; }
        public bool VeriDurumu { get; set; }
        public bool AutoStat { get; set; }
        public bool YikamaStat { get; set; }
        public bool HaftalikYikamaStat { get; set; }
        public bool KalibrasyonStat { get; set; }
        public bool BakimStat { get; set; }
        public bool Pompa1CalisiyorMu { get; set; }
        public bool Pompa2CalisiyorMu { get; set; }
    }
}
