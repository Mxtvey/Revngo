import { useState } from "react";

export default function SidebarSection({ title, optionsText, defaultOpen = true, children }) {
    const [open, setOpen] = useState(defaultOpen);

    return (
        <div className="sidebar-section">
            <button
                type="button"
                className={`section-header ${open ? "active" : ""}`}
                onClick={() => setOpen(v => !v)}
            >
                <span className="arrow">{open ? "⌃" : "⌄"}</span>
                {title}
            </button>

            {optionsText && <div className="opt-count">{optionsText}</div>}

            {open && <div className="section-content">{children}</div>}
        </div>
    );
}