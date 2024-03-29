﻿using DataAccess.Data;
using Models.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Models.Entities;
using Models.Enums;

namespace DataAccess;

public class AppDbInitializer
{
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
        var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

        context.Database.EnsureCreated();

        //Cinema
        if (!context.Cinemas.Any())
        {
            context.Cinemas.AddRange(new List<Cinema>()
            {
                new Cinema()
                {
                    Name = "Atlas",
                    Logo = "https://imgtr.ee/images/2023/04/03/UjCac.jpg",
                    Description = "1948 yılında 1860 kişilik koltuk kapasitesi ile " +
                    "İstanbul’un en büyük sinema salonlarından birisi olarak Atlas Pasajı'nın " +
                    "arkasında hizmete girmiştir. Ön kısmındaki Küçük Sahne ve Kulis Bar ile " +
                    "birlikte İstanbul'da bir dönemin en önemli eğlence ve kültür merkezlerinden " +
                    "birisi idi.Sinemanın ana salon kısmı 1970'lerde pasaja katıldı ve locaların " +
                    "olduğu bölüm üç küçük salona ayrılarak işlevine devam etti. 2018-2020 yılında " +
                    "restore edilip yeniden tek büyük salonlu bir sinema haline geldi."
                },
                new Cinema()
                {
                    Name = "Yeşilçam",
                    Logo = "https://imgtr.ee/images/2023/04/03/Ujtks.jpg",
                    Description = "Yeşilçam Sineması, 1998 yılında Beyoğlu'nda faaliyete başlamıştır. " +
                    "Sadece bağımsız filmlerin gösterilmesi ilkesiyle çalışan sinema, hiçbir dağıtım " +
                    "şirketine bağlı olmadan, kendi ilkeleri doğrultusunda film seçkisi yaparak faaliyetini " +
                    "sürdürmekte ve Türkiye'deki tek “Bağımsız Program Sineması” olarak bilinmektedir."
                },
                new Cinema()
                {
                    Name = "Emek",
                    Logo = "https://imgtr.ee/images/2023/04/03/UjBYD.jpg",
                    Description = "Cumhuriyet döneminde İstanbul'da açılmış en eski sinema salonudur. " +
                    "Sinema 2009 yılında kapandı, sinema binası \"Cercle d’Orient\" (Serkldoryan) adlı tarihi " +
                    "yapının arka cephesinde bulunan diğer bazı binalarla birlikte 20 Mayıs 2013'te tamamen yıkıldı. " +
                    "Kültür varlığı olarak tescillenen Barok üslubundaki tavan bezemeleri ve duvar süslemeleri ise " +
                    "tartışmalı bir restorasyon süreci sonunda renove edildi; Grand Pera adlı alışveriş merkezine " +
                    "dönüştürülen \"Cercle d’Orient\" binasının beşinci katına taşındı. Sinema 2016 yılında " +
                    "\"Emek Sahnesi\" adıyla Grand Pera'nın en üst katında yeniden hizmete girmiştir."
                },
                new Cinema()
                {
                    Name = "Moda Sahnesi",
                    Logo = "https://imgtr.ee/images/2023/04/03/UjEtM.jpg",
                    Description = "Moda Sahnesi, İstanbul’un Moda semtinde geçmişte “Moda Sineması” adıyla bilinen " +
                    "salonun kültür merkezine dönüştürülmesi sonucu Ekim 2013’te hizmete giren mekân ve burada oyun " +
                    "sahneleyen tiyatro topluluğudur.\r\n\r\nSahne; değişik boyutta ve işlevde üç salondan oluşur. " +
                    "1969’da Kafkas Sineması adıyla kurulan ve 1984’ten itibaren Moda Sineması adını alan yer, 1980’ler " +
                    "ve 1990’larda İstanbul’daki sanat yaşamının önemli noktalarından birisi iken bakıma muhtaç hale gelmiş; " +
                    "sinemayı dönüştürüp bir kültür merkezi olarak işletmeyi üstlenen 12 kişi tarafından 15 Ocak 2013’te " +
                    "başlatılan inşaat sonucunda 9 Ekim 2013’te Moda Sahnesi adıyla hizmet vermeye başlamıştır."
                },
                new Cinema()
                {
                    Name = "Beyoğlu",
                    Logo = "https://imgtr.ee/images/2023/04/03/UjFb1.jpg",
                    Description = "İstanbul'un en eski ve hâlâ popülerliğini koruyan en önemli sinema salonlarından biri " +
                    "konumundadır. 1989 yılında açılan Beyoğlu Sineması, 1994 yılında Avrupa Birliği çatısı altında " +
                    "oluşturulan Eurimages üyeliğine Türkiye'den kabul edilen ilk sinema işletmesidir."
                },
            });
            context.SaveChanges();
        }

