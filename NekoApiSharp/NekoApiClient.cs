using Microsoft.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace NekoApiSharp
{
    public class NekoApiClient
    {
        public NekoApiClient(string botname, string token = "")
        {
            if (Client == null)
            {
                Client = new HttpClient()
                {
                    BaseAddress = new Uri("https://nekobot.xyz/api/")
                };
                Client.DefaultRequestHeaders.Add("User-Agent", $"NekoApiSharp {Version} | {botname}");
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                if (token != "")
                    Client.DefaultRequestHeaders.Add("Authorization", token);
            }
            
            ImageGen = new ImageGenEndpoints(this);
            Image = new ImageEndpoints(this);
        }
        private static HttpClient Client;
        public static readonly string Version = "1.3.4";
        public LogType LogType = LogType.Info;
        public readonly ImageGenEndpoints ImageGen;
        public readonly ImageEndpoints Image;

        private static readonly RecyclableMemoryStreamManager recyclableMemoryStreamManager = new RecyclableMemoryStreamManager();

        public async Task<Request> SendRequest(string endpoint)
        {
            Request Request = null;
            HttpResponseMessage Res = null;
            try
            {
                Res = await Client.GetAsync("https://nekobot.xyz/api/" + endpoint, HttpCompletionOption.ResponseContentRead).ConfigureAwait(false);
                Res.EnsureSuccessStatusCode();
                int BufferSize = (int)Res.Content.Headers.ContentLength.Value;
                using (MemoryStream Stream = recyclableMemoryStreamManager.GetStream("NekosSharpApi-SendRequest", BufferSize))
                {
                    await Res.Content.CopyToAsync(Stream);
                    Stream.Position = 0;
                    using (TextReader text = new StreamReader(Stream))
                    using (JsonReader reader = new JsonTextReader(text))
                    {
                        JToken Value = JObject.ReadFrom(reader);
                        Request = new Request("", 200) { ImageUrl = (string)Value["message"] };
                    }
                }

                switch (LogType)
                {
                    case LogType.Info:
                        Console.WriteLine($"[NekoApiSharp] Success, {Request.Error}");
                        break;
                    case LogType.Debug:
                        Console.WriteLine($"[NekoApiSharp] Success, {Request.Error}");
                        Console.WriteLine("[NekoApiSharp] Request response in JSON\n" + JsonConvert.SerializeObject(Request, Formatting.Indented));
                        break;
                }
            }
            catch (Exception ex)
            {
                if (Res == null)
                    Request = new Request(ex.Message, 400);
                else
                    Request = new Request(ex.Message, (int)Res.StatusCode);
                switch (LogType)
                {
                    case LogType.Info:
                        Console.WriteLine($"[NekoApiSharp] Failed, {Request.Error} {Request.Code}");
                        break;
                    case LogType.Debug:
                        Console.WriteLine($"[NekoApiSharp] Failed, {Request.Error} {Request.Code}");
                        Console.WriteLine("[NekoApiSharp] Exception\n" + ex.ToString());
                        break;
                }
            }
            if (Request == null)
            {
                Request = new Request("Failed to parse json response", 400);
                if (LogType >= LogType.Info)
                    Console.WriteLine($"[NekoApiSharp] Failed to parse json response");
            }
            return Request;
        }
    }
    public enum LogType
    {
        None, Info, Debug
    }
}
