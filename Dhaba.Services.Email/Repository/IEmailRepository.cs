using Dhaba.Services.Email.Messages;


namespace Dhaba.Services.Email.Repository
{
    public interface IEmailRepository
    {
        Task SendAndLogEmail(UpdatePaymentResultMessage message);
    }
}
