using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GAME1001;
//Sheldon Pacheco
public class MyObject
{
    private string name;
    private int power; //0 to 100

    private static int cnt = 0;
    public MyObject(string name="object", int power=100) { 
        this.name = name;
        if (power >= 0 && power <= 100)
        {
            this.power = power;
        }
        cnt++;
    }
    public virtual string MakeSound()
    {
        return "crack";
    }
    public static MyObject CreateFlower()
    {
        return new MyObject("Flower", 100);
    }
    public static MyObject CreateTree()
    {
        return new MyObject("Tree", 90);
    }
    public string GetName()
    { 
        return this.name; 
    }
    public int Power() { 
        return this.power; 
    }
    public void SetPower(int newPower) { 
        if(newPower >= 0 && newPower <= 100) { 
            this.power = newPower;
        } else
        {
            this.power = 0;
        }
    }
    public void SetName(string newName)
    {
        this.name = newName;
    }
    public string ToString() { 
        return "name: "+this.name+"\n power: "+this.power.ToString()+"\n items created: "+MyObject.cnt.ToString(); 
    }
    public static int GetCount() { 
        
        return cnt; 
    }

}
//MyObject o = new MyObject("wand", 80);
