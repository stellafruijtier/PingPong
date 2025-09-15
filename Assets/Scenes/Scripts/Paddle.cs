using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public int id;                // 1 = left (W/S), 2 = right (Up/Down)
    public float moveSpeed = 8f;


    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
        GameManager.instance.onReset += ResetPosition;
    }


    private void ResetPosition()
    {
        transform.position = startPosition;
    }


    private void Update()
    {
        float movement = ProcessInput();
        Move(movement);
    }

    float ProcessInput()
    {
        switch (id)
        {
            case 1: return Input.GetAxisRaw("MovePlayer1");
            case 2: return Input.GetAxisRaw("MovePlayer2");
            default: return 0f;
        }
    }

    void Move(float movement)
    {
        Vector2 v = rb2d.linearVelocity;  // not linearVelocity
        v.x = 0f;
        v.y = moveSpeed * movement;
        rb2d.linearVelocity = v;
    }
}
