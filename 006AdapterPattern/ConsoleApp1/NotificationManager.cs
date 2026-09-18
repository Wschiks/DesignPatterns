namespace NotificationApp
{
    public class NotificationManager
    {
        public INotificationService emailService;
        public INotificationService smsService;
        public INotificationService pushService;
        public INotificationService whatsappService;

        public NotificationManager()
        {
            emailService = new EmailNotificationService();
            smsService = new SmsNotificationService();
            pushService = new PushNotificationService();
            whatsappService = new WhatsAppAdapter();
        }
    }
}   