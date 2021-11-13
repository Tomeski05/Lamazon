using Lamazon.Domain.Enums;
using Lamazon.Services.Interfaces;
using Lamazon.WebModels.Enums;
using Lamazon.WebModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lamazon.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderservice)
        {
            _orderService = orderservice;
        }

        public IActionResult ListAllOrders()
        {
            List<OrderViewModel> orders = _orderService.GetAllOrders().ToList();
            return View(orders);
        }

        public IActionResult ApproveOrder(int orderId)
        {
            OrderViewModel order = _orderService.GetOrderById(orderId);
            _orderService.ChangeStatus(order.Id, order.User.Id, StatusTypeViewModel.Confirmed);
            return RedirectToAction("listallorders");
        }

        public IActionResult DeclineOrder(int orderId)
        {
            OrderViewModel order = _orderService.GetOrderById(orderId);
            _orderService.ChangeStatus(order.Id, order.User.Id, StatusTypeViewModel.Declined);
            return RedirectToAction("listallorders");
        }

    }
}
