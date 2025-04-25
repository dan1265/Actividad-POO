using UnityEngine;

public class Holylightfunction : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]private float speed;
    private Vector3 moveDirection;
    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
        moveDirection = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {

        rb.linearVelocity = moveDirection * speed;
    }
}
