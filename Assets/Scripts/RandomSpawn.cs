using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public int enemiesSpawned;
    public GameObject enemyPrefab; // Drag your enemy prefab into this slot
    public float spawnAreaWidth = 10f; // Set the width of the spawn area
    public float spawnAreaHeight = 5f; // Set the height of the spawn area
    public float spawnDistance;

    public void SpawnEnemy()
    {
        for (int i = 0;i< 5; i++)
        {
            // Generate a random x and y position within the spawn area
        float randomX = Random.Range(-spawnAreaWidth, spawnAreaWidth);
        float randomY = Random.Range(-spawnAreaHeight, spawnAreaHeight);
        
        Vector3 spawnPosition = new Vector3(randomX, 0, randomY); // Assuming 2D, modify for 3D

        // Instantiate the enemy at the random position
            GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        
        }
        
       
    }

    void Start()
    {
        SpawnEnemy();
    }
}
