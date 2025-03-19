using System;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

class Program
{
    static void Main(string[] args)
    {
        // Load project configuration
        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        // Read configuration
        var emailConfig = configuration.GetSection("EmailConfig");

        string smtpServer = emailConfig["SmtpServer"];
        int smtpPort = int.Parse(emailConfig["SmtpPort"]);
        string email = emailConfig["Email"];
        string appPassword = emailConfig["AppPassword"];

        try
        {
            // Configure SMTP
            var smtpClient = new SmtpClient(smtpServer)
            {
                Port = smtpPort,
                Credentials = new NetworkCredential(email, appPassword),
                EnableSsl = true
            };

            // Enter your message
            var mailMessage = new MailMessage
            {
                From = new MailAddress(email),
                Subject = "Test Email from Localhost",
                Body = "This is a test email sent from localhost using Gmail SMTP.",
                IsBodyHtml = false
            };

            // Receiver email
            mailMessage.To.Add("cyrillepio@hotmail.com");

            // Send email
            smtpClient.Send(mailMessage);

            Console.WriteLine("Email sent successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
