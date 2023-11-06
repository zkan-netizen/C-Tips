using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritanceTwo : MonoBehaviour
{
    private void Start()
    {
        A a = new();
        B b = new();
        C c = new();
        D d = new();
    }
    class A
    {
        public A()
        {
            Debug.Log($"{nameof(A)}");
        }
    }
    class B : A
    {
        public B()
        {
            Debug.Log($"{nameof(B)}");
        }
    }
    class C : B
    {
        public C()
        {
            Debug.Log($"{nameof(C)}");
        }
    }
    class D : C
    {
        public D()
        {
            Debug.Log($"{nameof(D)}");
        }
    }
}
