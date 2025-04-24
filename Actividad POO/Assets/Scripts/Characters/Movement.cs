using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private PlayerInput playerInput;
    private Rigidbody rb;

    [SerializeField] private float speed;
    void Start()
    {
        playerInput = gameObject.GetComponent<PlayerInput>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Move()
    {
        Vector2 direction = playerInput.actions.FindAction("Move").ReadValue<Vector2>();
        rb.linearVelocity = new Vector3(direction.x, 0 , direction.y) * speed * Time.deltaTime;
    }
}
