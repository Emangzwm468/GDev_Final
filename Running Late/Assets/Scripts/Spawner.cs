using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] obsPrefabs;
    [SerializeField] float spawnTime = 2f;
    [SerializeField] float spd = 1f; 

    [SerializeField] float obsSpawnTimer;

    private void Update()
    {
        SpawnLoop();
    }

    private void SpawnLoop()
    {
        obsSpawnTimer += Time.deltaTime;

        if(obsSpawnTimer >= spawnTime)
        {
            Spawn();
            obsSpawnTimer = 0f;
        }
    }

    private void Spawn()
    {
        GameObject spawnObs = obsPrefabs[Random.Range(0, obsPrefabs.Length)];

        GameObject spawnedObs = Instantiate(spawnObs, transform.position, Quaternion.identity);

        Rigidbody2D obsRD = spawnedObs.GetComponent<Rigidbody2D>();

        obsRD.velocity = Vector2.left * spd;
    }
}
