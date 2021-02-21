using System;

public abstract class Pet {
    string name;
    string breed;
    string diet;

    public Pet(string name, string breed, string diet){
        this.name = name;
        this.breed = breed;
        this.diet = diet;
    }
    public string GetName(){
        return name;
    }

    public string GetBreed(){
        return breed;
    }

    public string GetDiet(){
        return diet;
    }

    public string MakeNoise(String pet, String noise){
        return pet + " says " + noise;
    }
}