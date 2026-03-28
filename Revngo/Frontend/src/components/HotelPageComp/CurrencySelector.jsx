export default function CurrencySelector() {
    return (
        <div className="bottom-bar">
            <div className="currency-selector">
                <button className="currency-btn">
                    <img
                        src="/jpg/coin-svgrepo-com.svg"
                        className="cur-icon"
                        alt="currency"
                    />
                    EUR (€) ▼
                </button>
            </div>
        </div>
    );
}