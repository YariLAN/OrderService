namespace OrderService.Models.Dto.Responses
{
    public class OrderResponse
    {
        public int Id { get; set; }

        public string CitySender { get; set; }

        public string AddressSender { get; set; }

        public string CityRecipient { get; set; }

        public string AddressRecipient { get; set; }

        public string WeightCargo { get; set; }

        public DateTime DateDispatch { get; set; }
    }
}
