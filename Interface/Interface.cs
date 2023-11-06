using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IExample
{

}
abstract class CAbstractClass
{
    public abstract int z { get; set; }
    abstract public void x();
    abstract public bool d { get; set; }
}
public class Interface : MonoBehaviour
{
    IExample _example = null;
}




































public abstract partial class Character
{
    public virtual int health { get; set; }
    protected int attackDamage;
    public abstract int durability { get; set; }


}
public abstract partial class Character
{
    public void TakeDamage(int damage)
    {
        health -= damage;

    }


}
public abstract partial class Character
{
    public Character(int health, int attackDamage, int durability)
    {
        this.health = health;
        this.attackDamage = attackDamage;
        this.durability = durability;
    }
}

public class Player : Character
{
    public Player(int health, int attackDamage, int durability)
        : base(health, attackDamage, durability)
    {

    }

    public override int durability { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public class Enemy : Character
    {
        public Enemy(int health, int attackDamage, int durability)
            : base(health, attackDamage, durability)
        {

        }

        public override int durability { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}




