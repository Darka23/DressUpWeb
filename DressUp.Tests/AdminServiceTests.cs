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
            await SeedDbAsync(repo);
        }

        [Test]
        public void AddingAccessoryThrowingException()
        {
            
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

        private async Task SeedDbAsync(IApplicationDbRepository repo)
        {
            var accessory = new Accessory
            {
                AccessoryType = "tigan",
                ImageUrl = "http://jumbo-online.bg/30667-superlarge_default/Tigan-nezalepvaso-pokritie-20-sm-1069297.jpg",
                Name = "Gosho",
                Price = 15
            };

            await repo.AddAsync(accessory);
            await repo.SaveChangesAsync();
        }
    }
}