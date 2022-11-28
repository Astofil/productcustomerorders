
using Dapper;
using Npgsql;
using Domain.DtosOrders;

public class OrderService
{
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=products/customer/orders;User Id=postgres;Password=151204;";
    public List<Order> GetOrdersByApple()
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            var sql = $"select * from orders right join products on orders.id=products.Id where products.company = 'Apple'";
            var result = conn.Query<Order>(sql).ToList();
            return result;
        }
    }
    public List<Order> GetOrdersByPrice()
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            var sql = $"select products.productName, orders.price from orders right join products on orders.id=products.Id where orders.price>=1000";
            var result = conn.Query<Order>(sql).ToList();
            return result;
        }
    }

}
