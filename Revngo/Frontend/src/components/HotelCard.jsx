import '../styles/styles.css';

export default function HotelCard({ hotel }) {
    const imgPath = `/images/${hotel.images[0]}`;

    return (

        <div className="hotel-card">
            <div className="hotel-card__image">
                <a href={`/tour/details?id=${hotel.id}`}>
                    {imgPath && (
                        <img
                            src={imgPath}
                            alt={hotel.Name}
                        />
                    )}
                </a>
            </div>

            <div className="hotel-card__content">
                <div className="hotel-card__header">
                    <div className="hotel-left">
                        <h2 className="hotel-title">
                            <a href={`/hotel/${hotel.id}`}>
                                {hotel.name}
                            </a>
                        </h2>

                        <div className="hotel-icons">
                            <img src="/jpg/wif.png" alt="wifi" />
                            <img src="/jpg/parking.png" alt="parking" />
                            <img src="/jpg/pool.png" alt="pool" />
                            <img src="/jpg/paw-1-svgrepo-com.svg" alt="pets" />
                        </div>
                    </div>

                    <div className="hotel-right">
                        <div className="rating-row">
                            <div className="rating-info">
                                <div className="rating-text">{hotel.ratingText}</div>
                                <div className="rating-reviews">{hotel.reviewsCount} reviews</div>
                            </div>
                            <div className="rating-value">{hotel.rating}</div>
                        </div>

                        <div className="hotel-price-block">
                            <div className="price">{hotel.price} €</div>

                            <div className="price-desc">
                                <div>{hotel.nights} nights</div>
                                <div>{hotel.adults} adults • {hotel.mealType}</div>
                            </div>

                            <a href={`/tour/details?id=${hotel.id}`} className="hotel-view-btn">
                                View
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    );
}