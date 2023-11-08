import React from 'react';
import {Container, Box, Typography} from "@mui/material";

const menuItems = [
    {
        name: "Fried Chicken",
        description: "best fried chicken in town",
        nutrience: "260kcal",
        preptime: "15min",
        image: "https://thissillygirlskitchen.com/wp-content/uploads/2020/05/Southern-Fried-Chicken-20.jpg", //image path
        price: 10.99,
    },
]

const review = [
    {
        ReviewText: "The food taste like food, Good!",
        ReviewRating: 5,
        userid: 1,
        OrderID: 1,
        MenuID: 1
    }
]

function MenuItemDetails() {

    return (
        <Container sx={{
            display: "flex",
            flexDirection: "column",
            alignItems: "center",
        }}>
            <Typography variant="h6" >{menuItems[0].name}</Typography>
            <Box><img src={menuItems[0].image} alt="no image yet"/></Box>
            <Box>
                 <Typography variant="body1" >{menuItems[0].description}</Typography>
                 <Typography variant="body1" >{menuItems[0].nutrience}</Typography>
                 <Typography variant="body1" >{menuItems[0].preptime}</Typography>
                 <Typography variant="body1" >{menuItems[0].price}</Typography>
            </Box>
            <Box>
                <Typography variant="h6"> {review[0].ReviewText} - {review[0].ReviewRating}</Typography>
            </Box>
        </Container>
    );
}

export default MenuItemDetails;