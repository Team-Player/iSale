using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BLL.SocialNetwork
{
    public class VkAccountProvider : SocialAccountProvider
    {
        private const string _accTokenUrl = "https://oauth.vk.com/access_token?client_id={0}&client_secret={1}&code={2}&redirect_uri=https://isale.team-player.ru/signin-vkontakte";
        private const string _userUrl = "https://api.vk.com/method/users.get?user_id={0}&access_token={1}&fields=photo_50,city,bdate,country,sex,photo_200";
        private const string _clientId = "4951624";//"4958654";
        private const string _clientSecret = "P2ypWQn0DSjEKpUxdzzD";//"zfy34YMvumnMBJE6iGFa";
        public override UserLoginData GetUserData(string accessCode)
        {
            string response = GetResponse(string.Format(_accTokenUrl, _clientId, _clientSecret, accessCode));

            var data = JsonConvert.DeserializeObject(response) as JObject;
            string accessToken = data["access_token"].ToString();

            string userResponse = GetResponse(string.Format(_userUrl, data["user_id"], data["access_token"]));
            var userData = JsonConvert.DeserializeObject(userResponse) as JObject;

            UserLoginData userLoginData = new UserLoginData
            {
                AccessToken = data["access_token"].ToString(),
                Email = data["email"].ToString(),
                ProviderKey = data["user_id"].ToString(),

                FirstName = userData["response"][0]["first_name"].ToString(),
                LastName = userData["response"][0]["last_name"].ToString(),
                Avatar = userData["response"][0]["photo_200"] == null ? userData["response"][0]["photo_50"].ToString() : userData["response"][0]["photo_200"].ToString()
            };

            return userLoginData;
        }

        public override void CreatePost(string accessToken)
        {
            string url = "https://api.vk.com/method/wall.post?owner_id=6273129&access_token={0}&message=test wall.post";

            string response = GetResponse(string.Format(url, accessToken));

            var data = JsonConvert.DeserializeObject(response) as JObject;

        }
    }
}
