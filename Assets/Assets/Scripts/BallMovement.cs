using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float speed = 10.0f;
    
    Rigidbody2D rigibody;

    private void Awake()
    {
        rigibody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Respawn();
    }


    public void Respawn()
    {
        transform.position = Vector2.zero;
        rigibody.velocity = Random.insideUnitCircle.normalized * speed;
    }

    
}
