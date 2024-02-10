using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class LabEx7 : MonoBehaviour
{

    List<int> list = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        intlist(list, 10);
        list.Sort();
        printlist(list);
        Debug.Log(isSorterd(list));
        Debug.Log(hasConditionElement(list, (x)=> x>=100));

        int a=10,b=20;
        Debug.Log("Swap before outside");
        Debug.Log(a + ", " + b);
        swap(ref a,ref b);
        Debug.Log("Swap after outside");
        Debug.Log(a + ", " + b);

        string s = "";
        int.TryParse(s,out a);
    }
    bool isG10(int x)
    {
        return (x >= 10);
    }
    // Update is called once per frame
    void Update()
    {
        //return;
    }
    bool hasLargerElements(List<int> l, int x)
    {
        for (int i = 0; i < l.Count; i++)
        {
            if (l[i] >= x)
            {
                return true;
            }
        }
        foreach (int i in l)
        {
            if (i >= x)
            {
                return true;
            }
        }
        return false;


    }

    bool hasConditionElement(List<int> l, Func<int, bool> condition)
    {
        foreach (int x in l)
        {
            if (condition(x))
            {
                return true;
            }
        }
        return false;
    }
    int find(List<int> l, int x)
    {
        for (int i = 0; i < l.Count; i++)
        {
            if (l[i] == x)
            {
                return i;
            }
        }
        return -1;
    }
    bool isSorterd(List<int> l)
    {
        for (int i = 1; i < l.Count; i++)
        {
            if (l[i - 1]> l[i])
            {
                return false;
            }
        }
        return true;
    }
    void printlist(List<int> l)
    {
        foreach (int i in l)
        {
            Debug.Log(i);
        }
    }
    void intlist(List<int> l, int size)
    {

        for(int i = 0; i < size; i++)
        {
            l.Add(Random.Range(1,101));
        }
  
    }
    int add(int a, int b)
    {
        a = 1000;
        return a + b; 
    
    }
    void swap(ref int a, ref int b)
    {
        Debug.Log("Swap before");
        Debug.Log(a + ", " + b);
        int t= a;
        a = b;
        b = t;
        Debug.Log("Swap after");
        Debug.Log(a + ", " + b);
    }
}
