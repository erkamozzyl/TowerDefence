using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public Unit unit;
    public new string name;
    public int attack;
    public RaycastHit ray;
    public string attackType;
    void Start()
    {
        name = unit.name;
        attack = unit.attack;
        attackType = unit.attackType;
        Debug.Log("Tower Object Created. "  + name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
