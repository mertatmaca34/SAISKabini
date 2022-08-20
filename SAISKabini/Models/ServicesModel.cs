using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SAISKabini
{
    public class ServicesModel
    {
        private string Url { get; set; }
        private Guid? TicketId { get; set; }
        private API_StationInformation StationInfo { get; set; }
        private StationType stationType { get; set; }

        public ServicesModel(string url, StationType stationType)
        {
            this.Url = url;
            this.stationType = stationType;
        }

        private string MD5Hash(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private ResultStatus<T> PostData<T>(string url, string data) where T : new()
        {
            try
            {
                using (var webClient = new WebClient())
                {

                    webClient.Encoding = Encoding.UTF8;
                    webClient.Headers.Add("AToken", JsonConvert.SerializeObject(new AToken { TicketId = this.TicketId.ToString() }));

                    var resp = webClient.UploadString(this.Url + url, data);

                    return JsonConvert.DeserializeObject<ResultStatus<T>>(resp);

                }
            }
            catch (Exception ex)
            {
                return new ResultStatus<T>
                {
                    message = ex.Message + System.Environment.NewLine + url
                };
            }

        }

        private ResultStatus<T> TriggerService<T>(string url) where T : new()
        {

            try
            {

                var _url = String.Format("https://{0}:{1}/{2}", StationInfo.ConnectionDomainAddress, StationInfo.ConnectionPort, url);

                using (var webClient = new WebClient())
                {

                    webClient.Encoding = Encoding.UTF8;
                    webClient.UseDefaultCredentials = true;
                    webClient.Credentials = new NetworkCredential(StationInfo.ConnectionUser, StationInfo.ConnectionPassword);

                    var resp = webClient.DownloadString(_url);

                    return JsonConvert.DeserializeObject<ResultStatus<T>>(resp);

                }

            }
            catch (Exception ex)
            {
                return new ResultStatus<T>
                {
                    message = ex.Message + System.Environment.NewLine + url
                };
            }

        }

        public ResultStatus<LoginResult> Login(string username, string password)
        {

            var login = new Login
            {
                username = username,
                password = MD5Hash(MD5Hash(password))
            };

            var res = PostData<LoginResult>("/security/login", JsonConvert.SerializeObject(login));
            if (res.result)
            {
                this.TicketId = res.objects.TicketId.Value;
            }

            return res;

        }

        public ResultStatus<DateTime> Trigger_GetLastDataDate()
        {

            var res = TriggerService<DateTime>(String.Format("GetLastDataDate?StationId={0}", StationInfo.StationId));

            return res;

        }

        public ResultStatus<API_StationInformation> GetStationInformation(string stationId)
        {

            var res = PostData<API_StationInformation>(String.Format(this.stationType.ToString() + "/GetStationInformation?stationId={0}", stationId), "");
            if (res.result)
            {
                this.StationInfo = res.objects;
            }

            return res;

        }

        public ResultStatus<object> SendHostChanged(API_StationInformation data)
        {

            var res = PostData<object>(this.stationType.ToString() + "/SendHostChanged", JsonConvert.SerializeObject(data));
            
            return res;

        }

        public ResultStatus<List<API_DiagnosticType>> GetDiagnosticTypes()
        {

            var res = PostData<List<API_DiagnosticType>>(this.stationType.ToString() + "/GetDiagnosticTypes", "");
            
            return res;

        }

        public ResultStatus<object> SendDiagnostic(API_Diagnostic data)
        {

            var res = PostData<object>(this.stationType.ToString() + "/SendDiagnostic", JsonConvert.SerializeObject(data));
            
            return res;

        }

        public ResultStatus<object> sendData(SendData data)
        {

            var res = PostData<object>(this.stationType.ToString() + "/SendData", JsonConvert.SerializeObject(data));

            return res;

        }

        public ResultStatus<object> sendCalibration(SendCalibration data)
        {

            var res = PostData<object>(this.stationType.ToString() + "/SendCalibration", JsonConvert.SerializeObject(data));

            return res;

        }


        public ResultStatus<object> GetLastData()
        {

            var res = TriggerService<object>(String.Format("GetLastData?stationId={0}&period={0}", StationInfo.StationId, StationInfo.DataPeriodMinute));

            return res;

        }

        public ResultStatus<object> sendDiagnosticWithTypeNo(SendDiagnosticWithTypeNo data)
        {

            var res = PostData<object>(this.stationType.ToString() + "/SendDiagnosticWithTypeNo", JsonConvert.SerializeObject(data));

            return res;

        }
    }

}
