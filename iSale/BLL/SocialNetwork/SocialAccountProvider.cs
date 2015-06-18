using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SocialNetwork
{
    public abstract class SocialAccountProvider
    {
        public abstract UserLoginData GetUserData(string accessCode);

        public abstract void CreatePost(string accessToken);

        protected string GetResponse(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream receivedStream = response.GetResponseStream())
                    {
                        StreamReader readStream = string.IsNullOrEmpty(response.CharacterSet) ? new StreamReader(receivedStream) : new StreamReader(receivedStream, Encoding.GetEncoding(response.CharacterSet));
                        return readStream.ReadToEnd();
                    }
                }
            }
            return null;
        }
    }
}
