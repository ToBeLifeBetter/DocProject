using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Util.Exception
{
    /// <summary>
    /// 自定义异常
    /// </summary>
    public class CustomException : System.Exception
    {
        public CustomException()
        {
        }

        public CustomException(string message) : base(message)
        {
        }
    }
}
