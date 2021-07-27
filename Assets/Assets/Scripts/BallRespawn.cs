using UnityEngine;

public class BallRespawn : MonoBehaviour
{
    
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        collision.GetComponent<BallMovement>().Respawn();
             
    }

}
