using Sharp7;
using System;

namespace SAISKabini
{
    internal class PlcOps
    {
        static readonly S7Client client = new S7Client(); //PLC Nesnesi Oluşturma
        private static readonly int v = client.ConnectTo("10.33.3.253", 0, 1);
        private int plcResult = v; //Oluşturulan nesneye PLC IP'sinin bağlanması


        //Değişkenler
        private byte[] db41Buffer = new byte[148];

        private byte[] db4Buffer = new byte[30];

        private byte[] db1Buffer = new byte[30];

        private byte[] mb1Buffer = new byte[300];


        public int PlcResult { get; set; }

        //DB41
        public double AkmValue { get; set; }
        public double OksijenValue { get; set; }
        public double DebiValue { get; set; }
        public double KoiValue { get; set; }
        public double PhValue { get; set; }
        public double SicaklikValue { get; set; }
        public double NemValue { get; set; }
        public double IletkenlikValue { get; set; }
        public double AkisHiziValue { get; set; }
        public double DesarjDebiValue { get; set; }
        public double Pompa1Hz { get; set; }
        public double Pompa2Hz { get; set; }


        //BİT DEĞERLER
        public bool KapiValue { get; set; }
        public bool DumanValue { get; set; }
        public bool SuBaskiniValue { get; set; }
        public bool AcilStopValue { get; set; }
        public bool Pompa1TermikValue { get; set; }
        public bool Pompa2TermikValue { get; set; }
        public bool TemizSuTermikValue { get; set; }
        public bool YikamaTankiValue { get; set; }
        public bool EnerjiValue { get; set; }
        public bool Pompa1Value { get; set; }
        public bool Pompa2Value { get; set; }



        public DateTime GetPlcTime() //Anlık PLC Saati Çekme
        {
            PlcResult = client.DBRead(4, 0, db4Buffer.Length, db4Buffer);

            DateTime time = S7.GetDTLAt(db4Buffer, 0);

            return time;
        }


        public int GetStatus() //Anlık Kabin Çalışma Durumu (Oto mod, Yıkama vb)
        {
            PlcResult = client.MBRead(0, mb1Buffer.Length, mb1Buffer);

            bool yikama = S7.GetBitAt(mb1Buffer, 24, 1);

            bool haftalikYikama = S7.GetBitAt(mb1Buffer, 24, 2);

            bool auto = S7.GetBitAt(mb1Buffer, 10, 6);

            bool bakim = S7.GetBitAt(mb1Buffer, 10, 4);

            bool kalibrasyon = S7.GetBitAt(mb1Buffer, 10, 5);


            int status = yikama == true ? 23
            : haftalikYikama == true ? 24
            : auto == true ? 1
            : bakim == true ? 25
            : kalibrasyon == true ? 9
            : 0;
            return status;
        }


        public void SetRealValues()
        {
            AkmValue = Math.Round(S7.GetRealAt(db41Buffer, 36), 2);

            OksijenValue = Math.Round(S7.GetRealAt(db41Buffer, 24), 2);

            DebiValue = Math.Round(S7.GetRealAt(db41Buffer, 0), 2);

            KoiValue = Math.Round(S7.GetRealAt(db41Buffer, 32), 2);

            PhValue = Math.Round(S7.GetRealAt(db41Buffer, 16), 2);

            SicaklikValue = Math.Round(S7.GetRealAt(db41Buffer, 28), 2);

            NemValue = Math.Round(S7.GetRealAt(db41Buffer, 44), 2);

            IletkenlikValue = Math.Round(S7.GetRealAt(db41Buffer, 20), 2);

            AkisHiziValue = Math.Round(S7.GetRealAt(db41Buffer, 4), 2);

            DesarjDebiValue = Math.Round(S7.GetRealAt(db41Buffer, 12), 2);

            Pompa1Hz = Math.Round(S7.GetRealAt(db41Buffer, 140), 2);

            Pompa2Hz = Math.Round(S7.GetRealAt(db41Buffer, 144), 2);
        }


        public void SetBitValues()
        {
            KapiValue = S7.GetBitAt(db1Buffer, 25, 5);

            DumanValue = S7.GetBitAt(db1Buffer, 1, 1);

            SuBaskiniValue = S7.GetBitAt(db1Buffer, 0, 7);

            AcilStopValue = S7.GetBitAt(db1Buffer, 25, 7);

            Pompa1TermikValue = S7.GetBitAt(db1Buffer, 27, 5);

            Pompa2TermikValue = S7.GetBitAt(db1Buffer, 28, 0);

            TemizSuTermikValue = S7.GetBitAt(db1Buffer, 28, 2);

            YikamaTankiValue = S7.GetBitAt(db1Buffer, 28, 3);

            EnerjiValue = S7.GetBitAt(db1Buffer, 25, 6);

            Pompa1Value = S7.GetBitAt(db1Buffer, 27, 4);

            Pompa2Value = S7.GetBitAt(db1Buffer, 27, 7);
        }


        public bool Connected()
        {
            return client.Connected;
        }


        public void Reconnect()
        {
            PlcResult = client.ConnectTo("10.33.3.253", 0, 1);
        }

    }
}
