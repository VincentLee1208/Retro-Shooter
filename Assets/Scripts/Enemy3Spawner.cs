﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Spawner : MonoBehaviour
{
    public GameObject Enemy3Prefab;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn) {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-20.1f, 19.9f);
            randY = Random.Range(-12.0f, 12.0f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(Enemy3Prefab, whereToSpawn, Quaternion.identity);
        }
    }
}
