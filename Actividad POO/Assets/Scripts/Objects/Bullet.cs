using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float despawnTimer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        despawnTimer -= Time.deltaTime;
        if (despawnTimer <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IDamageable damageable = other.GetComponent<IDamageable>();
            if (damageable != null)
            {
                damageable.TakeDamage(20);
            }
            Destroy(gameObject);
        }
        if (!other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
