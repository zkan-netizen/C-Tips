using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{

    void Start()
    {
        new MyClass1();
        MyClass1 m1 = new(); // We refered "MyClass1" to m1 as a new object.If u cant refere to objects like this you have to update your "Dot.net" version to 5.0 or higher versions.
    }
    static void Main()
    {
        new MyClass1();
        MyClass1 m2 = new();
        MyClass2 m3 = new();
        m3.MyProperty = 20;
    }

}
class MyClass1
{
    void Call()
    {
        Debug.Log("Called");
    }

}
class MyClass2
{

    public int MyProperty { get; set; }


}