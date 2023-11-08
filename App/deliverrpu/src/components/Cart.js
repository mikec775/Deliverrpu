import { List, ListItem, Button, Typography, Link } from "@mui/material";
import toast, { Toaster } from "react-hot-toast";
import { useState } from "react";

const menuItems = [
  {
    id: 1,
    name: "Fried Chicken",
    description: "best fried chicken in town",
    nutrience: "260kcal",
    preptime: "15min",
    image: "", //image path
    price: 10.99,
  },
];

const ShoppingCart = () => {
  const [cartItems, setCartItems] = useState(menuItems);
  const removeFromCart = (index) => {
    const updatedCart = [...cartItems];
    const removedItem = cartItems[index];
    updatedCart.splice(index, 1);
    setCartItems(updatedCart);

    toast.success(`${removedItem.name} removed from cart`, {
      autoClose: 2000,
    });
  };

  const calculateTotal = () => {
    return cartItems.reduce((total, item) => total + item.price, 0);
  };


  return (
    <>
      <Toaster position="bottom-right" reverseOrder={false} />
      <Typography variant="h2">My Cart</Typography>
      <List>
        {cartItems.map((item, index) => (
          <ListItem key={index} sx={{ display: "flex" }}>
            <Typography>
              <Link href="/menuItemDetails">
                {item.name} - ${item.price}
              </Link>
            </Typography>
            <Button
              variant="contained"
              color="error"
              onClick={() => removeFromCart(index)}
              sx={{ ml: "auto" }}
            >
              Remove
            </Button>
          </ListItem>
        ))}
      </List>
      <Typography>Total: $ {calculateTotal()}</Typography>
    </>
  );
};

export default ShoppingCart;
