using System;

public abstract class Pet {
    string name;
    string breed;
    string diet;

    public Pet(string nameOfPet, string breedName, string petDiet){
        name = nameOfPet;
        breed = breedName;
        diet = petDiet;
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
}