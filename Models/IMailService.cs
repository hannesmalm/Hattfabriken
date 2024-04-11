namespace Hattfabriken.Models
{
    public interface IMailService
    {
        bool SendMail(MailData mailData);
    }
}
