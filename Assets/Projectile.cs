//Projectile
//Moves upward
//Destroyed after a few seconds

using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 10f;//how fast bullet flies

    [SerializeField] private float lifeTime = 3f;// how long bullet is live(on screen)

    private Rigidbody2D lazerRB;//laser rigid body 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DestroyLazer();//cal DestroyLazer  
    }

    // Update is called once per frame
    void Update()
    {
        MoveLazer();//callMoveLazer
    }

    void MoveLazer ()
    {
        lazerRB.linearVelocity = transform.up * bulletSpeed; //bulet flies forward until destroyed        
    }

    void DestroyLazer()
    {
        lazerRB = GetComponent<Rigidbody2D>();//get lazer
        Destroy(gameObject, lifeTime); //what (lazer) and when to destroy
    }

}
