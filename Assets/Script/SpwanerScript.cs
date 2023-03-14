using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanerScript : MonoBehaviour
{

    public float spawnTimePeriod = 1f;

    public GameObject hexagonPrefab;

    public float nextTimeToSpawn = 0f;

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextTimeToSpawn)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnTimePeriod;
        }
    }
}