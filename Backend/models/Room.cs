namespace Revngo.Api.models;

public class Room
{
    public int Id { get; set; }

    public int HotelId { get; set; }

    public string Name { get; set; }

    public int AreaM2 { get; set; }

    public int Bedrooms { get; set; }

    public int? Beds { get; set; }

    public bool HasWifi { get; set; }

    public bool HasAc { get; set; }

    public bool Balcony { get; set; }

    public string ImageUrl { get; set; }

    public double PricePerNight { get; set; }
}