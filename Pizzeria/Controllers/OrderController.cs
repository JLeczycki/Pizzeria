using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;
using Pizzeria.Interfaces;
using Pizzeria.Models;
using Pizzeria.ViewModels;

namespace Pizzeria.Controllers
{
    public class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // [System.Web.Mvc.HttpPost]
        // public ActionResult Create(OderViewModel viewModel)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         viewModel.Products = _unitOfWork.Orders.GetProducts();
        //     }
        //
        //     var order = new Order
        //     {
        //         DateTime = DateTime.UtcNow,
        //         
        //     };
        //     return RedirectToAction("Index");
        // }

        // GET: Order
        // public ActionResult Index()
        // {
        //     return View();
        // }
    }
}