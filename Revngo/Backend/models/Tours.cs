namespace Revngo.Api.models;

public class Tours
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Stars { get; set; }
    public double Rating { get; set; }
    public int ReviewsCount { get; set; }

    public string ImageUrl { get; set; }
    public bool? IsSuperior { get; set; }

    public int LocationId { get; set; }

    public double Price { get; set; }
    public int Nights { get; set; }
    public int Adults { get; set; }

    public string MealType { get; set; }

    public bool HasWifi { get; set; }
    public bool HasParking { get; set; }
    public bool HasPool { get; set; }

    public bool IsKidFriendly { get; set; }
    public bool IsPetFriendly { get; set; }

    public string RatingText { get; set; }

    public string FeaturesJson { get; set; }
    public string UsefulInfoJson { get; set; }

    public string CheckinFrom { get; set; }
    public string CheckinTo { get; set; }
    public string CheckoutUntil { get; set; }

    public string SpokenLanguages { get; set; }

    public string PaymentPolicy { get; set; }
    public string AcceptedCurrency { get; set; }

    public string LocalTax { get; set; }

    public string ReceptionHours { get; set; }
    public string WellnessHours { get; set; }

    public List<string> AcceptedCards { get; set; }

    public bool HasWellness { get; set; }
    public bool HasAirConditioning { get; set; }
    public bool HasHalfBoard { get; set; }

    public string DescriptionHtml { get; set; }

    public string Description { get; set; }

    public List<string> Images { get; set; }
}