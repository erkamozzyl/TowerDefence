using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Unit unit;
    public new string  name;
    public int health;
    public int attack;
    public bool inAttack;
    public Image healthBar;
    public string attackType; 
    void Start()
    {
        name = unit.name;
        health = unit.health;
        attack = unit.attack;
        healthBar = unit.healthBar;
        attackType = unit.attackType;
        Debug.Log("Enemy Object Created. "  + name);
    }

}
