using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using System.Collections.Generic;

namespace List10.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            var categories = new List<Category>
            {
            new Category()
            {
                Id = 1,
                Name = "Vegetables",
            }, new Category()
            {
                Id = 2,
                Name = "Fruit",
            }, new Category()
            {
                Id = 3,
                Name = "Meat",
            }, new Category() {
                Id = 4,
                Name = "Breadstuff"
            }
            };

            var articles = new List<Article>
            {
                 new Article()
                {
                    Id = 1,
                    Name = "Apple",
                    Price = 2,
                    CategoryId = 2,
                    ImagePath = "images/apple.jpg"
                }, new Article()
                {
                    Id = 2,
                    Name = "Tomato",
                    Price = 4,
                    CategoryId = 1,
                    ImagePath = "images/carrot.png"
                }
            };


            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Article>().HasData(articles);

            Console.WriteLine("Data added to modelBuilder.");
        }
    }

}
