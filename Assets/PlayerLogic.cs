using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    //player variables
    [SerializeField] int moveSpeed = 100;
    //lazer variables
    [SerializeField] private GameObject lazerPrefab;//lazer
    [SerializeField] private Transform firingPoint;// point lazer will fire from
    /*[Range 0.1f, 1f]
    [SerializeField] private float firingRate = 0.5f;//rate for firing*/


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();

        if (Input.GetKeyDown(KeyCode.Space))//if space bar pressed shoot
        {
            shootLazer();
        }
    }


    void movePlayer()
    { 
        float horizontalInput = Input.GetAxis("Horizontal");//left hor input is -1 and right = 1 
        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);// input deltatyime smooths things out 

    }

    void shootLazer()
    {
        Instantiate(lazerPrefab, firingPoint.position, firingPoint.rotation);
    }
}
