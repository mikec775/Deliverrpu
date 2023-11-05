import "./App.css";
import MenuPage from "./menuPage";

import ShoppingCart from "./cart"
import { ToastContainer } from "react-toastify";
import "./ReactToastify.css";

function App() {
  return (
    <div className="App">
      <Header></Header>
      <ToastContainer position="top-right" autoClose={3000} />
      <ShoppingCart></ShoppingCart>
      <MenuPage></MenuPage>
    </div>
  );
}

export default App;
