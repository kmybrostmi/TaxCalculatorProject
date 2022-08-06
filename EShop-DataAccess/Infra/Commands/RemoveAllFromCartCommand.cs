using EShop_DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop_DataAccess.Infra.Commands;
public class RemoveAllFromCartCommand : ICommandd
{
    private readonly IProductRepository _productRepository;
    private readonly IShoppingCartRepository _shoppingCartRepository;

    public RemoveAllFromCartCommand(IProductRepository productRepository,IShoppingCartRepository shoppingCartRepository)
    {
        _productRepository = productRepository;
        _shoppingCartRepository = shoppingCartRepository;
    }

    public bool CanExecute()
    {
        return _shoppingCartRepository.GetAll().Any();
    }

    public void Execute()
    {
        var items = _shoppingCartRepository.GetAll().ToArray();   //Make a Local Copy

        foreach (var item in items)
        {
            _productRepository.IncreaseStockBy(item.Product.ArticleId, item.Quantity);
            _shoppingCartRepository.RemoveAll(item.Product.ArticleId);
        }

    }

    public void Undo()
    {
        throw new NotImplementedException();
    }
}
