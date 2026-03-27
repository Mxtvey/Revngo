export default function HotelServices({ hotel }) {
    return (
        <div className="services-wrapper">
            <h2 className="services-title">Services and features</h2>

            <div className="services-table">
                <div className="service-row">
                    <div className="service-left">Parking</div>
                    <div className="service-right">
                        {hotel.has_parking ? "Available" : "Not available"}
                    </div>
                </div>
                <div className="service-divider"></div>

                <div className="service-row">
                    <div className="service-left">Internet</div>
                    <div className="service-right">
                        {hotel.has_wifi ? "WiFi available" : "No WiFi"}
                    </div>
                </div>
                <div className="service-divider"></div>

                <div className="service-row">
                    <div className="service-left">Leisure, recreation</div>
                    <div className="service-right">Golf course…</div>
                </div>
                <div className="service-divider"></div>

                <div className="service-row">
                    <div className="service-left">
                        Wellness section,<br />
                        relaxation
                    </div>
                    <div className="service-right">
                        <div className="highlight-line">Size: 165 m²</div>
                        <div className="highlight-badge">
                            The guests of the hotel can use it free of charge.
                        </div>
                    </div>
                </div>

                <div className="service-row wellness-second">
                    <div className="service-right">
                        <div className="wellness-photo-block">
                            <div className="service-photo">
                                <img src="/jpg/micro.jpg" alt="Wellness" />
                                <span className="photo-count">14 photo</span>
                            </div>

                            <ul className="service-list">
                                {hotel.wellness_features?.map((feature, index) => (
                                    <li key={index}>{feature}</li>
                                ))}
                            </ul>
                        </div>
                    </div>
                </div>
                <div className="service-divider"></div>

                <div className="service-row">
                    <div className="service-left">General services</div>
                    <div className="service-right">
                        <ul className="service-list">
                            {hotel.kid_services?.map((service, index) => (
                                <li key={index}>{service}</li>
                            ))}
                        </ul>
                        <div className="highlight-badge">
                            Complimentary for children aged 3 and under.
                        </div>
                    </div>
                </div>
                <div className="service-divider"></div>

                <div className="service-row">
                    <div className="service-left">Catering</div>
                    <div className="service-right">
                        Cuisine type in own restaurant:
                        <br />
                        Dining options:
                        <br />
                        <div className="highlight-badge"></div>
                        <div className="highlight-badge">
                            The restaurant is open, and for safety, with extra distance.
                        </div>
                    </div>
                </div>
                <div className="service-divider"></div>

                <div className="service-row">
                    <div className="service-left">Kid-friendly services</div>
                    <div className="service-right">
                        <ul className="service-list">
                            {hotel.kid_friendly_services?.map((service, index) => (
                                <li key={index}>{service}</li>
                            ))}
                        </ul>
                        <div className="highlight-badge">
                            Complimentary for children aged 3 and under.
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
}