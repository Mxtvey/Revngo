export default function HotelPolicies({ hotel }) {
    return (
        <div className="policies-wrapper">
            <h2 className="policies-title">General Policies</h2>

            <div className="policies-table">
                <div className="policies-row">
                    <div className="pol-left">Check-in</div>
                    <div className="pol-right">
                        {hotel.checkin_from} - {hotel.checkin_to}
                    </div>
                </div>
                <div className="pol-divider"></div>

                <div className="policies-row">
                    <div className="pol-left">Check out</div>
                    <div className="pol-right">{hotel.checkout_until}</div>
                </div>
                <div className="pol-divider"></div>

                <div className="policies-row">
                    <div className="pol-left">Spoken languages</div>
                    <div className="pol-right">{hotel.spoken_languages}</div>
                </div>
                <div className="pol-divider"></div>

                <div className="policies-row">
                    <div className="pol-left">
                        Full price / remaining amount after prepayment - due date
                    </div>
                    <div className="pol-right">{hotel.payment_policy}</div>
                </div>
                <div className="pol-divider"></div>

                <div className="policies-row">
                    <div className="pol-left">Accepted currency</div>
                    <div className="pol-right">{hotel.accepted_currency}</div>
                </div>
                <div className="pol-divider"></div>

                <div className="policies-row">
                    <div className="pol-left">Accepted cards</div>
                    <div className="pol-right pol-cards">
                        {hotel.accepted_cards?.map((card, index) => (
                            <img
                                key={index}
                                src={`/jpg/${card}`}
                                className="pol-card"
                                alt={card}
                            />
                        ))}
                    </div>
                </div>
                <div className="pol-divider"></div>

                <div className="policies-row">
                    <div className="pol-left">Local tax</div>
                    <div className="pol-right">{hotel.local_tax}</div>
                </div>
                <div className="pol-divider"></div>

                <div className="policies-row">
                    <div className="pol-left">Reception</div>
                    <div className="pol-right">{hotel.reception_hours}</div>
                </div>
                <div className="pol-divider"></div>

                <div className="policies-row">
                    <div className="pol-left">Wellness services</div>
                    <div className="pol-right">
                        08:00 - 21:00
                        <br />
                        A wellness részleget a szálláshely vendégei ingyenesen
                        használhatják.
                    </div>
                </div>
                <div className="pol-divider"></div>

                <div className="policies-row">
                    <div className="pol-left">Business operator</div>
                    <div className="pol-right">
                        <a href="#">Fortrend Hotel Kft.</a>
                    </div>
                </div>
            </div>
        </div>
    );
}