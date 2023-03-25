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

        public Task<Request> Threats(string imageurl)
        => Client.SendRequest("imagegen?type=threats&url=" + imageurl);
        

        public Task<Request> Baguette(string imageurl)
            =>  Client.SendRequest("imagegen?type=baguette&url=" + imageurl);
        

        public Task<Request> Clyde(string text)
            =>  Client.SendRequest("imagegen?type=clyde&text=" + text);
        

        public Task<Request> Ship(string image1url, string image2url)
            =>  Client.SendRequest($"imagegen?type=ship&user1={image1url}&user2={image2url}");
        

        public Task<Request> Captcha(string name, string imageurl)
        => Client.SendRequest($"imagegen?type=captcha&username={name}&url={imageurl}");
        

        public Task<Request> WhoWouldWin(string image1url, string image2url)
        => Client.SendRequest($"imagegen?type=whowouldwin&user1={image1url}&user2={image2url}");
        

        public Task<Request> ChangeMyMind(string text)
        => Client.SendRequest("imagegen?type=changemymind&text=" + text);
        

        public Task<Request> DDLC(DDLC_Character character, DDLC_Background background, string text)
        => Client.SendRequest($"imagegen?type=ddlc&character={character.ToString().ToLower()}&background={background.ToString().ToLower()}&body=1&face=a&text={text}");
        

        public Task<Request> Lolice(string imageurl)
        => Client.SendRequest("imagegen?type=lolice&url=" + imageurl);
        

        public Task<Request> Kanna(string text)
        => Client.SendRequest("imagegen?type=kannagen&text=" + text);
        

        public Task<Request> IphoneX(string imageurl)
        => Client.SendRequest("imagegen?type=iphonex&url=" + imageurl);
        

        public Task<Request> Awooify(string imageurl)
        => Client.SendRequest("imagegen?type=awooify&url=" + imageurl);
        

        public Task<Request> Trap(string authorname, string targetname, string targetimageurl)
        => Client.SendRequest($"imagegen?type=trap&image={targetimageurl}&name={targetname}&author={authorname}");
        

        public Task<Request> TrumpTweet(string text)
        => Client.SendRequest("imagegen?type=trumptweet&text=" + text);
        

        public Task<Request> Tweet(string username, string text)
        => Client.SendRequest($"imagegen?type=tweet&username={username}&text={text}");
        

        public Task<Request> Deepfry(string imageurl)
            =>  Client.SendRequest("imagegen?type=deepfry&image=" + imageurl);
        

        public Task<Request> Blurpify(string imageurl)
            =>  Client.SendRequest("imagegen?type=blurpify&image=" + imageurl);
        

        public Task<Request> PornhubComment(string username, string imageurl, string text)
            =>  Client.SendRequest($"imagegen?type=trap&image={imageurl}&username={username}&text={text}");
        

        public Task<Request> Magik(string imageurl, int intensity)
            =>  Client.SendRequest($"imagegen?type=magik&image={imageurl}&intensity={intensity}");
        

        public Task<Request> Trash(string imageurl)
            =>  Client.SendRequest("imagegen?type=trash&url=" + imageurl);
        

        public enum DDLC_Character
        {
            Monika, Yuri, Natsuki, Sayori
        }

        public enum DDLC_Background
        {
            Bedroom, Class, Closet, Club, Corridor, House, Kitchen, Residential, Sayori_Bedroom
        }
    }
}
