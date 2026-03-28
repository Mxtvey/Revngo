export default function HotelReviews({ hotel }) {
    return (
        <div className="reviews-section">
            <h2>Guest reviews</h2>

            <div className="rating-box">
                <div className="rating-number">{hotel.rating}</div>

                <div className="rating-info">
                    <div className="rating-title">Very good</div>

                    <div className="rating-subtitle">
                        based on {hotel.reviews_count} reviews.
                    </div>
                </div>
            </div>

            <div className="reviews-link">
                <a href="#">All reviews ({hotel.reviews_count})</a>
            </div>
        </div>
    );
}