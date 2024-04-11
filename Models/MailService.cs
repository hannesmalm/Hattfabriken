using Microsoft.Extensions.Options;
using MimeKit;
using System;
using MailKit.Security;
using MailKit.Net.Smtp;
using Hattfabriken.Models;

public class MailService : IMailService
{
    private readonly MailSettings _mailSettings;

    public MailService(IOptions<MailSettings> mailSettings)
    {
        _mailSettings = mailSettings.Value;
    }

    public bool SendMail(MailData mailData)
    {
        try
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_mailSettings.SenderName, _mailSettings.SenderEmail));
            message.To.Add(new MailboxAddress(mailData.EmailToName, mailData.EmailToID));
            message.Subject = mailData.EmailSubject;

            message.Body = new TextPart("plain")
            {
                Text = mailData.EmailBody
            };

            using (var client = new SmtpClient())
            {
                client.Connect(_mailSettings.Server, _mailSettings.Port, SecureSocketOptions.StartTls);
                client.Authenticate(_mailSettings.UserName, _mailSettings.Password);
                client.Send(message);
                client.Disconnect(true);
            }

            return true; // Email sent successfully
        }
        catch (Exception ex)
        {
            // Log the exception for debugging
            Console.WriteLine(ex.ToString());
            return false; // Failed to send email
        }
    }
}










