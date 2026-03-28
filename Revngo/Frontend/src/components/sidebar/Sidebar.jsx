import React, { useEffect, useState, useCallback } from "react";
import SidebarSection from "./SidebarSection";
import ServicesGrid from "./ServicesGrid";
import CheckboxList from "./CheckboxList";
import { matchesFilter } from "../FilterMatch";

export default function Sidebar({ filters = {}, setFilters, hotels = [] }) {
    const [sections, setSections] = useState([]);

    useEffect(() => {
        fetch("/tours.json")
            .then(res => res.json())
            .then(data => setSections(data.sections || data))
    }, []);

    const toggle = useCallback((key) => {
        setFilters(prev => ({ ...prev, [key]: !prev[key] }));
    }, [setFilters]);


    const countForFilter = (key) => {
        const activeFilters = Object.keys(filters).filter(k => filters[k] && k !== key);
        const result = hotels.filter(hotel => {
            const passes = [...activeFilters, key].every(k => matchesFilter(hotel, k));
            return passes;
        });
        return result.length;
    };

    const sectionsWithCounts = sections.map(section => ({
        ...section,
        items: section.items.map(item => ({
            ...item,
            count: countForFilter(item.key),
        })),
    }));

    return (
        <div className="sidebar">
            {sectionsWithCounts.map(section => (
                <SidebarSection
                    key={section.key}
                    title={section.title}
                    optionsText={section.optionsText}
                    defaultOpen={true}
                >
                    {section.type === "services" ? (
                        <ServicesGrid items={section.items} value={filters} onToggle={toggle} />
                    ) : (
                        <CheckboxList items={section.items} value={filters} onChange={toggle} />
                    )}
                </SidebarSection>
            ))}
        </div>
    );
}