using System;
using System.Collections;

public class PetShop{
    ArrayList pets;
    
    public PetShop(){
        this.pets = new ArrayList();
    }

    public int StockCount => pets.Count;
// fat arrow is a 'Lambda' function
    public void AddToStock(Pet pet){
        pets.Add(pet);
    }

    public void RemoveFromStock(Pet pet){
        pets.Remove(pet);
    }

}