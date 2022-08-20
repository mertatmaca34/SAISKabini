﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAISKabini
{
    public class SendData
    {
        public Guid? Stationid { get; set; }
        public DateTime? Readtime { get; set; }
        public string SoftwareVersion { get; set; }
        public int? Period { get; set; }
        public double? AkisHizi { get; set; }
        public int? AkisHizi_Status { get; set; }
        public double? AKM { get; set; }
        public int? AKM_Status { get; set; }
        public double? CozunmusOksijen { get; set; }
        public int? CozunmusOksijen_Status { get; set; }
        public double? Debi { get; set; }
        public int? Debi_Status { get; set; }
        public double? DesarjDebi { get; set; }
        public int? DesarjDebi_Status { get; set; }
        public double? KOi { get; set; }
        public int? KOi_Status { get; set; }
        public double? pH { get; set; }
        public int? pH_Status { get; set; }
        public double? Sicaklik { get; set; }
        public int? Sicaklik_Status { get; set; }
        public double? Iletkenlik { get; set; }
        public int? Iletkenlik_Status { get; set; }
    }
}
