using System.Threading.Tasks;

namespace NekoApiSharp
{
    public class ImageEndpoints
    {
        public ImageEndpoints(NekoApiClient client)
        {
            Client = client;
        }
        private readonly NekoApiClient Client;

        public Task<Request> HAss()
            => Client.SendRequest("image?type=hass");

        public Task<Request> Hmidriff()
            => Client.SendRequest("image?type=hmidriff");

        public Task<Request> PGif()
            => Client.SendRequest("image?type=pgif");

        public Task<Request> FourK()
        => Client.SendRequest("image?type=4k");
        

        public Task<Request> Hentai()
        => Client.SendRequest("image?type=hentai");
        

        public Task<Request> Holo()
        => Client.SendRequest("image?type=holo");
        

        public Task<Request> Hneko()
        => Client.SendRequest("image?type=hneko");
        

        public Task<Request> Neko()
        => Client.SendRequest("image?type=neko");
        

        public Task<Request> LewdKitsune()
        => Client.SendRequest("image?type=lewdkitsune");

        public Task<Request> Hkitsune()
            => Client.SendRequest("image?type=hkitsune");
       
        public Task<Request> Kemonomimi()
        => Client.SendRequest("image?type=kemonomimi");
        

        public Task<Request> Anal()
        => Client.SendRequest("image?type=anal");
        

        public Task<Request> HentaiAnal()
        => Client.SendRequest("image?type=hentai_anal");
        

        public Task<Request> GoneWild()
        => Client.SendRequest("image?type=gonewild");
        

        public Task<Request> Kanna()
        => Client.SendRequest("image?type=kanna");
        

        public Task<Request> Ass()
        => Client.SendRequest("image?type=ass");
        

        public Task<Request> Pussy()
        => Client.SendRequest("image?type=pussy");
        

        public Task<Request> Thigh()
        => Client.SendRequest("image?type=thigh");

        public Task<Request> HThigh()
            => Client.SendRequest("image?type=hthigh");

        public Task<Request> Paizuri()
            => Client.SendRequest("image?type=paizuri");

        public Task<Request> Tentacle()
            => Client.SendRequest("image?type=tentacle");

        public Task<Request> Boobs()
            => Client.SendRequest("image?type=boobs");

        public Task<Request> Hboobs()
            => Client.SendRequest("image?type=hboobs");

        public Task<Request> Cosplay()
            => Client.SendRequest("image?type=cosplay");

        public Task<Request> Swimsuit()
            => Client.SendRequest("image?type=swimsuit");

        public Task<Request> Pantsu()
            => Client.SendRequest("image?type=pantsu");

    }
}
