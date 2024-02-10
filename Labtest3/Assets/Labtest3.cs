using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
//Sheldon Pacheco
//101350324
public class Labtest3 : MonoBehaviour
{
    List<int> list = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        intlist(list, 10);
        print(list);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void intlist(List<int> l, int size)
    {

        for (int i = 0; i < size; i++)
        {
            l.Add(Random.Range(1, 101));
        }

    }
    void printlist(List<int> l)
    {
        foreach (int i in l)
        {
            Debug.Log(i);
        }
    }
}
