
using Microsoft.AspNetCore.Mvc;
using Domain.DtosOrders;
using Infrastructure;

[ApiController]
[Route("[controller]")]

public class OrderController
{
    private OrderService _orderService;
    public OrderController()
    {
        _orderService = new OrderService();
    }

    [HttpGet("Get orders by apple")]
    public List<Order> GetOrdersByApple()
    {
        return _orderService.GetOrdersByApple();
    }

    [HttpGet("Get orders by price")]
    public List<Order> GetOrdersByPrice()
    {
        return _orderService.GetOrdersByPrice();
    }
}

