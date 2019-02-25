using System;
using System.Collections.Generic;
using System.Text;
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

        public async Task<Request> PornGif()
        {
            return await Client.SendRequest("image?type=pgif");
        }

        public async Task<Request> FourK()
        {
            return await Client.SendRequest("image?type=4k");
        }

        public async Task<Request> Hentai()
        {
            return await Client.SendRequest("image?type=hentai");
        }

        public async Task<Request> Holo()
        {
            return await Client.SendRequest("image?type=holo");
        }

        public async Task<Request> LewdNeko()
        {
            return await Client.SendRequest("image?type=lewdneko");
        }

        public async Task<Request> Neko()
        {
            return await Client.SendRequest("image?type=neko");
        }

        public async Task<Request> LewdKitsune()
        {
            return await Client.SendRequest("image?type=lewdkitsune");
        }

        public async Task<Request> Kemonomimi()
        {
            return await Client.SendRequest("image?type=kemonomimi");
        }

        public async Task<Request> Anal()
        {
            return await Client.SendRequest("image?type=anal");
        }

        public async Task<Request> HentaiAnal()
        {
            return await Client.SendRequest("image?type=hentai_anal");
        }

        public async Task<Request> GoneWild()
        {
            return await Client.SendRequest("image?type=gonewild");
        }

        public async Task<Request> Kanna()
        {
            return await Client.SendRequest("image?type=kanna");
        }

        public async Task<Request> Ass()
        {
            return await Client.SendRequest("image?type=ass");
        }

        public async Task<Request> Pussy()
        {
            return await Client.SendRequest("image?type=pussy");
        }

        public async Task<Request> Thigh()
        {
            return await Client.SendRequest("image?type=thigh");
        }
    }
}
