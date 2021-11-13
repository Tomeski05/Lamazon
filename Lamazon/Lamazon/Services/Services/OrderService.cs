using AutoMapper;
using Lamazon.DataAccess.Interfaces;
using Lamazon.Domain.Enums;
using Lamazon.Domain.Models;
using Lamazon.Services.Interfaces;
using Lamazon.WebModels.Enums;
using Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lamazon.Services.Services
{
    public class OrderService : IOrderService
    {
        protected readonly IRepository<Order> _orderRepository;
        protected readonly IMapper _mapper;
        protected readonly IUserRepository _userRepository;

        public OrderService(IRepository<Order> orderRepository, IMapper mapper, IUserRepository userRepository)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public int ChangeStatus(int orderId, string userId, StatusTypeViewModel status)
        {
            try
            {
                Order order = _orderRepository.GetById(orderId);
                User user = _userRepository.GetById(userId);

                order.Status = (StatusType)status;

                if(status == StatusTypeViewModel.Pending)
                {
                    _orderRepository.Insert(
                        new Order
                        {
                            User = user,
                            DateOfOrder = DateTime.Now,
                            Status = StatusType.Init
                        }
                        ); 
                }
                return _orderRepository.Update(order);
            }
            catch (Exception ex)
            {

                string message = ex.Message;
                throw new Exception(message);
            }
        }

        public IEnumerable<OrderViewModel> GetAllOrders()
        {
            IEnumerable<Order> orders = _orderRepository.GetAll();
            List<OrderViewModel> mappedOrders = _mapper.Map<List<OrderViewModel>>(orders);
            return mappedOrders;
        }

        public OrderViewModel GetOrderById(int id)
        {
            return _mapper.Map<OrderViewModel>(_orderRepository.GetById(id));
        }

        public OrderViewModel GetOrderById(int id, string userId)
        {
            try
            {
                User user = _userRepository.GetById(userId);
                Order order = _orderRepository.GetById(id);

                if (user.Id == order.UserId)
                {
                    return _mapper.Map<OrderViewModel>(order);
                }
                else
                {
                    return new OrderViewModel();
                }
            }
            catch (Exception ex)
            {

                throw new Exception($"Message: {ex.Message}");
            }
        }
    }
}
