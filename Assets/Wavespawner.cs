using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wavespawner : MonoBehaviour{

    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countDown = 2f;

    private int waveNumber = 1;


    void Update()
    {
        if (countDown <= 0f)
        {
            SpawnWave();
            countDown = timeBetweenWaves;
        }

        countDown  -= Time.deltaTime;
    }

    void SpawnWave()
    {
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
        }

        waveNumber++;
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
