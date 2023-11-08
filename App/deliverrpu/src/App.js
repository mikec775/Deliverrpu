import "./App.css";
import Header from "./Header";
import MenuPage from "./menuPage";
import "./reactToastify.css";
import StickyFooter from "./StickyFooter";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import MenuItemDetails from "./menuItemDetails";

function App() {
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
