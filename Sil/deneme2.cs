using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData
{
    public int health;
    public int score;
}

public class Player : MonoBehaviour
{


    private void Start()
    {
        CharacterData PlayerData = new();
        // Player'a özgü kodlar burada
    }
}

public class Enemy : MonoBehaviour
{


    private void Start()
    {
        CharacterData EnemyData = new();
        // Enemy'ye özgü kodlar burada
    }
}