        //Actors
        if (!context.Actors.Any())
        {
            context.Actors.AddRange(new List<Actor>()
            {
                new Actor()
                {
                    FullName = "Kemal Sunal",
                    Bio = "This is the Bio of Kemal Sunal",
                    ProfilePictureUrl = "https://imgtr.ee/images/2023/04/03/U3MRU.webp"

                },
                new Actor()
                {
                    FullName = "Tarık Akan",
                    Bio = "This is the Bio of the Tarık Akan",
                    ProfilePictureUrl = "https://imgtr.ee/images/2023/04/03/U39lI.jpg"
                },
                new Actor()
                {
                    FullName = "Haluk Bilginer",
                    Bio = "This is the Bio of the Haluk Bilginer",
                    ProfilePictureUrl = "https://imgtr.ee/images/2023/04/03/U3UNb.jpg"
                },
                new Actor()
                {
                    FullName = "Şener Şen",
                    Bio = "This is the Bio of the Şener Şen",
                    ProfilePictureUrl = "https://imgtr.ee/images/2023/04/03/U3ki7.jpg"
                },
                new Actor()
                {
                    FullName = "Münir Özkul",
                    Bio = "This is the Bio of the Münir Özkul",
                    ProfilePictureUrl = "https://imgtr.ee/images/2023/04/03/U3ynA.jpg"
                },
                new Actor()
                {
                    FullName = "Adile Naşit",
                    Bio = "This is the Bio of the Adile Naşit",
                    ProfilePictureUrl = "https://imgtr.ee/images/2023/04/03/U3aRx.jpg"
                },
                new Actor()
                {
                    FullName = "Ayşen Gruda",
                    Bio = "This is the Bio of the Ayşen Gruda",
                    ProfilePictureUrl = "https://imgtr.ee/images/2023/04/03/U3lpJ.jpg"
                },
                new Actor()
                {
                    FullName = "Halit Akçatepe",
                    Bio = "This is the Bio of the Halit Akçatepe",
                    ProfilePictureUrl = "https://imgtr.ee/images/2023/04/03/U3vhi.jpg"
                },
                new Actor()
                {
                    FullName = "İlyas Salman",
                    Bio = "This is the Bio of the İlyas Salman",
                    ProfilePictureUrl = "https://imgtr.ee/images/2023/04/03/U3YoM.jpg"
                },
                new Actor()
                {
                    FullName = "Kadir İnanır",
                    Bio = "This is the Bio of the Kadir İnanır",
                    ProfilePictureUrl = "https://imgtr.ee/images/2023/04/03/U3m41.jpg"
                },
                new Actor()
                {
                    FullName = "Metin Akpınar",
                    Bio = "This is the Bio of the Metin Akpınar",
                    ProfilePictureUrl = "https://imgtr.ee/images/2023/04/03/U3dXX.jpg"
                },
                new Actor()
                {
                    FullName = "Türkan Şoray",
                    Bio = "This is the Bio of the Türkan Şoray",
                    ProfilePictureUrl = "https://imgtr.ee/images/2023/04/03/U36vV.jpg"
                },
                new Actor()
                {
                    FullName = "Zeki Alasya",
                    Bio = "This is the Bio of the Zeki Alasya",
                    ProfilePictureUrl = "https://imgtr.ee/images/2023/04/03/U3Lxl.jpg"
                },
            });
            context.SaveChanges();
        }

