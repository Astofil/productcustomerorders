// namespace Infrastructure.Services;
// using Domain.DtosOrders;

using Dapper;
using Domain.DtosProducts;  //domain.Products; -sholud be instead of only domain
// using sql;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProductService
{
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=products/customer/orders;User Id=postgres;Password=151204;";
    public List<Product> GetProducts()
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            var sql = $"select * from products";
            var result = conn.Query<Product>(sql).ToList();
            return result;
        }
    }
    public int InsertProduct(Product product)
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            var sql = $"insert into products (productName, company, productcount, price) values('{product.ProductName}', '{product.Company}', {product.ProductCount}, {product.Price})";
            var result = conn.Execute(sql);
            return result;
        }
    }
    public List<Product> GetByJoin()
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            var sql = $"Select * from products left join orders on products.Id=orders.id";
            var result = conn.Query<Product>(sql).ToList();
            return result;
        }
    }
    public List<Product> GetProductsWithAmountOrder()
    {
        using ( var conn = new NpgsqlConnection(_connectionString))
        {
            var sql = $"select products.productName, Count(orders.price) from products full outer join orders on products.Id=orders.id";
            var result = conn.Query<Product>(sql).ToList();
            return result;
        }
    }
    public List<Product> GetProductsWithManufacturer()
    {
        using (var conn = new NpgsqlConnection (_connectionString))
        {
            var sql = $"select productName,company from products where company in('Samsung', 'Xiaomi', 'Apple')";
            var result = conn.Query<Product>(sql).ToList();
            return result;
        }
    }
}
