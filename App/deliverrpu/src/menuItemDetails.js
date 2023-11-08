import React from 'react';
import {Container, Box, Typography} from "@mui/material";
import {createTheme, responsiveFontSizes, ThemeProvider} from '@mui/material/styles';

let theme = createTheme();
theme = responsiveFontSizes(theme);


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
            // outlineStyle: "solid",
            marginTop: "2%",
            width: "20%",
            borderRadius: "25px"
        }}>
            <ThemeProvider theme={theme}>
                <Typography variant="h6" style={{padding: "5px" , outlineStyle: "solid", margin: "5%", width: "90%"}}>{menuItems[0].name}</Typography>
                <Box><img style={{ width: "100%", height: "auto", maxWidth: "260px", maxHeight: "500px", marginTop: "2%"}} src={menuItems[0].image} alt="no image yet"/></Box>
                <Box style={{outlineStyle: "solid", width: "90%", marginTop: "2%"}}>
                     <Typography variant="body1" >{menuItems[0].description}</Typography>
                     <Typography variant="body1" >{menuItems[0].nutrience}</Typography>
                     <Typography variant="body1" >{menuItems[0].preptime}</Typography>
                     <Typography variant="body1" >{menuItems[0].price}</Typography>
                </Box>
                <Box style={{outlineStyle: "solid", width: "90%", marginTop: "5%", marginBottom: "5%"}}>
                    <Typography variant="h6"> {review[0].ReviewText}</Typography>
                    <Typography variant="h6"> {review[0].ReviewRating} Star </Typography>
                </Box>
            </ThemeProvider>
        </Container>

    );
}

export default MenuItemDetails;