using System;
using System.Collections.Generic;
using System.Text;

namespace Homework12
{
    public interface IStore
    {
        Product[] Products { get; }
        void AddProduct(Product product);
        bool HasProductByNo(int no);
        Product GetProductByNo(int no);
        Product[] GetDrinkProducts();
        Product[] GetDairyProducts();
        void RemoveProduct(int no);
    }
}
