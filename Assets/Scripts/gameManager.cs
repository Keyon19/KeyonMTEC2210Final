using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemies", 3, 2);
    }


    // Update is called once per frame
    void Update()
    {

    }


    void spawnEnemies()
    {
        int index = Random.Range(0, spawnPoints.Length);
        
        Vector3 spawnPositions = spawnPoints[index].position;
        
        int enemyIndex = Random.Range(0, enemyPrefab.Length);

        GameObject enemies = Instantiate(enemyPrefab[enemyIndex], spawnPositions, Quaternion.identity);

        enemies.GetComponent<enemyMovement>().speed = Random.Range(-2.0f, -6.0f);
    }



}

    