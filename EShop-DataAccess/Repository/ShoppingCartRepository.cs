using EShop_DataAccess.Interface;
using EShop_DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop_DataAccess.Repository;

public class ShoppingCartRepository : IShoppingCartRepository
{
    public Dictionary<string, (Product Product, int Quantity)> ListItems = new Dictionary<string, (Product Product, int Quantity)>();
    public void Add(Product Product)
    {
        if (ListItems.ContainsKey(Product.ArticleId))
        {
            IncreaseQuantity(Product.ArticleId);
        }
        else
        {
            ListItems[Product.ArticleId] = (Product, 1);
        }
    }

    public void DecreaseQuantity(string articleId)
    {
        if (ListItems.ContainsKey(articleId))
        {
            var items = ListItems[articleId];
            if (items.Quantity == 1)
            {
                ListItems.Remove(articleId);
            }
            else
            {
                ListItems[articleId] = (items.Product, items.Quantity - 1);
            }
        }
        else
        {
            throw new KeyNotFoundException($"Product With Article Id {articleId} not In Cart, Please Add First");
        }
    }

    public (Product Product, int Quantity) Get(string articleId)
    {
        if (ListItems.ContainsKey(articleId))
        {
            return ListItems[articleId];
        }
        return (default, default);
    }

    public IEnumerable<(Product Product, int Quantity)> GetAll()
    {
        return ListItems.Values;
    }

    public void IncreaseQuantity(string articleId)
    {
        if (ListItems.ContainsKey(articleId))
        {
            var items = ListItems[articleId];
            ListItems[articleId] = (items.Product, items.Quantity + 1);
        }
        else
        {
            throw new KeyNotFoundException($"Product With Article Id {articleId} not In Cart, Please Add First");
        }
    }
    public void RemoveAll(string articleId)
    {
        ListItems.Remove(articleId);
    }
}
