using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class gameManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public Transform[] spawnPoints;
    public Transform bulletSpawn;
    public GameObject bulletPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("spawnEnemies", 3, 2);
    }


    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnBullet();
        }

    }


    void spawnEnemies()
    {
        int index = Random.Range(0, spawnPoints.Length);     
        Vector3 spawnPositions = spawnPoints[index].position;
        int enemyIndex = Random.Range(0, enemyPrefab.Length);
        GameObject enemies = Instantiate(enemyPrefab[enemyIndex], spawnPositions, Quaternion.identity);
        enemies.GetComponent<enemyMovement>().speed = Random.Range(-3.0f, -6.0f);
    }

    void spawnBullet()
    {
        Vector3 spawnPositions = bulletSpawn.position;
        GameObject bullet = Instantiate(bulletPrefab, spawnPositions , Quaternion.identity);
        bullet.GetComponent<bulletMovement>().speed = 5.0f;
    }

}

    