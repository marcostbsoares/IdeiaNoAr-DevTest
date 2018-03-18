using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CleanArchitecture.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IRepository<Customer> CustomerRepository;

        public UsersController(IRepository<Customer> customerRepository)
        {
            this.CustomerRepository = customerRepository;
        }

        public IActionResult Index()
        {
            return View(CustomerRepository.List());
        }

        [HttpGet]
        public IActionResult New()
        {
            return View("New");
        }

        [HttpPost]
        public async Task<IActionResult> New(int id, [Bind("Id")] int UserId)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(@"https://api.pipedrive.com/v1/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //Solicita informação do cliente pela API do Pipedrive
            var response = await client.GetAsync(@"persons/" + UserId + "?api_token=d8d2a00812cc811a940723a62fa28835a253901b");

            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;

                Customer customer = JsonConvert.DeserializeAnonymousType(content, new { Data = new Customer() }).Data;

                //Adiciona cliente ao DB se já não existir
                if (customer != null && CustomerRepository.GetById(customer.Id) == null)
                    CustomerRepository.Add(customer);
                else
                    return View("Error");

                return Redirect(@"/Users");
            }

            return View("Error");
        }

        [HttpGet("Users/{id}/edit")]
        public IActionResult Edit(int id)
        {
            Customer user = CustomerRepository.GetById(id);

            if (user == null)
                return View("Error");

            return View("Edit", user);
        }

        [HttpPut("Users/{id}")]
        public IActionResult Update(Customer user)
        {


            return Redirect(@"/Users");
        }
    }
}
