import "./App.css";
import {useState} from "react";

import { ToastContainer } from "react-toastify";
import "./reactToastify.css";

import Header from "./components/Header";
import MenuPage from "./components/MenuPage";
import ShoppingCart from "./components/Cart";
import StickyFooter from "./components/StickyFooter";

function App() {
  const [cartItems, setCartItems] = useState([]);

  return (
    <div className="App">
      <Header />
      <MenuPage setCartItems={setCartItems} />
      <ToastContainer position="top-right" autoClose={3000} />
      <ShoppingCart cartItems={cartItems} setCartItems={setCartItems}></ShoppingCart>
      <StickyFooter />
    </div>
  );
}

export default App;
