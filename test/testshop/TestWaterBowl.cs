using Xunit;

public class TestWaterBowl{
    WaterBowl bowl = new WaterBowl(50);

    [Fact]
    public void BowlHasWater(){
        Assert.Equal(50, bowl.GetVolume());
    }

    [Fact]
    public void CanFillBowl(){
        bowl.FillBowl();
        Assert.Equal(100, bowl.GetVolume());
    }

    [Fact]
    public void CanEmptyBowl(){
        bowl.EmptyBowl();
        Assert.Equal(0, bowl.GetVolume());
    }

    [Fact]
    public void CanAddToBowl(){
        bowl.AddWaterToBowl();
        Assert.Equal(60, bowl.GetVolume());
    }

    [Fact]
    public void CanRemoveFromBowl(){
        bowl.RemoveWaterFromBowl();
        Assert.Equal(40, bowl.GetVolume());
    }
}