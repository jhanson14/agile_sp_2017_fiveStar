using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Migrations
{
    public partial class AllProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Genre", "Name" },
                values: new object[] { "Monitor", "Basic Monitor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "FilePath", "Genre", "Name", "Price" },
                values: new object[] { "This monitor delivers superior quality for gaming.", "/images/rgbaMonitor.jpg", "Monitor", "RGB Monitor", 200.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "FilePath", "Genre", "Name", "Price" },
                values: new object[,]
                {
                    { 20, "Super high nitz for a great brightness. Intense color gamut and plenty of sound..", "/images/rgbaTV.jpg", "TV", "RGBA TV", 10000.0 },
                    { 19, "Medium color gamut and good sound.", "/images/basicTV.jpg", "TV", "Basic TV", 200.0 },
                    { 18, "SuPeR cOoL RGB Bro! Fast files! Bro! Bro guy man! Dude!", "/images/rgbaFlashDrive.jpg", "Flashdrive", "RGBA Flash Drive", 18.0 },
                    { 17, "Mediocre file transfer speed. Great bang for buck.", "/images/basicFlashDrive.jpg", "Flashdrive", "Basic Flashdrive", 2.0 },
                    { 16, "Super high resolution photos with a huge sensor to take in all the light and shadows of a shot.", "/images/rgbaCamera.jpg", "Camera", "RGBA Camera", 41000.0 },
                    { 15, "Takes lower resolution photos. Efficient on storage space.", "/images/basicCamera.jpg", "Camera", "Basic Camera", 20.0 },
                    { 14, "Fancy lights and big sound. Perfect for shaking a room to an explosion in a movie like Transformers.", "/images/rgbaSoundbar.jpg", "Soundbar", "RGBA Soundbar", 500.0 },
                    { 13, "Suited for small sound for a small office or a quiet living room.", "/images/basicSoundbar.jpg", "Soundbar", "Basic Soundbar", 50.0 },
                    { 12, "Suited for heavy printer jobs. High ink efficiency.", "/images/rgbaPrinter.jpg", "Printer", "RGBA Printer", 450.0 },
                    { 10, "Perfect for low latency gameplay and plenty of gaming abuse. RGB!", "/images/rgbaMouse.jpg", "Mouse", "RGBA Mouse", 90.0 },
                    { 9, "Suited for light gaming and office use.", "/images/basicMouse.jpg", "Mouse", "Basic Mouse", 14.0 },
                    { 8, "RGB Capability. Suited for intense gaming and delivering superior sound.", "/images/rgbHeadphone.jpg", "Headphones", "RGB Headphones", 150.0 },
                    { 7, "Suited for light gaming and home use.", "/images/basicHeadphones.jpg", "Headphones", "Basic Headphones", 15.0 },
                    { 6, "Great for small office sound.", "/images/basicSpeakers.jpg", "Speakers", "Basic Speakers", 15.0 },
                    { 5, "Premium speakers. Perfect for the complete in home speaker system.", "/images/rgbaSpeakers.jpg", "Speakers", "A5+ Speakers", 500.0 },
                    { 4, "RGBA light capability. Suited for intense gaming.", "/images/rgbaKeyboard.jpg", "Keyboard", "RGBA Keyboard", 90.0 },
                    { 11, "Suited for simple office use. Good for small day to day printing jobs.", "/images/basicPrinter.jpg", "Printer", "Basic Printer", 25.0 },
                    { 3, "Suited for light gaming and office use.", "/images/basicKeyboard.jpg", "Keyboard", "Basic Keyboard", 20.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Genre", "Name" },
                values: new object[] { "test", "basic Monitor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "FilePath", "Genre", "Name", "Price" },
                values: new object[] { "Suited for light gaming and office use.", "/images/basicMonitor.jpg", "test", "basic Monitor", 50.0 });
        }
    }
}
