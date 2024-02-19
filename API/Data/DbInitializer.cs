using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data;

public static class DbInitializer
{
    public static async Task Initialize(StoreContext context, UserManager<User> userManager)
    {
        if (!userManager.Users.Any())
        {
            var user = new User
            {
                UserName = "bob",
                Email = "bob@test.com"
            };

            await userManager.CreateAsync(user, "Pa$$w0rd");
            await userManager.AddToRoleAsync(user, "Member");

            var admin = new User
            {
                UserName = "admin",
                Email = "admin@test.com"
            };

            await userManager.CreateAsync(admin, "Pa$$w0rd");
            await userManager.AddToRolesAsync(admin, new[] { "Admin", "Member" });
        }

        if (context.Products.Any()) return;

        var products = new List<Product>
            {
                new Product
                {
                    Name = "boots_rw_1",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/images/products/boots_rw_1.png",
                    Brand = "Rugged Wear",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "boots_rw_2",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    PictureUrl = "/images/products/boots_rw_2.png",
                    Brand = "Rugged Wear",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "boots_rw_3",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/boots_rw_3.png",
                    Brand = "Rugged Wear",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "boots_sw_1",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 30000,
                    PictureUrl = "/images/products/boots_sw_1.png",
                    Brand = "Samson",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "boots_sw_2",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "/images/products/boots_sw_2.png",
                    Brand = "Samson",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "boots_sw_3",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "/images/products/boots_sw_3.png",
                    Brand = "Samson",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "boots_ww_1",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl = "/images/products/boots_ww_1.png",
                    Brand = "Wrangler",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "boots_ww_2",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 100,
                    PictureUrl = "/images/products/boots_ww_2.png",
                    Brand = "Wrangler",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "boots_ww_3",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1100,
                    PictureUrl = "/images/products/boots_ww_3.png",
                    Brand = "Wrangler",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "boots_ww_4",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 150,
                    PictureUrl = "/images/products/boots_ww_4.png",
                    Brand = "Wrangler",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "carriers_rw_1",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 400,
                    PictureUrl = "/images/products/carriers_rw_1.png",
                    Brand = "Rugged Wear",
                    Type = "Carriers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "carriers_rw_2",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 600,
                    PictureUrl = "/images/products/carriers_rw_2.png",
                    Brand = "Rugged Wear",
                    Type = "Carriers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "carriers_rw_3",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 350,
                    PictureUrl = "/images/products/carriers_rw_3.png",
                    Brand = "Rugged Wear",
                    Type = "Carriers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "carriers_rw_4",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 300,
                    PictureUrl = "/images/products/carriers_rw_4.png",
                    Brand = "Rugged Wear",
                    Type = "Carriers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "carriers_rw_5",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 100,
                    PictureUrl = "/images/products/carriers_rw_5.png",
                    Brand = "Rugged Wear",
                    Type = "Carriers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "carriers_rw_6",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 80,
                    PictureUrl = "/images/products/carriers_rw_6.png",
                    Brand = "Rugged Wear",
                    Type = "Carriers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "carriers_sw_1",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 170,
                    PictureUrl = "/images/products/carriers_sw_1.png",
                    Brand = "Samson",
                    Type = "Carriers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "carriers_sw_2",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 140,
                    PictureUrl = "/images/products/carriers_sw_2.png",
                    Brand = "Samson",
                    Type = "Carriers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "carriers_ww_1",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 110,
                    PictureUrl = "/images/products/carriers_ww_1.png",
                    Brand = "Wrangler",
                    Type = "Carriers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "carriers_ww_2",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 110,
                    PictureUrl = "/images/products/carriers_ww_2.png",
                    Brand = "Wrangler",
                    Type = "Carriers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "carriers_ww_3",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 220,
                    PictureUrl = "/images/products/carriers_ww_3.png",
                    Brand = "Wrangler",
                    Type = "Carriers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "hats_rw_1",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 130,
                    PictureUrl = "/images/products/hats_rw_1.png",
                    Brand = "Rugged Wear",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "hats_sw_1",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 140,
                    PictureUrl = "/images/products/hats_sw_1.png",
                    Brand = "Samson",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "hats_sw_2",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 170,
                    PictureUrl = "/images/products/hats_sw_2.png",
                    Brand = "Samson",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "hats_ww_1",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 160,
                    PictureUrl = "/images/products/hats_ww_1.png",
                    Brand = "Wrangler",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_rw_1",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 40,
                    PictureUrl = "/images/products/tools_rw_1.png",
                    Brand = "Rugged Wear",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_rw_2",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 60,
                    PictureUrl = "/images/products/tools_rw_2.png",
                    Brand = "Rugged Wear",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_rw_3",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 80,
                    PictureUrl = "/images/products/tools_rw_3.png",
                    Brand = "Rugged Wear",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_rw_4",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 100,
                    PictureUrl = "/images/products/tools_rw_4.png",
                    Brand = "Rugged Wear",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_rw_5",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 110,
                    PictureUrl = "/images/products/tools_rw_5.png",
                    Brand = "Rugged Wear",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_rw_6",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 220,
                    PictureUrl = "/images/products/tools_rw_6.png",
                    Brand = "Rugged Wear",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_sw_1",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 200,
                    PictureUrl = "/images/products/tools_sw_1.png",
                    Brand = "Samson",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_sw_2",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 180,
                    PictureUrl = "/images/products/tools_sw_2.png",
                    Brand = "Samson",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_sw_3",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 150,
                    PictureUrl = "/images/products/tools_sw_3.png",
                    Brand = "Samson",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_sw_4",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 110,
                    PictureUrl = "/images/products/tools_sw_4.png",
                    Brand = "Samson",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_sw_5",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 120,
                    PictureUrl = "/images/products/tools_sw_5.png",
                    Brand = "Samson",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_sw_6",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1100,
                    PictureUrl = "/images/products/tools_sw_6.png",
                    Brand = "Samson",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_sw_7",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 110,
                    PictureUrl = "/images/products/tools_sw_7.png",
                    Brand = "Samson",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_ww_1",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1600,
                    PictureUrl = "/images/products/tools_ww_1.png",
                    Brand = "Wrangler",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_ww_2",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 900,
                    PictureUrl = "/images/products/tools_ww_2.png",
                    Brand = "Wrangler",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_ww_3",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1100,
                    PictureUrl = "/images/products/tools_ww_3.png",
                    Brand = "Wrangler",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_ww_4",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1700,
                    PictureUrl = "/images/products/tools_ww_4.png",
                    Brand = "Wrangler",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_ww_5",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1600,
                    PictureUrl = "/images/products/tools_ww_5.png",
                    Brand = "Wrangler",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_ww_6",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1500,
                    PictureUrl = "/images/products/tools_ww_6.png",
                    Brand = "Wrangler",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_ww_7",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1600,
                    PictureUrl = "/images/products/tools_ww_7.png",
                    Brand = "Wrangler",
                    Type = "Tools",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "tools_ww_8",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1200,
                    PictureUrl = "/images/products/tools_ww_8.png",
                    Brand = "Wrangler",
                    Type = "Tools",
                    QuantityInStock = 100
                },
            };

        foreach (var product in products)
        {
            context.Products.Add(product);
        }

        context.SaveChanges();
    }
}