using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 101350324
 * Sheldon Pacheco  
 * Lab1 
 */
public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi!!!!!!!!!!");
        int mynum = 1;
        Debug.Log("this is my number: "+mynum);
        int x = 1, y = 3, z = x + y;
        Debug.Log("x+y=" + z);
        Debug.Log("x*y"+ (x*y));
        Debug.Log(x/y + x%y);
        float f = 1.234f, f2 = 2.3f, r = f / f2; ;
        Debug.Log(r);

        string s1 = "s1", s2 = "s2"; ;
        Debug.Log(s1+s2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
