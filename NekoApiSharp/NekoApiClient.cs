using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NekoApiSharp
{
    public class NekoApiClient
    {
        public NekoApiClient(string botname, string token = "")
        {
            Client.DefaultRequestHeaders.Add("User-Agent", $"NekoApiSharp {Version} | {botname}");
            if (token != "")
                Client.DefaultRequestHeaders.Add("Authorization", token);
            ImageGen = new ImageGenEndpoints(this);
            Image = new ImageEndpoints(this);
        }
        private readonly HttpClient Client = new HttpClient();
        public readonly string Version = "1.2.2";
        public LogType LogType = LogType.Info;

        public ImageGenEndpoints ImageGen;
        public ImageEndpoints Image;

        public async Task<Request> SendRequest(string endpoint)
        {
            Request Request = null;
            HttpResponseMessage Res = null;
            try
            {
                Res = await Client.GetAsync("https://nekobot.xyz/api/" + endpoint);
                Res.EnsureSuccessStatusCode();
                string Content = await Res.Content.ReadAsStringAsync();
                JObject Msg = JObject.Parse(Content);
                Request = new Request(Msg, true, "", (int)Res.StatusCode);
                if (LogType >= LogType.Info)
                    Console.WriteLine($"[NekoApiSharp] Success, {Request.ErrorMessage}");
                if (LogType == LogType.Debug)
                    Console.WriteLine("[NekoApiSharp] Request response in JSON\n" + Msg);
            }
            catch (Exception ex)
            {
                if (Res == null)
                    Request = new Request(null, false, ex.Message, 0);
                else
                    Request = new Request(null, false, ex.Message, (int)Res.StatusCode);
                if (LogType >= LogType.Info)
                    Console.WriteLine($"[NekoApiSharp] Failed, {Request.ErrorMessage} {Request.ErrorCode}");
                if (LogType == LogType.Debug)
                    Console.WriteLine("[NekoApiSharp] Exception\n" + ex.ToString());
            }
            return Request;
        }

        
    }
    public enum LogType
    {
        None, Info, Debug
    }
}
