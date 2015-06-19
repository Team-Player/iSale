using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Helpers
{
    public class AuthorizationHelper
    {
        public static string GetHeaderValue(HttpRequestMessage request, string headerName)
        {
            IEnumerable<string> headerValues;
            bool headerFound = request.Headers.TryGetValues(headerName, out headerValues);
            if (headerFound)
            {
                return headerValues.FirstOrDefault();
            }
            return string.Empty;
        }
    }
}
