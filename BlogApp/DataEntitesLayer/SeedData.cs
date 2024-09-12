using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataEntitesLayer
{
    public class SeedData
    {
        public static void TestVerileriniDoldur(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<BlogContext>();
            if (context != null)
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }
                if (!context.Tags.Any())
                {
                    context.Tags.AddRange(
                        new EntitiesLayer.Tag { Text = "web programlama", Url = "web-programlama" },
                        new EntitiesLayer.Tag { Text = "backend", Url = "backend" },
                        new EntitiesLayer.Tag { Text = "game", Url = "game" },
                        new EntitiesLayer.Tag { Text = "fullstack", Url = "full-stack" },
                        new EntitiesLayer.Tag { Text = "php", Url = "php" }
                    );
                    context.SaveChanges();
                }
                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new EntitiesLayer.User { UserName = "ahmetkaya", Name = "Ahmet Kaya", Email = "info@ahmetkaya.com", Password = "123456", Image = "p1.png" },
                        new EntitiesLayer.User { UserName = "selinkarsli", Name = "Selin Karslı", Email = "info@selinkarsli.com", Password = "123456", Image = "p2.jfif" }
                    );
                    context.SaveChanges();
                }
                if (!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new EntitiesLayer.Post
                        {
                            Title = "DataDrive: Back - End Development Bootcamp",
                            Description = "En temelden başlayıp C# + MVC + Identity ve çok daha fazla teknolojiyi kullanma konusunda alanında bilgi edinmeni sağlayacak.",
                            Content = "Bu Bootcamp'te, .NET Core'un temel yapı taşlarını öğrenme fırsatı bulacaksın. Backend geliştirmeden mikro servis mimarisine, API geliştirmeden veri yönetimine kadar, modern yazılım geliştirme süreçlerinin en önemli konularına hakim olacaksın.",
                            Url = "data-drive-back-end-development-bootcamp",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-10),
                            //Tags = context.Tags.Take(3).ToList(),
                            Image = "1.png",
                            UserId = 1,
                            Comments = new List<EntitiesLayer.Comment>{
                            new EntitiesLayer.Comment {Text = "iyi bir bootcamp", PublishedOn = DateTime.Now.AddDays(-20), UserId = 1},
                            new EntitiesLayer.Comment {Text = "tavsiye ederim", PublishedOn = DateTime.Now.AddDays(-10), UserId = 2},
                            }
                        },
                        new EntitiesLayer.Post
                        {
                            Title = "SQL Excellence Bootcamp",
                            Description = "SQL Excellence Bootcamp,SQL'in temel ve ileri seviye teknikleri konusunda derinlemesine bilgi edinmeni sağlayacak.",
                            Content = "SQL, veri tabanı yönetiminde ve veri analizi süreçlerinde kritik bir rol oynar. SQL'in kullanım alanları arasında veri sorgulama, veri manipülasyonu, veri tabanı yönetimi ve veri analitiği bulunur..",
                            Url = "sql-excellence-bootcamp",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-8),
                            //Tags = context.Tags.Take(4).ToList(),
                            Image = "2.png",
                            UserId = 1
                        },
                        new EntitiesLayer.Post
                        {
                            Title = "HTML & CSS Essentials",
                            Description = "HTML ve CSS, modern web geliştirme dünyasında temel yapı taşlarıdır.",
                            Content = "HTML, web sayfalarının yapısını tanımlar ve içerikleri organize ederken, CSS sayfanın stilini ve görünümünü belirler. Birlikte, web sitelerinin temelini oluşturan güçlü bir kombinasyon sağlarlar.",
                            Url = "html-and-css-essentials",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-5),
                            //Tags = context.Tags.Take(2).ToList(),
                            Image = "3.png",
                            UserId = 2
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
       
    