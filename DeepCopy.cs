using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeepCopy : MonoBehaviour
{
    public static int a = 5;
    public int b = a;


    void CheckValues()
    {


        if (Input.GetKey(KeyCode.B))
        {
            a = 10;
        }
        // else if (Input.GetKeyDown(KeyCode.C))
        // {
        //     b = a;
        //     Debug.Log("b değişti" + b + "=");
        // }
        Debug.Log("a" + "=" + a);
        Debug.Log("b" + "=" + b);
        Console.WriteLine(a);
    }
    private void Update()
    {
        CheckValues();
    }
}
