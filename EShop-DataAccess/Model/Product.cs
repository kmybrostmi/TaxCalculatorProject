using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop_DataAccess.Model;

public class Product
{
    public Product()
    {

    }
    public Product(string articleId, string name, decimal price)
    {
        ArticleId = articleId;
        Name = name;
        Price = price;
    }

    public string ArticleId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
 