using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractClasses : MonoBehaviour
{
    private void Start()
    {
        new MyClass2(5).W();
        MyClass2 _myclas = new(55);
        _myclas.W();
    }
    abstract class MyClass
    {
        public MyClass(int a)
        {

        }
        public void X()
        {

        }
        abstract public void W();
        abstract public int Q();
        abstract public int H { get; set; }

    }
    class MyClass2 : MyClass
    {


        public MyClass2(int a) : base(a)
        {
            Debug.Log("Constructor method");
        }

        public override int H { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public override int Q()
        {
            Debug.Log("Q method");
            throw new System.NotImplementedException();
        }

        public override void W()
        {
            Debug.Log("W method");
            // throw new System.NotImplementedException();
        }
    }

}
