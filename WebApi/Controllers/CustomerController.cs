
using Microsoft.AspNetCore.Mvc;
using Domain.DtosCustomers;
using Infrastructure;

[ApiController]
[Route("[controller]")]

public class CustomerController
{
    private CustomerService _customerService;
    public CustomerController()
    {
        _customerService = new CustomerService();
    }

    [HttpGet("Get Customers & Products (left join)")]
    public List<Customer> GetCustomersJoinProducts()
    {
        return _customerService.GetCustomersFullJoinProducts();
    }

    [HttpGet("Get Customer & Products (full outer join)")]
    public List<Customer> GetCustomersFullJoinProducts()
    {
        return _customerService.GetCustomersFullJoinProducts();
    }

    [HttpGet("Get Customer & Products (right join)")]
    public List<Customer> GetCustomersRightJoinProducts()
    {
        return _customerService.GetCustomersRightJoinProducts();
    }

    [HttpGet("Get Customers with number of Orders")]
    public List<Customer> GetCustomersWithOrders()
    {
        return _customerService.GetCustomersWithOrders();
    }
}

