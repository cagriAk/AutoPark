using AutoPark.Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPark.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                Name = "cagri",
                Age = 28
            };

           
            _logger.LogError("Customerda Hata var {@customer}",customer);



            //var settings = MongoClientSettings.FromConnectionString("mongodb+srv://netix:netix2323@cluster0.ldagn.mongodb.net/AutoParkDB?retryWrites=true&w=majority");
            //var client = new MongoClient(settings);
            //var database = client.GetDatabase("AutoParkDB");
            //var collection = database.GetCollection<Test>("Test");
            //var test = new Test
            //{
            //    Id = ObjectId.GenerateNewId(),
            //    Name = "Test",
            //    Age = 1,
            //    AddressList = new List<Address>() { new Address { Title = "Ev Addresi", Description = "İsanbul" },new Address {Title="Baba Evi",Description="Elazıg" } }
            //};

            //collection.InsertOne(test);


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
