import toast from "react-hot-toast";

export const addToCart = (item, cartItems, setCartItems) => {
  const updatedCart = [...cartItems, item];
  setCartItems(updatedCart);
  //if called
  console.log("added");
  toast.success(`${item.name} added to the cart`, {
    position: "top-right",
    autoClose: 2000,
  });
};

const ShoppingCart = ({ cartItems, setCartItems }) => {
  // Check if cartItems is defined
  if (!cartItems) {
    return (
      <div>
        <h1>Shopping Cart</h1>
        <p>No items in the cart.</p>
      </div>
    );
  }

  const removeFromCart = (index) => {
    const updatedCart = [...cartItems];
    const removedItem = cartItems[index];
    updatedCart.splice(index, 1);
    setCartItems(updatedCart);

    toast.success(`${removedItem.name} removed from cart`, {
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
      <p>Total: $ {calculateTotal()}</p>
    </div>
  );
};

export default ShoppingCart;
