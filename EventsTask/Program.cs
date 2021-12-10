using System;

namespace EventsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoEncoder = new VideoEncoder();

            var telegramService = new TelegramService();
            var emailService = new EmailService();

            var notificationSender = new NotificationSender();
            notificationSender.Subscribe(emailService);
            notificationSender.Subscribe(telegramService);

            videoEncoder.Preparing += (sender, eventArgs) => Console.WriteLine("Preparing");
            videoEncoder.Starting += (sender, eventArgs) => Console.WriteLine("Starting");
            videoEncoder.Finished += (sender, eventArgs) => notificationSender.Notify();

            videoEncoder.Encode(new byte[] { 1, 3});
        }
    }
}
