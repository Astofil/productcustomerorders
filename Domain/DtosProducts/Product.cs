namespace Domain.DtosProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Product
{
    public int id { get; set; }
    public string? ProductName { get; set; }
    public string? Company { get; set; }
    public int ProductCount { get; set; }
    public int Price { get; set; }
}

