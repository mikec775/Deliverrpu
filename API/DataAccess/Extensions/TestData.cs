using DataAccess.Models;

namespace DataAccess.Extensions
{
    public static class TestData
    {
        public static IEnumerable<User> GetUsers => new User[] {
            new User
            {
                UserID = "1",
                Username = "User1",
                Email = "email1@gmail.com"
            },
            new User
            {
                UserID = "2",
                Username = "nyablsley0",
                Email = "nberzon0@wordpress.org",
                PasswordHash =  ""
            },
            new User
            {
                UserID= "3",
                Username = "kburgott1",
                Email = "spappin1@163.com",
                PasswordHash =  ""
            },
            new User
            {
                UserID = "4",
                Username = "gmcanalley2",
                Email = "mlawee2@pen.io",
                PasswordHash =  ""
            },
            new User
            {
                UserID = "5",
                Username = "larpin3@nasa.gov",
                Email = "eu.erat.semper@protonmail.org",
                PasswordHash =  ""
            }
        };
        public static IEnumerable<Menu> GetMenus => new Menu[]
        {
            new Menu
            {
                MenuId = "1",
                MenuName = "Fried Chicken",
                MenuDescription = "Best fried chicken in town",
                MenuNutrience = "260kcal",
                MenuPrepTime = 15,
                MenuImage = "",
                MenuPrice = 10.99m
            },
            new Menu
            {
                MenuId = "2",
                MenuName = "Hamburger",
                MenuDescription = "juicy hamburger with cheese",
                MenuNutrience = "491kcal",
                MenuPrepTime = 10,
                MenuImage = "",
                MenuPrice = 12.99m
            },
            new Menu
            {
                MenuId = "3",
                MenuName = "Fries",
                MenuDescription = "Premium Russet Burbank variety potatoes for that fluffy inside, crispy outside taste",
                MenuNutrience = "432kcal",
                MenuPrepTime = 8,
                MenuImage = "",
                MenuPrice = 4.99m
            }
        };
        public static IEnumerable<MenuCategory> GetMenuCategories => new MenuCategory[] {
            new MenuCategory
            {
                CategoryId = "1",
                Category = "Burgers",
                MenuId = "2",
            },
            new MenuCategory
            {
                CategoryId = "2",
                Category = "Sides",
                MenuId = "3",
            },
            new MenuCategory {
                CategoryId = "3",
                Category = "Chicken",
                MenuId= "1",
            }

        };
        public static IEnumerable<UserPaymentDetails> GetUserPaymentDetails => new UserPaymentDetails[]
        {
            new UserPaymentDetails()
            {
                CardId = "1",
                CardNumber = 5020751290843793,
                NameOnCard = "Rebekah Matevushev",
                PaymentAddress = "50 Graceland Avenue, Room 871",
                ExpiryDate = new DateTime(2024, 9, 13),
                UserId = "1",
            },
            new UserPaymentDetails()
            {
                CardId = "2",
                CardNumber = 6331105501692333,
                NameOnCard = "Henrik Cheves",
                PaymentAddress = "56 Becker Hill, Apt 814",
                ExpiryDate = new DateTime(2025, 4, 7),
                UserId= "2",
            },
            new UserPaymentDetails()
            {
                CardId = "3",
                CardNumber = 5100179478445091,
                NameOnCard = "Mitchel	0785 Maple Drive, Ulrica Rikel",
                PaymentAddress = "Apt 1652",
                ExpiryDate = new DateTime(2027, 7, 11),
                UserId = "2"
            }
        };
        public static IEnumerable<UserAddress> GetUserAddresses => new UserAddress[]
        {
            new UserAddress()
            {
                AddressId = "1",
                Address = "Suite 56 49047 Holmberg Parkway",
                AddressLabel = "Home address",
                UserId = "1",
            },
            new UserAddress()
            {
                AddressId = "2",
                Address = "PO Box 95686 7324 Acker Place",
                AddressLabel = "Word address",
                UserId = "1",
            },
            new UserAddress()
            {
                AddressId = "3",
                Address = "Apt 510 97 Southridge Hill",
                AddressLabel = "Friend address",
                UserId = "3",
            }
        };
        public static IEnumerable<Order> GetOrders => new Order[]
        {
            new Order()
            {
                OrderId = "1",
                OrderDate = new DateTime(2024, 2, 1),
                TotalPrice = 33,
                UserAddressId = "1",
                UserId = "1",
            },
            new Order()
            {
                OrderId = "2",
                OrderDate = new DateTime(2023, 4, 24),
                TotalPrice = 26,
                UserAddressId = "2",
                UserId = "1",
            },
            new Order()
            {
                OrderId = "3",
                OrderDate = new DateTime(2023, 8, 6),
                TotalPrice = 17,
                UserAddressId = "2",
                UserId = "1",
            },
            new Order()
            {
                OrderId = "4",
                OrderDate = new DateTime(2023, 11, 2),
                TotalPrice = 88,
                UserAddressId = "1",
                UserId = "1",
            },
            new Order()
            {
                OrderId = "5",
                OrderDate = new DateTime(2023, 7, 12),
                TotalPrice = 43,
                UserAddressId = "3",
                UserId = "3",
            },
        };
        public static IEnumerable<OrderItem> GetOrderItems =>
            new OrderItem[]
            {
                new OrderItem()
                {
                    Quantity = 2,
                    MenuId = "3",
                    OrderId = "4"
                },
                new OrderItem()
                {
                    Quantity = 3,
                    MenuId = "1",
                    OrderId = "5"
                },
                new OrderItem()
                {
                    Quantity = 3,
                    MenuId = "2",
                    OrderId = "2"
                },
                new OrderItem()
                {
                    Quantity = 2,
                    MenuId = "1",
                    OrderId = "1"
                },
                new OrderItem()
                {
                    Quantity = 5,
                    MenuId = "2",
                    OrderId = "1"
                },
                new OrderItem()
                {
                    Quantity = 6,
                    MenuId = "3",
                    OrderId = "3"
                },
                new OrderItem()
                {
                    Quantity = 1,
                    MenuId = "3",
                    OrderId = "2"
                },

            };
        public static IEnumerable<Review> GetReviews => new Review[]
        {
            new Review()
            {
                ReviewText = "The food taste like food, Good!",
                ReviewRating = 5,
                UserId = "1",
                OrderItemId = "1",
            },
            new Review()
            {
                ReviewText = "In a small chapel, known as the Morning Chapel",
                ReviewRating = 3,
                UserId = "1",
                OrderItemId = "2",
            },
            new Review()
            {
                ReviewText = "The Organ,which is placed above the screen, dividing the nave from the choir",
                ReviewRating = 1,
                UserId = "3",
                OrderItemId = "2",
            }
        };
    }
}
