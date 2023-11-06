using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ShallowCopy : MonoBehaviour
{
    public class ShallowClass
    {

        //Example 1
        public int MyProperty { get; set; }
    }


    public void ShallowCopyExamples1()
    {
        //Shallow Copy
        //Example 1
        //We can control value from different references as you see.
        ShallowClass Episode1 = new ShallowClass();
        ShallowClass Epiosde2 = Episode1;
        ShallowClass Episode3 = Epiosde2;
        Episode3.MyProperty = 25;
        Debug.Log(Episode1.MyProperty);


    }
    //----------------------------------------------------------------------------------------------------------------
    public class ShallowClass2
    {

        //Example 2
        
    }
    public void ShallowCopyExamples2()
    {
        //Shallow Copy
        //Example 2
        //we can change refere of object that already refered as a null or different reference.
        ShallowClass Example1 = null;
        ShallowClass Example2 = new ShallowClass();
        ShallowClass Example3 = Example2;
        Example1 = Example3;

    }
    
    private void Update()
    {
        ShallowCopyExamples1();
    }
}