        //Producers
        if (!context.Producers.Any())
        {
            context.Producers.AddRange(new List<Producer>()
            {
                new Producer()
                {
                    FullName = "Nuri Bilge Ceylan",
                    Bio = "This is the Bio of Nuri Bilge Ceylan",
                    ProfilePictureUrl = "https://i.ibb.co/C6DF5QB/nuri-bilge-ceylan.jpg"
                },
                new Producer()
                {
                    FullName = "Yılmaz Güney",
                    Bio = "This is the Bio of Yılmaz Güney",
                    ProfilePictureUrl = "https://i.ibb.co/H4cXyYv/y-lmaz-g-ney.jpg"
                },
                new Producer()
                {
                    FullName = "Ertem Eğilmez",
                    Bio = "This is the Bio of Ertem Eğilmez",
                    ProfilePictureUrl = "https://i.ibb.co/LrR3Ywr/ertem-egilmez.jpg"
                },
                new Producer()
                {
                    FullName = "Orhan Aksoy",
                    Bio = "This is the Bio of Orhan Aksoy",
                    ProfilePictureUrl = "https://i.ibb.co/VpHYHDc/orhan-aksoy.jpg"
                },
                new Producer()
                {
                    FullName = "Atıf Yılmaz",
                    Bio = "This is the Bio of Atıf Yılmaz",
                    ProfilePictureUrl = "https://i.ibb.co/ZHnWCTC/at-f-y-lmaz.jpg"
                },
                new Producer()
                {
                    FullName = "Zeki Ökten",
                    Bio = "This is the Bio of Zeki Ökten",
                    ProfilePictureUrl = "https://i.ibb.co/6wJ484W/zeki-kten.jpg"
                },
                new Producer()
                {
                    FullName = "Ergin Orbey",
                    Bio = "This is the Bio of Ergin Orbey",
                    ProfilePictureUrl = "https://i.ibb.co/q7gXm9z/ergin-orbey.jpg"
                },
                new Producer()
                {
                    FullName = "Kartal Tibet",
                    Bio = "This is the Bio of Kartal Tibet",
                    ProfilePictureUrl = "https://i.ibb.co/RD2RsWT/kartal-tibet.jpg"
                },
            });
            context.SaveChanges();
        }

