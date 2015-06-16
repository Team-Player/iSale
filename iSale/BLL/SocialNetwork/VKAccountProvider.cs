using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SocialNetwork
{
    public class VkAccountProvider : SocialAccountProvider
    {
        private const string _url = "https://oauth.vk.com/access_token?client_id={0}&client_secret={1}&code={2}&redirect_uri=https://isale.team-player.ru/signin-vkontakte";
        private const string _clientId = "4951624";//"4958654";
        private const string _clientSecret = "P2ypWQn0DSjEKpUxdzzD";//"zfy34YMvumnMBJE6iGFa";
        public override string GetAccessToken(string accessCode)
        {
            string response = GetResponse(string.Format(_url, _clientId, _clientSecret, accessCode));
            string accessToken = "qwerty";

            return accessToken;
        }
    }
}
