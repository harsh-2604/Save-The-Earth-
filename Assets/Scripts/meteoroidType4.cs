using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoroidType4 : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;
    public int numberOfPrefabsToSpawn = 2;
    public float gapBetweenPrefabs = 2.0f; 
    void OnDestroy()
    {
        SpawnRandomPrefabs();
    }

    void SpawnRandomPrefabs()
    {
        if (prefabsToSpawn.Length == 0)
        {
            Debug.LogError("No prefabs assigned to spawn.");
            return;
        }

        for (int i = 0; i < numberOfPrefabsToSpawn; i++)
        {
            int randomIndex = Random.Range(0, prefabsToSpawn.Length);
            Vector3 spawnPosition = transform.position + new Vector3(i * gapBetweenPrefabs, 0, 0);
            Instantiate(prefabsToSpawn[randomIndex], spawnPosition, Quaternion.identity);
        }
    }
}
