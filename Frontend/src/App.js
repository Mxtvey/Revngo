import { BrowserRouter, Routes, Route } from "react-router-dom";
import Layout from "./components/layout.jsx";
import Home from "./pages/Home.jsx";
import HotelPage from "./pages/HotelPage";
import "./styles/tour.css"

export default function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route element={<Layout />}>
          <Route path="/" element={<Home />} />
          <Route path="/hotel/:id" element={<HotelPage />} />
        </Route>
      </Routes>

    </BrowserRouter>
  );
}