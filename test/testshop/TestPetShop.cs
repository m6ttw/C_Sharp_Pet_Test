using Xunit;

public class TestPetShop{
    PetShop shop = new PetShop();
    Dog dog = new Dog("Rover", "Labrador", "Dog food");
    Cat cat = new Cat("Susan", "Tabby Cat", "Cat food");
    Parrot parrot = new Parrot("Dinky", "Grey", "Parrot food");
    
    [Fact]
    public void StockIsEmptyTest(){
        Assert.Equal(0, shop.StockCount);
    }

    [Fact]
    public void AddToStockTest(){
        shop.AddToStock(dog);
        Assert.Equal(1, shop.StockCount);
    }

    [Fact]
    public void RemoveFromStockTest(){
        shop.AddToStock(dog);
        shop.AddToStock(cat);
        shop.AddToStock(parrot);
        shop.RemoveFromStock(cat);
        Assert.Equal(2, shop.StockCount);
    }
}