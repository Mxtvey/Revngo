export default function HotelGallery({ hotel }) {
    return (
        <div className="hotel-gallery">
            <div className="gallery-main">
                <img src={`/images/${hotel.images[0]}`} alt="Main photo" />
                <div className="gallery-count">81 photos</div>
            </div>

            <div className="gallery-row">
                <img src={`/images/${hotel.images[1]}`} alt="" />
                <img src={`/images/${hotel.images[2]}`} alt="" />
            </div>
        </div>
    );
}