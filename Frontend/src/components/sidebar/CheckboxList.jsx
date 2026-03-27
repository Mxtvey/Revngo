export default function CheckboxList({ items, value = {}, onChange }) {
    return (
        <>
            {items.map(item => (
                <label
                    key={item.key}
                    className={`sidebar-checkbox${item.disabled ? " disabled" : ""}`}
                >
                    <input
                        type="checkbox"
                        disabled={item.disabled}
                        checked={!!value[item.key]}
                        onChange={() => onChange?.(item.key)}
                    />
                    {item.label}
                    {typeof item.count === "number" && (
                        <span className="count"> ({item.count})</span>
                    )}
                </label>
            ))}
        </>
    );
}