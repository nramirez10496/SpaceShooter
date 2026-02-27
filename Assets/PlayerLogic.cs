//PlayerLogic
//Attached to player sprite/prefab
//Basic left/right input
//Space bar to instantiate projectile

using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    //player variables
    [SerializeField] int moveSpeed = 10;//speed player moves at
    
    //lazer variables
    [SerializeField] private GameObject lazerPrefab;//lazer
    [SerializeField] private Transform firingPoint;// point lazer will fire from
    
    //firing variables
    [SerializeField] private float firingRate = 0.5f;//rate for firing
    private float fireTimer;//when user can shoot


    // Update is called once per frame
    void Update()
    {
        MovePlayer();//call MovePlayer

        FireTimer();//call FireTimer
    }


    void MovePlayer()
    { 
        float horizontalInput = Input.GetAxis("Horizontal");//left hor input is -1 and right = 1 to move player left and right from its position
        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);// input deltatyime smooths things out 

    }

    void ShootLazer()
    {
        Instantiate(lazerPrefab, firingPoint.position, firingPoint.rotation);//shoot lazer from point on ship
    }

    void FireTimer()
    {
        if (Input.GetKeyDown(KeyCode.Space) && fireTimer <= 0f)//if space bar pressed shoot can shoot only when timer is less or 0 
        {
            ShootLazer();//shoot
            fireTimer = firingRate;// reset fire rate when fired
        }
        else//after amount of time it will become less than 0 and allows shooting again
        {
            fireTimer -= Time.deltaTime;//countdown timer 
        }
    }

}
