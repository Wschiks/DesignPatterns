namespace NotificationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationManager manager = new NotificationManager();

            manager.emailService.Send(
                "student@school.nl",
                "Je nieuwe rooster staat klaar."
            );

            manager.smsService.Send(
                "0612345678",
                "Je les begint over 15 minuten."
            );

            manager.pushService.Send(
                "student123",
                "Er staat nieuwe feedback voor je klaar."
            );

            manager.whatsappService.Send(
                "student 06-12345678",
                "Er staat nieuwe feedback voor je klaar."
            );

            // Decorator: Logging (Email en SMS)
            INotificationService loggingEmail =
                new LoggingNotificationDecorator(new EmailNotificationService());
            loggingEmail.Send("student@school.nl", "Je rooster is gewijzigd.");

            INotificationService loggingSms =
                new LoggingNotificationDecorator(new SmsNotificationService());
            loggingSms.Send("0612345678", "Je rooster is gewijzigd.");

            // Decorator: Urgent
            INotificationService urgentDecorated =
                new UrgentNotificationDecorator(new EmailNotificationService());
            urgentDecorated.Send("student@school.nl", "Je leslokaal is gewijzigd.");

            // Combinatie: Logging -> Timestamp -> Urgent -> Email
            INotificationService fullEmail =
                new LoggingNotificationDecorator(
                    new TimestampNotificationDecorator(
                        new UrgentNotificationDecorator(
                            new EmailNotificationService())));
            fullEmail.Send("student@school.nl", "Je rooster is gewijzigd.");

            // Dezelfde combinatie met SMS (eindopdracht)
            INotificationService fullSms =
                new LoggingNotificationDecorator(
                    new TimestampNotificationDecorator(
                        new UrgentNotificationDecorator(
                            new SmsNotificationService())));
            fullSms.Send("0612345678", "Je rooster is gewijzigd.");

            // Opdracht 9 - Variant A: Logging -> Urgent -> Email
            Console.WriteLine("--- Variant A ---");
            INotificationService variantA =
                new LoggingNotificationDecorator(
                    new UrgentNotificationDecorator(
                        new EmailNotificationService()));
            variantA.Send("student@school.nl", "Je rooster is gewijzigd.");

            // Opdracht 9 - Variant B: Urgent -> Logging -> Email
            Console.WriteLine("--- Variant B ---");
            INotificationService variantB =
                new UrgentNotificationDecorator(
                    new LoggingNotificationDecorator(
                        new EmailNotificationService()));
            variantB.Send("student@school.nl", "Je rooster is gewijzigd.");

            Console.ReadLine();
        }
    }
}