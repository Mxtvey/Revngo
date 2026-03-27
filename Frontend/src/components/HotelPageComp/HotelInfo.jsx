export default function HotelInfo({ hotel }) {
    return (
        <div className="hotel-info-block">

            <div className="info-icons-row">

                {hotel.is_kid_friendly && (
                    <div className="info-icon">
                        <img src="/jpg/baby.svg" />
                        <span>Baby-friendly</span>
                    </div>
                )}

                {hotel.has_pool && (
                    <div className="info-icon">
                        <img src="/jpg/lotus.png" />
                        <span>Pool</span>
                    </div>
                )}

                <div className="info-icon">
                    <img src="/jpg/air-conditioner.png" />
                    <span>Air-conditioned rooms</span>
                </div>

                {hotel.has_wifi && (
                    <div className="info-icon">
                        <img src="/jpg/wif.png" />
                        <span>Free WiFi</span>
                    </div>
                )}

            </div>


            <div className="info-text-wrapper">
                <div className="info-text collapsed">
                    <p>{hotel.description}</p>
                </div>

                <div className="info-more">
                    See full description ▼
                </div>
            </div>

        </div>
    );
}