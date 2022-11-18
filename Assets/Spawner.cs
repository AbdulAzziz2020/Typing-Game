using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spot;
    public float timeBetweenSpawn = 5f;
    private float timeSpawn;

    private void Update()
    {
        if (timeSpawn > 0)
        {
            timeSpawn -= Time.deltaTime;
        }
        else
        {
            int ran = Random.Range(0, spot.Length);
            Instantiate(enemyPrefab, spot[ran].position, Quaternion.identity);
            timeSpawn = timeBetweenSpawn;
        }
    }
}
