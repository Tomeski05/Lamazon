﻿using Lamazon.WebModels.Enums;
using Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lamazon.Services.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<OrderViewModel> GetAllOrders();
        OrderViewModel GetOrderById(int id);
        int ChangeStatus(int orderId, string userId, StatusTypeViewModel status);
    }
}