        //Movies
        if (!context.Movies.Any())
        {
            context.Movies.AddRange(new List<Movie>()
            {
                new Movie()
                {
                    Name = "Kış Uykusu",
                    Description = "This is the Kış Uykusu movie description",
                    Price = 39.50,
                    ImageUrl = "https://i.ibb.co/N1FczMV/k-uykusu.jpg",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1110),
                    CinemaId = 3,
                    ProducerId = 1,
                    MovieCategory = MovieCategory.Drama
                },
                new Movie()
                {
                    Name = "Süt Kardeşler",
                    Description = "This is the Süt Kardeşler movie description",
                    Price = 39.50,
                    ImageUrl = "https://i.ibb.co/B2wCDp7/s-t-kerde-ler.png",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1110),
                    CinemaId = 1,
                    ProducerId = 3,
                    MovieCategory = MovieCategory.Comedy
                },
                new Movie()
                {
                    Name = "Yol",
                    Description = "This is the Yol movie description",
                    Price = 29.50,
                    ImageUrl = "https://i.ibb.co/Z2y01DS/yol.jpg",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1110),
                    CinemaId = 2,
                    ProducerId = 2,
                    MovieCategory = MovieCategory.Drama
                },
                new Movie()
                {
                    Name = "Neşeli Günler",
                    Description = "This is the Neşeli Günler movie description",
                    Price = 39.50,
                    ImageUrl = "https://i.ibb.co/m8kNyzQ/ne-eli-g-nler.jpg",
                     StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1110),
                    CinemaId = 2,
                    ProducerId = 4,
                    MovieCategory = MovieCategory.Comedy
                },
                new Movie()
                {
                    Name = "Köyden İndim Şehire",
                    Description = "This is the Köyden İndim Şehire movie description",
                    Price = 39.50,
                    ImageUrl = "https://i.ibb.co/WvW1HtB/k-yden-indim-ehre.jpg",
                     StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1110),
                    CinemaId = 4,
                    ProducerId = 3,
                    MovieCategory = MovieCategory.Comedy
                },
                new Movie()
                {
                    Name = "Selvi Boylum Al Yazmalım",
                    Description = "This is the Selvi Boylum Al Yazmalım movie description",
                    Price = 39.50,
                    ImageUrl = "https://i.ibb.co/hZT9FHz/selvi-boylum.jpg",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1110),
                    CinemaId = 4,
                    ProducerId = 5,
                    MovieCategory = MovieCategory.Romantic
                },
                new Movie()
                {
                    Name = "Çöpçüler Kralı",
                    Description = "This is the Çöpçüler Kralı movie description",
                    Price = 39.50,
                    ImageUrl = "https://i.ibb.co/zVLfb4c/p-ler-kral.jpg",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1110),
                    CinemaId = 5,
                    ProducerId = 6,
                    MovieCategory = MovieCategory.Romantic
                },
                new Movie()
                {
                    Name = "Gülen Gözler",
                    Description = "This is the Gülen Gözler movie description",
                    Price = 39.50,
                    ImageUrl = "https://i.ibb.co/vkZw8Js/g-len-g-zler.jpg",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1110),
                    CinemaId = 3,
                    ProducerId = 3,
                    MovieCategory = MovieCategory.Drama
                },
                new Movie()
                {
                    Name = "Bizim Aile",
                    Description = "This is the Bizim Aile movie description",
                    Price = 39.50,
                    ImageUrl = "https://i.ibb.co/GQhS9v8/bizim-aile.jpg",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1110),
                    CinemaId = 4,
                    ProducerId = 7,
                    MovieCategory = MovieCategory.Drama
                },
                new Movie()
                {
                    Name = "Mavi Boncuk",
                    Description = "This is the Mavi Boncuk movie description",
                    Price = 39.50,
                    ImageUrl = "https://i.ibb.co/rK9NXV2/mavi-boncuk.jpg",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1110),
                    CinemaId = 5,
                    ProducerId = 3,
                    MovieCategory = MovieCategory.Comedy
                },
                new Movie()
                {
                    Name = "Canım Kardeşim",
                    Description = "This is the Canım Kardeşim movie description",
                    Price = 39.50,
                    ImageUrl = "https://i.ibb.co/wgbKQ1W/can-m-karde-im.png",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1110),
                    CinemaId = 1,
                    ProducerId = 3,
                    MovieCategory = MovieCategory.Drama
                },
                new Movie()
                {
                    Name = "Hababam Sınıfı",
                    Description = "This is the Hababam Sınıfı movie description",
                    Price = 39.50,
                    ImageUrl = "https://i.ibb.co/vLQhRWJ/hababam-s-n-f.jpg",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1110),
                    CinemaId = 3,
                    ProducerId = 3,
                    MovieCategory = MovieCategory.Comedy
                },
                new Movie()
                {
                    Name = "Tosun Paşa",
                    Description = "This is the Tosun Paşa movie description",
                    Price = 39.50,
                    ImageUrl = "https://i.ibb.co/7knQ0dH/tosun-pa-a.jpg",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1110),
                    CinemaId = 5,
                    ProducerId = 8,
                    MovieCategory = MovieCategory.Comedy
                },
                new Movie()
                {
                    Name = "Şabanoğlu Şaban",
                    Description = "This is the Şabanoğlu Şaban movie description",
                    Price = 39.50,
                    ImageUrl = "https://i.ibb.co/m9SWxQS/abano-lu-aban.jpg",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1110),
                    CinemaId = 1,
                    ProducerId = 3,
                    MovieCategory = MovieCategory.Comedy
                },
                new Movie()
                {
                    Name = "Kibar Feyzo",
                    Description = "This is the Kibar Feyzo movie description",
                    Price = 39.50,
                    ImageUrl = "https://i.ibb.co/FBrgLV6/kibar-feyzo.jpg",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1110),
                    CinemaId = 1,
                    ProducerId = 4,
                    MovieCategory = MovieCategory.Comedy
                },
            });
            context.SaveChanges();
        }

        //Actors & Movies
        if (!context.Actors_Movies.Any())
        {
            context.Actors_Movies.AddRange(new List<Actor_Movie>()
                {
                    new Actor_Movie() { MovieId = 1, ActorId = 3 },
                    new Actor_Movie() { MovieId = 2, ActorId = 1 },
                    new Actor_Movie() { MovieId = 2, ActorId = 4 },
                    new Actor_Movie() { MovieId = 2, ActorId = 6 },
                    new Actor_Movie() { MovieId = 2, ActorId = 7 },
                    new Actor_Movie() { MovieId = 2, ActorId = 8 },
                    new Actor_Movie() { MovieId = 3, ActorId = 2 },
                    new Actor_Movie() { MovieId = 4, ActorId = 4 },
                    new Actor_Movie() { MovieId = 4, ActorId = 5 },
                    new Actor_Movie() { MovieId = 4, ActorId = 6 },
                    new Actor_Movie() { MovieId = 4, ActorId = 7 },
                    new Actor_Movie() { MovieId = 5, ActorId = 1 },
                    new Actor_Movie() { MovieId = 5, ActorId = 5 },
                    new Actor_Movie() { MovieId = 5, ActorId = 8 },
                    new Actor_Movie() { MovieId = 5, ActorId = 11 },
                    new Actor_Movie() { MovieId = 5, ActorId = 13 },
                    new Actor_Movie() { MovieId = 6, ActorId = 10 },
                    new Actor_Movie() { MovieId = 6, ActorId = 12 },
                    new Actor_Movie() { MovieId = 7, ActorId = 1 },
                    new Actor_Movie() { MovieId = 7, ActorId = 4 },
                    new Actor_Movie() { MovieId = 7, ActorId = 7 },
                    new Actor_Movie() { MovieId = 7, ActorId = 9 },
                    new Actor_Movie() { MovieId = 8, ActorId = 4 },
                    new Actor_Movie() { MovieId = 8, ActorId = 5 },
                    new Actor_Movie() { MovieId = 8, ActorId = 6 },
                    new Actor_Movie() { MovieId = 8, ActorId = 7 },
                    new Actor_Movie() { MovieId = 8, ActorId = 8 },
                    new Actor_Movie() { MovieId = 9, ActorId = 2 },
                    new Actor_Movie() { MovieId = 9, ActorId = 4 },
                    new Actor_Movie() { MovieId = 9, ActorId = 5 },
                    new Actor_Movie() { MovieId = 9, ActorId = 6 },
                    new Actor_Movie() { MovieId = 9, ActorId = 7 },
                    new Actor_Movie() { MovieId = 9, ActorId = 8 },
                    new Actor_Movie() { MovieId = 10, ActorId = 1 },
                    new Actor_Movie() { MovieId = 10, ActorId = 2 },
                    new Actor_Movie() { MovieId = 10, ActorId = 5 },
                    new Actor_Movie() { MovieId = 10, ActorId = 6 },
                    new Actor_Movie() { MovieId = 10, ActorId = 8 },
                    new Actor_Movie() { MovieId = 10, ActorId = 11 },
                    new Actor_Movie() { MovieId = 10, ActorId = 13 },
                    new Actor_Movie() { MovieId = 11, ActorId = 1 },
                    new Actor_Movie() { MovieId = 11, ActorId = 2 },
                    new Actor_Movie() { MovieId = 11, ActorId = 6 },
                    new Actor_Movie() { MovieId = 11, ActorId = 8 },
                    new Actor_Movie() { MovieId = 11, ActorId = 11 },
                    new Actor_Movie() { MovieId = 12, ActorId = 1 },
                    new Actor_Movie() { MovieId = 12, ActorId = 2 },
                    new Actor_Movie() { MovieId = 12, ActorId = 4 },
                    new Actor_Movie() { MovieId = 12, ActorId = 5 },
                    new Actor_Movie() { MovieId = 12, ActorId = 6 },
                    new Actor_Movie() { MovieId = 12, ActorId = 7 },
                    new Actor_Movie() { MovieId = 12, ActorId = 8 },
                    new Actor_Movie() { MovieId = 13, ActorId = 1 },
                    new Actor_Movie() { MovieId = 13, ActorId = 4 },
                    new Actor_Movie() { MovieId = 13, ActorId = 6 },
                    new Actor_Movie() { MovieId = 13, ActorId = 7 },
                    new Actor_Movie() { MovieId = 14, ActorId = 1 },
                    new Actor_Movie() { MovieId = 14, ActorId = 4 },
                    new Actor_Movie() { MovieId = 14, ActorId = 6 },
                    new Actor_Movie() { MovieId = 14, ActorId = 7 },
                    new Actor_Movie() { MovieId = 14, ActorId = 8 },
                    new Actor_Movie() { MovieId = 15, ActorId = 1 },
                    new Actor_Movie() { MovieId = 15, ActorId = 4 },
                    new Actor_Movie() { MovieId = 15, ActorId = 6 },
                    new Actor_Movie() { MovieId = 15, ActorId = 9 },
                });
            context.SaveChanges();
        }

    }

    public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
    {
        using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();

        //Roles
        var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        if (!await roleManager.RoleExistsAsync(UserRoles.User))
            await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

        //Users
        var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
        string adminUserEmail = "admin@etickets.com";

        var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
        if (adminUser == null)
        {
            var newAdminUser = new AppUser()
            {
                FullName = "Admin User",
                UserName = "admin-user",
                Email = adminUserEmail,
                EmailConfirmed = true
            };
            await userManager.CreateAsync(newAdminUser, "@Admin1*");
            await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
        }


        string appUserEmail = "user@etickets.com";

        var appUser = await userManager.FindByEmailAsync(appUserEmail);
        if (appUser == null)
        {
            var newAppUser = new AppUser()
            {
                FullName = "Application User",
                UserName = "app-user",
                Email = appUserEmail,
                EmailConfirmed = true
            };
            await userManager.CreateAsync(newAppUser, "@User1*");
            await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
        }
    }
}

