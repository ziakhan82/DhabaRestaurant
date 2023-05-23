namespace Dhaba.Services.OrderAPI.Messages
{
    // this is the next message that the api will post 
    public class UpdatePaymentResultMessage
    {
        public int OrderId { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
    }
}
