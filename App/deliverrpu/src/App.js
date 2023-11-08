import "./App.css";
import { useState } from "react";

import "./reactToastify.css";
import Header from "./components/Header";
import MenuPage from "./components/MenuPage";
import ShoppingCart from "./components/Cart";
import StickyFooter from "./components/StickyFooter";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import MenuItemDetails from "./components/MenuItemDetails";


function App() {
  const [cartItems, setCartItems] = useState([]);

  return (
    <div className="App">
      <BrowserRouter>
        <Header />
        <Routes>
          <Route path="/" element={<MenuPage setCartItems={setCartItems} />} />
          <Route path="/menuItemDetails" element={<MenuItemDetails />} />
          <Route
            path="/cart"
            element={
              <ShoppingCart />
            }
          />
        </Routes>
        <StickyFooter />
      </BrowserRouter>
    </div>
  );
}

export default App;
