using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Homework12
{
    public class Bravo : IStore
    {
        private Product[] _products = new Product[0];
        public Product[] Products { get => _products; }
        public void AddProduct(Product product)
        {
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }

        public Product GetProductByNo(int no)
        {
            foreach (Product pr in _products)
            {
                if (pr.No == no)
                    return pr;
            }
            throw new ProductNotFoundException();
        }

        public bool HasProductByNo(int no)
        {
            foreach (Product pr in _products)
            {
                if (pr.No == no)
                    return true;
            }
            return false;
        }

        public Product[] GetDrinkProducts()
        {
            Drink[] drink = new Drink[Products.Length];

            foreach (var item in Products)
            {
                if (item is Drink)
                {
                   AddProduct(item);
                }
            }
            return drink;
        }

        public Product[] GetDairyProducts()
        {
            Dairy[] dairy = new Dairy[Products.Length];

            foreach (var item in Products)
            {
                if (item is Dairy)
                {
                    AddProduct(item);
                }
            }
            return dairy;
        }

        public void RemoveProduct(int no)
        {
            for (int i = 0; i < _products.Length; i++)
            {
                if (_products[i].No == no)
                {
                    for (int j = no; j < _products.Length; j++)
                    {
                        _products[j - 1] = _products[j];
                    }
                }
            }
            Array.Resize(ref _products, _products.Length - 1);
        }

    }
}
