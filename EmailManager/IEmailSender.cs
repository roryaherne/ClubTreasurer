using System.Threading.Tasks;

namespace EmailManager
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
