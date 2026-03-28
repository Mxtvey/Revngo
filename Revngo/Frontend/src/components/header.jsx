export default function Header() {
    return (
        <header className="header">
            <div class="top-header">
                <div class="container">
                    <div class="top-header-content">
                        <div class="logo">
                            <img src="/headerlogo/header-logo-revngo.svg" />
                            <img src="/headerlogo/slogan-en.svg" class="slogan" />
                        </div>

                        <div class="right-menu">
                            <a href="#">For partners</a>
                            <img
                                src="country/flag-for-flag-united-kingdom-svgrepo-com.svg"
                                class="flag"
                            />
                            <span class="currency">EUR</span>
                            <a href="#" class="customer-service">Customer service</a>
                            <a href="/auth/registr.html" class="login-btn">LOGIN</a>
                        </div>
                    </div>
                </div>
            </div>
        </header>
    );
}