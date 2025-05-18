using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float timer;
    [SerializeField] private float fireRate;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private Transform shootPoint;

    private void Start()
    {
        timer = fireRate;
    }
    private void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            GameObject insBullet = Instantiate(bullet, shootPoint.position, Quaternion.identity);
            Rigidbody rB = insBullet.GetComponent<Rigidbody>();
            rB.AddForce(shootPoint.forward * bulletSpeed);
            timer = fireRate;
        }
    }
}
