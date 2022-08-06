using EShop_DataAccess.Interface;
using EShop_DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop_DataAccess.Infra.Commands;
public class RemoveFromCartCommand : ICommandd
{
    private readonly IShoppingCartRepository _shoppingCartRepository;
    private readonly IProductRepository _productRepository;
    private readonly Product _product;

    public RemoveFromCartCommand(IShoppingCartRepository shoppingCartRepository,
        IProductRepository productRepository, Product product)
    {
        _shoppingCartRepository = shoppingCartRepository;
        _productRepository = productRepository;
        _product = product;
    }

    public bool CanExecute()
    {
        if (_product == null) return false;
        return _shoppingCartRepository.Get(_product.ArticleId).Quantity > 0;
    }

    public void Execute()
    {
        if (_product == null) return;
        var items = _shoppingCartRepository.Get(_product.ArticleId);
        _productRepository.IncreaseStockBy(_product.ArticleId, items.Quantity);
        _shoppingCartRepository.RemoveAll(_product.ArticleId);
    }

    public void Undo()
    {
        throw new NotImplementedException();
    }
}
