namespace NotificationApp
{
    public class LoggingNotificationDecorator
        : NotificationDecorator
    {
        public LoggingNotificationDecorator(
            INotificationService notificationService)
            : base(notificationService)
        {
        }

        public override void Send(
            string recipient,
            string message)
        {
            Console.WriteLine($"LOG: notificatie naar {recipient}");
            Console.WriteLine();

            notificationService.Send(recipient, message);
        }
    }
}
