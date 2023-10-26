import * as React from "react";
import { Box, Stack, Card, CardContent, Typography } from "@mui/material";

const menuItems = [
  {
    name: "Fried Chicken",
    description: "best fried chicken in town",
    nutrience: "260kcal",
    preptime: "15min",
    image: "", //image path
    price: 10.99,
  },
  {
    name: "Hamburger",
    description: "juicy hamburger with cheese",
    nutrience: "491kcal",
    preptime: "10min",
    image: "",
    price: 12.99,
  },
  {
    name: "Fries",
    description:
      "premium Russet Burbank variety potatoes for that fluffy inside, crispy outside taste",
    nutrience: "423kcal",
    preptime: "8min",
    image: "",
    price: 4.99,
  },
];

const MenuPage = () => {
  return (
    <Box sx={{ width: "100%" }}>
      <Stack spacing={1} direction={"column"}>
        {menuItems.map((item) => (
          <Card>
            <CardContent>
              <Typography variant="h4">{item.name}</Typography>
            </CardContent>
          </Card>
        ))}
      </Stack>
    </Box>
  );
};

export default MenuPage;
