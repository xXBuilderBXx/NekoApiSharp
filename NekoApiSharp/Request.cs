namespace NekoApiSharp
{
    public class Request
    {
        public Request(string error = "", int code = 200)
        {
            if (code == 200)
                Success = true;
            Code = code;
            Error = error;
        }
        public string ImageUrl { get; internal set; }
        public bool Success { get; internal set; }
        public int Code { get; private set; }
        public string Error { get; private set; }
    }
}