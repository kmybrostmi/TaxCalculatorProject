using EShop_DataAccess.Infra.Enums;
using EShop_DataAccess.Interface;
using EShop_DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop_DataAccess.Infra.Commands;
public class ChangeQuantityCommand : ICommandd
{
    private readonly IShoppingCartRepository _shoppingCartRepository;
    private readonly IProductRepository _productRepository;
    private readonly Product _product;
    private readonly Operations _operations;

    public ChangeQuantityCommand(IShoppingCartRepository shoppingCartRepository,
        IProductRepository productRepository, Product product, Operations operations)
    {
        _shoppingCartRepository = shoppingCartRepository;
        _productRepository = productRepository;
        _product = product;
        _operations = operations;
    }

    public bool CanExecute()
    {
        switch (_operations)
        {
            case Operations.Decrease:
                return _shoppingCartRepository.Get(_product.ArticleId).Quantity != 0;
            case Operations.Increase:
                return (_productRepository.GetStockFor(_product.ArticleId) - 1) >= 0;
        }
        return false;   
    }

    public void Execute()
    {
        switch (_operations)
        {
            case Operations.Decrease:
                _productRepository.IncreaseStockBy(_product.ArticleId, 1);
                _shoppingCartRepository.DecreaseQuantity(_product.ArticleId);
                break;
            case Operations.Increase:
                _productRepository.DecreaseStockBy(_product.ArticleId, 1);
                _shoppingCartRepository.IncreaseQuantity(_product.ArticleId);
                break;
        }
    }

    public void Undo()
    {
        switch (_operations)
        {
            case Operations.Decrease:
                _productRepository.DecreaseStockBy(_product.ArticleId, 1);
                _shoppingCartRepository.IncreaseQuantity(_product.ArticleId);
                break;
            case Operations.Increase:
                _productRepository.IncreaseStockBy(_product.ArticleId, 1);
                _shoppingCartRepository.DecreaseQuantity(_product.ArticleId);
                break;
        }
    }
}
