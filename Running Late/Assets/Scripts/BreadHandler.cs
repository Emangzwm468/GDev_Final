using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BreadHandler : MonoBehaviour
{
    [SerializeField] GameObject Bread;
    [SerializeField] float xMax;
    [SerializeField] float xMin;
    [SerializeField] float yMax;
    [SerializeField] float yMin;
    [SerializeField] float timeBetweenSpawns;
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawns;
        }
    }

    void Spawn()
    {
        float x = Random.Range(xMin, yMax);
        float y = Random.Range(yMin, yMax);

        Instantiate(Bread, transform.position + new Vector3(x, y, 0), transform.rotation);
    }
}
