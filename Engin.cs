using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class Engin : MonoBehaviour
{
    public class Engineer : Inheritance
    {

        public void Start()
        {
            Staff Engineer = new Staff()
            {
                Name = "asd",
                Surname = "ZASD"
            };
            Debug.Log(Engineer.Name);
            Debug.Log(Engineer.Surname);
            Engineer.Name = "Özkan";
            Engineer.Surname = "Koca";
        }
    }

}
