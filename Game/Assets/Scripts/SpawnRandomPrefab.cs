using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomPrefab : MonoBehaviour
{
    public GameObject obstacle1, obstacle2, obstacle3, obstacle4, obstacle5, obstacle6, obstacle7, obstacle8, obstacle9;

    public float spawnRate;

    float nextSpawnTime = 0f;

    int randomizer;

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            randomizer = Random.Range(1, 10);

            switch(randomizer)
            {
                case 1:
                    Instantiate(obstacle1, obstacle1.transform.position, obstacle1.transform.rotation);
                    break;
                case 2:
                    Instantiate(obstacle2, obstacle2.transform.position, obstacle2.transform.rotation);
                    break;
                case 3:
                    Instantiate(obstacle3, obstacle3.transform.position, obstacle3.transform.rotation);
                    break;
                case 4:
                    Instantiate(obstacle4, obstacle4.transform.position, obstacle4.transform.rotation);
                    break;
                case 5:
                    Instantiate(obstacle5, obstacle5.transform.position, obstacle5.transform.rotation);
                    break;
                case 6:
                    Instantiate(obstacle6, obstacle6.transform.position, obstacle6.transform.rotation);
                    break;
                case 7:
                    Instantiate(obstacle7, obstacle7.transform.position, obstacle7.transform.rotation);
                    break;
                case 8:
                    Instantiate(obstacle8, obstacle8.transform.position, obstacle8.transform.rotation);
                    break;
                case 9:
                    Instantiate(obstacle9, obstacle9.transform.position, obstacle9.transform.rotation);
                    break;
            }

            nextSpawnTime = Time.time + spawnRate;
        }
    }
}
