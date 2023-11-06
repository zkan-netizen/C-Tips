using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StaticConstructor : MonoBehaviour
{
    void Start()
    {
        new StaticConstructor();
        // new StaticConstructor();
    }
    public StaticConstructor()
    {
        //This is what happening while not static.
        //It is the method to be triggered when creating object from this class.
        Debug.Log("Constructor triggered.");

    }
    static StaticConstructor()
    {
        //It is the first method to be triggered when creating a first object from this class.
        Debug.Log("StaticConstructor triggered.");

    }

    //This is the difference between static and non-static constructor.
}
