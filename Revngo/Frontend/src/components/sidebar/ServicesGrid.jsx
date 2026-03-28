
export default function ServicesGrid({ items, onToggle, value = {} }) {
    return (
        <div className="services-grid">
            {items.map(item => (
                <div key={item.key} className="service">
                    <button
                        type="button"
                        className="service-item"
                        data-param={item.key}
                        onClick={() => onToggle?.(item.key)}
                        aria-pressed={!!value[item.key]}
                    >
                        <img src={item.icon} alt={item.label} />
                    </button>
                    {item.label} <span className="count">({item.count})</span>
                </div>
            ))}
        </div>
    );
}