using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoudItem : MyObject
{
    private string sound;

    public LoudItem( string name= "LoudNoName", int power = 100, string sound = "BANG") : base(name, power)
    {
        this.sound = sound;
    }
    public override string MakeSound()
    {
        return this.sound;
    }
}
public class LaughItem : LoudItem
{
    public LaughItem(string name = "LaughNoName", int power = 100, string sound = "HAHAAHAHAHAHAHAHAHHAHAHA") : base(name, power,sound)
    {

    }
}
