using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int coin;
    public GameObject enemyPrefab;
    public GameObject alliesPrefab;
    public GameObject towerPrefab;
    void Start()
    {
        StartCoroutine(StartEnemyWave());
    }

    IEnumerator StartEnemyWave()
    {
        yield return new WaitForSeconds(5);
        GetEnemy();
    }

    public  GameObject GetEnemy()
    {
        GameObject prefabInstance = Instantiate(enemyPrefab);
        prefabInstance.transform.position = new Vector3(6, 1, 0);
        return prefabInstance;
    }
    
    public GameObject GetTower()
    {
        GameObject prefabInstance = Instantiate(towerPrefab);
        prefabInstance.transform.position = new Vector3(0, 1, 1);
        return prefabInstance;
    }
    
    public GameObject GetAlliedSoldier()
    {
        GameObject prefabInstance = Instantiate(alliesPrefab);
        prefabInstance.transform.position = new Vector3(4, 1, 1);
        
        return prefabInstance;
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetTower();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            GetAlliedSoldier();
        }
    }
}
