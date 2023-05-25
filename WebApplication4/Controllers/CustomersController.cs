using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Index
        public ActionResult Index()
        {
            List<Customer> customers = _context.Customers.ToList();
            return View(customers);
        }

        //Create
        public IActionResult Create()
        {
            Customer customer = new Customer(); 
            return PartialView("_CustomerPartialView", customer);
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            customer.FullName = customer.FirstName + " " + customer.LastName;
            if (ModelState.IsValid)
            {
                var userexist = _context.Customers.Any(x => x.FullName == customer.FullName);
                var mobileexist = _context.Customers.Any(x => x.MobileNumber == customer.MobileNumber);

                if (userexist && mobileexist)
                {
                    ModelState.AddModelError("FirstName", "User with this name already exists");
                    ModelState.AddModelError("MobileNumber", "User with this mobile number already exists");
                    return PartialView("_CustomerPartialView", customer);
                }
                if (userexist) {
                    ModelState.AddModelError("FirstName", "User with this name already exists");
                    return PartialView("_CustomerPartialView", customer);
                }
                if (mobileexist)
                {
                    ModelState.AddModelError("MobileNumber", "User with this mobile number already exists");
                    return PartialView("_CustomerPartialView", customer);

                }
                else
                {
                    customer.FullName = customer.FirstName + " " + customer.LastName;
                    customer.DateCreated = DateTime.Now;
                    customer.TimeStamp = DateTime.Now;
                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Customers");
                }
            }
            return View(customer);
        }

        //Edit
        public IActionResult Edit(int id)
        {
            Customer customer = _context.Customers.Where(c => c.Id == id).FirstOrDefault();
            return PartialView("_EditCustomerPartialView", customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            customer.FullName = customer.FirstName + " " + customer.LastName;

            var userexist = _context.Customers.Any(x => x.FullName == customer.FullName);
            var mobileexist = _context.Customers.Any(x => x.MobileNumber == customer.MobileNumber);
            if (ModelState.IsValid)
            {
                if (userexist && mobileexist)
                {
                    ModelState.AddModelError("FirstName", "User with this name already exists");
                    ModelState.AddModelError("MobileNumber", "User with this mobile number already exists");
                    return PartialView("_EditCustomerPartialView", customer);
                }
                if (userexist)
                {
                    ModelState.AddModelError("FirstName", "User with this name already exists");
                    return PartialView("_EditCustomerPartialView", customer);
                }
                if (mobileexist)
                {
                    ModelState.AddModelError("MobileNumber", "User with this mobile number already exists");
                    return PartialView("_EditCustomerPartialView", customer);

                }
                else
                {
                    customer.FullName = customer.FirstName + " " + customer.LastName;
                    customer.DateCreated = DateTime.Now;
                    customer.TimeStamp = DateTime.Now;
                    _context.Customers.Update(customer);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(customer);
        }
    }
}
