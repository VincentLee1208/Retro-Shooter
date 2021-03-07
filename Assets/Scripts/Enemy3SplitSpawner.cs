using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3SplitSpawner : MonoBehaviour
{
    public GameObject Enemy3SplitPrefab;

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Bullet") {
            Debug.Log("collided");

            Vector2 spawn1 = gameObject.transform.position + new Vector3(0.0f, 0.0f, 5.0f);
            Vector2 spawn2 = gameObject.transform.position - new Vector3(0.0f, 0.0f, 5.0f);

            Instantiate(Enemy3SplitPrefab, spawn1, Quaternion.identity);
            Instantiate(Enemy3SplitPrefab, spawn2, Quaternion.identity);
        }
    }
}
