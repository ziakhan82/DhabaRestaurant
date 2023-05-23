using Dhaba.MessageBus;

namespace Dhaba.Services.PaymentAPI.Messages
{
    // this is the next message that the api will post 
    public class UpdatePaymentResultMessage : BaseMessage
    {
        public int OrderId { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
    }
}
