namespace Hattfabriken.Models.Interfaces
{
    public interface IMailService
    {
        bool SendMail(MailData mailData);
    }
}
