using UnityEngine;

public class Darkspearfunction : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]private float speed;
    private Vector3 moveDirection;
    [SerializeField]private float timer;

    [SerializeField] private Abilityscriptable abilityData;

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
            other.GetComponent<Enemy>().lifesystem.TakeDamage(abilityData.abilityValue);
            Destroy(gameObject);
        }
        else if (!other.CompareTag("Player")) 
        {
            Destroy(gameObject);
        }
    }
}
