import "./App.css";
import Header from "./Header";
import MenuPage from "./menuPage";

import ShoppingCart from "./cart";
import { ToastContainer } from "react-toastify";
import "./reactToastify.css";

import Header from "./components/Header";
import MenuPage from "./components/MenuPage";
import ShoppingCart from "./components/Cart";
import StickyFooter from "./components/StickyFooter";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import MenuItemDetails from "./menuItemDetails";

function App() {
  const [cartItems, setCartItems] = useState([]);

  return (
    // <div className="App">
    //   <Header />
    //   <ToastContainer position="top-right" autoClose={3000} />
    //   <ShoppingCart></ShoppingCart>
    //   <MenuPage />
    //   <StickyFooter />
    // </div>
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
