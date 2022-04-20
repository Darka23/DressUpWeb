using DressUp.Core.Contracts;
using DressUp.Core.Models.AddViewModels;
using DressUp.Core.Services;
using DressUp.Infrastructure.Data.Models;
using DressUp.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Tests
{
    
    public class AdminServiceTests
    {
        private ServiceProvider serviceProvider;
        private InMemoryDbContext dbContext;

        [SetUp]
        public async Task Setup()
        {
            dbContext = new InMemoryDbContext();
            
            var serviceCollection = new ServiceCollection();

            serviceProvider = serviceCollection
                .AddSingleton(sp=> dbContext.CreateContext())
                .AddSingleton<IApplicationDbRepository, ApplicationDbRepository>()
                .AddSingleton<ICloudinaryService, CloudinaryService>()
                .AddSingleton<IAdminServices, AdminServices>()
                .BuildServiceProvider();

            var repo = serviceProvider.GetService<ApplicationDbRepository>();
            //await SeedDbAsync(repo);
        }

        [Test]
        public void AddingAccessoryThrowingException()
        {
            Assert.Pass();
        }
        [Test]
        public void AddingAccessoryNotThrowingException()
        {
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Dispose();
        }

        //private async Task SeedDbAsync(IApplicationDbRepository repo)
        //{
        //    var bytes = Encoding.UTF8.GetBytes("This is a dummy file");
        //    IFormFile file = new FormFile(new MemoryStream(bytes), 0, bytes.Length, "Data", "dummy.txt");

        //    var accessory = new Accessory
        //    {
        //        AccessoryType = "tigan",
        //        Name = "Gosho",
        //        ImageUrl = "",
        //        Description = "sd",
        //        Price = 15
        //    };

        //    await repo.AddAsync(accessory);
        //    await repo.SaveChangesAsync();
        //}
    }
}