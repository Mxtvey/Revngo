import { Link } from "react-router-dom";

export default function BookingPanel({ hotel }) {
    return (
        <div className="booking-panel">
            <div className="booking-input">
                Enter a date for exact prices!
            </div>

            <div className="booking-room">
                <span>1 × Standard room</span>
                <span className="room-price">{hotel.price} €</span>
            </div>

            <hr className="divider" />

            <div className="price-row">
                <div className="price-left">Guide price:</div>

                <div className="price-right">
                    <div className="big-price">{hotel.price} €</div>

                    <div className="small-note">
                        {hotel.adults} adults, {hotel.meal_type}
                    </div>

                    <div className="small-note">
                        Includes taxes
                    </div>
                </div>
            </div>

            <Link to={`/booking?hotel=${hotel.id}`}>
                <button className="booking-submit">
                    Select
                </button>
            </Link>
        </div>
    );
}