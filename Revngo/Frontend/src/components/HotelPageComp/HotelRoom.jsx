export default function RoomCard({ room }) {
    return (
        <div className="room-card">
            <div className="room-top">
                <div className="urody">
                    <img src={`/images/${room.image_url}`} alt={room.name} />
                </div>

                <div className="room-info">
                    <h3 className="room-title">{room.name}</h3>

                    <div className="room-specs">
                        <span className="spec">
                            <img src="/jpg/arrows-expand-svgrepo-com.svg" alt="" />
                            {room.area_m2} m²
                        </span>

                        <span className="spec">
                            <img src="/jpg/bed-svgrepo-com.svg" alt="" />
                            {room.bedrooms} bedroom(s)
                        </span>
                    </div>

                    <div className="room-features">
                        {room.has_wifi && (
                            <div>
                                <img src="/jpg/wif.png" alt="" /> WiFi
                            </div>
                        )}

                        {room.has_ac && (
                            <div>
                                <img src="/jpg/air-conditioner.png" alt="" /> Air conditioning
                            </div>
                        )}

                        {room.balcony && (
                            <div>
                                <img src="/jpg/balcony-svgrepo-com.svg" alt="" /> Balcony/Terrace
                            </div>
                        )}
                    </div>
                </div>
            </div>
        </div>
    );
}