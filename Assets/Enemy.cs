//Enemy
//Moves down
//Destroyed if collides with projectile
//Awards points when destroyed
//If goes below bottom of screen, game over

using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform enemyShip;//enemy ships to shoot down
    public float enemySpeed = 3f; //speed enemy will come down
    private Rigidbody2D enemyRB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();//get component
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMovement();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.CompareTag("Lazer"))//if the enemy was hit
        {
            Destroy(gameObject);//enemy is destroyed
            Destroy(collision.gameObject);//lazer is destroyed
        }
    }
     
    void EnemyMovement()
    {
        enemyRB.linearVelocity = Vector3.down * enemySpeed;//enemy will come down at set speed
    }
}
