using Xunit;

public class TestCat{
    Cat Cat1 = new Cat("Moggy", "Persian", "Carnivore");

    [Fact]
    public void NameTest(){
        Assert.Equal("Moggy", Cat1.GetName());
    }

    [Fact]
    public void BreedNameTest(){
        Assert.Equal("Persian", Cat1.GetBreed());
    }

    [Fact]
    public void DietTest(){
        Assert.Equal("Carnivore", Cat1.GetDiet());
    }

    [Fact]
    public void CanMakeNoise(){
        Assert.Equal("Cat says meow", Cat1.MakeNoise("Cat", "meow"));
    }
}
