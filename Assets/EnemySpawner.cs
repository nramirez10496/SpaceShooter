//Enemy Spawner
//Spawns enemy at a certain interval
//Placement should be random within bounds of the screen

using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;

    float timeSinceLastSpawn = 0;
    [SerializeField] float timeBetweenSpawn = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpawnTime();

    }

    public void SpawnEnemy()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-8, 8), 6, 0);//spawn at this position (top of screen)
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
        timeSinceLastSpawn = 0;
    }


    public void SpawnTime()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn > timeBetweenSpawn)
        {
            SpawnEnemy();
        }
    }

}
