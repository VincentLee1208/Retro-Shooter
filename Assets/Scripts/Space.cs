using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Space : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space")) {
            ScoreScript.scoreValue = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
