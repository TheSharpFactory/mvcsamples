﻿#region Usings
using Microsoft.AspNetCore.Mvc;
using TheSharpFactory.Entity.MainDb.People;
using TheSharpFactory.Repository.Container.Interfaces;
#endregion

namespace TheSharpFactory.Web.Areas.People.Controllers
{
    [Area("People")]
    public class CustomerController : Controller
    {
        //reference to the repository generated by The Sharp Factory
        private readonly IRepositoryContainer _repository;

        //inject the repository in the constructor
        public CustomerController(IRepositoryContainer repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _repository.MainDb.People.Customer.ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int customerId)
        {
            var model = _repository.MainDb.People.Customer.ByPK(customerId);

            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            _repository.MainDb.People.Customer.Update(customer);

            var model = _repository.MainDb.People.Customer.ByPK(customer.CustomerId);

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(null);
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            _repository.MainDb.People.Customer.Create(customer);

            //by now the customerid property is populated           

            return LocalRedirect("~/People/Customer/Details?customerId=" + customer.CustomerId.ToString());
        }

        [HttpGet]
        public IActionResult Details(int customerId)
        {
            var model = _repository.MainDb.People.Customer.ByPK(customerId);

            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int customerId)
        {
            var model = _repository.MainDb.People.Customer.ByPK(customerId);

            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            _repository.MainDb.People.Customer.Delete(customer);

            return LocalRedirect("~/People/Customer/Index");
        }
    }
}
