using System;

namespace NotificationApp
{
    public class WhatsAppAdapter : INotificationService
    {
        private readonly WhatsAppClient whatsAppClient;

        public WhatsAppAdapter()
        {
            whatsAppClient = new WhatsAppClient();
        }

        public void Send(string recipient, string message)
        {
            whatsAppClient.SendWhatsAppMessage(recipient, message, false);
        }
    }
} 