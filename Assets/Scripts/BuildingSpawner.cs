using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> buildingSpawn;

    int buildingAmount = 4;


    private void Start()
    {

        for (int i = 0; i < buildingAmount; i++)
        {
            SpawnBuilding();
        }

    }

    private void Update()
    {

        /* if (Input.GetKey(KeyCode.G))
         {
             SpawnBuilding();
         }
        */
    }

    void SpawnBuilding()
    {
        Vector3 spawnPos = new Vector3(Random.Range(50, 900f), 0, Random.Range(50, 900f));

        Instantiate(buildingSpawn[Random.Range(0, buildingSpawn.Count)], spawnPos, Quaternion.identity);


    }
}
