using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows;

namespace Midterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Product> products = new List<Product>();
        private object lbProducts;
        private int i;

        public MainWindow()
        {
            InitializeComponent();
            Preload();
            DisplayInformation();
            DisplayInformation();
            DisplayInformation();
        }

        void Preload()

        {
            Random rand = new Random();
            int end = 106;



            for (int i = 100; i < end; i++)
            {
                string productName = "Red Bull: " + i;

                if (rand.Next(2) != 0)
                {
                    products.Add(new Product(productName));
                }
                else
                {
                    products.Add(new Product(productName, false));
                }
            }
        }
        public void DisplayInformation()
        {

            for (int i = 0; i <products.Count; i++)
            {
                lbProducts.items.Add(products[i]);
            }
        }
    }
}
