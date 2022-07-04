using System;
using System.Diagnostics;

namespace SendWhatsAppMessage
{
    class Program
    {
        private static string _whatsAppUri = "https://api.whatsapp.com/send/?phone=";
        static void Main(string[] args)
        {
            Console.WriteLine("Enter WhatsApp No.:");
            string number = Console.ReadLine();
            string whatsAppUrl = $"{_whatsAppUri}{number}";
            var psi = new ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = whatsAppUrl
            };
            Process.Start(psi);
        }
    }
}
