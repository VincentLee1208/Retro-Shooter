using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public GameObject particles;

    void OnCollisionEnter2D(Collision2D collision) {

        if(collision.gameObject.tag == "Boundaries") {
            GameObject explosion = Instantiate(particles, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
        if(collision.gameObject.tag == "Enemy") {
            ScoreScript.scoreValue += 100;

            GameObject explosion = Instantiate(particles, gameObject.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }

        if(collision.gameObject.tag == "Enemy Type2") {
            ScoreScript.scoreValue += 50;

            GameObject explosion = Instantiate(particles, gameObject.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
