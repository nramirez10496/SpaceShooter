using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] private float bulletSpeed = 10f;//how fast bullet flies

    [Range(1, 10)]
    [SerializeField] private float lifeTime = 3f;// how long bullet is live(on screen)

    private Rigidbody2D rb;//rigid body 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime); //what and when to destroy
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = transform.up * bulletSpeed; //bulet flies forward until destroyed
        //OnTriggerEnter2d(Collider2D //add trigger enter 
        
    }
}
