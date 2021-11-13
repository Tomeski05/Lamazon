using Lamazon.Services.Interfaces;
using Lamazon.WebModels.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lamazon.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Authorize(Roles = "user")]
        public IActionResult Products()
        {
            List<ProductViewModel> products = _productService.GetAllProducts().ToList();
            return View(products);
        }
    }
}
