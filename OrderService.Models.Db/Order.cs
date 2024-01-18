namespace OrderService.Models.Db
{
    public class Order
    {
        public int Id { get; set; }

        public string CitySender { get; set; }

        public string AddressSender { get; set; }

        public string CityRecipient { get; set; }

        public string AddressRecipient { get; set; }

        public double WeightCargo { get; set; }

        public DateOnly DateDispatch { get; set; }
    }
}
