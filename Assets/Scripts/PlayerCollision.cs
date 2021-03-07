using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject GOText;
    public GameObject ResText;

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Enemy Type2") {
            movement.enabled = false;

            GameObject[] spawners = GameObject.FindGameObjectsWithTag("Spawner");
            foreach(GameObject spawner in spawners)
                GameObject.Destroy(spawner);

            GameObject player = GameObject.FindWithTag("Player");
            GameObject.Destroy(player);

            


            Instantiate(GOText, GOText.transform.position, GOText.transform.rotation);
            Instantiate(ResText, ResText.transform.position, ResText.transform.rotation);
        }
    }
}
