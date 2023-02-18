﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Product
    {
        string _name;
        string _sku;
        private bool _instock;
        bool _inStock;

        public Product(string name, bool inStock = true)
        {
            Random rand = new Random();

            _name = name;
            _sku = rand.Next(1000000, 10000000).ToString();
            _inStock = inStock;
        }
       
        // overloading
        public Product(string name, string sku)
        {
            _name = name;
            _sku = sku;
            _inStock = true;
        }
        
        // Constructors don't have return types
        public Product(string name, string sku, bool inStock)
        {
            _name = name;
            _sku = sku;
            _instock = inStock;
        }

        public string Name { get => _name;}
        public string Sku { get => _sku; set => _sku = value; }
        public bool InStock { get => _inStock; set => _inStock = value; }

        // Override to string, to change what display when you call ToString() on an object
        public override string ToString()
        {
            // If in stock, display name and sku 
            // else display name and out of stock
            if(InStock)
            {
                return $"{_name} - Sku: {_sku}";
            }    
            else
            {
                return $"{_name} - Out Of Stock";
            }
        }
    }
}
