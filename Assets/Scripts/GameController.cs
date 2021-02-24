using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int coin;
    void Start()
    {
        StartCoroutine(StartEnemyWave());
    }

    IEnumerator StartEnemyWave()
    {
        yield return new WaitForSeconds(5);
        GetEnemy();
    }

    public void GetEnemy()
    {
        Debug.Log("Enemy object created");
    }
}
