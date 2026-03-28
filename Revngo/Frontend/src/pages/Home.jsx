import { useState, useEffect } from "react";
import Filterbar from '../components/filterbar';
import PageHeader from '../components/PageHeader';
import HotelsCard from "../components/HotelsCard";
import Sidebar from '../components/sidebar/Sidebar';

function Home() {
    const [filters, setFilters] = useState({});
    const [hotels, setHotels] = useState([]);

    useEffect(() => {
        fetch("tours.json")
            .then(res => res.json())
            .then(data => setHotels(Array.isArray(data) ? data : (data.hotels ?? [])));
    }, []);

    return (
        <>
            <Filterbar />
            <PageHeader />
            <div className="sidebar-divider"></div>
            <div className="layout">
                <Sidebar filters={filters} setFilters={setFilters} hotels={hotels} />
                <HotelsCard filters={filters} hotels={hotels} />  { }
            </div>
        </>
    );
}

export default Home;