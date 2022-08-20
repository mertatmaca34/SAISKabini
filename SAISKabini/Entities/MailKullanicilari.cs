using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAISKabini.Entities
{
    public class MailKullanicilari
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public bool PhLimitAsimi { get; set; }
        public bool AkmLimitAsimi { get; set; }
        public bool KoiLimitAsimi { get; set; }
        public bool DumanAlarmi { get; set; }
        public bool SuBaskiniAlarmi { get; set; }
        public bool ElektrikAlarmi { get; set; }
        public bool KapiAlarmi { get; set; }
        public bool Pompa1Alarmi { get; set; }
        public bool Pompa2Alarmi { get; set; }
        public bool TemizSuPompaTermik { get; set; }
        public bool YikamaTanki { get; set; }
        public bool VeriDurumu { get; set; }
    }
}
