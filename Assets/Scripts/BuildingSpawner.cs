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
         * actual code which will be used to spawn objects at the start of level
         * 
        for (int i = 0; i < buildingAmount; i++)
        {
            SpawnBuilding();
        }
        */
    }

    private void Update()
    {

        // Placeholder function for testing purposes

        if (Input.GetKey(KeyCode.G))
        {
            SpawnBuilding();
        }

    }

    void SpawnBuilding()
    {
        Vector3 spawnPos = new Vector3(Random.Range(200, 800), 100, Random.Range(200, 900));

        Ray checkHeight = new Ray(spawnPos, Vector3.down);
        RaycastHit actualHeight;

        Physics.Raycast(checkHeight, out actualHeight, Mathf.Infinity);

        float terHeight = Terrain.activeTerrain.SampleHeight(actualHeight.point) + transform.position.y;


        spawnPos.y = terHeight;

        Quaternion spawnRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);

        Instantiate(buildingSpawn[Random.Range(0, buildingSpawn.Count)], spawnPos, spawnRotation);

    }


}
