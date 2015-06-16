using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Shared
{
    public class RandomStringGenerator
    {
        public string Generate()
        {
            var builder = new StringBuilder();
            var random = new Random();

            char ch;
            for (int i = 0; i < 20; i += 2)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
                builder.Append(random.Next(0, 9));
            }

            builder.Append(Guid.NewGuid().ToString().Replace("-", "").ToUpper());

            return builder.ToString();
        }
    }
}
