using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance
{
    private void Start()
    {
        Manager manager = new Manager();
        manager.Name = "Özkan";
        manager.MyProperty = 10;
        Staff staff = new();
        staff.MaritalStatus = true;
    }
    public class Staff
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public bool MaritalStatus { get; set; }
    }
    class Accountant : Staff
    {
        public int MyProperty { get; set; }
    }
    class Developer : Accountant
    {
        public Developer()
        {

        }
    }
    class Manager : Developer
    {
        public Manager() : base()
        {

        }
    }

}
