using Domain.DtosCustomers;
using Npgsql;
using Dapper;

public class CustomerService
{
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=products/customer/orders;User Id=postgres;Password=151204;";
    public List<Customer> GetCustomersJoinProducts()
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            var sql = $"select * from customers left join products on customers.Id=products.Id";
            var result = conn.Query<Customer>(sql).ToList();
            return result;
        }
    }
    public List<Customer> GetCustomersFullJoinProducts()
    {
        using (var conn = new NpgsqlConnection (_connectionString))
        {
            var sql = $"select * from customers full outer join products on products.Id=customers.Id";
            var result = conn.Query<Customer>(sql).ToList();
            return result;
        }
    }
    public List<Customer> GetCustomersRightJoinProducts()
    {
        using (var conn = new NpgsqlConnection (_connectionString))
        {
            var sql = $"select * from customers right join products on products.Id=customers.Id";
            var result = conn.Query<Customer>(sql).ToList();
            return result;
        }
    }
    public List<Customer> GetCustomersWithOrders()
    {
        using (var conn = new NpgsqlConnection (_connectionString))
        {
            var sql = $"select customer.firstName,orders.id from customers left join orders on customers.Id=orders.id";
            var result = conn.Query<Customer>(sql).ToList();
            return result;
        }
    }
    //Task-9
}
