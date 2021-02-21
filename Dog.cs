using System;

class Dog {
    private string breed;

    public Dog(string breedName) {
        breed = breedName;
    }

    public string GetBreedName(){
        return breed;
    }

    public string Bark(){
        return "Woof woof!";
    }
}