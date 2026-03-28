export default function filterbar() {
    return (
        <div class="filters-bar">
            <div class="container filters-content">
                <input
                    type="text"
                    class="filter-input destination"
                    placeholder="Balatonfüred"
                />
                <div class="dates-wrapper">
                    <input
                        type="date"
                        class="date-field checkin-field"
                        placeholder="Check in"
                    />
                    <input
                        type="date"
                        class="date-field checkout-field"
                        placeholder="Check out"
                    />
                </div>

                <div class="filter-guests">
                    <img src="jpg/man.png" class="guest-icon" alt="" />
                    2
                    <img src="jpg/children.png" class="child-icon" alt="" />
                    0 ▼
                </div>

                <button type="button" class="search-btn">Search</button>
            </div>
        </div>

    );
}