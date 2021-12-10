using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTask
{
    public interface INotificationService
    {
        void Send(string message);
    }
}
