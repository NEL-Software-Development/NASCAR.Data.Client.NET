using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASCAR.Data.Client.NATS
{
    public interface INats
    {
        bool Connect();
        bool Disconnect();
        bool Subscribe<T>(string endpoint, Action<T> messageHandler);
        bool Unsubscribe(string endpoint);
        bool Send<T>(string endpoint, T data);
    }
}
