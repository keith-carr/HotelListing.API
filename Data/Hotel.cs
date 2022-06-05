using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Data;

public class Hotel {
    public int Id { set; get; }
    public string Name { set; get; } = null!;
    public string Address { set; get; } = null!;
    public int CountryId { set; get; }
    public double Rating { set; get; }
    [ForeignKey(nameof(CountryId))] 
    public Country Country { set; get; }    
}