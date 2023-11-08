using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuCategories_Menus_MenuId",
                table: "MenuCategories");

            migrationBuilder.DropIndex(
                name: "IX_MenuCategories_Category",
                table: "MenuCategories");

            migrationBuilder.RenameColumn(
                name: "CardName",
                table: "UserPaymentDetails",
                newName: "NameOnCard");

            migrationBuilder.AlterColumn<long>(
                name: "CardNumber",
                table: "UserPaymentDetails",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ReviewText",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MenuId",
                table: "MenuCategories",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "MenuCategories",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "MenuDescription", "MenuImage", "MenuName", "MenuNutrience", "MenuPrepTime", "MenuPrice" },
                values: new object[,]
                {
                    { "1", "Best fried chicken in town", "", "Fried Chicken", "260kcal", 15, 10.99m },
                    { "2", "juicy hamburger with cheese", "", "Hamburger", "491kcal", 10, 12.99m },
                    { "3", "Premium Russet Burbank variety potatoes for that fluffy inside, crispy outside taste", "", "Fries", "432kcal", 8, 4.99m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { "1", "email1@gmail.com", null, "User1" },
                    { "2", "nberzon0@wordpress.org", "", "nyablsley0" },
                    { "3", "spappin1@163.com", "", "kburgott1" },
                    { "4", "mlawee2@pen.io", "", "gmcanalley2" },
                    { "5", "eu.erat.semper@protonmail.org", "", "larpin3@nasa.gov" }
                });

            migrationBuilder.InsertData(
                table: "MenuCategories",
                columns: new[] { "CategoryId", "Category", "MenuId" },
                values: new object[,]
                {
                    { "1", "Burgers", "2" },
                    { "2", "Sides", "3" },
                    { "3", "Chicken", "1" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "OrderItemId", "UserId", "OrderedItemMenuId", "OrderedItemOrderId", "ReviewRating", "ReviewText" },
                values: new object[,]
                {
                    { "1", "1", null, null, 5m, "The food taste like food, Good!" },
                    { "2", "1", null, null, 3m, "In a small chapel, known as the Morning Chapel" },
                    { "2", "3", null, null, 1m, "The Organ,which is placed above the screen, dividing the nave from the choir" }
                });

            migrationBuilder.InsertData(
                table: "UserAddresses",
                columns: new[] { "AddressId", "Address", "AddressLabel", "UserId" },
                values: new object[,]
                {
                    { "1", "Suite 56 49047 Holmberg Parkway", "Home address", "1" },
                    { "2", "PO Box 95686 7324 Acker Place", "Word address", "1" },
                    { "3", "Apt 510 97 Southridge Hill", "Friend address", "3" }
                });

            migrationBuilder.InsertData(
                table: "UserPaymentDetails",
                columns: new[] { "CardId", "CardNumber", "ExpiryDate", "NameOnCard", "PaymentAddress", "UserId" },
                values: new object[,]
                {
                    { "1", 5020751290843793L, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rebekah Matevushev", "50 Graceland Avenue, Room 871", "1" },
                    { "2", 6331105501692333L, new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henrik Cheves", "56 Becker Hill, Apt 814", "2" },
                    { "3", 5100179478445091L, new DateTime(2027, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mitchel	0785 Maple Drive, Ulrica Rikel", "Apt 1652", "2" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate", "TotalPrice", "UserAddressId", "UserId" },
                values: new object[,]
                {
                    { "1", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, "1", "1" },
                    { "2", new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "2", "1" },
                    { "3", new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "2", "1" },
                    { "4", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, "1", "1" },
                    { "5", new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, "3", "3" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "MenuId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { "1", "1", 2 },
                    { "2", "1", 5 },
                    { "2", "2", 3 },
                    { "3", "2", 1 },
                    { "3", "3", 6 },
                    { "3", "4", 2 },
                    { "1", "5", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuCategories_Category",
                table: "MenuCategories",
                column: "Category",
                unique: true,
                filter: "[Category] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuCategories_Menus_MenuId",
                table: "MenuCategories",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "MenuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuCategories_Menus_MenuId",
                table: "MenuCategories");

            migrationBuilder.DropIndex(
                name: "IX_MenuCategories_Category",
                table: "MenuCategories");

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "CategoryId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "CategoryId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "MenuCategories",
                keyColumn: "CategoryId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "MenuId", "OrderId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "MenuId", "OrderId" },
                keyValues: new object[] { "2", "1" });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "MenuId", "OrderId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "MenuId", "OrderId" },
                keyValues: new object[] { "3", "2" });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "MenuId", "OrderId" },
                keyValues: new object[] { "3", "3" });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "MenuId", "OrderId" },
                keyValues: new object[] { "3", "4" });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "MenuId", "OrderId" },
                keyValues: new object[] { "1", "5" });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "OrderItemId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "OrderItemId", "UserId" },
                keyValues: new object[] { "2", "1" });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "OrderItemId", "UserId" },
                keyValues: new object[] { "2", "3" });

            migrationBuilder.DeleteData(
                table: "UserPaymentDetails",
                keyColumn: "CardId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "UserPaymentDetails",
                keyColumn: "CardId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "UserPaymentDetails",
                keyColumn: "CardId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "UserAddresses",
                keyColumn: "AddressId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "UserAddresses",
                keyColumn: "AddressId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "UserAddresses",
                keyColumn: "AddressId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "3");

            migrationBuilder.RenameColumn(
                name: "NameOnCard",
                table: "UserPaymentDetails",
                newName: "CardName");

            migrationBuilder.AlterColumn<int>(
                name: "CardNumber",
                table: "UserPaymentDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "ReviewText",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MenuId",
                table: "MenuCategories",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "MenuCategories",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenuCategories_Category",
                table: "MenuCategories",
                column: "Category",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuCategories_Menus_MenuId",
                table: "MenuCategories",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "MenuId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
