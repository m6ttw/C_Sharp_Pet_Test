using Xunit;

public class TestClass{
    [Fact]
    public void PassingAddTest(){
        Assert.Equal(4, Program.Add(2, 2));
    }

    [Fact]
    public void PassingMultiplyTest(){
        Assert.Equal(10, Program.Multiply(5, 2));
    }

    [Fact]
    public void PassingIsOddTest(){
        Assert.Equal(true, Program.IsOdd(3));
    }

    [Fact]

    public void PassingStringTest(){
        Assert.Equal("Hello", Program.SayHello());
    }
}
