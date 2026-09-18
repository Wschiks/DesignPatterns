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

            Console.ReadLine();
        }
    }
}