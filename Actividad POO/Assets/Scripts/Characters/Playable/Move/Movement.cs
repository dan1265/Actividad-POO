using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private PlayerInput playerInput;
    private Rigidbody rb;

    [SerializeField] private float speed = 5f;
    [SerializeField] private float mouseSensitivity = 100f;
    private Vector2 lookInput;
    private float xRotation = 0f;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody>();

        playerInput.actions.FindAction("Look").performed += ctx => lookInput = ctx.ReadValue<Vector2>();
        playerInput.actions.FindAction("Look").canceled += ctx => lookInput = Vector2.zero;
    }

    private void Update()
    {
        Look();
        Move();
    }


    private void Move()
    {
        Vector2 inputDir = playerInput.actions.FindAction("Move").ReadValue<Vector2>();

        Transform cam = Camera.main.transform;
        Vector3 forward = cam.forward;
        Vector3 right = cam.right;

        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        Vector3 moveDirection = (forward * inputDir.y + right * inputDir.x).normalized;

        rb.linearVelocity = moveDirection * speed * Time.deltaTime;
    }

    private void Look()
    {
        Vector2 mouse = lookInput * mouseSensitivity * Time.deltaTime;

        xRotation -= mouse.y;
        xRotation = Mathf.Clamp(xRotation, -60f, 60f);

        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        transform.Rotate(Vector3.up * mouse.x);
    }
}
