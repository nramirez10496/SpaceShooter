//Enemy Spawner
//Spawns enemy at a certain interval
//Placement should be random within bounds of the screen

using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;

    float timeSinceLastSpawn = 0;
    [SerializeField] float timeBetweenSpawn = 2;

    // Update is called once per frame
    void Update()
    {
        SpawnTime();
    }

    public void SpawnEnemy()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-8, 8), 6, 0);//will spawn at this position (top of screen)
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);//spawn enemy at set position
        timeSinceLastSpawn = 0;//reset time to 0
    }


    public void SpawnTime()
    {
        timeSinceLastSpawn += Time.deltaTime;//add up time
        if (timeSinceLastSpawn > timeBetweenSpawn)//if set(2) seconds pass spawn another 
        {
            SpawnEnemy();
        }
    }

}
