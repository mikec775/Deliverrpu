import React, { useState } from "react";

const ShoppingCart = () => {
    const [cartItems, setCartItems] = useState([]);

    const addToCart = (item) => {
        setCartItems([...cartItems, item]);

        toast.success(`${item.name} added to the cart`, {
            position: "top-right",
            autoClose: 2000,
        });

    };

  
    const removeFromCart = (index) => {
        const updatedCart = [...cartItems];
        updatedCart.splice(index, 1);
        setCartItems(updatedCart);

        toast.success(`${item.name} removed the cart`, {
            position: "top-right",
            autoClose: 2000,
        });

    };

   
    const calculateTotal = () => {
        return cartItems.reduce((total, item) => total + item.price, 0);
    };

    return (
        <div>
            <h1>Shopping Cart</h1>
            <ul>
                {cartItems.map((item, index) => (
                    <li key={index}>
                        {item.name} - ${item.price}
                        <button onClick={() => removeFromCart(index)}>Remove</button>
                    </li>
                ))}
            </ul>
            <p>Total: ${calculateTotal()}</p>
        </div>
    );
};

export default ShoppingCart;
