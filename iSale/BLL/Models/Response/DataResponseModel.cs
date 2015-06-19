using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models.Response
{
    public class DataResponseModel<T>: MessageResponseModel
    {
        public T Data { get; set; }
    }
}
