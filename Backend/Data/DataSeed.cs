using Revngo.Api.models;

namespace Revngo.Api.Data;

public static class DataSeed
{
   public static List<FilterSection> Filters = new List<FilterSection>
{
    new FilterSection
    {
        Key = "topServices",
        Title = "TOP services",
        OptionsText = "6 options",
        Type = "services",
        Items = new List<FilterItem>
        {
            new FilterItem { Key = "has_wifi", Label = "WiFi", Icon = "/jpg/wif.png" },
            new FilterItem { Key = "has_parking", Label = "Parking lot", Icon = "/jpg/parking.png" },
            new FilterItem { Key = "has_pool", Label = "Pool", Icon = "/jpg/pool.png" },
            new FilterItem { Key = "has_wellness", Label = "Wellness", Icon = "/jpg/lotus.png" },
            new FilterItem { Key = "has_air_conditioning", Label = "Air-conditioning", Icon = "/jpg/air-conditioner.png" },
            new FilterItem { Key = "has_half_board", Label = "Half-board", Icon = "/jpg/half-board.png" }
        }
    },

    new FilterSection
    {
        Key = "meals",
        Title = "Meals",
        OptionsText = "4 options",
        Type = "checkbox",
        Items = new List<FilterItem>
        {
            new FilterItem { Key = "meal_type:No meals", Label = "No meals" },
            new FilterItem { Key = "meal_type:Breakfast", Label = "Breakfast included" },
            new FilterItem { Key = "meal_type:Half board", Label = "Half-board" },
            new FilterItem { Key = "meal_type:Full board", Label = "Full board" }
        }
    },

    new FilterSection
    {
        Key = "accommodationType",
        Title = "Accommodation type",
        OptionsText = "4 options",
        Type = "checkbox",
        Items = new List<FilterItem>
        {
            new FilterItem { Key = "stars:2", Label = "2 star" },
            new FilterItem { Key = "stars:3", Label = "3 star" },
            new FilterItem { Key = "stars:4", Label = "4 star" },
            new FilterItem { Key = "stars:5", Label = "5 star" }
        }
    },

    new FilterSection
    {
        Key = "rating",
        Title = "Based on ratings",
        OptionsText = "3 options",
        Type = "checkbox",
        Items = new List<FilterItem>
        {
            new FilterItem { Key = "rating:9", Label = "Excellent (9+)" },
            new FilterItem { Key = "rating:8", Label = "Very good (8+)" },
            new FilterItem { Key = "rating_text:Excellent", Label = "Excellent text rating" }
        }
    },

    new FilterSection
    {
        Key = "paymentMethods",
        Title = "Payment methods",
        OptionsText = "3 options",
        Type = "checkbox",
        Items = new List<FilterItem>
        {
            new FilterItem { Key = "card:visa.png", Label = "Visa" },
            new FilterItem { Key = "card:mastercard.png", Label = "MasterCard" },
            new FilterItem { Key = "payment_policy:payable_on_site", Label = "Pay on site" }
        }
    },

    new FilterSection
    {
        Key = "languages",
        Title = "Spoken languages",
        OptionsText = "3 options",
        Type = "checkbox",
        Items = new List<FilterItem>
        {
            new FilterItem { Key = "language:English", Label = "English" },
            new FilterItem { Key = "language:Hungarian", Label = "Hungarian" },
            new FilterItem { Key = "language:German", Label = "German" }
        }
    },
  

    new FilterSection
    {
        Key = "locationFeatures",
        Title = "Location features",
        OptionsText = "4 options",
        Type = "checkbox",
        Items = new List<FilterItem>
        {
            new FilterItem { Key = "has_air_conditioning", Label = "Air conditioning" },
            new FilterItem { Key = "has_wifi", Label = "WiFi" },
            new FilterItem { Key = "has_parking", Label = "On-site parking" },
            new FilterItem { Key = "has_pool", Label = "Pool" }
        }
    },

    new FilterSection
    {
        Key = "petFriendly",
        Title = "Pet friendly",
        OptionsText = "2 options",
        Type = "checkbox",
        Items = new List<FilterItem>
        {
            new FilterItem { Key = "is_pet_friendly", Label = "Pet friendly" },
            new FilterItem { Key = "is_kid_friendly", Label = "Kid friendly" },
        }
    },
  

    new FilterSection
    {
        Key = "priceRange",
        Title = "Price range",
        OptionsText = "3 options",
        Type = "checkbox",
        Items = new List<FilterItem>
        {
            new FilterItem { Key = "price:<100", Label = "Under €100" },
            new FilterItem { Key = "price:100-200", Label = "€100 - €200" },
            new FilterItem { Key = "price:>200", Label = "Above €200" }
        }
    }
};

