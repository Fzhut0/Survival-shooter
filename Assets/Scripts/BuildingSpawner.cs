using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> buildingSpawn;


    int buildingAmount = 3;


    private void Start()
    {



    }

    private void Update()
    {


        StartCoroutine("BuildingAmountCheck");

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

        Vector3 overlapBoxSize = new Vector3(150, 150, 150);
        Collider[] buildingColliders = new Collider[5];
        int buildingsToCheck = Physics.OverlapBoxNonAlloc(spawnPos, overlapBoxSize, buildingColliders, spawnRotation, 7);



        if (buildingsToCheck == 0)
        {
            Instantiate(buildingSpawn[Random.Range(0, buildingSpawn.Count)], spawnPos, spawnRotation);
        }
        else
        {
            return;
        }

    }

    IEnumerator BuildingAmountCheck()
    {
        GameObject[] buildings = GameObject.FindGameObjectsWithTag("Building");

        if (buildings.Length < buildingAmount)
        {
            SpawnBuilding();
        }

        yield return new WaitForSeconds(1);

    }
}








