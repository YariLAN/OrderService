using System.ComponentModel.DataAnnotations;

namespace OrderService.Models.Dto.Requests
{
    public class OrderRequest
    {
        [Required]
        public string CitySender { get; set; }

        [Required]
        public string AddressSender { get; set; }

        [Required]
        public string CityRecipient { get; set; }

        [Required]
        public string AddressRecipient { get; set; }

        [Required]
        public string WeightCargo { get; set; }

        [Required]
        public DateOnly DateDispatch { get; set; }
    }
}
