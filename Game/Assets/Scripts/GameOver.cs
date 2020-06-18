using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void Update()
    {
        if(transform.parent.position.z < -12)
        {
            Destroy(transform.parent.gameObject);
            ScoreScript.scoreValue += 100;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(Application.loadedLevel);
        ScoreScript.scoreValue = 0;
    }
}