    public static List<Tours> Tours = new()
    {
        new Tours
        {
            Id = 4,
            Name = "Hotel Vinifera Wine & Spa Balatonfüred",
            Stars = 5,
            Rating = 9.6,
            ReviewsCount = 50,
            ImageUrl = "hotels/4.jpg",
            IsSuperior = null,
            LocationId = 2,
            Price = 205.94,
            Nights = 1,
            Adults = 2,
            MealType = "No meals",
            HasWifi = true,
            HasParking = false,
            HasPool = true,
            IsKidFriendly = true,
            IsPetFriendly = false,
            RatingText = "Excellent",
            FeaturesJson = null,
            UsefulInfoJson = "[]",
            CheckinFrom = "15:00",
            CheckinTo = "24:00",
            CheckoutUntil = "until 11:00",
            SpokenLanguages = "English, Hungarian, German",
            PaymentPolicy =
                "Payment policy: The full balance (or remaining amount after prepayment) is On departure day.",
            AcceptedCurrency = "HUF (Ft) , EUR (€)",
            LocalTax =
                "Local tax: 710 Ft / person / night (1.86 € / person / night) of the reservation value (for guests aged 18), included in the full price and payable on site.(payable on site) ",
            ReceptionHours = "24-hour front desk",
            WellnessHours = "07:30 - 21:30",
            AcceptedCards = new List<string>
            {
                "visa.png",
                "mastercard.png"
            },
            HasWellness = true,
            HasAirConditioning = true,
            HasHalfBoard = false,
            DescriptionHtml = null,
            Description =
                "The Hotel Vinifera Wine & Spa is a five-star wellness hotel located 1,000 m from the Balaton shore in Balatonfüred, a sparkling cultural city on the northern shore of Balaton, where guests can get to know the wine culture and taste of the region in addition to relaxing.",
            Images = new List<string>
            {
                "hotels/4.jpg",
                "hotels/4.1.jpg",
                "hotels/4.2.jpg"
            }
        },
        new Tours
        {
            Id = 2,
            Name = "Hotel Golden Lake Resort Balatonfüred",
            Stars = 4,
            Rating = 9.1,
            ReviewsCount = 1097,
            ImageUrl = "jpg/2.jpg",
            IsSuperior = null,
            LocationId = 2,
            Price = 108.53,
            Nights = 1,
            Adults = 2,
            MealType = "Breakfast",
            HasWifi = true,
            HasParking = true,
            HasPool = true,
            IsKidFriendly = true,
            IsPetFriendly = true,
            RatingText = "Very good",
            FeaturesJson = null,
            UsefulInfoJson = "[]",
            CheckinFrom = "15:00",
            CheckinTo = "24:00",
            CheckoutUntil = "11:00",
            SpokenLanguages = "English, Hungarian, German",
            PaymentPolicy =
                "Payment policy: The full balance (or remaining amount after prepayment) is On arrival day.",
            AcceptedCurrency = "HUF (Ft) , EUR (€)",
            LocalTax =
                "Local tax: 710 Ft / person / night (1.86 € / person / night) of the reservation value (for guests aged 18), included in the full price and payable on site.(payable on site) ",
            ReceptionHours = "24-hour front desk",
            WellnessHours = "07:30 - 20:30",
            AcceptedCards = new List<string>(),
            HasWellness = true,
            HasAirConditioning = true,
            HasHalfBoard = true,
            DescriptionHtml = "<p>123</p>",
            Description = @"Dear Guests,

**** Hotel Golden Lake Resort located in Balatonfüred, a former Roman settlement, now a marvellous city which brings back remote times. The city dwellers and their guests have always led their lives and habits in line with the historic traditions. The hotel welcomes its guests with such historic traditions plus all modern conveniences.

Built in wonderful scenery, in the centre of the lakeside area, next to Tagore Promenade and the port, the building complex offers a wide range of services for all who need an active rest, holiday or yachting.

****Hotel Golden Lake Resort Balatonfüred is a wellness and conference hotel with 58 double rooms including spare beds as required, with a balcony and view. From them there are 5 in the category standard, 30 medium, 23 plus, as well as 1 de lux junior suite and 8 de lux suites. Besides, the hotel capacity is regularly increased with de lux junior suites from the apart hotel of the complex.

We provide parking spaces subject to free capacity, on the basis of a prior written reservation. Please let us know your parking needs in advance!
The outdoor Swim spa jacuzzi is temporarily closed for maintenance.",
            Images = new List<string>
            {
                "hotels/2.jpg",
                "hotels/2.1.jpg",
                "hotels/2.2.jpg"
            }
        },
        new Tours
    {
        Id = 1,
        Name = "Hotel Margaréta Balatonfüred",
        Stars = 4,
        Rating = 9.2,
        ReviewsCount = 1849,
        ImageUrl = "jpg/1.jpg",
        IsSuperior = null,
        LocationId = 1,
        Price = 114.97,
        Nights = 1,
        Adults = 2,
        MealType = "No meals",
        HasWifi = true,
        HasParking = true,
        HasPool = true,
        IsKidFriendly = true,
        IsPetFriendly = false,
        RatingText = "Very good",
        FeaturesJson = null,
        UsefulInfoJson = "[{\"label\": \"Bus station\", \"distance\": \"200 m\"}, {\"label\": \"Restaurant\", \"distance\": \"550 m\"}, {\"label\": \"Train station\", \"distance\": \"1 km\"}, {\"label\": \"City center\", \"distance\": \"1.2 km\"}]",
        CheckinFrom = "15:00",
        CheckinTo = "18:00",
        CheckoutUntil = "10:00",
        SpokenLanguages = "English, Hungarian, German",
        PaymentPolicy = "The full balance is payable on arrival.",
        AcceptedCurrency = "HUF (Ft), EUR (€)",
        LocalTax = "Local tax: 710 Ft / person / night (1.86€)",
        ReceptionHours = "24-hour front desk",
        WellnessHours = "07:30 - 20:30",
        AcceptedCards = new List<string>
        {
            "visa.png",
            "mastercard.png"
        },
        HasWellness = false,
        HasAirConditioning = false,
        HasHalfBoard = false,
        DescriptionHtml = null,
        Description = "The renewed Hotel Margaréta is located in Balatonfüred, directly at the main road Nr.71. Balatonfüred is a popular and continuously developing holiday resort at lake Balaton, next to the wonderful peninsula Tihany.\r\n\r\nTo finalise the booking your are required to pay 50% advance payment of the total amount within 3 days of our confirmation.\r\nIn case of a cancellation up to 14 days prior to arrival may result in a change of the arrival date or in a refund of the deposit after the deduction of a penalty fee of 3.000 HUF.\r\n\r\nTourist tax in 2025: 710 HUF/Person/Night (from 18 years).\r\n\r\nWe draw your attention that bookings for five rooms or more are considered as groop booking...",
        Images = new List<string>
        {
            "hotels/1.jpg",
            "hotels/1.1.jpg",
            "hotels/1.2.jpg"
        }
    },
        new Tours
        {
            Id = 5,
            Name = "Echo Residence All Suite Hotel",
            Stars = 4,
            Rating = 9.3,
            ReviewsCount = 1124,
            ImageUrl = "hotels/5.jpg",
            IsSuperior = null,
            LocationId = 5,
            Price = 165.00,
            Nights = 2,
            Adults = 2,
            MealType = "Half board",
            HasWifi = true,
            HasParking = true,
            HasPool = true,
            IsKidFriendly = true,
            IsPetFriendly = false,
            RatingText = null,
            FeaturesJson = "{}",
            UsefulInfoJson = "[{\"label\": \"Lake Balaton\", \"distance\": \"150 m\"}, {\"label\": \"Viewpoint\", \"distance\": \"400 m\"}, {\"label\": \"Restaurant\", \"distance\": \"700 m\"}, {\"label\": \"Tihany Benedictine Abbey\", \"distance\": \"1.3 km\"}, {\"label\": \"City center\", \"distance\": \"2 km\"}]",
            CheckinFrom = "14:00",
            CheckinTo = "18:00",
            CheckoutUntil = "10:30",
            SpokenLanguages = "English, Hungarian, German",
            PaymentPolicy = "Full payment required at check-in.",
            AcceptedCurrency = "HUF (Ft), EUR (€)",
            LocalTax = "Local tax: 600 Ft / person / night (included).",
            ReceptionHours = "24-hour front desk",
            WellnessHours = "07:00 - 22:00",
            AcceptedCards = new List<string>
            {
                "visa.png",
                "mastercard.png"
            },
            HasWellness = false,
            HasAirConditioning = false,
            HasHalfBoard = false,
            DescriptionHtml = null,
            Description = null,
            Images = new List<string>
            {
                "hotels/5.jpg",
                "hotels/5.1.jpg",
                "hotels/5.2.jpg"
            }
        },
        new Tours
        {
            Id = 3,
            Name = "Anna Grand Hotel Balatonfüred",
            Stars = 5,
            Rating = 9.6,
            ReviewsCount = 11,
            ImageUrl = "hotels/3.jpg",
            IsSuperior = null,
            LocationId = 3,
            Price = 213.34,
            Nights = 1,
            Adults = 2,
            MealType = "Breakfast",
            HasWifi = true,
            HasParking = true,
            HasPool = true,
            IsKidFriendly = true,
            IsPetFriendly = true,
            RatingText = "Excellent",
            FeaturesJson = null,
            UsefulInfoJson = "[]",
            CheckinFrom = "15:00",
            CheckinTo = "00:00",
            CheckoutUntil = "until 11:00",
            SpokenLanguages = "English, Hungarian, German",
            PaymentPolicy = "Payment policy: The full balance (or remaining amount after prepayment) is On departure day.",
            AcceptedCurrency = "HUF (Ft) , EUR (€)",
            LocalTax = "Local tax: 710 Ft / person / night (1.86 € / person / night)",
            ReceptionHours = "24-hour front desk",
            WellnessHours = "08:00 - 20:00",
            AcceptedCards = new List<string>
            {
                "visa.png",
                "mastercard.png"
            },
            HasWellness = true,
            HasAirConditioning = true,
            HasHalfBoard = true,
            DescriptionHtml = null,
            Description = "105 comfortably furnished rooms are offered by Anna Grand Hotel Balatonfüred to guests looking for accommodation in Balatonfüred...",
            Images = new List<string>
            {
                "hotels/3.jpg",
                "hotels/3.1.jpg",
                "hotels/3.2.jpg"
            }
        },
        new Tours
        {
            Id = 9,
            Name = "Forest Hills Wellness & Spa",
            Stars = 5,
            Rating = 9.5,
            ReviewsCount = 347,
            ImageUrl = "hotels/9.jpg",
            IsSuperior = true,
            LocationId = 1,
            Price = 189.00,
            Nights = 1,
            Adults = 2,
            MealType = "Half-board",
            HasWifi = true,
            HasParking = true,
            HasPool = true,
            IsKidFriendly = true,
            IsPetFriendly = true,
            RatingText = "Exceptional",
            FeaturesJson = null,
            UsefulInfoJson = "[]",
            CheckinFrom = "15:00",
            CheckinTo = "21:00",
            CheckoutUntil = "11:00",
            SpokenLanguages = "English, German, Hungarian",
            PaymentPolicy = "50% prepayment after booking. Remaining amount on arrival.",
            AcceptedCurrency = "HUF (Ft), EUR (€)",
            LocalTax = "Local tax: 2.20 € / person / night",
            ReceptionHours = "24-hour front desk",
            WellnessHours = "09:00 - 21:00",
            AcceptedCards = new List<string>
            {
                "visa.png",
                "mastercard.png"
            },
            HasWellness = true,
            HasAirConditioning = true,
            HasHalfBoard = true,
            DescriptionHtml = null,
            Description = "Boutique wellness hotel in a quiet forest area. Large spa, indoor and outdoor pools, half-board included.",
            Images = new List<string>
            {
                "hotels/9.jpg",
                "hotels/9.1.jpg",
                "hotels/9.2.jpg"
            }
        },
        new Tours
        {
            Id = 10,
            Name = "Balaton Plaza Apartments",
            Stars = 3,
            Rating = 8.7,
            ReviewsCount = 612,
            ImageUrl = "hotels/10.jpg",
            IsSuperior = false,
            LocationId = 1,
            Price = 79.00,
            Nights = 1,
            Adults = 2,
            MealType = "No meals",
            HasWifi = true,
            HasParking = true,
            HasPool = false,
            IsKidFriendly = true,
            IsPetFriendly = false,
            RatingText = "Very good",
            FeaturesJson = null,
            UsefulInfoJson = "[]",
            CheckinFrom = "14:00",
            CheckinTo = "20:00",
            CheckoutUntil = "10:00",
            SpokenLanguages = "English",
            PaymentPolicy = "100% payment on arrival in cash or card.",
            AcceptedCurrency = "HUF (Ft), EUR (€)",
            LocalTax = "Local tax: 1.80 € / person / night",
            ReceptionHours = "08:00 - 20:00",
            WellnessHours = "10:00 - 18:00",
            AcceptedCards = new List<string>
            {
                "visa.png",
                "mastercard.png"
            },
            HasWellness = false,
            HasAirConditioning = true,
            HasHalfBoard = false,
            DescriptionHtml = null,
            Description = "Apartment-style accommodation with kitchenettes and balcony. Close to the beach and promenade.",
            Images = new List<string>
            {
                "hotels/10.jpg",
                "hotels/10.1.jpg",
                "hotels/10.2.jpg"
            }
        },
        new Tours
        {
            Id = 6,
            Name = "Hotel Blaha Lujza Balatonfüred",
            Stars = 4,
            Rating = 9.2,
            ReviewsCount = 1849,
            ImageUrl = "hotels/6.jpg",
            IsSuperior = false,
            LocationId = 1,
            Price = 114.97,
            Nights = 1,
            Adults = 2,
            MealType = "No meals",
            HasWifi = true,
            HasParking = true,
            HasPool = true,
            IsKidFriendly = true,
            IsPetFriendly = false,
            RatingText = "Very good",
            FeaturesJson = null,
            UsefulInfoJson = "[]",
            CheckinFrom = "15:00",
            CheckinTo = "18:00",
            CheckoutUntil = "10:00",
            SpokenLanguages = "English, Hungarian, German",
            PaymentPolicy = "The full balance is payable on arrival.",
            AcceptedCurrency = "HUF (Ft), EUR (€)",
            LocalTax = "Local tax: 710 Ft / person / night (1.86€)",
            ReceptionHours = "24-hour front desk",
            WellnessHours = "07:30 - 20:30",
            AcceptedCards = new List<string>
            {
                "visa.png",
                "mastercard.png"
            },
            HasWellness = true,
            HasAirConditioning = true,
            HasHalfBoard = false,
            DescriptionHtml = null,
            Description = "Renovated hotel near lake Balaton. Big garden pool, wellness area and bar. Popular choice for families and couples.",
            Images = new List<string>
            {
                "hotels/6.jpg",
                "hotels/6.1.jpg",
                "hotels/6.2.jpg"
            }
        },
        new Tours
        {
            Id = 7,
            Name = "Silver Lake Resort",
            Stars = 4,
            Rating = 8.9,
            ReviewsCount = 921,
            ImageUrl = "hotels/7.jpg",
            IsSuperior = false,
            LocationId = 1,
            Price = 129.50,
            Nights = 1,
            Adults = 2,
            MealType = "Breakfast",
            HasWifi = true,
            HasParking = true,
            HasPool = true,
            IsKidFriendly = true,
            IsPetFriendly = true,
            RatingText = "Fabulous",
            FeaturesJson = null,
            UsefulInfoJson = "[]",
            CheckinFrom = "14:00",
            CheckinTo = "20:00",
            CheckoutUntil = "11:00",
            SpokenLanguages = "English, German",
            PaymentPolicy = "Free cancellation up to 7 days before arrival. After that 1 night will be charged.",
            AcceptedCurrency = "EUR (€)",
            LocalTax = "Local tax: 2 € / person / night",
            ReceptionHours = "08:00 - 22:00",
            WellnessHours = "09:00 - 21:00",
            AcceptedCards = new List<string>(),   // у тебя в JSON было accepted_cards_json: "[]"
            HasWellness = true,
            HasAirConditioning = true,
            HasHalfBoard = false,
            DescriptionHtml = null,
            Description = "Lakefront resort with outdoor pool, sauna and spacious rooms. Good option for longer stays and families with kids.",
            Images = new List<string>
            {
                "hotels/7.jpg",
                "hotels/7.1.jpg",
                "hotels/7.2.jpg"
            }
        },new Tours
        {
            Id = 8,
            Name = "Sunrise Marina Hotel",
            Stars = 3,
            Rating = 8.3,
            ReviewsCount = 510,
            ImageUrl = "hotels/8.jpg",
            IsSuperior = false,
            LocationId = 1,
            Price = 98.00,
            Nights = 1,
            Adults = 2,
            MealType = "Breakfast",
            HasWifi = true,
            HasParking = false,
            HasPool = false,
            IsKidFriendly = false,
            IsPetFriendly = false,
            RatingText = "Very good",
            FeaturesJson = null,
            UsefulInfoJson = "[]",
            CheckinFrom = "13:00",
            CheckinTo = "19:00",
            CheckoutUntil = "10:30",
            SpokenLanguages = "English, Hungarian",
            PaymentPolicy = "Payment on arrival. Free cancellation up to 3 days before check-in.",
            AcceptedCurrency = "EUR (€)",
            LocalTax = "Local tax: 1.50 € / person / night",
            ReceptionHours = "07:00 - 21:00",
            WellnessHours = "10:00 - 20:00",
            AcceptedCards = new List<string>
            {
                "visa.png",
                "mastercard.png"
            },
            HasWellness = false,
            HasAirConditioning = true,
            HasHalfBoard = false,
            DescriptionHtml = null,
            Description = "Smaller hotel next to the marina. Simple but clean rooms with breakfast included.",
            Images = new List<string>
            {
                "hotels/8.jpg",
                "hotels/8.1.jpg",
                "hotels/8.2.jpg"
            }
        },
    };
    public static List<Room> Rooms = new List<Room>
{
    new Room { Id = 1, HotelId = 1, Name = "1-Room Suite for 2 Persons", AreaM2 = 45, Bedrooms = 1, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/1.1.jpg", PricePerNight = 0.00 },
    new Room { Id = 2, HotelId = 1, Name = "2-Room Apartment for 2 Persons", AreaM2 = 40, Bedrooms = 2, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/1.2.jpg", PricePerNight = 0.00 },

    new Room { Id = 4, HotelId = 2, Name = "Double Room", AreaM2 = 24, Bedrooms = 1, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/2.2.jpg", PricePerNight = 0.00 },
    new Room { Id = 3, HotelId = 2, Name = "Classic 2-Room Family Suite for 4 Persons (extra bed available)", AreaM2 = 65, Bedrooms = 2, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/2.1.jpg", PricePerNight = 0.00 },

    new Room { Id = 5, HotelId = 3, Name = "Executive 2-Room Suite for 4 Persons", AreaM2 = 36, Bedrooms = 1, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/3.1.jpg", PricePerNight = 0.00 },
    new Room { Id = 6, HotelId = 3, Name = "Deluxe Triple Room", AreaM2 = 22, Bedrooms = 2, Beds = null, HasWifi = false, HasAc = true, Balcony = true, ImageUrl = "rooms/3.2.jpg", PricePerNight = 0.00 },

    new Room { Id = 7, HotelId = 4, Name = "Superior Partial Sea View Double Room", AreaM2 = 27, Bedrooms = 1, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/4.1.jpg", PricePerNight = 0.00 },
    new Room { Id = 8, HotelId = 4, Name = "Superior City View Double Room", AreaM2 = 27, Bedrooms = 1, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/4.2.jpg", PricePerNight = 0.00 },

    new Room { Id = 9, HotelId = 5, Name = "Garden View Mansard 2-Room Suite for 4 Persons", AreaM2 = 50, Bedrooms = 2, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/5.1.jpg", PricePerNight = 0.00 },
    new Room { Id = 10, HotelId = 5, Name = "Basement 1-Room Apartment for 2 Persons ensuite", AreaM2 = 15, Bedrooms = 1, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/5.2.jpg", PricePerNight = 0.00 },

    new Room { Id = 11, HotelId = 6, Name = "Economy Twin Room", AreaM2 = 23, Bedrooms = 1, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/6.1.jpg", PricePerNight = 0.00 },
    new Room { Id = 12, HotelId = 6, Name = "Studio Triple Room with Terrace", AreaM2 = 32, Bedrooms = 2, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/6.2.jpg", PricePerNight = 0.00 },

    new Room { Id = 13, HotelId = 7, Name = "Standard Double Room", AreaM2 = 51, Bedrooms = 2, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/7.1.jpg", PricePerNight = 0.00 },
    new Room { Id = 14, HotelId = 7, Name = "2-Room Suite for 4 Persons (extra bed available)", AreaM2 = 12, Bedrooms = 1, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/7.2.jpg", PricePerNight = 0.00 },

    new Room { Id = 15, HotelId = 8, Name = "1-Room Suite for 2 Persons", AreaM2 = 13, Bedrooms = 1, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/8.1.jpg", PricePerNight = 0.00 },
    new Room { Id = 16, HotelId = 8, Name = "Triple Room", AreaM2 = 22, Bedrooms = 1, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/8.2.jpg", PricePerNight = 0.00 },

    new Room { Id = 17, HotelId = 9, Name = "Superior Twin Room with Terrace (extra bed available)", AreaM2 = 42, Bedrooms = 1, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/9.1.jpg", PricePerNight = 0.00 },
    new Room { Id = 18, HotelId = 9, Name = "Junior 1-Room Suite for 2 Persons (extra bed available)", AreaM2 = 27, Bedrooms = 2, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/9.2.jpg", PricePerNight = 0.00 },

    new Room { Id = 19, HotelId = 10, Name = "Standard Twin Room (extra bed available)", AreaM2 = 27, Bedrooms = 1, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/10.1.jpg", PricePerNight = 0.00 },
    new Room { Id = 20, HotelId = 10, Name = "Twin Room", AreaM2 = 31, Bedrooms = 1, Beds = null, HasWifi = true, HasAc = true, Balcony = true, ImageUrl = "rooms/10.2.jpg", PricePerNight = 0.00 }
};
}