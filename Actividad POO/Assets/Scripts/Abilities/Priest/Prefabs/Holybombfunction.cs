using UnityEngine;

public class Holybombfunction : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float force;
    private Vector3 moveDirection;
    [SerializeField] private float timer;

    [SerializeField] private GameObject zone;

    public float damage;
    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
        moveDirection = transform.forward + Vector3.up;
        rb.AddForce(moveDirection * force);
    }

    // Update is called once per frame
    void Update()
    {


        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            GameObject newZone = Instantiate(zone, transform.position, Quaternion.identity);
            newZone.transform.GetChild(0).GetComponent<Holybombzonefuction>().damage = damage;
            Destroy(gameObject);
        }
    }
}
