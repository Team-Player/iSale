using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SocialNetwork
{
    public static class SocialAccountProviderFactory
    {
        private static readonly Dictionary<string, SocialAccountProvider> _accountProviders = new Dictionary<string, SocialAccountProvider>()
        {
            {"VK", new VkAccountProvider()}
        };

        public static SocialAccountProvider GetProvider(string providerName)
        {
            return _accountProviders[providerName];
        }
    }
}
