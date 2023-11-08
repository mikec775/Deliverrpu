import * as React from "react";
import {
  Box,
  Stack,
  Card,
  CardContent,
  Typography,
  Button,
} from "@mui/material";
import toast, {Toaster} from "react-hot-toast";
import { Link } from "react-router-dom";

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
  {
    id: 2,
    name: "Hamburger",
    description: "juicy hamburger with cheese",
    nutrience: "491kcal",
    preptime: "10min",
    image: "",
    price: 12.99,
  },
  {
    id: 3,
    name: "Fries",
    description:
      "premium Russet Burbank variety potatoes for that fluffy inside, crispy outside taste",
    nutrience: "423kcal",
    preptime: "8min",
    image: "",
    price: 4.99,
  },
];

const MenuPage = ({setCartItems}) => {
    const addToCart = (item) => { 
        setCartItems((curr) => [...curr, item]);
        toast.success(`${item.name} added to cart`, {
            autoClose: 2000,
        });
    }

    return (
      <>
        <Toaster position="bottom-right" reverseOrder={false} />
        <Box sx={{ width: "100%" }}>
          <Stack spacing={1} direction={"column"}>
            {menuItems.map((item) => (
              <Card key={item.id}>
                <CardContent>
                  {/*<Typography variant="h4">{item.name}</Typography>*/}
                  <Typography>
                    <Link to="/menuItemDetails">
                      <Button>
                        <Typography variant="h4" style={{ color: "black" }}>
                          {item.name}
                        </Typography>
                      </Button>
                    </Link>
                  </Typography>
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
                    {" "}
                    Add to Cart
                  </Button>
                </CardContent>
              </Card>
            ))}
          </Stack>
        </Box>
      </>
    );
};

export default MenuPage;
