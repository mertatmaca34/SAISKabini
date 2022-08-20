using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAISKabini
{
    public class Objects
    {
        public int Period { get; set; }
        public DateTime ReadTime { get; set; }
        public double AKM { get; set; }
        public int AKM_Status { get; set; }
        public double CozunmusOksijen { get; set; }
        public int CozunmusOksijen_Status { get; set; }
        public double Debi { get; set; }
        public int Debi_Status { get; set; }
        public double KOi { get; set; }
        public int KOi_Status { get; set; }
        public double pH { get; set; }
        public int pH_Status { get; set; }
        public double Sicaklik { get; set; }
        public int Sicaklik_Status { get; set; }
        public double Iletkenlik { get; set; }
        public int Iletkenlik_Status { get; set; }
        public double AkisHizi { get; set; }
        public int AkisHizi_Status { get; set; }
        public double DesarjDebi { get; set; }
        public int DesarjDebi_Status { get; set; }
        public double DesarjDebi_N { get; set; }
        public int DesarjDebi_N_Status { get; set; }
        public double AKM_N { get; set; }
        public int AKM_N_Status { get; set; }
        public double CozunmusOksijen_N { get; set; }
        public int CozunmusOksijen_N_Status { get; set; }
        public double AkisHizi_N { get; set; }
        public int AkisHizi_N_Status { get; set; }
        public double Debi_N { get; set; }
        public int Debi_N_Status { get; set; }
        public double KOi_N { get; set; }
        public int KOi_N_Status { get; set; }
        public double pH_N { get; set; }
        public int pH_N_Status { get; set; }
        public double Iletkenlik_N { get; set; }
        public int Iletkenlik_N_Status { get; set; }
        public double Sicaklik_N { get; set; }
        public int Sicaklik_N_Status { get; set; }
    }

    public class ResultStatus
    {
        public bool result { get; set; }
        public string message { get; set; }
        public Objects objects { get; set; }
    }

    public class ResultStatus<Objects>
    {
        public bool result { get; set; }
        public string message { get; set; }
        public Objects objects { get; set; }
    }
}