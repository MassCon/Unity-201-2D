using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointScript : MonoBehaviour
{
    [SerializeField] private GameObject[] pipePrefabs;
    private float pipeSpawnPeriod = 2f;     // 
    private float pipeCountdown;            //
    void Start()
    {
        pipeCountdown = pipeSpawnPeriod;
        SpawnPipe();
    }

    void Update()
    {
        pipeCountdown -= Time.deltaTime;
        if (pipeCountdown <= 0)
        {
            pipeCountdown = pipeSpawnPeriod;
            SpawnPipe();
        }
    }

    private void SpawnPipe()
    {
        var pipe = Instantiate(pipePrefabs[Random.Range(0, 3)]);
        pipe.transform.position = transform.position + Vector3.up * Random.Range(-1.42f, 1.36f);
    }
}
