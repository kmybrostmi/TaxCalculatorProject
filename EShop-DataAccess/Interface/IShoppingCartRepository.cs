using EShop_DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop_DataAccess.Interface;
public interface IShoppingCartRepository
{
    (Product Product, int Quantity) Get(string articleId);
    IEnumerable<(Product Product, int Quantity)> GetAll();
    void Add(Product Product);
    void IncreaseQuantity(string articleId);
    void DecreaseQuantity(string articleId); 
    void RemoveAll(string articleId);   
}
