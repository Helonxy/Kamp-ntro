﻿using OOP1;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Id = 1;
        product1.CategoryId = 2;
        product1.ProductName = "Masa";
        product1.UnitPrice = 699;
        product1.UnitsInStock = 4;

        Product product2 = new Product {Id = 2, CategoryId =5,UnitsInStock=5, ProductName="Kalem", };

        //PascalCase   // camelCase
        //case sensitive
        ProductManager productManager = new ProductManager();
        productManager.Add(product1);



        productManager.Topla2(3, 6);


        int toplamaSonucu = productManager.Topla(3, 6);

        Console.WriteLine(toplamaSonucu*2);




    }
}