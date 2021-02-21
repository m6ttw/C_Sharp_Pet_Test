using System;

public class WaterBowl{
    int volume;

    public WaterBowl(int volume){
        this.volume = volume;
    }

    public int GetVolume(){
        return volume;
    }

    public void FillBowl(){
        volume = 100;
    }

    public void EmptyBowl(){
        volume -= volume;
    }

    public void AddWaterToBowl(){
        volume += 10;
    }

    public void RemoveWaterFromBowl(){
        volume -= 10;
    }

}