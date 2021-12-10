using System;

namespace EventsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new MyComplexEncoder();
            var telegramService = new TelegramService();
            var emailService = new EmailService();

            var videoEncoder = new VideoEncoder();
            videoEncoder.AddNotificationSource(telegramService);
            videoEncoder.AddNotificationSource(emailService);

            encoder.Preparing += videoEncoder.PreparingEncoding;
            encoder.Starting += videoEncoder.StartedEncoding;
            encoder.Finished += videoEncoder.FinishedEncoding;

            encoder.Encode(new byte[] { 1, 3});
        }
    }
}
