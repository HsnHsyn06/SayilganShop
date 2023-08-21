﻿using Microsoft.AspNetCore.Mvc;
using SayilganShop.Business.Services;
using SayilganShop.WebUI.Models;

namespace SayilganShop.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Detail(int id)
        {
            var productDetailDto = _productService.GetProductDetail(id);
            var viewModel = new ProductDetailViewModel()
            {
                Id = productDetailDto.Id,
                Name = productDetailDto.Name,
                Description = productDetailDto.Description,
                UnitPrice = productDetailDto.UnitPrice,
                ImagePath = productDetailDto.ImagePath,
                CategoryId = productDetailDto.CategoryId,
                CategoryName = productDetailDto.CategoryName,
            };
            if (productDetailDto.UnitInStock == 0)
            {
                viewModel.IsSoldOut = true;
                viewModel.SoldingOutMessage = "Tükendi";
            }
            else if (productDetailDto.UnitInStock <= 3)
            {
                viewModel.SoldingOutMessage = "Son Ürünler!";
            }

            return View(viewModel);
        }
    }
}
