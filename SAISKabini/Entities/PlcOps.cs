using Sharp7;
using System;

namespace SAISKabini
{
    public class PlcOps
    {
        static readonly S7Client client = new S7Client(); //PLC Nesnesi Oluşturma
        private int PlcResult = client.ConnectTo("10.33.3.253", 0, 1); //Oluşturulan nesneye PLC IP'sinin bağlanması


        //Değişkenler
        byte[] db41Buffer = new byte[148];

        byte[] db4Buffer = new byte[30];

        byte[] db1Buffer = new byte[30];

        byte[] mb1Buffer = new byte[300];

        byte[] MBBuffer = new byte[2000];


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


        //BİT STATS DEĞERLERİ
        public bool YikamaStat { get; set; }
        public bool HaftalikYikamaStat { get; set; }

        public bool AutoStat { get; set; }
        public bool BakimStat { get; set; }
        public bool KalibrasyonStat { get; set; }


        //MB36 DENEME
        public bool[] MB36 = new bool[8];
        public bool[] MB19 = new bool[8];
        public bool[] MB1600 = new bool[8];


        public DateTime GetPlcTime() //Anlık PLC Saati Çekme
        {
            PlcResult = client.DBRead(4, 0, db4Buffer.Length, db4Buffer);

            DateTime time = S7.GetDTLAt(db4Buffer, 0);

            return time;
        }


        public int GetStatus() //Anlık Kabin Çalışma Durumu (Oto mod, Yıkama vb)
        {
            SetStatusValues();

            int status = YikamaStat == true ? 23
            : HaftalikYikamaStat == true ? 24
            : AutoStat == true ? 1
            : BakimStat == true ? 25
            : KalibrasyonStat == true ? 9
            : 0;


            return status;
        }

        public void SetStatusValues()
        {
            PlcResult = client.MBRead(0, mb1Buffer.Length, mb1Buffer);

            YikamaStat = S7.GetBitAt(mb1Buffer, 24, 1);

            HaftalikYikamaStat = S7.GetBitAt(mb1Buffer, 24, 2);

            AutoStat = S7.GetBitAt(mb1Buffer, 10, 6);

            BakimStat = S7.GetBitAt(mb1Buffer, 10, 4);

            KalibrasyonStat = S7.GetBitAt(mb1Buffer, 10, 5);
        }

        public void SetRealValues()
        {
            PlcResult = client.DBRead(41, 0, db41Buffer.Length, db41Buffer);

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
            PlcResult = client.EBRead(0, db1Buffer.Length, db1Buffer);

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

        public void SetGunlukYikama()
        {
            PlcResult = client.MBRead(0, MBBuffer.Length, MBBuffer);

            for (int i = 0; i < 8; i++)
            {
                if (i != 5)
                {
                    MB19[i] = S7.GetBitAt(MBBuffer, 19, i);
                    S7.SetBitAt(MBBuffer, 19, i, MB19[i]);
                }
            }

            S7.SetBitAt(MBBuffer, 19, 5, true);

            PlcResult = client.MBWrite(0, MBBuffer.Length, MBBuffer);
        }

        public void SetHaftalikYikama()
        {
            PlcResult = client.MBRead(0, MBBuffer.Length, MBBuffer);

            for (int i = 0; i < 8; i++)
            {
                if (i != 0)
                {
                    MB1600[i] = S7.GetBitAt(MBBuffer, 1600, i);
                    S7.SetBitAt(MBBuffer, 1600, i, MB19[i]);
                }
            }

            S7.SetBitAt(MBBuffer, 1600, 0, true);

            PlcResult = client.MBWrite(0, MBBuffer.Length, MBBuffer);
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
