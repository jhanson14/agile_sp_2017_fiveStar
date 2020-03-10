
  
using Microsoft.EntityFrameworkCore;
using WebStore.Models;

namespace WebStore.Data
{

    // Seeds data for product table
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(
                new Products
                {
                    Id = 1,
                    Name = "Basic Monitor",
                    Description = "Suited for light gaming and office use.",
                    Price = 50,
                    Genre = "Monitor",
                    FilePath = "/images/basicMonitor.jpg"
                },

                    new Products
                    {
                        Id = 2,
                        Name = "RGB Monitor",
                        Description = "This monitor delivers superior quality for gaming.",
                        Price = 200,
                        Genre = "Monitor",
                        FilePath = "/images/rgbaMonitor.jpg"
                    },

                    new Products
                    {
                        Id = 3,
                        Name = "Basic Keyboard",
                        Description = "Suited for light gaming and office use.",
                        Price = 20,
                        Genre = "Keyboard",
                        FilePath = "/images/basicKeyboard.png"
                    },

                    new Products
                    {
                        Id = 4,
                        Name = "RGBA Keyboard",
                        Description = "RGBA light capability. Suited for intense gaming.",
                        Price = 90,
                        Genre = "Keyboard",
                        FilePath = "/images/rgbaKeyboard.jpg"
                    },

                    new Products
                    {
                        Id = 5,
                        Name = "A5+ Speakers",
                        Description = "Premium speakers. Perfect for the complete in home speaker system.",
                        Price = 500,
                        Genre = "Speakers",
                        FilePath = "/images/rgbaSpeakers.jpeg"
                    },

                    new Products
                    {
                        Id = 6,
                        Name = "Basic Speakers",
                        Description = "Great for small office sound.",
                        Price = 15,
                        Genre = "Speakers",
                        FilePath = "/images/basicSpeakers.jpg"
                    },

                    new Products
                    {
                        Id = 7,
                        Name = "Basic Headphones",
                        Description = "Suited for light gaming and home use.",
                        Price = 15,
                        Genre = "Headphones",
                        FilePath = "/images/basicHeadphones.jpg"
                    },

                    new Products
                    {
                        Id = 8,
                        Name = "RGB Headphones",
                        Description = "RGB Capability. Suited for intense gaming and delivering superior sound.",
                        Price = 150,
                        Genre = "Headphones",
                        FilePath = "/images/rgbHeadphone.jpg"
                    },

                    new Products
                    {
                        Id = 9,
                        Name = "Basic Mouse",
                        Description = "Suited for light gaming and office use.",
                        Price = 14,
                        Genre = "Mouse",
                        FilePath = "/images/basicMouse.jpg"
                    },

                    new Products
                    {
                        Id = 10,
                        Name = "RGBA Mouse",
                        Description = "Perfect for low latency gameplay and plenty of gaming abuse. RGB!",
                        Price = 90,
                        Genre = "Mouse",
                        FilePath = "/images/rgbaMouse.jpg"
                    },

                    new Products
                    {
                        Id = 11,
                        Name = "Basic Printer",
                        Description = "Suited for simple office use. Good for small day to day printing jobs.",
                        Price = 25,
                        Genre = "Printer",
                        FilePath = "/images/basicPrinter.jpg"
                    },

                    new Products
                    {
                        Id = 12,
                        Name = "RGBA Printer",
                        Description = "Suited for heavy printer jobs. High ink efficiency.",
                        Price = 450,
                        Genre = "Printer",
                        FilePath = "/images/rgbaPrinter.jpeg"
                    },

                    new Products
                    {
                        Id = 13,
                        Name = "Basic Soundbar",
                        Description = "Suited for small sound for a small office or a quiet living room.",
                        Price = 50,
                        Genre = "Soundbar",
                        FilePath = "/images/basicSoundbar.jpeg"
                    },

                    new Products
                    {
                        Id = 14,
                        Name = "RGBA Soundbar",
                        Description = "Fancy lights and big sound. Perfect for shaking a room to an explosion in a movie like Transformers.",
                        Price = 500,
                        Genre = "Soundbar",
                        FilePath = "/images/rgbaSoundbar.jpeg"
                    },

                    new Products
                    {
                        Id = 15,
                        Name = "Basic Camera",
                        Description = "Takes lower resolution photos. Efficient on storage space.",
                        Price = 20,
                        Genre = "Camera",
                        FilePath = "/images/basicCamera.jpeg"
                    },

                    new Products
                    {
                        Id = 16,
                        Name = "RGBA Camera",
                        Description = "Super high resolution photos with a huge sensor to take in all the light and shadows of a shot.",
                        Price = 41000,
                        Genre = "Camera",
                        FilePath = "/images/rgbaCamera.jpg"
                    },

                    new Products
                    {
                        Id = 17,
                        Name = "Basic Flashdrive",
                        Description = "Mediocre file transfer speed. Great bang for buck.",
                        Price = 2,
                        Genre = "Flashdrive",
                        FilePath = "/images/basicFlashDrive.jpeg"
                    },

                    new Products
                    {
                        Id = 18,
                        Name = "RGBA Flash Drive",
                        Description = "SuPeR cOoL RGB Bro! Fast files! Bro! Bro guy man! Dude!",
                        Price = 18,
                        Genre = "Flashdrive",
                        FilePath = "/images/rgbaFlashDrive.jpg"
                    },

                    new Products
                    {
                        Id = 19,
                        Name = "Basic TV",
                        Description = "Medium color gamut and good sound.",
                        Price = 200,
                        Genre = "TV",
                        FilePath = "/images/basicTV.jpg"
                    },

                    new Products
                    {
                        Id = 20,
                        Name = "RGBA TV",
                        Description = "Super high nitz for a great brightness. Intense color gamut and plenty of sound..",
                        Price = 10000,
                        Genre = "TV",
                        FilePath = "/images/rgbaTV.jpeg"
                    }

        );
            return modelBuilder;
        }
    }
}
