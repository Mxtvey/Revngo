export default function HotelTitleComp({ hotel }) {
    return (
        <div>
            <div className="page-header">
                <div className="breadcrumbs">
                    <a href="/">Homepage</a>
                    <span>{hotel.name}</span>
                </div>
            </div>

            <div className="container-hotel-title">
                <div className="title-left">
                    <h1 className="hotel-title-full">
                        {hotel.name} ★{hotel.stars}
                    </h1>


                </div>

                <div className="rating-box">
                    <div className="rating-texts">
                        <div className="rating-label">Very good</div>
                        <div className="rating-count">
                            {hotel.reviews_count} reviews
                        </div>
                    </div>

                    <div className="rating-circle">{hotel.rating}</div>
                </div>
            </div>
        </div>
    );
}