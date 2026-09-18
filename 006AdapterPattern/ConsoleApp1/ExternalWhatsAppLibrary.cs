using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApp;

     public class WhatsAppClient 

    { 
        public void SendWhatsAppMessage( 
            string phoneNumber, 
            string text, 
            bool urgent) 
        { 

            Console.WriteLine("EXTERNE WHATSAPP SERVICE"); 
            Console.WriteLine($"Telefoonnummer: {phoneNumber}"); 
            Console.WriteLine($"Tekst: {text}"); 
            Console.WriteLine($"Urgent: {urgent}"); 

        } 

    } 
