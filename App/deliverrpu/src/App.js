import "./App.css";
import Header from "./Header";
import MenuPage from "./menuPage";

import ShoppingCart from "./cart";
import { ToastContainer } from "react-toastify";
import "./ReactToastify.css";
import StickyFooter from "./StickyFooter";

function App() {
  return (
    <div className="App">
      <Header />
      <ToastContainer position="top-right" autoClose={3000} />
      <ShoppingCart></ShoppingCart>
      <MenuPage />
      <StickyFooter />
    </div>
  );
}

export default App;
