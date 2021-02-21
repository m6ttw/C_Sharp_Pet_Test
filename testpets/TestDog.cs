using Xunit;

public class TestDog{
    Dog Dog1 = new Dog("Stella", "Jack Russell", "Human food");

    [Fact]
    public void NameTest(){
        Assert.Equal("Stella", Dog1.GetName());
    }

    [Fact]
    public void BreedNameTest(){
        Assert.Equal("Jack Russell", Dog1.GetBreed());
    }

    [Fact]
    public void DietTest(){
        Assert.Equal("Human food", Dog1.GetDiet());
    }

    [Fact]
    public void CanMakeNoise(){
        Assert.Equal("Dog says woof", Dog1.MakeNoise("Dog", "woof"));
    }
}