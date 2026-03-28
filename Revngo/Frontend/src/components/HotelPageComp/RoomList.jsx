import RoomCard from "./HotelRoom";

export default function RoomsList({ rooms }) {
    return (
        <div>
            <h2 className="rooms-title">Rooms, prices</h2>

            {rooms.map((room) => (
                <RoomCard key={room.id} room={room} />
            ))}

        </div>
    );
}