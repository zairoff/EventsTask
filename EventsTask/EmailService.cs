using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTask
{
    public class EmailService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending email...");
        }
    }
}
