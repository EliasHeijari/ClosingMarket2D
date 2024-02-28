using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OstacleSpawn : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;

    float spawnCounter;
    float timeToSpawn = 0;
    private void Update() {
        spawnCounter += Time.deltaTime;
        if (spawnCounter > timeToSpawn)
        {
            spawnCounter = 0;
            timeToSpawn = Random.Range(0f, 5f);

            SpawnObstacle();
        }
    }

    private void SpawnObstacle()
    {
        GameObject obstacle = Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
        Destroy(obstacle, 10f);
    }
}
