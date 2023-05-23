using Dhaba.MessageBus;

namespace Dhaba.Services.PaymentAPI.Messages
{
    // this will be the message that i post on the azure service bus, once this message is retreive
    // inside the payment api, it will create and process that, once the processing is successful
    //that api will post a new message with the order id and the status and the order api will
    // retrive that message and then it will update the order status
    public class PaymentRequestMessage : BaseMessage
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public string ExpiryMonthYear { get; set; }
        public double OrderTotal { get; set; }
        public string Email { get; set; }
    }
}
