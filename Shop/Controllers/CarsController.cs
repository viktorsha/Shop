using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController: Controller
    {
        private readonly ICars _cars;
        private readonly ICarsCategory _carCategories;

        public CarsController(ICars iCars, ICarsCategory iCarsCat)
        {
            _cars = iCars;
            _carCategories = iCarsCat;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Autos page";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _cars.getAllCars;
            obj.carCategory = "Auto";
            return View(obj);
        }
    }
}
