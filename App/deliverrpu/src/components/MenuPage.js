import { useState, useEffect } from "react";
import {
  Box,
  Stack,
  Card,
  CardContent,
  Typography,
  Button,
} from "@mui/material";
import { Link } from "react-router-dom";
import toast, {Toaster} from "react-hot-toast";

const MenuPage = ({ setCartItems}) => {
  const [menuItems, setMenuItems] = useState([]);

  useEffect(() => {
    return () => {
      fetch("https://localhost:7278/api/menu")
        .then((response) => response.json())
        .then((data) => {
          console.log(data);
          setMenuItems(data);
        })
        .catch((err) => console.log(err));
    };
  }, []);

  const addToCart = (item) => {
    setCartItems((curr) => [...curr, item]);
    console.log(item);
    toast.success(`${item.menuName} added to cart`, {
      autoClose: 2000,
    });
  };

  return (
    <>
      <Toaster position="bottom-right" reverseOrder={false} />
      <Box sx={{ width: "100%" }}>
        <Stack spacing={1} direction={"column"}>
          {menuItems.map((item) => {
            return (
              <Card key={item.menuId}>
                <CardContent>
                  <Typography variant="h4">{item.menuName}</Typography>
                  <Link to="/menuItemDetails">
                    <Button onClick={() => console.log("Viewed")}>
                      View Details
                    </Button>
                  </Link>
                  <Button
                    variant="contained"
                    color="primary"
                    onClick={() => addToCart(item)}
                  >
                    Add to Cart
                  </Button>
                </CardContent>
              </Card>
            )
          })}
        </Stack>
      </Box>
    </>
  );
};

export default MenuPage;
