using Xunit;

public class TestCat{
    Cat Cat1 = new Cat("Moggy", "Persian", "Carnivore");

    [Fact]
    public void BreedNameTest(){
        Assert.Equal("Persian", Cat1.GetBreed());
    }

    [Fact]
    public void NameTest(){
        Assert.Equal("Moggy", Cat1.GetName());
    }
}
