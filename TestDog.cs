using Xunit;

public class TestDog{
    Dog Dog1 = new Dog("Jack Russell");

    [Fact]
    public void BreedNameTest(){
        Assert.Equal("Jack Russell", Dog1.GetBreedName());
    }

    [Fact]
    public void WoofTest(){
        Assert.Equal("Woof woof!", Dog1.Bark());
    }
}