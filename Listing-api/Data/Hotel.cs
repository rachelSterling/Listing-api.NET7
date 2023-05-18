using System.ComponentModel.DataAnnotations.Schema;

namespace Listing_api.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }


        [ForeignKey(nameof(ContryId))]
        public int ContryId { get; set; }
        public Country Contry { get; set; }
    }
}
