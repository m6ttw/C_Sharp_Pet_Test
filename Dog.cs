using System;

public class Dog : Pet {

    public Dog(string nameOfPet, string breedName, string petDiet) : base(nameOfPet, breedName, petDiet) {
    }

    public string Bark(){
        return "Woof woof!";
    }
}