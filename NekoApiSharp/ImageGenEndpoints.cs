using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NekoApiSharp
{
    public class ImageGenEndpoints
    {
        public ImageGenEndpoints(NekoApiClient client)
        {
            Client = client;
        }
        private readonly NekoApiClient Client;

        public async Task<Request> Threats(string imageurl)
        {
            return await Client.SendRequest("imagegen?type=threats&url=" + imageurl);
        }

        public async Task<Request> Baguette(string imageurl)
        {
            return await Client.SendRequest("imagegen?type=baguette&url=" + imageurl);
        }

        public async Task<Request> Clyde(string text)
        {
            return await Client.SendRequest("imagegen?type=clyde&text=" + text);
        }

        public async Task<Request> Ship(string image1url, string image2url)
        {
            return await Client.SendRequest($"imagegen?type=ship&user1={image1url}&user2={image2url}");
        }

        public async Task<Request> Captcha(string name, string imageurl)
        {
            return await Client.SendRequest($"imagegen?type=captcha&username={name}&url={imageurl}");
        }

        public async Task<Request> WhoWouldWin(string image1url, string image2url)
        {
            return await Client.SendRequest($"imagegen?type=whowouldwin&user1={image1url}&user2={image2url}");
        }

        public async Task<Request> ChangeMyMind(string text)
        {
            return await Client.SendRequest("imagegen?type=changemymind&text=" + text);
        }

        public async Task<Request> DDLC(DDLC_Character character, DDLC_Background background, string text)
        {
            return await Client.SendRequest($"imagegen?type=ddlc&character={character.ToString().ToLower()}&background={background.ToString().ToLower()}&body=1&face=a&text={text}");
        }

        public async Task<Request> Lolice(string imageurl)
        {
            return await Client.SendRequest("imagegen?type=lolice&url=" + imageurl);
        }

        public async Task<Request> Kanna(string text)
        {
            return await Client.SendRequest("imagegen?type=kannagen&text=" + text);
        }

        public async Task<Request> IphoneX(string imageurl)
        {
            return await Client.SendRequest("imagegen?type=iphonex&url=" + imageurl);
        }

        public async Task<Request> Awooify(string imageurl)
        {
            return await Client.SendRequest("imagegen?type=awooify&url=" + imageurl);
        }

        public async Task<Request> Trap(string authorname, string targetname, string targetimageurl)
        {
            return await Client.SendRequest($"imagegen?type=trap&image={targetimageurl}&name={targetname}&author={authorname}");
        }

        public async Task<Request> TrumpTweet(string text)
        {
            return await Client.SendRequest("imagegen?type=trumptweet&text=" + text);
        }

        public async Task<Request> Tweet(string username, string text)
        {
            return await Client.SendRequest($"imagegen?type=tweet&username={username}&text={text}");
        }

        public async Task<Request> Deepfry(string imageurl)
        {
            return await Client.SendRequest("imagegen?type=deepfry&image=" + imageurl);
        }

        public async Task<Request> Blurpify(string imageurl)
        {
            return await Client.SendRequest("imagegen?type=blurpify&image=" + imageurl);
        }

        public async Task<Request> PornhubComment(string username, string imageurl, string text)
        {
            return await Client.SendRequest($"imagegen?type=trap&image={imageurl}&username={username}&text={text}");
        }

        public async Task<Request> Magik(string imageurl, int intensity)
        {
            return await Client.SendRequest($"imagegen?type=magik&image={imageurl}&intensity={intensity}");
        }

        public async Task<Request> Trash(string imageurl)
        {
            return await Client.SendRequest("imagegen?type=trash&url=" + imageurl);
        }

        public enum DDLC_Character
        {
            Monkia, Yuri, Natsuki, Sayori
        }

        public enum DDLC_Background
        {
            Bedroom, Class, Closet, Club, Corridor, House, Kitchen, Residential, Sayori_Bedroom
        }
    }
}
