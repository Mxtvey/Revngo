



export default function footer() {
    return (
        <>
            <div class="footer-stats">
                <div>From cozy apartments to 5 star wellness hotels</div>
                <div>Free booking without fine prints</div>
                <div>
                    88% of real guests would recommend RevNGo.com to their friends or family.
                </div>
            </div>
            <div class="footer-columns">
                <div class="footer-col">
                    <h4>About Us</h4>
                    <a href="#">Imprint</a>
                    <a href="#">Feedback</a>
                    <a href="#">Terms of Service</a>
                    <a href="#">Accessibility Statement</a>
                </div>

                <div class="footer-col">
                    <h4>Popular choices</h4>
                    <a href="#">Kid-friendly accomodations</a>
                    <a href="#">Wellness</a>
                    <a href="#">Wellness deals</a>
                    <a href="#">Last minute offers</a>
                </div>

                <div class="footer-col">
                    <h4>For Partners</h4>
                    <button class="list-property">List your property</button>
                    <a href="/admin/login" class="admin-link">Log in as admin</a>
                    <a href="#">Admins – app for owners</a>
                    <a href="#">General Terms and Conditions</a>
                </div>

                <div class="footer-col">
                    <h4>Contact us</h4>
                    <div>Customer service:</div>
                    <div>Email: info@revngo.com</div>
                    <img src="jpg/2023_Facebook_icon.svg" class="contact-icon" />
                </div>
            </div>
            <div class="footer-logos">
                <img src="/jpg/ssl-security.svg" class="logo-small" />
                <img src="/jpg/nevogate_black.svg" class="logo-main" />
            </div>
            <div class="footer-languages">
                <a href="#"><img src="/country/Flag_of_the_Czech_Republic.svg" /> Česky</a>
                <a href="#"><img src="/country/Flag_of_Hungary.svg" /> Magyar</a>
                <a href="#"><img src="/country/Flag_of_Romania.svg" /> Română</a>
                <a href="#"><img src="/country/Flag_of_Slovakia.svg" /> Slovenský</a>
                <a href="#"><img src="/country/Flag_of_Germany.svg" /> Deutsch</a>
                <a href="#"><img src="/country/Flag_of_Poland.svg" /> Polski</a>
                <a href="#"><img src="/country/Flag_of_Croatia.svg" /> Hrvatski</a>
            </div>
            <div class="footer-bottom">
                Copyright 2008 - 2025.
                <a href="#">Privacy Policy</a>
                <a href="#">Report offensive content</a>
            </div>
        </>
    );

}