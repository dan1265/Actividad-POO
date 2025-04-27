using UnityEngine;

public class Holylightfunction : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]private float speed;
    private Vector3 moveDirection;
    [SerializeField]private float timer;
    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
        moveDirection = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = moveDirection * speed;

        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().Getdamage(20);
            Destroy(gameObject);
        }
        else if (!other.CompareTag("Player")) 
        {
            Destroy(gameObject);
        }
    }
}
