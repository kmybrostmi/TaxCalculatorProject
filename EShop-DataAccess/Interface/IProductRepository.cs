using EShop_DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop_DataAccess.Interface
{
    public interface IProductRepository
    {
        Product FindById(string articleId);
        int GetStockFor(string articleId);
        IEnumerable<Product> GetAll();
        void DecreaseStockBy(string articleId, int amount);
        void IncreaseStockBy(string articleId, int amount);
    }
}

