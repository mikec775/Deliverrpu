import toast from "react-hot-toast";

export 

const ShoppingCart = ({cartItems, setCartItems}) => {
    // const [cartItems, setCartItems] = useState([]);

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

