using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items
{
    //Sheldon Pacheco
    private string name;
    private float cost;
    private int power;
    private string description;
    private bool owned;
    private int timesBought;

    public Items(string name = "name", float cost = 1000, int power = 100, string description = "description")
    {
        this.name = name;
        this.cost = cost;
        this.power = (power < 0) ? 0 : (power > 100) ? 100 : power;
        this.description = description;
        this.owned = false;
        this.timesBought=0;
    }

    public static Items PowerfulStaff()
    {
        return new Items("Powerful Staff", 1000, 100, "A very powerful staff that deals lots of damage.");
    }

    public static Items BasicSword()
    {
        return new Items("Basic Sword", 100, 25, "A basic sword.");
    }

    public static Items BasicBow()
    {
        return new Items("Basic Bow", 125, 35, "A basic bow.");
    }

    public static Items ManaPotion()
    {
        return new Items("1 Mana Potion", 50, 0, "Restores mana.");
    }

    public static Items HealthPotion()
    {
        return new Items("1 Health Potion", 25, 0, "Heals you.");
    }

    public string GetName()
    {
        return this.name;
    }

    public float GetCost()
    {
        return this.cost;
    }

    public int GetPower()
    {
        return this.power;
    }

    public string GetDescription()
    {
        return this.description;
    }

    public bool IsOwned()
    {
        return this.owned;
    }

    public void SetOwned(bool isOwned)
    {
        this.owned = isOwned;
    }
    public int TimesBought()
    {
        return ++this.timesBought;
    }

    public override string ToString()
    {
        return "Name: " + this.name + "\nCost: " + this.cost.ToString() + "\nPower: " + this.power.ToString() + "\nDescription: " + this.description + "\nOwned: " + this.owned.ToString();
    }
}