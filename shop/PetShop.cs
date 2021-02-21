using System;
using System.Collections;

public class PetShop{
    ArrayList pets;
    
    public PetShop(){
        pets = new ArrayList();
    }

    public int GetStockCount(){
        return pets.Count;
    }

    public void AddToStock(Pet pet){
        pets.Add(pet);
    }

    public void RemoveFromStock(Pet pet){
        pets.Remove(pet);
    }

}