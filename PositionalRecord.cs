using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionalRecord : MonoBehaviour
{
    private void Start()
    {
        MyRecord m = new MyRecord("sdasd", "asdsad")
        {
            // Surname = "bzn",
            // Name = "zkn"
            surname = "bzn",
            name = "zkn"

        };


    }

    #region  Positional Record
    //We can use constructor and deconstructor through positional record  easly.
    record MyRecord(string name, string surname)
    {
        // public string Surname { get; set; }
        // public string Name { get; set; }
        
    }


    #endregion
}
