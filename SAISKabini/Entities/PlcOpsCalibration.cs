using Sharp7;
using System;

namespace SAISKabini
{
    public class PlcOpsCalibration
    {
        static readonly S7Client client = new S7Client(); //PLC Nesnesi Oluşturma
        private static readonly int v = client.ConnectTo("10.33.3.253", 0, 1);
        private readonly int plcResult = v; //Oluşturulan nesneye PLC IP'sinin bağlanması


        //Değişkenler
        byte[] db41Buffer = new byte[148];

        byte[] db4Buffer = new byte[30];

        byte[] db1Buffer = new byte[30];

        byte[] mb1Buffer = new byte[300];

        byte[] MBBuffer = new byte[2000];

        public int PlcResult { get; set; }

        //DB41
        public double AkmValue { get; set; }
        public double KoiValue { get; set; }
        public double PhValue { get; set; }
        public double IletkenlikValue { get; set; }


        public DateTime GetPlcTime() //Anlık PLC Saati Çekme
        {
            PlcResult = client.DBRead(4, 0, db4Buffer.Length, db4Buffer);

            DateTime time = S7.GetDTLAt(db4Buffer, 0);

            return time;
        }

        public void SetRealValues()
        {
            PlcResult = client.DBRead(41, 0, db41Buffer.Length, db41Buffer);

            AkmValue = Math.Round(S7.GetRealAt(db41Buffer, 36), 2);

            KoiValue = Math.Round(S7.GetRealAt(db41Buffer, 32), 2);

            PhValue = Math.Round(S7.GetRealAt(db41Buffer, 16), 2);

            IletkenlikValue = Math.Round(S7.GetRealAt(db41Buffer, 20), 2);
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
