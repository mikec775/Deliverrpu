import "./App.css";
import "./reactToastify.css";
import Header from "./components/Header";
import MenuPage from "./components/MenuPage";
import StickyFooter from "./components/StickyFooter";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import MenuItemDetails from "./components/MenuItemDetails";

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Header />
        <Routes>
          <Route>
            <Route path="/" element={<MenuPage />} />
            <Route path="/menuPage" element={<MenuPage />} />
            <Route path="/menuItemDetails" element={<MenuItemDetails />} />
          </Route>
        </Routes>
        <StickyFooter />
      </BrowserRouter>
    </div>
  );
}

export default App;
