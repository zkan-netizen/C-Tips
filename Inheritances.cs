using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritances : MonoBehaviour
{
    private void Start()
    {
        // A a = new();
        // B b = new();
        // C c = new();
        D d = new();
        Console.WriteLine("asd");
    }
    class A
    {
        public A()
        {
            Debug.Log($"{nameof(A)} object created by compiler.");
        }
    }
    class B : A
    {
        public B()
        {
            Debug.Log($"{nameof(B)} object created by compiler.");
        }
    }
    class C : B
    {
        public C()
        {
            Debug.Log($"{nameof(C)} object created by compiler.");
        }
    }
    class D : C
    {
        public D()
        {
            Debug.Log($"{nameof(D)} object created by compiler.");
        }
    }
}
