using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Unit", menuName = "Unit")]
public class Unit : ScriptableObject
{
  public new string name;
  public int health;
  public int attack;
  public string attackType;
  public Image healthBar;

  public void Attack()
  {
    Debug.Log("Attack");
  }
}
