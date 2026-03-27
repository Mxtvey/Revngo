import { matchesFilter } from "./FilterMatch";
import HotelCard from "../components/HotelCard";

export default function HotelsCard({ filters, hotels = [] }) {
  // useEffect с fetch убираем — данные приходят сверху

  const activeFilters = Object.keys(filters).filter(key => filters[key]);

  const filteredHotels = hotels.filter(hotel =>
    activeFilters.every(key => matchesFilter(hotel, key))
  );

  return (
    <div>
      {filteredHotels.map((hotel, index) => (
        <HotelCard key={hotel.id ?? index} hotel={hotel} />
      ))}
    </div>
  );
}