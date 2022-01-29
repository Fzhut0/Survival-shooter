using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> buildingSpawn;

    int buildingAmount = 4;


    private void Start()
    {
        /*
        for (int i = 0; i < buildingAmount; i++)
        {
            SpawnBuilding();
        }
        */
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.G))
        {
            SpawnBuilding();
        }

    }

    void SpawnBuilding()
    {
        float terHeight = Terrain.activeTerrain.SampleHeight(transform.localPosition);
        Vector3 spawnPos = new Vector3(Random.Range(200, 800), terHeight, Random.Range(200, 900));
        Quaternion spawnRotation = Quaternion.Euler(0, Random.Range(0, 90), 0);

        Instantiate(buildingSpawn[Random.Range(0, buildingSpawn.Count)], spawnPos, spawnRotation);


    }
}
