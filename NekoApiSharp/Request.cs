using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace NekoApiSharp
{
    public class Request
    {
        public Request(JObject content, bool success, string error, int code)
        {
            if (content != null)
            {
                RawData = content;
                if (content.ContainsKey("message"))
                    ImageUrl = (string)content["message"];
            }
            Success = success;
            ErrorCode = code;
            ErrorMessage = error;
        }
        public readonly string ImageUrl;
        public readonly bool Success;
        public readonly int ErrorCode;
        public readonly string ErrorMessage;
        public readonly dynamic RawData;
    }
}
