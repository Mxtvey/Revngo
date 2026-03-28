const matchers = {

    boolean: (hotel, key) => hotel[key] === true,

    meal_type: (hotel, val) => hotel.meal_type === val,
    rating_text: (hotel, val) => hotel.rating_text === val,
    stars: (hotel, val) => hotel.stars === Number(val),
    rating: (hotel, val) => hotel.rating >= Number(val),
    card: (hotel, val) => hotel.accepted_cards?.includes(val) ?? false,
    language: (hotel, val) => hotel.spoken_languages?.includes(val) ?? false,
    payment_policy: (hotel) => hotel.payment_policy?.toLowerCase().includes("payable on site") ?? false,

    price: (hotel, val) => {
        const p = hotel.price;
        if (val.startsWith("<")) return p < Number(val.slice(1));
        if (val.startsWith(">")) return p > Number(val.slice(1));
        const [min, max] = val.split("-").map(Number);
        return p >= min && p <= max;
    },
};

export const matchesFilter = (hotel, key) => {
    if (!key.includes(":")) return matchers.boolean(hotel, key);
    const [prefix, value] = key.split(":");
    return matchers[prefix]?.(hotel, value) ?? false;
};