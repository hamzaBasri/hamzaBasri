using BLL.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Rosa.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq.Expressions;


namespace Rosa.Controllers
{
    public class CarouselController : BaseMvcController
    {
        readonly ICarouselBLL _carouselBLL;
        public CarouselController(ICarouselBLL carouselBll, IWebHostEnvironment env) : base(env)
        {
            _carouselBLL = carouselBll;
        }

        public IActionResult List()
        {
            var carousel = _carouselBLL.GetAll().Select(CarouselListViewModel.FromModel).ToList();
            return View(carousel);
        }
        public IActionResult Delete(Carousel carousel)
        {
            _carouselBLL.Delete(carousel);
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var carouselVM = new CarouselListViewModel();


            var carousel = _carouselBLL.GetByid(id);
            carouselVM = CarouselListViewModel.FromModel(carousel);

            ViewData["Title"] = carouselVM.IsCreateMode ? "Create" : "Update";
            return View(carouselVM);
        }
        public IActionResult Save(CarouselListViewModel carouselVM)
        {
            var carousel = carouselVM.ToModel();
            carousel.ImageUrl = UploadImage(carouselVM.ImageUrl);
            _carouselBLL.Save(carousel);
            SetMessage($"Carousel Id {carousel.Id} Saved Succesfuly");
            return RedirectToAction("List");
        }
        


    }
}
