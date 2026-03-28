export default function PageHeader() {
    return (
        <div class="page-header">
            <div class="breadcrumbs">
                <div>
                    <a href="#">Homepage</a> &gt;
                    <a href="#">Hungary</a> &gt;
                    <a href="#">Veszprém county</a> &gt;
                    <a href="#">Lake Balaton</a> &gt;
                    <a href="#">Northern Lake Balaton</a> &gt;
                    <a href="#">Balatonfüred</a>
                </div>
                <span>Hotels</span>
            </div>

            <h1 class="page-title">Balatonfüred hotels</h1>


            <div class="subinfo">

                <div class="subinfo-left">
                    <div class="results-count">
                        12 results (+38 results in a 30 km vicinity)
                        <a href="#" class="map-view">map view</a>
                    </div>

                    <div class="rating-line">
                        <span class="rating-box">9.9</span>
                        <span class="reviews"
                        >12932 By ratings Balatonfüred
                            <strong>Excellent</strong> destination!</span
                        >
                        <span class="tag">✨ clean</span>
                        <span class="tag">😌 calm</span>
                        <span class="tag">🏢 modern</span>
                        <span class="tag">🧭 1343 program</span>
                    </div>
                </div>
                <div class="subinfo-right">
                    <button class="sort-btn">≡ Our recommendation ▼</button>
                </div>
            </div>
        </div>

    );
}