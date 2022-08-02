using EShop_DataAccess.Interface;
using EShop_DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop_DataAccess.Repository;
public class ProductReposiroty : IProductRepository
{
    private Dictionary<string,(Product Product, int Stock)> products { get; }
    public ProductReposiroty()
    {
        products = new Dictionary<string, (Product Product, int Stock)>();

        Add(new Product("1", "one", 1000), 1);
        Add(new Product("2", "two", 2000), 2);
        Add(new Product("3", "three", 3000), 3);
        Add(new Product("4", "four", 4000), 4);

    }
    public void Add(Product product, int stock)
    {
        products[product.ArticleId] = (product, stock);
    }

    public void DecreaseStockBy(string articleId, int amount)
    {
        throw new NotImplementedException();
    }

    public Product FindById(string articleId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public int GetStockFor(string articleId)
    {
        throw new NotImplementedException();
    }

    public void IncreaseStockBy(string articleId, int amount)
    {
        throw new NotImplementedException();
    }
}

