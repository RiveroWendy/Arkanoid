using UnityEngine;

public class PaddleMovement : MonoBehaviour
{

    [SerializeField] float speed = 6.0f;

    Rigidbody2D rigibody;

    private float _input;

    private void Awake()
    {
        rigibody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        _input = Input.GetAxisRaw("Horizontal");
        
    }

    private void FixedUpdate()
    {
     
      rigibody.velocity = _input * speed * Vector2.right;
        
    }
}
