using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string nameProduct = "banana";
        double priceProduct = 3.40;
        int quantityProduct = 2;

        string expectedInventory = $"Product Inventory:{Environment.NewLine}{nameProduct} - Price: ${priceProduct:f2} - Quantity: {quantityProduct}";



        // Act
        this._inventory.AddProduct(nameProduct, priceProduct, quantityProduct);

        string result = this._inventory.DisplayInventory();


        // Assert
        Assert.That(result, Is.EqualTo(expectedInventory));
        

    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {    // Arrange
        
        string nameProduct = "";
        double priceProduct = 3.40;
        int quantityProduct = 2;

        string expectedInventory = $"Product Inventory:{Environment.NewLine}{nameProduct} - Price: ${priceProduct:f2} - Quantity: {quantityProduct}";

        // Act
        this._inventory.AddProduct(nameProduct, priceProduct, quantityProduct);

        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expectedInventory));


    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange

        string nameProduct = "peach";
        double priceProduct = 3.401;
        int quantityProduct = 2;

        string expectedInventory = $"Product Inventory:{Environment.NewLine}{nameProduct} - Price: ${priceProduct:f2} - Quantity: {quantityProduct}";

        // Act
        this._inventory.AddProduct(nameProduct, priceProduct, quantityProduct);

        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expectedInventory));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange

        // Act
        double result = this._inventory.CalculateTotalValue();


        // Assert
        Assert.That(0, Is.EqualTo(result));
       
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        string nameProduct = "banana";
        double priceProduct = 30;
        int quantityProduct = 2;

        string nameProduct2 = "peach";
        double priceProduct2 = 60;
        int quantityProduct2 = 2;

        double expected = 180;

        // Act
        this._inventory.AddProduct(nameProduct, priceProduct, quantityProduct);
        this._inventory.AddProduct(nameProduct2, priceProduct2, quantityProduct2);
        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
