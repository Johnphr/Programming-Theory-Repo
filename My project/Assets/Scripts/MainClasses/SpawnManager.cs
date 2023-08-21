using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float SpawnRange { get; set; }
    private float spawnCount = 3;
    [SerializeField] GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRange = 8f;
        InvokeRepeating("SpawnEnemies", 0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemies()
    {
        for (int i = 0; i <= spawnCount; i++)
        {
            Instantiate(enemyPrefab, new Vector3(Random.Range(-SpawnRange, SpawnRange), 4.75f, 0), enemyPrefab.transform.rotation);
        }
        spawnCount++;
    }
}
