using EShop_DataAccess.Model;

namespace EShop_DataAccess.Interface;

public interface IProductRepository
{
    Product FindById(string articleId);
    int GetStockFor(string articleId);
    IEnumerable<Product> GetAll();
    void DecreaseStockBy(string articleId, int amount);
    void IncreaseStockBy(string articleId, int amount);
}

