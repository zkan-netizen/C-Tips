using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class IsExternalInit { } //This part launching for =>"Lambda Expression"
}
public class Properties : MonoBehaviour
{
    // MyClass myclass = new();
    void Start()
    {
        //Full Property
        // myclass.Age = 10;
        // //Prop Property
        // myclass.Name = "Nobody";
        // myclass.Name = "Nobody";
    }


    // ------------
    //Auto Property Initizialers
    //This property is readonly and giving value while creating.
    //You can use it without field because it has field has own it like "prop property" and also its pretty good about memory.
    //Auto properties cant be write only but can be readonly or read-write property.
    public string _Name { get; set; } = "Özkan";
    public string SurName { get; set; } = "Koca";
    public int _Age { get; set; } = 25;

    void Update()
    {

    }


    // ------------
    //Full Property
    int age;
    public int Age
    {
        get
        {
            return age / 2;
        }
        set
        {
            age = 10;
        }

    }
    // ------------
    //Prop Property
    // You can identify this property without field.This property has own its field.
    public string Name { get; set; }


    // ------------
    //Ref Readonly Returns
    //It is good for memory optimization and also it will be effective while design static structre;
    string brand = "Ferrari";
    public ref readonly string Brand => ref brand;

    // ------------
    //Computed Properties
    int s1 = 5;
    int s2 = 10;

    public int _addsomethingup
    {
        get
        {
            return s1 + s2;
        }
    }
    // ------------
    //Expression-Bodied Property
    //We are using lambda expression "=>" here.
    public string Gender => "Man";//In this way we create readonly prop.
    // ------------
    //Init Only Property
    //Value is only giving at begin.Can not change after give valute.
    public string ID { get; init; } = "RandomID";

}

public class MyClass    
{ // ------------
    //Full Property
    int age;
    public int Age
    {
        get
        {
            return age / 2;
        }
        set
        {
            age = 10;
        }

    }


    //     // ------------
    //     //Prop Property
    //     // You can identify this property without field.This property has own its field.
    //     public string Name { get; set; }






}
