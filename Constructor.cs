using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Constructor : MonoBehaviour
{

    // The first method that triggered by compiler.
    void Start()
    {

        new MyClass();
        // new Example();
        // new Example();
        // new Example();
        new Example().X();
    }

    // class MyClass
    // {
    //     public MyClass() : this(5, "c")
    //     {

    //         Debug.Log("deneme1");
    //     }
    //     public MyClass(int a) : this()
    //     {
    //         Debug.Log("deneme2");
    //     }
    //     public MyClass(int a, string b)
    //     {
    //         Debug.Log("deneme3");
    //     }
    // }

    class MyClass
    {
        public MyClass() : this(5)
        {

            Debug.Log("deneme1");
        }
        public MyClass(int a)
        {
            Debug.Log("deneme2");
        }
        public MyClass(int a, string b)
        {
            Debug.Log("deneme3");
        }
    }

    public class Example
    {
        public Example() { Debug.Log("Object created by constructor method."); }
        public void X()
        {
            Debug.Log("Object created by ''X'' method.");
        }
    }
}
