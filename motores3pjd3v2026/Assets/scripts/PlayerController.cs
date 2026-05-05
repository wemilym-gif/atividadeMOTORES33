using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody rb;
    private Vector2 movement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Input System
    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector3 move = new Vector3(movement.x, 0.0f, movement.y);
        rb.AddForce(move * speed);
    }
}