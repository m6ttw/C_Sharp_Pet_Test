using Xunit;

public class TestParrot{
    Parrot Parrot1 = new Parrot("Polly", "Some kind of PSarrot", "Seeds");

    [Fact]
    public void HasNameTest(){
        Assert.Equal("Polly", Parrot1.GetName());
    }

    [Fact]
    public void HasBreedTest(){
        Assert.Equal("Some kind of Parrot", Parrot1.GetBreed());
    }S

    [Fact]
    public void HasDietTest(){
        Assert.Equal("Seeds", Parrot1.GetDiet());
    }
}