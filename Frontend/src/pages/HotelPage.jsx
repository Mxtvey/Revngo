import { useParams } from "react-router-dom";


import Filterbar from "../components/filterbar";
import HotelTitleComp from "../components/HotelPageComp/hotelTitleComp";
import HotelGallery from "../components/HotelPageComp/HotelGallery";
import HotelInfo from "../components/HotelPageComp/HotelInfo";
import HotelReview from "../components/HotelPageComp/HotelReview";
import RoomsList from "../components/HotelPageComp/RoomList";
import CurrencySelector from "../components/HotelPageComp/CurrencySelector";
import HotelPolicies from "../components/HotelPageComp/HotelPolices";
import BookingPanel from "../components/HotelPageComp/BookingPanel";
import HotelServices from "../components/HotelPageComp/HotelService";
import HotelUsefulInfo from "../components/HotelPageComp/HotelUsefulInfo";




import { useEffect, useState } from "react";


export default function HotelPage() {
    const { id } = useParams();

    const [hotel, setHotel] = useState(null);
    const [rooms, setRooms] = useState([]);

    useEffect(() => {
        fetch("/tours.json")
            .then(res => res.json())
            .then(data => {
                const hotels = Array.isArray(data) ? data : (data.hotels ?? []);
                const foundHotel = hotels.find(h => h.id === Number(id));
                setHotel(foundHotel || null);
            });
        fetch("/rooms.json")
            .then(res => res.json())
            .then(data => {
                const allRooms = Array.isArray(data) ? data : (data.rooms ?? []);
                const filteredRooms = allRooms.filter(
                    room => Number(room.hotel_id) === Number(id)
                );
                setRooms(filteredRooms);
            });
    }, [id]);
    if (!hotel) {
        return <div>Loading...</div>;
    }




    return (
        <>
            <div className="page-container">
                <Filterbar />
                <HotelTitleComp hotel={hotel} />
                <div className="sidebar-divider"></div>
                <div className="hotel-main-grid">
                    <div className="left-column">
                        <HotelGallery hotel={hotel} />
                        <HotelInfo hotel={hotel} />
                        <HotelReview hotel={hotel} />
                        <RoomsList rooms={rooms} />
                        <HotelServices hotel={hotel} />
                        <HotelUsefulInfo hotel={hotel} />
                        <HotelPolicies hotel={hotel} />
                        <CurrencySelector />
                    </div>
                    <div className="right-column">
                        <BookingPanel hotel={hotel} />
                    </div>
                </div>
            </div>
            <button className="back-top">↑</button>

        </>
    );
}