using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTask
{
    public class VideoEncoder
    {
        private readonly List<INotificationService> _notificationServices;

        public VideoEncoder()
        {
            _notificationServices = new List<INotificationService>();
        }

        public void PreparingEncoding(object source, EventArgs args)
        {
            Console.WriteLine("Preparing encoding");
        }

        public void StartedEncoding(object source, EventArgs args)
        {
            Console.WriteLine("Started encoding");
        }

        public void FinishedEncoding(object source, EventArgs args)
        {
            Console.WriteLine("Finished encoding");

            Notify();
        }

        public void AddNotificationSource(INotificationService notificationService)
        {
            _notificationServices.Add(notificationService);
        }

        public void Notify()
        {
            foreach (var notification in _notificationServices)
            {
                notification.Send("Video is encoded");
            }
        }
    }
}
